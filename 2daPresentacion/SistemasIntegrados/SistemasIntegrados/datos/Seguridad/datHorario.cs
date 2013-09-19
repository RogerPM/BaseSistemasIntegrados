using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Seguridad;

namespace datos.Seguridad
{
    public class datHorario
    {
        int GetId() 
        {
            try
            {
                int id=0;
                using (TECAv8Entities Context = new TECAv8Entities())
                {
                    var Cons = from q in Context.Horario
                               select q;

                    id = Cons.Count() + 1;
                }

                return id;
            }
            catch (Exception)
            {

                return 0;
            }
        }


        public void Guardar(clsHorario Info) 
        {
            using (TECAv8Entities Context = new TECAv8Entities())
            {
                var contact = Horario.CreateHorario(0,0,0, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
                var Address = new Horario();
                Address.IdHorario =GetId();
                Address.IdPerfil = Info.IdPerfil;
                Address.dia = Info.dia;
                Address.H00 = Info.H00;
                Address.H01 = Info.H01;
                Address.H02 = Info.H02;
                Address.H03 = Info.H03;
                Address.H04 = Info.H04;
                Address.H05 = Info.H05;
                Address.H06 = Info.H06;
                Address.H07 = Info.H07;
                Address.H08 = Info.H08;
                Address.H09 = Info.H09;
                Address.H10 = Info.H10;
                Address.H11 = Info.H11;
                Address.H12 = Info.H12;
                Address.H13 = Info.H13;
                Address.H14 = Info.H14;
                Address.H15 = Info.H15;
                Address.H16 = Info.H16;
                Address.H17 = Info.H17;
                Address.H18 = Info.H18;
                Address.H19 = Info.H19;
                Address.H20 = Info.H20;
                Address.H21 = Info.H21;
                Address.H22 = Info.H22;
                Address.H23 = Info.H23;
                contact = Address;
                Context.Horario.AddObject(contact);
                Context.SaveChanges();
            
            }
        }

        public List<clsHorario> COnsultar(int IdPerfil)
        {
            try
            {
                using (TECAv8Entities Oen = new TECAv8Entities())
                {

                    string query = "select * from Seguridad.Horario where IdPerfil=" + IdPerfil;
                    return Oen.ExecuteStoreQuery<clsHorario>(query).ToList() ;
                }

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
