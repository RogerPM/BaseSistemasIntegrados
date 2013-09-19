using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Compras;
using datos.Compras;
using clases.Seguridad;

namespace forms.Compras
{
    public partial class frmRptSolicitudes : Form
    {

        private clsSolicitud oClsSolicitud = new clsSolicitud();
        private clsSolicitudDet oclsSolicitudDet = new clsSolicitudDet();

        private List<clsRptSolicitud1> listaReporte = new List<clsRptSolicitud1>();
        private clsRptSolicitud1 oClsRptReporte = new clsRptSolicitud1();

        private datSolicitud oDatSolicitud = new datSolicitud();
        private clsSolicitud clsSolicitud = new clsSolicitud();

        private List<clsSolicitud> listaSolicitud = new List<clsSolicitud>();

        public frmRptSolicitudes()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            List<clsRptSolicitud1> lst = new List<clsRptSolicitud1>();
            clsRptSolicitud1 cls = new clsRptSolicitud1();
            List<clsSolicitudDet> listadetalle = new List<clsSolicitudDet>();

            listaSolicitud = oDatSolicitud.ConsultarSolicitudCab();
            foreach (var item in listaSolicitud)
	        {
                listadetalle = oDatSolicitud.Detalle_Solicitud(item.Numero,1);//clsVwUsuarioInformacion.idEmpresa);
                item.detalle = listadetalle;
	        }
            rptSolicitud rpt = new rptSolicitud();
            cls.cabeceraDetalle = listaSolicitud;
            lst.Add(cls);
            rpt.datos(lst);
            //oClsRptReporte.detalle = oclsSolicitudDet;S
            
            
                rpt.ShowPreviewDialog();
        }

        private void frmRptSolicitudes_Load(object sender, EventArgs e)
        {

        }
    }
}
