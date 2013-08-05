using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.ActivoFijo;

namespace datos.ActivoFijo
{
    public  class clsClaseDatosBajaActivo
    {
    
    public List<clsBajaActivo>consulta()
    {
        try
            {
                List<clsBajaActivo> lista= new List<clsBajaActivo>();
                ActivoFijoEntities  ent = new ActivoFijoEntities ();
                var con = from w in ent.BajaActivo select w;
                
                foreach (var item in con)
                {
                    clsBajaActivo clas = new clsBajaActivo();
                    clas.Codigo       = item.idBajaActivo;
                    clas.ActivoFIjo   = Convert.ToInt32(item.IdActivoFIjo);
                    clas.Grupo        = Convert.ToInt32 (item.IdGrupo);
                    clas.Subgrupo     = Convert.ToInt32(item.IdSubgrupo);
                    clas.Fecha        = Convert.ToDateTime(item.Fecha);
                    clas.IdEstado     = Convert.ToString(item.IdEstado) ;
                    clas.IdEmpresa    = Convert.ToInt32(item.IdEmpresa);
                    clas.Descripcion  = item.Descripcion;
                    clas.Motivo       = item.Motivo ;
                    clas.Proveedor    = Convert.ToInt32(item.IdProveedor);
                    clas.Observacion  = item.Observacion;
                    clas.IdCabeceraComprobante = Convert.ToInt32(item.IdCabeceraComprobante);

                    lista.Add (clas);
                }
                return lista;

        }
            catch (Exception)
            {

                return null;
            }


        }
   

    public void modificar(clsBajaActivo baja)
    {
        using (ActivoFijoEntities  ent = new ActivoFijoEntities())
        {
            var x = (from q in ent.BajaActivo where q.idBajaActivo == baja.Codigo select q).First();
            x.idBajaActivo = baja.Codigo;
            x.IdActivoFIjo = baja.ActivoFIjo;
            x.IdGrupo      = baja.Grupo;
            x.IdSubgrupo   = baja.Subgrupo;
            x.Fecha        = baja.Fecha;
            x.IdEstado     = Convert.ToInt32(baja.IdEstado);
            x.IdEmpresa    = baja.IdEmpresa;
            x.Descripcion  = baja.Descripcion;
            x.Motivo       = baja.Motivo;
            x.IdProveedor = baja.Proveedor;
            x.Observacion  = baja.Observacion;
            ent.SaveChanges();
        }
    }
 
    public void guardar(clsBajaActivo baja)
    {
        using (ActivoFijoEntities ent = new ActivoFijoEntities())
        {
            BajaActivo baj = new BajaActivo()
            {
                idBajaActivo = baja.Codigo,
                IdActivoFIjo = baja.ActivoFIjo,
                IdGrupo      = baja.Grupo,
                IdSubgrupo   = baja.Subgrupo,
                Fecha        = baja.Fecha,
                IdEstado     = Convert.ToInt32(baja.IdEstado),
                IdEmpresa    = baja.IdEmpresa,
                Descripcion  = baja.Descripcion,
                Motivo       = baja.Motivo,
                IdProveedor  = baja.Proveedor,
             // IdCabeceraComprobante = baja.IdCabeceraComprobante,
                Observacion  = baja.Observacion,
            };
            ent.AddToBajaActivo(baj);
            ent.SaveChanges();
        }
    }

    public void eliminar(clsBajaActivo baja)
    {
        using (ActivoFijoEntities ent = new ActivoFijoEntities())
        {
            //Hago un wehere por el primaryKey codigo
            var x = (from q in ent.BajaActivo where q.idBajaActivo == baja.Codigo select q).First();
            //Eliminar es muy parecido
            //Eliminar el registro que me trajpp el select
            ent.DeleteObject(x);
            ent.SaveChanges();
        }

    }

    }
}

