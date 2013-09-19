using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Seguridad;
using clases.RecursosHumanos;
using datos.Seguridad;
using ComboxExtended;
using System.IO;
using forms._Otro;
namespace forms.Seguridad
{
    public partial class frmCrearUsuario : Form
    {
        public frmCrearUsuario()
        {
            InitializeComponent();
        }
        public clsUsuario usuario = new clsUsuario();
        public clsImagen cls = new clsImagen();
        clsPersona per = new clsPersona();
        datEstado oDatEstado = new datEstado();
        datUsuario oDatUsuario = new datUsuario();
        datUsuarioPorEmpresa oDatUsuarioPorEmpresa = new datUsuarioPorEmpresa();

        #region "Distributed by security team 3/3" 
        private void Seguridad()
        {           
                simpleButton3.Visible = frmPrincipal.Lectura;           
                toolStripButton1.Visible = frmPrincipal.Escritura;
                toolStripButton5.Visible = frmPrincipal.Escritura;
                toolStripButton3.Visible = frmPrincipal.Escritura;            
                toolStripButton4.Visible = frmPrincipal.Eliminacion;            
        }
        #endregion

        
        public void establecer()
        {
            txtUsuario.Text = usuario.NombreUsuario;
            txtContrasenia.Text = usuario.Contrasena;

        }
        public void obtener()
        {
            usuario.IdUsuario = Convert.ToInt32(txtCedula.Text);
            usuario.NombreUsuario = txtUsuario.Text;
            usuario.Contrasena = Validador.encriptar(txtContrasenia);
            //usuario.Contrasena = txtContrasenia.Text;
            usuario.IdEstado = Convert.ToInt32(Convert.ToString(cbxEstado.SelectedValue));

            //usuario.IdImagen = Convert.ToInt32(cuadroCombinadoGrafico1.SelectedValue);
        }
        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {
            LlenarGrid();
            CargarCuadroCombinadoEstado();
            Seguridad();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (Validador.ContraseñaValidad(txtContrasenia))
            {
                if (txtContrasenia.Text == txtRepetir.Text)
                {
                    obtener();
                    if (datUsuario.Guardar(usuario))
                    {
                        MessageBox.Show("Guardado con éxito");
                        //GrabarEmpresas();
                    }
                    else
                        MessageBox.Show("No Guardado");
                }
                else
                    MessageBox.Show("Contraseña y Confirmación de Contraseña deben ser iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Contraseña Debe Poseer Mayúsculas,Minúsculas,Números y Caracteres Especiales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public void GrabarEmpresas()
        {
            clsUsuarioPorEmpresa oUsuarioPoEmpresa = new clsUsuarioPorEmpresa();
            int i = 0;
            while (i < checkedListBox1.Items.Count)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    //MessageBox.Show("IdEmpresa =" + (i+1));
                    oUsuarioPoEmpresa.IdUsuario = Convert.ToInt32(txtCedula.Text);
                    oUsuarioPoEmpresa.IdEmpresa = (i + 1);
                    datUsuarioPorEmpresa.GuardarEmpresa(oUsuarioPoEmpresa);
                }
                i += 1;
                //oUsuarioPoEmpresa.IdEmpresa =checkedListBox1.Item
            }
        }
        //public void GrabarEmpresas(){
        //    clsUsuarioPorEmpresa oUsuarioPoEmpresa = new clsUsuarioPorEmpresa();
        //    oUsuarioPoEmpresa.IdUsuario = Convert.ToInt32(txtCedula.Text);
        //    foreach (DataRowView item in checkedListBox1.CheckedItems)
        //    {
        //        oUsuarioPoEmpresa.IdUsuario = Convert.ToInt32(txtCedula.Text);
        //        oUsuarioPoEmpresa.IdEmpresa = Convert.ToInt32(item[checkedListBox1.ValueMember].ToString());
        //        //oUsuarioPoEmpresa.IdEmpresa = Convert.ToInt32(checkedListBox1.SelectedValue);
        //        if (datUsuarioPorEmpresa.GuardarEmpresa(oUsuarioPoEmpresa))
        //            MessageBox.Show("Guardado UsuarioPorEmpresa con exito");
        //        else
        //            MessageBox.Show("No Guardado");
        //    }            
        //}
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmConsultaGeneral of = new frmConsultaGeneral();
            of.ShowDialog();
            per = of.oPersona;
            if (Convert.ToString(per.IdPersona) != "0")//if (of.Codigo != String.Empty)
            {
                txtCedula.Text = per.IdPersona.ToString();
                txtNombre.Text = per.NombreRazonSocial.ToString();
                txtApellido.Text = per.Apellido.ToString();
                txtGenero.Text = per.genero.ToString();
                txtTipoPersona.Text = (per.IdTipoPersona.ToString() == "1") ? "Natural" : "Jurídica";
                //txtCedula.Text = of.Codigo;
                //txtNombre.Text = of.Nombre;
                //txtApellido.Text = of.Apellido;
                //txtGenero.Text = of.Genero;
                //txtTipoPersona.Text = (of.TipoPersona == "1") ? "Natural" : "Jurídica";
                if (txtCedula.Text == "")
                {
                }
                else
                {
                    if (datUsuario.ConsultarPorId(Convert.ToInt32(per.IdPersona)) == true)
                    {
                        Consulta();
                    }
                    else
                    {
                        MessageBox.Show("Personal sin Usuario", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        crearNombreUsuario();
                    }
                }
            }
            of = null;
        }
        private void Consulta()
        {
            int c = Convert.ToInt32(txtCedula.Text);
            TECAv8Entities ent = new TECAv8Entities();
            var x = (from a in ent.Usuario where a.IdUsuario == c select a).First();
            txtUsuario.Text = x.NombreUsuario;
            txtContrasenia.Text = x.Contrasena;
            cbxEstado.SelectedValue = x.Estado.IdEstado;

            //for (int i = 0; i < checkedListBox1.Items.Count; i++)
            //{
            //    DataRowView row = (DataRowView)checkedListBox1.Items[i];
            //    if (row[checkedListBox1.ValueMember].ToString() == rdr_supplied["item_id"].ToString())
            //    {
            //        checkedListBox1.SetItemChecked(i, true);
            //    }
            //}
            //x.IdPerfil 
        }
        private void crearNombreUsuario()
        {
            if (txtNombre.Text != "")
            {
                txtUsuario.Text = (txtNombre.Text.Substring(0, 3) + txtApellido.Text.Substring(0,2)).ToLower();
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            obtener();
            DialogResult r = MessageBox.Show("¿Está usted Seguro que desea eliminar?", "Seguridad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            datUsuarioPorEmpresa.EliminarEmpresa(usuario);
            if (r == DialogResult.Yes)
            {
                if (datUsuario.Eliminar(usuario))
                    MessageBox.Show("Eliminado exitoso", "Correcto", MessageBoxButtons.OK);
                else
                    MessageBox.Show("No se ha podido eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarCuadroCombinadoEstado()
        {
            try
            {
                var Descripcionestado = from estado in EntidadSeguridad.Seguridad.Estado
                                        orderby estado.Descripcion
                                        select estado;
                cbxEstado.DataSource = Descripcionestado;
                cbxEstado.DisplayMember = "Descripcion";
                cbxEstado.ValueMember = "IdEstado";

                var NombreEmpresa = from empresa in EntidadSeguridad.Seguridad.Empresa
                                    orderby empresa.IdEmpresa
                                    select empresa;
                //checkedListBox1.DataSource = NombreEmpresa;
                //checkedListBox1.DisplayMember = "NombreComercial";
                //checkedListBox1.ValueMember = "IdEmpresa";
                cbxEmpresa.DataSource = NombreEmpresa;
                cbxEmpresa.DisplayMember = "NombreComercial";
                cbxEmpresa.ValueMember = "IdEmpresa";
                //var ImagenSeguridad = from imagenes in EntidadSeguridad.Seguridad.Imagen
                                      //select imagenes;
                //cuadroCombinadoGrafico1.DataSource = ImagenSeguridad;                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                throw;
            }
        }

        public void LlenarGrid()
        {
            datImagen datImg = new datImagen();
            gridControl1.DataSource = datImg.listaimagen();
            if (gridControl1.DataSource == null)
            {
                MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtUsuario.Enabled = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == txtRepetir.Text)
            {
                obtener();
                if (datUsuario.Modificar(usuario))
                    MessageBox.Show("Modificado exitoso", "Correcto", MessageBoxButtons.OK);
                else
                    MessageBox.Show("No se ha podido Modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Contraseña y Confirmación de Contraseña deben ser iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            cls = getRow((DevExpress.XtraGrid.Views.Grid.GridView)sender);
            //usuario.IdImagen = Convert.ToInt32(cuadroCombinadoGrafico1.SelectedValue);
            
            usuario.IdImagen = cls.IdImagen;
            txtAux.BackColor = Color.Green;
            txtAux.Text = "Seleccionado";
            //txtAux.Text = cls.IdImagen.ToString();
        }
        private clsImagen getRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            try
            {
                return (clsImagen)view.GetRow(view.FocusedRowHandle);
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
