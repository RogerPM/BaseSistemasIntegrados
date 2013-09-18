using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.ActivoFijo;
using clases.Compras;
using clases.RecursosHumanos;
using clases.Inventario;
using datos.Inventario;
using datos.RecursosHumanos;
using datos.Compras;
using datos.Seguridad;

namespace datos.ActivoFijo
{
    public class clsClaseDatosActivoFijo
    {

        private clsActivoFijo clas = new clsActivoFijo();
        public clsActivoFijo auxi;
        public clsVehiculos vehiculo;
        public clsTerreno Terreno;
        public clsEdificio Edificio;
        public clsEquipoMaquinariaMebles EquipoMaqui;
        public clsEquipoMaquinariaMebles Muebles;
        public clsArticulo_SuministroOfic Articulo;

      

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
                            if (Descripcion == "Edificio")
                            {
                                return clas.aniosDepreciable_Edificios; 
                            }
                            else
                            {
                                return 0;
                            }                            
                        }
                    }
                } 
            }
        }

        public string VerificacionGrupo(string Descripcion)
        {
            if (Descripcion == "Vehiculos")
            {

                return "Vehiculos";
            }
            else
            {
                if (Descripcion == "MueblesyEnseres")
                {
                    return "Muebles y Enseres";
                }
                else
                {
                    if (Descripcion == "Equipos")
                    {
                        return "Equipos";
                    }
                    else
                    {
                        if (Descripcion == "Maquinarias")
                        {
                            return "Maquinarias";
                        }
                        else
                        {
                            if (Descripcion  == "InsumosdeOficina" | Descripcion =="Papeleria")
                            {
                                return "Articulos/Suministros de Oficinas";
                            }
                            else
                            {
                                if (Descripcion =="Terreno")
                                {
                                    return "Terrenos";
                                }
                                else
                                {
                                    if (Descripcion == "Edificio")
                                    {
                                        return "Edificios";
                                    }
                                    else
                                    {
                                        return "";
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void funcionLLamada(string Descripcion,clsActivoFijo activo,clsVehiculos vehiculo,int id,clsEquipoMaquinariaMebles EquipMaqui, clsEquipoMaquinariaMebles Muebles,clsEdificio Edificio, clsTerreno Terreno,clsArticulo_SuministroOfic Articulo )
        {
            bool auxi = true;
            if (Descripcion == "Vehiculos")
            {
                guardarVehiculos(vehiculo, id);
                //return "Vehiculos";
            }
            else
            {
                if (Descripcion == "MueblesyEnseres")
                {
                   guardarEquiposMaquinariasMuebles(Muebles,id);
                    //return "MueblesyEnseres";
                }
                else
                {
                    if (Descripcion == "Equipos")
                    {
                        guardarEquiposMaquinariasMuebles(EquipMaqui,id);
                        //return "Equipos";
                    }
                    else
                    {
                        if (Descripcion == "Maquinarias")                           
                        {
                            guardarEquiposMaquinariasMuebles(EquipMaqui, id);
                            //return "Maquinarias";
                        }
                        else
                        {
                            if (Descripcion == "Edificio")
                            {
                                guardarEdificios(Edificio,id);
                                //return "Edificio";
                            }
                            else
                            {
                                if (Descripcion == "Terreno")
                                {
                                    guardarTerreno(Terreno,id);
                                    //return "Terreno";
                                }
                                else
                                {
                                    if (Descripcion == "InsumosdeOficina" | Descripcion == "Papeleria")
                                    {
                                        guardarArticulos_Suministros(Articulo,id);
                                        //if (frm.cbxIdentDescripcion.Text == "Insumos de Oficina"){ return "InsumosdeOficina"; }else{
                                        //    if (frm.cbxIdentDescripcion.Text == "Papelería") { return "Papeleria"; }}


                                    }                                   
                                   
                                }
                            }
                        }
                    }
                }
            }
        }

        public clsActivoFijo TrasladoActivo(clsActivoFijo acti) {return acti;}

        public clsVehiculos TrasladoVehiculo(clsVehiculos veh){return veh;}



    #region"Funiciones de Programa"

        /*****Funciones que corresponderan a la calse de ActivoFijo*****/
                //metodo que retorna la descripcion de un motivo baja segun su id
        public string getDescripcionSegunIdMotivoBaja(int id)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    var x = (from a in ent.MotivoBaja where a.IdMotivoBaja == id select a).First();
                    return x.descripcion;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return null;
            }
        }

        public int getIdSegunDescripcionIdMotivo(string descrip)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    var x = (from a in ent.MotivoBaja where a.descripcion == descrip select a).First();
                    return x.IdMotivoBaja; //se lo puede cambiar y devolver el objeto x que en realidad es un objeto estado lleno con valores correcto segun la base
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encontro, Error: " + e);
                return 0;
            }
        }



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

        /*****Funciones que corresponderan a la calse de Inventario.Marca*****/

        public string getDescripcionSegunIdInventarioMarca(int id)
        {
            try
            {
                using (INVENTARIOEntities ent = new INVENTARIOEntities())
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

        public int getIdSegunDescripcionInventarioMarca(string descrip)
        {
            try
            {
                using (INVENTARIOEntities ent = new INVENTARIOEntities())
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

        /*****Funciones que corresponderan a la calse de Inventario.Modelo*****/

        public string getDescripcionSegunIdInventarioModelo(int id)
        {
            try
            {
                using (INVENTARIOEntities ent = new INVENTARIOEntities())
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

        public int getIdSegunDescripcionInventarioModelo(string descrip)
        {
            try
            {
                using (INVENTARIOEntities ent = new INVENTARIOEntities())
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


        /*****Funciones que corresponderan a la calse de Inventario.Color*****/

        public string getDescripcionSegunIdInventarioColor(int id)
        {
            try
            {
                using (INVENTARIOEntities ent = new INVENTARIOEntities())
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

        public int getIdSegunDescripcionInventarioColor(string descrip)
        {
            try
            {
                using (INVENTARIOEntities ent = new INVENTARIOEntities())
                {
                    var x = (from a in ent.Color  where a.Descripcion == descrip select a).First();
                    return x.IdColor; //se lo puede cambiar y devolver el objeto x que en realidad es un objeto estado lleno con valores correcto segun la base
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encontro, Error: " + e);
                return 0;
            }
        }

        /*****Funciones que corresponderan a la calse de Inventario.Material*****/

        public string getDescripcionSegunIdInventarioMaterial(int id)
        {
            try
            {
                using (INVENTARIOEntities ent = new INVENTARIOEntities())
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

        public int getIdSegunDescripcionInventarioMaterial(string descrip)
        {
            try
            {
                using (INVENTARIOEntities ent = new INVENTARIOEntities())
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

        /*****Funciones que corresponderan a la calse de Inventario.Chasis*****/
        public string getDescripcionSegunIdInventarioChasis(int id)
        {
            try
            {
                using (INVENTARIOEntities ent = new INVENTARIOEntities())
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

        public int getIdSegunDescripcionInventarioChasis(string descrip)
        {
            try
            {
                using (INVENTARIOEntities ent = new INVENTARIOEntities())
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

        /*****Funciones que corresponderan a la calse de Inventario.Motor*****/
        public string getDescripcionSegunIdInventarioMotor(int id)
        {
            try
            {
                using (INVENTARIOEntities ent = new INVENTARIOEntities())
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

        public int getIdSegunDescripcionInventarioMotor(string descrip)
        {
            try
            {
                using (INVENTARIOEntities ent = new INVENTARIOEntities())
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

        /*****Funciones que corresponderan a la calse de Compras.Proveedor*****/

        public string getDescripcionSegunIdComprasProveedor(int id)
        {
            try
            {
                CompraEntities ent = new CompraEntities();
                clsProveedor proveedor = new clsProveedor();
                var x = (from a in ent.Proveedor where a.IdProveedor == id select a).First();

                RecursosHumanosEntities aux = new RecursosHumanosEntities();
                var auxi = (from q in aux.Persona where q.IdPersona == x.IdPersona select q).First();

                return auxi.NombreRazonSocial;
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encontro, Error: " + e);
                return null;
            }
        }

        public int getIdSegunDescripcionComprasProveedor(string descripcion) 
        {
            try
            {

                RecursosHumanosEntities aux = new RecursosHumanosEntities();
                var auxi = (from q in aux.Persona where q.NombreRazonSocial == descripcion select q).First();
                CompraEntities ent = new CompraEntities();
                clsProveedor proveedor = new clsProveedor();
                var x = (from a in ent.Proveedor where a.IdPersona == auxi.IdPersona select a).First();

                return x.IdProveedor;
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encontro, Error: " + e);
                return 0;
            }
        }


    #endregion 

        /*******************************************ActivoFIjo******************************************************/

        #region"Funiciones Basicas"

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
                    clas.departamento = Convert.ToInt32(item.IdDepartamento);
                    clas.responsable = Convert.ToInt32(item.IdResponsable);
                    clas.ArtBodega = Convert.ToInt32(item.IdArticuloBodega);
                    clas.usuario = Convert.ToInt32(item.IdUsuario);
                    clas.tipo = Convert.ToInt32(item.IdTipo);
                    clas.grupo = Convert.ToInt32(item.IdGrupo);
                    clas.subgrupo = Convert.ToInt32(item.IdSubgrupo);
                    clas.articulo = Convert.ToInt32(item.IdArticulo);
                    clas.proveedor = Convert.ToInt32(item.IdProveedor);
                    clas._EstadoProceso = Convert.ToString(item.EstadoProceso);
                    clas.descripcion = item.descripcion;
                    clas.ValorAdquisicion = Convert.ToDouble(item.ValorAdquisicion);
                    clas.valor_nominal = Convert.ToDouble(item.valor_nomial);
                    clas.valor_residual = Convert.ToDouble(item.valor_residual);
                    clas.valor_actualserie = Convert.ToDouble(item.valor_actualserie);
                    clas.codigo_barra = Convert.ToInt32(item.IdCodigoBarra);
                    clas.Fecha_Adquisicion = Convert.ToDateTime(item.fecha_Adquisicion);
                    clas.ano_vidautil = Convert.ToInt32(item.ano_vidaUtil);
                    clas.estado = Convert.ToInt32(item.IdEstado);
                    clas.fecha_registro = Convert.ToDateTime(item.fecha_registro);
                    

                    lista.Add(clas);
                }
                return lista;
            }
            catch (Exception)
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
                    var x = (from q in ent.ActivoFijo where q.IdActivoFijo == activo.Codigo select q).First();
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

        public Boolean guardar(clsActivoFijo activo, clsVehiculos clsVehic,clsEdificio clsEdi,clsTerreno clsTerreno,clsEquipoMaquinariaMebles clsMaquiEqui,clsArticulo_SuministroOfic clasArti,clsEquipoMaquinariaMebles clsMuebles)
        {
            int bandera = 0;
            //auxi = TrasladoActivo;
            try
            {
                int id = getSiguiente();
                activo.Codigo = id;
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {                   

                    ActivoFijo act = new ActivoFijo()
                    {
                        IdActivoFijo = activo.Codigo,
                        cantidad = activo.Cantidad,
                        IdEmpresa = activo.Empresa,
                        //IdDepartamento = activo.departamento,
                        //IdResponsable = activo.responsable,
                        IdUsuario = activo.usuario,
                        //IdArticuloBodega = activo.ArtBodega,
                        IdTipo = activo.tipo,
                        IdGrupo = activo.grupo,
                        IdSubgrupo = activo.subgrupo,
                        //IdArticulo = activo.articulo,
                        IdProveedor = activo.proveedor,
                        EstadoProceso = activo._EstadoProceso,
                        descripcion = activo.descripcion,
                        ValorAdquisicion = Convert.ToDecimal(activo.ValorAdquisicion),
                        valor_nomial = Convert.ToDecimal(activo.valor_nominal),
                        valor_residual = Convert.ToDecimal(activo.valor_residual),
                        valor_actualserie = Convert.ToDecimal(activo.valor_actualserie),
                       // IdCodigoBarra = activo.codigo_barra,
                        fecha_Adquisicion = activo.Fecha_Adquisicion,
                        ano_vidaUtil = activo.ano_vidautil,
                        IdEstado = activo.estado,
                        fecha_registro = activo.fecha_registro,
                    };
                    bandera = activo.Codigo;

                    ent.AddToActivoFijo(act);
                    ent.SaveChanges();

                    funcionLLamada(getDescripcionSegunIdInventarioGrupo(activo.grupo), activo, clsVehic, bandera,clsMaquiEqui, clsMuebles,clsEdi, clsTerreno,clasArti);
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
                    x.IdActivoFijo = activo.Codigo;
                    x.cantidad = activo.Cantidad;
                    x.IdEmpresa = activo.Empresa;
                    x.IdDepartamento = activo.departamento;
                    x.IdResponsable = activo.responsable;
                    x.IdUsuario = activo.usuario;
                    x.IdArticuloBodega = activo.ArtBodega;
                    x.IdTipo = activo.tipo;
                    x.IdGrupo = activo.grupo;
                    x.IdSubgrupo = activo.subgrupo;
                    x.IdArticulo = activo.articulo;
                    x.IdProveedor = activo.proveedor;
                    x.EstadoProceso = activo._EstadoProceso;
                    x.descripcion = activo.descripcion;
                    x.ValorAdquisicion = Convert.ToDecimal(activo.ValorAdquisicion);
                    x.valor_nomial = Convert.ToDecimal(activo.valor_nominal);
                    x.valor_residual = Convert.ToDecimal(activo.valor_residual);
                    x.valor_actualserie = Convert.ToDecimal(activo.valor_actualserie);
                    x.IdCodigoBarra = activo.codigo_barra;
                    x.fecha_Adquisicion = activo.Fecha_Adquisicion;
                    x.ano_vidaUtil = activo.ano_vidautil;
                    x.IdEstado = activo.estado;
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

        public Boolean ModificarValorActual(clsActivoFijo activo)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    //Se hace un primary key codigo 
                    var x = (from q in ent.ActivoFijo where q.IdActivoFijo == activo.Codigo select q).First();
                    //First obtiene un registro que coincida con el codigo y luego mas a bajo
                    //modifico dicho registro y guardo eso lo modifica en la base 
                    x.IdActivoFijo = activo.Codigo;                  
                    x.valor_actualserie = Convert.ToDecimal(activo.valor_actualserie);                    

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


        /*******************************************Terrenos******************************************************/

        #region"Funiciones de Basicas de Terreno"

        public Boolean guardarTerreno(clsTerreno Terreno, int id)
        {
            try
            {
                Terreno.idCodActivoFijo = clas.Codigo ;//Se copiara el mismo codigo del AxtivoFijo para ingresar el terreno
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    Terreno Terren = new Terreno()
                    {
                        IdActivoFijo = Terreno.idCodActivoFijo,
                        direccion = Terreno.direccion,
                        observacion= Terreno.observacion,
                        codigoCatatral = Terreno.CodigoCatrastal,
                        DimensionAncho =Convert.ToDecimal( Terreno.dimenAncho),
                        DimensionLargo =Convert.ToDecimal( Terreno.dimenLargo),
                        FechaLegalizacion =Convert.ToDateTime ( Terreno .fechaLegalizacion),
                    };

                    ent.AddToTerreno(Terren);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public clsTerreno consultaTerreno(int id)
         {
             try
             {
                 
                 ActivoFijoEntities ent = new ActivoFijoEntities();
                 var q = (from w in ent.Terreno where w.IdActivoFijo == id select w).First();

                     clsTerreno Terren = new clsTerreno();
                     Terren.idCodActivoFijo = Convert.ToInt32(q.IdActivoFijo);
                     Terren.direccion=Convert.ToString( q.direccion);
                     Terren.observacion =Convert.ToString (q.observacion);
                     Terren.CodigoCatrastal =Convert.ToString(q.codigoCatatral);
                     Terren.dimenAncho=Convert.ToDouble(q.DimensionAncho);
                     Terren.dimenLargo=Convert.ToDouble(q.DimensionLargo );
                     Terren.fechaLegalizacion = Convert.ToDateTime(q.FechaLegalizacion);

                 return Terren;
             }
             catch (Exception)
             {
                 return null;
             }

         }

        public Boolean modificarTerreno(clsTerreno Terreno)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    //Se hace un primary key codigo 
                    var x = (from q in ent.Terreno where q.IdActivoFijo == clas.Codigo select q).First();
                    //First obtiene un registro que coincida con el codigo y luego mas a bajo
                    //modifico dicho registro y guardo eso lo modifica en la base 
                        x.IdActivoFijo = clas.Codigo;
                        x.direccion = Terreno.direccion;
                        x.observacion= Terreno.observacion;
                        x.codigoCatatral = Terreno.CodigoCatrastal;
                        x.DimensionAncho =Convert.ToDecimal( Terreno.dimenAncho);
                        x.DimensionLargo =Convert.ToDecimal( Terreno.dimenLargo);
                        x.FechaLegalizacion = Convert.ToDateTime(Terreno.fechaLegalizacion);

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

        /*******************************************Edificios******************************************************/

        #region"Funiciones de Basicas de Edificios"

        public Boolean guardarEdificios(clsEdificio Edificios, int id)
        {
            try
            {
                Edificios.idCodActivoFijo = id;//Se copiara el mismo codigo del AxtivoFijo para ingresar el Edificios
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    Edifico Edifi = new Edifico()
                    {
                        IdActivoFijo = Edificios.idCodActivoFijo,
                        FechaConstruccion = Edificios.fechaConstruccion,
                        CodigoCatastral = Edificios.codCatrastal,
                        NumeroPisos = Edificios.NumPisos,
                        AniosDepreciados = Edificios.AniosDepreciados,
                        Ubicacion = Edificios.ubicacion,
                        DimensionAncho = Convert.ToDecimal(Edificios.DimenAncho),
                        DimensionLargo = Convert.ToDecimal(Edificios.DimenLargo),
                        observacion = Edificios.observacion,
                    };

                    ent.AddToEdifico(Edifi);
                    ent.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public clsEdificio consultaEdificios(int id)
         {
             try
             {
                
                 ActivoFijoEntities ent = new ActivoFijoEntities();
                 var q = (from w in ent.Edifico where w.IdActivoFijo==id  select w).First();

                 
                     clsEdificio Edificios = new clsEdificio();
                        Edificios.idCodActivoFijo =Convert.ToInt32( q.IdActivoFijo);
                        Edificios.fechaConstruccion = Convert.ToDateTime( q.FechaConstruccion );
                        Edificios.codCatrastal = Convert.ToString( q.CodigoCatastral );
                        Edificios.NumPisos =Convert.ToInt32( q.NumeroPisos );
                        Edificios.AniosDepreciados =Convert .ToInt32 ( q.AniosDepreciados );
                        Edificios.ubicacion =Convert.ToString ( q.Ubicacion );
                        Edificios.DimenAncho = Convert.ToDouble(q.DimensionAncho);
                        Edificios.DimenLargo = Convert.ToDouble(q.DimensionLargo );
                        Edificios.observacion = Convert.ToString ( q.observacion);

                 return Edificios;
             }
             catch (Exception)
             {
                 return null;
             }

         }

        public Boolean modificarEdificios(clsEdificio Edificios)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    //Se hace un primary key codigo 
                    var x = (from q in ent.Edifico where q.IdActivoFijo == clas.Codigo select q).First();
                    //First obtiene un registro que coincida con el codigo y luego mas a bajo
                    //modifico dicho registro y guardo eso lo modifica en la base 
                        x.IdActivoFijo = clas.Codigo;
                        x.FechaConstruccion = Edificios.fechaConstruccion;
                        x.CodigoCatastral = Edificios.codCatrastal;
                        x.NumeroPisos = Edificios.NumPisos;
                        x.AniosDepreciados = Edificios.AniosDepreciados;
                        x.Ubicacion = Edificios.ubicacion;
                        x.DimensionAncho = Convert.ToDecimal(Edificios.DimenAncho);
                        x.DimensionLargo = Convert.ToDecimal(Edificios.DimenLargo);
                        x.observacion = Edificios.observacion;

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

        /*******************************************EquiposMaquinariasMuebles******************************************************/

        #region"Funiciones de Basicas de EquiposMaquinariasMuebles"
      
        public Boolean guardarEquiposMaquinariasMuebles(clsEquipoMaquinariaMebles EquipMaqMub, int id)
        {
            try
            {
                EquipMaqMub.idCodActivoFijo = id;//Se copiara el mismo codigo del AxtivoFijo para ingresar el EquipMaqMub
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    EquipoMaquinariaMuebles EquipoMaquiMueb = new EquipoMaquinariaMuebles()
                    {


                        IdActivoFijo = EquipMaqMub.idCodActivoFijo,
                        IdMarca = EquipMaqMub.idMarca,
                        IdModelo = EquipMaqMub.idModelo,
                        IdColor = EquipMaqMub.idColor,
                        Carga = Convert .ToDecimal(EquipMaqMub.carga), 
                        AniosDepreciados = EquipMaqMub.AniosDepreciados,
                        DimensionAlto = Convert.ToDecimal(EquipMaqMub.DimenAlto),
                        DimensionAncho = Convert.ToDecimal(EquipMaqMub.DimenAncho),
                        DimensionLargo = Convert.ToDecimal(EquipMaqMub.DimenLargo),
                        observacion = EquipMaqMub.observacion,
                    };

                    ent.AddToEquipoMaquinariaMuebles(EquipoMaquiMueb);
                    ent.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public clsEquipoMaquinariaMebles consultaEquiposMaquinariasMuebles(int id)
        {
            try
            {                
                ActivoFijoEntities ent = new ActivoFijoEntities();
                var q =(from w in ent.EquipoMaquinariaMuebles where w.IdActivoFijo==id  select w).First();

                    clsEquipoMaquinariaMebles EquipMaqMub = new clsEquipoMaquinariaMebles();
                    EquipMaqMub.idCodActivoFijo = Convert.ToInt32(q.IdActivoFijo);
                    EquipMaqMub.idMarca = Convert.ToInt32 (q.IdMarca);
                    EquipMaqMub.idModelo = Convert.ToInt32(q.IdModelo);
                    EquipMaqMub.idColor = Convert.ToInt32(q.IdColor);
                    EquipMaqMub.carga = Convert.ToDouble(q.Carga);
                    EquipMaqMub.AniosDepreciados = Convert.ToInt32(q.AniosDepreciados);
                    EquipMaqMub.DimenAlto = Convert.ToDouble(q.DimensionAlto);
                    EquipMaqMub.DimenAncho = Convert.ToDouble(q.DimensionAncho);
                    EquipMaqMub.DimenLargo = Convert.ToDouble(q.DimensionLargo);
                    EquipMaqMub.observacion = Convert.ToString(q.observacion);

                return EquipMaqMub;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public Boolean modificarEquiposMaquinariasMuebles(clsEquipoMaquinariaMebles EquipMaqMub)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    //Se hace un primary key codigo 
                    var x = (from q in ent.EquipoMaquinariaMuebles where q.IdActivoFijo == clas.Codigo select q).First();
                    //First obtiene un registro que coincida con el codigo y luego mas a bajo
                    //modifico dicho registro y guardo eso lo modifica en la base 
                        x.IdActivoFijo = clas.Codigo;
                        x.IdMarca = EquipMaqMub.idMarca;
                        x.IdModelo = EquipMaqMub.idModelo;
                        x.IdColor = EquipMaqMub.idColor;
                        x.Carga = Convert.ToDecimal(EquipMaqMub.carga);
                        x.AniosDepreciados = EquipMaqMub.AniosDepreciados;
                        x.DimensionAlto = Convert.ToDecimal(EquipMaqMub.DimenAlto);
                        x.DimensionAncho = Convert.ToDecimal(EquipMaqMub.DimenAncho);
                        x.DimensionLargo = Convert.ToDecimal(EquipMaqMub.DimenLargo);
                        x.observacion = EquipMaqMub.observacion;

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


        /*******************************************Articulos_Suministros******************************************************/

        #region"Funiciones de Basicas de Articulos_Suministros"
        public Boolean guardarArticulos_Suministros(clsArticulo_SuministroOfic ArticSumi, int id)
        {
            try
            {
                ArticSumi.idCodActivoFijo = id;//Se copiara el mismo codigo del AxtivoFijo para ingresar el Articulos_Suministros
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    Articulos_SuministrosOficina ArticuloSuministros = new Articulos_SuministrosOficina()
                    {
                        IdActivoFijo = ArticSumi.idCodActivoFijo,
                        IdMarca = ArticSumi.idMarca,
                        IdModelo = ArticSumi.idModelo,
                        IdColor = ArticSumi.idColor,
                        IdMaterial = ArticSumi.idMaterial,
                        observacion = ArticSumi.Observacion,
                    };

                    ent.AddToArticulos_SuministrosOficina(ArticuloSuministros);
                    ent.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public clsArticulo_SuministroOfic consultaArticulos_Suministros(int id)
        {
            try
            {
                
                ActivoFijoEntities ent = new ActivoFijoEntities();
                var q =( from w in ent.Articulos_SuministrosOficina where w.IdActivoFijo==id  select w).First();
		 
                    clsArticulo_SuministroOfic ArticulosSuministros = new clsArticulo_SuministroOfic();
                    ArticulosSuministros.idCodActivoFijo = Convert.ToInt32(q.IdActivoFijo);
                    ArticulosSuministros.idMarca = Convert.ToInt32(q.IdMarca);
                    ArticulosSuministros.idModelo = Convert.ToInt32(q.IdModelo);
                    ArticulosSuministros.idColor = Convert.ToInt32(q.IdColor);
                    ArticulosSuministros.idMaterial = Convert.ToInt32(q.IdMaterial);
                    ArticulosSuministros.Observacion = Convert.ToString(q.observacion);
                    

                    return ArticulosSuministros;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public Boolean modificarEquiposMaquinariasMuebles(clsArticulo_SuministroOfic ArticSumi)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    //Se hace un primary key codigo 
                    var x = (from q in ent.Articulos_SuministrosOficina where q.IdActivoFijo == clas.Codigo select q).First();
                    //First obtiene un registro que coincida con el codigo y luego mas a bajo
                    //modifico dicho registro y guardo eso lo modifica en la base 
                    x.IdActivoFijo = clas.Codigo;
                    x.IdMarca = ArticSumi.idMarca;
                    x.IdModelo = ArticSumi.idModelo;
                    x.IdColor = ArticSumi.idColor;
                    x.IdMaterial = ArticSumi.idMaterial;
                    x.observacion = ArticSumi.Observacion;

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

        /*******************************************Vehiculos******************************************************/


        #region"Funiciones de Basicas de Vehiculos"
        public Boolean guardarVehiculos(clsVehiculos Vehicu,int id)
        {
            try
            {
                Vehicu.idCodActivoFijo = id;//Se copiara el mismo codigo del AxtivoFijo para ingresar el Articulos_Suministros
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    Vehiculo Vehiculo = new Vehiculo()
                    {
                        IdActivoFijo = Vehicu.idCodActivoFijo,
                        IdMarca = Vehicu.idMarca,
                        IdModelo = Vehicu.idModelo,
                        IdColor = Vehicu.idColor,
                        IdMotor =Vehicu.idMotor,
                        serie = Vehicu.serie,
                        IdChasis = Vehicu.idChasis,
                        placa=Vehicu.placa,
                        numeropuerta = Vehicu.NumPuertas,
                        AniosDepreciados = Vehicu.AniosDepreciados,
                        descripcion = Vehicu.Descripcion,
                        IdMaterial = Vehicu.idMaterial,
                        matricula = Vehicu.Matricula ,
                        transmision = Vehicu .Transmision,
                        carga = Convert.ToDecimal ( Vehicu.carga ),
                        capacidad =Convert.ToDecimal ( Vehicu.capacidad),
                        kilometraje  = Convert.ToDecimal (Vehicu.kilometraje),
                        fechaCreacion = Convert.ToDateTime (Vehicu.FechaCracion),
                    };

                    ent.AddToVehiculo (Vehiculo);
                    ent.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public clsVehiculos  consultaVehiculos(int id)
        {
            try
            {
               
                ActivoFijoEntities ent = new ActivoFijoEntities();
                var q = (from w in ent.Vehiculo where w.IdActivoFijo==id  select w).First();

                
                    clsVehiculos Vehicu = new clsVehiculos();
                    Vehicu.idCodActivoFijo = Convert.ToInt32(q.IdActivoFijo);
                    Vehicu.idMarca = Convert.ToInt32(q.IdMarca);
                    Vehicu.idModelo = Convert.ToInt32(q.IdModelo);
                    Vehicu.idColor = Convert.ToInt32(q.IdColor);
                    Vehicu.idMaterial = Convert.ToInt32(q.IdMaterial);
                    Vehicu.idMotor = Convert.ToInt32(q.IdMotor);
                    Vehicu.serie = q.serie;
                    Vehicu.Matricula = Convert.ToString(q.matricula);
                    Vehicu.placa = Convert.ToString(q.placa);   
                    Vehicu.idChasis = Convert.ToInt32 ( q.IdChasis);
                    Vehicu .NumPuertas = Convert.ToInt32 ( q.numeropuerta);
                    Vehicu.AniosDepreciados = Convert.ToInt32 (q.AniosDepreciados);
                    Vehicu.Descripcion = q.descripcion;
                    Vehicu .Transmision = q.transmision;
                    Vehicu.carga = Convert.ToDouble(q.carga);
                    Vehicu.capacidad =Convert.ToDouble( q.capacidad);
                    Vehicu.kilometraje = Convert.ToDouble (q.kilometraje);
                    Vehicu.FechaCracion = Convert.ToDateTime(q.fechaCreacion);
                 

                return Vehicu;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public Boolean modificarVehiculos(clsVehiculos Vehicu)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    //Se hace un primary key codigo 
                    var x = (from q in ent.Vehiculo where q.IdActivoFijo == clas.Codigo select q).First();
                    //First obtiene un registro que coincida con el codigo y luego mas a bajo
                    //modifico dicho registro y guardo eso lo modifica en la base 
                        x.IdActivoFijo = clas.Codigo;
                        x.IdMarca = Vehicu.idMarca;
                        x.IdModelo = Vehicu.idModelo;
                        x.IdColor = Vehicu.idColor;
                        x.IdMaterial = Vehicu.idMaterial;
                        x.serie =Vehicu.serie;
                        x.IdChasis = Vehicu.idChasis;
                        x.numeropuerta = Vehicu .NumPuertas;
                        x.AniosDepreciados = Vehicu.AniosDepreciados;
                        x.descripcion = Vehicu.Descripcion;
                        x.transmision = Vehicu .Transmision;
                        x.carga = Convert.ToDecimal ( Vehicu.carga );
                        x.capacidad =Convert.ToDecimal ( Vehicu.capacidad);
                        x.kilometraje  = Convert.ToDecimal (Vehicu.kilometraje);
                        x.fechaCreacion = Convert.ToDateTime(Vehicu.FechaCracion);

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
