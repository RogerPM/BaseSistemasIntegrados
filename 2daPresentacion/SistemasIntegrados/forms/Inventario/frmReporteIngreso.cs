using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Inventario;
using datos.Inventario;

namespace forms.Inventario
{
    public partial class frmReporteIngreso : Form
    {
        public frmReporteIngreso()
        {
            InitializeComponent();
        }
        clsInventario dat = new clsInventario();

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbGeneral.Checked)
                {
                    clsrptIngreso cls = new clsrptIngreso();
                    List<clsrptIngreso> lista = new List<clsrptIngreso>();
                    rptIngresoEgreso rpt = new rptIngresoEgreso();
                    datIngresoEgresoBodegaCAB datcab = new datIngresoEgresoBodegaCAB();


                    cls.listaCab = datcab.consulta();

                    foreach (var item in cls.listaCab)
                    {
                        item.detalle = dat.consultaIEDetalle(item.nroMovimiento);

                    }
                    lista.Add(cls);

                    rpt.dato(lista);
                    rpt.ShowPreviewDialog();
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnBuscarMovmiento_Click(object sender, EventArgs e)
        {
            try
            {
                clsrptIngreso cls = new clsrptIngreso();
                List<clsrptIngreso> lista = new List<clsrptIngreso>();
                rptIngresoEgreso rpt = new rptIngresoEgreso();
                datIngresoEgresoBodegaCAB datcab = new datIngresoEgresoBodegaCAB();

                clsIngresoEgresoCAB oIngresoEgreso = new clsIngresoEgresoCAB(); 
                List<clsIngresoEgresoCAB> listaIngreso = new List<clsIngresoEgresoCAB>();
                frmConsultaIngresoEgresoCAB consulta = new frmConsultaIngresoEgresoCAB();
                consulta.ShowDialog();
                oIngresoEgreso = consulta.cls;
                oIngresoEgreso.detalle=dat.consultaIEDetalle(oIngresoEgreso.nroMovimiento);
                txtNoMovimiento.Text = Convert.ToString(oIngresoEgreso.nroMovimiento);

                listaIngreso.Add(oIngresoEgreso);
                cls.listaCab=listaIngreso;

                lista.Add(cls);

                rpt.dato(lista);
                rpt.ShowPreviewDialog();
            }
            catch (Exception)
            {
            }
        }

        private void rbGeneral_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
