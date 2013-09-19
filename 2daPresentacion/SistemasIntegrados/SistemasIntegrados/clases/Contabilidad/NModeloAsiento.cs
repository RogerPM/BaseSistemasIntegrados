using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace clases.Contabilidad
{
    public class NModeloAsiento
    {

        public TECAEntitiesCont dt = null;
        private clsModeloAsiento ctipo = new clsModeloAsiento();
 
        /// <summary>
        /// Metodo para Listar Modelo de Asiento
        /// </summary>
        /// <param name="buscar"> Nombre de variables descripcion </param>
        /// <returns></returns>
        /// //from mod in this.dt.Modulos
        /// && c.modulo.Equals(mod.IdModulo)
        public List<clsTipoTransaccion> ListarModeloAsiento()
        {
            try
            {
                List<clsTipoTransaccion> lista = new List<clsTipoTransaccion>();
                //TECAEntitiesCont dt = new TECAEntitiesCont();
                using (this.dt = new TECAEntitiesCont())
                {
                    var mod = from mod1 in this.dt.vwTipoTransaccion
                             select mod1 ;

                    var t = (from c in this.dt.vwTipoTransaccion
                            //from mod1 in this.dt.Modulo
                            //where c.NombreModulo.Equals(buscar) // modulo.Equals(mod1.IdModulo) // && c.descripcion.Contains(buscar)
                            select c );

                    foreach (var item in t)
                    {
                        clsTipoTransaccion ctipo = new clsTipoTransaccion();                                               
                        ctipo.IdTransaccion = Convert.ToInt32(item.IdTransaccion);
                        ctipo.modulo = Convert.ToInt32(item.modulo);
                        ctipo.nombremodulo = item.NombreModulo ;
                        ctipo.TipoDocumento = item.TipoDocumento;
                        ctipo.descripcion = item.descripcion;
                        lista.Add(ctipo);
                    }

                    return lista; //t.ToList();                  
                    ///return t.Queryable();
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Error al Listar\n " + ex.Message);
            }
        }

        public List<ModeloAsiento> ListarG(int IdEmpresa, int modulo, int IdTransaccion)
        {
            try
            {
                using (this.dt = new TECAEntitiesCont())
                {
                    var tg = from c in this.dt.ModeloAsiento
                             where c.IdEmpresa.Equals(IdEmpresa) && c.modulo.Equals(modulo) && c.IdTransaccion.Equals(IdTransaccion)
                             select c;
                    return tg.ToList();
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al Listar\n " + ex.Message);
            }
        }

        /// <summary>
        /// Metodo Insertar
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public void Insertar(int _IdEmpresa, int _IdTransaccion , int _Modulo, string _Descripcion, string _Debe, string _Haber, int _IdUsuario1, DateTime _FechaModificacion1)
        {
            try
            {
                using (TECAEntitiesCont dt = new TECAEntitiesCont())
                {

                    ModeloAsiento pe = new ModeloAsiento()
                    {
                        IdEmpresa = _IdEmpresa,
                        IdTransaccion = _IdTransaccion,
                        modulo = _Modulo,
                        descripcion = _Descripcion,
                        debe = _Debe,
                        haber = _Haber,
                        IdUsuario = _IdUsuario1,
                        FechaModificacion = _FechaModificacion1
                    };

                    dt.AddToModeloAsiento(pe);
                    dt.SaveChanges();

                    //return dt.ModeloAsientos_Insertar(d.IdEmpresa, d.IdTransaccion, d.Modulo, d.Descripcion, d.Debe, d.Haber, d.IdUsuario1.ToString(), d.FechaModificacion1);
                    ///return this.dt.ModeloAsientos_Insertar(int, int, int, string, string, string, int, DateTime);
                    //return 0;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public void Editar(int _IdEmpresa, int _Modulo, int _IdTransaccion, int _Seceuncia, string _Descripcion, string _Debe, string _Haber, int _IdUsuario1, DateTime _FechaModificacion1)
         //         Insertar(int _IdEmpresa, int _IdTransaccion , int _Modulo, string _Descripcion, string _Debe, string _Haber, int _IdUsuario1, DateTime _FechaModificacion1)
        {
            try
            {
                using (TECAEntitiesCont dt = new TECAEntitiesCont())
                {
                    var upd = (from q in dt.ModeloAsiento where q.IdEmpresa == _IdEmpresa && q.modulo == _Modulo && q.IdTransaccion == _IdTransaccion && q.secuencia == _Seceuncia select q).First();
                    upd.descripcion = _Descripcion;
                    upd.debe = _Debe;
                    upd.haber = _Haber;
                    upd.FechaModificacion = _FechaModificacion1;
                    dt.SaveChanges();
                    
                    
                    ///return this.dt.ModeloAsientos_Insertar(int, int, int, string, string, string, int, DateTime);
                    ///
                    //this.dt.ModeloAsientos_Update(d.IdEmpresa, d.IdTransaccion, d.Modulo, d.Secuencia, d.Descripcion, d.Debe, d.Haber, d.IdUsuario1.ToString(), d.FechaModificacion1);
                    ///this.dt.ModeloAsientos_Update((d.IdEmpresa, d.IdTransaccion, d.Modulo,d.Descripcion, d.Debe,d.Haber, d.IdUsuario1, d.FechaModificacion1);
                    //return ;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public void Eliminar(int _IdEmpresa, int _IdTransaccion, int _modulo, int _secuencia)
        {

            try
            {
                using (TECAEntitiesCont dt = new TECAEntitiesCont())
                {
                    var upd = (from q in dt.ModeloAsiento where q.IdEmpresa == _IdEmpresa && q.IdTransaccion == _IdTransaccion select q).First();
                    dt.DeleteObject(upd);//elimina el registro
                    dt.SaveChanges();
                    ///return this.dt.ModeloAsientos_Insertar(int, int, int, string, string, string, int, DateTime);
                    ///
                    ///this.dt.ModeloAsientos_Delete(IdEmpresa, IdTransaccion, modulo, secuencia);
                    //return;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        /// <summary>
        /// metodo para obtener el registro 
        /// </summary>
        /// <param name="IdEmpresa"></param>
        /// <param name="IdTransaccion"></param>
        /// <param name="modulo"></param>
        /// <param name="secuencia"></param>
        /// <returns></returns>
        public ModeloAsiento getDatos(int _IdEmpresa, int _IdTransaccion, int _modulo, int _secuencia)
        {

            try
            {
                using (this.dt = new TECAEntitiesCont())
                {
                    var t = (from c in this.dt.ModeloAsiento where c.IdEmpresa.Equals(_IdEmpresa) && c.IdTransaccion.Equals(_IdTransaccion) && c.modulo.Equals(_modulo) && c.secuencia.Equals(_secuencia) select c) ;
                    return t.Single();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public ModeloAsiento getDatosD(int IdEmpresa, int modulo, int IdTransaccion)
        {

            try
            {
                using (this.dt = new TECAEntitiesCont())
                {
                    var t = from c in this.dt.ModeloAsiento where c.IdEmpresa.Equals(IdEmpresa) && c.modulo.Equals(modulo) && c.IdTransaccion.Equals(IdTransaccion) select c;
                    return t.Single();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public TipoTransaccion getDatosT(int IdTransaccion, int modulo)
        {



            try
            {
                using (this.dt = new TECAEntitiesCont())
                {
                    ///var tg = from c in this.dt.ModeloAsientos where c.IdEmpresa.Equals(IdEmpresa) && c.modulo.Equals(modulo) && c.IdTransaccion.Equals(IdTransaccion) && c.secuencia > 0 select c;
                    ///var t = from c in this.dt.ModeloAsientos where c.IdEmpresa.Equals(IdEmpresa) && c.IdTransaccion.Equals(IdTransaccion) && c.modulo.Equals(modulo) && c.secuencia.Equals(secuencia) select c;
                    var t = from c in this.dt.TipoTransaccion where c.IdTransaccion.Equals(IdTransaccion) && c.modulo.Equals(modulo) select c;
                    ///var t = from c in this.dt.ModeloAsientos where c.IdEmpresa.Equals(IdEmpresa) && c.modulo.Equals(modulo) && c.IdTransaccion.Equals(IdTransaccion) select c;
                    return t.Single();
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }


    }
}
