using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace clases.Seguridad
{
    public class clsImagen
    {

        public int IdImagen { get; set; }        
        public string Descripcion { get; set; }
        public byte[] Imagen { get; set; }
        public MemoryStream ayuda { get; set; }
        

        public clsImagen()
        {

        }
    }
}
