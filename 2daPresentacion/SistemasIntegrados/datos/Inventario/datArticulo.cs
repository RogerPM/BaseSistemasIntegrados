using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Inventario;
using System.Data;

namespace datos.Inventario
{
    public class datArticulo
    {
        
        public List<clsArticulo> consultaArt()
        {
            
            try
            {
                List<clsArticulo> listado = new List<clsArticulo>();
                INVENTARIOEntities art = new INVENTARIOEntities();
                var con = from w in art.Articulo select w;
                foreach (var item in con)
                {
                    clsArticulo clsArt = new clsArticulo();

                    clsArt.IdArt = Convert.ToInt32(item.IdArticulo);
                    clsArt.DescArt = item.Descripcion;
                    clsArt.FProduccion = Convert.ToDateTime(item.FechaProduccion);
                    clsArt.CantMinima = Convert.ToInt32(item.CantidadMinima);
                    clsArt.CantMaxima = Convert.ToInt32(item.CantidadMaxima);
                    clsArt.CantActual = Convert.ToInt32(item.CantidadActual);
                    clsArt.UMed = Convert.ToInt32(item.IdUnidadMedida);
                    clsArt.FCaducidad = Convert.ToDateTime(item.FechaCaducidad);
                    clsArt.TipoArt = Convert.ToInt32(item.IdTipoArticulo);
                    clsArt.GrupoArt = Convert.ToInt32(item.IdGrupo);
                    clsArt.TipoChasis = Convert.ToInt32(item.IdChasis);
                    clsArt.SChasis = item.SerieChasis;
                    clsArt.TipoMotor = Convert.ToInt32(item.IdTipoMotor);
                    clsArt.SMotor = item.SerieMotor;
                    clsArt.NPlaca = Convert.ToString(item.NroPlaca);
                    clsArt.TipoComb = Convert.ToInt32(item.IdTipoCombustible);
                    clsArt.ColorArt = Convert.ToInt32(item.IdColor);
                    clsArt.MarcaArt = Convert.ToInt32(item.IdMarca);
                    clsArt.ModeloArt = Convert.ToInt32(item.Modelo);
                    clsArt.TipoMat = Convert.ToInt32(item.TipoMaterial);
                    clsArt.ObservArt = item.Observacion;
                    clsArt.EstArt = Convert.ToInt32(item.IdEstado);

                    listado.Add(clsArt);
                }
                return listado;
            }
            catch (Exception)
            {
                //Console.WriteLine("ERROR " + e);
                return null;
            }
        }

        public List<clsTipoArticulo> consultaTipoArticulo()
        {
            try
            {
                List<clsTipoArticulo> listcta = new List<clsTipoArticulo>();
                INVENTARIOEntities ta = new INVENTARIOEntities();
                var con = from w in ta.TipoArticulo select w;
                foreach (var item in con)
                {
                    clsTipoArticulo clsTA = new clsTipoArticulo();
                    clsTA.empresa = Convert.ToInt32(item.IdEmpresa);
                    clsTA.codigo = Convert.ToInt32(item.IdTipoArticulo);
                    clsTA.descripcion = item.Descripcion;
                    clsTA.estado = Convert.ToString(item.IdEstado);
                    listcta.Add(clsTA);
                }
                return listcta;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR " + e);
                return null;
            }
        }

        public List<clsGrupo> consultaGrupoArticulo()
        {
            try
            {
                List<clsGrupo> listaGrupo = new List<clsGrupo>();
                INVENTARIOEntities ta = new INVENTARIOEntities();
                var con = from w in ta.Grupo select w;
                foreach (var item in con)
                {
                    clsGrupo clsGrupArt = new clsGrupo();
                    clsGrupArt.codigo = item.IdGrupo;
                    clsGrupArt.empresa = Convert.ToInt32(item.IdEmpresa);
                    clsGrupArt.descripcion = item.Descripcion;
                    clsGrupArt.tipoarticulo = Convert.ToString(item.IdTipoArticulo);
                    clsGrupArt.estado = Convert.ToString(item.IdEstado);
                    listaGrupo.Add(clsGrupArt);

                }
                return listaGrupo;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR " + e);
                return null;
            }
        }

        public List<clsMarca> consultaMarca()
        {
            try
            {
                List<clsMarca> listaMarca = new List<clsMarca>();
                INVENTARIOEntities ta = new INVENTARIOEntities();
                var con = from w in ta.Marca select w;
                foreach (var item in con)
                {
                    clsMarca clsMarcArt = new clsMarca();
                    clsMarcArt.empresa = Convert.ToInt32(item.IdEmpresa);
                    clsMarcArt.codigo = item.IdMarca;
                    clsMarcArt.descripcion = item.Descripcion;
                    clsMarcArt.estado = Convert.ToString(item.IdEstado);
                    listaMarca.Add(clsMarcArt);
                }
                return listaMarca;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR " + e);
                return null;
            }
        }

        public List<clsModelo> consultaModelo()
        {
            try
            {
                List<clsModelo> listaModelo = new List<clsModelo>();
                INVENTARIOEntities ta = new INVENTARIOEntities();
                var con = from w in ta.Modelo select w;
                foreach (var item in con)
                {
                    clsModelo clsModeloArt = new clsModelo();
                    clsModeloArt.empresa = Convert.ToInt32(item.IdEmpresa);
                    clsModeloArt.codigo = item.IdModelo;
                    clsModeloArt.descripcion = item.Descripcion;
                    clsModeloArt.marca = Convert.ToString(item.IdMarca);
                    clsModeloArt.estado = Convert.ToString(item.IdEstado);
                    listaModelo.Add(clsModeloArt);
                }
                return listaModelo;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR " + e);
                return null;
            }
        }

        public List<clsColor> consultaColor()
        {
            try
            {
                List<clsColor> listaColor = new List<clsColor>();
                INVENTARIOEntities ta = new INVENTARIOEntities();
                var con = from w in ta.Color select w;
                foreach (var item in con)
                {
                    clsColor clsColorArt = new clsColor();
                    clsColorArt.empresa = Convert.ToInt32(item.IdEmpresa);
                    clsColorArt.codigo = item.IdColor;
                    clsColorArt.descripcion = item.Descripcion;
                    clsColorArt.estado = Convert.ToString(item.IdEstado);
                    listaColor.Add(clsColorArt);
                }
                return listaColor;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR " + e);
                return null;
            }
        }

        public List<clsTipoMotor> consultaTipoMotor()
        {
            try
            {
                List<clsTipoMotor> listaTMotor = new List<clsTipoMotor>();
                INVENTARIOEntities ta = new INVENTARIOEntities();
                var con = from w in ta.TipoMotor select w;
                foreach (var item in con)
                {
                    clsTipoMotor clsTMotor = new clsTipoMotor();
                    clsTMotor.empresa = Convert.ToInt32(item.IdEmpresa);
                    clsTMotor.codigo = item.IdTipoMotor;
                    clsTMotor.descripcion = item.Descripcion;
                    clsTMotor.estado = Convert.ToString(item.IdEstado);
                    listaTMotor.Add(clsTMotor);
                }
                return listaTMotor;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR " + e);
                return null;
            }
        }

        public List<clsTipoCombustible> consultaTipoCombustible()
        {
            try
            {
                List<clsTipoCombustible> listaTipoComb = new List<clsTipoCombustible>();
                INVENTARIOEntities ta = new INVENTARIOEntities();
                var con = from w in ta.TipoCombustible select w;
                foreach (var item in con)
                {
                    clsTipoCombustible clsTipoComb = new clsTipoCombustible();
                    clsTipoComb.empresa = Convert.ToInt32(item.IdEmpresa);
                    clsTipoComb.codigo = item.IdTipoCombustible;
                    clsTipoComb.descripcion = item.Descripcion;
                    clsTipoComb.estado = Convert.ToString(item.IdEstado);
                    listaTipoComb.Add(clsTipoComb);
                }
                return listaTipoComb;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR " + e);
                return null;
            }
        }

        public List<clsTipoChasis> consultaTipoChasis()
        {
            try
            {
                List<clsTipoChasis> listaChasis = new List<clsTipoChasis>();
                INVENTARIOEntities ta = new INVENTARIOEntities();
                var con = from w in ta.Chasis select w;
                foreach (var item in con)
                {
                    clsTipoChasis clsTipoCh = new clsTipoChasis();
                    clsTipoCh.empresa = Convert.ToInt32(item.IdEmpresa);
                    clsTipoCh.codigo = item.IdChasis;
                    clsTipoCh.descripcion = item.Descripcion;
                    clsTipoCh.estado = Convert.ToString(item.IdEstado);
                    listaChasis.Add(clsTipoCh);
                }
                return listaChasis;
            }
            catch
            {
                return null;
            }
        }

        public List<clsUnidadMedida> consultaUMedida()
        {
            try
            {
                List<clsUnidadMedida> listaUMedida = new List<clsUnidadMedida>();
                INVENTARIOEntities ta = new INVENTARIOEntities();
                var con = from w in ta.UnidadMedida select w;
                foreach (var item in con)
                {
                    clsUnidadMedida clsUmedida = new clsUnidadMedida();
                    clsUmedida.empresa = Convert.ToInt32(item.IdEmpresa);
                    clsUmedida.codigo = item.IdUnidadMedida;
                    clsUmedida.descripcion = item.Descripcion;
                    clsUmedida.estado = Convert.ToString(item.IdEstado);
                    listaUMedida.Add(clsUmedida);
                }
                return listaUMedida;
            }
            catch
            {
                return null;
            }
        }

        public List<clsTipoMaterial> consultaTipoMaterial()
        {
            try
            {
                List<clsTipoMaterial> listaTMaterial = new List<clsTipoMaterial>();
                INVENTARIOEntities ta = new INVENTARIOEntities();
                var con = from w in ta.TipoMaterial select w;
                foreach (var item in con)
                {
                    clsTipoMaterial clsTMaterial = new clsTipoMaterial();
                    clsTMaterial.empresa = Convert.ToInt32(item.IdEmpresa);
                    clsTMaterial.codigo = item.IdTipoMaterial;
                    clsTMaterial.descripcion = item.Descripcion;
                    clsTMaterial.estado = Convert.ToString(item.IdEstado);
                    listaTMaterial.Add(clsTMaterial);
                }
                return listaTMaterial;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR " + e);
                return null;
            }
        }


        public Boolean GuardarArt(clsArticulo artic, ref string msg)
        {
            try
            {
                using (INVENTARIOEntities b_art = new INVENTARIOEntities())
                {
                    Articulo art = new Articulo();
                    
                        art.IdEmpresa = artic.EmpresaArt;
                        art.IdArticulo = artic.IdArt;
                        art.Descripcion = artic.DescArt;
                        art.FechaProduccion = artic.FProduccion;
                        art.CantidadMinima = artic.CantMinima;
                        art.CantidadMaxima = artic.CantMaxima;
                        art.CantidadActual = artic.CantActual;
                        if (artic.UMed == 0)
                            art.IdUnidadMedida = null;
                        else
                            art.IdUnidadMedida =  artic.UMed;
                        art.FechaCaducidad = artic.FCaducidad;
                        art.IdTipoArticulo = artic.TipoArt;
                        art.IdGrupo = artic.GrupoArt;
                    if(artic.TipoChasis !=0)
                        art.IdChasis = artic.TipoChasis;
                        art.SerieChasis = artic.SChasis;
                        if (artic.TipoMotor != 0)
                        art.IdTipoMotor = artic.TipoMotor;
                        art.SerieMotor = artic.SMotor;
                        art.NroPlaca = artic.NPlaca;
                    if (artic.TipoComb != 0)
                        art.IdTipoCombustible = artic.TipoComb;
                    if (artic.ColorArt != 0)
                        art.IdColor = artic.ColorArt;
                    if (artic.MarcaArt != 0)
                        art.IdMarca = artic.MarcaArt;
                    if (artic.ModeloArt != 0)
                        art.IdModelo = artic.ModeloArt;
                    if(artic.TipoMat!=0)
                        art.IdTipoMaterial = artic.TipoMat;
                        art.Observacion = artic.ObservArt;
                    if(artic.EstArt !=0)
                        art.IdEstado = artic.EstArt;
                    b_art.AddToArticulo(art);
                    b_art.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                msg = "ERROR : " + e.InnerException + e.Message;
                return false;
            }
        }
        public Boolean ModificarArt(clsArticulo artic)
        {
            try
            {
                using (INVENTARIOEntities ta = new INVENTARIOEntities())
                {
                    EntityKey ekey = new EntityKey("INVENTARIOEntities.Articulo", "IdArticulo", artic.IdArt);
                    object OBJ = null;
                    if (ta.TryGetObjectByKey(ekey, out OBJ))
                    {
                        Articulo c = (Articulo)OBJ;
                        //var c = (from q in ta.Articulo where q.IdArticulo == artic.IdArt select q).First();
                        c.IdEmpresa = artic.EmpresaArt;
                        c.Descripcion = artic.DescArt;
                        c.FechaProduccion = artic.FProduccion;
                        c.CantidadMinima = artic.CantMinima;
                        c.CantidadMaxima = artic.CantMaxima;
                        c.CantidadActual = artic.CantActual;
                        c.IdUnidadMedida = artic.UMed;
                        c.FechaCaducidad = artic.FCaducidad;
                        c.IdTipoArticulo = artic.TipoArt;
                        c.IdGrupo = artic.GrupoArt;
                        c.IdChasis = artic.TipoChasis;
                        c.SerieChasis = artic.SChasis;
                        c.IdTipoMotor = artic.TipoMotor;
                        c.SerieMotor = artic.SMotor;
                        c.NroPlaca = artic.NPlaca;
                        c.IdTipoCombustible = artic.TipoComb;
                        c.IdColor = artic.ColorArt;
                        c.IdMarca = artic.MarcaArt;
                        c.IdModelo = artic.ModeloArt;
                        c.IdTipoMaterial = artic.TipoMat;
                        c.Observacion = artic.ObservArt;
                        c.IdEstado = artic.EstArt;

                    }

                    ta.SaveChanges(System.Data.Objects.SaveOptions.DetectChangesBeforeSave);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void EliminarArt(clsArticulo artic)
        {
            using (INVENTARIOEntities ar = new INVENTARIOEntities())
            {
                var a = (from q in ar.Articulo where q.IdArticulo == artic.IdArt select q).First();
                ar.DeleteObject(a);
                ar.SaveChanges();
            }
        }

        public int getIdSiguiente()
        {
            try
            {
                INVENTARIOEntities ent = new INVENTARIOEntities();
                int x = ((from a in ent.Articulo  select a.IdArticulo ).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1; //en caso de que no exista algun registro
            }
        }
    }
}
