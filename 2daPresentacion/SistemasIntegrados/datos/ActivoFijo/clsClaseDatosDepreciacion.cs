using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.ActivoFijo;
using datos.ActivoFijo;

namespace datos.ActivoFijo
{
    public class clsClaseDatosDepreciacion
    {

        #region"Funiciones de Programa"

        /*****Funciones que corresponderan a la calse de Inventario.Grupo*****/

        //metodo que retorna la descripcion de un estado segun su Id
        public string getDescripcionSegunIdActivoFIjoSubGrupo(int id)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
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
                    var x = (from a in ent.SubGrupos where a.Descripcion == descrip select a).First();
                    return x.IdSubGrupo; //se lo puede cambiar y devolver el objeto x que en realidad es un objeto estado lleno con valores correcto segun la base
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se encontro, Error: " + e);
                return 0;
            }
        }



        public int getSiguienteDepreCab()
        {


            try
            {
                ActivoFijoEntities ent = new ActivoFijoEntities();
                int x = ((from a in ent.DepreciacionCab select a.Secuencia_DepreciacionCab & a.IdEmpresa).Max()) + 1;
                //var x = (from a in ent.DepreciacionCab where a.Secuencia_DepreciacionCab == null select a).First();

                //if (x.Secuencia_DepreciacionCab == null)
                //{
                //    x.Secuencia_DepreciacionCab = 0;
                //    int p = Convert.ToInt32((from q in ent.DepreciacionCab select q.Secuencia_DepreciacionCab).Max())+1;
                //    return p;
                //}
                //else
                //{
                //    int r = ((from a in ent.DepreciacionCab select a.Secuencia_DepreciacionCab & a.IdEmpresa).Max()) + 1;
                //    return r;
                //} 
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1;
            }
        }

        public int getSiguienteDepreDet()
        {
            try
            {
                ActivoFijoEntities ent = new ActivoFijoEntities();
                int x = ((from a in ent.DepreciacionDet select a.Secuencia_DepreciacionDet & a.IdCabecera).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1;
            }
        }

        #endregion




        //#region"Operaciones Basicas"
        public List<clsDepreciacion> consultaDepreciacionDet()
        {

            try
            {
                List<clsDepreciacion> lista = new List<clsDepreciacion>();
                ActivoFijoEntities ent = new ActivoFijoEntities();

                var con = from p in ent.DepreciacionDet select p;
                var conDos = from w in ent.DepreciacionCab select w;

                foreach (var itemDos in conDos)
                {
                    clsDepreciacion Depre = new clsDepreciacion();
                    Depre.CodsecuenciaCab = Convert.ToInt32(itemDos.Secuencia_DepreciacionCab);
                    Depre.empresa = itemDos.IdEmpresa;
                    Depre.usuario = Convert.ToInt32(itemDos.IdUsuario);
                    Depre.estadoProceso = itemDos.EstadoProceso;
                    Depre.FechaRegistro = Convert.ToDateTime(itemDos.fecha);
                    Depre.FechaModificacion = Convert.ToDateTime(itemDos.fechaModificacion);
                    Depre.observacion = itemDos.observacion;

                    foreach (var item in con)
                    {

                        Depre.idCabecera = item.IdCabecera;
                        Depre.CodsecuenciaDet = item.Secuencia_DepreciacionDet;
                        Depre.ActivoFijo = Convert.ToInt32(item.IdActivoFijo);
                        Depre.periodo = Convert.ToInt32(item.Periodo);
                        Depre.empresa = Convert.ToInt32(item.IdEmpresa);
                        Depre.depreAnual = Convert.ToDouble(item.DepreAnual);
                        Depre.depreAcumulada = Convert.ToDouble(item.DepreAcumulada);
                        Depre.valorNominal = Convert.ToDouble(item.valor_nominal);
                        Depre.valorActual = Convert.ToDouble(item.valor_actual);


                    }

                    lista.Add(Depre);

                }

                //foreach (var item in con)
                //{
                //    clsDepreciacionDet DepreDet = new clsDepreciacionDet();
                //        DepreDet.idCabecera =item.IdCabecera;
                //        DepreDet.Codigo_SecuDepreciDet= item.Secuencia_DepreciacionDet ;
                //        DepreDet.idActivoFijo=Convert.ToInt32( item.IdActivoFijo);
                //        DepreDet.Perido= Convert.ToInt32(item.Periodo);
                //        DepreDet.idEmpresa = Convert.ToInt32(item.IdEmpresa);
                //        DepreDet.depreAnual=Convert.ToDouble( item.DepreAnual);
                //        DepreDet.depreAcumulada= Convert.ToDouble(item.DepreAcumulada );
                //        DepreDet.ValorNominal= Convert.ToDouble(item.valor_nominal );
                //        DepreDet.ValorActual = Convert.ToDouble(item.valor_actual);


                //}

                return lista;


            }
            catch (Exception)
            {

                return null;
            }
        }

        public Boolean modificar(clsDepreciacionCab DepreCab, clsDepreciacionDet DepreDet)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    //Se hace un primary key codigo 
                    var x = (from q in ent.DepreciacionDet where q.Secuencia_DepreciacionDet == DepreDet.Codigo_SecuDepreciDet select q).First();
                    var r = (from p in ent.DepreciacionCab where p.Secuencia_DepreciacionCab == DepreCab.Codigo_SecuDepreciCab select p).First();

                    //Cabecera 
                    r.Secuencia_DepreciacionCab = DepreCab.Codigo_SecuDepreciCab;
                    //r.IdEmpresa = DepreCab.idEmpresa;
                    //r.IdUsuario  = DepreCab.idUsuario;
                    r.EstadoProceso = DepreCab._EstadoProceso;
                    r.fecha = DepreCab.fecharegistro;
                    r.fechaModificacion = DepreCab.fecharegistro;
                    r.observacion = DepreCab.observacion;

                    //Detalle 
                    x.IdCabecera = Convert.ToInt32(DepreCab.Codigo_SecuDepreciCab);
                    x.Secuencia_DepreciacionDet = Convert.ToInt32(DepreDet.Codigo_SecuDepreciDet);
                    x.IdActivoFijo = DepreDet.idActivoFijo;
                    x.Periodo = Convert.ToInt32(DepreDet.Perido);
                    //x.IdEmpresa=Convert.ToInt32(DepreDet.idEmpresa );
                    x.DepreAnual = Convert.ToDecimal(DepreDet.depreAnual);
                    x.DepreAcumulada = Convert.ToDecimal(DepreDet.depreAcumulada);
                    x.valor_nominal = Convert.ToDecimal(DepreDet.ValorNominal);
                    x.valor_actual = Convert.ToDecimal(DepreDet.ValorActual);

                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }



        }

        public Boolean guardarDepreciacion(clsDepreciacionCab DepreCab, clsDepreciacionDet DepreDet)
        {
            try
            {
                int id = getSiguienteDepreCab();
                DepreCab.Codigo_SecuDepreciCab = id;
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    DepreciacionCab DepCab = new DepreciacionCab();
                    DepCab.Secuencia_DepreciacionCab = DepreCab.Codigo_SecuDepreciCab;
                    DepCab.IdEmpresa = DepreCab.idEmpresa;
                    DepCab.IdUsuario = DepreCab.idUsuario;
                    DepCab.EstadoProceso = DepreCab._EstadoProceso;
                    DepCab.fecha = DepreCab.fecharegistro;
                    DepCab.fechaModificacion = DepreCab.fechaModificacion;
                    DepCab.observacion = DepreCab.observacion;

                    //{
                    //    Secuencia_DepreciacionCab = DepreCab.Codigo_SecuDepreciCab,
                    //    //IdEmpresa = DepreCab.idEmpresa,
                    //    //IdUsuario  = DepreCab.idUsuario,
                    //    EstadoProceso =DepreCab ._EstadoProceso,                         
                    //    fecha = DepreCab.fecharegistro,
                    //    fechaModificacion=DepreCab.fechaModificacion,
                    //    observacion= DepreCab.observacion,                    
                    //};

                    ent.AddToDepreciacionCab(DepCab);
                    ent.SaveChanges();
                }

                int codId = getSiguienteDepreDet();
                DepreDet.Codigo_SecuDepreciDet = id;

                using (ActivoFijoEntities ini = new ActivoFijoEntities())
                {
                    DepreciacionDet DepDet = new DepreciacionDet();
                    DepDet.IdCabecera = Convert.ToInt32(DepreCab.Codigo_SecuDepreciCab);
                    DepDet.Secuencia_DepreciacionDet = Convert.ToInt32(DepreDet.Codigo_SecuDepreciDet);
                    DepDet.IdActivoFijo = DepreDet.idActivoFijo;
                    DepDet.Periodo = DepreDet.Perido;
                    DepDet.IdEmpresa = Convert.ToInt32(DepreDet.idEmpresa);
                    DepDet.DepreAnual = Convert.ToDecimal(DepreDet.depreAnual);
                    DepDet.DepreAcumulada = Convert.ToDecimal(DepreDet.depreAcumulada);
                    DepDet.valor_nominal = Convert.ToDecimal(DepreDet.ValorNominal);
                    DepDet.valor_actual = Convert.ToDecimal(DepreDet.ValorActual);
                    //{
                    //    IdCabecera = Convert.ToInt32(DepreCab.Codigo_SecuDepreciCab),
                    //    Secuencia_DepreciacionDet = Convert.ToInt32(DepreDet.Codigo_SecuDepreciDet),
                    //    IdActivoFijo = DepreDet.idActivoFijo,
                    //    Periodo = Convert.ToInt32(DepreDet.Perido),
                    //    //IdEmpresa=Convert.ToInt32(DepreDet.idEmpresa ),
                    //    DepreAnual = Convert.ToDecimal(DepreDet.depreAnual),
                    //    DepreAcumulada = Convert.ToDecimal(DepreDet.depreAcumulada),
                    //    valor_nominal = Convert.ToDecimal(DepreDet.ValorNominal),
                    //    valor_actual = Convert.ToDecimal(DepreDet.ValorActual),
                    //};

                    ini.AddToDepreciacionDet(DepDet);
                    ini.SaveChanges();
                }


                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex);
                return false;
            }

        }

        public Boolean eliminar(clsDepreciacionDet DepreDet, clsDepreciacionCab DepreCab)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    //Hago un wehere por el primaryKey codigo
                    var x = (from q in ent.DepreciacionDet where q.Secuencia_DepreciacionDet == DepreDet.Codigo_SecuDepreciDet select q).First();
                    var p = (from r in ent.DepreciacionCab where r.Secuencia_DepreciacionCab == DepreCab.Codigo_SecuDepreciCab select r).First();
                    //Eliminar es muy parecido
                    //Eliminar el registro que me trajpp el select
                    ent.DeleteObject(x);
                    ent.DeleteObject(p);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }


        //#endregion



    }

}
