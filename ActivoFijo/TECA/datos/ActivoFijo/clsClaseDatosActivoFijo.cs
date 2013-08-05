using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using clases.ActivoFijo;

namespace datos.ActivoFijo
{
    public class clsClaseDatosActivoFijo
    {

        /*
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
                    clas.Codigo = item.IdActivoFijo;
                    clas.Empresa = item.IdEmpresa;
                    clas.departamento = item.IdDepartamento;
                    clas.responsable = item.IdResponsable;
                    clas.usuario = item.IdUsuario;
                    clas.tipo = item.IdTipo;
                    clas.grupo = item.IdGrupo;
                    clas.subgrupo = item.IdSubgrupo;
                    clas.articulo = item.IdArticulo;
                    clas.descripcion = item.descripcion;
                    clas.valor_nominal = Convert.ToInt32(item.valor_nomial);
                    clas.valor_residual = Convert.ToInt32(item.valor_residual);
                    clas.valor_actualserie = Convert.ToInt32(item.valor_actualserie);
                    clas.codigo_barra = item.IdCodigoBarra;
                    clas.serie = Convert.ToInt32 (item.serie);
                    clas.marca = item.IdMarca;
                    clas.fecha_deprecioacion = item.fecha_depreciacion;
                    clas.ano_vidautil = Convert.ToInt32(item.ano_vidaUtil);
                    clas.estado = item.IdEstado;
                    clas.fecha_registro = item.fecha_registro;

                    lista.Add(clas);
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }

        }
        */
        public void guardar (clsActivoFijo activo)
        {
                using (ActivoFijoEntities  ent = new ActivoFijoEntities ())
                {
                    ActivoFijo act = new ActivoFijo()
                    {
                        IdActivoFijo =activo.Codigo,
                        IdEmpresa =activo.Empresa
                    };
                    
                }

        }



    }
}
