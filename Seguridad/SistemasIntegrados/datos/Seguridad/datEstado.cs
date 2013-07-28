using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//otros
using clases.Seguridad;

namespace datos.Seguridad
{
    public class datEstado
    {

        #region "Funciones populares"
        
        //metodo que retorna la descripcion de un estado segun su Id
        public string getDescripcionSegunId(int id)
        {
            try
            {
                using (TECAv8Entities ent = new TECAv8Entities())
                {
                    var x = (from a in ent.Estado where a.IdEstado == id select a).First();
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
        public int getIdSegunDescripcion(string descrip)
        {
            try
            {
                using (TECAv8Entities ent = new TECAv8Entities())
                {
                    var x = (from a in ent.Estado where a.Descripcion == descrip select a).First();
                    return x.IdEstado; //se lo puede cambiar y devolver el objeto x que en realidad es un objeto estado lleno con valores correcto segun la base
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encontro, Error: " + e);
                return 0;
            }
        }

        public clsEstado Consultar(clsEstado Estado)
        {
            try
            {
                TECAv8Entities ent = new TECAv8Entities();
                if (Estado.idEstado == 0)
                {//si no existe id en el objeto busca por descripcion
                    var x = (from a in ent.Estado where a.Descripcion == Estado.descripcion select a).First();
                    Estado.idEstado = x.IdEstado;
                    Estado.descripcion = x.Descripcion;
                    return Estado;
                }
                else
                { //caso contrario significa que si exite Id en objeto
                    var x = (from a in ent.Estado where a.IdEstado == Estado.idEstado select a).First();
                    Estado.idEstado = x.IdEstado;
                    Estado.descripcion = x.Descripcion;
                    return Estado;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No encontrado, Error: " + e);
                //en caso de excepcion
                Estado.idEstado = 0;
                Estado.descripcion = null;
                return Estado;
            }
        }

        //recibe un objeto estado, busca segun descripcion, si NO existe lo guarda
        //al final retorna un objeto estado con el idEstado y descripcion deseados  
        public clsEstado GuardarNuevoEstado(clsEstado oEstadoEntrante)
        {
            clsEstado oEstadoSaliente = new clsEstado();
            try
            {
                int x = getIdSegunDescripcion(oEstadoEntrante.descripcion);
                if (x == 0)
                {
                    int id = getIdSiguiente();
                    using (TECAv8Entities ent = new TECAv8Entities())
                    {
                        Estado estado = new Estado()
                        {
                            IdEstado = oEstadoEntrante.idEstado,
                            Descripcion = oEstadoEntrante.descripcion
                        };
                        ent.AddToEstado(estado);
                        ent.SaveChanges();
                        oEstadoSaliente = oEstadoEntrante;
                        return oEstadoSaliente;//devuelve el id de ese estado guardado
                    }
                }
                else
                {
                    oEstadoEntrante.idEstado = getIdSegunDescripcion(oEstadoEntrante.descripcion);
                    oEstadoSaliente = oEstadoEntrante;
                    return oEstadoSaliente;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return oEstadoSaliente;
            }
        }

        #endregion


        #region "Funciones en desarrollo"

        public List<clsEstado> ConsultaTodos() {
            try
            {
                List<clsEstado> lista = new List<clsEstado>();
                TECAv8Entities ent = new TECAv8Entities();
                var con = (from w in ent.Estado select w).Take(7);
                foreach (var item in con)
                {
                    clsEstado e = new clsEstado();
                    e.idEstado = item.IdEstado;
                    e.descripcion = item.Descripcion;
                    lista.Add(e);
                }
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Consulta estado Error:" +ex);
                return null;
            }
        }

        public int Guardar(string descripcion)
        {//se recomienda no usar
            try
            {
                int id = getIdSiguiente();
                using (TECAv8Entities ent = new TECAv8Entities())
                {
                    Estado estado = new Estado()
                    {
                        IdEstado = id,
                        Descripcion = descripcion
                    };
                    ent.AddToEstado(estado);
                    ent.SaveChanges();
                    return id;//devuelve el id de ese estado guardado
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 0;
            }
        }



        //obtener id siguiente
        public int getIdSiguiente()
        {
            try
            {
                TECAv8Entities ent = new TECAv8Entities();
                int x = ((from a in ent.Estado select a.IdEstado).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }



        public clsEstado GuardarSimple(clsEstado oEntrante)
        {
            clsEstado oSaliente = new clsEstado();
            try
            {
                oSaliente = Consultar(oEntrante);
                if (oSaliente.idEstado == 0)
                {
                    int id = getIdSiguiente();
                    using (TECAv8Entities ent = new TECAv8Entities())
                    {
                        Estado estado = new Estado()
                        {
                            IdEstado = id,
                            Descripcion = oEntrante.descripcion
                        };
                        ent.AddToEstado(estado);
                        ent.SaveChanges();
                        oSaliente.idEstado = id;
                        oSaliente.descripcion = oEntrante.descripcion;
                        return oSaliente;//devuelve el id de ese estado guardado
                    }
                }
                else
                {
                    oSaliente = oEntrante;
                    return oSaliente;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return oSaliente;
            }
        }
        
        #endregion


    }
}
