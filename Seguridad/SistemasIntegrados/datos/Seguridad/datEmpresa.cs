using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//otros usings
using clases.Seguridad;
using System.IO;

namespace datos.Seguridad
{
    public class datEmpresa
    {
        //obtener id siguiente para guardar la empresa
        public int getIdSiguiente(){
            try
            {
                TECAv8Entities ent = new TECAv8Entities();
                int x = ((from a in ent.Empresa select a.IdEmpresa).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }

        //para consultar todos
        public List<clsEmpresa> Consultar()
        {
            try
            {
                List<clsEmpresa> listaEmpresa = new List<clsEmpresa>();
                TECAv8Entities ent = new TECAv8Entities();
                var con = from w in ent.Empresa select w;
                foreach (var item in con)
                {
                    clsEmpresa e = new clsEmpresa();
                    e.idEmpresa = item.IdEmpresa;
                    e.razonSocial = item.RazonSocial;
                    e.nombreComercial = item.NombreComercial;
                    e.ruc = item.Ruc;
                    //e.idTelefono = Convert.ToInt32(item.IdTelefono); //tabla de Recursos humanos
                    e.direccion = item.Direccion;
                    //e.idImagen = item.IdImagen;
                    e.idImagen = 0;
                    e.logo = null;
                    e.fondo = null;
                    e.logotipo = item.Logotipo;
                    //e.fechaInicioSistema = Convert.ToDateTime(item.FechaInicioSistema);
                    e.fechaInicioSistema = DateTime.Today;
                    e.correo = item.Correo;
                    e.sitioWeb = item.SitioWeb;
                    e.descripcion = item.Descripcion;
                    e.idEstado = Convert.ToInt32(item.IdEstado);
                    listaEmpresa.Add(e);
                }
                return listaEmpresa;

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datEmpresa: " +ex);
                return null;
            }
        }

        public bool Guardar(clsEmpresa e) {
            try
            {
                int id = getIdSiguiente();
                e.idEmpresa = id;
                using (TECAv8Entities ent = new TECAv8Entities())
                { //se instancia el entity para poder usar los nombres de las tablas
                    Empresa empresa = new Empresa()
                    {
                        IdEmpresa = e.idEmpresa,
                        RazonSocial = e.razonSocial,
                        NombreComercial = e.nombreComercial,
                        Ruc = e.ruc,
                        Direccion = e.direccion,
                        //IdImagen = e.idImagen,
                        //Logo = e.logo,
                        //Fondo = e.fondo,
                        Logotipo=e.logotipo,
                        //FechaInicioSistema = e.fechaInicioSistema,
                        Correo = e.correo,
                        SitioWeb = e.sitioWeb,
                        Descripcion = e.descripcion,
                        IdEstado = e.idEstado
                    };
                    //ent.AddObject("Empresa", empresa);
                    ent.AddToEmpresa(empresa);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar: " +ex);
                return false;
            }
        }

        //metodo que retorna el nombre de la empresa segun Id que se le envia
        public string ConsultarPorId(int id) {
            using (TECAv8Entities ent = new TECAv8Entities()) {
                var x = (from a in ent.Empresa where a.IdEmpresa == id select a).First();
                return x.NombreComercial;
            }
        }

        //metodo que devuelve el Id de la empresa segun el nombre comercial que se le envia
        public int ConsultarPorNombreComercial(string nombre){
            using (TECAv8Entities ent = new TECAv8Entities())
            {
                var x = (from a in ent.Empresa where a.NombreComercial == nombre select a).First();
                return x.IdEmpresa;
            }
        } 

        public bool Modificar(clsEmpresa e){
            try
            {
                using (TECAv8Entities ent = new TECAv8Entities()) {
                //busca por PK el primero que encuentre lo coge
                var x = (from a in ent.Empresa where a.IdEmpresa == e.idEmpresa select a).First();
                x.RazonSocial = e.razonSocial;
                x.NombreComercial = e.nombreComercial;
                x.Ruc = e.ruc;
                x.Direccion = e.direccion;
              //  x.IdImagen = e.idImagen;
               // x.Logo = e.logo;
              //  x.Fondo = e.fondo;
              //  x.FechaInicioSistema = e.fechaInicioSistema;
                x.Correo = e.correo;
                x.SitioWeb = e.sitioWeb;
                x.Descripcion = e.descripcion;
                x.IdEstado = e.idEstado;
                ent.SaveChanges();
            }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " +ex);
                return false;
            }
 
        }

        //eliminado fisico.. no usar solo seguridad
        public void Eliminar(clsEmpresa e){
            using (TECAv8Entities ent = new TECAv8Entities())
            {
                //busca por PK el primero que encuentre lo coge
                var x = (from a in ent.Empresa where a.IdEmpresa == e.idEmpresa select a).First();
                ent.DeleteObject(x);//elimina el registro
                ent.SaveChanges();
            }
        }
  
    }//close public class
}
