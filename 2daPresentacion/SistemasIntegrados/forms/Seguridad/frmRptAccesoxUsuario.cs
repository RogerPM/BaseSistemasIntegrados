using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.Seguridad;
using clases.Seguridad;

namespace forms.Seguridad
{
    public partial class frmRptAccesoxUsuario : Form
    {

        List<clsRptAccesoUsuarios> listaReporte = new List<clsRptAccesoUsuarios>();
        ReporteHistorialUsuario reporte = new ReporteHistorialUsuario();
        private clsUsuario usu = new clsUsuario();


        #region "Distributed by security team 3/3"
        //si este bloque ha sido parcial o totalmente editado, los miembros del equipo de seguridad no 
        //se responzabilizan en el caso de que exista un mal funcionamiento de este form.        
        private void Seguridad()
        {
            //lecturas
            toolStripButton1.Visible = frmPrincipal.Lectura;
        }
        #endregion

        public frmRptAccesoxUsuario()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (radioGroup2.EditValue.ToString()=="general")
            {
                List<clsVwIniciosDeSesion> lista = new List<clsVwIniciosDeSesion>();
            lista = datVwIniciosDeSesion.ConsultarTodos();

            var query = (from w in lista select w);
            foreach (var item in query)
            {
                clsRptAccesoUsuarios c = new clsRptAccesoUsuarios();
                
                c.nombreUsuario = item.nombreUsuario;
                c.perfil = item.descripcion;
                var con =(from x in lista where x.nombreUsuario==c.nombreUsuario select x).Count();
                c.cantidad = con;
                var con2 = (from y in lista where y.nombreUsuario == c.nombreUsuario select y).Last();
                c.fechUltimoInicio = con2.fechaIS;
                if (!listaReporte.Contains(c))
                {
                    c.idHistorial = item.idHistorial;
                    listaReporte.Add(c);
                }
            }
            //var distinctItems = listaReporte.GroupBy(x => x.idHistorial).Select(y => y.First());
            var distinctItems = listaReporte.GroupBy(x => x.nombreUsuario).Select(y => y.First());

            reporte.DataSource = distinctItems;
            //reporte.DataSource = quitarRepetidos(listaReporte);
            //r.DataSource = datVwIniciosDeSesion.ConsultarTodos();
            reporte.ShowPreview();
            }
            else if (radioGroup2.EditValue.ToString()=="porUsuario")
            {
                if (String.IsNullOrWhiteSpace(txtCodigo.Text.ToString()))
                {
                    MessageBox.Show("Seleccione un Usuario","TECA");                    
                }else
	            {
                    ReporteHistorialUsuarioEspecif r = new ReporteHistorialUsuarioEspecif();
                    List<clsVwIniciosDeSesion> lista = new List<clsVwIniciosDeSesion>();
                    lista = datVwIniciosDeSesion.ConsultarxIdUsuario(Convert.ToInt32(txtCodigo.Text));
                    r.DataSource = lista ;
                    r.ShowPreview();
	            }
            }
        }

        private List<clsRptAccesoUsuarios> quitarRepetidos(List<clsRptAccesoUsuarios> lista1)
        {    
            List<clsRptAccesoUsuarios> listanueva = new List<clsRptAccesoUsuarios>();
            for (int i = 0; i < lista1.Count; i++)
            {
                if (!(listanueva.Contains(lista1[i])))
                {
                    listanueva.Add(lista1[i]);
                }
            }
            return listanueva;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmConsultarUsuario of = new frmConsultarUsuario();
            of.ShowDialog();
            usu = of.oUsuario;
            txtCodigo.Text = usu.IdUsuario.ToString();
            txtNombre.Text = usu.NombreUsuario.ToString();
        }

        private void radioGroup2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup2.EditValue.ToString() == "general")
            {
                groupControl3.Enabled = false;
            }
            if (radioGroup2.EditValue.ToString() == "porUsuario")
            {
                groupControl3.Enabled = true;
            } 
        }

        private void frmRptAccesoxUsuario_Load(object sender, EventArgs e)
        {
            Seguridad();
        }

    }
}
