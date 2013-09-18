from TipoTransaccions in dt.TipoTransaccions
from Modulos in dt.Modulos
where
  TipoTransaccions.modulo == Modulos.IdModulo
select new {
  TipoTransaccions.IdTransaccion,
  TipoTransaccions.modulo,
  Modulos.Nombre,
  TipoTransaccions.TipoDocumento,
  TipoTransaccions.descripcion
}