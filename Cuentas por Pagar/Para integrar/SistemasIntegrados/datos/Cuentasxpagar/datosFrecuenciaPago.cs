using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Cuentasxpagar;
using clases.Seguridad;

namespace datos.Cuentasxpagar
{
    public class datosFrecuenciaPago
    {
        public List<clsFrecuencia> consulta()
        {

            try
            {
                List<clsFrecuencia> lista = new List<clsFrecuencia>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.FrecuenciaPago select w;
                foreach (var item in con)
                {
                    clsFrecuencia clas = new clsFrecuencia();
                    clas._IdFrecuenciaPago = item.IdFrecuenciaPago;
                    clas._Descripcion = item.Descripcion;
                    clas._FechaActual = (item.FechaActual);
                    clas._Estado = item.Estado;
                    clas._IdUsuario = item.IdUsuario;
                    clas._IdEmpresa = item.IdEmpresa;
                    lista.Add(clas);

                }

                return lista;
            }

            catch (Exception)
            {
                return null;
            }
        }


        public void Modificar(clsFrecuencia Frecuencia)
        {
            using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
            {
                var x = (from q in ent.FrecuenciaPago where q.IdFrecuenciaPago == Frecuencia._IdFrecuenciaPago select q).First();

                x.Descripcion = Frecuencia._Descripcion;
                x.FechaActual = Frecuencia._FechaActual;
               x.Estado = Frecuencia._Estado;
                x.IdEmpresa = Frecuencia._IdEmpresa;
                x.IdUsuario = Frecuencia._IdUsuario;
                ent.SaveChanges();

            }
        }

        public Boolean Guardar(clsFrecuencia Frecuencia)
       
        {
            try
            {
                int id = getIdSiguiente();
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {
                    FrecuenciaPago pago = new FrecuenciaPago()
                    {
                        IdFrecuenciaPago = id,
                        Descripcion = Frecuencia._Descripcion,
                        FechaActual = DateTime.Today,//Frecuencia.FechaActual,
                        Estado = Frecuencia._Estado,
                        IdUsuario = Frecuencia._IdUsuario,
                        IdEmpresa = Frecuencia._IdEmpresa,
                    };
                    ent.AddToFrecuenciaPago(pago);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Boolean Eliminar(clsFrecuencia Frecuencia)
        {
            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {

                    var x = (from q in ent.FrecuenciaPago where q.IdFrecuenciaPago == Frecuencia._IdFrecuenciaPago select q).First();

                    ent.DeleteObject(x);

                    ent.SaveChanges();

                }
                return true;
            }
            catch (Exception ex)
            {
                return false ;
            }

        }
        public int getIdSiguiente()
        {
            try
            {
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                int x = ((from a in ent.FrecuenciaPago select a.IdFrecuenciaPago).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1;
            }
        }

    }


}


