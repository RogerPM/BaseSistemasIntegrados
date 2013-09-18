using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Contabilidad
{
    public class EPeriodoContable
    {

        private int IdEmpresa;

        public int idEmpresa
        {
            get { return IdEmpresa; }
            set { IdEmpresa = value; }
        }
        private int IdPeriodo;

        public int idPeriodo
        {
            get { return IdPeriodo; }
            set { IdPeriodo = value; }
        }
        private int IdAFiscal;

        public int idAFiscal
        {
            get { return IdAFiscal; }
            set { IdAFiscal = value; }
        }
        private DateTime FechaInicio;

        public DateTime fechaInicio
        {
            get { return FechaInicio; }
            set { FechaInicio = value; }
        }
        private DateTime FechaFin;

        public DateTime fechaFin
        {
            get { return FechaFin; }
            set { FechaFin = value; }
        }
        private int IdEstado;

        public int idEstado
        {
            get { return IdEstado; }
            set { IdEstado = value; }
        }
        private int IdUsuario;

        public int idUsuario
        {
            get { return IdUsuario; }
            set { IdUsuario = value; }
        }
        private DateTime FechaModificacion;

        public DateTime fechaModificacion
        {
            get { return FechaModificacion; }
            set { FechaModificacion = value; }
        }

        public void Method()
        {

        }
        public EPeriodoContable()
        {

        }
        public EPeriodoContable(int IdEmpresa, int IdPeriodoContable, int IdAFiscal, DateTime FechaInicio, DateTime FechaFin, int IdEstado, int IdUsuario, DateTime FechaModificacion)
        {

        }

    }
}
