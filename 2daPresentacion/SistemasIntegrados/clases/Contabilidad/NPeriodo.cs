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
        
        public List<AnoFiscal> peridosoConsulta(){
            try
            {
                List<AnoFiscal> list = new List<AnoFiscal>();
                TECAEntitiesCont ent = new TECAEntitiesCont();
                var sel = from q in ent.AnoFiscal select q;
                foreach (var item in sel)
                {
                    AnoFiscal clase = new AnoFiscal();
                    clase.FechaModificacion = item.FechaModificacion;
                    clase.IdAnoFiscal = item.IdAnoFiscal;
                    clase.inicio_periodo = item.inicio_periodo;
                    list.Add(clase);
                }
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<clsPeriodoContable> ListarP(int buscar)
        {
            try
            {
                using (this.dt = new TECAEntitiesCont())
                {
                    List<clsPeriodoContable> lista = new List<clsPeriodoContable>();
                    var per = from c in this.dt.PeriodoContable
                             where c.IdAFiscal == buscar && c.IdEmpresa == 1                             
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

        public List<clsPeriodoContable> generarP(String buscar)
        {
            EPeriodoContable gene = new EPeriodoContable();
            NPeriodo addPeriodo = new NPeriodo();
            //NModeloAsiento addModeloAsiento = new NModeloAsiento();
            int mes = 0;

            int WIDempresa = 0;
            int WIdPeriodo = 0;
            int WIdAFiscal = 0;
            DateTime wFechaInicio = DateTime.Now;
            DateTime wFechaFin = DateTime.Now;
            int WIdEstado = 0;
            int WIdUsuario = 0;
            DateTime wFechaModificacion = DateTime.Now;

            try
            {
                for (int i = 1; i < 13; i++)
                {
                    // Genero los meses del año que no existe
                    TECAEntitiesCont ent = new TECAEntitiesCont();
                    WIDempresa = 1;
                    WIdPeriodo = i;
                    WIdAFiscal = Convert.ToInt32(buscar);
                    string fechaI = buscar + '-' + i.ToString() + '-' + 1;
                    if(i==2){
                    string fechaF = buscar + '-' + i.ToString() + '-' + 28;
                    wFechaFin = Convert.ToDateTime(fechaF);
                    }
                    if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
                    {
                        string fechaF = buscar + '-' + i.ToString() + '-' + 31;
                        wFechaFin = Convert.ToDateTime(fechaF);
                    }
                    if (i == 4 || i == 6 || i == 9 || i == 11 )
                    {
                        string fechaF = buscar + '-' + i.ToString() + '-' + 30;
                        wFechaFin = Convert.ToDateTime(fechaF);
                    }
                    wFechaInicio = Convert.ToDateTime(fechaI);
                    WIdEstado = 1;
                    WIdUsuario = 1;
                    wFechaModificacion = DateTime.Now;
                    //DateTime.Now
                    NPeriodo dat = new NPeriodo();
                    dat.periodocontable_Insertar(WIDempresa, WIdPeriodo, WIdAFiscal, wFechaInicio, wFechaFin, WIdEstado, WIdUsuario, wFechaModificacion);



                    ///this.txtSecuencia.Text = this.addModeloAsiento.Insertar(this.e).ToString();
                    ///this.addModeloAsiento.Insertar(this.e).ToString();.
                    //MessageBox.Show("Registro insertado correctamente", "Correcto!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    /// pongo en falso que al precionar grabar otra vez no se 
                }

                return ListarP(Convert.ToInt32(buscar));
            }
            catch (Exception ex)
            {
                
                throw new Exception("Error al Listar rrrr\n " + ex.Message);
            }
        }

        
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
           //     System.Windows.Forms.MessageBox.Show(ex.ToString());
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
