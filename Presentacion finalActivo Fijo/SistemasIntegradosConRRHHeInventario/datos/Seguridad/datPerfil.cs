using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Seguridad;

namespace datos.Seguridad
{
    public class datPerfil
    {

        #region "funcional usando linq-entity"
        public List<clsPerfil> ConsultarTodos() {
            try
            {
                List<clsPerfil> listaPerfil = new List<clsPerfil>();
                TECAv8Entities ent = new TECAv8Entities();
                var query = from a in ent.Perfil select a;
                foreach (var item in query)
                {
                    clsPerfil p = new clsPerfil();
                    p.IdPErfil = item.IdPerfil;
                    p.Descripcion = item.Descripcion;
                    p.IdEstado = Convert.ToInt32(item.IdEstado);
                    listaPerfil.Add(p);
                }
                return listaPerfil;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error"+ ex);
                return null;
            }
        }
        #endregion

        public List<Perfil> ConsultarPerfiles()
        {
            using (TECAv8Entities entity = new TECAv8Entities())
            {
                return entity.ExecuteStoreQuery<Perfil>("select * from Seguridad.Perfil").ToList();
            }

        }
        public Boolean Guardar(clsPerfil Info, ref int IdPerfil)
        {

            try
            {
                using (TECAv8Entities Context = new TECAv8Entities())
                {
                    var contact = Perfil.CreatePerfil(0);
                    var address = new Perfil();
                    address.IdEstado = Info.IdEstado;
                    address.Descripcion = Info.Descripcion;
                    address.IdPerfil = IdPerfil = GetId();

                    contact = address;
                    Context.Perfil.AddObject(contact);
                    Context.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        int GetId()
        {
            try
            {
                int id = 0;

                using (TECAv8Entities Context = new TECAv8Entities())
                {
                    var Consulta = from q in Context.Perfil
                                   select q;

                    id = Consulta.Count() + 1;

                }


                return id;

            }
            catch (Exception)
            {

                return 0;
            }
        }


        public List<clsPerfil> Consulltar()
        {
            try
            {

                using (TECAv8Entities oent = new TECAv8Entities())
                {

                    string quert = "select * from Seguridad.Perfil";
                    return oent.ExecuteStoreQuery<clsPerfil>(quert).ToList();
                }


            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
