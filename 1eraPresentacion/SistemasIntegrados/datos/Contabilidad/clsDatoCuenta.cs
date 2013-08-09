using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Contabilidad;

namespace datos.Contabilidad
{
     public class clsDatoCuenta
    {

         public List<clsCuenta> ConsultaCuenta()
         {
             try
             {
                 List<clsCuenta> lista = new List<clsCuenta>();

                 EntitiesContabilidad entity = new EntitiesContabilidad();

                 var plancuenta = from cuenta in entity.Cuenta select cuenta;

                 foreach (var item in plancuenta )
                 {
                     clsCuenta ccuenta = new clsCuenta();
                     ccuenta.IdEmpresa = item.IdEmpresa;
                     ccuenta.IdCuenta = item.IdCuenta;
                     ccuenta.codigo_padre = item.codigo_padre;
                     ccuenta.nombre = item.nombre;
                     ccuenta.descripcion = item.descripcion;
                     ccuenta.IdNivelCuenta = item.IdNivelCuenta;
                     ccuenta.IdTipoCuenta = item.IdTipoCuenta;
                     ccuenta.naturaleza_cuenta = item.naturaleza_cuenta;
                     ccuenta.IdUsuario = Convert.ToInt32(item.IdUsuario);
                     ccuenta.FechaModficacion = Convert.ToDateTime(item.FechaModificacion);
                     lista.Add(ccuenta);
                 }

                 return lista;
             }
             catch (Exception)
             {
                 
                 return null;
             }
         }
         public List<clsCuenta> ConsultaCuentaGrabar()
         {
             try
             {
                 List<clsCuenta> lista = new List<clsCuenta>();

                 EntitiesContabilidad entity = new EntitiesContabilidad();

                 var plancuenta = from cuenta in entity.vwCuenta where cuenta.IdNivelCuenta<5 select cuenta;

                 foreach (var item in plancuenta)
                 {
                     clsCuenta ccuenta = new clsCuenta();
                     ccuenta.IdEmpresa = item.IdEmpresa;
                     ccuenta.IdCuenta = item.IdCuenta;
                     ccuenta.codigo_padre = item.codigo_padre;
                     ccuenta.nombre = item.nombre;
                     ccuenta.descripcion = item.descripcion;
                     ccuenta.IdNivelCuenta = item.IdNivelCuenta;
                     ccuenta.IdTipoCuenta = item.IdTipoCuenta;
                     ccuenta.naturaleza_cuenta = item.naturaleza_cuenta;
                     ccuenta.IdUsuario = Convert.ToInt32(item.IdUsuario);
                     ccuenta.FechaModficacion = Convert.ToDateTime(item.FechaModificacion);
                     ccuenta.digitos = item.digitos;
                     lista.Add(ccuenta);
                 }

                 return lista;
             }
             catch (Exception)
             {

                 return null;
             }
         }
         public Boolean Guardar(clsCuenta cuenta) {
             try
             {
                 using (EntitiesContabilidad ent =new EntitiesContabilidad())
                 {
                     Cuenta ct = new Cuenta() { 
                     IdEmpresa=cuenta.IdEmpresa,
                     IdCuenta = cuenta.IdCuenta,
                     codigo_padre = cuenta.codigo_padre,
                     nombre = cuenta.nombre,
                     descripcion = cuenta.descripcion,
                     IdNivelCuenta = cuenta.IdNivelCuenta,
                     IdTipoCuenta = cuenta.IdTipoCuenta,
                     naturaleza_cuenta = cuenta.naturaleza_cuenta,
                     IdUsuario = 1,
                     //FechaModificacion = cuenta.IdEmpresa
                     };
                     ent.AddToCuenta(ct);
                     ent.SaveChanges();
                 }
                 return true;
             }
             catch (Exception)
             {
                 return false;
             }
         }
         public Boolean Modificar(clsCuenta cuenta)
         {
             try
             {
                 EntitiesContabilidad ent = new EntitiesContabilidad();
                     var mod = (from q in ent.Cuenta where q.IdEmpresa == cuenta.IdEmpresa && q.IdCuenta == cuenta.IdCuenta select q).First();
                     mod.descripcion = cuenta.descripcion;
                     mod.nombre = cuenta.nombre;
                     mod.FechaModificacion = DateTime.Now;
                     ent.SaveChanges();
                     
                 return true;
             }
             catch (Exception)
             {
                 return false;
             }
         }
         public Boolean Eliminar(clsCuenta cuenta)
         {
             try
             {
                 EntitiesContabilidad ent = new EntitiesContabilidad();
                 var regcuenta = (from q in ent.Cuenta where q.IdEmpresa == cuenta.IdEmpresa && q.IdCuenta == cuenta.IdCuenta select q).First();
                 var count = (from q in ent.Cuenta where q.codigo_padre == cuenta.IdCuenta select q).Count();
                 if (count == 0)
                 {
                     ent.DeleteObject(regcuenta);
                     ent.SaveChanges();
                 }
                 else { return false; }
                 return true;
             }
             catch (Exception)
             {
                 return false;
             }
         }
    }
}
