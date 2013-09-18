using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.ActivoFijo;
using datos.Inventario;
using datos.Seguridad;

namespace datos.ActivoFijo
{
    public class clsClaseDatosSubgrupoActivoFijo
    {

        #region"Funiciones de Programa"

        /*****Funciones que corresponderan a la calse de Inventario.Grupo*****/

        //metodo que retorna la descripcion de un estado segun su Id
        public string getDescripcionSegunIdActivoFIjoSubGrupo(int id)
        {
            try
            {
                using (ActivoFijoEntities  ent = new ActivoFijoEntities())
                {
                    var x = (from a in ent.SubGrupos where a.IdSubGrupo == id select a).First();
                    return x.Descripcion;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return null;
            }
        }

        //metodo que retorna el Id de un estado segun su descripcion
        public int getIdSegunDescripcionActivoFIjoSubGrupo(string descrip)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    var x = (from a in ent.SubGrupos  where a.Descripcion == descrip select a).First();
                    return x.IdSubGrupo; //se lo puede cambiar y devolver el objeto x que en realidad es un objeto estado lleno con valores correcto segun la base
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encontro, Error: " + e);
                return 0;
            }
        }



        public int getSiguiente()
        {
            try
            {
                ActivoFijoEntities ent = new ActivoFijoEntities();
                int x = ((from a in ent.SubGrupos select a.IdSubGrupo).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1;
            }
        }

        #endregion



        #region"Operaciones Basicas"
        public List<clsSubgrupoActivoFijo> consulta()
        {
            try
            {
                List<clsSubgrupoActivoFijo> lista = new List<clsSubgrupoActivoFijo>();
                ActivoFijoEntities ent = new ActivoFijoEntities();
                var con = from w in ent.SubGrupos select w;

                foreach (var item in con)
                {
                    clsSubgrupoActivoFijo  clas = new clsSubgrupoActivoFijo();
                    clas.Codigo = item.IdSubGrupo;
                    clas.Grupo =  Convert.ToInt32(item.IdGrupo);
                    clas.descripcion = item.Descripcion;
                    clas.Fecha = Convert.ToDateTime(item.fecha);
                    clas.IdEstado = Convert .ToInt32(item.IdEstado);
                    //clas._EstadoProceso = item.EstadoProceso;
                    clas.Empresa = Convert.ToInt32 (item.IdEmpresa);

                    lista.Add(clas);
                }
                return lista ;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public Boolean  modificar (clsSubgrupoActivoFijo SubActivo){
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    //Se hace un primary key codigo 
                    var x = (from q in ent.SubGrupos where q.IdSubGrupo == SubActivo.Codigo select q).First();
                    //First obtiene un registro que coincida con el codigo y luego mas a bajo
                    //modifico dicho registro y guardo eso lo modifica en la base 
                    x.IdSubGrupo = SubActivo.Codigo;
                    x.IdGrupo = SubActivo.Grupo;
                    x.Descripcion = SubActivo.descripcion;
                    x.fecha = SubActivo.Fecha;
                    x.IdEstado = SubActivo.IdEstado;
                    x.IdEmpresa = SubActivo.Empresa;
                   // x.EstadoProceso = SubActivo._EstadoProceso;
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                
                return false;
            }
           
                
        }

        public Boolean guardar(clsSubgrupoActivoFijo  SubActivo)
        {
            try
            {
                int id=getSiguiente();
                SubActivo.Codigo = id;
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    SubGrupos Sub = new SubGrupos()
                    {
                        IdSubGrupo = SubActivo.Codigo,
                        IdGrupo = SubActivo.Grupo,
                        Descripcion = SubActivo.descripcion,
                        fecha = SubActivo.Fecha,
                        IdEstado = Convert.ToInt32(SubActivo.IdEstado),
                        //EstadoProceso = SubActivo._EstadoProceso,
                        IdEmpresa = Convert.ToInt32(SubActivo.Empresa),

                    };
                    
                    ent.AddToSubGrupos(Sub);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                
                return false;
            }
            
        }

        public Boolean  eliminar(clsSubgrupoActivoFijo SubActivo)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    //Hago un wehere por el primaryKey codigo
                    var x = (from q in ent.SubGrupos where q.IdSubGrupo == SubActivo.Codigo select q).First();
                    //Eliminar es muy parecido
                    //Eliminar el registro que me trajpp el select
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


        #endregion



    }
}
