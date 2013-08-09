using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Taller;

namespace datos.Taller
{
    public class datArticulo
    {
        //obtener id siguiente para guardar la empresa
        public int getIdSiguiente()
        {
            try
            {
                TallerEntities ent = new TallerEntities();
                int x = ((from a in ent.Articulo select a.IdArticulo).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }

        //para consultar todos
        public List<clsArticulo> Consultar()
        {
            try
            {
                List<clsArticulo> listaArticulo = new List<clsArticulo>();
                TallerEntities ent = new TallerEntities();
                var con = from w in ent.Articulo select w;
                foreach (var item in con)
                {
                    clsArticulo e = new clsArticulo();
                    e.IdArticulo = item.IdArticulo;
                    e.Descripcion = item.Descripcion;
                    e.FechaProduccion = Convert.ToDateTime(item.FechaProduccion);
                    e.CantidadMinima = Convert.ToInt32(item.CantidadMinima);
                    e.CantidadMaxima = Convert.ToInt32(item.CantidadMaxima);
                    e.CantidadActual = Convert.ToInt32(item.CantidadActual);
                    e.IdUnidadMedida = item.IdUnidadMedida;
                    //e.IdTipoArticulo = item.IdTipoArticulo;
                    e.IdGrupo = item.IdGrupo;
                    e.IdChasis = item.IdChasis;
                    e.IdTipoMotor = item.IdTipoMotor;
                    e.NroPlaca = item.NroPlaca;
                    e.IdTipoCombustible = item.IdTipoCombustible;
                    e.IdColor = item.IdColor;
                    e.IdMarca = item.IdMarca;
                    e.IdModelo = item.IdModelo;
                    e.IdTipoMaterial = item.IdTipoMaterial;
                    e.Observacion = item.Observacion;
                    e.IdEmpresa = item.IdEmpresa;
                    e.IdUsuario = item.IdUsuario;
                    e.IdEstado = item.IdEstado;

                    listaArticulo.Add(e);
                }
                return listaArticulo;

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error datTipoTrabajo: " + ex);
                return null;
            }
        }

        public bool Guardar(clsArticulo e)
        {
            try
            {
                int id = getIdSiguiente();
                e.IdArticulo = id;
                using (TallerEntities ent = new TallerEntities())
                { //se instancia el entity para poder usar los nombres de las tablas
                    Articulo articulo = new Articulo()
                    {
                        IdEmpresa = e.IdEmpresa,
                        IdArticulo = e.IdArticulo,
                        Descripcion = e.Descripcion,
                        FechaProduccion = e.FechaProduccion,
                        CantidadMinima = e.CantidadMinima,
                        CantidadMaxima = e.CantidadMaxima,
                        CantidadActual = e.CantidadActual,
                        IdUnidadMedida = e.IdUnidadMedida,
                        //IdTipoArticulo = e.IdTipoArticulo,
                        IdGrupo = e.IdGrupo,
                        //IdSubGrupo = e.IdSubGrupo,
                        IdChasis = e.IdChasis,
                        IdTipoMotor = e.IdTipoMotor,
                        NroPlaca = e.NroPlaca,
                        IdTipoCombustible = e.IdTipoCombustible,
                        IdColor = e.IdColor,
                        IdMarca = e.IdMarca,
                        IdModelo = e.IdModelo,
                        IdTipoMaterial = e.IdTipoMaterial,
                        Observacion = e.Observacion,
                        IdUsuario = e.IdUsuario,
                        IdEstado = e.IdEstado,
                    };
                    ent.AddToArticulo(articulo);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar: " + ex);
                Console.Read();
                return false;
            }
        }

        public bool Modificar(clsArticulo e)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    //busca por PK el primero que encuentre lo coge
                    var x = (from a in ent.Articulo where a.IdArticulo == e.IdArticulo select a).First();

                    x.IdArticulo = e.IdArticulo;
                    x.Descripcion = e.Descripcion;
                    x.FechaProduccion = e.FechaProduccion;
                    x.CantidadMinima = e.CantidadMinima;
                    x.CantidadMaxima = e.CantidadMaxima;
                    x.CantidadActual = e.CantidadActual;
                    x.IdUnidadMedida = e.IdUnidadMedida;
                    //x.IdTipoArticulo = e.IdTipoArticulo;
                    x.IdGrupo = e.IdGrupo;
                    x.IdChasis = e.IdChasis;
                    x.IdTipoMotor = e.IdTipoMotor;
                    x.NroPlaca = e.NroPlaca;
                    x.IdTipoCombustible = e.IdTipoCombustible;
                    x.IdColor = e.IdColor;
                    x.IdMarca = e.IdMarca;
                    x.IdModelo = e.IdModelo;
                    x.IdTipoMaterial = e.IdTipoMaterial;
                    x.Observacion = e.Observacion;
                    x.IdEstado = e.IdEstado;

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

        public bool Eliminar(clsArticulo e)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    //busca por PK el primero que encuentre lo coge
                    var x = (from a in ent.Articulo where a.IdArticulo == e.IdArticulo select a).First();
                    ent.DeleteObject(x);//elimina el registro
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eliminar Error: " + ex);
                return false;

            }
        }

        //PARA LA MARCA
        //metodo que retorna la descripcion de un estado segun su Id
        public string getDescripcionSegunIdMarca(int? id)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.Marca where a.IdMarca == id select a).First();
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
        public int getIdSegunDescripcionMarca(string descrip)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.Marca where a.Descripcion == descrip select a).First();
                    return x.IdMarca; //se lo puede cambiar y devolver el objeto x que en realidad es un objeto estado lleno con valores correcto segun la base
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encontro, Error: " + e);
                return 0;
            }
        }


        //PARA EL MODELO
        public string getDescripcionSegunIdModelo(int? id)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.Modelo where a.IdModelo == id select a).First();
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
        public int getIdSegunDescripcionModelo(string descrip)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.Modelo where a.Descripcion == descrip select a).First();
                    return x.IdModelo; //se lo puede cambiar y devolver el objeto x que en realidad es un objeto estado lleno con valores correcto segun la base
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encontro, Error: " + e);
                return 0;
            }
        }


        //PARA EL COLOR
        public string getDescripcionSegunIdColor(int? id)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.Color where a.IdColor == id select a).First();
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
        public int getIdSegunDescripcionColor(string descrip)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.Color where a.Descripcion == descrip select a).First();
                    return x.IdColor; //se lo puede cambiar y devolver el objeto x que en realidad es un objeto estado lleno con valores correcto segun la base
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encontro, Error: " + e);
                return 0;
            }
        }



        //PARA EL TIPO MOTOR
        public string getDescripcionSegunIdMotor(int? id)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.TipoMotor where a.IdTipoMotor == id select a).First();
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
        public int getIdSegunDescripcionMotor(string descrip)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.TipoMotor where a.Descripcion == descrip select a).First();
                    return x.IdTipoMotor; //se lo puede cambiar y devolver el objeto x que en realidad es un objeto estado lleno con valores correcto segun la base
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encontro, Error: " + e);
                return 0;
            }
        }



        //PARA EL TIPO COMBUSTIBLE
        public string getDescripcionSegunIdCombustible(int? id)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.TipoCombustible where a.IdTipoCombustible == id select a).First();
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
        public int getIdSegunDescripcionCombustible(string descrip)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.TipoCombustible where a.Descripcion == descrip select a).First();
                    return x.IdTipoCombustible; //se lo puede cambiar y devolver el objeto x que en realidad es un objeto estado lleno con valores correcto segun la base
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encontro, Error: " + e);
                return 0;
            }
        }

        //PARA EL TIPO COMBUSTIBLE
        public string getDescripcionSegunIdChasis(int? id)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.Chasis where a.IdChasis == id select a).First();
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
        public int getIdSegunDescripcionChasis(string descrip)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.Chasis where a.Descripcion == descrip select a).First();
                    return x.IdChasis; //se lo puede cambiar y devolver el objeto x que en realidad es un objeto estado lleno con valores correcto segun la base
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encontro, Error: " + e);
                return 0;
            }
        }


        //PARA EL TIPO MATERIAL
        public string getDescripcionSegunIdTipoMaterial(int? id)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.TipoMaterial where a.IdTipoMaterial == id select a).First();
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
        public int getIdSegunDescripcionTipoMaterial(string descrip)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.TipoMaterial where a.Descripcion == descrip select a).First();
                    return x.IdTipoMaterial; //se lo puede cambiar y devolver el objeto x que en realidad es un objeto estado lleno con valores correcto segun la base
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encontro, Error: " + e);
                return 0;
            }
        }


        //PARA LA UNIDAD DE MEDIDA
        public string getDescripcionSegunIdUnidadMedida(int? id)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.UnidadMedida where a.IdUnidadMedida == id select a).First();
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
        public int getIdSegunDescripcionUnidadMedida(string descrip)
        {
            try
            {
                using (TallerEntities ent = new TallerEntities())
                {
                    var x = (from a in ent.UnidadMedida where a.Descripcion == descrip select a).First();
                    return x.IdUnidadMedida; //se lo puede cambiar y devolver el objeto x que en realidad es un objeto estado lleno con valores correcto segun la base
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encontro, Error: " + e);
                return 0;
            }
        }

    }
}
