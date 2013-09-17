using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases.Seguridad;

namespace forms.Seguridad
{
    public partial class frmCrearPerfil : Form
    {
        public frmCrearPerfil()
        {
            InitializeComponent();
        }

        private void frmCrearPerfil_Load(object sender, EventArgs e)
        {
            List<clsHorario> lista = new List<clsHorario>();
            for (int i = 0; i < 25; i++)
            {
                clsHorario cls = new clsHorario();
                cls._Hora = i.ToString() + ":00";
                cls._Lunes = true;
                cls._Martes = true;
                cls._Miercoles = true;
                cls._Jueves = true;
                cls._Viernes = true;
                cls._Sabado = true;
                cls._Domingo = true;
                lista.Add(cls);
            }
            gridControl1.DataSource = lista;
        }
    }
}
