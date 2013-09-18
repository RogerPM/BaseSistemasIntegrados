using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Inventario
{
    public class clsArticulo
    {

        public int EmpresaArt { get; set; }
        public int IdArt { get; set; }
        public string DescArt { get; set; }
        public DateTime FProduccion { get; set; }
        public int CantMinima { get; set; }
        public int CantMaxima { get; set; }
        public int CantActual { get; set; }
        public int UMed { get; set; }
        public DateTime FCaducidad { get; set; }
        public int TipoArt { get; set; }
        public int GrupoArt { get; set; }
        public int TipoChasis { get; set; }
        public string SChasis { get; set; }
        public int TipoMotor { get; set; }
        public string SMotor { get; set; }
        public string NPlaca { get; set; }
        public int TipoComb { get; set; }
        public int ColorArt { get; set; }
        public int MarcaArt { get; set; }
        public int ModeloArt { get; set; }
        public int TipoMat { get; set; }
        public string ObservArt { get; set; }
        public int EstArt { get; set; }


        public clsArticulo() { }
    }
}
