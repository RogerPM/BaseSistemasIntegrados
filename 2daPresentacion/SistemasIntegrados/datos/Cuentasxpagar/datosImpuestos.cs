using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Cuentasxpagar;

namespace datos.Cuentasxpagar
{
    public class datosImpuestos
    {
        public List<clsImpuestos> consulta()
        {

            try
            {
                List<clsImpuestos> lista = new List<clsImpuestos>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.Impuesto select w;
                foreach (var item in con)
                {
                    clsImpuestos clas = new clsImpuestos();
                    clas.IdImpuesto = item.IdImpuesto;
                    clas.Descripcion = item.Descripcion;
                    clas.FechaRegistro = item.FechaRegistro;
                    clas.IdEstado = item.Estado;
                    clas.Porcentaje = item.Porcentaje;
                    clas.IdUsuario = item.IdUsuario;
                    clas.IdEmpresa = item.IdEmpresa;
                    lista.Add(clas);

                }

                return lista;
            }

            catch (Exception)
            {
                return null;
            }

        }

        public void Modificar(clsImpuestos Imp)
        {
            using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
            {
                var x = (from q in ent.MedioPago where q.IdMedioPago == Imp.IdImpuesto select q).First();

                x.Descripcion = Imp.Descripcion;
                x.fechaRegistro = Imp.FechaRegistro;
                x.Estado = Imp.IdEstado;
                x.IdEmpresa = Imp.IdEmpresa;
                x.IdUsuario = Imp.IdUsuario;
                ent.SaveChanges();

            }
        }

        public clsImpuestos CalcularImp(int indice)
        {
            using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
            {
                var x = (from q in ent.Impuesto where q.IdImpuesto == indice select q).First();

                clsImpuestos impues = new clsImpuestos();
                impues.Porcentaje = x.Porcentaje;
                return impues;
            }
        }

        public Boolean Guardar(clsImpuestos Imp)
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
                        Estado = Imp.IdEstado,
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
        public Boolean Eliminar(clsImpuestos Imp)
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
