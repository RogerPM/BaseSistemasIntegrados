using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Cuentasxpagar;
using clases.Seguridad;

namespace datos.Cuentasxpagar
{
    public class datosMedioPago
    {
        public List<clsMedioPago> consulta()
        {

            try
            {
                List<clsMedioPago> lista = new List<clsMedioPago>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.MedioPago select w;
                foreach (var item in con)
                {
                    clsMedioPago clas = new clsMedioPago();
                    clas.IdMedioPago = item.IdMedioPago;
                    clas.Descripcion = item.Descripcion;
                    clas.FechaRegistro = (item.fechaRegistro);
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


        public void Modificar(clsMedioPago Medio)
        {
            using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
            {
                var x = (from q in ent.MedioPago where q.IdMedioPago == Medio.IdMedioPago select q).First();

                x.Descripcion = Medio.Descripcion;
                x.fechaRegistro = Medio.FechaRegistro;
                x.Estado = Medio.Estado;
                x.IdEmpresa = Medio.IdEmpresa;
                x.IdUsuario = Medio.IdUsuario;
                ent.SaveChanges();

            }
        }

        public Boolean Guardar(clsMedioPago Medio)
        {
            try
            {
                int id = getIdSiguiente();
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {

                    MedioPago pago = new MedioPago()
                    {
                        IdMedioPago = id,
                        Descripcion = Medio.Descripcion,
                        fechaRegistro = DateTime.Today, // Medio.FechaRegistro,
                        Estado = Medio.Estado,
                        IdEmpresa = Medio.IdEmpresa,
                        IdUsuario = Medio.IdUsuario,

                    };
                    ent.AddToMedioPago(pago);
                    ent.SaveChanges();
                }

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public Boolean Eliminar(clsMedioPago Medio)
        {
            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {

                    var x = (from q in ent.MedioPago where q.IdMedioPago == Medio.IdMedioPago select q).First();

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
                int x = ((from a in ent.MedioPago select a.IdMedioPago).Max()) + 1;

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
