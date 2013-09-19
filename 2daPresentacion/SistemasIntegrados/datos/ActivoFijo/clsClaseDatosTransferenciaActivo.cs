using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using clases.ActivoFijo;
using datos.ActivoFijo;

namespace datos.ActivoFijo
{
    public class clsClaseDatosTransferenciaActivo

    {

        #region"Funciones de Programa"

        public string getDescripcionSegunIdActivoFijo(int id)
        {
            try
            {
                using ( ActivoFijoEntities  ent = new ActivoFijoEntities ())
                {
                    var x = (from a in ent.Transferencia  where a.IdActivoFijo == id select a).First();
                    return x.Observaciones;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return null;
            }
        }

         public int getIdSegunDescripcionSegunIdc(string descrip)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    var x = (from a in ent.Transferencia where a.Observaciones == descrip select a).First();
                    return x.Idtransferencia; //se lo puede cambiar y devolver el objeto x que en realidad es un objeto estado lleno con valores correcto segun la base
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
                int x = ((from a in ent.Transferencia select a.Idtransferencia).Max()) + 1;
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1;
            }
        }

        public List<clsTransferencia> consulta()
        {
            try
            {
                List<clsTransferencia> lista = new List<clsTransferencia>();
                ActivoFijoEntities ent = new ActivoFijoEntities();
                var con = from w in ent.Transferencia select w;

                foreach (var item in con)
                {
                    clsTransferencia clas = new clsTransferencia();
                    clas.estadoproceso = item.EstadoProceso;
                    clas.idActivoFijo = Convert.ToInt32(item.IdActivoFijo);
                    clas.fecha = Convert.ToDateTime(item.fecha);
                    clas.EmpresaFutura = Convert.ToInt32(item.IdEmpresa);
                    clas.ResponsableFuturo = Convert.ToInt32( item.IdResponsableFuturo);
                    clas.BodegaFuturo = Convert.ToInt32(item.IdBodegaFuturo);
                    clas.Departamento =Convert.ToInt32 ( item.IdDepartamento);
                    clas.Observaciones = item.Observaciones;

                  
                    lista.Add(clas);
                }
                return lista;
            }
            catch (Exception )
            {
                return null;
            }

        }

         public Boolean guardartransferencia(clsTransferencia transferencia)
        {
            try
            {
                int id = getSiguiente();
                transferencia.codTransferencia  = id;
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    Transferencia act = new Transferencia();
                    act.IdActivoFijo = transferencia.idActivoFijo;
                    act.IdEmpresa = transferencia.EmpresaFutura;
                    act.fecha = transferencia.fecha;
                    act.EstadoProceso = transferencia.estadoproceso;
                    act.IdResponsableFuturo = transferencia.ResponsableFuturo;
                    act.IdBodegaFuturo = transferencia.BodegaFuturo;
                    act.IdDepartamento = transferencia.Departamento;
                    act.Observaciones = transferencia.Observaciones;


                    //{
                    //    IdActivoFijo = transferencia.idActivoFijo,
                    //    IdEmpresa = transferencia.EmpresaFutura,
                    //    fecha = transferencia.fecha,
                    //    EstadoProceso = transferencia.estadoproceso,
                    //    IdResponsableFuturo = transferencia.ResponsableFuturo,
                    //    IdBodegaFuturo = transferencia.BodegaFuturo,
                    //    IdDepartamento = transferencia.Departamento,
                    //    Observaciones = transferencia.Observaciones
                    //};   
                    
                    ent.AddToTransferencia(act);
                    ent.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }

        public Boolean modificar(clsTransferencia transferencia)
        {
            try
            {
                using (ActivoFijoEntities ent = new ActivoFijoEntities())
                {
                    //Se hace un primary key codigo 
                    var x = (from q in ent.Transferencia where q.IdActivoFijo == transferencia.idActivoFijo select q).First();

                    x.IdActivoFijo    =transferencia.idActivoFijo;
                    x.Idtransferencia = transferencia.codTransferencia;
                    x.fecha= transferencia.fecha;
                    x.IdEmpresa = transferencia.EmpresaFutura;
                    x.IdResponsableFuturo = transferencia.ResponsableFuturo;
                    x.IdBodegaFuturo= transferencia.BodegaFuturo;
                    x.IdDepartamento = transferencia.Departamento;
                    x.Observaciones = transferencia.Observaciones;
                    x.EstadoProceso = transferencia.estadoproceso;

                    
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