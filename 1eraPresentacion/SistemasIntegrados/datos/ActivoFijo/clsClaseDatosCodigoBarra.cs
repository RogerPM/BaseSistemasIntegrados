using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.ActivoFijo;

namespace datos.ActivoFijo
{
    public class clsClaseDatosCodigoBarra
    {
        
       //public List<clsClaseDatosCodigoBarra>consultaCodigoBarra()
       //{
       //     try
       //     {
       //     List<clsCodigoBarra>lista= new List<clsCodigoBarra>();
       //     ActivoFijoEntities  ent = new ActivoFijoEntities();
       //     var con = from w in ent.CodigoBarra select w;

       //     foreach (var item in con)
       //     {
       //     clsCodigoBarra  clas = new clsCodigoBarra();
       //     clas.Codigo     = item.IdCodigoBarra;
       //     clas.ancho      = Convert.ToDecimal(item.ancho);
       //     clas.alto       = Convert.ToDecimal (item.alto);
       //     clas.fecha      = Convert.ToDateTime ( item.fecha);
       //     clas.fecha_seteoDesde = Convert.ToDateTime (item.fecha_seteoDesde);
       //     clas.fecha_seteoHasta = Convert.ToDateTime (item.fecha_seteoHasta)
       //     clas.margen_superior =Convert.ToDecimal(item.margen_superior);
       //     clas.margen_inferior =Convert.ToDecimal (item.margen_inferior);
       //     clas.sentido_Lectura =Convert.ToBoolean (item.sentido_lectura);
       //     clas.Idformato = Convert.ToInt32(item.Idformato);
       //     clas.IdImagen = Convert.ToInt32 (item.Imagen);
       //     lista.Add(clas);
       //     }
       //     return lista ;

       //     }
       //                 catch (Exception)
       //                 {

       //                     return null;
       //                 }
        
       //   }

       //public List<clsClaseDatosCodigoBarra> consultaSeteoCodigo()
       //{
       //    try
       //    {
       //        List<clsClaseDatosCodigoBarra> lista = new List<clsClaseDatosCodigoBarra>();
       //        ActivoFijoEntities ent = new ActivoFijoEntities();
       //        var con = from w in ent.CodigoBarra select w;

       //        foreach (var item in con)
       //        {
       //            clsCodigoBarra clas = new clsCodigoBarra();
       //            clas.Codigo = item.IdCodigoBarra;
       //            clas.ancho = Convert.ToDecimal(item.ancho);
       //            clas.alto = Convert.ToDecimal(item.alto);
       //            clas.fecha = Convert.ToDateTime(item.fecha);
       //            clas.fecha_seteoDesde = Convert.ToDateTime(fecha_seteoDesde);
       //            clas.fecha_seteoHasta = item.fecha_seteoHasta;
       //            clas.margen_superior = item.margen_superior;
       //            clas.margen_inferior = item.margen_inferior;
       //            clas.sentido_lectura_Horizontal = item.sentido_lectura;
       //            clas.sentido_lectura_Vertical = item.sentido_lectura;
       //            clas.Idformato = item.Idformato;
       //            clas.observacion = item.observacion;


       //            lista.Add(clas);
       //        }
       //        return lista;

       //    }
       //    catch (Exception)
       //    {

       //        return null;
       //    }

       //}


       //public List<clsSubgrupoActivoFijo> consulta()
       //{
       //    try
       //    {
       //        List<clsCodigoBarra > lista = new List<clsCodigoBarra >();
       //        ActivoFijoEntities ent = new ActivoFijoEntities();
       //        var con = from w in ent.CodigoBarra select w;

       //        foreach (var item in con)
       //        {
       //             clsCodigoBarra  clas = new clsCodigoBarra();
       //             clas.Codigo     = item.IdCodigoBarra;
       //             clas.ancho      = Convert.ToDecimal(item.ancho);
       //             clas.alto       = Convert.ToDecimal (item.alto);
       //             clas.fecha      = Convert.ToDateTime ( item.fecha);
       //             clas.margen_superior =Convert.ToDecimal(item.margen_superior);
       //             clas.margen_inferior =Convert.ToDecimal (item.margen_inferior);
       //             clas.sentido_Lectura =Convert.ToBoolean (item.sentido_lectura);
       //             clas.Idformato = Convert.ToInt32(item.Idformato);

       //             lista.Add(clas);
       //      }

       //            lista.Add(clas);
       //        }
       //        return lista;
       //    }
          
       //}

       //public Boolean modificar(clsSubgrupoActivoFijo SubActivo)
       //{
       //    try
       //    {
       //        using (ActivoFijoEntities ent = new ActivoFijoEntities())
       //        {
       //            //Se hace un primary key codigo 
       //            var x = (from q in ent.SubGrupos where q.IdSubGrupo == SubActivo.Codigo select q).First();
       //            //First obtiene un registro que coincida con el codigo y luego mas a bajo
       //            //modifico dicho registro y guardo eso lo modifica en la base 
       //            x.IdSubGrupo = SubActivo.Codigo;
       //            x.IdGrupo = SubActivo.Grupo;
       //            x.Descripcion = SubActivo.descripcion;
       //            x.fecha = SubActivo.Fecha;
       //            x.IdEstado = SubActivo.IdEstado;
       //            x.IdEmpresa = SubActivo.Empresa;
       //            ent.SaveChanges();
       //        }
       //        return true;
       //    }
       //    catch (Exception)
       //    {

       //        return false;
       //    }


       //}

       //public Boolean guardar(clsSubgrupoActivoFijo SubActivo)
       //{
       //    try
       //    {
       //        using (ActivoFijoEntities ent = new ActivoFijoEntities())
       //        {
       //            SubGrupos Sub = new SubGrupos()
       //            {
       //                IdSubGrupo = SubActivo.Codigo,
       //                IdGrupo = SubActivo.Grupo,
       //                Descripcion = SubActivo.descripcion,
       //                fecha = SubActivo.Fecha,
       //                IdEstado = Convert.ToInt32(SubActivo.IdEstado),
       //                IdEmpresa = Convert.ToInt32(SubActivo.Empresa),

       //            };

       //            ent.AddToSubGrupos(Sub);
       //            ent.SaveChanges();
       //        }
       //        return true;
       //    }
       //    catch (Exception)
       //    {

       //        return false;
       //    }

       //}

       //public Boolean eliminar(clsSubgrupoActivoFijo SubActivo)
       //{
       //    try
       //    {
       //        using (ActivoFijoEntities ent = new ActivoFijoEntities())
       //        {
       //            //Hago un wehere por el primaryKey codigo
       //            var x = (from q in ent.SubGrupos where q.IdSubGrupo == SubActivo.Codigo select q).First();
       //            //Eliminar es muy parecido
       //            //Eliminar el registro que me trajpp el select
       //            ent.DeleteObject(x);
       //            ent.SaveChanges();
       //        }
       //        return true;
       //    }
       //    catch (Exception)
       //    {

       //        return false;
       //    }


       //}





       
    }
 }
