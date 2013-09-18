using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.CuentasxCobrar;
using clases.Seguridad;

namespace datos.CuentasxCobrar
{
    public class clsDatosTipoInversion
    {
        public int getIdSiguiente()
        {
            try
            {
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                int x = ((from a in ent.TipoInversion select a.idTipoInversion).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }

        public List<clsTipoInversion> consultaTipoInversionGeneral()
        {
            try
            {
                List<clsTipoInversion> lista = new List<clsTipoInversion>();
                CuentasPorCobrarEntities ent = new CuentasPorCobrarEntities();
                var con = from w in ent.TipoInversion select w;
                foreach (var item in con)
                {
                    clsTipoInversion inversion = new clsTipoInversion();
                    inversion.idEmpresa = item.idEmpresa;
                    inversion.idTipoInversion = item.idTipoInversion;
                    inversion.Descripcion = item.Descripcion;
                    inversion.Estado = item.Estado;
                   
                    lista.Add(inversion);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
        }
        
        public Boolean modificar(clsTipoInversion inversion)
        {
            using (CuentasPorCobrarEntities entCxC = new CuentasPorCobrarEntities())
            {
                var x = (from q in entCxC.TipoInversion where q.idTipoInversion == inversion.idTipoInversion select q).First();
                
                x.idEmpresa = inversion.idEmpresa;
                x.idTipoInversion = inversion.idTipoInversion;
                x.Descripcion = inversion.Descripcion;
                x.Estado = inversion.Estado;
                
                entCxC.SaveChanges();
                
                return true;
            }
        }

        public Boolean guardar(clsTipoInversion inversion)
        {
            try
            {

                using (CuentasPorCobrarEntities entCxC = new CuentasPorCobrarEntities())
                {
                    int x = this.getIdSiguiente();
                    TipoInversion tipoInver = new TipoInversion()
                    {
                        idEmpresa = inversion.idEmpresa,                           
                        idTipoInversion = x,
                        Descripcion = inversion.Descripcion,
                        Estado =   inversion.Estado,
                    };
                    entCxC.AddToTipoInversion(tipoInver);
                    entCxC.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("xxxxxxxxxxxx" + ex);   
                return false;
            }
        }

        public Boolean eliminar(clsTipoInversion inversion)
        {
            try
            {
                using (CuentasPorCobrarEntities entCxC = new CuentasPorCobrarEntities())
                {
                    var x = (from q in entCxC.TipoInversion where q.idTipoInversion == inversion.idTipoInversion select q).First();
                    entCxC.DeleteObject(x);
                    entCxC.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("xxxxxxxxxxxx" + ex); 
                return false;
            }
        }
     
    }
}
