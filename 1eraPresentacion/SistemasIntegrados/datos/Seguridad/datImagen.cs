using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using clases.Seguridad;

namespace datos.Seguridad
{
    public class datImagen
    {

        public List<clsImagen> listaimagen()
        {
            try
            {
                List<clsImagen> lista = new List<clsImagen>();
                TECAv8Entities ent = new TECAv8Entities();
                var find = from w in ent.Imagen select w;
                //recorrer el entity de la lista imagen
                foreach (var item in find)
                {
                    clsImagen claseImagen = new clsImagen();
                    claseImagen.IdImagen = item.IdImagen;
                    claseImagen.Descripcion = item.Descripcion;
                    claseImagen.Imagen = item.Imagen1;
                    MemoryStream memoria = new MemoryStream(item.Imagen1);
                    claseImagen.ayuda = memoria;
                    lista.Add(claseImagen);
                }
                return lista;
            }
            catch (Exception)
            {

                return null;
            }
        }


        public Boolean GuardarImagen(clsImagen info)
        {
            try
            {
                using (TECAv8Entities ent = new TECAv8Entities())
                {
                    Imagen img = new Imagen()
                    {
                        IdImagen = info.IdImagen,
                        Descripcion = info.Descripcion,
                        Imagen1 = info.Imagen,
                    };
                    ent.AddToImagen(img);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public bool eliminar(clsImagen ima)
        {
            try
            {
                using (TECAv8Entities ent = new TECAv8Entities())
                {
                    //hago un where por el primarykey codigo
                    var x = (from q in ent.Imagen where q.IdImagen == ima.IdImagen select q).First();
                    //eliminar es muy parecido
                    //elimina el registro que me trajo el select
                    ent.DeleteObject(x);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }


        public bool Modificar(clsImagen e)
        {
            try
            {
                using (TECAv8Entities ent = new TECAv8Entities())
                {
                    //busca por PK el primero que encuentre lo coge
                    var x = (from a in ent.Imagen where a.IdImagen == e.IdImagen select a).First();
                    x.Descripcion = e.Descripcion;
                    x.Imagen1 = e.Imagen;
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return false;
            }

        }

        public clsImagen Consultar(int IdImagen)
        {
            try
            {

                TECAv8Entities ent = new TECAv8Entities();
                var con = from w in ent.Imagen where w.IdImagen == IdImagen select w;
                clsImagen e = new clsImagen();
                foreach (var item in con)
                {
                    e.Descripcion = item.Descripcion;
                    MemoryStream memoria = new MemoryStream(item.Imagen1);
                    e.ayuda = memoria;
                    e.Imagen = item.Imagen1;

                }
                return e;

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datEmpresa: " + ex);
                return null;
            }
        }
    }
}
