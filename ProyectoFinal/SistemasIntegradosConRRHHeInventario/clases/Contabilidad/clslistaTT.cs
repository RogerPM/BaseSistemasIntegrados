using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clases.Contabilidad
{
    public class clslistaTT
    {

        public class Query1
        {
            private Int32? _IdTransaccion;
            private Int32? _modulo;
            private String _Nombre;
            private String _TipoDocumento;
            private String _descripcion;
            public Query1(
                Int32? AIdTransaccion, Int32? Amodulo, String ANombre,
                String ATipoDocumento, String Adescripcion)
            {
                _IdTransaccion = AIdTransaccion;
                _modulo = Amodulo;
                _Nombre = ANombre;
                _TipoDocumento = ATipoDocumento;
                _descripcion = Adescripcion;
            }
            public Int32? IdTransaccion { get { return _IdTransaccion; } }
            public Int32? modulo { get { return _modulo; } }
            public String Nombre { get { return _Nombre; } }
            public String TipoDocumento { get { return _TipoDocumento; } }
            public String descripcion { get { return _descripcion; } }
        }
        public class Query1List : List<Query1>
        {
            public Query1List(TECAEntitiesCont dt)
            {
                var query =
                    from TipoTransaccions in dt.TipoTransaccion
                    from Modulos in dt.Modulo
                    where
                      TipoTransaccions.modulo == Modulos.IdModulo
                    select new
                    {
                        TipoTransaccions.IdTransaccion,
                        TipoTransaccions.modulo,
                        Modulos.Nombre,
                        TipoTransaccions.TipoDocumento,
                        TipoTransaccions.descripcion
                    };
                foreach (var r in query)
                    Add(new Query1(
                        r.IdTransaccion, r.modulo, r.Nombre, r.TipoDocumento,
                        r.descripcion));
            }
        }
    }
}
