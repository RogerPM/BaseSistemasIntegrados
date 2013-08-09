using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace clases.Contabilidad
{
    public class NModeloAsiento
    {

        public DataSIsConDataContext dt = null;
        /// <summary>
        /// Metodo para Listar Modelo de Asiento
        /// </summary>
        /// <param name="buscar"> Nombre de variables descripcion </param>
        /// <returns></returns>
        public List<TipoTransaccion> Listar(String @buscar)
        {
            try
            {
                using (this.dt = new DataSIsConDataContext())
                {
                    var t = from c in this.dt.TipoTransaccions
                            where c.descripcion.Contains(buscar)
                            select c;
                    return t.ToList();
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
                using (this.dt = new DataSIsConDataContext())
                {
                    var tg = from c in this.dt.ModeloAsientos
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
        public int Insertar(EModeloAsiento d)
        {
            try
            {
                using (DataSIsConDataContext dt = new DataSIsConDataContext())
                {
                    return dt.ModeloAsientos_Insertar(d.IdEmpresa, d.IdTransaccion, d.Modulo, d.Descripcion, d.Debe, d.Haber, d.IdUsuario1.ToString(), d.FechaModificacion1);
                    ///return this.dt.ModeloAsientos_Insertar(int, int, int, string, string, string, int, DateTime);
                    //return 0;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public void Editar(EModeloAsiento d)
        {
            try
            {
                using (this.dt = new DataSIsConDataContext())
                {
                    ///return this.dt.ModeloAsientos_Insertar(int, int, int, string, string, string, int, DateTime);
                    ///
                    this.dt.ModeloAsientos_Update(d.IdEmpresa, d.IdTransaccion, d.Modulo, d.Secuencia, d.Descripcion, d.Debe, d.Haber, d.IdUsuario1.ToString(), d.FechaModificacion1);
                    ///this.dt.ModeloAsientos_Update((d.IdEmpresa, d.IdTransaccion, d.Modulo,d.Descripcion, d.Debe,d.Haber, d.IdUsuario1, d.FechaModificacion1);
                    //return ;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public void Eliminar(int IdEmpresa, int IdTransaccion, int modulo, int secuencia)
        {

            try
            {
                using (this.dt = new DataSIsConDataContext())
                {
                    ///return this.dt.ModeloAsientos_Insertar(int, int, int, string, string, string, int, DateTime);
                    ///
                    this.dt.ModeloAsientos_Delete(IdEmpresa, IdTransaccion, modulo, secuencia);
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
        public ModeloAsiento getDatos(int IdEmpresa, int IdTransaccion, int modulo, int secuencia)
        {

            try
            {
                using (this.dt = new DataSIsConDataContext())
                {
                    var t = from c in this.dt.ModeloAsientos where c.IdEmpresa.Equals(IdEmpresa) && c.IdTransaccion.Equals(IdTransaccion) && c.modulo.Equals(modulo) && c.secuencia.Equals(secuencia) select c;
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
                using (this.dt = new DataSIsConDataContext())
                {
                    ///var tg = from c in this.dt.ModeloAsientos where c.IdEmpresa.Equals(IdEmpresa) && c.modulo.Equals(modulo) && c.IdTransaccion.Equals(IdTransaccion) && c.secuencia > 0 select c;
                    ///var t = from c in this.dt.ModeloAsientos where c.IdEmpresa.Equals(IdEmpresa) && c.IdTransaccion.Equals(IdTransaccion) && c.modulo.Equals(modulo) && c.secuencia.Equals(secuencia) select c;
                    var t = from c in this.dt.ModeloAsientos where c.IdEmpresa.Equals(IdEmpresa) && c.modulo.Equals(modulo) && c.IdTransaccion.Equals(IdTransaccion) select c;
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
                using (this.dt = new DataSIsConDataContext())
                {
                    ///var tg = from c in this.dt.ModeloAsientos where c.IdEmpresa.Equals(IdEmpresa) && c.modulo.Equals(modulo) && c.IdTransaccion.Equals(IdTransaccion) && c.secuencia > 0 select c;
                    ///var t = from c in this.dt.ModeloAsientos where c.IdEmpresa.Equals(IdEmpresa) && c.IdTransaccion.Equals(IdTransaccion) && c.modulo.Equals(modulo) && c.secuencia.Equals(secuencia) select c;
                    var t = from c in this.dt.TipoTransaccions where c.IdTransaccion.Equals(IdTransaccion) && c.modulo.Equals(modulo) select c;
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
