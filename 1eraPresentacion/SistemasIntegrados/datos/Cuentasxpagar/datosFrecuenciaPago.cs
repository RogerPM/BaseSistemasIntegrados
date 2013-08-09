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
        public List<clsFrecuenciaPago> consulta()
        {

            try
            {
                List<clsFrecuenciaPago> lista = new List<clsFrecuenciaPago>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.FrecuenciaPago select w;
                foreach (var item in con)
                {
                    clsFrecuenciaPago clas = new clsFrecuenciaPago();
                    clas.IdFrecuenciaPago = item.IdFrecuenciaPago;
                    clas.Descripcion = item.Descripcion;
                    clas.FechaActual = (item.FechaActual);
                    clas.Estado = item.Estado;
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

      
        public void Modificar(clsFrecuenciaPago Frecuencia)
        {
            using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
            {
                var x = (from q in ent.FrecuenciaPago where q.IdFrecuenciaPago == Frecuencia.IdFrecuenciaPago select q).First();

                x.Descripcion = Frecuencia.Descripcion;
                x.FechaActual = Frecuencia.FechaActual;
               x.Estado = Frecuencia.Estado;
                x.IdEmpresa = Frecuencia.IdEmpresa;
                x.IdUsuario = Frecuencia.IdUsuario;
                ent.SaveChanges();

            }
        }

        public Boolean Guardar(clsFrecuenciaPago Frecuencia)
       
        {
            try
            {
                int id = getIdSiguiente();
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {
                  
                    FrecuenciaPago pago = new FrecuenciaPago()
                    {
                        IdFrecuenciaPago = id,
                        Descripcion = Frecuencia.Descripcion,
                        FechaActual = DateTime.Today,//Frecuencia.FechaActual,
                        Estado = Frecuencia.Estado,
                        IdUsuario =Frecuencia.IdUsuario,
                        IdEmpresa =Frecuencia.IdEmpresa,
                            };
                    ent.AddToFrecuenciaPago(pago);
                    ent.SaveChanges();
                }

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public Boolean  Eliminar(clsFrecuenciaPago Frecuencia)
        {
            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {

                    var x = (from q in ent.FrecuenciaPago where q.IdFrecuenciaPago == Frecuencia.IdFrecuenciaPago select q).First();

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
                return 1; //en caso de que no exista algun registro
            }
        }

    }


}


