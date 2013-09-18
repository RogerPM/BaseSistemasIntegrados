using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.ActivoFijo;
using clases.Inventario;
using clases.Seguridad;
using datos.ActivoFijo;
using datos.Inventario;
using datos.Seguridad;

namespace forms.ActivoFijo
{
    public partial class prcsActivoFijo : Form
    {
        clsClaseDatosSubgrupoActivoFijo datoSubgrupo = new clsClaseDatosSubgrupoActivoFijo();
        datGrupo datGrupo = new datGrupo();
        clsClaseDatosBajaActivo datoProvePerso = new clsClaseDatosBajaActivo();
        datEstado datoEstado = new datEstado();
        datEmpresa datoEmpresa = new datEmpresa();
        clsClaseDatosActivoFijo datoActivo = new clsClaseDatosActivoFijo();

        DetArticulo frm = new DetArticulo();
        DetVehiculo frm1 = new DetVehiculo();
        DetMueblesEnseres frm2 = new DetMueblesEnseres();
        DetEdificios frm3 = new DetEdificios();
        DetTerrenos frm4 = new DetTerrenos();
        DetMaquinariasEquipos frm5 = new DetMaquinariasEquipos();

        clsActivoFijo oActivoFijo = new clsActivoFijo();
        clsMensajesActivoFijos msj = new clsMensajesActivoFijos();

        public prcsActivoFijo()
        {
            InitializeComponent();
        }

        private void prcsActivoFijo_Load(object sender, EventArgs e)
        {

            //Llenamos el combo de Estado de Seguridad en la pantalla
            cbxEstado.Properties.DataSource = datoEstado.ConsultaTodos();

            //Llenamos el combo de Empresa de Seguridad en la pantalla
            cbxEmpresa.Properties.DataSource = datoEmpresa.Consultar();

            //llenamos el combo de Subgrupo de ActivoFijo en la pantalla
            cbxSubGrupo.Properties.DataSource = datoSubgrupo.consulta();

            //llenamos el combo de la Persona que es Proveedor
            //cbxProveedor.Properties.DataSource = datoProvePerso.consultaEspecial();
            dtFecha.DateTime = DateTime.Now;

            cbxEstado.EditValue = datoEstado.getDescripcionSegunId(oActivoFijo.estado);
            cbxEmpresa.EditValue = datoEmpresa.ConsultarPorId(oActivoFijo.Empresa);
        }

        public string converPantalla_a_Tabla(string Descripcion)
        {
            bool auxi =true;
            if (Descripcion == "Vehiculos")
            {
            
                return "Vehiculos";
            }
            else
            {
                if (Descripcion == "Muebles y Enseres")
                {
                    return "MueblesyEnseres";
                }
                else
                {
                    if (Descripcion == "Equipos")
                    {
                        return "Equipos";
                    }
                    else
                    {
                        if (Descripcion == "Maquinarias")
                        {
                            return "Maquinarias";
                        }
                        else
                        {
                            if (Descripcion == "Edificios")
                            {
                                return "Edificio";
                            }
                            else
                            {
                                if (Descripcion == "Terrenos")
                                {
                                    return "Terreno";
                                }
                                else
                                {
                                    if (Descripcion == "Articulos/Suministros de Oficinas" & frm.cbxIdentDescripcion.Text=="")
                                    {
                                        if (frm.cbxIdentDescripcion.Text == "Insumos de Oficina")
                                        { return "InsumosdeOficina"; }
                                        else
                                        {
                                            if (frm.cbxIdentDescripcion.Text == "Papelería"){ return "Papeleria"; }
                                        }
                                    }
                                    else
                                    {
                                        auxi = false;
                                        MessageBox.Show("Error al guardar, campo Identificar en blanco sin selección alguna", msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                                             
                                        return "";
                                    }

                                    return "";
                                }
                            }
                        }
                    }
                }
            }
        }

        public void FuncionEspecialConsulta( string Descripcion, clsActivoFijo clase)
        {
            if (Descripcion == "Vehiculos")
            {
                frm1.setVehiculo(clase);
            }
            else
            {
                if (Descripcion == "MueblesyEnseres")
                {
                    frm2.setMueblesEnseres(clase);
                }
                else
                {
                    if (Descripcion == "Equipos")
                    {
                        frm5.setMaquinariasEquipos(clase);
                    }
                    else
                    {
                        if (Descripcion == "Maquinarias")
                        {
                            frm5.setMaquinariasEquipos(clase);
                        }
                        else
                        {
                            if (Descripcion == "InsumosdeOficina" | Descripcion == "Papeleria")
                            {
                                frm.setArticulo(clase);                               
                            }
                            else
                            {
                                if (Descripcion == "Terreno")
                                {
                                    frm4.setTerreno(clase);
                                }
                                else
                                {
                                    if (Descripcion == "Edificio")
                                    {
                                        frm3.setEdificios(clase);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public bool FuncionEspecialGetValor(string Descripcion, clsActivoFijo clase)
        {
            if (Descripcion == "Vehiculos")
            {
                frm1.getValorVehiculo(clase);
                return true;                
            }
            else
            {
                if (Descripcion == "MueblesyEnseres")
                {
                    frm2.getValorMueblesEnseres(clase);
                    return true;
                }
                else
                {
                    if (Descripcion == "Equipos")
                    {
                        frm5.getValorMaquinariasEquipos(clase);
                        return true;
                    }
                    else
                    {
                        if (Descripcion == "Maquinarias")
                        {
                            frm5.getValorMaquinariasEquipos(clase);
                            return true;
                        }
                        else
                        {
                            if (Descripcion == "InsumosdeOficina" | Descripcion == "Papeleria")
                            {
                                frm.getValorArticulo(clase);
                                return true;
                            }
                            else
                            {
                                if (Descripcion == "Terreno")
                                {
                                    frm4.getValorTerreno(clase);
                                    return true;
                                }
                                else
                                {
                                    if (Descripcion == "Edificio")
                                    {
                                        frm3.getValorEdificios(clase);
                                        return true;
                                    }
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            prcsResponsables clss = new prcsResponsables();
            clss.ShowDialog();
        }

        public void limpiarControlUser() 
        {
            pnlCargar.Controls.Remove(frm);
            pnlCargar.Controls.Remove(frm1);
            pnlCargar.Controls.Remove(frm2);
            pnlCargar.Controls.Remove(frm3);
            pnlCargar.Controls.Remove(frm4);
            pnlCargar.Controls.Remove(frm5);
            frm.limpiarArticulo();
            frm1.limpiarMaquinariasVehiculos();
            frm2.limpiarMueblesEnseres();
            frm3.limpiarEdificio();
            frm4.limpiarTerrenos();
            frm5.limpiarMaquinariasEquipos();

        }

        public void limpiarControles()
        {
            cbxGrupo.SelectedIndex = -1;
            cbxSubGrupo.EditValue = null;
            txtDescripcion.Text = null;
            //txtCodigoActivo.Text = "";
            cbxGrupo.EditValue = "";
            cbxSubGrupo.Text = "";
            //cbxEmpresa.Text = "";
            //dtFecha.EditValue = "";
            //cbxEstado.Text = "";
            txtDescripcion.Text = "";
      
        }

        private void HabilitarControles()
        {
            btnGuardar.Enabled = true;
            btnAnular.Enabled = false;
            btnConsultar.Enabled = true;
            btnAsignar.Enabled = true;
            btnGenerarCodBarra.Enabled = true;
            //txtCodigoActivo.Enabled = false;
            cbxGrupo.Enabled = true;
            cbxSubGrupo.Enabled = true;
            //cbxEstado.Enabled = true;
            //dtFecha.Enabled = true;
            txtDescripcion.Enabled = true;
            //GridDepreciacion.Enabled = true;
        }

        private void BloquearControles()
        {
            btnGuardar.Enabled = false;
            btnAnular.Enabled = false;
            btnConsultar.Enabled = false;
            cbxGrupo.Enabled = false;
            cbxSubGrupo.Enabled = false;
            cbxEstado.Enabled = false;
            dtFecha.Enabled = false;
            txtDescripcion.Enabled = false;

        }

        public bool getValor()
        {
            oActivoFijo.Codigo = 0;//PK
            if (dtFecha.Text == "")//para que no se caiga la aplicacion en la fecha
            {
                return false;
            }
            else
            {


                if ((dtFecha.EditValue == null || txtUsuario.Text == "") || (cbxEmpresa.EditValue == null) || (cbxEstado.EditValue == null) ||
                    (txtUsuario.Text == "") || (cbxGrupo.SelectedText == "") || (cbxSubGrupo.EditValue == null) || (txtDescripcion.Text == ""))
                {
                    return false;
                }
                oActivoFijo.fecha_registro = Convert.ToDateTime(dtFecha.EditValue);
                //oActivoFijo.Empresa= Convert.ToDouble(txtValorRevalorizado.Text);//Por que ya se encuentran asignados de formadirecta el usuario 
                // oActivoFijo.usuario = txtUsuario.Text;
                //oActivoFijo._Empresa = cbxEmpresa.Text;
                oActivoFijo.subgrupo = datoSubgrupo.getIdSegunDescripcionActivoFIjoSubGrupo(cbxSubGrupo.Text);
                oActivoFijo.estado = datoEstado.getIdSegunDescripcion(cbxEstado.Text);
                oActivoFijo.descripcion = txtDescripcion.Text;
                oActivoFijo.Empresa = datoEmpresa.ConsultarPorNombreComercial(cbxEmpresa.Text);
                oActivoFijo.grupo =datoActivo.getIdSegunDescripcionInventarioGrupo(converPantalla_a_Tabla(cbxGrupo.Text));


                return true;
            }
        }

        public void setActivofijo(clsActivoFijo ActivoFij)
        {
            txtCodigo.Text = Convert.ToString(ActivoFij.Codigo);
            txtUsuario.Text = ActivoFij._Usuario;
            dtFecha.EditValue = ActivoFij.fecha_registro;
            cbxEmpresa.Text = ActivoFij._Empresa;
            cbxSubGrupo.EditValue = datoSubgrupo.getDescripcionSegunIdActivoFIjoSubGrupo(Convert.ToInt32(ActivoFij.subgrupo));
            cbxEstado.EditValue = datoEstado.getDescripcionSegunId(Convert.ToInt32(ActivoFij.estado));
            txtDescripcion.Text = ActivoFij.descripcion;
            cbxEmpresa.EditValue = datoEmpresa.ConsultarPorId( oActivoFijo.Empresa);
            cbxGrupo.SelectedText = datoActivo.VerificacionGrupo(datoActivo.getDescripcionSegunIdInventarioGrupo(ActivoFij.grupo));

            /****************/
            FuncionEspecialConsulta(datoActivo.getDescripcionSegunIdInventarioGrupo(oActivoFijo.grupo),ActivoFij);

            
        }



        private void cbxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

            var num = cbxGrupo.SelectedIndex;
            limpiarControlUser();

            switch (num)
            {

                case 0:

                    pnlCargar.Controls.Add(frm);
                    
                    break;

                case 1:

                    pnlCargar.Controls.Add(frm1);
                    frm1.txtAñosVidaUtil.Text =Convert.ToString( oActivoFijo.aniosDepreciable_Vehiculos);
                    break;

                case 2:

                    pnlCargar.Controls.Add(frm2);
                    frm2.txtAñosVidaUtil.Text = Convert.ToString(oActivoFijo.aniosDepreciable_MueblesEnseres);
                    break;
                case 3:

                    pnlCargar.Controls.Add(frm3);
                    frm3.txtAñosVidaUtil.Text = Convert.ToString(oActivoFijo.aniosDepreciable_Edificios);
                    break;

                case 4:

                    pnlCargar.Controls.Add(frm4);
                    
                    break;
                case 5:

                    pnlCargar.Controls.Add(frm5);
                    frm1.txtAñosVidaUtil.Text = Convert.ToString(oActivoFijo.aniosDepreciable_EquiposCompu);
                    break;
                case 6:

                    pnlCargar.Controls.Add(frm5);
                    frm1.txtAñosVidaUtil.Text = Convert.ToString(oActivoFijo.aniosDepreciable_Maquinarias);
                    break;
                default: break;


            }

           

        }

        private void btnGenerarCodBarra_Click(object sender, EventArgs e)
        {
            prcsCodigoBarra frm = new prcsCodigoBarra();
            frm.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarControlUser();
            limpiarControles();
            HabilitarControles ();
            btnAnular.Enabled = false;
            cbxEmpresa.EditValue = datoEmpresa.ConsultarPorId(1);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            VtnConsultaActivoFijo frm = new VtnConsultaActivoFijo();
            frm.ShowDialog();
            if (frm.Cancelar())
            {
                limpiarControles();
                
                btnGuardar.Enabled = false;
                btnAnular.Enabled = true;
                oActivoFijo = frm.cls;
                setActivofijo(oActivoFijo);

            }
            else
            {
                //Estas varibles que se le coloca true o false son para setar los botones para que no haiga caidas del sistemas 
                btnAnular.Enabled = false;//
                btnConsultar.Enabled = true;//
                limpiarControles();
                MessageBox.Show(msj.Sin_Seleccion, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (getValor())
            {
                if (FuncionEspecialGetValor(datoActivo.getDescripcionSegunIdInventarioGrupo(oActivoFijo.grupo),oActivoFijo ))                {

                    datoActivo.Articulo = frm.auxiArtic;
                    datoActivo.vehiculo=frm1.auxiVehi;
                    datoActivo.Muebles = frm2.auxiMuebles;
                    datoActivo.Edificio = frm3.auxiEdificio;
                    datoActivo.Terreno = frm4.auxiTerreno;
                    datoActivo.EquipoMaqui = frm5.auxiEquipMaqu;
                
                   
                    

                    if (oActivoFijo.Codigo == 0)
                    {
                        if (datoActivo.guardar(oActivoFijo,datoActivo.vehiculo,datoActivo.Edificio,datoActivo.Terreno,datoActivo.EquipoMaqui,datoActivo.Articulo,datoActivo.Muebles))
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
                    MessageBox.Show("Error al guardar datos del grupo asignado", msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(msj.Vacio, msj.Titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnGuardar.Enabled = true;
        }
    }
}
