using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Cuentasxpagar;

namespace datos.Cuentasxpagar
{
    public class clsEmpresaServicioDAT1
    {
        EmpresaServicio EmpSer;
        Telefono Tel;
        TelefonoEmpresaServicio TelEmpServ;
        CuentaBancaria2 CtaBanc;
        int valTel, aux;




        public int getIdSiguienteTelefono()
        {
            try
            {
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                int x = ((from a in ent.Telefono select a.IdTelefono).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1;
            }
        }




        public int getIdSiguienteCtaBanc()
        {
            try
            {
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                int x = ((from a in ent.CuentaBancaria2 select a.Serie).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1;
            }
        }





        public Boolean Guardar(clsEmpresaServicio EmpresaServiciocls)
        {
            try
            {
                using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
                {
                    EmpSer = new EmpresaServicio()
                    {
                        IdEmpresaServicio = EmpresaServiciocls._IdEmpresaServicio,
                        IdTipoPersona = EmpresaServiciocls._TipoPersona,
                        FechaRegistro = DateTime.Today,
                        RazonSocial = EmpresaServiciocls._RazonSocial,
                        Estado = EmpresaServiciocls._Estado,
                        Direccion = EmpresaServiciocls._Direccion,
                        Email = EmpresaServiciocls._Email,
                        Webpage = EmpresaServiciocls._Website,
                    };
                    ent.AddToEmpresaServicio(EmpSer);
                    //ent.SaveChanges();


                    aux = EmpresaServiciocls._DetalleTelefono.Count();
                    for (int i = 0; i <= aux; i++)//Guardando los teléfonos, tanto en la tabla Telefono como en TelefonoEmpresaServicio
                    {
                        valTel = getIdSiguienteTelefono();
                        Tel = new Telefono()
                        {
                            IdTelefono = valTel,
                            IdTipoTelefono = EmpresaServiciocls._DetalleTelefono[i].getTipoTelefono(),
                            Numero = EmpresaServiciocls._DetalleTelefono[i].getNumTelefono(),
                        };
                        ent.AddToTelefono(Tel);
                        //ent.SaveChanges();


                        TelEmpServ = new TelefonoEmpresaServicio()
                        {
                            IdEmpresa = EmpresaServiciocls._IdEmpresa,
                            IdEmpresaServicio = EmpresaServiciocls._IdEmpresaServicio,
                            IdTelefono = valTel,
                        };
                        ent.AddToTelefonoEmpresaServicio(TelEmpServ);
                        //ent.SaveChanges();
                    }
                    //=============================================================================
                    aux = EmpresaServiciocls._CuentaBancaria.Count();
                    for (int i = 0; i <= aux; i++)//Guardando las cuentas bancarias
                    {
                        CtaBanc = new CuentaBancaria2()
                        {
                            IdEmpresaServicio = EmpresaServiciocls._IdEmpresaServicio,
                            IdEmpresa = EmpresaServiciocls._IdEmpresa,
                            Serie = getIdSiguienteCtaBanc(),
                            IdBanco = EmpresaServiciocls._CuentaBancaria[i].getIdBanco(),
                            TipoCuenta = EmpresaServiciocls._CuentaBancaria[i].getTipoCuenta(),
                            NroCta = EmpresaServiciocls._CuentaBancaria[i].getNroCuenta(),
                        };
                        ent.AddToCuentaBancaria2(CtaBanc);
                        //ent.SaveChanges();
                    }
                    ent.SaveChanges();
                }

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }





        public void Modificar(clsEmpresaServicio Empresa)
        {
            using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
            {
                var x = (from q in ent.EmpresaServicio where q.IdEmpresaServicio == (Empresa._IdEmpresaServicio) select q).First();
                x.IdEmpresaServicio = Empresa._IdEmpresaServicio;
                x.RazonSocial = Empresa._RazonSocial;
                x.Direccion = Empresa._Direccion;
                x.Email = Empresa._Email;
                x.Webpage = Empresa._Website;
                x.Estado = Empresa._Estado;
                x.IdTipoPersona = Empresa._TipoPersona;
                x.IdEmpresa = Empresa._IdEmpresa;
                x.IdUsuario = Empresa._IdUsuario;
                ent.SaveChanges();
            }
        }

        public void Eliminar(clsEmpresaServicio Empresa)
        {
            using (CuentasPorPagarEntities ent = new CuentasPorPagarEntities())
            {
                var x = (from q in ent.EmpresaServicio where q.IdEmpresaServicio == (Empresa._IdEmpresaServicio) select q).First();
                ent.DeleteObject(x);
                ent.SaveChanges();
            }
        }

        //=========================================================================================================================
        //============================================CONSULTA EMPRESA DE SERVICIOS================================================
        //=========================================================================================================================

        public List<clsEmpresaServicio> ConsultaEmpresaServicio()
        {
            try
            {
                List<clsEmpresaServicio> EmpresaServicio = new List<clsEmpresaServicio>();
                List<clsDetalleTelefono> DetalleTelefono = new List<clsDetalleTelefono>();
                List<clsCtaBancaria2> CuentaBancaria = new List<clsCtaBancaria2>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var lst = from q in ent.EmpresaServicio select q;
                var lst2 = from i in ent.Telefono select i;
                var lst3 = from j in ent.CuentaBancaria2 select j;

                foreach (var item in lst)
                {
                    clsEmpresaServicio cls = new clsEmpresaServicio();
                    cls._IdEmpresaServicio = item.IdEmpresaServicio;
                    cls._FechaRegistro = item.FechaRegistro;
                    cls._RazonSocial = item.RazonSocial;
                    cls._TipoPersona = item.IdTipoPersona;
                    cls._Estado = item.Estado;
                    cls._Direccion = item.Direccion;
                    cls._Email = item.Email;
                    cls._Website = item.Webpage;
                    foreach (var item2 in lst2)
                    {
                        clsDetalleTelefono det = new clsDetalleTelefono();
                        det._TipoTelefono = item2.IdTipoTelefono;
                        det._numTelefono = item2.Numero;
                        DetalleTelefono.Add(det);
                    }
                    cls._DetalleTelefono = DetalleTelefono;
                    foreach (var item3 in lst3)
                    {
                        clsCtaBancaria2 det = new clsCtaBancaria2();
                        det._IdBanco = item3.IdBanco;
                        det._TipoCuenta = item3.TipoCuenta;
                        det._NroCuenta = item3.NroCta;
                        CuentaBancaria.Add(det);
                    }
                    cls._CuentaBancaria = CuentaBancaria;
                    EmpresaServicio.Add(cls);
                }
                return EmpresaServicio;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //=========================================================================================================================
        //==============================================CONSULTA TIPO DE PERSONA===================================================
        //=========================================================================================================================

        public List<clsTipoPersonaCXP> ConsultaTipoPersona()
        {
            try
            {
                List<clsTipoPersonaCXP> TipoPersona = new List<clsTipoPersonaCXP>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var lst = from q in ent.TipoPersona select q;
                foreach (var item in lst)
                {
                    clsTipoPersonaCXP cls = new clsTipoPersonaCXP();
                    cls._IdTipoPersona = item.IdTipoPersona;
                    cls._Descripcion = item.Descripcion;
                    cls._IdEmpresa = item.IdEmpresa;
                    cls._IdEstado = item.IdEstado;
                    TipoPersona.Add(cls);
                }
                return TipoPersona;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //=========================================================================================================================
        //==============================================CONSULTA TIPO DE TELEFONO==================================================
        //=========================================================================================================================

        public List<clsTipoTelefonoCXP> ConsultaTipoTelefono()
        {
            try
            {
                List<clsTipoTelefonoCXP> TipoTelefono = new List<clsTipoTelefonoCXP>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var lst = from q in ent.TipoTelefono select q;
                foreach (var item in lst)
                {
                    clsTipoTelefonoCXP cls = new clsTipoTelefonoCXP();
                    cls.IdTipoTelefono = item.IdTipoTelefono;
                    cls.descripcion = item.Descripcion;
                    cls.IdEmpresa = item.IdEmpresa;
                    cls.IdEstado = item.IdEstado;
                    TipoTelefono.Add(cls);
                }
                return TipoTelefono;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //=========================================================================================================================
        //===================================================CONSULTA BANCO========================================================
        //=========================================================================================================================

        public List<clsBancosCXP> ConsultaBanco()
        {
            try
            {
                List<clsBancosCXP> Banco = new List<clsBancosCXP>();
                CuentasPorPagarEntities ent = new CuentasPorPagarEntities();
                var lst = from q in ent.Banco select q;
                foreach (var item in lst)
                {
                    clsBancosCXP cls = new clsBancosCXP();
                    cls._IdBanco = item.idBanco;
                    cls._IdEmpresa = item.idEmpresa;
                    cls._Estado = item.Estado;
                    cls._Nombre = item.Nombre;
                    Banco.Add(cls);
                }
                return Banco;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}