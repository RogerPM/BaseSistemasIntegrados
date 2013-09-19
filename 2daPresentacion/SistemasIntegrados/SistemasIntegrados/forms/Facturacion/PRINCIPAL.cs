using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using forms.Facturacion;
using forms.Facturacion.ConsultasReportes;


namespace forms.Facturacion
{
    public partial class PRINCIPAL : Form
    {
        public PRINCIPAL()
        {
            InitializeComponent();
        }

        private bool noChild()
        {
            Form[] fcChild = MdiChildren;
            if (fcChild.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void bloqMenu()
        {
            if (ribbonControl1.Enabled == true)
            {
                ribbonControl1.Enabled = false;
                ribbonControl1.Minimized = true;
            }
            else
            {
                ribbonControl1.Enabled = true;
                ribbonControl1.Minimized = false;
            }
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnMantPromociones_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPromocion1 frm = new frmPromocion1();
            frm.MdiParent = this;
            frm.Show();

            //frmPromocion1  pantallaPromocion = new frmPromocion1();
            //pantallaPromocion.ShowDialog();
        }

        private void btnMantPorcComisiones_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPorcentajeComi frm = new frmPorcentajeComi();
            frm.MdiParent = this;
            frm.Show();

            //frmPorcentajeComi pantallaPorcComision = new frmPorcentajeComi();
            //pantallaPorcComision.ShowDialog();
        }

        private void btnMantCliente_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.MdiParent = this;
            frm.Show();

            //frmCliente pantallaCliente = new frmCliente();
            //pantallaCliente.ShowDialog();

        }

        private void btnProcCotizacion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCotizacion2 frm = new frmCotizacion2();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnProcFacturacion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmFacturacion pantallaFacturacion = new frmFacturacion();
            //pantallaFacturacion.ShowDialog();

            frmFacturacion frm = new frmFacturacion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnProcDevolucion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmDevolucionVentas pantallaDevolucionVentas = new frmDevolucionVentas();
            //pantallaDevolucionVentas.ShowDialog();

            frmDevolucionVentas frm = new frmDevolucionVentas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnProcComisiones_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmComisiones pantallaComisiones = new frmComisiones();
            //pantallaComisiones.ShowDialog();

            frmComisiones frm = new frmComisiones();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnProcGuiaRemision_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmGuiasRemision pantallaGuiaRemision = new frmGuiasRemision();
            //pantallaGuiaRemision.ShowDialog();

            frmGuiasRemision frm = new frmGuiasRemision();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnRepVentas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmRptVentas pantallaRepVentas = new frmRptVentas();
            //pantallaRepVentas.ShowDialog();

            frmRptVentas frm = new frmRptVentas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnRepCotizaciones_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmRptCotizaciones pantallaRepCotizaciones = new frmRptCotizaciones();
            //pantallaRepCotizaciones.ShowDialog();

            frmRptCotizaciones frm = new frmRptCotizaciones();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnRepComisiones_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmRptComisiones pantallaRepComisiones = new frmRptComisiones();
            //pantallaRepComisiones .ShowDialog();

            frmRptComisiones frm = new frmRptComisiones();
            frm.MdiParent = this;
            frm.Show();
        }

        private void PRINCIPAL_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();

        }

        private void btnMantPromociones_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPromocion1 frm = new frmPromocion1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnMantPorcComisiones_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmPorcentajeComi frm = new frmPorcentajeComi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnMantCliente_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnProcCotizacion_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCotizacion2 frm = new frmCotizacion2();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnProcFacturacion_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmFacturacion frm = new frmFacturacion();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnProcDevolucion_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDevolucionVentas frm = new frmDevolucionVentas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnProcComisiones_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmComisiones frm = new frmComisiones();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnProcGuiaRemision_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmGuiasRemision frm = new frmGuiasRemision();
            frm.MdiParent = this;
            frm.Show();

        }

        private void btnRepVentas_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRptVentas frm = new frmRptVentas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnRepCotizaciones_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRptCotizaciones frm = new frmRptCotizaciones();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnRepComisiones_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmRptComisiones frm = new frmRptComisiones();
            frm.MdiParent = this;
            frm.Show();
        }

       
       
        
    }
}
