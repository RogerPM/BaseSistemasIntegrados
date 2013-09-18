using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Seguridad
{
    public class clsMensajeSeguridad
    {
        public string Titulo = "TECA - Módulo de seguridad";
        public string Editar_ok = "Información editada con éxito";
        public string Guardar_ok = "Información guardada con éxito";

        public string Editar_error = "Ocurrió un error cuando se intentaba editar los datos";
        public string Guardar_error = "Ocurrió un error cuando se intentaba guardar los datos";
        public string Eliminar_error = "Ocurrió un error cuando se intentaba eliminar los datos";
        public string Eliminar_ok = "Información eliminada con éxito";

        public string Eliminar_confirmacion = "Esta seguro que desea eliminar el registro?";

        
        public string ErrorLogin = "Ha escrito mal su nombre de usuario, contraseña y/o seleccionado la empresa incorrecta";
        public string ErrorPermiso = " No tiene derechos para acceder a esta pantalla, favor consulte al administrador del sistema";
        public string ErrorUsuarioNoActivo = ", no es un usuario activo, imposible iniciar sesión favor consulte al administrador del sistema";
        public string Vacio = "Uno o más campos estan vacíos, no se puede continuar el proceso";
        public string NoDatos = "No existen datos para mostrar";
        public string NoExisteUsuario = "Nombre de usuario no existe, consulte al administrador del sistema";
        public string Salir = "Si sale la información actual se perderá, Esta seguro que desea salir?";
    }
}
