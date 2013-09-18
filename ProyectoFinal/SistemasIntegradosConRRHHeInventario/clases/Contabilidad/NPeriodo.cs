using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.Contabilidad;
using clases;

namespace clases.Contabilidad
{
    public class NPeriodo
    {
        public TECAEntitiesCont dt = null;
        /// <summary>
        /// Metodo para Listar Modelo de Asiento
        /// </summary>
        /// <param name="buscar"> Nombre de variables descripcion </param>
        /// <returns></returns>
        ///&& c.IdPeriodoContable.Equals(buscar) 
        //public List<PeriodoContable> ListarP(int buscar)
        public List<clsPeriodoContable> ListarP(int @buscar)
        {
            try
            {
                using (this.dt = new TECAEntitiesCont())
                {
                    List<clsPeriodoContable> lista = new List<clsPeriodoContable>();
                    var per = from c in this.dt.PeriodoContable
                             where c.IdPeriodoContable == buscar && c.IdEmpresa == 1                             
                             //where c.IdEmpresa == 1 
                             select c;

                    foreach (var item in per)
                    {
                        clsPeriodoContable ctipo = new clsPeriodoContable();
                        //las variables puden ser nulas u no soportan el tipo de dato int por eso se realiza el convert
                        ctipo.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                        ctipo.IdPeriodoContable = Convert.ToInt32(item.IdPeriodoContable);
                        ctipo.FechaInicio = item.FechaInicio;
                        ctipo.FechaFin = item.FechaFin;
                        ctipo.IdAFiscal = Convert.ToInt32(item.IdAFiscal);
                        ctipo.IdEstado = Convert.ToInt32(item.IdEstado);
                        ctipo.IdUsuario = Convert.ToInt32(item.IdUsuario);
                        //ctipo.FechaModificacion = Convert.ToDateTime(item.FechaModificacion);
                        //ctipo.IdEstado = item.IdEstado;
                        lista.Add(ctipo);
                    }
                    //return per.ToList();
                    return lista;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Listar\n " + ex.Message);
            }
        }

        public List<clsPeriodoContable> generarP(String @buscar)
        {
            EPeriodoContable gene = new EPeriodoContable();
            NPeriodo addPeriodo = new NPeriodo();
            //NModeloAsiento addModeloAsiento = new NModeloAsiento();

            try
            {
                using (this.dt = new TECAEntitiesCont())
                {
                    List<clsPeriodoContable> generarlista = new List<clsPeriodoContable>();
                    var per = from c in this.dt.PeriodoContable
                              where c.IdPeriodoContable.ToString().Contains(buscar) && c.IdEmpresa == 1
                              select c;
                    int mes = 0;

                    int WIDempresa = 0;
                    int WIdPeriodo = 0;
                    int WIdAFiscal = 0;
                    DateTime wFechaInicio = DateTime.Now ;
                    DateTime wFechaFin = DateTime.Now ;
                    int WIdEstado = 0;
                    int WIdUsuario = 0;
                    DateTime wFechaModificacion = DateTime.Now ;

                    foreach (var item in per)
                    {
                        clsPeriodoContable ctipo = new clsPeriodoContable();
                        //las variables puden ser nulas u no soportan el tipo de dato int por eso se realiza el convert
                        //ctipo.IdEmpresa = Convert.ToInt32(item.IdEmpresa);
                        ctipo.IdPeriodoContable = Convert.ToInt32(item.IdPeriodoContable);
                        ctipo.IdAFiscal = Convert.ToInt32(item.IdAFiscal);
                        ctipo.FechaInicio = item.FechaInicio;
                        ctipo.FechaFin = item.FechaFin;
                        ctipo.IdEstado = item.IdEstado;
                        generarlista.Add(ctipo);
                        mes = 1;
                    }

                    if (mes == 0)
                    {
                        // Genero los meses del año
                        for (int i = 1; i < 13; i++)
                        {
                            // Genero los meses del año que no existe

                            WIDempresa = 1;
                            WIdPeriodo = Convert.ToInt32(buscar);
                            WIdAFiscal = i;
                            string fechaI = WIdPeriodo.ToString()+'-'+i.ToString()+'-'+1;
                            string fechaF = WIdPeriodo.ToString() + '-' + i.ToString() + '-' + 28;
                            wFechaInicio = Convert.ToDateTime(fechaI);
                            wFechaFin = Convert.ToDateTime(fechaF);
                            WIdEstado = 1;
                            WIdUsuario = 1;
                            wFechaModificacion = DateTime.Now;
                            //DateTime.Now
                                NPeriodo dat = new NPeriodo();
                                dat.periodocontable_Insertar(WIDempresa, WIdPeriodo, WIdAFiscal, wFechaInicio, wFechaFin , WIdEstado , WIdUsuario, wFechaModificacion);
                                ///this.txtSecuencia.Text = this.addModeloAsiento.Insertar(this.e).ToString();
                                ///this.addModeloAsiento.Insertar(this.e).ToString();.
                                //MessageBox.Show("Registro insertado correctamente", "Correcto!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                /// pongo en falso que al precionar grabar otra vez no se 
                        }
                    }
                    else
                    {
                        throw new Exception("Existe informacion en el año ");
                    }

                    //return per.ToList();
                    return generarlista;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al Listar\n " + ex.Message);
            }
        }

        /// <summary>
        /// Metodo Insertar
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public void periodocontable_Insertar(int _idEmpresa, int _idPeriodo, int _idAFiscal, DateTime _FechaInicio, DateTime _FechaFin, int _idEstado, int _idUsuario, DateTime _fechaModificacion)
        {
            try
            {
                using (TECAEntitiesCont dt = new TECAEntitiesCont())
                {
                    PeriodoContable pe = new PeriodoContable() {
                        IdEmpresa = _idEmpresa,
                        IdPeriodoContable = _idPeriodo,
                        IdAFiscal = _idAFiscal,
                        FechaInicio = _FechaInicio,
                        FechaFin = _FechaFin,
                        IdEstado=_idEstado,
                        FechaModificacion=_fechaModificacion,
                        IdUsuario=_idUsuario
                    };
                    dt.AddToPeriodoContable(pe);
                    dt.SaveChanges();
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
        public void periodocontable_Editar(int idEmpresa, int idPeriodo, int idAFiscal, int idEstado, int idUsuario, DateTime fechaModificacion)
        {
            try
            {
                using (TECAEntitiesCont ent = new TECAEntitiesCont())
                {
                    var upd=(from q in ent.PeriodoContable where q.IdEmpresa==idEmpresa && q.IdPeriodoContable ==idPeriodo select q).First();
                    upd.IdEstado = idEstado;
                    ent.SaveChanges();
                    
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
