using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace Core.Erp.Info.TECAv8Entities
{
	public class clsMenuXUsuario
	{
        public int IdEmpresa { get; set; }
		public string NombreUsuario{ get; set; } 
		public string Contrasena{ get; set; } 
		public int IdMenu{ get; set; } 
		public Nullable<int> IdModulo{ get; set; } 
		public Nullable<int> IdPadre{ get; set; } 
		public string Descripcion{ get; set; } 
		public string NombreFormulario{ get; set; } 
		public string NombreAssembly{ get; set; } 
		public Nullable<int> IdEstado{ get; set; } 
		public int IdPerfil{ get; set; } 
		public int IdPermiso{ get; set; } 
		public Nullable<int> Expr1{ get; set; } 
		public Nullable<int> Expr2{ get; set; } 
		public Boolean Lectura{ get; set; } 
		public Boolean Escritura{ get; set; } 
		public Boolean Eliminacion{ get; set; }
        public clsMenuXUsuario() { }     
	}
}
