using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace clases.Seguridad
{
    public class clsEmpresa
    {
        public int idEmpresa { get; set; }
        public string razonSocial { get; set; }
        public string nombreComercial { get; set; }
        public string ruc { get; set; }
        public string direccion { get; set; }
        //public int idImagen { get; set; }
        //public string logo { get; set; }
        //public string fondo { get; set; }
        public byte[] logotipo { get; set; }//para guardar tipo image en la DB
       // public MemoryStream imagen { get; set; } //using System.IO;
        public DateTime fechaInicioSistema { get; set; }
        public string correo { get; set; }
        public string sitioWeb { get; set; }
        public string sector { get; set; }
        public string descripcion { get; set; }
        public int idEstado { get; set; }


        public clsEmpresa()
        {

        }

    }
}
