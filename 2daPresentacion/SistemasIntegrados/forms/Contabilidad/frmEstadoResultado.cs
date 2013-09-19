using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Contabilidad;
using datos.Contabilidad;
using clases.Seguridad;

namespace forms.Contabilidad
{
    public partial class frmEstadoResultado : Form
    {
        public frmEstadoResultado()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int dias;
                dias = DateTime.DaysInMonth(dtFecha.Value.Year, dtFecha.Value.Month);
                dtFecha.Value = Convert.ToDateTime(dias.ToString() + "-" + dtFecha.Value.Month.ToString() + "-" + dtFecha.Value.Year.ToString());

            }
            catch (Exception)
            {
            }
        }

        private void frmEstadoResultado_Load(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker1_ValueChanged(new object(),new EventArgs());
            }
            catch (Exception)
            {}
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            rptEstadoResultado rpt = new rptEstadoResultado();
            List<clsRPTEstadoResultado> lst = new List<clsRPTEstadoResultado>();
            clsRPTEstadoResultado cls = new clsRPTEstadoResultado();
            clsDatoER dat = new clsDatoER();
            cls.lista = dat.consulta(Convert.ToDateTime(dtFecha.Value.ToShortDateString()));



            cls.NombreEmpresa = clsVwUsuarioInformacion.nombreUsuario;
            lst.Add(cls);
            
            rpt.data(lst);
            rpt.ShowPreviewDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
