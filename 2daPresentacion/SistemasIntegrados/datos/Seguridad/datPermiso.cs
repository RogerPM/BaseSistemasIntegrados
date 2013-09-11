using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace datos.Seguridad
{
    public class datPermiso
    {

        public int GetId(int IdPerfil) 
        {
            int Id = 0;
            using (TECAv8Entities entity = new TECAv8Entities())
            {

                var select = from q in entity.Permiso
                             where q.IdPerfil == IdPerfil
                             select q;

                if (select.ToList().Count < 1)
                {
                    Id = 1;
                }
                else
                {
                    var select_pv = (from q in entity.Permiso
                                     where q.IdPerfil == IdPerfil
                                     select q.IdPerfil).Max();
                    Id = Convert.ToInt32(select_pv.ToString()) + 1;
                }
            
            }

            return Id;
        }
        public Boolean Guardar(List<Permiso> Lst, int IdPerfil , int IdModulo) 
        {
            try
            {
                

                using (TECAv8Entities entity = new TECAv8Entities())
                {
                   int entiero =
                        entity.ExecuteStoreCommand("Delete from Seguridad.Permiso where IdPerfil = "+IdPerfil +"and IdModulo = "+IdModulo);
                }
                    int secuencia = 1;
                    foreach (Permiso item in Lst)
                    {
                        using (TECAv8Entities entity = new TECAv8Entities())
                        {
                            string query = "select isnull(MAX(IdPermiso)+1,1) from Seguridad.Permiso where IdPerfil=" + IdPerfil; 
                            item.IdPermiso = entity.ExecuteStoreQuery<int>(query).ToList().First();
                            secuencia++;
                            entity.AddToPermiso(item);
                            entity.SaveChanges();
                        }
                    }
                    
                

                return true;
            }
            catch (Exception)
            {
                return false;   
            }
        }
        public List<Permiso> Consultar(int IdPerfil, int IdModulo)
        {
            using (TECAv8Entities Entity = new TECAv8Entities())
            {
                return Entity.ExecuteStoreQuery<Permiso>("select *from Seguridad.Permiso where IdPerfil="+IdPerfil+" and IdModulo="+IdModulo).ToList();
            }

        }


    }
}
