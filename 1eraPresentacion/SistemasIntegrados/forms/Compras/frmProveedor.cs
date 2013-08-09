using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using clases.Seguridad;
using datos.Seguridad;
using clases.Compras;
using datos.Compras;
using System.IO;
using System.Drawing.Imaging;

namespace forms.Compras
{
    public partial class frmProveedor : Form
    {

        clsMensajesCompras msj = new clsMensajesCompras();
        clsProveedor oProveedor= new clsProveedor ();
        datProveedor oDatProveedor = new datProveedor();

        public frmProveedor()
        {
            InitializeComponent();
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            frmConsultaProveedor f = new frmConsultaProveedor();
            f.ShowDialog();

            //Añado los valores a los text
            txtCodigo.Text = frmConsultaProveedor.id_proveedor.ToString();
            txtEmpresa.Text = frmConsultaProveedor.nombre_proveedorempresa;
            txtPersona.Text = frmConsultaProveedor.nombre_proveedor;
            radioGroup1.SelectedIndex = frmConsultaProveedor.id_tipo_articulo-1;
            cbbEstado.SelectedIndex = frmConsultaProveedor.id_estado-1;

        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {
            borrar();
            btnModificar.Enabled = false;
            habilitar(true);
            txtCodigo.Enabled = false;
            btnCodigo.Enabled = false;
       
        }

        public bool getValores()
        {
            if (txtCodigo.Text == "" || txtCodigo.Text == "0")
            {
                oProveedor.idProveedor = 0;//PK
            }
            else
            {
                oProveedor.idProveedor = Convert.ToInt32(txtCodigo.Text);
            }
            if ((txtEmpresa.Text == null || txtEmpresa.Text == "") ||
                (txtPersona.Text == null || txtPersona.Text == "") ||
                (cbbEstado.SelectedItem  == null))
            {
                return false;
            }
            //oProveedor.idEmpresa = Convert.ToInt32 (txtEmpresa.Text);
            oProveedor.idEmpresa = (frmConsultaEmpresa.id_empresa);
            oProveedor.idPersona = (frmComprasConsultaPersona.id_persona);
            oProveedor.idArticulo = radioGroup1.SelectedIndex+1;
            oProveedor.idEstado = cbbEstado.SelectedIndex+1;
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (getValores())
            {
                if (oProveedor.idProveedor==0)
                {
                    if (oDatProveedor.Guardar(oProveedor))
                    {
                        MessageBox.Show(msj.Guardar_ok, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnModificar.Enabled = true;
                        habilitar(false);
                        borrar();
                    }
                    else
                    {
                        MessageBox.Show(msj.Guardar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (oDatProveedor.Modificar(oProveedor))
                    {
                        MessageBox.Show(msj.Editar_ok, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnModificar.Enabled = true;
                        btnModificar.Enabled = false;
                        borrar();
                    }
                    else
                    {
                        MessageBox.Show(msj.Editar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            habilitar(false);
        }



        public void habilitar(bool valor)
        {
            txtEmpresa.Enabled = valor;
            txtPersona.Enabled = valor;
            radioGroup1.Enabled = valor;
            cbbEstado.Enabled = valor;
            btnEmpresa.Enabled = valor;
            btnPersona.Enabled = valor;
            
        }
        public void borrar()
        {
            clsProveedor e = new clsProveedor ();
            txtCodigo.Text = "";
            txtPersona.Text = "";
            txtEmpresa.Text = "";
         }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            habilitar(false);

        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            habilitar(true);
            btnModificar.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            frmConsultaEmpresa fempresa = new frmConsultaEmpresa();
            fempresa.ShowDialog();
            //Añado los valores a los text
            txtEmpresa.Text = frmConsultaEmpresa.nombre_empresa;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            habilitar(false);
            btnCodigo.Enabled=true;
            btnModificar.Enabled = true;
            

        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            frmComprasConsultaPersona fpersona = new frmComprasConsultaPersona();
            fpersona.ShowDialog();
            //Añado los valores a los text
            txtPersona.Text = frmComprasConsultaPersona.razonsocial;
        }


    }
}