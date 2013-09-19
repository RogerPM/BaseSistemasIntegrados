using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using clases.ActivoFijo;
using datos.ActivoFijo;




namespace datos.ActivoFijo
{
    
    public class clsDatosBajaActivoProce

    {
      
        


        #region"Funciones de Programa"




        
        public int getSiguiente()
        {
            try
            {
                ActivoFijoEntities ent = new ActivoFijoEntities();
                int x = ((from a in ent.BajaActivo select a.idBajaActivo).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1;
            }
        }

        public List<clsBajaActivoProc> consulta()
        {
            try
            {
                List<clsBajaActivoProc> lista = new List<clsBajaActivoProc>();
                ActivoFijoEntities ent = new ActivoFijoEntities();
                var con = from w in ent.BajaActivo select w;

                foreach (var item in con)
                {
                    clsBajaActivoProc clas = new clsBajaActivoProc();
                    clas.estadoproceso = item.EstadoProceso;
                    clas.idActivoFijo = Convert.ToInt32(item.idBajaActivo);
                    //clas.idgrupo  = Convert.ToInt32(item.IdGrr);
                    clas.fecha = Convert.ToDateTime(item.Fecha);
                    //clas.idsubgrupo  =Convert.ToInt32(item.IdSubgrupo);
                    clas.Empresa = Convert.ToInt32(item.IdEmpresa);
                    clas.IdMotivoBaja = Convert.ToInt32(item.MotivoBaja);
                    //clas.idProveedor = Convert.ToInt32(item.IdProveedor);
                    //clas.IdCabeceraComprobante = Convert.ToInt32(item.IdCabeceraComprobante);
                    clas.descripcion = item.Descripcion;
                    clas.Observacion = item.Observacion;
                    //clas.idImagen = Convert.ToInt32(item.IdImagen);


                    
                    

                    lista.Add(clas);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
          }

        public Boolean guardar(clsBajaActivoProc BajaActivopro)
        {
            try
            {
                int id = getSiguiente();
                BajaActivopro.codBajaActivo = id;
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                        BajaActivo act = new BajaActivo(){
                        IdActivoFIjo = BajaActivopro.idActivoFijo,
                        IdEmpresa = BajaActivopro.Empresa,
                        //IdGrupo= BajaActivopro.idgrupo,
                        //IdSubgrupo= BajaActivopro.idsubgrupo,
                        Fecha = BajaActivopro.fecha,
                        EstadoProceso = BajaActivopro.estadoproceso,
                        Descripcion = BajaActivopro.descripcion,
                        IdMotivoBaja= BajaActivopro.IdMotivoBaja,
                        //IdProveedor= BajaActivopro.idProveedor,
                        //IdCabeceraComprobante = BajaActivopro.IdCabeceraComprobante,
                        Observacion = BajaActivopro.Observacion,
                        IdImagen= 1,

                       
                         
                    };

                    ent.AddToBajaActivo(act);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public Boolean modificar(clsBajaActivoProc bajaActivopro)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    //Se hace un primary key codigo 
                    var x = (from q in ent.BajaActivo where q.IdActivoFIjo == bajaActivopro.idActivoFijo select q).First();

                        x.IdActivoFIjo = bajaActivopro.idActivoFijo;
                        x.IdEmpresa = bajaActivopro.Empresa;
                        //x.IdGrupo= bajaActivopro.idgrupo;
                        //x.IdSubgrupo= bajaActivopro.idsubgrupo;
                        x.Fecha = bajaActivopro.fecha;
                        x.EstadoProceso = bajaActivopro.estadoproceso;
                        x.Descripcion = bajaActivopro.descripcion;
                        x.IdMotivoBaja= bajaActivopro.IdMotivoBaja;
                        //x.IdProveedor= bajaActivopro.idProveedor;
                       // x.IdCabeceraComprobante = bajaActivopro.IdCabeceraComprobante;
                        x.Observacion = bajaActivopro.Observacion;
                       // x.IdImagen = bajaActivopro.idImagen;



                   

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
