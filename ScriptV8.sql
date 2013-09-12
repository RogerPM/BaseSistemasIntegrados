use master
if exists(select * from sys.databases where name='TECA')-- solo existen los objetos sys.databases y sys.sysdatabases
drop database TECA
PRINT N'1.base eliminada'
go

create database TECA
PRINT N'2.base creada '
go

--crear los esquemas respectivos para cada Modulo
use TECA
go
create schema Seguridad
go
create schema Compras
go
create schema Facturacion
go
create schema CuentaxPagar
go
create schema CuentasPorCobrar
go
create schema Inventario
go
create schema Contabilidad
go
create schema RecursosHumanos
go
create schema ActivoFijo
go
create schema Taller
go

--crear las tablas y anadirlas al esquema de su repectivo modulo
--seguridad

create table  Seguridad.Estado
(
	 IdEstado			int			primary key,
	 Descripcion		varchar(220)
) 
go
--Estado usados en procesos de compras
Create table Compras.Estado
(
	idEstado			int		primary key,
	Descripcion			varchar (100)
)
go


create table  Seguridad.Imagen
(
	 IdImagen				int				primary key,
	 Descripcion			varchar(50),
	 Imagen					image
)
go


create table Seguridad.Empresa
(
	 IdEmpresa				int				primary key,
	 RazonSocial			varchar  (50),
	 NombreComercial		varchar  (50),
	 Ruc					varchar  (20),
	 Direccion				varchar	 (200),
	 Logotipo				image,
	 FechaInicioSistema		datetime,
	 Correo					varchar  (70),
	 SitioWeb				varchar  (70),
	 Sector					varchar  (15),
	 Descripcion			varchar  (250),
	 IdEstado				int				foreign key references Seguridad.Estado on delete cascade
)
go


/**************************Recursos humanos******************************
************************************************************************/
/*TIPO PERSONA*/
create table RecursosHumanos.TipoPersona
(
	IdTipoPersona			int not null			primary key,
	Descripcion				varchar(50) not null,
	IdEmpresa				int not null,
	IdEstado				int not null,
	foreign key (IdEmpresa) references Seguridad.Empresa ,
	foreign key (IdEstado) references Seguridad.Estado
)
go




/*TIPO IDENTIFICACION*/
create table RecursosHumanos.TipoIdentificacion
(
	IdTipoIdentificacion	int not null primary key,
	descripcion				varchar (50) not null,
	IdEmpresa				int not null,
	IdEstado				int not null,


	foreign key (IdEmpresa) references Seguridad.Empresa,

)
go

/*PERSONA*/
create table RecursosHumanos.Persona
(
	IdPersona			int not null primary key,
	Identificacion		numeric(14,0) not null,
	IdTipoPersona		int not null,
	IdEmpresa			int not null,
	NombreRazonSocial	varchar(100) not null,
	Apellido			varchar(50)null,
	FechaNacimiento		datetime null,
	genero				char(1) null,
	TipoIdentificacion	int not null,
	direccion			varchar (100) not null,
	TelefonoGneral		numeric(14,0)null,
	TelefonoMovil		numeric(14,0)not null,
	TelefonoCasa		numeric (14,0) not null,
	TelefonoOtros		numeric (14,0) null,
	mail				varchar (50) not null,
	IdEstado			int not null,



foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdTipoPersona)references RecursosHumanos.TipoPersona,
foreign key (TipoIdentificacion)references RecursosHumanos.TipoIdentificacion

)
go

/*CLIENTE*/
--create table RecursosHumanos.Cliente
--(
--	IdCliente				int not null primary key,
--	IdPersona				int not null,
--	IdEmpresa				int not null,
--	IdEstado				int not null,
--	foreign key (IdEmpresa) references Seguridad.Empresa,
--	foreign key (IdEstado) references Seguridad.Estado,
--	foreign key (IdPersona) references RecursosHumanos.Persona
--)
--go


/*EMPLEADO*/
create table RecursosHumanos.Empleado
(
	IdEmpresa				int not null,
	IdEmpleado				int not null,
	IdPersona				int not null,
	IdEstado				int not null,
	Sueldo					money not null,
	primary key (IdEmpresa,IdPersona),
	foreign key (IdEstado)references Seguridad.Estado,
	foreign key (IdEmpresa)references Seguridad.Empresa,
	foreign key (IdPersona)references RecursosHumanos.Persona
)
go

/*MATERNIDAD*/
create table RecursosHumanos.Maternidad
(
	NumMaternidad			int not null		primary key,
	IdEmpleado				int not null,
	IdEmpresa				int not null,
	FechaParto				datetime not null,
	FechaInicio				datetime not null,
	FechaFin				datetime not null,
	FechaModificacion		datetime, 
	IdEstado				int not null,
	foreign key (IdEstado)references Seguridad.Estado,
	foreign key (IdEmpleado,IdEmpresa)references RecursosHumanos.Empleado
)
go

/*DEPARTAMENTO*/
create table RecursosHumanos.Departamento
(
	IdDepartamento			int not null		primary key,
	Descripcion				varchar(50)not null,
	IdEstado				int not null,

)
go

/*PERFIL*/
create table Seguridad.Perfil 
(
	 IdPerfil		int							primary key,
	 Descripcion	varchar (70),
	 IdEstado		int							references Seguridad.Estado on delete cascade,   
)
go


/*USUARIO*/
create table Seguridad.Usuario
(
	 IdUsuario			int,
	 NombreUsuario		varchar(20)			not null unique,
	 Contrasena			varchar(220)		not null,
	 IdEstado			int					references Seguridad.Estado on delete cascade,
	 IdImagen			int					references Seguridad.Imagen on delete cascade,
	 IdPerfil int ,
	 primary key(IdUsuario),
	 -- foreign key(IdPerfil) references Seguridad.Perfil,
	 foreign key (IdUsuario) references RecursosHumanos.Persona on delete cascade --el id usuario es el mismo q id persona
)
go


/*PROVEEDOR REasignado a Compras.Proveedor hasta que RRHH tome la batuta*/
create table RecursosHumanos.Proveedor
(
	IdProveedor int not null primary key,
	IdPersona int not null,
	foreign key (IdPersona)references RecursosHumanos.Persona
)
go

/*CURSO*/
create table RecursosHumanos.Curso
(
	IdCurso					int					primary key,
	IdEmpresa				int not null, 
	FechaInicio				date not null,
	FechaFinal				date not null,
	foreign key (IdEmpresa)references Seguridad.Empresa
)
go

/*UNIVERSIDAD*/
create table RecursosHumanos.Universidad
(
	IdUniversidad			int					primary key,
	IdEmpresa				int not null, 
	Nombre					varchar(30) not null,
	foreign key (IdEmpresa)references Seguridad.Empresa
)
go

/*PERSONAxCURSO*/
create table RecursosHumanos.PersonaxCurso
(
	IdPersonaxCurso			int not null		primary key,
	IdPersona				int not null,
	IdEmpresa				int not null,
	IdCurso					int not null,
	foreign key (IdEmpresa) references Seguridad.Empresa,
	foreign key (IdPersona)references RecursosHumanos.Persona,
	foreign key (IdCurso)references RecursosHumanos.Curso
)
go

/*TIPO TELEFONO*/
create table RecursosHumanos.TipoTelefono
(
	IdTipoTelefono			int not null		primary key,
	Descripcion				varchar(30) not null,
	IdEmpresa				int not null,
	IdEstado				int not null,
	foreign key (IdEstado) references Seguridad.Estado,
	foreign key (IdEmpresa) references Seguridad.Empresa
)
go

/*TELEFONO*/
create table RecursosHumanos.Telefono
(
	IdTelefono				int not null		primary key,
	Numero					int not null,
	IdTipoTelefono			int not null,
	foreign key (IdTipoTelefono) references RecursosHumanos.TipoTelefono
)
go


/*TITULO*/
create table RecursosHumanos.Titulo
(
	IdTitulo				int					primary key,
	Nombre					varchar(50),
	FechaInicio				date not null,
	FechaFinal				date not null,
	IdEstado				int not null,
	IdUniversidad			int not null,
	IdEmpresa				int not null,
	foreign key (IdEmpresa) references Seguridad.Empresa,
	foreign key (IdUniversidad)references RecursosHumanos.Universidad,

)
go

/*TIPO JORNADA*/
create Table RecursosHumanos.TipoJornada
(
	IdTipoJornada			int					primary key,
	Descripcion				varchar(45),
	IdEmpresa				int not null,
	foreign key (IdEmpresa) references Seguridad.Empresa
)
go

/*JORNADA*/
create table RecursosHumanos.Jornada
(
	IdJornada				int not null primary key,
	Fecha					datetime not null,
	FechaModificacion		datetime,
	HoraInicio				time not null,
	HoraFinal				time not null,
	IdEmpresa				int not null,
	IdTipoJornada			int not null,
	IdPersona				int not null,
	foreign key (IdTipoJornada) references RecursosHumanos.TipoJornada,
	foreign key (IdEmpresa) references Seguridad.Empresa,
	foreign key (IdPersona) references RecursosHumanos.Persona
)
go

/*MULTA*/
create table RecursosHumanos.Multa
(
	IdMulta					int	primary key,
	Descripcion				varchar(45),
	Porcentaje				float not null,
	IdEmpresa				int not null,
	IdEstado				int not null,
	foreign key (IdEmpresa) references Seguridad.Empresa,

)
go

/*MULTAxPERSONA*/
create table RecursosHumanos.MultaxPersona
(
	IdPersona				int not null,
	IdMulta					int not null,
	FechaEmision			date not null,
	FechaModificacion		datetime,
	IdEmpresa				int not null,
	IdEstado				int not null,
	primary key (idpersona,idmulta),
	foreign key (IdMulta) references RecursosHumanos.Multa,
	foreign key (IdEmpresa) references Seguridad.Empresa,

	foreign key (IdPersona) references RecursosHumanos.Persona
)
go

/*PERSONAxDEPARTAMENTO*/
create table RecursosHumanos.PersonaxDepartamento
(
	IdEmpresa				int not null, 
	IdPersona				int not null,
	IdDepartamento			int not null,
	IdEstado				int not null,
	primary key (idpersona,iddepartamento),
	foreign key (IdDepartamento) references RecursosHumanos.Departamento,
	foreign key (IdEmpresa)references Seguridad.Empresa,

	foreign key (IdPersona) references RecursosHumanos.Persona
)
go

/*CARGO*/
create table RecursosHumanos.Cargo
(
	IdCargo					int not null primary key,
	Descripcion				varchar(45) not null,
	Sueldo					numeric(10,2) not null,
	IdEstado				int not null,

)
go

/*CARGOxDEPARTAMENTO*/
create table RecursosHumanos.CargoxDepartamento
(
	IdDepartamento			int not null,
	IdCargo					int not null,
	FechaCreacion			date not null,
	FechaModificacion		datetime null,
	IdEstado				int not null,
	primary key (idCargo,idDepartamento),
	foreign key (IdCargo) references RecursosHumanos.Cargo,

	foreign key (IdDepartamento) references RecursosHumanos.Departamento
)
go

/*RUBRO*/
create table RecursosHumanos.Rubro
(
	IdRubro					int not null primary key,
	Descripcion				varchar(45) not null,
	Porcentaje				float not null,
	IdEstado				int not null,
	IdEmpresa				int not null,
	IdCargo					int not null,
	IdDepartamento			int not null,
	foreign key (IdCargo,IdDepartamento) references RecursosHumanos.CargoxDepartamento,

	foreign key (IdEmpresa) references Seguridad.Empresa
)
go

/*PERSONAxTITULO*/
create table RecursosHumanos.PersonaxTitulo
(
	IdTitulo				int not null,
	IdEmpresa				int not null,
	IdPersona				int not null,
	IdEstado				int not null,

	primary key (idpersona,idtitulo),

	foreign key (IdTitulo) references RecursosHumanos.Titulo,
	foreign key (IdEmpresa) references Seguridad.Empresa,
	foreign key (IdPersona) references RecursosHumanos.Persona
)
go

/*ACADEMICO*/
create table RecursosHumanos.Academico
(
	IdAcademico				int not null,
	IdPersona				int not null,
	IdTitulo				int not null,
	IdEmpresa				int not null,
	IdUniversidad			int not null,
	IdEstado				int not null,
	primary key (IdAcademico),
	foreign key (IdPersona) references RecursosHumanos.Persona,
	foreign key (IdTitulo) references RecursosHumanos.Titulo,
	foreign key (IdEmpresa) references Seguridad.Empresa,
	foreign key (IdUniversidad) references RecursosHumanos.Universidad,
)
go


/*PERSONAxCARGO*/
create table RecursosHumanos.PersonaxCargo
(
	IdPersona				int not null,
	IdEmpresa				int not null,
	IdCargo					int not null,
	FechaIngreso			datetime not null,
	FechaModificacion		datetime null,
	IdEstado				int not null,
	primary key (idPersona,IdCargo),
	foreign key (IdPersona) references RecursosHumanos.Persona,
	foreign key (IdEmpresa) references Seguridad.Empresa,
	foreign key (Idcargo) references RecursosHumanos.Cargo
)
go

/*PARENTESCO*/
create  table RecursosHumanos.Parentesco
(
	IdParentesco			int not null primary key,
	Descripcion				varchar(50) not null,
	IdEmpresa				int not null,
	IdEstado				int not null,

	foreign key (IdEmpresa) references Seguridad.Empresa
)
go

/*CARGA FAMILIAR*/
create table RecursosHumanos.CargaFamiliar
(
	IdPersona				int not null,
	IdParentesco			int not null,
	IdEmpresa				int not null,
	FechaNacimiento			date not null,
	FechaRegistro			date not null,
	FechaModificacion		datetime,
	IdEstado				int not null,
	primary key (idpersona,idparentesco),

	foreign key (IdEmpresa) references Seguridad.Empresa,
	foreign key (IdPersona) references RecursosHumanos.Persona,
	foreign key (IdParentesco) references RecursosHumanos.Parentesco
)
go

/*ANTICIPO CABECERA*/
create table RecursosHumanos.AnticipoCab
(
	NumAnticipo				int not null,
	IdEmpleado				int not null,
	Fecha					date not null,
	FechaModificacion		datetime,
	Total					numeric(10,2) not null,
	Observacion				varchar(50) null,
	IdEmpresa				int not null,
	IdEstado				int not null,
	foreign key (IdEmpleado) references RecursosHumanos.Persona,
	foreign key (IdEmpresa) references Seguridad.Empresa,

	primary key (NumAnticipo, IdEmpresa)
)
go

/*ANTICIPO DETALLE*/
create table RecursosHumanos.AnticipoDet
(
	NumLinea				int not null,
	NumAnticipo				int not null,
	FechaCobro				date not null,
	FechaModificacion		datetime,
	IdEmpresa int not null references Seguridad.Empresa,
	foreign key (NumAnticipo, IdEmpresa) references RecursosHumanos.AnticipoCab,
	primary key (NumLinea,IdEmpresa)
)
go

/*BENEFICIOS*/
create table RecursosHumanos.Beneficios
(
	IdBeneficios			int primary key,
	Descripcion				varchar(50) not null,
	Porcentaje				numeric(10,2) not null,
	IdEmpresa				int not null,
	foreign key (IdEmpresa)references Seguridad.Empresa
)
go

/*NOMINA CABECERA*/
create table RecursosHumanos.NominaCab
(
	NumNomina				int not null,
	Fecha					date not null,
	FechaModificacion		datetime,
	Periodo					int not null,
	Total					money not null,
	IdEstado				int not null,
	IdEmpresa				int not null,
	Observacion				varchar(50) null,
	
	foreign key (IdEmpresa) references Seguridad.Empresa,
	primary key (NumNomina,IdEmpresa)
)
go

/*NOMINA DETALLE*/
create table RecursosHumanos.NominaDet
(
	NumLinea				int not null,
	NumNomina				int not null,
	IdPersona				int not null,
	SueldoNominal			money not null,
	SueldoGanado			money not null,
	Iess					money not null,
	Prestamo				money null,
	Anticipo				money null,
	ValorLiquido			money not null,
	IdEmpresa				int not null,
	foreign key (NumNomina,IdEmpresa)references RecursosHumanos.NominaCab,
	primary key (NumLinea)
)
go

/*TIPO CONTRATO*/
create table RecursosHumanos.TipoContrato
(
	IdTipoContrato			int not null primary key,
	Descripcion				varchar(50) not null,
	Periodo					varchar(50) not null,
	IdEmpresa				int not null,
	IdEstado				int not null,


	foreign key (IdEmpresa) references Seguridad.Empresa
)
go

/*CONTRATO*/
create table RecursosHumanos.Contrato
(
	NumContrato				int not null,
	IdPersona				int not null,
	IdTipoContrato			int not null,
	IdCargo					int not null,
	IdEmpresa				int not null,
	Fecha					datetime not null,
	FechaModificacion		datetime,
	Remuneracion			numeric(10,2) not null,
	IdJornada				int not null,
	PeriodoPrueba			bit not null,
	Discapacidad			bit,
	grado					int,
	TipoDiscapacidad		int,
	Carnet					numeric(29,0),
	IdEstado				int not null,

	primary key (IdPersona,NumContrato,idEmpresa),

	foreign key (IdEmpresa) references Seguridad.Empresa,
	foreign key (IdPersona) references RecursosHumanos.Persona,
	foreign key (IdTipoContrato) references RecursosHumanos.TipoContrato,
	foreign key (IdCargo) references RecursosHumanos.Cargo,
	foreign key (IdJornada) references RecursosHumanos.Jornada
)
go

/*TIPO PERMISO*/
create table RecursosHumanos.TipoPermiso
(
	IdTipoPermiso			int not null primary key,
	Descripcion				varchar(50) not null,
	IdEmpresa				int not null,
	IdEstado				int not null,

	foreign key (IdEmpresa) references Seguridad.Empresa
)
go

/*PERMISO*/
create table RecursosHumanos.Permiso
(
	NumPermiso				int primary key,
	IdUsuario				int not null,
	IdEmpleado				int not null,
	IdTipoPermiso			int not null,
	FechaInicio				datetime not null,
	FechaFinal				datetime not null,
	FechaModificacion		datetime,
	IdEstado				int not null,
	IdEmpresa				int not null,
	foreign key (IdUsuario) references Seguridad.Usuario,
	foreign key (IdEmpleado) references RecursosHumanos.Persona,
	foreign key (IdTipoPermiso) references RecursosHumanos.TipoPermiso,

	foreign key (IdEmpresa) references Seguridad.Empresa
)
go

/*LIQUIDACION*/
create table RecursosHumanos.Liquidacion
(
	NumLiquidacion			int not null,
	IdPersona				int not null,
	NumContrato				int not null,
	IdEmpresa				int not null,
	Fecha					datetime not null,
	FechaModificacion		datetime,
	Causa					varchar(150) not null,
	FechaSalida				datetime not null,
	Ingresos				numeric(10,2) not null,
	Egresos					numeric(10,2) not null,
	Total					numeric(10,2) not null,
	IdEstado				int not null,
	primary key (NumLiquidacion,IdEmpresa,Idpersona),
	foreign key (IdPersona,NumContrato,IdEmpresa) references RecursosHumanos.Contrato,

	foreign key (IdPersona) references RecursosHumanos.persona,
	foreign key (IdEmpresa) references Seguridad.Empresa,
)
go

/*VACACION*/
create table RecursosHumanos.Vacacion
(
	NumVacacion				int not null primary key,
	IdEmpleado				int not null,
	FechaModificacion		datetime,
	FechaInicio				date not null,
	FechaFin				date not null,
	IdEmpresa				int not null,
	IdEstado				int not null,
	foreign key (IdEmpleado) references RecursosHumanos.Persona,
	foreign key (IdEmpresa) references Seguridad.Empresa,

)
go

/*TIPO PRESTAMO*/
create table RecursosHumanos.TipoPrestamo
(
	IdTipoPrestamo 			int not null primary key,
	Nombre					varchar(50) not null,
	IdEmpresa 				int not null,
	IdEstado 				int not null,

	foreign key (IdEmpresa) references Seguridad.Empresa
)
go

/*PRESTAMO*/
create table RecursosHumanos.Prestamo
(
	IdPrestamo 				int not null primary key,
	IdTipoPrestamo 			int not null,
	IdPersona 				int not null,
	FechaModificacion		datetime,
	Monto					money not null,
	Pago					money not null,
	IdEstado 				int not null,
	IdEmpresa 				int not null,
	foreign key (IdPersona) references RecursosHumanos.Persona,
	foreign key (IdEmpresa) references Seguridad.Empresa,

	foreign key (IdTipoPrestamo) references RecursosHumanos.TipoPrestamo,
)
go

/*TRABAJO DIARIO CABECERA*/
create table RecursosHumanos.TrabajoDiarioCab
(
	NumTrabajo				int not null,
	Fecha					datetime not null,
	IdEstado				int not null,
	IdEmpresa				int not null,
	Observacion				varchar(50) null,
	
	foreign key (IdEmpresa) references Seguridad.Empresa,
	primary key (NumTrabajo, IdEmpresa)
)
go

/*TRABAJO DIARIO DETALLE*/
create table RecursosHumanos.TrabajoDiarioDet
(
	NumLinea				int not null,
	NumTrabajo				int not null,
	IdPersona				int not null,
	HoraEntrada				varchar(50) not null,
	HoraSalida				varchar(50) not null,
	HoraTrabajada			int not null,
	HoraExtraM				int null,
	HoraExtraT				int null,
	HoraRango				int not null,
	IdEmpresa				int not null
	foreign key (IdPersona) references RecursosHumanos.Persona,
	foreign key (NumTrabajo,IdEmpresa)references RecursosHumanos.TrabajoDiarioCab,
	primary key (NumLinea, IdEmpresa)
)
go

/****************************SEGURIDAD****************************/
/*USUARIO POR EMPRESA*/
create table Seguridad.UsuarioPorEmpresa
(
	IdUsuario		int,
	IdEmpresa		int,
	Descripcion     varchar(1),
	foreign key(IdUsuario)references Seguridad.Usuario on delete cascade,
	foreign key(IdEmpresa)references Seguridad.Empresa,
	primary key(IdUsuario,IdEmpresa)
)
go


/*MODULO*/
create table  Seguridad.Modulo
(
	 IdModulo		int				primary key,
	 Nombre			varchar(50),
	 IdEstado		int				references Seguridad.Estado on delete cascade,
	 Logo			varchar(50)
) 
go

/*MENU*/
create table  Seguridad.Menu 
(
	 IdMenu				int					primary key,
	 IdModulo			int					references Seguridad.Modulo on delete cascade,
	 IdPadre			int					references Seguridad.Menu,
	 Descripcion		varchar (255),
	 NombreFormulario	varchar (255), 
	 NombreAssembly		varchar (200), 
	 IdEstado			int					references Seguridad.Estado,
)
go

/*MENU POR EMPRESA*/
--create table Seguridad.MenuPorEmpresa
--(
--	 IdEmpresa					int				references Seguridad.Empresa on delete cascade,
--	 IdMenu						int				references Seguridad.Menu,
--	 NombreAsamblyPorEmpresa    varchar  (200),
--	 NomFormularioPorEmpresa    varchar  (200), 
--	 IdEstado					int				references Seguridad.Estado,
--	 primary key(IdMenu,IdEmpresa)
--)
--go

create table Seguridad.Horario
(
	IdHorario					int,
	IdPerfil					int				references Seguridad.Perfil on delete cascade,
	Secuencia					int ,
	dia	varchar(10),
	H00	bit	not null,
	H01	bit	not null,
	H02	bit	not null,
	H03	bit	not null,
	H04	bit	not null,
	H05	bit	not null,
	H06	bit	not null,
	H07	bit	not null,
	H08	bit	not null,
	H09	bit	not null,
	H10	bit	not null,
	H11	bit	not null,
	H12	bit	not null,
	H13	bit	not null,
	H14	bit	not null,
	H15	bit	not null,
	H16	bit	not null,
	H17	bit	not null,
	H18	bit	not null,
	H19	bit	not null,
	H20	bit	not null,
	H21	bit	not null,
	H22	bit	not null,
	H23	bit	not null,
	primary key (IdHorario,IdPerfil,Secuencia)
)
go

/*PERMISO*/
create table Seguridad.Permiso
(
	 IdPerfil		int				references Seguridad.Perfil on delete cascade,
	 IdPermiso		int, 
	 IdMenu			int				references Seguridad.Menu,
	 IdModulo		int				references Seguridad.Modulo,
	 Lectura		bit				not null,
	 Escritura		bit				not null,
	 Eliminacion    bit				not null,
	 primary key (IdPerfil,IdPermiso)
)
go


/*TELEFONO POR EMPRESA*/
create table  Seguridad.TelefonoEmpresa --E editada agregado
(
	IdEmpresa		int references Seguridad.Empresa on delete cascade,
	IdTelefono		int references RecursosHumanos.Telefono on delete cascade,
	primary key (IdEmpresa,IdTelefono)
) 
go

/*************************************contabilidad***********************************/
create table Contabilidad.TipoCuenta
(
	IdTipoCuenta			numeric(2,0) primary key,
	nombre					varchar(20) not null
)
go
/*tabla de seguridad*/

create table Contabilidad.AnoFiscal
(
	IdAnoFiscal				numeric(4) primary key,
	inicio_periodo			date not null,
	IdUsuario 				int,
	FechaModificacion		datetime, 
)
go

create table Contabilidad.NivelCuenta
(
	IdNivelCuenta			numeric(2,0) primary key,
	descripcion				varchar(20),
	digitos					numeric(1) not null,
	IdEstado 				int not null references Seguridad.Estado
)
go

create table Contabilidad.PeriodoContable
(
	IdEmpresa 				int references Seguridad.Empresa,
	IdPeriodoContable		numeric(6),
	IdAFiscal				numeric(4) references Contabilidad.AnoFiscal,
	FechaInicio				date not null,
	FechaFin				date not null,
	IdEstado 				int not null references Seguridad.Estado,
	IdUsuario 				int not null references Seguridad.Usuario,
	FechaModificacion		datetime, 
	PRIMARY KEY(IdEmpresa,IdPeriodoContable,IdAFiscal)
)
go

create table Contabilidad.Cuenta
(
	IdEmpresa 				int references Seguridad.Empresa,
	IdCuenta				varchar(50),
	codigo_padre			varchar(50), --E codigo_padre
	nombre					varchar(50) not null,
	descripcion				varchar(80) not null,
	IdNivelCuenta			numeric(2,0)not null references Contabilidad.NivelCuenta,
	IdTipoCuenta			numeric(2,0) not null references Contabilidad.TipoCuenta,
	naturaleza_cuenta		varchar(50) not null,
	IdUsuario 				int not null references Seguridad.Usuario, 
	FechaModificacion		datetime, 
	PRIMARY KEY(IdEmpresa, IdCuenta)
)
go

create table Contabilidad.CabeceraComprobante
(
	IdEmpresa 				int ,
	numero_comprobante		numeric(4) ,
	fecha					date not null,
	glosa					varchar(50) not null,
	periodo_contable		numeric(6,0) ,
	periodo_contable_IdAFiscal numeric(4,0),
	IdUsuario 				int,
	FechaModificacion		datetime, 
	primary key(IdEmpresa, numero_comprobante),
	foreign key(IdEmpresa,periodo_contable,periodo_contable_IdAFiscal) references Contabilidad.PeriodoContable,
	foreign key(IdEmpresa) references Seguridad.Empresa
)
go

create table Contabilidad.DetalleComprobante
(
	IdEmpresa 				int,
	cabecera_comprobante	numeric (4),
	linea_comprobante		numeric(2,0) not null,
	cuenta					varchar(50) not null,
	debe					decimal(14,2) not null,
	haber					decimal(14,2) not null,
	foreign key (IdEmpresa)references Seguridad.Empresa,
	foreign key (IdEmpresa,cuenta)references Contabilidad.Cuenta,
	foreign key (IdEmpresa,cabecera_comprobante)references Contabilidad.CabeceraComprobante,
	primary key (IdEmpresa,cabecera_comprobante, linea_comprobante)
)
go

create table Contabilidad.Saldo
(
	IdEmpresa 				int,
	cuenta varchar(50) not null,
	fecha date,
	saldo_deudor decimal(14,2) not null,
	saldo_acreedor decimal(14,2) not null,
	IdUsuario 				int,
	FechaModificacion datetime,
	foreign key (IdEmpresa)references Seguridad.Empresa,
	foreign key (IdEmpresa,cuenta)references Contabilidad.Cuenta,
	primary key (IdEmpresa,cuenta,fecha)
)
go

--modulo no es tabla de contabilidad segun la ruth

create table Contabilidad.TipoTransaccion
(
	IdTransaccion 			int primary key,
	modulo 					int references Seguridad.Modulo not null,
	TipoDocumento			varchar(50),
	descripcion				varchar(50) not null
)
go

create table Contabilidad.ModeloAsiento
(
	IdEmpresa 				int references Seguridad.Empresa,
	modulo					int references Seguridad.Modulo,
	IdTransaccion 			int references Contabilidad.TipoTransaccion,
	secuencia				int , 
	descripcion				varchar(50) not null,
	debe					varchar(50),
	haber					varchar(50),
	IdUsuario 				int,
	FechaModificacion		datetime, 
	PRIMARY KEY(IdEmpresa,secuencia,IdTransaccion)
	
)
go

--Inventario 


create table Inventario.TipoArticulo
(
IdEmpresa	int,
IdTipoArticulo	int not null,
Descripcion	varchar(500)not null,
IdEstado	int,
primary key (IdTipoArticulo),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
)
go

create table Inventario.Grupo
(
IdEmpresa	int,
IdGrupo	int not null,
Descripcion	varchar(100) not null,
IdTipoArticulo int,
IdEstado	int,
primary key (IdGrupo),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdTipoArticulo) references Inventario.TipoArticulo,
foreign key (IdEstado) references Seguridad.Estado,
)
go

/********************Tabla de ActivoFijo***************************/
create table ActivoFijo.SubGrupos
(
	IdSubGrupo			int not null,
	IdGrupo			    int   null,
	Descripcion			varchar(100)  null,
	fecha				date   null,
	IdEstado			int   null,
	EstadoProceso	    varchar(30)   null,--Es para identificar si esta anulado o no el proceso
	IdEmpresa			int   null,
	primary key (IdSubGrupo),
	foreign key (IdGrupo)  references Inventario.Grupo,
	foreign key (IdEmpresa) references Seguridad.Empresa,
	foreign key (IdEstado) references Seguridad.Estado
)
go


/***********************Tabla de compras********************************/
create table Compras.Proveedor
(
IdProveedor			int not null primary key,
IdEmpresa			int not null,
IdPersona			int not null,
IdTipoArticulo		int not null,
Estado				int not null,
foreign key (IdPersona)references RecursosHumanos.Persona,
foreign key (IdEmpresa)references Seguridad.Empresa,
foreign key (IdTipoArticulo)references Inventario.TipoArticulo,
foreign key (Estado) references Seguridad.Estado
)
go

/*para integrar compras con inventario*/
CREATE TABLE Compras.Cotizacion --100%
(
Numero				int NOT NULL,
idEmpresa			int NOT NULL,
IdUsuario			int NOT NULL,
idProveedor			int NOT NULL,
--NumeroPedido		int NOT NULL,
Fecha				date NOT NULL Default Getdate(),
FechaModificacion	date NOT NULL Default Getdate(),
Ruta				varchar (250),
idEstado			int NOT NULL,
foreign key(IdEmpresa)references Seguridad.Empresa,
foreign key(IdUsuario)references Seguridad.Usuario,
foreign key (idProveedor) references Compras.Proveedor,
foreign key (IdEstado) references Compras.Estado,
--foreign key (NumeroPedido) references Compras.Pedido,
primary key(Numero,IdEmpresa)
)
 GO

CREATE TABLE Compras.OrdenCompra  --ok
(
	IdOrdenCompra		int		NOT NULL,
	idEmpresa			int		NOT NULL,
    IdUsuario			int		NOT NULL,
	Fecha				date	NOT NULL Default Getdate(),
    FechaModificacion	date    NOT NULL Default Getdate(),
	idProveedor			int		NOT NULL,
    NumeroCotizacion    int		NOT NULL,
	idEstado			int     NOT NULL,
	Observaciones		varchar   (300),
	foreign key(IdEmpresa)references Seguridad.Empresa,
    foreign key(IdUsuario)references Seguridad.Usuario,
	foreign key (IdEstado) references Compras.Estado,
	foreign key(idProveedor)references Compras.Proveedor,
	foreign key (NumeroCotizacion, idEmpresa) references Compras.Cotizacion,
	primary key(IdOrdenCompra,IdEmpresa)
)
GO

CREATE TABLE Compras.Compra  --ok
(
	Numero				int		NOT NULL,
	idEmpresa			int		NOT NULL,
    IdUsuario			int		NOT NULL,
    idOrdenCompra		int		not null,
	Fecha				date	NOT NULL Default Getdate(),
    FechaModificacion	date    NOT NULL Default Getdate(),
	idEstado			int     NOT NULL,
	foreign key(IdEmpresa)references Seguridad.Empresa,
    foreign key(IdUsuario)references Seguridad.Usuario,
	foreign key (IdEstado) references Compras.Estado,
	foreign key (idEmpresa,idOrdenCompra) references Compras.OrdenCompra,
	primary key(Numero,IdEmpresa)
)
GO

Create Table Compras.CompraDet
(
	Numero		int		Not null,
	idEmpresa	int		not null,
	Linea		int		not null,
	idArticulo	int		not null,
	Cantidad	int		not null,
	foreign key(Numero,IdEmpresa)references Compras.Compra,
	primary key(Numero,IdEmpresa, Linea)
)
go
/********************************INVENTARIO************************/

create table Inventario.Bodega
(
IdEmpresa	int not null,
IdBodega	int not null,
Decripcion	varchar(100),
Capacidadm2	int,
IdResponsable	int,
IdPercha	int,
Direccion	varchar(100),
Telefono varchar(15),
IdEstado	int,
primary key (IdBodega, IdEmpresa),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdResponsable) references RecursosHumanos.Persona,
foreign key (IdEstado) references Seguridad.Estado,
)
go


 
 
create table Inventario.UnidadMedida
(
IdEmpresa	int,
IdUnidadMedida	int not null,
Descripcion	varchar(100) not null,
IdEstado	int,
primary key (IdUnidadMedida),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
)
go



create table Inventario.Chasis
(
IdEmpresa	int,
IdChasis	int not null,
Descripcion	varchar(100) not null,
IdEstado	int,
primary key (IdChasis),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
)
go

create table Inventario.TipoMotor
(
IdEmpresa	int,
IdTipoMotor	int not null,
Descripcion	varchar(100),
IdEstado	int,
primary key (IdTipoMotor),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
)
go

create table Inventario.TipoCombustible
(
IdEmpresa	int,
IdTipoCombustible	int not null,
Descripcion	varchar(100),
IdEstado	int,
primary key (IdTipoCombustible),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
)
go

create table Inventario.Color
(
IdEmpresa	int,
IdColor	int not null,
Descripcion	varchar(100) not null,
IdEstado	int,
primary key (IdColor),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
)
go


create table Inventario.Marca
(
IdEmpresa	int,
IdMarca	int not null,
Descripcion	varchar(100) not null,
IdEstado	int,
primary key (IdMarca),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
)
go

create table Inventario.Modelo
(
IdEmpresa	int,
IdModelo	int not null,
Descripcion	varchar(100) not null,
IdMarca int,
IdEstado	int,
primary key (IdModelo),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdMarca) references Inventario.Marca,
)
go

create table Inventario.TipoMaterial
(
IdEmpresa	int,
IdTipoMaterial	int not null,
Descripcion	varchar(100),
IdEstado	int,
primary key (IdTipoMaterial),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
)
go

create table Inventario.Articulo
(
IdEmpresa	int,
IdArticulo	int not null,
Descripcion	varchar(100) not null,
FechaProduccion date,
CantidadMinima	numeric(5,0),
CantidadMaxima	numeric(5,0),
CantidadActual	numeric(5,0),
IdUnidadMedida	int,
FechaCaducidad	date,
IdTipoArticulo	int not null,
IdGrupo	int not null,
--IdSubgrupo int,
IdChasis	int,
SerieChasis varchar(17),
IdTipoMotor	int,
SerieMotor varchar(11),
NroPlaca	varchar(8),
IdTipoCombustible int,
IdColor	int,
IdMarca	int,
IdModelo	int,
IdTipoMaterial	int,
Observacion	varchar(100),
IdEstado	int,
primary key (IdArticulo, IdEmpresa),
foreign key(IdEstado)references Seguridad.Estado,
foreign key(IdEmpresa)references Seguridad.Empresa,
foreign key(IdUnidadMedida)references Inventario.UnidadMedida,
foreign key (IdTipoArticulo)references Inventario.TipoArticulo,
foreign key (IdGrupo)references Inventario.Grupo,
foreign key (IdChasis)references Inventario.Chasis,
foreign key (IdTipoMotor)references Inventario.TipoMotor,
foreign key (IdTipoCombustible)references Inventario.TipoCombustible,
foreign key (IdColor)references Inventario.Color,
foreign key (IdMarca)references Inventario.Marca,
foreign key (IdModelo)references Inventario.Modelo,
foreign key (IdTipoMaterial)references Inventario.TipoMaterial,
)
go



create table Inventario.Percha
(
IdEmpresa	int not null,
IdPercha	int not null,
Descripcion varchar(10),
Nro_Divisiones	numeric(10,0) not null,
IdBodega	int not null,
IdEstado	int,
primary key (IdPercha),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdBodega, IdEmpresa) references Inventario.Bodega,
foreign key (IdEstado) references Seguridad.Estado,
)
go

create table Inventario.Motivo
(
IdEmpresa	int,
IdMotivo	int not null,
Descripcion	varchar(100) not null,
IdEstado	int,
primary key (IdMotivo),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
)
go

create table Inventario.TransferenciaBodegaCab
(
IdEmpresa	int,
NroTransferencia	int not null,
FechaTransferencia	date,
FechaModificacion datetime,
IdBodegaOrigen	int,
IdBodegaDestino	int,
IdMotivo	int,
Observacion	varchar(150),
IdUsuario	int,
IdEstado	int,
Fecha datetime,
primary key (NroTransferencia),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdBodegaOrigen, IdEmpresa) references Inventario.Bodega,
foreign key (IdBodegaDestino, IdEmpresa) references Inventario.Bodega,
foreign key (IdMotivo) references Inventario.Motivo,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdUsuario) references Seguridad.Usuario,
)
go

create table Inventario.TransferenciaBodegaDet
(
IdEmpresa	int,
NroTransferencia	int not null,
CantidadTrasladada	int,
Articulo	numeric(10,0),
IdEstado	int,
primary key(NroTransferencia),
foreign key(NroTransferencia) references Inventario.TransferenciaBodegaCab,
foreign key (IdEstado) references Seguridad.Estado,
)
go

create table Inventario.TomaFisicaCab
(
IdEmpresa	int,
NroTomaFisica	int not null,
IdMotivo	int,
FechaTomaFisica	date,
FechaModificacion datetime,
Usuario	numeric(10,0),
IdTipoArticulo	int,
IdBodega	int,
IdUsuario	int,
Auditor	varchar(50),
Observacion	varchar(150),
IdEstado	int,
primary key (NroTomaFisica),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key(IdMotivo) references Inventario.Motivo,
foreign key(IdTipoArticulo) references Inventario.TipoArticulo,
foreign key(IdBodega, IdEmpresa) references Inventario.Bodega,
foreign key (IdUsuario) references Seguridad.Usuario,
foreign key (IdEstado) references Seguridad.Estado,
)
go


create table Inventario.TomaFisicaDet
(
IdEmpresa	int,
NroTomaFisica	int not null,
IdArticulo	int,
ExistenciaSistema	int,
ExistenciaFisica	int,
CantidadAjustada	int,
FechaAjuste	date,
primary key (NroTomaFisica),
foreign key(IdEmpresa) references Seguridad.Empresa,
foreign key(IdArticulo, IdEmpresa) references Inventario.Articulo,
)
go

create table Inventario.TipoMovimiento
(
IdEmpresa	int,
IdTipoMovimiento	int,
Descripcion	varchar(25),
IdEstado	int,
primary key (IdTipoMovimiento),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
)
go


create table Inventario.ArticuloBodega
(
IdEmpresa	int,
IdArticuloBodega	int,
IdArticulo	int,
IdPercha	int,
Cantidad	int,
--Fecha datetime,
primary key	(IdArticuloBodega),
foreign key(IdEmpresa) references Seguridad.Empresa,
foreign key (IdArticulo, IdEmpresa) references Inventario.Articulo,
foreign key (IdPercha) references Inventario.Percha,
)
go

/************************MODULO DE FACTURACION INTEGRACION********************/
CREATE TABLE Facturacion.FormaPago
(
IdEmpresa int NOT NULL,
idUsuario int NOT NULL,
IdFormaPago int NOT NULL,
Descripcion varchar (250) NULL,
idEstado int NOT NULL,
primary key(IdFormaPago),	
foreign key (idEmpresa) references Seguridad.Empresa,
foreign key (idUsuario) references Seguridad.Usuario,
foreign key (idEstado) references Seguridad.Estado
)
GO

CREATE TABLE Facturacion.ClienteDefactura
(
IdEmpresa int NOT NULL,
idUsuario int NOT NULL,
IdNumeroCliente int NOT NULL,
Identificacion int NOT NULL,
Fecha	date NOT NULL,
NombreRazonSocial varchar(50) NOT NULL,
Apellido varchar(50) NULL,
FechaNacimiento date NULL,
Genero varchar(10) NULL,
Direccion varchar(100) NOT NULL,
Telefono int NOT NULL,
Celular int NOT NULL,
CorreoElectronico varchar(50) NULL,
idEstado int NOT NULL,
primary key(IdNumeroCliente),	
foreign key (idEmpresa) references Seguridad.Empresa,
foreign key (idUsuario) references Seguridad.Usuario,
foreign key (idEstado) references Seguridad.Estado
)
GO

CREATE TABLE Facturacion.Cotizacion
(
IdEmpresa int NOT NULL,
idUsuario int NOT NULL,
IdNumeroCotizacion int NOT NULL,
IdFormaPago int NOT NULL,/*Desvinculada de CXP.FormaPago*/
IdNumeroCliente int NOT NULL,
Fecha	date NULL,
PorcentajeEntrada	money NULL,
ValorEntrada	money NULL,
EntradaMinimaRequerida	money NULL,
ValorCancelar	money NULL,
FechaInicialPago	date NULL,
FechaFinalPago	date NULL,
Seguro	bit NULL,
idEstado int NOT NULL,
primary key(IdNumeroCotizacion),	
foreign key (IdNumeroCliente) references Facturacion.ClienteDeFactura,
foreign key (IdFormaPago) references Facturacion.FormaPago,
foreign key (idEmpresa) references Seguridad.Empresa,
foreign key (idUsuario) references Seguridad.Usuario,
foreign key (idEstado) references Seguridad.Estado
)
GO

CREATE TABLE Facturacion.Promocion
(
IdEmpresa int NOT NULL,
idUsuario int NOT NULL,
IdPromocion int NOT NULL,
descripcion	varchar(50),
FechaInicio	date NULL,
FechaFin	date NULL,
tipoPromocion	varchar(50) NULL,
pordescuento	decimal(18, 2) NULL,
idEstado int NOT NULL,
primary key(IdPromocion),
foreign key (idEmpresa) references Seguridad.Empresa,
foreign key (idUsuario) references Seguridad.Usuario,
foreign key (idEstado) references Seguridad.Estado
)
GO

CREATE TABLE Facturacion.PorcentajeComision
(
IdEmpresa int NOT NULL,
idUsuario int NOT NULL,
IdNumeroPorcComision int NOT NULL,
Fecha	date NULL,
descripcion	varchar(100) NULL,
IdFormaPago int NOT NULL,/*Desvinculada de CXP.FormaPago*/
Porcentaje	money NULL,
MontoVenta	money NULL,
idEstado int NOT NULL,
primary key(IdNumeroPorcComision),
foreign key (IdFormaPago) references Facturacion.FormaPago,
foreign key (idEmpresa) references Seguridad.Empresa,
foreign key (idUsuario) references Seguridad.Usuario,
foreign key (idEstado) references Seguridad.Estado
)
GO


CREATE TABLE Facturacion.GuiaRemision
(
IdEmpresa int NOT NULL,
idUsuario int NOT NULL,
IdNumeroGuiaRemision int NOT NULL,
FechaEmision	date NULL,
SitioSalida	varchar(50) NULL,
Sitiollegada	varchar(50) NULL,
FechaTraslado	date NULL,
IdPesonaNatural int NOT NULL,
idEstado int NOT NULL,
primary key(IdNumeroGuiaRemision),
foreign key (IdPesonaNatural) references RecursosHumanos.Persona,
foreign key (idEmpresa) references Seguridad.Empresa,
foreign key (idUsuario) references Seguridad.Usuario,
foreign key (idEstado) references Seguridad.Estado
)
GO

CREATE TABLE Facturacion.Factura
(
IdEmpresa int NOT NULL,
cabecera_comprobante	numeric (4),
idUsuario int NOT NULL,
IdNumeroFactura int NOT NULL,
IdNumeroCotizacion int NULL,
IdPromocion int NULL,
IdFormaPago int NOT NULL,/*Desvinculada de CXP.FormaPago*/
IdNumeroCliente int NULL,
Fecha	date NULL,
ValorEntrada	money NULL,
NumeroCuotaMensual int NULL,
Subtotal money NULL,
Iva money NULL,
Ice money NULL,
Descuento money NULL,
TotalPagar	money NULL,
idEstado int NOT NULL,
primary key(IdNumeroFactura),
foreign key (IdFormaPago) references Facturacion.FormaPago,	
foreign key (IdEmpresa,cabecera_comprobante)references Contabilidad.CabeceraComprobante,
foreign key (IdNumeroCliente) references Facturacion.ClienteDeFactura,
foreign key (IdNumeroCotizacion) references Facturacion.Cotizacion,
foreign key (IdPromocion) references Facturacion.Promocion,	
foreign key (idUsuario) references Seguridad.Usuario,
foreign key (idEstado) references Seguridad.Estado
)
GO

CREATE TABLE Facturacion.Comision
(
IdEmpresa int NOT NULL,
cabecera_comprobante	numeric (4),
idUsuario int NOT NULL,
IdNumeroComision int NOT NULL,
FechaInicial	date NULL,
FechaFinal	date NULL,
IdNumeroPorcComision int NOT NULL,
MontoVenta	money NULL,
idEstado int NOT NULL,
primary key(IdNumeroComision),
foreign key (IdNumeroPorcComision) references Facturacion.PorcentajeComision,
foreign key (IdEmpresa,cabecera_comprobante)references Contabilidad.CabeceraComprobante,	
foreign key (idUsuario) references Seguridad.Usuario,
foreign key (idEstado) references Seguridad.Estado
)
GO

CREATE TABLE Facturacion.CotizacionDet
(
IdEmpresa int NOT NULL,
idUsuario int NOT NULL,
Linea int NOT NULL,
IdNumeroCotizacion int NOT NULL,
IdArticulo int NULL,
CuotaMensual int NULL,
Interes	money NULL,
FechaPago	date NULL,
FechaMaximaPago	date NULL,
precio money NULL,
cantidad int NULL,
idEstado	int NOT NULL,
primary key(Linea,IdNumeroCotizacion),
foreign key (IdNumeroCotizacion) references Facturacion.Cotizacion,
foreign key(IdArticulo, IdEmpresa) references Inventario.Articulo,	
foreign key (idUsuario) references Seguridad.Usuario,
foreign key (idEstado) references Seguridad.Estado
)
GO

CREATE TABLE Facturacion.ComisionDet
(
IdEmpresa int NOT NULL,
idUsuario int NOT NULL,
Linea int NOT NULL,
IdNumeroComision int NOT NULL,
idEmpleado int NULL,
IdNumeroFactura int NULL,
MontoComision	money NULL,
FechaPago	date NULL,
idEstado int NOT NULL,
primary key(Linea,IdNumeroComision),
foreign key (IdNumeroComision) references Facturacion.Comision,
foreign key (IdNumeroFactura) references Facturacion.Factura,	
foreign key (IdEmpleado,idempresa) references RecursosHumanos.Empleado,
foreign key (idEmpresa) references Seguridad.Empresa,
foreign key (idUsuario) references Seguridad.Usuario,
foreign key (idEstado) references Seguridad.Estado
)
GO

CREATE TABLE Facturacion.DevolucionVenta
(
IdEmpresa int NOT NULL,
cabecera_comprobante	numeric (4),
idUsuario int NOT NULL,
IdNumeroDevolucion int NOT NULL,
IdNumeroFactura int NULL,
Fecha	date NULL,
idEstado int NOT NULL,
primary key(IdNumeroDevolucion),
foreign key (IdNumeroFactura) references Facturacion.Factura,	
foreign key (IdEmpresa,cabecera_comprobante)references Contabilidad.CabeceraComprobante,	
foreign key (idUsuario) references Seguridad.Usuario,
foreign key (idEstado) references Seguridad.Estado
)
GO

CREATE TABLE Facturacion.GuiaRemisionDet
(
IdEmpresa int NOT NULL,
idUsuario int NOT NULL,
Linea int NOT NULL,
IdNumeroGuiaRemision int NOT NULL,
IdNumeroFactura int NULL,
FechaEntrega	date NULL,
idEstado int NOT NULL,
primary key(Linea,IdNumeroGuiaRemision),
foreign key (IdNumeroFactura) references Facturacion.Factura,	
foreign key (idEmpresa) references Seguridad.Empresa,
foreign key (idUsuario) references Seguridad.Usuario,
foreign key (idEstado) references Seguridad.Estado
)
GO

CREATE TABLE Facturacion.FacturaDet
(
IdEmpresa int NOT NULL,
idUsuario int NOT NULL,
Linea int NOT NULL,
IdNumeroFactura int NOT NULL,
IdArticulo int NULL,
CuotaMensual	money NULL,
Interes	money NULL,
FechaPago	date NULL,
FechaMaximaPago	date NULL,
precio money NULL,
cantidad int NULL,
idEstado	int NOT NULL,
primary key(Linea,IdNumeroFactura),
foreign key (IdNumeroFactura) references Facturacion.Factura,	
foreign key(IdArticulo, IdEmpresa) references Inventario.Articulo,	
foreign key (idUsuario) references Seguridad.Usuario,
foreign key (idEstado) references Seguridad.Estado
)
GO

CREATE TABLE Facturacion.DevolucionDet
(
IdEmpresa int NOT NULL,
idUsuario int NOT NULL,
Linea int NOT NULL,
IdNumeroDevolucion int NOT NULL,
IdArticulo int NULL,
Observacion	varchar(300) NULL,
cantidad int NULL,
idEstado	int NOT NULL,
primary key(Linea,IdNumeroDevolucion),
foreign key (IdNumeroDevolucion) references Facturacion.DevolucionVenta,	
foreign key(IdArticulo, IdEmpresa) references Inventario.Articulo,	
foreign key (idUsuario) references Seguridad.Usuario,
foreign key (idEstado) references Seguridad.Estado
)
GO


create table Inventario.IngresoEgresoCab
(
IdEmpresa	int not null,
NroMovimiento	int,
IdTipoMovimiento	int,
FechaMovimiento	date,
IdOrdenCompra	int,
IdMotivo		int,
IdBodega	int,
IdResponsable	int,
TotalPagar	numeric(7,2),
Observacion	varchar(150),
IdUsuario	int,
IdEstado	int,
primary key(IdEmpresa,NroMovimiento),
foreign key(IdOrdenCompra,IdEmpresa)references Compras.OrdenCompra,
foreign key (IdTipoMovimiento) references Inventario.TipoMovimiento,
foreign key(IdEstado)references Seguridad.Estado,
foreign key (IdMotivo) references Inventario.Motivo,
foreign key(IdBodega,IdEmpresa)references Inventario.Bodega,
foreign key(IdResponsable)references RecursosHumanos.Persona,
foreign key(IdUsuario)references Seguridad.Usuario
)
 go
 
 create table Inventario.IngresoEgresoDet
(
IdEmpresa	int,
NroMovimiento	int not null,
numero int not null,
IdArticulo	int,
IdPercha int,
CantidadPedida	int,
CantidadLlegada int,
Costo	numeric(5,2),
Subtotal	numeric(5,2),
ValorIVA	numeric(5,2),
ValorTotal	numeric(5,2),
primary key (NroMovimiento, numero),
foreign key (IdEmpresa, NroMovimiento) references Inventario.IngresoEgresoCab,
foreign key(IdArticulo,IdEmpresa)references Inventario.Articulo,
foreign key(IdPercha)references Inventario.Percha,
)
go

/****************** Cuentas por cobrar **********************/
/************************************************************/
/*necesita de modulo facturacion*/

create table CuentaxPagar.MedioPago/*TABLA SUBIDA PORQUE LA USA CXP.COBRO*/
(
	IdMedioPago 			int not null ,
	Descripcion				varchar(30) not null,
	fechaRegistro			date not null,
	Estado 				int not null,
	IdEmpresa 				int not null references Seguridad.Empresa,
	IdUsuario 				int not null,
	foreign key (IdUsuario) references Seguridad.Usuario,
	primary key(IdMedioPago, IdEmpresa) 
)
go

create table CuentasPorCobrar.UnidadTiempo
(
	idEmpresa 				int NOT NULL,/*Agrego Campo Empresa*/
	idUnidadTiempo 			int not null,
	Descripcion				varchar(25) not null,
	Estado					char(1),/*'A' activo 'I' Inactivo*/
	primary key(idUnidadTiempo),
	foreign key (idEmpresa) references Seguridad.Empresa
)
go

CREATE TABLE CuentasPorCobrar.MonetarioDet
(
	idEmpresa 				int NOT NULL,
	idDetalleMonetario 		int NOT NULL,
	Descripcion				varchar(100) NOT NULL,
	Valor					money NOT NULL,
	Estado				    char(1),/*'A' activo 'I' Inactivo*/
	primary key (idDetalleMonetario),
	foreign key (idEmpresa) references Seguridad.Empresa
)
go



CREATE TABLE CuentasPorCobrar.CierreCaja
(
	idEmpresa 				int NOT NULL,
	idUsuario 				int NOT NULL,
	idCierreCaja 			int NOT NULL,
	FechaCierre				date NOT NULL,
	FechaModificacion		datetime, 
	MontoApertura			money NOT NULL,
	TotalDeposito			money NOT NULL,
	TotalTransferencia		money NOT NULL,
	TotalCheque				money NOT NULL,
	TotalBoucher			money NOT NULL,
	TotalEfectivo			money NOT NULL,
	TotalRecaudado			money NOT NULL,
	idEstado 				int NOT NULL,
	primary key (idCierreCaja),
	foreign key (idEmpresa) references Seguridad.Empresa,
	foreign key (idUsuario) references Seguridad.Usuario,
	foreign key (idEstado) references Seguridad.Estado
)
go

CREATE TABLE CuentasPorCobrar.TipoInversion
(
	idEmpresa 				int NOT NULL,
	idTipoInversion 		int NOT NULL,
	Descripcion				varchar(100) NOT NULL,
	Estado				    char(1),/*'A' activo 'I' Inactivo*/
	primary key (idTipoInversion),
	foreign key (idEmpresa) references Seguridad.Empresa
)
go

CREATE TABLE CuentasPorCobrar.Banco
(
	idEmpresa 				int NOT NULL,
	idBanco 				int NOT NULL,
	Nombre					varchar(100) NOT NULL,
	Estado				    char(1),/*'A' activo 'I' Inactivo*/
	primary key (idBanco),
	foreign key (idEmpresa) references Seguridad.Empresa
 )
go

CREATE TABLE CuentasPorCobrar.TarjetaCredito
(
	idEmpresa 				int NOT NULL,
	idTarjeta 				int NOT NULL,
	descripcion				varchar(100) NOT NULL,
	idBanco 				int NOT NULL,
	Estado				    char(1),/*'A' activo 'I' Inactivo*/
	primary key (idTarjeta),
	foreign key (idEmpresa) references Seguridad.Empresa,
	foreign key (idBanco) references CuentasPorCobrar.Banco,
 )
 go

CREATE TABLE CuentasPorCobrar.MovimientoBancario
(
	idEmpresa 				int NOT NULL,
	idUsuario 				int NOT NULL,
	idMovimientoBancario 	int NOT NULL,
	idTransaccion 			int NOT NULL,
	idBanco 				int NOT NULL,
	NumeroDocumento 		int NOT NULL,
	Observacion				varchar(150) NOT NULL,
	Fecha					date NOT NULL,
	FechaModificacion		datetime, 
	Valor					money NOT NULL,
	idEstado 				int NOT NULL,
	primary key (idMovimientoBancario),
	foreign key (idEmpresa) references Seguridad.Empresa,
	foreign key (idUsuario) references Seguridad.Usuario,
	foreign key (idTransaccion) references Facturacion.Factura,
	foreign key (idBanco) references CuentasPorCobrar.Banco,
	foreign key (idEstado) references Seguridad.Estado
)
go

CREATE TABLE CuentasPorCobrar.Inversion
(
	idEmpresa 				int NOT NULL,
	idUsuario 				int NOT NULL,
	idInversion 			int NOT NULL,
	idEntidad 				int NOT NULL,
	idTipoInversion 		int NOT NULL,
	Tiempo 					int NOT NULL,
	idUnidadTiempo 			int NOT NULL,
	idBanco					int,
	Valor					money NOT NULL,
	Porcentaje				numeric(18, 0) NOT NULL,
	Ganancia				decimal(18, 2),
	Fecha					date NOT NULL,
	FechaModificacion		datetime, 
	FechaInicio				date NOT NULL,
	FechaFinal				date NOT NULL,
	idEstado				varchar(1) NOT NULL,
	primary key (idInversion),
	foreign key (idEmpresa) references Seguridad.Empresa,
	foreign key (idUsuario) references Seguridad.Usuario,
	foreign key (idEntidad) references RecursosHumanos.Persona,
	foreign key (idTipoInversion) references CuentasPorCobrar.TipoInversion,
	foreign key (idUnidadTiempo) references CuentasPorCobrar.UnidadTiempo,
	foreign key (idBanco) references CuentasPorCobrar.Banco
 )
 go

 
CREATE TABLE CuentasPorCobrar.AperturaCaja
(
	idEmpresa 				int NOT NULL,
	idUsuario 				int NOT NULL,
	idAperturaCaja 			int NOT NULL,
	Fecha					date NOT NULL,
	FechaModificacion		datetime, 
	Monto					money NOT NULL,
	idEstado 				int NOT NULL,
	primary key (idAperturaCaja),
	foreign key (idEmpresa) references Seguridad.Empresa,
	foreign key (idUsuario) references Seguridad.Usuario,
	foreign key (idEstado) references Seguridad.Estado
 )
 go

CREATE TABLE CuentasPorCobrar.CuentaBancaria
(
	idEmpresa 				int NOT NULL,
	idCuentaBancaria 		int NOT NULL,
	idBanco 				int NOT NULL,
	idTitular        		int NULL,/*se ha modificado a un solo campo*/
	NumeroCuenta 			int NOT NULL,
	TipoCuenta				varchar(100) NOT NULL,
	Saldo					money NOT NULL,
	Estado				    char(1),/*'A' activo 'I' Inactivo*/
	primary key (idCuentaBancaria),
	foreign key (idEmpresa) references Seguridad.Empresa,
	foreign key (idBanco) references CuentasPorCobrar.Banco,
	foreign key (idTitular) references RecursosHumanos.Persona,/*Referencia unica*/
)
go

CREATE TABLE CuentasPorCobrar.ConciliacionBancaria
(
	idEmpresa 				int NOT NULL,
	idUsuario 				int NOT NULL,
	idConciliacionBancaria 	int NOT NULL,
	idBanco 				int NOT NULL,
	NumeroCuenta 			int NOT NULL,
	FechaModificacion		datetime, 
	FechaConciliacion		date NOT NULL,
	FechaDesde				date NOT NULL,
	FechaHasta				date NOT NULL,
	TotalIngresos			money NOT NULL,
	TotalEgresos			money NOT NULL,
	Saldo					money NOT NULL,
	TotalConciliacion		money NOT NULL,
	idEstado 				int NOT NULL,
	primary key (idConciliacionBancaria),
	foreign key (idEmpresa) references Seguridad.Empresa,
	foreign key (idUsuario) references Seguridad.Usuario,
	foreign key (idBanco) references CuentasPorCobrar.Banco,
	foreign key (idEstado) references Seguridad.Estado
 )
 go
/*subida la tabla de cxc y cxcdet*/
create table CuentasPorCobrar.CuentaxCobrar
(
	idEmpresa 				int NOT NULL,
	idUsuario 				int NOT NULL,
	idCuentaxCobrar 		int NOT NULL,	
	numero_comprobante		numeric(4,0),
	idTransaccion 			int NOT NULL,
	idFactura 				int NOT NULL,
	Modulo				int NOT NULL,
	idCabeceraComprobante 	int NOT NULL,
	TotalCuotas 			int NOT NULL,
	porcentaje_interes		numeric NOT NULL,
	idEstado 				int NOT NULL,
	primary key (idCuentaxCobrar),
	foreign key (idEmpresa) references Seguridad.Empresa,
	foreign key (idUsuario) references Seguridad.Usuario,
	foreign key (idTransaccion) references Facturacion.Factura,
	foreign key (idFactura) references Facturacion.Factura,
	foreign key (IdEmpresa, numero_comprobante) references Contabilidad.CabeceraComprobante,
	foreign key (idEstado) references Seguridad.Estado
)
go

CREATE TABLE CuentasPorCobrar.CuentaxCobrarDet
(
	idEmpresa 				int NOT NULL,
	idUsuario 				int NOT NULL,
	idCuentaxCobrar 		int NOT NULL,
	/*idCobro 				int NOT NULL,*//*se cambio logica de referencia a cobro*/
	Numero 					int NOT NULL,
	numero_cuota 			int NOT NULL,
	valor_cuota				money NOT NULL,
	valor_interes			money NOT NULL,
	valor_mora				money NOT NULL,
	fecha_cobro				date NOT NULL,
	fecha_vencimiento		date NOT NULL,
	FechaModificacion		datetime, 
	idEstado int NOT NULL,
	primary key (idCuentaxCobrar, numero),
	foreign key (idEmpresa) references Seguridad.Empresa,
	foreign key (idUsuario) references Seguridad.Usuario,
	/*foreign key (idCobro) references CuentasPorCobrar.Cobro,*/
	foreign key (idEstado) references Seguridad.Estado
)
go
 
 CREATE TABLE CuentasPorCobrar.Cobro
(
	idEmpresa 				int NOT NULL,
	idUsuario 				int NOT NULL,
	idCobro 				int NOT NULL,
	idTransaccion 			int NOT NULL,
	idFactura 				int NOT NULL,
	idCliente 				int NOT NULL,
	idCabeceraComprobante	numeric(4,0) NOT NULL,
	idCuentaxCobrar			int NOT NULL,/*AGREGADO CAMBIO LOGICA*/
	numeroCuentaxCobrar		int NOT NULL,/*AGREGADO CAMBIO LOGICA*/
	Fecha					date NOT NULL,
	FechaModificacion		datetime, 
	NumeroCuota 			int NOT NULL,
	ValorCuota				money NOT NULL,
	Interes					money NOT NULL,
	Mora					money NOT NULL,
	ValorPagado				money NOT NULL,
	Saldo					money NOT NULL,
	idEstado 				int NOT NULL,
	primary key (idCobro),
	foreign key (idEmpresa) references Seguridad.Empresa,
	foreign key (idUsuario) references Seguridad.Usuario,
	foreign key (idTransaccion) references Facturacion.Factura,
	foreign key (idFactura) references Facturacion.Factura,
	foreign key (idCliente) references RecursosHumanos.Persona,
	foreign key (IdEmpresa,idCabeceraComprobante) references Contabilidad.CabeceraComprobante,
	foreign key (idCuentaxCobrar, numeroCuentaxCobrar) references CuentasPorCobrar.CuentaxCobrarDet,/*agregada ref de cambio de log*/
	foreign key (idEstado) references Seguridad.Estado
)
go
 
CREATE TABLE CuentasPorCobrar.CobroDet
(
	idEmpresa 				int NOT NULL,
	idUsuario 				int NOT NULL,
	idCobro 				int NOT NULL,
	numero 					int NOT NULL,
	idBanco 				int NOT NULL,
	idMedioPago 			int NOT NULL,/*se establece referencia MEDIOPAGO de CXP*/
	Valor					money NOT NULL,
	NumeroDocumento 		int NOT NULL,
	Observacion				varchar(150) NOT NULL,
	idEstado 				int NOT NULL,
	primary key(idCobro,numero),
	foreign key(idEmpresa)references Seguridad.Empresa,
	foreign key(idUsuario)references Seguridad.Usuario,
	foreign key(idCobro)references CuentasPorCobrar.Cobro,/*Se agrego la referencia a cobro que le quitaron*/
	foreign key(idBanco)references CuentasPorCobrar.Banco,
	foreign key (idMedioPago, idEmpresa)references CuentaxPagar.MedioPago,/*se corrige la referencia*/
	foreign key (idEstado) references Seguridad.Estado 
 )
 go
 
CREATE TABLE CuentasPorCobrar.AperturaDet
(
	idEmpresa 				int NOT NULL,
	IdUsuario 				int NOT NULL,
	idAperturaCaja 			int NOT NULL,
	Numero 					int NOT NULL,
	Denominacion 			int NOT NULL,
	Cantidad 				int NOT NULL,
	idEstado 				int NOT NULL,
	primary key (idAperturaCaja,numero),
	foreign key (idEmpresa) references Seguridad.Empresa,
	foreign key (idUsuario) references Seguridad.Usuario,
	foreign key (idAperturaCaja) references CuentasPorCobrar.AperturaCaja,
	foreign key (idEstado) references Seguridad.Estado
)
go


/***************Cuentas por Pagar**************************************************/

create table CuentaxPagar.EmpresaServicio
(
	IdEmpresaServicio 		varchar (13) not null,
	FechaRegistro			date not null,
	RazonSocial				varchar(30) not null,
	Direccion				varchar(30)not null,
	Email					varchar(50) null,
	Webpage					varchar(50) null,
	Estado					int not null,
	IdTipoPersona 			int not null,
	IdEmpresa 				int not null,
	IdUsuario 				int not null,
	foreign key (IdTipoPersona)references RecursosHumanos.TipoPersona,
	foreign key (IdEmpresa)references Seguridad.Empresa, 
	foreign key (IdUsuario)references Seguridad.Usuario,
	primary key(IdEmpresaServicio,IdEmpresa)
)
go


create table CuentaxPagar.TelefonoEmpresaServicio
(
		IdEmpresa 				int not null,
		IdEmpresaServicio 		varchar(13) not null,
		IdTelefono 				int not null,
		Serie 					int not null,
		foreign key (IdEmpresa)references Seguridad.Empresa, 
		foreign key (IdEmpresaServicio, IdEmpresa)references CuentaxPagar.EmpresaServicio,
		foreign key (IdTelefono)references RecursosHumanos.Telefono, 
		primary key(IdEmpresaServicio,IdEmpresa, Serie, IdTelefono)	
)
go	


create table CuentaxPagar.Impuesto
(
	IdImpuesto 				int not null,
	Descripcion				varchar(30) not null,
	Porcentaje				decimal(4,2)not null,
	FechaRegistro			date not null,
	Estado 					int not null,
	IdEmpresa 				int not null,
	IdUsuario 				int not null,
	foreign key (IdUsuario)references Seguridad.Usuario,
	foreign key (IdEmpresa)references Seguridad.Empresa,
	primary key (IdImpuesto, IdEmpresa)
)
go

create table CuentaxPagar.FrecuenciaPago
(
	IdFrecuenciaPago 		int not null,
	Descripcion				varchar(30) not null,
	FechaActual				date not null,
	Estado 					int not null,
	IdUsuario 				int not null,
	IdEmpresa 				int not null,
	foreign key (IdUsuario)references Seguridad.Usuario,
	foreign key (IdEmpresa)references Seguridad.Empresa,
	primary key(IdFrecuenciaPago,IdEmpresa)
)
go

create table CuentaxPagar.CuentaBancaria2
(
	Serie 				int not null,
	TipoCuenta			varchar (10) not null,
	NroCta 				varchar(13) not null,
	IdBanco 			int not null,
	IdEmpresa 			int not null,
	IdEmpresaServicio	varchar(13) not null,
	foreign key (IdEmpresaServicio, IdEmpresa)references CuentaxPagar.EmpresaServicio,
	foreign key (IdBanco)references CuentasPorCobrar.Banco,
	foreign key (IdEmpresa)references Seguridad.Empresa,
	primary key(Serie,IdEmpresaServicio)
)
go

/************************cuentas por pagar*************/

create table CuentaxPagar.CuentaPorPagar 
(
	NumCuentaPorPagar 		int not null ,
	NumIngresoEgreso 		int null,
	FechaIngreso			date not null,
	NumeroFactura 			varchar(16) not null,
	FechaTransaccion		date not null,
	IdProveedor 			int null,
	IdEmpresaServicio		varchar(13) null,
	Motivo					varchar(30) not null,
	Detalle					varchar(150) not null,
	Subtotal				numeric(10,2) not null,
	Descuento				numeric(10,2) not null,
	Total					numeric (10,2) not null,
	FormaPago				char not null,
	ValorEntrada			numeric(10,2) null,
	NumeroLetra				int null,
	IdFrecuencia 			int null,
	ValorLetra				numeric(10,2) null,
	SaldoDeuda				numeric(10,2) null,
	IdUsuario 				int not null,
    IdEmpresa 				int not null references Seguridad.Empresa,
    foreign key (IdUsuario)references Seguridad.Usuario,
    foreign key (IdFrecuencia, IdEmpresa)references CuentaxPagar.FrecuenciaPago,
    foreign key (IdEmpresaServicio, IdEmpresa)references CuentaxPagar.EmpresaServicio,
	foreign key (IdProveedor)references Compras.Proveedor,		
    foreign key (NumIngresoEgreso, IdEmpresa)references Inventario.IngresoEgresoCab,
    foreign key (IdEmpresa) references Seguridad.Empresa,
	primary key(NumCuentaPorPagar, IdEmpresa)
)
GO

create table CuentaxPagar.DeudaDet--esta tabla debe llamarse CuentaPorPagarDetalle
(
	IdEmpresa 				int,
	NumCuentaPorPagar 		int not null,
	NumDetalleDeuda 		int not null,
	ValorLetra				numeric(10,2) not null,
	FechaVencimiento		date not null,
	Estado 				int not null,
    foreign key (NumCuentaPorPagar, IdEmpresa) references CuentaxPagar.CuentaPorPagar,
	primary key(IdEmpresa, NumCuentaPorPagar, NumDetalleDeuda)
)
go


create table CuentaxPagar.ImpuestoCuenta
(
	IdImpuesto 				int,
	NumCuentaPorPagar 		int not null,
	Valor					numeric(10,0) not null,
    IdEmpresa 				int not null references Seguridad.Empresa,
    foreign key (IdImpuesto, IdEmpresa)references CuentaxPagar.Impuesto, 
    foreign key (NumCuentaPorPagar, IdEmpresa)references CuentaxPagar.CuentaPorPagar, 
    primary key(IdEmpresa, IdImpuesto, NumcuentaPorPagar) 	
)
go


create table CuentaxPagar.OrdenPagoCab
(
	NumOrdenPago 			int not null,
	fechadeEmision			date not null,
	IdPersona 				int null,
	Estado 				int not null,
	TotalPagar				numeric(10,2) not null,
	TipoOrdenPago			char not null,
	IdUsuario 				int not null,
    IdEmpresa 				int not null,
    foreign key (IdUsuario)references Seguridad.Usuario,
    foreign key (IdEmpresa)references Seguridad.Empresa, 
	primary key (NumOrdenPago, IdEmpresa) 
)
go

create table CuentaxPagar.OrdenPagoEmpleadoDet
(
	NumOrdenPago 			int not null,
	IdEmpresa 				int not null,
	Linea 					int not null,
	IdPersona 				int not null,
	SueldoTotal				numeric(10,2) null,
	IngresoAdicional		numeric(10,2) null,
	DescuentoTotal			numeric(10,2) null,
	PagoNeto				numeric(10,2) not null,
    foreign key (NumOrdenPago, IdEmpresa) references CuentaxPagar.OrdenPagoCab,
    foreign key (IdEmpresa)references Seguridad.Empresa, 
	primary key (NumOrdenPago, IdEmpresa, Linea) 
)
go

create table CuentaxPagar.OrdenPagoDet
(
	NumLinea 				int not null,
	NumCuentaPorPagar 		int not null,
	NumDetalleDeuda 		int not null,
	SaldoDeuda				numeric(10,0)not null,
	NumeroPagosRealizar 	int not null,
	NumOrdenCab 			int not null,
	TotalPagar				numeric(10,0) not null,
    IdEmpresa 				int not null,
    foreign key(NumOrdenCab, IdEmpresa) references CuentaxPagar.OrdenPagoCab,
    foreign key (NumDetalleDeuda, NumCuentaPorPagar, IdEmpresa)references CuentaxPagar.DeudaDet, 
    primary key(NumLinea, NumOrdenCab, IdEmpresa)
)
go

--*******************************************

create table CuentaxPagar.PagoCab
(
	NumPago 				int not null,
	FechaIngreso			date not null,
	NumOrdenPago 			int null,
	TotalPagar				numeric(10,0) not null,
	IdUsuario 				int not null,
	IdEmpresa 				int not null,
	Estado 					int not null,
    NumComprobante			numeric(4)not  null,

	foreign key (IdUsuario)references Seguridad.Usuario,
    foreign key (IdEmpresa)references Seguridad.Empresa, 
    foreign key (NumOrdenPago, IdEmpresa)references CuentaxPagar.OrdenPagoCab,
    primary key (NumPago,IdEmpresa)				
)
go



create table CuentaxPagar.PagoDet
(
	NumLinea 				int not null,
	IdMedioPago 			int not null,
	Monto					numeric(10,0) not null,
	NumeroCuenta 			int not null,
	IdEmpresa 				int not null,
	IdBanco 				int not null,
	NumComprobante			numeric(4)not null,
	NumComision 			int null,
	NumNominaCab 			int null,
	NumPago 				int not null,
	foreign key (NumPago, IdEmpresa)references CuentaxPagar.PagoCab,
	foreign key (NumComision)references Facturacion.Comision,
	foreign key (NumNominaCab, IdEmpresa)references RecursosHumanos.NominaCab,
	foreign key (IdMedioPago, IdEmpresa)references CuentaxPagar.MedioPago,
	foreign key (IdEmpresa, NumComprobante)references Contabilidad.CabeceraComprobante,
	foreign key (IdBanco)references CuentasPorCobrar.Banco,
	primary key(NumPago,NumLinea) 
)
go


/*Activo Fijo se integra con inventario*************************************/
/*************************ACTIVO FIJO***********/

go
/*8 Esta es la tabla de CodigoBarra*/
--Nueva TablaV1 Esta es la tabla TipoFormato
create table ActivoFijo.TipoFormato
(
	IdTipoFormato 			int primary key,
	descripcion				varchar(50)  null,
)
go
--Nueva TablaV1 Esta es la tabla TipoFormato
create table ActivoFijo.Imagen
(
	IdImagen			    int primary key,
	descripcion				varchar(250) null,
	Imagen					image null,	
)
go

--8 Esta es la tabla de CodigoBarra
create table ActivoFijo.CodigoBarra
(
	IdCodigoBarra 			int primary key,
	ancho					numeric(10,2)   null,
	alto					numeric(10,2)   null,
	fecha					date   null,
	fecha_seteoDesde		date   null,
	fecha_seteoHasta		date   null,
	margen_superior			numeric(10,2)  null,
	margen_inferior			numeric(10,2)   null,
	sentido_lectura			bit   null,
	Idformato				int   null,
	IdImagen				int  null,
	EstadoProceso			varchar(30)   null,--Es para identificar si esta anulado o no el proceso
	--haciendo las referencias constraint
	foreign key (Idformato) references ActivoFijo.TipoFormato,--relacion tablas de Seguridad
	FOREIGN KEY (IdImagen)REFERENCES ActivoFijo.Imagen
)

go
create table ActivoFijo.ActivoFijo
(
	IdActivoFijo 			int primary key,
	cantidad				int   null,
	IdEmpresa 				int   null,--relacion tablas de Seguridad
	IdDepartamento 			int   null,--relacaion tablas de RRHH
	IdResponsable 			int   null,--relacaion tablas de RHHH de la tabla Personal
	IdArticuloBodega 		int   null,--relacion tablas de inventario que es para la asignacion de responsable de bodega
	IdUsuario 				int   null,     --relacion tablas de RHHH de la tabla Personal
	IdTipo 					int   null,--relacion tablas de inventario que es el tipo de articulo que ellos poseen
	IdGrupo 				int   null,
	IdSubgrupo 				int   null,--relacion tablas de inventario
	IdArticulo 				int   null,--relacion tablas de inventario
	IdProveedor				int  null,
	descripcion				varchar(150)   null,
	valor_nomial			numeric(10,2)   null,
	ValorAdquisicion		numeric (10,2)  null,--Campo nuevo ingresado******
	valor_residual			numeric(10,2)   null,
	valor_actualserie		numeric(10,2)   null,
	IdCodigoBarra 			int   null,
	EstadoProceso			varchar(30)   null,--Es para identificar si esta anulado o no el proceso
	fecha_Adquisicion		date   null,
	ano_vidaUtil 			numeric   null,
	IdEstado 				int   null,--relacion tabla general de Estado
	fecha_registro			date   null,
	--haciendo las referencias constraint
	foreign key (IdEmpresa) references Seguridad.Empresa,--relacion tablas de Seguridad
	foreign key (IdDepartamento)references RecursosHumanos.Departamento,--relacaion tablas de RRHH
	foreign key (IdArticuloBodega)references Inventario.ArticuloBodega,--relacion tablas de inventario,
	foreign key (IdResponsable,IdEmpresa)references RecursosHumanos.Empleado,--relacaion tablas de RRHH
	foreign key (IdUsuario)references Seguridad.Usuario,
	foreign key (IdTipo)references Inventario.TipoArticulo,--relacion tablas de inventario,
	foreign key (IdGrupo)references Inventario.Grupo,
	foreign key (IdSubgrupo)references ActivoFijo.SubGrupos,--relacion tablas de inventario,
	foreign key (IdArticulo,IdEmpresa)references Inventario.Articulo,--relacion tablas de inventario,
	foreign key (IdProveedor) references Compras.Proveedor,
	--foreign key (IdMarca)references Inventario.Marca,--relacion tablas de inventario,
	foreign key (IdCodigoBarra) references ActivoFijo.CodigoBarra,
	foreign key (IdEstado) references Seguridad.Estado--relacion tabla general de Estado
) 
go


--2 Esta es la tabla de Terreno
create table ActivoFijo.Terreno
(
	IdActivoFijo 			int primary key,
	direccion				varchar(100)  null, 
	observacion				varchar(450)  null,
	--IdTipoTerreno 			int   null,
	codigoCatatral          varchar (40) null,
	DimensionAncho			numeric(10,2)   null,
	DimensionLargo			numeric(10,2)   null,
	FechaLegalizacion		date   null,
	foreign key (IdActivoFijo) references ActivoFijo.ActivoFijo,
	--foreign key (IdTipoTerreno) references ActivoFijo.TipoTerreno
)
go


--4 Esta es la tabla de EquipoComputo
create table ActivoFijo.EquipoMaquinariaMuebles
(
	IdActivoFijo 			int primary key,
	IdMarca 				int   null,--relacion tablas de inventario,
	IdModelo 				int   null,--relacion tablas de inventario
	IdColor 				int   null,--relacion tablas de inventario,
	Carga					int   null,
	AniosDepreciados		int   null,
	DimensionAncho			numeric(10,2)   null,
	DimensionLargo			numeric(10,2)   null,
	DimensionAlto			numeric(10,2)   null,
	observacion				varchar(450) null, 

	--haciendo las referencias constraint
	foreign key (IdActivoFijo) references ActivoFijo.ActivoFijo,
	foreign key (IdMarca)references Inventario.Marca,--relacion tablas de inventario,
	foreign key (IdModelo)references Inventario.Modelo,--relacion tablas de inventario,
	foreign key (IdColor)references Inventario.Color,--relacion tablas de inventario,
)
go

--6 Esta es la tabla de DepreciacionCab
create table ActivoFijo.DepreciacionCab
(
	Secuencia_DepreciacionCab int,
	IdEmpresa				  int,
	IdUsuario 				  int   null,
	EstadoProceso			varchar(30)   null,--Es para identificar si esta anulado o no el proceso
	fecha					  date   null,
	fechaModificacion		  date   null,
	observacion				  varchar(150)   null
	primary key (Secuencia_DepreciacionCab,IdEmpresa),
	foreign key (IdUsuario)references Seguridad.Usuario,--relacaion tablas de RRHH
	foreign key (IdEmpresa) references Seguridad.Empresa,
)
go


--5 Esta es la tabla de DepreciacionDet
create table ActivoFijo.DepreciacionDet
(
	IdCabecera 				  int,
	Secuencia_DepreciacionDet int,
	IdActivoFijo 		      int   null,
	Periodo                   int null,
	IdEmpresa				  int   null,
	DepreAnual				  numeric(10,2)   null,--campos nuevos insertados*******
	DepreAcumulada		      numeric(10,2)   null,--campos nuevos insertados*******
	valor_nominal			  numeric(10,2)   null,
	valor_actual			  numeric(10,2)   null
	--haciendo las referencias constraint
	 primary key (IdCabecera,Secuencia_DepreciacionDet),
	 foreign key (IdActivoFijo) references ActivoFijo.ActivoFijo,
	 FOREIGN KEY (IdCabecera,IdEmpresa)REFERENCES ActivoFijo.DepreciacionCab	 
)
go




--7 Esta es la tabla de Vehiculo
create table ActivoFijo.Vehiculo
(
	IdActivoFijo			int primary key,
	IdMarca 				int   null,--relacion tablas de inventario,
	IdModelo 				int   null,--relacion tablas de inventario
	IdColor 				int   null,--relacion tablas de inventario,
	IdMotor 				int   null,--relacion tablas de inventario,
	serie					varchar(17)	  null,
	IdChasis 				int   null,
	placa					varchar(10)   null,
	numeropuerta			int    null,
	AniosDepreciados        int    null,
	descripcion				varchar (50)  null,
	IdMaterial 				int     null,--relacion tablas de inventario,
	matricula				varchar (50)  null,
	transmision				varchar (30)  null,
	carga					numeric(10,2) null,
	capacidad				numeric(10,2) null,
	kilometraje				numeric(10,2) null,
	fechaCreacion			date null,
	--haciendo las referencias constraint
	 foreign key (IdActivoFijo) references ActivoFijo.ActivoFijo,
	 foreign key (IdMarca)references Inventario.Marca,--relacion tablas de inventario,
	 foreign key (IdModelo)references Inventario.Modelo,--relacion tablas de inventario,
	 foreign key (IdColor)references Inventario.Color,--relacion tablas de inventario,
	 foreign key (IdMotor)references Inventario.TipoMotor,--relacion tablas de inventario,
	 foreign key (IdChasis)references Inventario.Chasis,--relacion  tablas de inventario,
	 foreign key (IdMaterial)references Inventario.TipoMaterial--relacion tablas de inventario
)
go

go
create table ActivoFijo.Articulos_SuministrosOficina
(
	IdActivoFijo 			int primary key, 
	IdMarca 				int   null,--relacion tablas de inventario,
	IdModelo 				int   null,--relacion tablas de inventario
	IdColor 				int   null,--relacion tablas de inventario,
	IdMaterial 				int   null,
	observacion				varchar(450) null, 
	--haciendo las referencias constraint
	foreign key (IdActivoFijo) references ActivoFijo.ActivoFijo,
	foreign key (IdMarca)references Inventario.Marca,--relacion tablas de inventario,
	foreign key (IdModelo)references Inventario.Modelo,--relacion tablas de inventario,
	foreign key (IdColor)references Inventario.Color,--relacion tablas de inventario,
	foreign key (IdMaterial)references Inventario.TipoMaterial--relacion tablas de inventario
)
go 



--9 Esta es la tabla de Transferencia
create table ActivoFijo.Transferencia
(
	Idtransferencia 			int primary key,
	EstadoProceso			varchar(30)   null,--Es para identificar si esta anulado o no el proceso
	IdActivoFijo 				int   null,
	fecha						date  null,
	--IdTipoTransferencia 		int   null,
	IdEmpresa 					int   null,
	IdResponsableFuturo 		int   null,
	IdBodegaFuturo 				int   null,
	IdDepartamento 				int   null,
	Observaciones				varchar(250),
	--haciendo las referencias constraint
	foreign key (IdActivoFijo) references ActivoFijo.ActivoFijo,
	--foreign key (IdTipoTransferencia) references ActivoFijo.TipoTransferencia,
	foreign key (IdDepartamento)references RecursosHumanos.Departamento,--relacaion tablas de RRHH
	foreign key (IdResponsableFuturo,IdEmpresa)references RecursosHumanos.Empleado,--relacaion tablas de RRHH
	foreign key (IdBodegaFuturo,IdEmpresa)references Inventario.Bodega,--relacaion con Inventario 
)
go



--*************Nuevas tablas***********
create table ActivoFijo.Edifico
(
	IdActivoFijo 				int primary key,
	FechaConstruccion			date  null,
	CodigoCatastral 			int   null,
	NumeroPisos 				int   null,
	AniosDepreciados 			int   null,
	Ubicacion 					varchar(100)  null, 
	DimensionAncho				numeric(10,2) null,
	DimensionLargo				numeric(10,2) null,
	--Avaluo						numeric(10,2) null,
	observacion 				varchar(450)  null,
	--haciendo las referencias constraint
	foreign key (IdActivoFijo) references ActivoFijo.ActivoFijo,
)
go

create table ActivoFijo.revalorizacion
(
	IdRevalorizacion 			int primary key,
	IdUsuario 				    int  null,
	EstadoProceso			varchar(30)   null,--Es para identificar si esta anulado o no el proceso
	Fecha						date null,
	IdActivoFijo 				int   null,
	ValorAtual					numeric(10,2)   null,
	ValorRevalorizado			numeric(10,2)   null,
	ValorResidual				numeric(10,2)   null,
	foreign key (IdUsuario)references Seguridad.Usuario,
	foreign key (IdActivoFijo) references ActivoFijo.ActivoFijo--relacion tabla general de Estado
)
go

create table ActivoFijo.BajaActivo
(
	idBajaActivo 				int primary key,
	EstadoProceso			varchar(30)   null,--Es para identificar si esta anulado o no el proceso
	IdActivoFIjo 				int   null,
	--IdGrupo						int  null,
	--IdSubgrupo					int  null,
	Fecha						date null,
	--IdEstado 					int  null,
	IdEmpresa 					int  null,
	Descripcion 				varchar(50)   null,
	Motivo 						varchar(25)   null,
	--IdProveedor					int  null,
	IdCabeceraComprobante		numeric(4,0)  null,
	Observacion 				varchar(300)  null,
	IdImagen				int  null,
	--haciendo las referencias constraint
	foreign key (IdActivoFIjo) references ActivoFijo.ActivoFijo,
	--foreign key (IdGrupo)references Inventario.Grupo,
	--foreign key (IdSubgrupo)references ActivoFijo.SubGrupos,
	--foreign key (IdEstado) references Seguridad.Estado,
	foreign key (IdEmpresa) references Seguridad.Empresa,
	--foreign key (IdProveedor) references Compras.Proveedor,
	FOREIGN KEY (IdImagen)REFERENCES ActivoFijo.Imagen,
	foreign key (IdEmpresa, IdCabeceraComprobante) references Contabilidad.CabeceraComprobante
)
go


create table ActivoFijo.VentaGarageCab
(
	idVentaGarage 				int,
	IdEmpresa 					int,
	IdUsuario 				    int  null,
	NombreCliente  				varchar(50)   null,
	Direccion 					varchar(150)  null,
	Identificador 				int   null,
	Fecha						date  null,
	fechaModificacion		    date  null,
	Telefono 					int   null,
	IdFormaPagoMedioPago 		int   null,
	CantidadEfectivo 			int   null,
	CantidadCredito 			int   null,
	CantidadTransferencia 		int   null,
	CantidadDeposito 			int   null,
	CantidadCheque 				int   null,
	EstadoProceso			varchar(30)   null,--Es para identificar si esta anulado o no el proceso
	--haciendo las referencias constraint
	primary key (idVentaGarage,IdEmpresa),
	foreign key (IdUsuario)references Seguridad.Usuario,
	foreign key (IdEmpresa) references Seguridad.Empresa,
	foreign key (IdFormaPagoMedioPago, IdEmpresa) references CuentaxPagar.MedioPago
)
go

create table ActivoFijo.VentaGarageDet
(
	IdCabecera 				int not null,
	IdVentaGarageDet 		int,
	IdEmpresa 				int,
	--IdBajaActivo 			int   null,
	cantidad 				int   null,
	ValorUnitario 			int   null,
	ValorTotal 				int   null,
	SubTotal 				int   null,
	Iva 					int   null,
	Total 					int   null, 
	IdCabeceraComprobante numeric(4,0)   null,
	--haciendo las referencias constraint
	primary key (IdCabecera,IdVentaGarageDet),
	foreign key (IdCabecera,IdEmpresa)references ActivoFijo.VentaGarageCab,
	--foreign key (IdBajaActivo) references ActivoFijo.BajaActivo,
	foreign key (IdEmpresa, IdCabeceraComprobante) references Contabilidad.CabeceraComprobante,
)
go



/******************COMPRAS************************/
CREATE TABLE Compras.MotivoDevolucion  --ok
(
	 idMotivo    				int   NOT NULL,
	 Descripcion    			int   NOT NULL,
	primary key(IdMotivo)
)
GO

/*
CREATE TABLE Compras.TipoOrdenCompra  -- tabla sin usar no borrar
( 
	 idTipoOrden    int  NOT NULL,
	 descripcion    varchar  (10) NULL,
	primary key(idTipoOrden)
)
GO
*/

CREATE TABLE Compras.OrdenCompraDet  --ok
(
	 Numero    				int   NOT NULL,
	 IdEmpresa    			int   NOT NULL,
	 Linea    				int   NOT NULL,
	 IdArticulo				int  NOT NULL,
	 Cantidad				int   NOT NULL,
	 Precio					int   NOT NULL,
	foreign key (Numero, IdEmpresa) references Compras.OrdenCompra,
	foreign key(IdArticulo,IdEmpresa)references Inventario.Articulo,
	primary key(Numero,IdEmpresa,Linea)	
)
 

GO

CREATE TABLE Compras.DevolucionCompra  --ok
(
	Numero				int   NOT NULL,
	idEmpresa			int   NOT NULL,
    IdUsuario			int   NOT NULL,
	idProveedor			int   NOT NULL,
--	idEmpleado			int   NOT NULL,
	NumeroFactura		int   NOT NULL, -- no es clave foranea
    Fecha				date  NOT NULL Default Getdate(),
    FechaModificacion	date  NOT NULL Default Getdate(),
	idEstado			int   NOT NULL,
 	foreign key(IdEmpresa)references Seguridad.Empresa,
    foreign key(IdUsuario)references Seguridad.Usuario,
 	foreign key (IdEstado) references Compras.Estado,
	foreign key (idProveedor) references Compras.Proveedor,
--	foreign key (idEmpleado,IdEmpresa) references RecursosHumanos.Empleado,
	primary key(Numero,IdEmpresa)
)
go

CREATE TABLE Compras.DevolucionCompraDet  --OK
(
	Numero    				int   NOT NULL,
	IdEmpresa    			int   NOT NULL,
	Linea    				int   NOT NULL,
	idArticulo    			int   NOT NULL,
	Cantidad    			int   NOT NULL,
	idMotivo    			int   NOT NULL,
	Obervaciones 			varchar  (300),
	Foreign Key (Numero,IdEmpresa) references Compras.DevolucionCompra,
 	foreign key (idArticulo,IdEmpresa)references Inventario.Articulo,
 	foreign key (idMotivo)references Compras.MotivoDevolucion,
 	primary key(Numero,IdEmpresa,Linea)
)
go	

CREATE TABLE Compras.OrdenDespacho --ok 
(
	Numero						int   NOT NULL,
	idEmpresa					int   NOT NULL,
    idUsuario					int   NOT NULL,
    idDepartamento 				int   not null,
--	idEmpleado					int   NOT NULL,
	Fecha						date  NOT NULL Default Getdate() ,
    FechaModificacion			date  NOT NULL Default Getdate(),
	idEstado					int   NOT NULL,
	foreign key(IdEmpresa)references Seguridad.Empresa,
    foreign key(IdUsuario)references Seguridad.Usuario,
 	foreign key (IdEstado) references Compras.Estado,
--	foreign key (idEmpleado,IdEmpresa) references RecursosHumanos.Empleado,
	foreign key (idDepartamento) references RecursosHumanos.Departamento,
	primary key(Numero,IdEmpresa)
 )
GO

CREATE TABLE Compras.OrdenDespachoDet  --ok
(
	Numero    					int   NOT NULL,
	idEmpresa    				int   NOT NULL,
	Linea    					int   NOT NULL,
	idArticulo    				int   NOT NULL,
	Cantidad    				int   NOT NULL,
	foreign key(Numero,IdEmpresa)references Compras.OrdenDespacho,
	foreign key (idArticulo,IdEmpresa) references Inventario.Articulo,
	primary key(Numero,IdEmpresa,Linea)
)
GO
CREATE TABLE Compras.Solicitud  --ok
(
	Numero			int		NOT NULL,
	idEmpresa		int		NOT NULL,
	IdTipoArticulo	int		NOT NULL,
    IdUsuario		int		NOT NULL,
	idDepartamento	int		NOT NULL,
	Fecha			date	NOT NULL Default Getdate(),
    FechaModificacion date  NOT NULL Default Getdate(),
	idEstado		int   NOT NULL,
	foreign key(IdEmpresa)references Seguridad.Empresa,
    foreign key(IdUsuario)references Seguridad.Usuario,
	foreign key (IdEstado) references Compras.Estado,
	foreign key (idTipoArticulo) references Inventario.TipoArticulo,
	primary key(Numero,IdEmpresa)
	--select * from Inventario.TipoArticulo
)
GO


CREATE TABLE Compras.SolicitudDet  --ok
(
	Numero		int   NOT NULL,
	idEmpresa   int   NOT NULL,
	Linea		int   NOT NULL,
	idArticulo  int   NOT NULL,
	Cantidad    int   NOT NULL,
	foreign key (Numero, IdEmpresa) references Compras.Solicitud,
	foreign key (idArticulo,IdEmpresa) references Inventario.Articulo,
	primary key(Numero,IdEmpresa,Linea)
 )
GO
CREATE TABLE Compras.Pedido --ok 
(
	Numero			int		NOT NULL,
	idEmpresa		int		NOT NULL, 
    idUsuario		int		NOT NULL,
    idTipoArticulo  int     not null,
	--idDepartamento	int		NOT NULL,
	Fecha			date	NOT NULL Default Getdate(),
    FechaModificacion date  NOT NULL Default Getdate(),
	idEstado		int		NOT NULL,
 	foreign key(IdEmpresa)references Seguridad.Empresa,
    foreign key(IdUsuario)references Seguridad.Usuario,
    foreign key (idTipoArticulo) references inventario.tipoArticulo,
 	foreign key (IdEstado) references Compras.Estado,
	--foreign key (idDepartamento) references RecursosHumanos.Departamento,	
	primary key(Numero,IdEmpresa)
)
GO

CREATE TABLE Compras.PedidoDet  --ok
(
	Numero		int   NOT NULL,
	idEmpresa	int   NOT NULL,
	Linea		int   NOT NULL,
	idArticulo	int   NOT NULL,
	Cantidad	int   NOT NULL,
 	foreign key (Numero, IdEmpresa)references Compras.Pedido,
 	foreign key (idArticulo,IdEmpresa) references Inventario.Articulo,
	primary key(Numero,IdEmpresa,Linea)
) 
go
 
CREATE TABLE Compras.CotizacionDet  --ok
(
	Numero		int   NOT NULL,
	idEmpresa   int   NOT NULL,
	Linea		int   NOT NULL,
	NumeroPedido int   NOT NULL,
 	foreign key(IdEmpresa)references Seguridad.Empresa,
	foreign key (NumeroPedido,IdEmpresa) references Compras.Pedido,	
	primary key(Numero,IdEmpresa)
)
go

Create table Compras.NotaDebito
(
	Numero					int		not null,
	idEmpresa				int		not null,
	NumeroDevolucionCompra	int		not null,
	Fecha			date	NOT NULL Default Getdate(),
    FechaModificacion date  NOT NULL Default Getdate(),
	SubTotal				int		not null,
	Descuento				int		not null,
	idEstado				int		not null
	foreign key (idEmpresa)	references Seguridad.Empresa,
	foreign key (NumeroDevolucionCompra, idEmpresa) references Compras.DevolucionCompra,
	foreign key (idEstado) references Compras.Estado,
	primary key (Numero, idEmpresa)
	
)
go
Create table Compras.NotaDebitoDet
(
	Numero					int		not null,
	idEmpresa				int		not null,
	Linea					int		not null,
	idArticulo				int		not null,
	Cantidad				int		not null
	
	foreign key (Numero,idEmpresa) references Compras.NotaDebito,
	primary key (Numero, idEmpresa,Linea)		

)
go

PRINT 'De Compras: Listo las tablas notadebito y compras, Actualizacion de Tablas, no afectan otros modulos.'

/**************************TALLER************************/

--PERSONA
create table Taller.Persona
(
IdPersona			 int not null primary key,
Identificacion       varchar(14) not null unique,
IdTipoPersona        int  NOT NULL ,
NombreRazonSocial    varchar(50)  NOT NULL ,
Apellido             varchar(50)  NOT NULL ,
FechaNacimiento      date  NOT NULL ,
Genero				 varchar(10)not null,
TipoIdentificacion   int  NOT NULL ,
Direccion            varchar(100)  NOT NULL ,
Telefono             varchar(10) not null,
Mail                 varchar(50)  NOT NULL ,
IdEstado             int  NOT NULL ,
IdEmpresa            int  NOT NULL ,
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdTipoPersona)references RecursosHumanos.TipoPersona,
foreign key (TipoIdentificacion)references RecursosHumanos.TipoIdentificacion
)
go





--ARTICULO
create table Taller.Articulo(
IdEmpresa		int not null,
IdArticulo		int not null primary key,
IdPersona		int,
Descripcion		varchar(100) not null,
FechaProduccion date,
CantidadMinima	numeric(5,0),
CantidadMaxima	numeric(5,0),
CantidadActual	numeric(5,0),
IdUnidadMedida	int,
IdGrupo			int not null,
IdChasis		int, 
IdTipoMotor		int,
NroPlaca		varchar(8) null,
IdTipoCombustible int,
IdColor			int,
IdMarca			int,
IdModelo		int,
IdTipoMaterial	int,
PrecioUnitario  decimal(18,2),
Observacion		varchar(100),
IdUsuario		int,
IdEstado		int,
foreign key (IdEmpresa)references Seguridad.Empresa,
foreign key (IdPersona)references Taller.Persona,
foreign key(IdEstado)references Seguridad.Estado,
foreign key(IdEmpresa)references Seguridad.Empresa,
foreign key(IdUnidadMedida)references Inventario.UnidadMedida,
foreign key (IdGrupo)references Inventario.Grupo,
foreign key (IdChasis)references Inventario.Chasis,
foreign key (IdTipoMotor)references Inventario.TipoMotor,
foreign key (IdTipoCombustible)references Inventario.TipoCombustible,
foreign key (IdColor)references Inventario.Color,
foreign key (IdMarca)references Inventario.Marca,
foreign key (IdModelo)references Inventario.Modelo,
foreign key (IdTipoMaterial)references Inventario.TipoMaterial
)
go




--PRESUPUESTO
CREATE TABLE Taller.Presupuesto
( 
	IdPresupuesto        int  not null primary key,
	IdPersona            int  not null,
	IdArticulo			 int  not null,
	Fecha                date  not null,
	TotalTiempoTrabajo   int  not null,
	Iva                  decimal(18,2) not null,
	Subtotal             decimal(18,2) not null,
	TotalPresupuesto     decimal(18,2) not null,
	Observacion          varchar(100) not null,
	IdEstado 	     int not null,
	IdEmpresa		 int  not null,
	foreign key (IdEmpresa)references Seguridad.Empresa,
	foreign key (IdEstado)references Seguridad.Estado,
	foreign key(IdPersona)references Taller.Persona, 
	foreign key(IdArticulo)references Taller.Articulo, 
)
go


--TIPO DE TRABAJO
CREATE TABLE Taller.TipoTrabajo
( 
	IdTipoTrabajo        int  not null primary key,
	Descripcion          varchar(50)  not null,
	Observación			 varchar(100)  not null, 
	IdEstado 			 int not null,
	foreign key (IdEstado)references Seguridad.Estado
)
go


--ORDEN TRABAJO
CREATE TABLE Taller.OrdenTrabajo
( 
	IdOrdenTrabajo       int  not null primary key,
	IdPresupuesto        int  not null,
	IdPersona			 int  not null,
	IdArticulo			 int  not null,
	Kilometraje			 int  not null,
	Deposito			 int  not null,
	FechaRecepcion       date  not null,
	InicioReparacion     date  not null,
	FechaIngreso	     datetime  not null,
	FechaEntrega		 date  not null,
	TotalTrabajos 	     decimal(18,2) not null,
	TotalRepuestos 	     decimal(18,2) not null,
	TotalOtros 	         decimal(18,2) not null,
	Observacion			 varchar(100), 
	IdEstado 	         int not null,
	IdEmpresa		     int  not null,
	foreign key(IdEstado)references Seguridad.Estado,
	foreign key (IdEmpresa)references Seguridad.Empresa,
	foreign key(IdPresupuesto)references Taller.Presupuesto,
	foreign key(IdPersona)references Taller.Persona,
	foreign key(IdArticulo)references Taller.Articulo
)
go


--MANO DE OBRA
CREATE TABLE Taller.ManoObra
( 
	IdManoObra       int  not null primary key,
	IdTipoTrabajo    int  not null,
	PrecioHora		 decimal(18,2) not null,
	Horas			 int  not null,
	Total			 decimal(18,2) not null,
	Observacion      varchar(100),
	IdEstado 	     int  not null,
	IdEmpresa		 int  not null,
	foreign key (IdEstado)references Seguridad.Estado,
	foreign key (IdEmpresa)references Seguridad.Empresa,
	foreign key (IdTipoTrabajo)references Taller.TipoTrabajo
)
go


--PRESUPUESTO POR MANO DE OBRA
CREATE TABLE Taller.PresupuestoxManoObra
( 
	IdPresupuestoMO       int  not null primary key,
    IdPresupuesto    int  not null,
	IdManoObra       int  not null,
	IdTrabajo		 int  not null,
	PrecioHora		 decimal(18,2) not null,
	Horas			 int  not null,
	Total			 decimal(18,2) not null,
	foreign key (IdPresupuesto)references Taller.Presupuesto,
	foreign key (IdManoObra)references Taller.ManoObra
)
go



--REPUESTOS
CREATE TABLE Taller.Repuestos
( 
	IdRepuestos      int  not null primary key,
	IdArticulo		 int  not null,
	IdOrdenTrabajo   int  not null,
	Cantidad	     int  not null,
	PrecioUnitario	 decimal(18,2) not null,
	Total			 decimal(18,2) not null,
	foreign key (IdOrdenTrabajo)references Taller.OrdenTrabajo,
	foreign key(IdArticulo)references Taller.Articulo
)
go


--Otros
CREATE TABLE Taller.Otros
( 
	IdOtros      int  not null primary key,
	IdOrdenTrabajo   int  not null,
	Descripcion      varchar(100)  not null,
	Precio			 decimal(18,2) not null,
	foreign key (IdOrdenTrabajo)references Taller.OrdenTrabajo
)
go


--SALIDA VEHICULO
CREATE TABLE Taller.Liquidacion
( 
	IdLiquidacion     int  not null primary key,
	IdOrdenTrabajo    int  not null,
	Fecha             date not null,	
	TotalPagar		  decimal(18,2) not null,
	Observacion       varchar(100),
	IdEstado 	      int not null, 
	IdEmpresa		  int  not null,
	foreign key(IdEstado)references Seguridad.Estado,
	foreign key (IdEmpresa)references Seguridad.Empresa,
	foreign key(IdOrdenTrabajo)references Taller.OrdenTrabajo
)
go

/*************contabilidad***************/
create table Contabilidad.SaldoxComprobante(
IdEmpresa	int,
numero_comprobante	numeric(4, 0),
primary key (IdEmpresa,numero_comprobante)
)


-- de aqui en adelante sera para creacion de vistas, stored procedures, etc
-- siempre y cuando no afecten la integridad funcional de este script
PRINT N'3.creando vistas'
--SEGURIDAD
go
create view Seguridad.UsuariodPermisos as
SELECT distinct ROW_NUMBER() OVER(ORDER BY Seguridad.Usuario.IdUsuario) AS id,Seguridad.Usuario.IdUsuario, Seguridad.Usuario.NombreUsuario, Seguridad.Perfil.Descripcion, Seguridad.Modulo.IdModulo, Seguridad.Modulo.Nombre, Seguridad.Menu.NombreFormulario, 
                      Seguridad.Permiso.Lectura, Seguridad.Permiso.Escritura, Seguridad.Permiso.Eliminacion
FROM         Seguridad.Perfil INNER JOIN
                      Seguridad.Permiso ON Seguridad.Perfil.IdPerfil = Seguridad.Permiso.IdPerfil INNER JOIN
                      Seguridad.Modulo ON Seguridad.Permiso.IdModulo = Seguridad.Modulo.IdModulo INNER JOIN
                      Seguridad.Menu ON Seguridad.Permiso.IdMenu = Seguridad.Menu.IdMenu AND Seguridad.Modulo.IdModulo = Seguridad.Menu.IdModulo INNER JOIN
                      Seguridad.Usuario ON Seguridad.Perfil.IdPerfil = Seguridad.Usuario.IdPerfil
go   

create view Seguridad.UsuarioInformacion as
SELECT distinct usu.IdUsuario, usu.NombreUsuario, usu.Contrasena, usu.IdEstado, est.Descripcion, emp.IdEmpresa, emp.NombreComercial,
					emp.RazonSocial, emp.Ruc
FROM Seguridad.Usuario usu, Seguridad.Empresa emp, Seguridad.UsuarioPorEmpresa uxe, Seguridad.Estado est
WHERE uxe.IdEmpresa = emp.IdEmpresa
AND uxe.IdUsuario = usu.IdUsuario
AND usu.IdEstado = est.IdEstado
go
                 
-- view in disuse
--create view Menu_X_Usuario as
--SELECT     e.IdEmpresa, a.NombreUsuario, a.Contrasena, d.IdMenu, d.IdModulo, d.IdPadre, d.Descripcion, d.NombreFormulario, d.NombreAssembly, d.IdEstado, c.IdPerfil, c.IdPermiso, c.IdMenu AS Expr1, 
--                      c.IdModulo AS Expr2, c.Lectura, c.Escritura, c.Eliminacion
--FROM         Seguridad.Usuario AS a INNER JOIN
--                      Seguridad.Perfil AS b ON a.IdPerfil = b.IdPerfil INNER JOIN
--                      Seguridad.Permiso AS c ON a.IdPerfil = c.IdPerfil AND b.IdPerfil = b.IdPerfil INNER JOIN
--                      Seguridad.Menu AS d ON c.IdMenu = d.IdMenu INNER JOIN
--                      Seguridad.MenuPorEmpresa AS e ON e.IdMenu = c.IdMenu AND e.IdMenu = d.IdMenu                      
--go

--fix by castro
create view Menu_X_Usuario as
select e.IdEmpresa, a.NombreUsuario, a.Contrasena, d.IdMenu, d.IdModulo, d.IdPadre, d.Descripcion, d.NombreFormulario, d.NombreAssembly, d.IdEstado, c.IdPerfil, 
                      c.IdPermiso, c.IdMenu AS Expr1, c.IdModulo AS Expr2, c.Lectura, c.Escritura, c.Eliminacion
from		Seguridad.Usuario a inner join 
			Seguridad.Perfil b on a.IdPerfil = b.IdPerfil inner join 
			Seguridad.Permiso c on a.IdPerfil = c.IdPerfil and b.IdPerfil = b.IdPerfil inner join 
			Seguridad.Menu d on c.IdMenu = d.IdMenu inner join
			Seguridad.UsuarioPorEmpresa e on e.IdUsuario = a.IdUsuario
go

/***************************COMPRAS****************************/
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

/********************CONTABILIDAD*****************************/
create view Contabilidad.vwCuenta as
SELECT        Contabilidad.Cuenta.IdEmpresa, Contabilidad.Cuenta.IdCuenta, Contabilidad.Cuenta.codigo_padre, Contabilidad.Cuenta.nombre, 
                         Contabilidad.Cuenta.descripcion, Contabilidad.Cuenta.IdNivelCuenta, Contabilidad.Cuenta.IdTipoCuenta, Contabilidad.Cuenta.naturaleza_cuenta, 
                         Contabilidad.Cuenta.IdUsuario, Contabilidad.Cuenta.FechaModificacion, Contabilidad.NivelCuenta.digitos
FROM            Contabilidad.Cuenta INNER JOIN
                         Contabilidad.NivelCuenta ON Contabilidad.Cuenta.IdNivelCuenta + 1 = Contabilidad.NivelCuenta.IdNivelCuenta
go

create view Contabilidad.vwTipoTransaccion as
SELECT     Contabilidad.TipoTransaccion.IdTransaccion, Contabilidad.TipoTransaccion.modulo, Contabilidad.TipoTransaccion.TipoDocumento, Contabilidad.TipoTransaccion.descripcion, 
                      Seguridad.Modulo.Nombre AS NombreModulo
FROM         Contabilidad.TipoTransaccion INNER JOIN
                      Seguridad.Modulo ON Contabilidad.TipoTransaccion.modulo = Seguridad.Modulo.IdModulo
go


create view Contabilidad.vwComprobanteMayorizar as                       
SELECT     Contabilidad.CabeceraComprobante.IdEmpresa, Contabilidad.CabeceraComprobante.fecha, Contabilidad.CabeceraComprobante.numero_comprobante, Contabilidad.CabeceraComprobante.glosa, 
                      SUM(Contabilidad.DetalleComprobante.haber) AS haber, SUM(Contabilidad.DetalleComprobante.debe) AS debe, Contabilidad.SaldoxComprobante.numero_comprobante AS Expr1
FROM         Contabilidad.CabeceraComprobante INNER JOIN
                      Contabilidad.DetalleComprobante ON Contabilidad.CabeceraComprobante.IdEmpresa = Contabilidad.DetalleComprobante.IdEmpresa AND 
                      Contabilidad.CabeceraComprobante.numero_comprobante = Contabilidad.DetalleComprobante.cabecera_comprobante LEFT OUTER JOIN
                      Contabilidad.SaldoxComprobante ON Contabilidad.CabeceraComprobante.IdEmpresa = Contabilidad.SaldoxComprobante.IdEmpresa AND 
                      Contabilidad.CabeceraComprobante.numero_comprobante = Contabilidad.SaldoxComprobante.numero_comprobante
GROUP BY Contabilidad.CabeceraComprobante.numero_comprobante, Contabilidad.CabeceraComprobante.fecha, Contabilidad.CabeceraComprobante.IdEmpresa, Contabilidad.CabeceraComprobante.glosa, 
                      Contabilidad.SaldoxComprobante.numero_comprobante
HAVING      (Contabilidad.SaldoxComprobante.numero_comprobante IS NULL)
go