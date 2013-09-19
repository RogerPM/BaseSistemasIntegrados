using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.RecursosHumanos;
using datos.RecursosHumanos;

namespace forms
{
    public partial class frmPConsultaContrato : Form
    {
        public frmPConsultaContrato()
        {
            InitializeComponent();
        }

#region Instancia
        public clsContrato c = new clsContrato();

        clsDatosContrato Contrato = new clsDatosContrato();
#endregion

#region Metodos

        public void Cargar()
        {
            gcContrato.DataSource = Contrato.ConsultContrato();
            
        }

        public void getSeleccion()
        {
            c.NumContrato =Convert.ToInt32(gvContrato.GetFocusedRowCellValue(colNumContrato ));
            c.IdPersona =Convert.ToInt32(gvContrato.GetFocusedRowCellValue(colIdPersona  ));
            c.IdTipoContrato=Convert.ToInt32(gvContrato.GetFocusedRowCellValue(colIdTipoContrato  ));
            c.IdCargo =Convert.ToInt32(gvContrato.GetFocusedRowCellValue(colIdCargo ));
            c.IdEmpresa = Convert.ToInt32(gvContrato.GetFocusedRowCellValue(colIdEmpresa  ));
            c .Fecha =Convert.ToDateTime(gvContrato.GetFocusedRowCellValue(colFecha  )) ;
            c.FechaModificacion =Convert.ToDateTime (gvContrato.GetFocusedRowCellValue(colFechaModificacion  )) ;
            c.Remuneracion =Convert.ToDouble(gvContrato.GetFocusedRowCellValue(colRemuneracion ));
            c.IdJornada =Convert.ToInt32(gvContrato.GetFocusedRowCellValue(colIdJornada )) ;
            c.PeriodoPrueba  =Convert.ToInt32(gvContrato.GetFocusedRowCellValue(colPeriodoPrueba ))  ;
            c .Discapacidad   =Convert.ToInt32(gvContrato.GetFocusedRowCellValue(colDiscapacidad ))  ;
            c.grado =Convert.ToInt32(gvContrato.GetFocusedRowCellValue(colgrado ));
            c.TipoDiscapacidad =Convert.ToInt32(gvContrato.GetFocusedRowCellValue(colTipoDiscapacidad )) ;
            c.Carnet =Convert.ToInt32(gvContrato.GetFocusedRowCellValue(colCarnet ));
            c.IdEstado = Convert.ToInt32(gvContrato.GetFocusedRowCellValue(colIdEstado  ));
            c.NumContrato =Convert.ToInt32(gvContrato.GetFocusedRowCellValue(colNumContrato ));
            c.IdEmpresa =Convert.ToInt32(gvContrato.GetFocusedRowCellValue(colIdEmpresa ));
            c.IdCargo =Convert.ToInt32 (gvContrato.GetFocusedRowCellValue(colIdCargo ));
            c.IdEstado =Convert.ToInt32 (gvContrato.GetFocusedRowCellValue(colIdEstado ));
            
        }

#endregion

#region load

        private void frmPConsultaContrato_Load(object sender, EventArgs e)
        {
            Cargar();

        }


#endregion

        
#region Botones

        private void tsbConsultado_Click(object sender, EventArgs e)
        {
            getSeleccion();
            this.Close();
        }
#endregion

        
    }
}
