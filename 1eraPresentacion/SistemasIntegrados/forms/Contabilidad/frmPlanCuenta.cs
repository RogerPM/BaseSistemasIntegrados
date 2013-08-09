using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.Contabilidad;
using clases.Contabilidad;

namespace forms.Contabilidad
{
    public partial class frmPlanCuenta : Form
    {
        public frmPlanCuenta()
        {
            InitializeComponent();
        }


        clsDatoCuenta dcuenta = new clsDatoCuenta();
        clsDatoTipoCuenta tcuenta = new clsDatoTipoCuenta();
        clsCuenta clase = new clsCuenta();
        clsCuenta claseCmbPadre = new clsCuenta();
        private void frmPlanCuenta_Load(object sender, EventArgs e)
        {
            CargarPlan();
        }


        public void CargarPlan() {
            gcontrol.DataSource = treePlanCuenta.DataSource = dcuenta.ConsultaCuenta();
            cmbtipo.Properties.DataSource = tcuenta.ConsultaTipoCuenta();
            treePlanCuenta.ExpandAll();
            cmbPadre.Properties.DataSource = dcuenta.ConsultaCuentaGrabar();
            treePlanCuenta.Enabled = true;
        }
        private clsCuenta GetSelectedRowCmbCuenta(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsCuenta)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: "+ex);
                return null;
            }
        }

        
        public void limpiar()
        {
            try
            {
                txtnombre.Text = "";
                txtcodigo.Text = "";
                txtDescripcion.Text = "";
            }
            catch (Exception)
            {
            }
        }
        public void CargarText() {
            try
            {
                txtnombre.Text = clase.nombre;
                txtcodigo.Text = clase.IdCuenta;
                txtDescripcion.Text = clase.descripcion;
                cmbtipo.EditValue = clase.IdTipoCuenta;
                cmbNaturaleza.SelectedItem = (clase.naturaleza_cuenta == "D") ? "Debe" : "Haber";
            }
            catch (Exception)
            {
            }
        
        }
        private void treePlanCuenta_AfterFocusNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            try
            {
                clase.IdEmpresa = Convert.ToInt32(treePlanCuenta.FocusedNode.GetDisplayText(colIdEmpresa));
                clase.IdCuenta = Convert.ToString(treePlanCuenta.FocusedNode.GetDisplayText(colIdCuenta));
                clase.codigo_padre = Convert.ToString(treePlanCuenta.FocusedNode.GetDisplayText(colcodigo_padre));
                clase.nombre = treePlanCuenta.FocusedNode.GetDisplayText(colnombre);
                clase.descripcion = treePlanCuenta.FocusedNode.GetDisplayText(coldescripcion);
                clase.IdNivelCuenta = Convert.ToDecimal(treePlanCuenta.FocusedNode.GetDisplayText(colIdNivelCuenta));
                clase.IdTipoCuenta = Convert.ToDecimal(treePlanCuenta.FocusedNode.GetDisplayText(colIdTipoCuenta));
                clase.naturaleza_cuenta = treePlanCuenta.FocusedNode.GetDisplayText(colnaturaleza_cuenta);
                clase.IdUsuario = Convert.ToInt32(treePlanCuenta.FocusedNode.GetDisplayText(colIdUsuario));
                clase.FechaModficacion = Convert.ToDateTime(treePlanCuenta.FocusedNode.GetDisplayText(colFechaModficacion));
                CargarText();
            }
            catch (Exception)
            {
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this .Close();
        }

        private void gridViewCmbPadre_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                claseCmbPadre = GetSelectedRowCmbCuenta((DevExpress.XtraGrid.Views.Grid.GridView)sender);

                txtcodigo.Properties.MaxLength = Convert.ToInt32(claseCmbPadre.digitos);
                //txtcodigo.Properties.Mask.EditMask = "\d{"+claseCmbPadre.digitos.ToString()+"}";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " +ex);

            }

        }
        public void get() {
            clase.codigo_padre=Convert.ToString(cmbPadre.EditValue);
            clase.nombre = txtnombre.Text;
            clase.descripcion = txtDescripcion.Text;
            clase.IdNivelCuenta = claseCmbPadre.IdNivelCuenta+1;
            clase.IdCuenta = clase.IdCuenta;
            
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                txtcodigo.Text =txtDescripcion.Text=txtnombre.Text= "";
                txtcodigo.Properties.MaxLength = 1;
                btnGuardar.Enabled = true;
                aux = "N";
                label1.Visible = true;
                cmbPadre.Visible = true;

                treePlanCuenta.Enabled = false;
            }
            catch (Exception)
            {
            }
        }

        private void cmbPadre_EditValueChanged(object sender, EventArgs e)
        {
            try
            {//rowclik
                txtcodigo.Properties.MaxLength = Convert.ToInt32(gridViewCmbPadre.GetFocusedRowCellValue(coldigitos));
                //rowclik
                cmbNaturaleza.SelectedItem = (claseCmbPadre.naturaleza_cuenta == "D") ? "Debe" : "Haber";
                cmbtipo.EditValue = claseCmbPadre.IdTipoCuenta;

                cmbNaturaleza.SelectedItem = (gridViewCmbPadre.GetFocusedRowCellValue(nCuenta).ToString() == "D") ? "Debe" : "Haber";
                cmbtipo.EditValue = gridViewCmbPadre.GetFocusedRowCellValue(tipoCuenta);
            }
            catch (Exception)
            {
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            focus = gView.FocusedRowHandle;
            get();
            if(aux=="N"){
                if (txtcodigo.Text.Length != txtcodigo.Properties.MaxLength || txtnombre.Text=="")
                {
                    txtcodigo.Focus();
                    MessageBox.Show("la Cuenta debe tener " + txtcodigo.Properties.MaxLength + " digitos y Nombre", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else 
                {
                    clase.IdCuenta = claseCmbPadre.IdCuenta + txtcodigo.Text;
                    if (dcuenta.Guardar(clase)) { MessageBox.Show("Cuenta Guardada.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                    else
                    { MessageBox.Show("No se pudo Guardar tal vez el codigo ya existe. \nConsulte con Seguridad", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }                
            }
            
            if (aux == "M")
            {
                if (dcuenta.Modificar(clase)) { MessageBox.Show("Cuenta Modificada.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                else
                { MessageBox.Show("No se pudo modificar consulte con Seguridad", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            CargarPlan();
            label1.Visible = cmbPadre.Visible = btnGuardar.Enabled = false;
            gView.FocusedRowHandle = focus+1;
        }
        string aux = "";
        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            aux = "M";
        }
        int focus = 0;
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            focus = gView.FocusedRowHandle;

            get();
            if (dcuenta.Eliminar(clase)) { MessageBox.Show("Cuenta Eliminada.", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else 
            { MessageBox.Show("No puede eliminar esta cuenta si tiene Subcuentas o es usada en un comprobante", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
            CargarPlan();
            gView.FocusedRowHandle = focus-1;
        }

        private void btnExpandir_Click(object sender, EventArgs e)
        {
            treePlanCuenta.ExpandAll();
        }

        private void btnAcoplar_Click(object sender, EventArgs e)
        {
            treePlanCuenta.CollapseAll();
        }


    }
}
