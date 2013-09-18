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
using datos.Seguridad;

namespace forms.Inventario
{
    public partial class frmArticulo : Form
    {
        public frmArticulo()
        {
            InitializeComponent();
        }
        int E = 1;

        public clsArticulo classArt = new clsArticulo();
        datArticulo data = new datArticulo();
        datArticulo datos = new datArticulo();

        private void frmArticulo_Load(object sender, EventArgs e)
        {

            int a = datos.getIdSiguiente();
            txt_codigo.Text = Convert.ToString(a);

            datArticulo data = new datArticulo();
            datEstado data1 = new datEstado();
            cbx_tipoArticulo.Properties.DataSource = data.consultaTipoArticulo();
            cbx_grupoArticulo.Properties.DataSource = data.consultaGrupoArticulo();
            cbx_marca.Properties.DataSource = data.consultaMarca();
            cbx_Modelo.Properties.DataSource = data.consultaModelo();
            cbx_Color.Properties.DataSource = data.consultaColor();
            cbx_TipoMotor.Properties.DataSource = data.consultaTipoMotor();
            cbx_TipoChasis.Properties.DataSource = data.consultaTipoChasis();
            cbx_TipoCombustible.Properties.DataSource = data.consultaTipoCombustible();
            cbx_MarcaAcc.Properties.DataSource = data.consultaMarca();
            cbx_UMedAcc.Properties.DataSource = data.consultaUMedida();
            cbx_tipoMatAcc.Properties.DataSource = data.consultaTipoMaterial();
            cbx_tMatSO.Properties.DataSource = data.consultaTipoMaterial();
            cbx_UMedSO.Properties.DataSource = data.consultaUMedida();
            cbx_MarcaSO.Properties.DataSource = data.consultaMarca();
            cbx_tMaterialAL.Properties.DataSource = data.consultaTipoMaterial();
            cbx_uMedAL.Properties.DataSource = data.consultaUMedida();
            cbx_MarcaAL.Properties.DataSource = data.consultaMarca();
            cbx_tMatAF.Properties.DataSource = data.consultaTipoMaterial();
            cbx_uMedidaAF.Properties.DataSource = data.consultaUMedida();
            cbx_MarcaAF.Properties.DataSource = data.consultaMarca();
            cbx_ModeloAF.Properties.DataSource = data.consultaModelo();
            cbx_ColorAF.Properties.DataSource = data.consultaColor();
            txt_estado.Properties.DataSource = data1.ConsultaTodos();

            if (accion == "M")
            {
                set();
            }
            if (accion == "E")
            {
                set();
            }
        }

        public string accion { get; set; }
        public void set()
        {
            E = classArt.EmpresaArt;
            txt_codigo.Text = Convert.ToString(classArt.IdArt);
            dtp_fecha.Value = classArt.FProduccion;
            cbx_grupoArticulo.EditValue = classArt.GrupoArt;
            cbx_tipoArticulo.EditValue = classArt.TipoArt;
            txt_observacion.Text = classArt.ObservArt;
            if (cbx_grupoArticulo.SelectedText == "Vehiculos" & cbx_tipoArticulo.SelectedText == "Mercaderia")
            {
                cbx_marca.EditValue = classArt.MarcaArt;
                cbx_Modelo.EditValue = classArt.ModeloArt;
                cbx_Color.EditValue = classArt.ColorArt;
                cbx_TipoChasis.EditValue = classArt.TipoChasis;
                txt_NroChasis.Text = classArt.SChasis;
                cbx_TipoMotor.EditValue = classArt.TipoMotor;
                txt_serieMotor.Text = classArt.SMotor;
                cbx_TipoCombustible.EditValue = classArt.TipoComb;
                txt_estado.Text = Convert.ToString(classArt.EstArt);
                txt_descripcion.Text = classArt.DescArt;
                txt_cantMinima.Text = Convert.ToString(classArt.CantMinima);
                txt_cantMaxima.Text = Convert.ToString(classArt.CantMaxima);
                txt_cantActual.Text = Convert.ToString(classArt.CantActual);
                txt_Placa.Text = classArt.NPlaca;
            }
            if (cbx_grupoArticulo.SelectedText == "Accesorios" & cbx_tipoArticulo.SelectedText == "Mercaderia")
            {
                txt_cantMinAcc.Text = Convert.ToString(classArt.CantMinima);
                txt_cantMaxAcc.Text = Convert.ToString(classArt.CantMaxima);
                txt_cantActAcc.Text = Convert.ToString(classArt.CantActual);
                cbx_MarcaAcc.EditValue = classArt.MarcaArt;
                cbx_tipoMatAcc.EditValue = classArt.TipoMat;
                cbx_UMedAcc.EditValue = classArt.UMed;
                txt_DescripAcc.Text = classArt.DescArt;
            }
            if (cbx_tipoArticulo.SelectedText == "Suministrosdeoficina")
            {
                txt_cantMinSO.Text = Convert.ToString(classArt.CantMinima);
                txt_cantMaxSO.Text = Convert.ToString(classArt.CantMaxima);
                txt_cantActSO.Text = Convert.ToString(classArt.CantActual);
                cbx_tMatSO.EditValue = classArt.TipoMat;
                cbx_UMedSO.EditValue = classArt.UMed;
                cbx_MarcaSO.EditValue = classArt.MarcaArt;
                txt_DescripSO.Text = classArt.DescArt;
            }
            if (cbx_tipoArticulo.SelectedText == "SuministrosdeLimpieza")
            {
                txt_cantMinAL.Text = Convert.ToString(classArt.CantMinima);
                txt_cantMaxAL.Text = Convert.ToString(classArt.CantMaxima);
                txt_cantActAL.Text = Convert.ToString(classArt.CantActual);
                cbx_tMaterialAL.EditValue = classArt.TipoMat;
                cbx_uMedAL.EditValue = classArt.UMed;
                dtp_fechaCaducidad.Value = classArt.FCaducidad;
                cbx_MarcaAL.EditValue = classArt.MarcaArt;
                txt_DescripcionAL.Text = classArt.DescArt;
            }
            if (cbx_tipoArticulo.SelectedText == "ActivoFijo")
            {
                txt_cantMinAF.Text = Convert.ToString(classArt.CantMinima);
                txt_cantMaxAF.Text = Convert.ToString(classArt.CantMaxima);
                txt_cantActAF.Text = Convert.ToString(classArt.CantActual);
                cbx_tMatAF.EditValue = classArt.TipoMat;
                cbx_uMedidaAF.EditValue = classArt.UMed;
                cbx_MarcaAF.EditValue = classArt.MarcaArt;
                cbx_ModeloAF.EditValue = classArt.ModeloArt;
                cbx_ColorAF.EditValue = classArt.ColorArt;
                txt_DescripSO.Text = classArt.DescArt;
            }
        }
        public void get()
        {
            classArt.EmpresaArt = E;

            classArt.IdArt = Convert.ToInt32(txt_codigo.Text);
            classArt.FProduccion = (DateTime)dtp_fecha.Value;
            classArt.GrupoArt = Convert.ToInt32(cbx_grupoArticulo.EditValue);
            classArt.TipoArt = Convert.ToInt32(cbx_tipoArticulo.EditValue);
            classArt.ObservArt = txt_observacion.Text;
            if (cbx_grupoArticulo.SelectedText == "Vehiculos" & cbx_tipoArticulo.SelectedText == "Mercaderia")
            {
                TabControl_Art.Show();
                Vehiculos.PageEnabled = true;
                classArt.MarcaArt = Convert.ToInt32(cbx_marca.EditValue);
                classArt.ModeloArt = Convert.ToInt32(cbx_Modelo.EditValue);
                classArt.ColorArt = Convert.ToInt32(cbx_Color.EditValue);
                classArt.TipoChasis = Convert.ToInt32(cbx_TipoChasis.EditValue);
                classArt.SChasis = txt_NroChasis.Text;
                classArt.TipoMotor = Convert.ToInt32(cbx_TipoMotor.EditValue);
                classArt.SMotor = txt_serieMotor.Text;
                classArt.TipoComb = Convert.ToInt32(cbx_TipoCombustible.EditValue);
                classArt.EstArt = Convert.ToInt32(txt_estado.EditValue);
                classArt.DescArt = txt_descripcion.Text;
                classArt.CantMinima = Convert.ToInt32(txt_cantMinima.Text);
                classArt.CantMaxima = Convert.ToInt32(txt_cantMaxima.Text);
                classArt.CantActual = Convert.ToInt32(txt_cantActual.Text);
                classArt.NPlaca = txt_Placa.Text;
            }
            if (cbx_grupoArticulo.SelectedText == "Accesorios" & cbx_tipoArticulo.SelectedText == "Mercaderia")
            {
                classArt.CantMinima = Convert.ToInt32(txt_cantMinAcc.Text);
                classArt.CantMaxima = Convert.ToInt32(txt_cantMaxAcc.Text);
                classArt.CantActual = Convert.ToInt32(txt_cantActAcc.Text);
                classArt.MarcaArt = Convert.ToInt32(cbx_MarcaAcc.EditValue);
                classArt.TipoMat = Convert.ToInt32(cbx_tipoMatAcc.EditValue);
                classArt.UMed = Convert.ToInt32(cbx_UMedAcc.EditValue);
                classArt.DescArt = txt_DescripAcc.Text;
            }
            if (cbx_tipoArticulo.SelectedText == "SuministrosdeOficina")
            {
                classArt.CantMinima = Convert.ToInt32(txt_cantMinSO.Text);
                classArt.CantMaxima = Convert.ToInt32(txt_cantMaxSO.Text);
                classArt.CantActual = Convert.ToInt32(txt_cantActSO.Text);
                classArt.TipoMat = Convert.ToInt32(cbx_tMatSO.EditValue);
                classArt.UMed = Convert.ToInt32(cbx_UMedSO.EditValue);
                classArt.MarcaArt = Convert.ToInt32(cbx_MarcaSO.EditValue);
                classArt.DescArt = txt_DescripSO.Text;
            }
            if (cbx_tipoArticulo.SelectedText == "SuministrosdeLimpieza")
            {
                classArt.CantMinima = Convert.ToInt32(txt_cantMinAL.Text);
                classArt.CantMaxima = Convert.ToInt32(txt_cantMaxAL.Text);
                classArt.CantActual = Convert.ToInt32(txt_cantActAL.Text);
                classArt.TipoMat = Convert.ToInt32(cbx_tMaterialAL.EditValue);
                classArt.UMed = Convert.ToInt32(cbx_uMedAL.EditValue);
                classArt.FCaducidad = (DateTime)(dtp_fechaCaducidad.Value);
                classArt.MarcaArt = Convert.ToInt32(cbx_MarcaAL.EditValue);
                classArt.DescArt = txt_DescripcionAL.Text;
            }
            if (cbx_tipoArticulo.SelectedText == "ActivoFijo")
            {
                classArt.CantMinima = Convert.ToInt32(txt_cantMinAF.Text);
                classArt.CantMaxima = Convert.ToInt32(txt_cantMaxAF.Text);
                classArt.CantActual = Convert.ToInt32(txt_cantActAF.Text);
                classArt.TipoMat = Convert.ToInt32(cbx_tMatAF.EditValue);
                classArt.UMed = Convert.ToInt32(cbx_uMedidaAF.EditValue);
                classArt.MarcaArt = Convert.ToInt32(cbx_MarcaAF.EditValue);
                classArt.ModeloArt = Convert.ToInt32(cbx_ModeloAF.EditValue);
                classArt.ColorArt = Convert.ToInt32(cbx_ColorAF.EditValue);
                classArt.DescArt = txt_DescripcionAF.Text;
            }

        }

        public void limpiar()
        {
            cbx_tipoArticulo.Text = "";
            cbx_grupoArticulo.Text = "";
            dtp_fecha.Text = "";
            txt_codigo.Text = "";
            txt_observacion.Text = "";
            txt_cantMinima.Text = "";
            txt_cantMaxima.Text = "";
            txt_cantActual.Text = "";
            cbx_marca.EditValue = "";
            cbx_Modelo.EditValue = "";
            cbx_Color.EditValue = "";
            cbx_TipoMotor.EditValue = "";
            txt_serieMotor.Text = "";
            cbx_TipoCombustible.EditValue = "";
            cbx_TipoChasis.Text = "";
            txt_NroChasis.Text = "";
            txt_Placa.Text = "";
            txt_descripcion.Text = "";
            txt_cantMinAcc.Text = "";
            txt_cantMaxAcc.Text = "";
            txt_cantActAcc.Text = "";
            cbx_MarcaAcc.EditValue = "";
            cbx_tipoMatAcc.EditValue = "";
            cbx_UMedAcc.EditValue = "";
            txt_DescripAcc.Text = "";
            txt_cantMinSO.Text = "";
            txt_cantMaxSO.Text = "";
            txt_cantActSO.Text = "";
            cbx_tMatSO.EditValue = "";
            cbx_UMedSO.EditValue = "";
            cbx_MarcaSO.EditValue = "";
            txt_DescripSO.Text = "";
            txt_cantMinAL.Text = "";
            txt_cantMaxAL.Text = "";
            txt_cantActAL.Text = "";
            cbx_MarcaAL.EditValue = "";
            cbx_uMedAL.EditValue = "";
            cbx_tMaterialAL.EditValue = "";
            dtp_fechaCaducidad.Text = "";
            txt_DescripcionAL.Text = "";
            txt_cantMinAF.Text = "";
            txt_cantMaxAF.Text = "";
            txt_cantActAF.Text = "";
            cbx_tMatAF.EditValue = "";
            cbx_uMedidaAF.EditValue = "";
            cbx_MarcaAF.EditValue = "";
            cbx_ModeloAF.EditValue = "";
            cbx_ColorAF.EditValue = "";
            txt_DescripcionAF.Text = "";
          }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            get();
            string Msg = " ";
            if (data.GuardarArt(classArt, ref Msg))
                MessageBox.Show("Guardado");
            else
                MessageBox.Show(Msg);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            get();
            data.ModificarArt(classArt);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            get();
            data.EliminarArt(classArt);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultaArticulo frmConsArt = new frmConsultaArticulo();
            frmConsArt.ShowDialog();
        }



        private void cbx_grupoArticulo_EditValueChanged_1(object sender, EventArgs e)
        {
            if (cbx_grupoArticulo.SelectedText == "Vehiculos")
            {
                TabControl_Art.Show();
                Vehiculos.PageEnabled = true;
                Accesorios.PageEnabled = false;
                Sum_Oficina.PageEnabled = false;
                Art_Limpieza.PageEnabled = false;
                Art_Act_Fij.PageEnabled = false;
            }
            else
            {
                if (cbx_grupoArticulo.SelectedText == "Accesorios")
                {
                    TabControl_Art.Show();
                    Vehiculos.PageEnabled = false;
                    Accesorios.PageEnabled = true;
                    Sum_Oficina.PageEnabled = false;
                    Art_Limpieza.PageEnabled = false;
                    Art_Act_Fij.PageEnabled = false;
                }
                else
                {
                    if (cbx_grupoArticulo.SelectedText == "Papeleria" ||
                        cbx_grupoArticulo.SelectedText == "InsumosdeOficina")
                    {
                        TabControl_Art.Show();
                        Vehiculos.PageEnabled = false;
                        Accesorios.PageEnabled = false;
                        Sum_Oficina.PageEnabled = true;
                        Art_Limpieza.PageEnabled = false;
                        Art_Act_Fij.PageEnabled = false;
                    }
                    else
                    {
                        if (cbx_grupoArticulo.SelectedText == "Detergentes" ||
                            cbx_grupoArticulo.SelectedText == "Desinfectantes" ||
                            cbx_grupoArticulo.SelectedText == "InstrumentodeLimpieza")
                        {
                            TabControl_Art.Show();
                            Vehiculos.PageEnabled = false;
                            Accesorios.PageEnabled = false;
                            Sum_Oficina.PageEnabled = false;
                            Art_Limpieza.PageEnabled = true;
                            Art_Act_Fij.PageEnabled = false;
                        }
                        else
                        {
                            if (cbx_grupoArticulo.SelectedText == "Edificio" ||
                                cbx_grupoArticulo.SelectedText == "Terreno" ||
                                cbx_grupoArticulo.SelectedText == "MueblesyEnseres" ||
                                cbx_grupoArticulo.SelectedText == "EquiposdeComputo")
                            {
                                TabControl_Art.Show();
                                Vehiculos.PageEnabled = false;
                                Accesorios.PageEnabled = false;
                                Sum_Oficina.PageEnabled = false;
                                Art_Limpieza.PageEnabled = false;
                                Art_Act_Fij.PageEnabled = true;
                            }
                            else
                            {
                                if (cbx_grupoArticulo.SelectedText == "")
                                {
                                    TabControl_Art.Hide();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void txt_DescripAcc_EditValueChanged(object sender, EventArgs e)
        {

        }

    }
}
