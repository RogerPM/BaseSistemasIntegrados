using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.Seguridad
{
	public class clsMenu
	{
		public int IdMenu{ get; set; }
        public int IdModulo { get; set; }
		public Nullable<int> IdPadre{ get; set; } 
		public string Descripcion{ get; set; } 
		public int PosicionMenu{ get; set; } 
		public bool HabilitadoMenu{ get; set; }
        public bool FormularioAsociado { get; set; } 
		public int IndexIcono{ get; set; }
        public string NombreFormulario { get; set; } 
		public string NombreAssembly{ get; set; } 
	public clsMenu(){ }
	}
}
