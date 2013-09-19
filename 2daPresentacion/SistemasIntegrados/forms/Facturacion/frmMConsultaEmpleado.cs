using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using datos.RecursosHumanos;
using clases.RecursosHumanos;

namespace forms.Facturacion
{
    public partial class frmMConsultaEmpleado : Form
    {

        public clsPersona p = new clsPersona();   
        public frmMConsultaEmpleado()
        {
            InitializeComponent();
        }

     

       

            public void Cargar()
        {
            clsDatosPersona  Persoana = new clsDatosPersona();
            gdPersona .DataSource = Persoana.ConsultaPersona();
        }
           
        

        public void getSeleccion()
        {
            p.IdPersona = Convert.ToInt32(gvEmpleado.GetFocusedRowCellValue(colIdPersona));
            p.Identificacion = Convert.ToInt32  ( gvEmpleado.GetFocusedRowCellValue  (colIdentificacion ));
            p.NombreRazonSocial = Convert .ToString ( gvEmpleado.GetFocusedRowCellValue(colNombreRazonSocial));
            p.Apellido = Convert.ToString(gvEmpleado.GetFocusedRowCellValue(colApellido));

            if (gvEmpleado.GetFocusedRowCellValue(colgenero) == "M")
            {
                p.genero= "M";

            }
            else
            {
                p.genero = "F";
            }
            p.FechaNacimiento = Convert.ToDateTime(gvEmpleado.GetFocusedRowCellValue(colFechaNacimiento));
            p.direccion = Convert.ToString(gvEmpleado.GetFocusedRowCellValue(coldireccion));
            p.direccion = Convert.ToString(gvEmpleado.GetFocusedRowCellValue(coldireccion));
            p.mail = Convert.ToString(gvEmpleado.GetFocusedRowCellValue(colmail));
            p.General = Convert.ToInt32(gvEmpleado.GetFocusedRowCellValue(colGeneral));
            p.Movil = Convert.ToInt32(gvEmpleado.GetFocusedRowCellValue(colMovil));
            p.Casa = Convert.ToInt32(gvEmpleado.GetFocusedRowCellValue(colCasa));
            p.Otros = Convert.ToInt32(gvEmpleado.GetFocusedRowCellValue(colOtros));
            p.IdEstado = Convert.ToInt32(gvEmpleado.GetFocusedRowCellValue(colIdEstado));



           // p.IdPersona =gdPersona .
            //p.Identificacion =gdPersona.get  gridView1.GetFocusedRowCellValue(1);
           // p.Identificacion  = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colIdentificacion));
            //p.NombreRazonSocial = gridView1.GetFocusedRowCellValue(colNombreRazonSocial);
            //p.Apellido   = gridView1.GetFocusedRowCellValue(colNombre);

        }


        

      
       

        private void tsbConsultado_Click_1(object sender, EventArgs e)
        {
            getSeleccion();
            this.Close();
        }

        private void frmMConsultaEmpleado_Load_1(object sender, EventArgs e)
        {
            Cargar();
        }

       



    }
}
