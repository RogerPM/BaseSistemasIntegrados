using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.ActivoFijo
{
    public class clsVehiculos
    {
        public int idCodActivoFijo { get; set; }
        public int idMarca { get; set; }
        public int idModelo { get; set; }
        public int idColor { get; set; }
        public int idMotor { get; set; }
        public string serie { get; set; }
        public int idChasis { get; set; }
        public string placa { get; set; }
        public int NumPuertas { get; set; }
        public int AniosDepreciados { get; set; }
        public string  Descripcion { get; set; }
        public int idMaterial { get; set; }
        public string  Matricula { get; set; }
        public string  Transmision { get; set; }
        public double carga { get; set; }
        public double capacidad { get; set; }
        public double kilometraje { get; set; }
        public DateTime  FechaCracion { get; set; }

        
        public clsVehiculos()
        {

        }
    }
}
