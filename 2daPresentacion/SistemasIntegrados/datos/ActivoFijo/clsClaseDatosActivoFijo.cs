using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.ActivoFijo;
using datos.Inventario;

namespace datos.ActivoFijo
{
    public class clsClaseDatosActivoFijo
    {
        private clsActivoFijo clas = new clsActivoFijo();
        public double AniosDepreciar(string Descripcion)
        {
            if (Descripcion=="Vehiculos")
            {
                    return clas.aniosDepreciable_Vehiculos ;
            }
            else
            {
                if (Descripcion=="MueblesyEnseres")
                {
                    return clas.aniosDepreciable_MueblesEnseres;
                }
                else
                {
                    if (Descripcion =="Equipos")
                    {
                        return clas.aniosDepreciable_EquiposCompu;
                    }
                    else
                    {
                        if (Descripcion =="Maquinarias")
                        {
                            return clas.aniosDepreciable_Maquinarias;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                } 
            }
        }

    #region"Funiciones de Programa"

        /*****Funciones que corresponderan a la calse de ActivoFijo*****/

        //metodo que retorna la descripcion de un estado segun su Id
        public string getDescripcionSegunIdActivoFijo(int id)
        {
            try
            {
                using ( ActivoFijoEntities  ent = new ActivoFijoEntities ())
                {
                    var x = (from a in ent.ActivoFijo  where a.IdActivoFijo == id select a).First();
                    return x.descripcion;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return null;
            }
        }

        //metodo que retorna el Id de un estado segun su descripcion
        public int getIdSegunDescripcionSegunIdActivoFijo(string descrip)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    var x = (from a in ent.ActivoFijo where a.descripcion == descrip select a).First();
                    return x.IdActivoFijo; //se lo puede cambiar y devolver el objeto x que en realidad es un objeto estado lleno con valores correcto segun la base
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
                int x = ((from a in ent.ActivoFijo select a.IdActivoFijo).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1;
            }
        }

        /*****Funciones que corresponderan a la calse de Inventario.Grupo*****/

        public string getDescripcionSegunIdInventarioGrupo(int id)
        {
            try
            {
                using (INVENTARIOEntities ent = new INVENTARIOEntities())
                {
                    var x = (from a in ent.Grupo where a.IdGrupo == id select a).First();
                    return x.Descripcion;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return null;
            }
        }

        public int getIdSegunDescripcionInventarioGrupo(string descrip)
        {
            try
            {
                using (INVENTARIOEntities ent = new INVENTARIOEntities())
                {
                    var x = (from a in ent.Grupo where a.Descripcion == descrip select a).First();
                    return x.IdGrupo; //se lo puede cambiar y devolver el objeto x que en realidad es un objeto estado lleno con valores correcto segun la base
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encontro, Error: " + e);
                return 0;
            }
        }

    #endregion 



        public List<clsActivoFijo> consulta()
        {
            try
            {
                List<clsActivoFijo> lista = new List<clsActivoFijo>();
                ActivoFijoEntities ent = new ActivoFijoEntities();
                var con = from w in ent.ActivoFijo select w;

                foreach (var item in con)
                {
                    clsActivoFijo clas = new clsActivoFijo();
                    clas.Codigo = Convert.ToInt32(item.IdActivoFijo);
                    clas.Cantidad = Convert.ToInt32(item.cantidad);
                    clas.Empresa = Convert.ToInt32(item.IdEmpresa);
                    clas.departamento =Convert.ToInt32 ( item.IdDepartamento);
                    clas.responsable = Convert.ToInt32( item.IdResponsable);
                    clas.ArtBodega = Convert.ToInt32(item.IdArticuloBodega);
                    clas.usuario =Convert.ToInt32 ( item.IdUsuario);
                    clas.tipo = Convert.ToInt32 ( item.IdTipo);
                    clas.grupo = Convert.ToInt32 (item.IdGrupo);
                    clas.subgrupo = Convert.ToInt32(item.IdSubgrupo);
                    clas.articulo = Convert.ToInt32 ( item.IdArticulo);
                    clas.proveedor = Convert.ToInt32(item.IdProveedor);
                    clas._EstadoProceso =Convert.ToString (item.EstadoProceso);
                    clas.descripcion = item.descripcion;
                    clas.valor_nominal = Convert.ToDouble (item.valor_nomial);
                    clas.valor_residual = Convert.ToDouble(item.valor_residual);
                    clas.valor_actualserie = Convert.ToDouble(item.valor_actualserie);
                    clas.codigo_barra = Convert.ToInt32 (item.IdCodigoBarra);
                    clas.Fecha_Adquisicion = Convert.ToDateTime(item.fecha_Adquisicion);
                    clas.ano_vidautil = Convert.ToInt32(item.ano_vidaUtil);
                    clas.estado = Convert.ToInt32 ( item.IdEstado);
                    clas.fecha_registro = Convert.ToDateTime ( item.fecha_registro);

                    lista.Add(clas);
                }
                return lista;
            }
            catch (Exception )
            {
                return null;
            }

        }
        //El elminar esta en dudas por que me mencionaron que los procesos no se eliminan 
        //si no que se los anulan es por este motivo que se cambio la base
        //y posiblemente aqi sea la asigancion del campo EstadoProceso a anulado 
        //de la clase de activofijo e base de datos 
        public Boolean eliminar(clsActivoFijo activo)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    //Hago un wehere por el primaryKey codigo
                    var x = (from q in ent.ActivoFijo  where q.IdActivoFijo  == activo.Codigo select q).First();
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

        public Boolean guardar(clsActivoFijo activo)
        {
            try
            {
                int id = getSiguiente();
                activo.Codigo  = id;
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    ActivoFijo act = new ActivoFijo()
                    {
                        IdActivoFijo    =activo.Codigo,
                        cantidad        =activo.Cantidad,
                        IdEmpresa       =activo.Empresa,
                        IdDepartamento  =activo.departamento,
                        IdResponsable   =activo.responsable,
                        IdUsuario       =activo.usuario,
                        IdArticuloBodega=activo.ArtBodega,
                        IdTipo          =activo.tipo,
                        IdGrupo         =activo.grupo,
                        IdSubgrupo      =activo.subgrupo,
                        IdArticulo      =activo.articulo,
                        IdProveedor     =activo.proveedor,
                        EstadoProceso	=activo._EstadoProceso,
                        descripcion     =activo.descripcion,
                        valor_nomial    =Convert.ToDecimal(activo.valor_nominal),
                        valor_residual  =Convert.ToDecimal(activo.valor_residual),
                        valor_actualserie=Convert.ToDecimal ( activo.valor_actualserie),
                        IdCodigoBarra   = activo.codigo_barra,
                        fecha_Adquisicion=activo.Fecha_Adquisicion,
                        ano_vidaUtil    =activo.ano_vidautil,
                        IdEstado        =activo.estado,
                        fecha_registro  =activo.fecha_registro,
                    };

                    ent.AddToActivoFijo(act);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public Boolean modificar(clsActivoFijo activo)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    //Se hace un primary key codigo 
                    var x = (from q in ent.ActivoFijo where q.IdActivoFijo == activo.Codigo select q).First();
                    //First obtiene un registro que coincida con el codigo y luego mas a bajo
                    //modifico dicho registro y guardo eso lo modifica en la base 
                        x.IdActivoFijo  = activo.Codigo;
                        x.cantidad        =activo.Cantidad;
                        x.IdEmpresa       =activo.Empresa;
                        x.IdDepartamento  =activo.departamento;
                        x.IdResponsable   =activo.responsable;
                        x.IdUsuario       =activo.usuario;
                        x.IdArticuloBodega=activo.ArtBodega;
                        x.IdTipo          =activo.tipo;
                        x.IdGrupo         =activo.grupo;
                        x.IdSubgrupo      =activo.subgrupo;
                        x.IdArticulo      =activo.articulo;
                        x.IdProveedor     =activo.proveedor;
                        x.EstadoProceso = activo._EstadoProceso;
                        x.descripcion     =activo.descripcion;
                        x.valor_nomial    =Convert.ToDecimal(activo.valor_nominal);
                        x.valor_residual  =Convert.ToDecimal(activo.valor_residual);
                        x.valor_actualserie=Convert.ToDecimal ( activo.valor_actualserie);
                        x.IdCodigoBarra   = activo.codigo_barra;
                        x.fecha_Adquisicion=activo.Fecha_Adquisicion;
                        x.ano_vidaUtil    =activo.ano_vidautil;
                        x.IdEstado        =activo.estado;
                        x.fecha_registro = activo.fecha_registro;
                   
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }


        #region"Funiciones de Programa"

        #endregion

    }
}
