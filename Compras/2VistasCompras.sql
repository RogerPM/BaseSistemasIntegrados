use TECA
go
-- Vista Proveedor
Create view Compras.ProveedorDescripcion as
SELECT	p.IdProveedor, p.IdPersona, NombreRazonSocial, p.IdEmpresa, RazonSocial, p.IdTipoArticulo, t.Descripcion, p.Estado
FROM	Compras.Proveedor p, RecursosHumanos.Persona, Seguridad.Empresa, Inventario.TipoArticulo t
WHERE	RecursosHumanos.Persona.IdPersona  = p.IdPersona 
and		Seguridad.Empresa.IdEmpresa = p.IdEmpresa
and     p.IdTipoArticulo = t.IdTipoArticulo
go
--vista vehiculo
Create view Compras.Vehiculo_Vista
as
Select	emp.NombreComercial, art.IdArticulo, art.Descripcion,  art.CantidadActual, art.IdTipoArticulo, tip.Descripcion TipoArticulo, art.IdGrupo, 
		gru.Descripcion Grupo,cha.Descripcion Chasis, mot.Descripcion TipoMotor,tco.Descripcion TipoComb, 
		col.Descripcion Color, mar.Descripcion Marca , mol.Descripcion Modelo, tma.Descripcion TipoMaterial, art.idestado, est.Descripcion Estado
from	Inventario.Articulo art, Inventario.TipoArticulo tip, Inventario.Grupo gru, Inventario.Chasis cha, Inventario.TipoMotor mot, 
		Inventario.TipoCombustible tco, Inventario.Color col, Inventario.Marca mar, Inventario.Modelo mol, Inventario.TipoMaterial tma,
		Seguridad.Estado est, Seguridad.Empresa emp
where	art.IdEmpresa=emp.IdEmpresa
and		art.IdTipoArticulo = tip.IdTipoArticulo
and		art.IdGrupo= gru.IdGrupo
and		art.IdChasis= cha.IdChasis
and		art.IdTipoMotor= mot.IdTipoMotor
and		art.IdTipoCombustible= tco.IdTipoCombustible
and		art.IdColor= col.IdColor
and		art.IdMarca= mar.IdMarca
and		art.IdModelo= mol.IdModelo
and		art.IdTipoMaterial= tma.IdTipoMaterial
and		art.IdEstado= est.IdEstado
and		art.IdGrupo= 6
go
--vista articulos
Create view Compras.Articulo_Vista
as
select	art.IdArticulo, art.Descripcion, art.CantidadActual, art.IdTipoArticulo, tip.Descripcion TipoArticulo, art.IdGrupo,
		gru.Descripcion Grupo,art.IdEmpresa, emp.NombreComercial ,art.IdEstado,est.Descripcion Estado
from	Seguridad.Empresa emp, Inventario.Articulo art, Inventario.TipoArticulo tip, Inventario.Grupo gru, Seguridad.Estado est
where	art.IdEmpresa= emp.IdEmpresa
and		art.IdTipoArticulo= tip.IdTipoArticulo
and		art.IdGrupo= gru.IdGrupo
and		art.IdEstado= est.IdEstado
and		art.IdGrupo != 6
go
--vista cabecera de solicitudes
Create view Compras.SolicitudCab
as
select	cab.Numero, cab.idEmpresa ,emp.NombreComercial Empresa, cab.idtipoArticulo, tip.Descripcion TipoArticulo, cab.IdUsuario,usu.NombreUsuario Usuario, 
		cab.idDepartamento,dep.Descripcion Departamento, cab.Fecha, cab.idEstado,est.Descripcion Estado
from	Compras.Solicitud cab,  Seguridad.Empresa emp, Inventario.TipoArticulo tip, Seguridad.Usuario usu,
		RecursosHumanos.Departamento dep, Compras.Estado est
where	cab.idEmpresa= emp.IdEmpresa
and		cab.IdTipoArticulo= tip.IdTipoArticulo
and		cab.IdUsuario= usu.IdUsuario
and		cab.idDepartamento= dep.IdDepartamento
and		cab.idEstado= est.IdEstado
go

--vista detalle de solicitudes
Create View Compras.SolicitudDetalle
as
select	det.numero, det.Linea, det.idArticulo, art.Descripcion Articulo, det.Cantidad, det.idEmpresa, emp.NombreComercial Empresa
from	Compras.SolicitudDet det, Compras.Solicitud cab, Inventario.Articulo art, Seguridad.Empresa emp
where	det.Numero= cab.Numero
and		det.idArticulo= art.IdArticulo
and		det.idEmpresa= emp.IdEmpresa
go
-- Vista cabecera Pedido
Create view Compras.PedidoCabecera_Vista
as
select	cab.Numero, cab.idTipoArticulo, tip.Descripcion TipoArticulo, cab.Fecha, cab.idEmpresa, emp.NombreComercial Empresa,
		cab.idUsuario, usu.NombreUsuario Usuario,
		cab.idEstado, est.Descripcion Estado
from	Compras.Pedido cab, Inventario.TipoArticulo tip, Seguridad.Empresa emp, Compras.Estado est, Seguridad.Usuario usu
where	cab.idTipoArticulo = tip.IdTipoArticulo
and		cab.idEmpresa= emp.IdEmpresa
and		cab.idEstado= est.idEstado
and		cab.idUsuario= usu.idUsuario
go
--Vista Detalle Pedido
Create view Compras.PedidoDetalle_Vista
as
select	det.numero, det.Linea, det.idArticulo, art.Descripcion Articulo, det.Cantidad, det.idEmpresa, emp.NombreComercial Empresa
from	Compras.PedidoDet det, Compras.Pedido cab, Inventario.Articulo art, Seguridad.Empresa emp
where	det.Numero= cab.Numero
and		det.idArticulo= art.IdArticulo
and		det.idEmpresa= emp.IdEmpresa
go
-- Vista Cotizacion Cabecera
Create view Compras.CotizacionCab_Vista
as
select  cab.Numero, cab.idproveedor, pro.NombreRazonSocial Proveedor, cab.Fecha, cab.idEstado, est.descripcion Estado, 
		cab.idEmpresa, emp.NombreComercial Empresa, cab.IdUsuario, usu.NombreUsuario Usuario
from	Compras.Cotizacion cab, Compras.Proveedordescripcion pro, Compras.estado est, Seguridad.Empresa emp, Seguridad.Usuario usu
where	cab.idproveedor= pro.idProveedor
and		cab.idEstado= est.idestado
and		cab.idEmpresa= emp.IdEmpresa
and		cab.IdUsuario= usu.IdUsuario
go
--Vista Cotizacion Detalle
Create View  Compras.CotizacionDetalle_Vista
as
select		det.Numero, det.Linea, det.NumeroPedido, ped.idUsuario, usu.NombreUsuario, ped.Fecha, ped.idTipoArticulo,
			tip.Descripcion TipoArticulo, det.idEmpresa, emp.NombreComercial Empresa
from		Compras.CotizacionDet det, Seguridad.Empresa emp, Compras.Pedido ped, Seguridad.Usuario usu, Inventario.TipoArticulo tip
where		det.idEmpresa= emp.IdEmpresa
and			det.NumeroPedido= ped.Numero
and			ped.idUsuario= usu.IdUsuario
and			ped.idTipoArticulo= tip.IdTipoArticulo
go

Create View Compras.OrdenCompraCab_Vista
as
select		cab.IdOrdenCompra, cab.idProveedor,pro.NombreRazonSocial Proveedor , cab.NumeroCotizacion, cab.Fecha,
			cab.IdUsuario, usu.NombreUsuario,cab.idEmpresa, emp.NombreComercial,cab.idEstado,est.Descripcion Estado, cab.Observaciones
from		Compras.OrdenCompra cab, Seguridad.Empresa emp, Seguridad.Usuario usu, Compras.ProveedorDescripcion pro, Compras.Estado est
where		cab.idEmpresa= emp.IdEmpresa
and			cab.IdUsuario= usu.IdUsuario
and			cab.idProveedor= pro.idProveedor
and			cab.idEstado= est.idEstado
GO			

Create view Compras.OrdenCompraDetalle_Vista
as
select		det.Numero, det.Linea, det.IdArticulo, art.Descripcion Articulo, det.Cantidad, det.Precio,
			det.IdEmpresa, emp.NombreComercial
from		Compras.OrdenCompraDet det, Seguridad.Empresa emp, Inventario.Articulo art
where		det.IdEmpresa= emp.IdEmpresa
and			det.IdArticulo= art.IdArticulo
go