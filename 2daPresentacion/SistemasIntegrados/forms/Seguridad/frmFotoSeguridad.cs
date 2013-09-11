using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Seguridad;
using datos.Seguridad;

namespace forms.Seguridad
{
    public partial class frmFotoSeguridad : Form
    {
        clsImagen oImagen = new clsImagen();
        datImagen oDatImagen = new datImagen();
        clsMensajeSeguridad msj = new clsMensajeSeguridad();


        #region "Distributed by security team 3/3"
        //si este bloque ha sido parcial o totalmente editado, los miembros del equipo de seguridad no 
        //se responzabilizan en el caso de que exista un mal funcionamiento de este form.
        private void Botones()
        {
            //lecturas
            btnConsultar.Visible = frmPrincipal.Lectura; 
            //escrituras
            tlsNuevo.Visible = frmPrincipal.Escritura;
            tsbGuardar.Visible = frmPrincipal.Escritura;
            tsbModificar.Visible = frmPrincipal.Escritura;
            //eliminacion
            tsbEliminar.Visible = frmPrincipal.Eliminacion;            
        }

        #endregion

        public frmFotoSeguridad()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }


        datImagen dtimg = new datImagen();
        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.BackgroundImage != null)
                {
                    clsImagen cimagen = new clsImagen();
                    MemoryStream ms = new MemoryStream();
                    Image.FromFile(txtRuta.Text).Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                    cimagen.IdImagen = Convert.ToInt32(txtCodigo.Text);

                    cimagen.Descripcion = txtDescripcion.Text;

                    cimagen.Imagen = ms.ToArray();

                    dtimg.GuardarImagen(cimagen);
                    frmFotoSeguridad_Load(sender, e);
                    MessageBox.Show(msj.Guardar_ok, msj.Titulo, MessageBoxButtons.OK);
                }


            }
            catch (Exception ex)
            {

                Console.WriteLine("Error: " + ex);
            }
        }



        private void frmFotoSeguridad_Load(object sender, EventArgs e)
        {
            try
            {
                List<Image> img = new List<Image>();
                foreach (var item in dtimg.listaimagen())
                {


                    img.Add(Image.FromStream(item.ayuda));
                    imageSlider1.Images.Add(Image.FromStream(item.ayuda));


                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la carga del Formulario");
            }
            Botones();
        }



        private void btnImagen_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            //pictureBox1.BackgroundImage = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = Convert.ToString(openFileDialog1.FileName);
                pictureEdit1.Visible = false;
                pictureBox1.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
            }
        }


        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    var item = dtimg.Consultar(Convert.ToInt32((txtCodigo.Text == "") ? "0" : txtCodigo.Text));
            //    if (item.Imagen != null)
            //    {
            //        txtDescripcion.Text = item.Descripcion;
            //        pictureBox1.BackgroundImage = System.Drawing.Image.FromStream(item.ayuda);
            //        pictureEdit1.Visible = false;
            //    }
            //    else
            //        MessageBox.Show("No existe Registro");
            //}
            //catch (Exception)
            //{


            //}

            frmConsultarImagen f = new frmConsultarImagen();
            f.ShowDialog();
            oImagen = f.oImg;
            txtCodigo.Text = Convert.ToString(oImagen.IdImagen);
            txtDescripcion.Text = oImagen.Descripcion;
            if (oImagen.Imagen != null)
            {
                MemoryStream s = new MemoryStream(oImagen.Imagen);
                //pictureBox1.Image = Image.FromStream(s);
                pictureBox1.BackgroundImage = Image.FromStream(s);
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pictureBox1.BackgroundImage = null;
            }
            pictureEdit1.Visible = false;
           // habilitar(false);
           // btnModificar.Enabled = true;
        }


        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            pictureBox1.Visible = false;
            pictureEdit1.Visible = true;
        }


        private void tsbModificar_Click(object sender, EventArgs e)
        {
            try
            {
                clsImagen cimagen = new clsImagen();
                MemoryStream ms = new MemoryStream();
                Image.FromFile(txtRuta.Text).Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

                cimagen.IdImagen = Convert.ToInt16(txtCodigo.Text);

                cimagen.Descripcion = txtDescripcion.Text;

                cimagen.Imagen = ms.ToArray();

                dtimg.GuardarImagen(cimagen);
                frmFotoSeguridad_Load(sender, e);
                if (oDatImagen.Modificar(oImagen))
                {
                    MessageBox.Show(msj.Editar_ok, msj.Titulo, MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(msj.Editar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {


            }
        }


        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text) || txtCodigo.Text == "0")
            {

                MessageBox.Show("ingrese codigo");

            }
            else
            {
                oImagen.IdImagen = Convert.ToInt32(txtCodigo.Text);
                try
                {
                    DialogResult r;
                    r = MessageBox.Show(msj.Eliminar_confirmacion, msj.Titulo, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (r == DialogResult.Yes)
                    {
                        if (oDatImagen.eliminar(oImagen))
                        {

                            MessageBox.Show(msj.Eliminar_ok, msj.Titulo, MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show(msj.Eliminar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void txtCodigo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


    }
}
