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
                    clas._IdEmpresaServicio = Convert.ToString(item.IdEmpresaServicio);
                    clas._FechaRegistro = item.FechaRegistro;
                    clas._RazonSocial = item.RazonSocial;
                    clas._Direccion = item.Direccion;
                    clas._Email = item.Email;
                    clas._Website = item.Webpage;
                    clas._Estado = item.Estado;
                    clas._TipoPersona = item.IdTipoPersona;
                    clas._IdEmpresa = item.IdEmpresa;
                    clas._IdUsuario = item.IdUsuario;
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
                var x = (from q in ent.EmpresaServicio where q.IdEmpresaServicio ==(Empresa._IdEmpresaServicio) select q).First();
                x.IdEmpresaServicio = Empresa._IdEmpresaServicio;
               
                x.RazonSocial = Empresa._RazonSocial;
                x.Direccion = Empresa._Direccion;
                x.Email = Empresa._Email;
                x.Webpage = Empresa._Website;
                x.Estado = Empresa._Estado;
                x.IdTipoPersona = Empresa._TipoPersona;
                x.IdEmpresa= Empresa._IdEmpresa;
                x.IdUsuario = Empresa._IdUsuario;
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
                        IdEmpresaServicio = Empresa._IdEmpresaServicio,
                        FechaRegistro = Empresa._FechaRegistro,
                        RazonSocial = Empresa._RazonSocial,
                        Direccion = Empresa._Direccion,
                        Email = Empresa._Email,
                        Webpage = Empresa._Website,
                        Estado = Empresa._Estado,
                        IdTipoPersona = Empresa._TipoPersona,
                        IdEmpresa = Empresa._IdEmpresa,
                        IdUsuario = Empresa._IdUsuario,


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

                    var x = (from q in ent.EmpresaServicio  where q.IdEmpresaServicio ==( Empresa ._IdEmpresaServicio)  select q).First();

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


