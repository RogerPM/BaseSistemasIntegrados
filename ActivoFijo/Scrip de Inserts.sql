use TECA
/***********************************************INSERTS****************************************************/
--TABLA SUBGRUPO DE ACTIVOS FIJOS
insert into ActivoFijo.SubGrupos(IdSubGrupo,IdGrupo,Descripcion ,fecha ,IdEstado ,IdEmpresa) values (1,2,'Equipos de Computos','2013-07-28',null,null);
insert into ActivoFijo.SubGrupos(IdSubGrupo,IdGrupo,Descripcion ,fecha ,IdEstado ,IdEmpresa)values(2,1,'Muebles de oficina','1995-03-14',null,null);
insert into ActivoFijo.SubGrupos(IdSubGrupo,IdGrupo,Descripcion ,fecha ,IdEstado ,IdEmpresa) values (3,3,'Vehiculos Livianos','2002-08-21',null,null);
insert into ActivoFijo.SubGrupos(IdSubGrupo,IdGrupo,Descripcion ,fecha ,IdEstado ,IdEmpresa)values(4,2,'Maquinarias de Oficina','1990-03-14',null,null);
insert into ActivoFijo.SubGrupos(IdSubGrupo,IdGrupo,Descripcion ,fecha ,IdEstado ,IdEmpresa) values (5,1,'Equipos de Oficina','2010-05-18',null,null);

--TABLA GRUPO DE INVENTARIO
insert into Inventario.Grupo(IdEmpresa,IdGrupo,Descripcion,IdTipoArticulo,IdEstado,IdUsuario) values(null,1,'Muebles Y Enseres',null,null,null); 
insert into Inventario.Grupo (IdEmpresa,IdGrupo,Descripcion,IdTipoArticulo,IdEstado,IdUsuario) values(null,2,'EquipsMaquiMueb',null,null,null);
insert into Inventario.Grupo (IdEmpresa,IdGrupo,Descripcion,IdTipoArticulo,IdEstado,IdUsuario) values(null,3,'Vehiculos',null,null,null);

go
use TECA
create table ActivoFijo.AbPrueba
(
codigo int primary key not null,
nombre varchar (150)null,
descripcion varchar(150) null,
genero bit null,
)
go






