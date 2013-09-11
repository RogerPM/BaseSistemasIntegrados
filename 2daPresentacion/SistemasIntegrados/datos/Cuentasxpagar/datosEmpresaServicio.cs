using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Cuentasxpagar;
using clases.Seguridad;
using clases.RecursosHumanos;

namespace datos.Cuentasxpagar
{
    public class datosEmpresaServicio
    {
        public List<clsEmpresaServicio> consulta()
        {

            try
            {
                List<clsEmpresaServicio> lista = new List<clsEmpresaServicio>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.EmpresaServicio select w;
                foreach (var item in con)
                {
                    clsEmpresaServicio clas = new clsEmpresaServicio();
                    clas.IdEmpresaServicio = Convert.ToString(item.IdEmpresaServicio);
                    clas.fechaRegistro = item.FechaRegistro;
                    clas.RazonSocial = item.RazonSocial;
                    clas.Direccion = item.Direccion;
                    clas.email = item.Email;
                    clas.webpage = item.Webpage;
                    clas.Estado = item.Estado;
                    clas.IdTipoPersona = item.IdTipoPersona;
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
        public List<clsTipoPersona> consultaTipoPersona()
        {

            try
            {
                List<clsTipoPersona > lista = new List<clsTipoPersona >();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var con = from w in ent.TipoPersona select w;
                foreach (var item in con)
                {
                    clsTipoPersona tper= new clsTipoPersona();
                    tper.IdTipoPersona = item.IdTipoPersona;
                    tper.Descripcion = item.Descripcion;
                    tper.IdEstado = item.IdEstado;
                    tper.IdEmpresa = item.IdEmpresa;
                    lista.Add(tper);


                }

                return lista;
            }

            catch (Exception)
            {
                return null;
            }

        }
                public void Modificar(clsEmpresaServicio Empresa)
                 {
               using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                  {
                var x = (from q in ent.EmpresaServicio where q.IdEmpresaServicio ==(Empresa.IdEmpresaServicio) select q).First();
                x.IdEmpresaServicio = Empresa.IdEmpresaServicio;
               
                x.RazonSocial = Empresa.RazonSocial;
                x.Direccion = Empresa.Direccion;
                x.Email = Empresa.email;
                x.Webpage = Empresa.webpage;
                x.Estado = Empresa.Estado;
                x.IdTipoPersona = Empresa.IdTipoPersona;
                x.IdEmpresa= Empresa.IdEmpresa;
                x.IdUsuario = Empresa.IdUsuario;
                ent.SaveChanges();


                     }


        }

        public Boolean Guardar(clsEmpresaServicio Empresa)
        {
            try
            {
                
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {
                    EmpresaServicio servicio = new EmpresaServicio()
                    {
                        IdEmpresaServicio = Empresa.IdEmpresaServicio,
                        FechaRegistro = Empresa.fechaRegistro,
                        RazonSocial = Empresa.RazonSocial,
                        Direccion = Empresa.Direccion,
                        Email = Empresa.email,
                        Webpage = Empresa.webpage,
                        Estado = Empresa.Estado,
                        IdTipoPersona = Empresa.IdTipoPersona,
                        IdEmpresa = Empresa.IdEmpresa,
                        IdUsuario = Empresa.IdUsuario,


                    };
                    ent.AddToEmpresaServicio(servicio);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;

            }

        }

        public Boolean Eliminar(clsEmpresaServicio  Empresa)
        {
            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {

                    var x = (from q in ent.EmpresaServicio  where q.IdEmpresaServicio ==( Empresa .IdEmpresaServicio)  select q).First();

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


