using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using clases.ActivoFijo;
using datos.Seguridad;
using datos.Inventario;
using datos.ActivoFijo;
namespace forms.ActivoFijo
{
    public partial class prcsDepreciacion : Form
    {
        clsClaseDatosGrupo datoGrupo = new clsClaseDatosGrupo();
        clsClaseDatosSubgrupoActivoFijo datoSubGrup = new clsClaseDatosSubgrupoActivoFijo();
        clsClaseDatosActivoFijo datoActivoFijo = new clsClaseDatosActivoFijo();
        clsClaseDatosDepreciacion datoDepreciacion = new clsClaseDatosDepreciacion();

        clsGridDepreciacion oclsGrid = new clsGridDepreciacion();

        clsActivoFijo oActivoFijo = new clsActivoFijo();
        clsGridDepreciacion oGridDepreciacion = new clsGridDepreciacion();
        clsDepreciacionCab oDepreCab = new clsDepreciacionCab();
        clsDepreciacionDet oDepreDet = new clsDepreciacionDet();
        clsDepreciacion oDepreGeneral = new clsDepreciacion();
        datEstado datoEsta = new datEstado();
        clsMensajesActivoFijos msj = new clsMensajesActivoFijos();

        public prcsDepreciacion()
        {
            InitializeComponent();
        }

        #region"Evento Load"
        private void prcsDepreciacion_Load(object sender, EventArgs e)
        {
            //userPrincipal frm = new userPrincipal();
            //pnlCargar.Controls.Add(frm);

            //Llenamos el combo grupo de inventario en la pantalla 

            cbxGrupo.Properties.DataSource = datoGrupo.consultaGrupo();
            BloquearControles();
            cbxEstado.Properties.DataSource = datoEsta.ConsultaTodos();
            cbxSubGrupo.Properties.DataSource = datoSubGrup.consulta();
            gridView1.OptionsBehavior.Editable = false;
            dtFecha.DateTime = DateTime.Now;
        }

        #endregion
        private void pnlCargar_Paint(object sender, PaintEventArgs e)
        {

        }

        #region"Operaciones de Controles"
        public void set(clsDepreciacion Depre)
        {
            txtCodigoActivo.Text = Convert.ToString(Depre.ActivoFijo);
            using (ActivoFijoEntities ent = new ActivoFijoEntities())
            {
                //Se hace un primary key codigo 
                var x = (from q in ent.ActivoFijo where q.IdActivoFijo == Depre.ActivoFijo select q).First();
                cbxGrupo.EditValue = datoActivoFijo.getDescripcionSegunIdInventarioGrupo(Convert.ToInt32(x.IdGrupo));
                cbxSubGrupo.EditValue = datoSubGrup.getDescripcionSegunIdActivoFIjoSubGrupo(Convert.ToInt32(x.IdSubgrupo));
                cbxEstado.EditValue = datoEsta.getDescripcionSegunId(Convert.ToInt32(x.IdEstado));
                txtDescripcion.Text = x.descripcion;
            }

            dtFecha.EditValue = Depre.FechaRegistro;

        }

        public bool getValor()
        {
            oDepreCab.Codigo_SecuDepreciCab = 0;//PK //lo que se hace aqui es colocar los pk en 0 para que se las pueda utilizar 
            oDepreDet.Codigo_SecuDepreciDet = 0;//como una validacion mas adelante 

            if (dtFecha.Text == "")//para que no se caiga la aplicacion en la fecha
            {
                return false;// se retorna false para que cuando se haga la oregunta de que si hay espacios vacios 
                //bote un error 
            }
            else
            {


                if ((txtCodigoActivo.Text == "" || cbxGrupo.EditValue == null) || (dtFecha.EditValue == null) ||
                    (cbxSubGrupo.EditValue == null) || (cbxEstado.EditValue == null) || (txteUsuario.Text == "") || (txtDescripcion.Text == ""))
                {
                    return false; // se retorna false para que cuando se haga la oregunta de que si hay espacios vacios 
                    //bote un error 
                }


                oDepreCab.fecharegistro = Convert.ToDateTime(dtFecha.EditValue);
                oDepreCab.fechaModificacion = Convert.ToDateTime(dtFecha.EditValue);
                oDepreCab.observacion = Convert.ToString(rtbObservacion.Text);
                oDepreDet.idActivoFijo = Convert.ToInt32(txtCodigoActivo.Text);//Se llena el campo del acivo fijo 
                oDepreDet.Perido = oclsGrid.Periodo;
                oDepreDet.depreAnual = oclsGrid.DepreciacionAnual;
                oDepreDet.depreAcumulada = oclsGrid.DepreciacionAcumulada;
                oDepreDet.ValorNominal = oActivoFijo.valor_actualserie;
                oDepreDet.ValorActual = oclsGrid.total;

                return true;// se retorna false para que cuando se haga la oregunta de que si hay espacios vacios 
                //bote que todos los datos estan llenos 
            }
        }

        private void HabilitarControles()
        {
            btnGuardar.Enabled = true;
            btnAnular.Enabled = false;
            btnConsultar.Enabled = true;
            btnBuscar.Enabled = true;
            //btnProcesar.Enabled = true;
            //txtCodigoActivo.Enabled = false;
            //cbxGrupo.Enabled = true;
            //cbxSubGrupo.Enabled = true;
            //cbxEstado.Enabled = true;
            //dtFecha.Enabled = true;
            //txtDescripcion.Enabled = true;
            //GridDepreciacion.Enabled = true;
        }

        private void BloquearControles()
        {
            btnGuardar.Enabled = false;
            btnAnular.Enabled = false;
            btnConsultar.Enabled = false;
            btnBuscar.Enabled = false;
            btnProcesar.Enabled = false;
            cbxGrupo.Enabled = false;
            cbxSubGrupo.Enabled = false;
            cbxEstado.Enabled = false;
            dtFecha.Enabled = false;
            txtDescripcion.Enabled = false;

        }

        private void limpiarControles()
        {
            txtCodigoActivo.Text = "";
            cbxGrupo.EditValue = "";
            cbxSubGrupo.Text = "";
            //dtFecha.EditValue = "";
            cbxEstado.Text = "";
            txtDescripcion.Text = "";
            limpiarGrid();
        }

        public void limpiarGrid()
        {
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                gridView1.DeleteRow(i);
            }
        }


        #endregion


        #region"Operaciones Basicas"
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            VtnConsultaActivoFijo frm = new VtnConsultaActivoFijo();
            frm.ShowDialog();
            if (frm.Cancelar())
            {
                btnGuardar.Enabled = true;//Estas varibles que se le coloca true o false son para setar los botones para que no haiga caidas del sistemas 
                //btnAnular.Enabled = true;//
                btnProcesar.Enabled = true;
                //btnConsultar.Enabled = true;//

                oActivoFijo = frm.cls;
                set(oActivoFijo);
            }
            else
            {
                btnGuardar.Enabled = true;//Estas varibles que se le coloca true o false son para setar los botones para que no haiga caidas del sistemas 
                btnAnular.Enabled = false;//
                btnConsultar.Enabled = false;//
                btnProcesar.Enabled = false;
                limpiarControles();
                MessageBox.Show(msj.Sin_Seleccion, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnProcesar_Click_1(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
            cargar();
            //setGrid(oGridDepreciacion);
            btnProcesar.Enabled = false;
        }


        public void cargar()
        {
            GridDepreciacion.DataSource = setDepreciar(oGridDepreciacion);
        }

        public List<clsGridDepreciacion> setDepreciar(clsGridDepreciacion cls)
        {
            try
            {
                List<clsGridDepreciacion> lista = new List<clsGridDepreciacion>();
                double aux = 0, num1 = 0, num2 = 0, auxi2 = 0;
                if (cbxGrupo.SelectedText == "")
                {
                    cls._Perido = Convert.ToDateTime(dtFecha.EditValue);

                    num1 = oActivoFijo.valor_actualserie;
                    num2 = datoActivoFijo.AniosDepreciar(cbxGrupo.Text);
                    cls.DepreciacionAnual = num1 / num2;

                    aux = aux + cls.DepreciacionAnual;

                    //using (ActivoFijoEntities ent = new ActivoFijoEntities())// con esto voy haber si en la base ya existe algun valor en el depAcumulada para sumarlo al acutal 
                    //{
                    //    var x = (from q in ent.DepreciacionDet where q.Secuencia_DepreciacionDet == oDepreDet.Codigo_SecuDepreciDet && q.IdCabecera == oDepreDet.idCabecera select q).First();
                    //    if (x.DepreAcumulada == 0)
                    //    {
                    //        cls.DepreciacionAcumulada = aux;
                    //    }
                    //    else
                    //    {

                    //        cls.DepreciacionAcumulada = (double)(x.DepreAcumulada);

                    //    }
                    //}

                    if (cls.DepreciacionAcumulada == 0)
                    {
                        cls.DepreciacionAcumulada = aux;
                    }
                    else
                    {
                        auxi2 = auxi2 + cls.DepreciacionAcumulada;
                        cls.DepreciacionAcumulada = auxi2;
                    }
                    cls.total = oActivoFijo.valor_actualserie - aux;
                    cls.Periodo = dtFecha.DateTime.Year;
                    lista.Add(cls);
                }
                else
                {
                    MessageBox.Show("Error por el grupo no se pudo Depreciar ");

                }
                return lista;
            }
            catch (Exception)
            {

                return null;
            }

        }

        public void set(clsActivoFijo ActiFijo)
        {
            txtCodigoActivo.Text = Convert.ToString(ActiFijo.Codigo);
            cbxGrupo.EditValue = datoActivoFijo.getDescripcionSegunIdInventarioGrupo(ActiFijo.grupo);
            cbxSubGrupo.EditValue = datoSubGrup.getDescripcionSegunIdActivoFIjoSubGrupo(ActiFijo.subgrupo);
            dtFecha.EditValue = ActiFijo.fecha_registro;
            cbxEstado.EditValue = datoEsta.getDescripcionSegunId(ActiFijo.estado);
            txtDescripcion.Text = ActiFijo.descripcion;
        }

        public void setGrid(clsGridDepreciacion clsGrid)
        {
            int num = gridView1.RowCount;


            for (int i = 0; i < gridView1.RowCount; i++)
            {

                gridView1.SetRowCellValue(i, col_Perido, clsGrid.Periodo);
                gridView1.SetRowCellValue(i, colDepreciacionAnual, clsGrid.DepreciacionAnual);
                gridView1.SetRowCellValue(i, colDepreciacionAcumulada, clsGrid.DepreciacionAcumulada);
                gridView1.SetRowCellValue(i, coltotal, clsGrid.total);
                gridView1.SetRowCellValue(i, col_Perido, clsGrid._Perido);


            }

        }

        public void getGrid(clsGridDepreciacion clsGrid)
        {
            //decimal  aux = 0;
            for (int i = 0; i < gridView1.RowCount; i++)
            {

                clsGrid.Periodo = /*Convert.ToInt32(gridView1.GetFocusedRowCellValue(col_Perido))*/ 2013;
                clsGrid.DepreciacionAnual = Convert.ToDouble(gridView1.GetFocusedRowCellValue(colDepreciacionAnual));


                clsGrid.DepreciacionAcumulada = Convert.ToDouble(gridView1.GetFocusedRowCellValue(colDepreciacionAcumulada));
                //using (ActivoFijoEntities ent = new ActivoFijoEntities())// con esto voy haber si en la base ya existe algun valor en el depAcumulada para sumarlo al acutal 
                //{                    
                //    var x = (from q in ent.DepreciacionDet where q.Secuencia_DepreciacionDet == oDepreDet.Codigo_SecuDepreciDet &&  q.IdCabecera== oDepreDet.idCabecera  select q).First();
                //    if (x.DepreAcumulada == 0)
                //    {
                //        clsGrid.DepreciacionAcumulada = Convert.ToDouble(gridView1.GetFocusedRowCellValue(colDepreciacionAcumulada));
                //    }
                //    else
                //    {
                //        aux = aux + Convert.ToDecimal(gridView1.GetFocusedRowCellValue(colDepreciacionAcumulada));
                //        clsGrid.DepreciacionAcumulada = (double)(x.DepreAcumulada + aux);
                //        aux = 0;
                //    }
                //}

                clsGrid.total = Convert.ToDouble(gridView1.GetFocusedRowCellValue(coltotal));
                clsGrid._Perido = Convert.ToDateTime(gridView1.GetFocusedRowCellValue(col_Perido));
            }
        }



        private void btnConsultar_Click(object sender, EventArgs e)
        {
            VtnConsultaDepreciacion frm = new VtnConsultaDepreciacion();
            frm.ShowDialog();
            oDepreGeneral = frm.cls;
            set(oDepreGeneral);
            btnGuardar.Enabled = false;

        }

        private void btnAdicional_Click(object sender, EventArgs e)
        {
            if (rtbObservacion.Enabled == true)
            {
                rtbObservacion.Enabled = false;
            }
            else
            {
                rtbObservacion.Enabled = true;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            getGrid(oclsGrid);

            if (getValor())
            {
                if (oDepreDet.Codigo_SecuDepreciDet == 0 & oDepreCab.Codigo_SecuDepreciCab == 0)
                {
                    if (datoDepreciacion.guardarDepreciacion(oDepreCab, oDepreDet))
                    {
                        MessageBox.Show(msj.Guardar_ok);
                        limpiarControles();
                    }
                    else
                    {
                        MessageBox.Show(msj.Guardar_error, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpiarGrid();
        }

        #endregion

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarControles();
            HabilitarControles();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {

            try
            {

                if (datoDepreciacion.eliminar(oDepreDet, oDepreCab))
                {
                    MessageBox.Show(msj.Eliminar_ok);
                    limpiarControles();
                    BloquearControles();
                }
                else
                {
                    MessageBox.Show(msj.Eliminar_error);
                }


            }
            catch (Exception)
            {

                MessageBox.Show(msj.Eliminar_error);
            }
        }

    }
}
