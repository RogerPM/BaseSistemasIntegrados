using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.CuentasxCobrar;
using clases.Seguridad;

namespace datos.CuentasxCobrar
{
    public class clsDatosMonetarioDetalle
    {
        public int getIdSiguiente()
        {
            try
            {
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                int x = ((from a in ent.MonetarioDet select a.idDetalleMonetario).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }

        public List<clsMonetarioDetalle> consultaMonetarioDetalleGeneral()
        {
            try 
            {
                List<clsMonetarioDetalle> lista = new List<clsMonetarioDetalle>();
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                var con = from w in ent.MonetarioDet select w;
                foreach (var item in con)
                {
                    clsMonetarioDetalle mondet = new clsMonetarioDetalle();
                    mondet.idEmpresa = item.idEmpresa;
                    mondet.idDetalleMonetario = item.idDetalleMonetario;
                    mondet.Descripcion = item.Descripcion;
                    mondet.Valor = Convert.ToInt32  (item.Valor); //convertir money a int
                    mondet.Estado = item.Estado;
                    
                    lista.Add(mondet);
                    

                }
                return lista;
            }                              
            
            catch (Exception)
            {
                return null;
            }

        }

        public Boolean modificar(clsMonetarioDetalle monetario)
        {
            using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
            {
                var x = (from q in ent.MonetarioDet where q.idDetalleMonetario == monetario.idDetalleMonetario select q).First();

                x.idEmpresa = monetario.idEmpresa; 
                x.Descripcion = monetario.Descripcion;
                x.Valor = monetario.Valor;
                x.Estado = monetario.Estado;

                ent.SaveChanges();

                return true;

            }

        }

        public Boolean guardar(clsMonetarioDetalle monetario)
        {
            try
            {
                using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                {
                    //ojo mon se lo crea pa tener referencia
                    //monetariodet es el nombre de la tabla
                    int x = this.getIdSiguiente();
                    MonetarioDet mon = new MonetarioDet()
                    {
                        idEmpresa = monetario.idEmpresa,
                        idDetalleMonetario = x,
                        Descripcion =  monetario.Descripcion,
                        Valor   =  monetario.Valor,
                        Estado  = monetario.Estado,
                        
                        
                    };
                    ent.AddToMonetarioDet(mon);
                    ent.SaveChanges();

                }
                return true;
            }
            catch (Exception )
            {
                
                return false;
            }
        }

        public Boolean eliminar(clsMonetarioDetalle monetario)
        {
            try
            {
                using (CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities())
                {

                    var x = (from q in ent.MonetarioDet where q.idDetalleMonetario == monetario.idDetalleMonetario select q).First();
                    ent.DeleteObject(x);
                    ent.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                
                return false;
            }
        }
    }
}
