using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Contabilidad
{
    public class EModeloAsiento
    {
        private int idEmpresa;

        public int IdEmpresa
        {
            get { return idEmpresa; }
            set { idEmpresa = value; }
        }
        private int idTransaccion;

        public int IdTransaccion
        {
            get { return idTransaccion; }
            set { idTransaccion = value; }
        }
        private int modulo;

        public int Modulo
        {
            get { return modulo; }
            set { modulo = value; }
        }
        private int secuencia;

        public int Secuencia
        {
            get { return secuencia; }
            set { secuencia = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    ///(string.IsNullOrEmpty(IdEmpresa))
                    throw new Exception("EL campo Descripcion es Obligatorio...");
                }
                else
                {
                    descripcion = value;
                }
            }
        }
        private string debe;

        public string Debe
        {
            get { return debe; }
            set { debe = value; }
        }
        private string haber;

        public string Haber
        {
            get { return haber; }
            set { haber = value; }
        }
        private int IdUsuario;

        public int IdUsuario1
        {
            get { return IdUsuario; }
            set { IdUsuario = value; }
        }
        private DateTime FechaModificacion;

        public DateTime FechaModificacion1
        {
            get { return FechaModificacion; }
            set { FechaModificacion = value; }
        }

        /// <summary>
        /// Contructor sin parametros
        /// </summary>

        public EModeloAsiento()
        {

        }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="IdEmpresa"></param>
        /// <param name="IdTransaccion"></param>
        /// <param name="modulo"></param>
        /// <param name="secuencia"></param>
        /// <param name="descripcion"></param>
        /// <param name="debe"></param>
        /// <param name="haber"></param>
        /// <param name="IdUsuario"></param>
        /// <param name="FechaModificacion"></param>

        public EModeloAsiento(int IdEmpresa, int IdTransaccion, int modulo, int secuencia, string descripcion, string debe, string haber, int IdUsuario, DateTime FechaModificacion)
        {
            this.IdEmpresa = IdEmpresa;
            this.modulo = modulo;
            this.idTransaccion = IdTransaccion;
            this.secuencia = secuencia;
            this.descripcion = descripcion;
            this.debe = debe;
            this.haber = haber;
            this.IdUsuario = IdUsuario;
            this.FechaModificacion = FechaModificacion;
        }

    }
}
