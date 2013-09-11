using System;
using System.Collections.Generic;
using System.Linq;
using clases.Seguridad;
using clases.Cuentasxpagar;

namespace datos.Cuentasxpagar
{
    public class datosImpuesto
    {
        public List<clsImpuesto> consulta()
        {

            try
            {
                List<clsImpuesto > lista = new List<clsImpuesto>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.Impuesto select w;
                foreach (var item in con)
                {
                    clsImpuesto clas = new clsImpuesto();
                    clas.IdImpuesto = item.IdImpuesto;
                    clas.Descripcion = item.Descripcion;
                     clas.Porcentaje =Convert.ToDouble (item.Porcentaje);
                    clas.FechaRegistro = (item.FechaRegistro);
                    clas.Estado = item.Estado;
                        clas.IdEmpresa = item.IdEmpresa;
                    clas.IdUsuario = item.IdUsuario;
               
                    lista.Add(clas);

                }
               
                return lista;
            }

            catch (Exception)
            {
                return null;
            }

        }

       
        public void Modificar(clsImpuesto Imp)
        {
            using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
            {
                var x = (from q in ent.Impuesto where q.IdImpuesto == Imp.IdImpuesto select q).First();

                x.Descripcion = Imp.Descripcion;
                x.FechaRegistro = Imp.FechaRegistro;
                x.Estado = Imp.Estado;
                x.Porcentaje = Convert.ToDecimal( Imp.Porcentaje);
                x.IdEmpresa = Imp.IdEmpresa;
                x.IdUsuario = Imp.IdUsuario;
                ent.SaveChanges();

            }
        }

        public Boolean Guardar(clsImpuesto Imp)
        {
            
            try
            {
                int id = getIdSiguiente();
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {

                    Impuesto impu = new Impuesto()
                    {
                        IdImpuesto = id,
                        Descripcion = Imp.Descripcion,
                        FechaRegistro = DateTime.Today, // Medio.FechaRegistro,
                      
                        Porcentaje=Convert.ToDecimal (Imp.Porcentaje),
                        Estado = Imp.Estado,
                        IdEmpresa = Imp.IdEmpresa,
                        IdUsuario = Imp.IdUsuario,

                    };
                    ent.AddToImpuesto(impu);
                    ent.SaveChanges();
                }

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public Boolean Eliminar(clsImpuesto Imp)
        {
            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {

                    var x = (from q in ent.Impuesto where q.IdImpuesto == Imp.IdImpuesto select q).First();

                    ent.DeleteObject(x);

                    ent.SaveChanges();

                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public int getIdSiguiente()
        {
            try
            {

                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                int x = ((from a in ent.Impuesto select a.IdImpuesto).Max()) + 1;

                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }

        }

    }
}
