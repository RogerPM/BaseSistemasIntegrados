use master
go
drop database TECAv8
Create Database TECAv8
go
--crear los esquemas respectivos para cada Modulo
use TECAv8  
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

--crear las tablas y añadirlas al esquema de su repectivo modulo

create table  Seguridad.Estado
(
	 IdEstado   int primary key,
	 Descripcion   varchar(220)
) 
go

create table  Seguridad.TipoImagen
(
	 IdTipoImagen   int primary key,
	 Descripcion   varchar(50)
) 
go

create table  Seguridad.Imagen
(
	 IdImagen   int primary key,
	 Descripcion   varchar(50),
	 Imagen image,
	 IdTipoImagen int references Seguridad.TipoImagen --E agregado sintaxis
)
go

create table Seguridad.Empresa
(
	 IdEmpresa    int   primary key,
	 RazonSocial    varchar  (50) NOT NULL,
	 NombreComercial    varchar  (50) NOT NULL,
	 Ruc    int NOT NULL,
	 Direccion varchar(200) ,
	 IdImagen	int not null,
	 Logo    varchar(50)   NULL,
	 Fondo    varchar(50)   NULL,
	 FechaInicioSistema    datetime   NOT NULL,
	 IdCorreo int,
	 SitioWeb varchar(50),
	 IdEstado int references Seguridad.Estado --E agregado	 
)
go


/**************************Recursos humanos******************************
************************************************************************/
/*TIPO PERSONA*/
create table RecursosHumanos.TipoPersona
(
IdTipoPersona int not null primary key,
Descripcion varchar(50) not null,
IdEmpresa int not null,
IdEstado int not null,
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado
)
go


/*PERSONA*/
create table RecursosHumanos.Persona
(
Identificacion int not null primary key,
IdTipoPersona int not null,
NombreRazonSocial varchar(100) not null,
Apellido varchar(50),
FechaNacimiento datetime null,
genero varchar(10)not null,
TipoIdentificacion varchar (11) not null,
dirección varchar (100) not null,
telefono int not null,
mail varchar (50) not null,
IdEmpresa int not null,
IdEstado int not null,
Foto image null,
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdTipoPersona)references RecursosHumanos.TipoPersona
)
go

/*TIPO IDENTIFICACION*/
create table RecursosHumanos.TipoIdentificacion
(
IdTipoIdentificacion int not null primary key,
descripcion varchar (50) not null,
IdEmpresa int not null,
IdEstado int not null,
IdPersona int not null,
foreign key (IdPersona) references RecursosHumanos.Persona,
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado
)
go

/*CLIENTE*/
create table RecursosHumanos.Cliente
(
IdCliente int not null primary key,
IdPersona int not null,
IdEmpresa int not null,
IdEstado int not null,
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdPersona) references RecursosHumanos.Persona
)
go


/*EMPLEADO*/
create table RecursosHumanos.Empleado
(
IdEmpresa int not null,
IdEmpleado int not null,
IdPersona int not null,
IdEstado int not null,
Sueldo money not null,
primary key (IdEmpresa,IdPersona),
foreign key (IdEstado)references Seguridad.Estado,
foreign key (IdEmpresa)references Seguridad.Empresa,
foreign key (IdPersona)references RecursosHumanos.Persona
)
go

/*MATERNIDAD*/
create table RecursosHumanos.Maternidad
(
NumMaternidad int not null primary key,
IdEmpleado int not null,
IdEmpresa int not null,
FechaParto datetime not null,
FechaInicio datetime not null,
FechaFin datetime not null,
FechaModificacion datetime,
IdEstado int not null,
foreign key (IdEstado)references Seguridad.Estado,
foreign key (IdEmpleado,IdEmpresa)references RecursosHumanos.Empleado
)
go

/*DEPARTAMENTO*/
create table RecursosHumanos.Departamento
(
IdDepartamento int not null primary key,
Descripcion varchar(50)not null,
IdEstado int not null,
foreign key (IdEstado) references Seguridad.Estado,
)
go

/*USUARIO*/
create table Seguridad.Usuario
(
	 IdUsuario    int references RecursosHumanos.Persona,
	 NombreUsuario varchar(20),
	 Contrasena    varchar  (20) NULL,
	 IdEstado    int NULL references Seguridad.Estado,
	 IdImagen int references Seguridad.Imagen,
	 IdPerfil int,
	 primary key(IdUsuario)
)
go

/*PROVEEDOR*/
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
IdCurso int not null primary key,
IdEmpresa int not null, 
FechaInicio date not null,
FechaFinal date not null,
foreign key (IdEmpresa)references Seguridad.Empresa
)
go

/*UNIVERSIDAD*/
create table RecursosHumanos.Universidad
(
IdUniversidad int not null primary key,
IdEmpresa int not null, 
Nombre varchar(30) not null,
foreign key (IdEmpresa)references Seguridad.Empresa
)
go

/*PERSONAxCURSO*/
create table RecursosHumanos.PersonaxCurso
(
IdPersonaxCurso int not null primary key,
IdPersona int not null,
IdEmpresa int not null,
IdCurso int not null,
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdPersona)references RecursosHumanos.Persona,
foreign key (IdCurso)references RecursosHumanos.Curso
)
go

/*TIPO TELEFONO*/
create table RecursosHumanos.TipoTelefono
(
IdTipoTelefono int not null primary key,
Descripcion varchar(30) not null,
IdEmpresa int not null,
IdEstado int not null,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdEmpresa) references Seguridad.Empresa
)
go

/*TELEFONO*/
create table RecursosHumanos.Telefono
(
IdTelefono int not null primary key,
Numero int not null,
IdTipoTelefono int not null,
foreign key (IdTipoTelefono) references RecursosHumanos.TipoTelefono
)
go

/*Telefono por persona*/
create table RecursosHumanos.TelefonoPersona
(
IdPersona int references RecursosHumanos.Persona,
IdTelefono int references RecursosHumanos.Telefono,
primary key (Idpersona,Idtelefono)
)

/*TITULO*/
create table RecursosHumanos.Titulo
(
IdTitulo int not null primary key,
Nombre varchar(50),
FechaInicio date not null,
FechaFinal date not null,
IdEstado int not null,
IdUniversidad int not null,
IdEmpresa int not null,
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdUniversidad)references RecursosHumanos.Universidad,
foreign key (IdEstado)references Seguridad.Estado
)
go

/*TIPO JORNADA*/
create Table RecursosHumanos.TipoJornada
(
IdTipoJornada int not null primary key,
Descripcion varchar(45),
IdEmpresa int not null,
foreign key (IdEmpresa) references Seguridad.Empresa
)
go

/*JORNADA*/
create table RecursosHumanos.Jornada
(
IdJornada int not null primary key,
Fecha datetime not null,
FechaModificacion datetime,
HoraInicio time not null,
HoraFinal time not null,
IdEmpresa int not null,
IdTipoJornada int not null,
IdPersona int not null,
foreign key (IdTipoJornada) references RecursosHumanos.TipoJornada,
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdPersona) references RecursosHumanos.Persona
)
go

/*MULTA*/
create table RecursosHumanos.Multa
(
IdMulta int not null primary key,
Descripcion varchar(45),
Porcentaje float not null,
IdEmpresa int not null,
IdEstado int not null,
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado
)
go

/*MULTAxPERSONA*/
create table RecursosHumanos.MultaxPersona
(
IdPersona int not null,
IdMulta int not null,
FechaEmision date not null,
FechaModificacion datetime,
IdEmpresa int not null,
IdEstado int not null,
primary key (idpersona,idmulta),
foreign key (IdMulta) references RecursosHumanos.Multa,
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdPersona) references RecursosHumanos.Persona
)
go

/*PERSONAxDEPARTAMENTO*/
create table RecursosHumanos.PersonaxDepartamento
(
IdEmpresa int not null, 
IdPersona int not null,
IdDepartamento int not null,
IdEstado int not null,
primary key (idpersona,iddepartamento),
foreign key (IdDepartamento) references RecursosHumanos.Departamento,
foreign key (IdEmpresa)references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdPersona) references RecursosHumanos.Persona
)
go

/*CARGO*/
create table RecursosHumanos.Cargo
(
IdCargo int not null primary key,
Descripcion varchar(45) not null,
Sueldo float not null,
IdEstado int not null,
foreign key (IdEstado) references Seguridad.Estado
)
go

/*CARGOxDEPARTAMENTO*/
create table RecursosHumanos.CargoxDepartamento
(
IdDepartamento int not null,
IdCargo int not null,
FechaCreacion date not null,
FechaModificacion datetime,
IdEstado int not null,
primary key (idCargo,idDepartamento),
foreign key (IdCargo) references RecursosHumanos.Cargo,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdDepartamento) references RecursosHumanos.Departamento
)
go

/*RUBRO*/
create table RecursosHumanos.Rubro
(
IdRubro int not null primary key,
Descripcion varchar(45) not null,
Porcentaje float not null,
IdEstado int not null,
IdEmpresa int not null,
IdCargo int not null,
IdDepartamento int not null,
foreign key (IdCargo,IdDepartamento) references RecursosHumanos.CargoxDepartamento,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdEmpresa) references Seguridad.Empresa
)
go

/*PERSONAxTITULO*/
create table RecursosHumanos.PersonaxTitulo
(
IdTitulo int not null,
IdEmpresa int not null,
IdPersona int not null,
IdEstado int not null,
primary key (idpersona,idtitulo),
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdTitulo) references RecursosHumanos.Titulo,
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdPersona) references RecursosHumanos.Persona
)
go

/*PERSONAxCARGO*/
create table RecursosHumanos.PersonaxCargo
(
IdPersona int not null,
IdEmpresa int not null,
IdCargo int not null,
FechaModificacion datetime,
IdEstado int not null,
primary key (idPersona,IdCargo),
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdPersona) references RecursosHumanos.Persona,
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (Idcargo) references RecursosHumanos.Cargo
)
go

/*PARENTESCO*/
create  table RecursosHumanos.Parentesco
(
IdParentesco int not null primary key,
Descripcion varchar(50) not null,
IdEmpresa int not null,
IdEstado int not null,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdEmpresa) references Seguridad.Empresa
)
go

/*CARGA FAMILIAR*/
create table RecursosHumanos.CargaFamiliar
(
IdPersona int not null,
IdParentesco int not null,
IdEmpresa int not null,
FechaNacimiento date not null,
FechaRegistro date not null,
FechaModificacion datetime,
IdEstado int not null,
primary key (idpersona,idparentesco),
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdPersona) references RecursosHumanos.Persona,
foreign key (IdParentesco) references RecursosHumanos.Parentesco
)
go

/*ANTICIPO CABECERA*/
create table RecursosHumanos.AnticipoCab
(
NumAnticipo int not null,
IdEmpleado int not null,
Fecha date not null,
FechaModificacion datetime,
Total numeric(10,2) not null,
Observacion varchar(50) null,
IdEmpresa int not null,
IdEstado int not null,
foreign key (IdEmpleado,idempresa) references RecursosHumanos.Empleado,
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
primary key (NumAnticipo, IdEmpresa)
)
go

/*ANTICIPO DETALLE*/
create table RecursosHumanos.AnticipoDet
(
NumLinea int not null,
NumAnticipo int not null,
FechaCobro date not null,
FechaModificacion datetime,
IdEmpresa int not null references Seguridad.Empresa,
foreign key (NumAnticipo, IdEmpresa) references RecursosHumanos.AnticipoCab,
primary key (NumLinea,IdEmpresa)
)
go

/*BENEFICIOS*/
create table RecursosHumanos.Beneficios
(
IdBeneficios int not null primary key,
Descripcion varchar(50) not null,
Porcentaje numeric(10,2) not null,
IdEmpresa int not null,
foreign key (IdEmpresa)references Seguridad.Empresa
)
go

/*NOMINA CABECERA*/
create table RecursosHumanos.NominaCab
(
NumNomina int not null,
FechaEmision date not null,
FechaModificacion datetime,
Total numeric(10,2) not null,
IdEmpleado int not null,
IdEstado int not null,
IdEmpresa int not null,
Observacion varchar(50) null,
foreign key (IdEmpleado,idempresa) references RecursosHumanos.Empleado,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdEmpresa) references Seguridad.Empresa,
primary key (NumNomina, IdEmpresa)
)
go

/*NOMINA DETALLE*/
create table RecursosHumanos.NominaDet
(
NumLinea int not null,
NumNomina int not null,
IdBeneficios int not null,
IdMulta int not null,
IdEmpresa int not null,
foreign key (IdMulta) references RecursosHumanos.Multa,
foreign key (IdBeneficios) references RecursosHumanos.Beneficios,
foreign key (NumNomina,IdEmpresa)references RecursosHumanos.NominaCab,
primary key (NumLinea, IdEmpresa)
)
go

/*TIPO CONTRATO*/
create table RecursosHumanos.TipoContrato
(
IdTipoContrato int not null primary key,
Descripcion varchar(50) not null,
IdEmpresa int not null,
IdEstado int not null,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdEmpresa) references Seguridad.Empresa
)
go

/*CONTRATO*/
create table RecursosHumanos.Contrato
(
NumContrato int not null,
IdPersona int not null,
IdTipoContrato int not null,
IdCargo int not null,
IdEmpresa int not null,
Fecha date not null,
FechaModificacion datetime,
Remuneracion numeric(10,2) not null,
IdJornada int not null,
PeriodoPrueba bit not null,
IdEstado int not null,
primary key (IdPersona,NumContrato,idEmpresa),
foreign key (IdEstado) references Seguridad.Estado,
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
IdTipoPermiso int not null primary key,
Descripcion varchar(50) not null,
IdEmpresa int not null,
IdEstado int not null,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdEmpresa) references Seguridad.Empresa
)
go

/*PERMISO*/
create table RecursosHumanos.Permiso
(
NumPermiso int not null primary key,
IdUsuario int not null,
IdEmpleado int not null,
IdTipoPermiso int not null,
FechaInicio datetime not null,
FechaFinal datetime not null,
FechaModificacion datetime,
IdEstado int not null,
IdEmpresa int not null,
foreign key (IdUsuario) references Seguridad.Usuario,
foreign key (IdEmpleado,idempresa) references RecursosHumanos.Empleado,
foreign key (IdTipoPermiso) references RecursosHumanos.TipoPermiso,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdEmpresa) references Seguridad.Empresa
)
go

/*LIQUIDACION*/
create table RecursosHumanos.Liquidacion
(
NumLiquidacion int not null,
IdPersona int not null,
NumContrato int not null,
IdEmpresa int not null,
Fecha datetime not null,
FechaModificacion datetime,
Causa varchar(150) not null,
FechaSalida datetime not null,
Ingresos numeric(10,2) not null,
Egresos numeric(10,2) not null,
Total numeric(10,2) not null,
IdEstado int not null,
primary key (NumLiquidacion,IdEmpresa,Idpersona),
foreign key (IdPersona,NumContrato,IdEmpresa) references RecursosHumanos.Contrato,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdPersona) references RecursosHumanos.persona,
foreign key (IdEmpresa) references Seguridad.Empresa,
)
go

/*VACACION*/
create table RecursosHumanos.Vacacion
(
NumVacacion int not null primary key,
IdEmpleado int not null,
FechaModificacion datetime,
FechaInicio date not null,
FechaFin date not null,
IdEmpresa int not null,
IdEstado int not null,
foreign key (IdEmpleado,idempresa) references RecursosHumanos.Empleado,
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado
)
go

/*TIPO PRESTAMO*/
create table RecursosHumanos.TipoPrestamo
(
IdTipoPrestamo int not null primary key,
Nombre varchar(50) not null,
IdEmpresa int not null,
IdEstado int not null,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdEmpresa) references Seguridad.Empresa
)
go

/*PRESTAMO*/
create table RecursosHumanos.Prestamo
(
IdPrestamo int not null primary key,
IdTipoPrestamo int not null,
IdPersona int not null,
FechaModificacion datetime,
Monto money not null,
Pago money not null,
IdEstado int not null,
IdEmpresa int not null,
foreign key (IdPersona) references RecursosHumanos.Persona,
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdTipoPrestamo) references RecursosHumanos.TipoPrestamo,
)
go



/*USUARIO POR EMPRESA*/
create table Seguridad.UsuarioPorEmpresa
(
	IdUsuario int,
	IdEmpresa int,
	foreign key(IdUsuario)references Seguridad.Usuario,
	foreign key(IdEmpresa)references Seguridad.Empresa,
	primary key(IdUsuario,IdEmpresa)
)
go

/*MODULO*/
create table  Seguridad.Modulo
(
	 IdModulo   int primary key,
	 Nombre   varchar(50),
	 IdEstado int,
	 Logo varchar(50)
) 
go

/*MENU*/
create table  Seguridad.Menu 
(
	 IdMenu   int  primary key,
	 IdModulo   int references Seguridad.Modulo  ,
	 IdPadre int,
	 Descripcion   varchar (255)  ,
	 NombreForm   varchar (255)  , 
	 NombreAssembly   varchar (200) , 
	 IdEstado int,
)
go

/*MENU POR EMPRESA*/
create table Seguridad.MenuPorEmpresa
(
	 IdEmpresa    int,
	 IdMenu    int,
	 IdEstado int references Seguridad.Estado,
	 NombreAsamblyPorEmpresa    varchar  (200),--E
	 NomFormularioPorEmpresa    varchar  (200), --E
	 foreign key(IdMenu)references Seguridad.Menu,
	 foreign key(IdEmpresa)references Seguridad.Empresa,
	 primary key(IdMenu,IdEmpresa)
)
go

/*PERFIL*/
create table Seguridad.Perfil 
(
	 IdPerfil   int primary key,
	 Descripcion   varchar (70),
	 IdEstado   int   ,   
)
go

/*PERMISO*/
create table Seguridad.Permiso
(
	 IdPerfil    int   primary key references Seguridad.Perfil,
	 IdPermiso    int NOT NULL, --secuencia
	 IdPersona int references Seguridad.Usuario,
	 IdEmpresa int references Seguridad.Empresa,
	 IdMenu int references Seguridad.Menu,
	 IdModulo int references Seguridad.Modulo,
	 Lectura    bit   NOT NULL,
	 Escritura    bit   NOT NULL,
	 Eliminacion    bit   NOT NULL
)
go

/*TELEFONO POR EMPRESA*/
create table  Seguridad.TelefonoEmpresa --E editada agregado
(
	IdEmpresa int references Seguridad.Empresa,
	idTelefono int references RecursosHumanos.Telefono,
	primary key(IdEmpresa,IdTelefono)
) 
go

/*************************************contabilidad***********************************/
create table Contabilidad.TipoCuenta
(
IdTipoCuenta numeric(2,0) primary key,
nombre varchar(20) not null
)
go
/*tabla de seguridad*/

create table Contabilidad.AnoFiscal
(
IdAnoFiscal numeric(4) primary key,
inicio_periodo date not null,
IdUsuario int,
FechaModificacion datetime,
)
go

create table Contabilidad.NivelCuenta
(
IdNivelCuenta numeric(2,0) primary key,
descripcion varchar(20),
digitos numeric(1) not null,
IdEstado int not null references Seguridad.Estado
)
go

create table Contabilidad.PeriodoContable
(
IdEmpresa int references Seguridad.Empresa,
IdPeriodoContable numeric(6),
IdAFiscal numeric(4) references Contabilidad.AnoFiscal,
FechaInicio date not null,
FechaFin date not null,
IdEstado int not null references Seguridad.Estado,
IdUsuario int not null references Seguridad.Usuario, --E agregado
FechaModificacion datetime,
foreign key (IdUsuario) references Seguridad.Usuario,
PRIMARY KEY(IdEmpresa,IdPeriodoContable,IdAFiscal)
)
go

create table Contabilidad.Cuenta
(
IdEmpresa int references Seguridad.Empresa,
IdCuenta varchar(50),
codigo_padre varchar(50), --E codigo_padre
nombre varchar(50) not null,
descripcion varchar(80) not null,
IdNivelCuenta numeric(2,0)not null references Contabilidad.NivelCuenta,
IdTipoCuenta numeric(2,0) not null references Contabilidad.TipoCuenta,
naturaleza_cuenta varchar(50) not null,
IdUsuario int not null references Seguridad.Usuario, --E agregado
FechaModificacion datetime,
foreign key (IdUsuario) references Seguridad.Usuario,
PRIMARY KEY(IdEmpresa, IdCuenta)
)
go

create table Contabilidad.CabeceraComprobante
(
IdEmpresa int ,
numero_comprobante numeric(4) ,
fecha date not null,
glosa varchar(50) not null,
periodo_contable numeric(6,0) ,
periodo_contable_IdAFiscal numeric(4,0),
IdUsuario int,
FechaModificacion datetime,
primary key(IdEmpresa, numero_comprobante),
foreign key(IdEmpresa,periodo_contable,periodo_contable_IdAFiscal) references Contabilidad.PeriodoContable,
foreign key(IdEmpresa) references Seguridad.Empresa
)
go

create table Contabilidad.DetalleComprobante
(
IdEmpresa int,
cabecera_comprobante numeric (4),
linea_comprobante numeric(2,0) not null,
cuenta varchar(50) not null,
debe decimal(14,2) not null,
haber decimal(14,2) not null,
foreign key (IdEmpresa)references Seguridad.Empresa,
foreign key (IdEmpresa,cuenta)references Contabilidad.Cuenta,
foreign key (IdEmpresa,cabecera_comprobante)references Contabilidad.CabeceraComprobante,
primary key (IdEmpresa,cabecera_comprobante, linea_comprobante)
)
go

create table Contabilidad.Saldo
(
IdEmpresa int,
cuenta varchar(50) not null,
fecha date,
saldo_deudor decimal(14,2) not null,
saldo_acreedor decimal(14,2) not null,
IdUsuario int,
FechaModificacion datetime,
foreign key (IdEmpresa)references Seguridad.Empresa,
foreign key (IdEmpresa,cuenta)references Contabilidad.Cuenta,
primary key (IdEmpresa,cuenta,fecha)
)
go

--modulo no es tabla de contabilidad segun la ruth

create table Contabilidad.TipoTransaccion
(
IdTransaccion int primary key,
modulo int references Seguridad.Modulo not null,
TipoDocumento varchar(50),
descripcion varchar(50) not null
)
go

create table Contabilidad.ModeloAsiento
(
IdEmpresa int references Seguridad.Empresa,
numero varchar(4),
IdTransaccion int references Contabilidad.TipoTransaccion,
descripcion varchar(50) not null,
debe varchar(50),
haber varchar(50),
IdUsuario int,
FechaModificacion datetime,
PRIMARY KEY(IdEmpresa,numero,IdTransaccion)
)
go

/*para integrar compras con inventario*/
CREATE TABLE Compras.Cotizacion  --ok
(
	 Numero    int   NOT NULL,
	 idEmpresa    int   NOT NULL,
     IdUsuario   int NOT NULL,
	 idProveedor    int   NOT NULL,
	 --NumeroPedido    int   NOT NULL,
	 Fecha date NOT NULL,
     FechaModificacion datetime NOT NULL,
	 idEstado    int   NOT NULL,
 	foreign key(IdEmpresa)references Seguridad.Empresa,
    foreign key(IdUsuario)references Seguridad.Usuario,
 	foreign key (IdEstado) references Seguridad.Estado,
	foreign key (idProveedor) references RecursosHumanos.Proveedor,	
	--foreign key (NumeroPedido) references Compras.Pedido,
	primary key(Numero,IdEmpresa)
)
 GO

CREATE TABLE Compras.OrdenCompra  --ok
(
	IdOrdenCompra		int		NOT NULL,
	idEmpresa			int		NOT NULL,
    IdUsuario			int		NOT NULL,
	Fecha				date	NOT NULL,
    FechaModificacion	datetime NOT NULL,
	idProveedor			int		NOT NULL,
    NumeroCotizacion    int		NOT NULL,
	idEstado			int   NOT NULL,
	Observaciones		varchar   (300),
	
	foreign key(IdEmpresa)references Seguridad.Empresa,
    foreign key(IdUsuario)references Seguridad.Usuario,
	foreign key (IdEstado) references Seguridad.Estado,
	foreign key(idProveedor)references RecursosHumanos.Proveedor,
	foreign key (idEmpresa,NumeroCotizacion) references Compras.Cotizacion,
	primary key(IdOrdenCompra,IdEmpresa)
)
GO

/********************************INVENTARIO************************/

create table Inventario.Bodega
(
IdEmpresa		int not null,
IdBodega		int not null,
Decripcion		varchar(100) not null,
Capacidad		numeric(5,0) not null,
IdResponsable		int not null,
Direccion		varchar(100),
Telefono		numeric(10,0),
Perchas			numeric(10,0),
IdEstado			int,
IdUsuario			int,
primary key (IdBodega, IdEmpresa),
foreign key (IdEmpresa) references Seguridad.Empresa,
--foreign key (IdTelefono) references RecursosHumanos.Telefono,
foreign key (IdResponsable) references RecursosHumanos.Persona,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdUsuario) references Seguridad.Usuario,
)
go

create table Inventario.IngresoEgresoCab
(
IdEmpresa			int not null,
NroMovimiento		int,
TipoMovimiento		char(1),
FechaMovimiento		date,
FechaModificacion datetime,
NroDocumento		numeric(10,0),
IdTransaccion		int,
TipoDocumento		numeric(10,0),
IdOrdenCompra		int,
IdBodega			int,
TotalPagar			numeric(7,2),
IdUsuario			int,
Observacion			varchar(150),
IdEstado			int,
primary key(IdEmpresa,NroMovimiento),
foreign key(IdOrdenCompra,IdEmpresa)references Compras.OrdenCompra,
foreign key(IdEstado)references Seguridad.Estado,
foreign key(IdTransaccion)references Contabilidad.TipoTransaccion,
foreign key(IdBodega,IdEmpresa)references Inventario.Bodega,
foreign key(IdUsuario)references Seguridad.Usuario
)
 go

create table Inventario.UnidadMedida
(
IdEmpresa			int,
IdUnidadMedida		int not null,
Descripcion			varchar(100) not null,
IdEstado			int,
IdUsuario			int,
primary key (IdUnidadMedida),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdUsuario) references Seguridad.Usuario,
)
go

create table Inventario.SubGrupo
(
IdEmpresa			int,
IdSubGrupo			int not null,
Descripcion			varchar(100) not null,
IdEstado			int,
IdUsuario			int
primary key (IdSubGrupo),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdUsuario) references Seguridad.Usuario,
)
go

create table Inventario.Grupo
(
IdEmpresa			int,
IdGrupo				int not null,
Descripcion			varchar(100) not null,
IdSubGrupo			int,
IdEstado			int,
IdUsuario			int
primary key (IdGrupo),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdUsuario) references Seguridad.Usuario,
foreign key (IdSubGrupo)references Inventario.SubGrupo,
) 
go

create table Inventario.TipoArticulo
(
IdEmpresa			int,
IdTipoArticulo		int not null,
Descripción			varchar(500)not null,
IdGrupo				int,
IdUsuario			int,
IdEstado			int,
primary key (IdTipoArticulo),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdUsuario) references Seguridad.Usuario,
foreign key (IdGrupo)references Inventario.Grupo,
)
go

create table Inventario.Chasis
(
IdEmpresa			int,
IdChasis			int not null,
Descripcion			varchar(100) not null,
IdUsuario			int,
IdEstado			int,
primary key (IdChasis),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdUsuario) references Seguridad.Usuario,
)
go

create table Inventario.TipoMotor
(
IdEmpresa			int,
IdTipoMotor			int not null,
Descripcion			varchar(100),
IdUsuario			int,
IdEstado			int,
primary key (IdTipoMotor),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdUsuario) references Seguridad.Usuario,
)
go

create table Inventario.TipoCombustible
(
IdEmpresa			int,
IdTipoCombustible	int not null,
Descripcion			varchar(100),
IdUsuario			int,
IdEstado			int,
primary key (IdTipoCombustible),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdUsuario) references Seguridad.Usuario,
) 
go

create table Inventario.Color
(
IdEmpresa			int,
IdColor				int not null,
Descripcion			varchar(100) not null,
IdUsuario			int,
IdEstado			int,
primary key (IdColor),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdUsuario) references Seguridad.Usuario,
)
go

create table Inventario.Modelo
(
IdEmpresa			int,
IdModelo			int not null,
Descripcion			varchar(100) not null,
IdUsuario			int,
IdEstado			int,
primary key (IdModelo),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdUsuario) references Seguridad.Usuario,
)
go

create table Inventario.Marca
(
IdEmpresa		int,
IdMarca			int not null,
Descripcion		varchar(100) not null,
IdModelo		int,
IdUsuario		int,
IdEstado		int,
primary key (IdMarca),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdUsuario) references Seguridad.Usuario,
foreign key (IdModelo) references Inventario.Modelo,
)
go

create table Inventario.TipoMaterial
(
IdEmpresa		int,
IdTipoMaterial	int not null,
Descripcion		varchar(100),
IdUsuario		int,
IdEstado		int,
primary key (IdTipoMaterial),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdUsuario) references Seguridad.Usuario,
)
go

create table Inventario.Articulo
(
IdEmpresa		int,
IdArticulo		int not null,
Descripcion		varchar(100) not null,
FechaProduccion date,
CantidadMinima	numeric(5,0),
CantidadMaxima	numeric(5,0),
CantidadActual	numeric(5,0),
IdUnidadMedida	int not null,
FechaCaducidad	date,
IdTipoArticulo	int not null,
IdGrupo			int not null,
IdSubGrupo		int, 
IdChasis		int, 
IdTipoMotor		int,
NroPlaca		int,
IdTipoCombustible int,
IdColor			int,
IdMarca			int,
IdModelo		int,
IdTipoMaterial	int,
Observacion		varchar(100),
IdUsuario		int,
IdEstado		int,
primary key (IdArticulo, IdEmpresa),
foreign key(IdEstado)references Seguridad.Estado,
foreign key(IdEmpresa)references Seguridad.Empresa,
foreign key(IdUnidadMedida)references Inventario.UnidadMedida,
foreign key (IdTipoArticulo)references Inventario.TipoArticulo,
foreign key (IdGrupo)references Inventario.Grupo,
foreign key (IdSubGrupo)references Inventario.SubGrupo,
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
IdEmpresa		int not null,
IdPercha		int not null,
Nro_Divisiones	numeric(10,0) not null,
IdBodega		int not null,
IdEstado			int,
IdUsuario			int,
primary key (IdPercha),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdBodega, IdEmpresa) references Inventario.Bodega,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdUsuario) references Seguridad.Usuario,
)
go

create table Inventario.Motivo
(
IdEmpresa		int,
IdMotivo		int not null,
Descripcion		varchar(100) not null,
IdEstado			int,
IdUsuario			int,
primary key (IdMotivo),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdEstado) references Seguridad.Estado,
foreign key (IdUsuario) references Seguridad.Usuario,
)
go

create table Inventario.TransferenciaBodegaCab
(
IdEmpresa			int,
NroTransferencia	int not null,
FechaTransferencia	date,
FechaModificacion datetime,
IdBodegaOrigen		int,
IdBodegaDestino		int,
IdMotivo			int,
Observacion			varchar(150),
IdUsuario			int,
IdEstado			int,
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
IdEmpresa			int,
NroTransferencia	int not null,
CantidadTrasladada	int,
Articulo			numeric(10,0),
IdEstado				int,
primary key(NroTransferencia),
foreign key(NroTransferencia) references Inventario.TransferenciaBodegaCab,
foreign key (IdEstado) references Seguridad.Estado,
) 
go

create table Inventario.TomaFisicaCab
(
IdEmpresa			int,
NroTomaFisica		int not null,
IdMotivo			int,
FechaTomaFisica		date,
FechaModificacion datetime,
Usuario				numeric(10,0),
IdTipoArticulo		int,
IdBodega			int,
IdUsuario			int,
Auditor				varchar(50),
Observacion			varchar(150),
IdEstado				int,
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
IdEmpresa			int,
NroTomaFisica		int not null,
IdArticulo			int,
ExistenciaSistema	int,
ExistenciaFisica	int,
CantidadAjustada	int,
FechaAjuste			date,
primary key (NroTomaFisica),
foreign key(IdEmpresa) references Seguridad.Empresa,
foreign key(IdArticulo, IdEmpresa) references Inventario.Articulo,
)
go


create table Inventario.IngresoEgresoDet
(
IdEmpresa			int,
IdTransaccion		int,
NroMovimiento		int not null,
IdArticulo			int,
IdGrupo				int,
IdSubGrupo			int,
IdUnidadMedida		int,
Cantidad			int,
Costo				numeric(5,2), 
IdResponsable		int,
Subtotal			numeric(5,2),
ValorIVA			numeric(5,2),
IdUsuario			int,
primary key (NroMovimiento),
foreign key(IdTransaccion)references Contabilidad.TipoTransaccion,
foreign key(IdArticulo,IdEmpresa)references Inventario.Articulo,
foreign key(IdGrupo)references Inventario.Grupo,
foreign key(IdSubGrupo)references Inventario.SubGrupo,
foreign key(IdUnidadMedida)references Inventario.UnidadMedida,
foreign key(IdResponsable)references RecursosHumanos.Persona,
foreign key(IdUsuario)references Seguridad.Usuario
) 
go

create table Inventario.ArticuloBodega
(
IdEmpresa			int,
IdArticuloBodega	int,
IdArticulo			int,
IdPercha			int,
Cantidad			int,
primary key	(IdArticuloBodega),
foreign key(IdEmpresa) references Seguridad.Empresa,
foreign key (IdArticulo, IdEmpresa) references Inventario.Articulo,
foreign key (IdPercha) references Inventario.Percha,
)
go


/*************para integrar cuentas por cobrar con facturacion******************/

CREATE TABLE CuentasPorCobrar.FormaPago
(
	idEmpresa int NOT NULL,
	idUsuario int NOT NULL,
	idFormaPago int NOT NULL,
	Descripcion varchar(100) NOT NULL,
	idEstado int NOT NULL,
	primary key(idFormaPago),
	foreign key (idEmpresa) references Seguridad.Empresa,
	foreign key (idUsuario) references Seguridad.Usuario,
	foreign key (idEstado) references Seguridad.Estado
)
go

/************************MODULO DE FACTURACION INTEGRACION********************/

CREATE TABLE Facturacion.Cotizacion
(
	IdEmpresa int NOT NULL,
	idUsuario int NOT NULL,
	IdNumeroCotizacion int NOT NULL,
	idFormaPago int NOT NULL,
	idCliente int NOT NULL,
	Fecha date NULL,
	PorcentajeEntrada money NULL,
	ValorEntrada money NULL,
	EntradaMinimaRequerida money NULL,
	ValorCancelar money NULL,
	FechaInicialPago date NULL,
	FechaFinalPago date NULL,
	Seguro bit NULL,
	idEstado int NOT NULL,
	primary key(IdNumeroCotizacion),	
	foreign key (idCliente) references RecursosHumanos.CLiente,
	foreign key(idFormaPago)references CuentasPorCobrar.FormaPago,
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
	descripcion varchar(50) NULL,
	FechaInicio date NULL,
	FechaFin date NULL,
	tipoPromocion varchar(50) NULL,
	pordescuento decimal(18, 2) NULL,
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
	Fecha date NULL,
	descripcion varchar(100) NULL,
	idFormaPago int NULL,
	Porcentaje money NULL,
	MontoVenta money NULL,
	idEstado int NOT NULL,
	primary key(IdNumeroPorcComision),
	foreign key(idFormaPago)references CuentasPorCobrar.FormaPago,
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
	FechaEmision date NULL,
	SitioSalida varchar(50) NULL,
	Sitiollegada varchar(50) NULL,
	FechaTraslado date NULL,
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
	cabecera_comprobante numeric (4),
	idUsuario int NOT NULL,
	IdNumeroFactura int NOT NULL,
	IdNumeroCotizacion int NULL,
	IdPromocion int NULL,
	idFormaPago int NULL,
	idCliente int NULL,
	Fecha date NULL,
	ValorEntrada money NULL,
	NumeroCuotaMensual int NULL,
	TotalPagar money NULL,
	idEstado int NOT NULL,
	primary key(IdNumeroFactura),	
	foreign key (IdEmpresa,cabecera_comprobante)references Contabilidad.CabeceraComprobante,
	foreign key (idCliente) references RecursosHumanos.CLiente,
	foreign key (IdNumeroCotizacion) references Facturacion.Cotizacion,
	foreign key (IdPromocion) references Facturacion.Promocion,
	foreign key(idFormaPago)references CuentasPorCobrar.FormaPago,	
	foreign key (idUsuario) references Seguridad.Usuario,
	foreign key (idEstado) references Seguridad.Estado
) 
GO

CREATE TABLE Facturacion.Comision
(
	IdEmpresa int NOT NULL,
	cabecera_comprobante numeric (4),
	idUsuario int NOT NULL,
	IdNumeroComision int NOT NULL,
	FechaInicial date NULL,
	FechaFinal date NULL,
	IdNumeroPorcComision int NOT NULL,
	MontoVenta money NULL,
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
	Interes money NULL,
	FechaPago date NULL,
	FechaMaximaPago date NULL,
	idEstado int NOT NULL,
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
	MontoComision money NULL,
	FechaPago date NULL,
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
	cabecera_comprobante numeric (4),
	idUsuario int NOT NULL,
	IdNumeroDevolucion int NOT NULL,
	IdNumeroFactura int NULL,
	Fecha date NULL,
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
	FechaEntrega date NULL,
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
	CuotaMensual money NULL,
	Interes money NULL,
	FechaPago date NULL,
	FechaMaximaPago date NULL,
	idEstado int NOT NULL,
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
	Observacion varchar(300) NULL,
	idEstado int NOT NULL,
	primary key(Linea,IdNumeroDevolucion),
	foreign key (IdNumeroDevolucion) references Facturacion.DevolucionVenta,	
	foreign key(IdArticulo, IdEmpresa) references Inventario.Articulo,	
	foreign key (idUsuario) references Seguridad.Usuario,
	foreign key (idEstado) references Seguridad.Estado 
) 
GO

/****************** Cuentas por cobrar **********************/
/************************************************************/
/*necesita de modulo facturacion*/

create table CuentasPorCobrar.UnidadTiempo
(
	idUnidadTiempo int not null,
	descripcion varchar(25) not null,
	primary key(idUnidadTiempo)
)
go
	
CREATE TABLE CuentasPorCobrar.MonetarioDet
(
	idEmpresa int NOT NULL,
	idUsuario int NOT NULL,
	idDetalleMonetario int NOT NULL,
	Descripcion varchar(100) NOT NULL,
	Valor money NOT NULL,
	idEstado int NOT NULL,
	primary key (idDetalleMonetario),
	foreign key (idEmpresa) references Seguridad.Empresa,
	foreign key (idUsuario) references Seguridad.Usuario,
	foreign key (idEstado) references Seguridad.Estado
)
go



CREATE TABLE CuentasPorCobrar.CierreCaja
(
	idEmpresa int NOT NULL,
	idUsuario int NOT NULL,
	idCierreCaja int NOT NULL,
	FechaCierre date NOT NULL,
	FechaModificacion datetime,
	MontoApertura money NOT NULL,
	TotalDeposito money NOT NULL,
	TotalTransferencia money NOT NULL,
	TotalCheque money NOT NULL,
	TotalBoucher money NOT NULL,
	TotalEfectivo money NOT NULL,
	TotalRecaudado money NOT NULL,
	idEstado int NOT NULL,
	primary key (idCierreCaja),
	foreign key (idEmpresa) references Seguridad.Empresa,
	foreign key (idUsuario) references Seguridad.Usuario,
	foreign key (idEstado) references Seguridad.Estado
)
go

CREATE TABLE CuentasPorCobrar.TipoInversion
(
	idEmpresa int NOT NULL,
	idUsuario int NOT NULL,
	idTipoInversion int NOT NULL,
	Descripcion varchar(100) NOT NULL,
	idEstado int NOT NULL,
	primary key (idTipoInversion),
	foreign key (idEmpresa) references Seguridad.Empresa,
	foreign key (idUsuario) references Seguridad.Usuario,
	foreign key (idEstado) references Seguridad.Estado
)
go

CREATE TABLE CuentasPorCobrar.Banco
(
	idEmpresa int NOT NULL,
	idUsuario int NOT NULL,
	idBanco int NOT NULL,
	Nombre varchar(100) NOT NULL,
	idEstado int NOT NULL,
	primary key (idBanco),
	foreign key (idEmpresa) references Seguridad.Empresa,
	foreign key (idUsuario) references Seguridad.Usuario,
	foreign key (idEstado) references Seguridad.Estado
 )
go

CREATE TABLE CuentasPorCobrar.TarjetaCredito
(
	idEmpresa int NOT NULL,
	idUsuario int NOT NULL,
	idTarjeta int NOT NULL,
	descripcion varchar(100) NOT NULL,
	idBanco int NOT NULL,
	idEstado int NOT NULL,
	primary key (idTarjeta),
	foreign key (idEmpresa) references Seguridad.Empresa,
	foreign key (idUsuario) references Seguridad.Usuario,
	foreign key (idBanco) references CuentasPorCobrar.Banco,
	foreign key (idEstado) references Seguridad.Estado
 )
 go

CREATE TABLE CuentasPorCobrar.MovimientoBancario
(
	idEmpresa int NOT NULL,
	idUsuario int NOT NULL,
	idMovimientoBancario int NOT NULL,
	idTransaccion int NOT NULL,
	idBanco int NOT NULL,
	NumeroDocumento int NOT NULL,
	Observacion varchar(150) NOT NULL,
	Fecha date NOT NULL,
	FechaModificacion datetime,
	Valor money NOT NULL,
	idEstado int NOT NULL,
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
	idEmpresa int NOT NULL,
	idUsuario int NOT NULL,
	idInversion int NOT NULL,
	idEntidad int NOT NULL,
	idTipoInversion int NOT NULL,
	Tiempo int NOT NULL,
	idUnidadTiempo int NOT NULL,
	Valor money NOT NULL,
	Porcentaje numeric(18, 0) NOT NULL,
	Fecha date NOT NULL,
	FechaModificacion datetime,
	FechaInicio date NOT NULL,
	FechaFinal date NOT NULL,
	idEstado int NOT NULL,
	primary key (idInversion),
	foreign key (idEmpresa) references Seguridad.Empresa,
	foreign key (idUsuario) references Seguridad.Usuario,
	foreign key (idEntidad) references RecursosHumanos.Persona,
	foreign key (idTipoInversion) references CuentasPorCobrar.TipoInversion,
	foreign key (idUnidadTiempo) references CuentasPorCobrar.UnidadTiempo,
	foreign key (idEstado) references Seguridad.Estado
 )
 go
 
CREATE TABLE CuentasPorCobrar.AperturaCaja
(
	idEmpresa int NOT NULL,
	idUsuario int NOT NULL,
	idAperturaCaja int NOT NULL,
	Fecha date NOT NULL,
	FechaModificacion datetime,
	Monto money NOT NULL,
	idEstado int NOT NULL,
	primary key (idAperturaCaja),
	foreign key (idEmpresa) references Seguridad.Empresa,
	foreign key (idUsuario) references Seguridad.Usuario,
	foreign key (idEstado) references Seguridad.Estado
 )
 go

CREATE TABLE CuentasPorCobrar.CuentaBancaria
(
	idEmpresa int NOT NULL,
	idUsuario int NOT NULL,
	idCuentaBancaria int NOT NULL,
	idBanco int NOT NULL,
	idTitularNatural int NULL,
	idTitularJuridico int NULL,
	NumeroCuenta int NOT NULL,
	TipoCuenta varchar(100) NOT NULL,
	Saldo money NOT NULL,
	idEstado int NOT NULL,
	primary key (idCuentaBancaria),
	foreign key (idEmpresa) references Seguridad.Empresa,
	foreign key (idUsuario) references Seguridad.Usuario,
	foreign key (idBanco) references CuentasPorCobrar.Banco,
	foreign key (idTitularNatural) references RecursosHumanos.Persona,
	foreign key (idTitularJuridico) references RecursosHumanos.Persona,
	foreign key (idEstado) references Seguridad.Estado
)
go

CREATE TABLE CuentasPorCobrar.ConciliacionBancaria
(
	idEmpresa int NOT NULL,
	idUsuario int NOT NULL,
	idConciliacionBancaria int NOT NULL,
	idBanco int NOT NULL,
	NumeroCuenta int NOT NULL,
	FechaModificacion datetime,
	FechaConciliacion date NOT NULL,
	FechaDesde date NOT NULL,
	FechaHasta date NOT NULL,
	TotalIngresos money NOT NULL,
	TotalEgresos money NOT NULL,
	Saldo money NOT NULL,
	TotalConciliacion money NOT NULL,
	idEstado int NOT NULL,
	primary key (idConciliacionBancaria),
	foreign key (idEmpresa) references Seguridad.Empresa,
	foreign key (idUsuario) references Seguridad.Usuario,
	foreign key (idBanco) references CuentasPorCobrar.Banco,
	foreign key (idEstado) references Seguridad.Estado
 )
 go
 
CREATE TABLE CuentasPorCobrar.CobroDet
(
	idEmpresa int NOT NULL,
	idUsuario int NOT NULL,
	idCobro int NOT NULL,
	numero int NOT NULL,
	idBanco int NOT NULL,
	idFormaPago int NOT NULL,
	Valor money NOT NULL,
	NumeroDocumento int NOT NULL,
	Observacion varchar(150) NOT NULL,
	idEstado int NOT NULL,
	primary key(idCobro,numero),
	foreign key(idEmpresa)references Seguridad.Empresa,
	foreign key(idUsuario)references Seguridad.Usuario,
	foreign key(idBanco)references CuentasPorCobrar.Banco,
	foreign key(idFormaPago)references CuentasPorCobrar.FormaPago,
	foreign key (idEstado) references Seguridad.Estado 
 )
 go
 
CREATE TABLE CuentasPorCobrar.AperturaDet
(
	idEmpresa int NOT NULL,
	IdUsuario int NOT NULL,
	idAperturaCaja int NOT NULL,
	Numero int NOT NULL,
	Denominacion int NOT NULL,
	Cantidad int NOT NULL,
	idEstado int NOT NULL,
	primary key (idAperturaCaja,numero),
	foreign key (idEmpresa) references Seguridad.Empresa,
	foreign key (idUsuario) references Seguridad.Usuario,
	foreign key (idAperturaCaja) references CuentasPorCobrar.AperturaCaja,
	foreign key (idEstado) references Seguridad.Estado
)
go


/***************Cuentas por Pagar**************************************************/

	create table CuentaxPagar.MedioPago
	(
	IdMedioPago int not null ,
	Descripcion nvarchar(30) not null,
	fechaRegistro date not null,
	IdEstado int not null,
	IdEmpresa int not null references Seguridad.Empresa,
	IdUsuario int not null,
	foreign key (IdUsuario) references Seguridad.Usuario,
	foreign key (IdEstado)references Seguridad.Estado,
	primary key(IdMedioPago, IdEmpresa) 
	)
	go
	
	create table CuentaxPagar.EmpresaServicio(
	IdEmpresaServicio int not null,
	fechaRegistro date not null,
	RazonSocial nvarchar(30) not null,
	Direccion nvarchar(30)not null,
	IdTipoPersona int not null,
	IdEmpresa int not null,
	IdUsuario int not null,
	foreign key (IdTipoPersona)references RecursosHumanos.TipoPersona,
	foreign key (IdUsuario)references Seguridad.Usuario,
	foreign key (IdEmpresa)references Seguridad.Empresa, 
	foreign key (IdUsuario)references Seguridad.Usuario,
	primary key(IdEmpresaServicio,IdEmpresa)
	)
	go
	
	
	create table CuentaxPagar.TelefonoEmpresaServicio(
		IdEmpresa int not null,
		IdEmpresaServicio int not null,
		IdTelefono int not null,
		Serie int not null,
		foreign key (IdEmpresa)references Seguridad.Empresa, 
	foreign key (IdEmpresaServicio, IdEmpresa)references CuentaxPagar.EmpresaServicio,
		foreign key (IdTelefono)references RecursosHumanos.Telefono, 
	primary key(IdEmpresaServicio,IdEmpresa, Serie, IdTelefono)	
	)
go	
	
	
	create table CuentaxPagar.Impuesto(
	IdImpuesto int not null,
	Descripcion nvarchar(30) not null,
	Porcentaje numeric(3,0)not null,
	FechaRegistro date not null,
	IdEstado int not null,
	IdEmpresa int not null,
	IdUsuario int not null,
	foreign key (IdUsuario)references Seguridad.Usuario,
	foreign key (IdEmpresa)references Seguridad.Empresa, 
	foreign key (IdEstado)references Seguridad.Estado,
	primary key (IdImpuesto, IdEmpresa)
	)
	go

	create table CuentaxPagar.FrecuenciaPago(
	IdFrecuenciaPago int not null,
	Descripcion nvarchar(30) not null,
	FechaActual date not null,
	IdEstado int not null,
	IdUsuario int not null,
	IdEmpresa int not null,
	foreign key (IdUsuario)references Seguridad.Usuario,
	foreign key (IdEmpresa)references Seguridad.Empresa, 
	foreign key(IdEstado)references Seguridad.Estado,
	primary key(IdFrecuenciaPago,IdEmpresa)
)
go

	create table CuentaxPagar.CuentaBancaria
	(
	Serie int not null,
	FechaActual date not null,
	TipoCuenta char not null,
	NroCta int not null,
	IdBanco int not null,
	IdEmpresa int not null,
	IdEmpresaServicio int not null,
	foreign key (IdEmpresaServicio, IdEmpresa)references CuentaxPagar.EmpresaServicio,
	foreign key (IdBanco)references CuentasPorCobrar.Banco,
	foreign key (IdEmpresa)references Seguridad.Empresa,
	primary key(Serie,IdEmpresaServicio)
)
go

/*********************COMPRAS****************/
-- TABLA DE COMPRAS (cabecera)
/*cuentas por cobrar*/

CREATE TABLE CuentasPorCobrar.Cobro
(
	idEmpresa int NOT NULL,
	idUsuario int NOT NULL,
	idCobro int NOT NULL,
	idTransaccion int NOT NULL,
	idFactura int NOT NULL,
	idCliente int NOT NULL,
	idCabeceraComprobante numeric(4,0) NOT NULL,
	Fecha date NOT NULL,
	FechaModificacion datetime,
	NumeroCuota int NOT NULL,
	ValorCuota money NOT NULL,
	Interes money NOT NULL,
	Mora money NOT NULL,
	ValorPagado money NOT NULL,
	Saldo money NOT NULL,
	idEstado int NOT NULL,
	primary key (idCobro),
	foreign key (idEmpresa) references Seguridad.Empresa,
	foreign key (idUsuario) references Seguridad.Usuario,
	foreign key (idTransaccion) references Facturacion.Factura,
	foreign key (idFactura) references Facturacion.Factura,
	foreign key (idCliente) references RecursosHumanos.CLiente,
	foreign key (IdEmpresa,idCabeceraComprobante) references Contabilidad.CabeceraComprobante,
	foreign key (idEstado) references Seguridad.Estado
)
go


create table CuentasPorCobrar.CuentaxCobrar
(
	idEmpresa int NOT NULL,
	idUsuario int NOT NULL,
	idCuentaxCobrar int NOT NULL,
	
	numero_comprobante numeric(4,0),
	idTransaccion int NOT NULL,
	idFactura int NOT NULL,
	idCabeceraComprobante int NOT NULL,
	TotalCuotas int NOT NULL,
	porcentaje_interes numeric NOT NULL,
	idEstado int NOT NULL,
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
	idEmpresa int NOT NULL,
	idUsuario int NOT NULL,
	idCuentaxCobrar int NOT NULL,
	idCobro int NOT NULL,
	Numero int NOT NULL,
	numero_cuota int NOT NULL,
	valor_cuota money NOT NULL,
	valor_interes money NOT NULL,
	valor_mora money NOT NULL,
	fecha_cobro date NOT NULL,
	fecha_vencimiento date NOT NULL,
	FechaModificacion datetime,
	idEstado int NOT NULL,
	primary key (idCuentaxCobrar, numero),
	foreign key (idEmpresa) references Seguridad.Empresa,
	foreign key (idUsuario) references Seguridad.Usuario,
	foreign key (idCobro) references CuentasPorCobrar.Cobro,
	foreign key (idEstado) references Seguridad.Estado
)
go




/************************cuentas por pagar*************/

	create table CuentaxPagar.CuentaPorPagar 
	(
	NumCuentaPorPagar int not null ,--
	NumIngresoEgreso int not null,--
	FechaIngreso date not null,
	Factura int not null,
	FechaModificacion datetime,
	FechaTransaccion date not null,
	IdPersona int not null,
	Motivo nvarchar(30) not null,
	detalle nvarchar(30) not null,
	Subtotal numeric(10,0) not null,
	Descuento numeric(10,0) not null,
	Total numeric (10,0) not null,
	FormaPago char not null,--
	ValorEntrada numeric(10,0) null,--
	NumeroLetra int null,
	IdFrecuencia int null,
	ValorLetra numeric(10,0) null,
	SaldoDeuda numeric(10,0) null,
	LetraPendientePago int null,
	IdUsuario int not null,
    IdEmpresa int not null references Seguridad.Empresa,
    foreign key (IdUsuario)references Seguridad.Usuario,
    foreign key (IdFrecuencia, IdEmpresa)references CuentaxPagar.FrecuenciaPago,
    foreign key (IdPersona, IdEmpresa)references CuentaxPagar.EmpresaServicio,
	foreign key (IdPersona)references RecursosHumanos.Persona,		
    foreign key (NumIngresoEgreso, IdEmpresa)references Inventario.IngresoEgresoCab,
    foreign key (IdEmpresa) references Seguridad.Empresa,
	primary key(NumCuentaPorPagar, IdEmpresa)
	)
	GO

create table CuentaxPagar.DeudaDet--esta tabla debe llamarse CuentaPorPagarDetalle
(
	IdEmpresa int not null,
	NumCuentaPorPagar int not null,
	NumDetalleDeuda int not null,
	ValorLetra numeric(10,2) not null,
	FechaVencimiento date not null,
	FechaPagoReal date not null,
	FechaModificacion datetime,
	IdEstado int not null,
    foreign key (IdEstado) references Seguridad.Estado,
    foreign key (NumCuentaPorPagar, IdEmpresa) references CuentaxPagar.CuentaPorPagar,
	primary key(IdEmpresa, NumCuentaPorPagar, NumDetalleDeuda)
)
go


create table CuentaxPagar.ImpuestoCuenta
(
	IdImpuesto int not null,
	NumCuentaPorPagar int not null,
	Linea int not null,
	Valor numeric(10,0) not null,
	IdUsuario int not null,
    IdEmpresa int not null references Seguridad.Empresa,
    foreign key (IdUsuario)references Seguridad.Usuario,
    foreign key (IdImpuesto, IdEmpresa)references CuentaxPagar.Impuesto, 
    foreign key (NumCuentaPorPagar, IdEmpresa)references CuentaxPagar.CuentaPorPagar, 
    primary key(IdImpuesto, NumcuentaPorPagar, Linea) 	
)
go


create table CuentaxPagar.OrdenPagoCab
(
	NumOrdenPago int not null,
	fechadeEmision date not null,
	IdPersona int null,
	IdEstado int not null,
	TotalPagar numeric(10,2) not null,
	TipoOrdenPago char not null,
	IdUsuario int not null,
    IdEmpresa int not null,
    foreign key (IdUsuario)references Seguridad.Usuario,
    foreign key (IdEstado) references Seguridad.Estado,
    foreign key (IdEmpresa)references Seguridad.Empresa, 
	primary key (NumOrdenPago, IdEmpresa) 
)
go

create table CuentaxPagar.OrdenPagoEmpleadoDet
(
	NumOrdenPago int not null,
	IdEmpresa int not null,
	Linea int not null,
	IdPersona int not null,
	SueldoTotal numeric(10,2) null,
	IngresoAdicional numeric(10,2) null,
	DescuentoTotal numeric(10,2) null,
	PagoNeto numeric(10,2) not null,
    foreign key (NumOrdenPago, IdEmpresa) references CuentaxPagar.OrdenPagoCab,
    foreign key (IdEmpresa)references Seguridad.Empresa, 
	primary key (NumOrdenPago, IdEmpresa, Linea) 
)
go

create table CuentaxPagar.OrdenPagoDet
(
		NumLinea int not null,
	NumCuentaPorPagar int not null,
	NumDetalleDeuda int not null,
	SaldoDeuda numeric(10,0)not null,
	NumeroPagosRealizar int not null,
	NumOrdenCab int not null,
	TotalPagar numeric(10,0) not null,
      IdEmpresa int not null,
    foreign key(NumOrdenCab, IdEmpresa) references CuentaxPagar.OrdenPagoCab,
    foreign key (NumDetalleDeuda, NumCuentaPorPagar, IdEmpresa)references CuentaxPagar.DeudaDet, 
    primary key(NumLinea, NumOrdenCab, IdEmpresa)
  )
go

--*******************************************

create table CuentaxPagar.PagoCab
(
	NumPago int not null,
	FechaIngreso date not null,
	NumOrdenPago int not null,
	TipoPago bit not null,
	TotalPagar numeric(10,0) not null,
	IdUsuario int not null,
	IdEmpresa int not null,
	IdEstado int not null,
    NumComprobante numeric(4)not  null,
	
	foreign key (IdUsuario)references Seguridad.Usuario,
    foreign key (IdEmpresa)references Seguridad.Empresa, 
    foreign key (NumOrdenPago, IdEmpresa)references CuentaxPagar.OrdenPagoCab,
    foreign key (IdEstado)references Seguridad.Estado,
    primary key (NumPago,IdEmpresa)				
)
go



create table CuentaxPagar.PagoDet
(
	NumLinea int not null,
	IdMedioPago int not null,
	Monto numeric(10,0) not null,
	NumeroCuenta int not null,
	IdEmpresa int not null,
	IdBanco int not null,
	NumComprobante numeric(4)not null,
	NumComision int not null,
	NumNominaCab int not null,
	NumPago int not null,
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

/*8 Esta es la tabla de CodigoBarra*/

--8 Esta es la tabla de CodigoBarra
create table ActivoFijo.CodigoBarra
(
IdCodigoBarra int primary key,
fecha date not null,
fecha_seteoDesde date not null,
fecha_seteoHasta date not null,
ancho float not null,
alto float not null,
margen_superior float not null,
margen_inferior float not null,
sentido_lectura bit not null,
formato varchar(20) not null,
observacion varchar(150) not null
)
go

create table ActivoFijo.ActivoFijo
(
IdActivoFijo int primary key,
IdEmpresa int not null,--relacion tablas de Seguridad
IdDepartamento int not null,--relacaion tablas de RRHH
IdResponsable int not null,--relacaion tablas de RHHH de la tabla Personal
IdArticuloBodega int not null,--relacion tablas de inventario que es para la asignacion de responsable de bodega
IdUsuario int not null,     --relacion tablas de RHHH de la tabla Personal
IdTipo int not null,--relacion tablas de inventario que es el tipo de articulo que ellos poseen
IdGrupo int not null,--relacion tablas de inventario
IdSubgrupo int not null,--relacion tablas de inventario
IdArticulo int not null,--relacion tablas de inventario
descripcion char null,
valor_nomial float not null,
valor_residual float not null,
valor_actualserie float not null,
IdCodigoBarra int not null,
serie numeric not null,
IdMarca int not null,--relacion tablas de inventario
fecha_depreciacion date not null,
año_vidaUtil int not null,
IdEstado int not null,--relacion tabla general de Estado
fecha_registro date not null,
--haciendo las referencias constraint
foreign key (IdEmpresa) references Seguridad.Empresa,--relacion tablas de Seguridad
foreign key (IdDepartamento)references RecursosHumanos.Departamento,--relacaion tablas de RRHH
foreign key (IdArticuloBodega)references Inventario.ArticuloBodega,--relacion tablas de inventario,
foreign key (IdResponsable,IdEmpresa)references RecursosHumanos.Empleado,--relacaion tablas de RRHH
foreign key (IdUsuario)references Seguridad.Usuario,--relacaion tablas de RRHH
foreign key (IdTipo)references Inventario.TipoArticulo,--relacion tablas de inventario,
foreign key (IdGrupo)references Inventario.Grupo,--relacion tablas de inventario,
foreign key (IdSubgrupo)references Inventario.SubGrupo,--relacion tablas de inventario,
foreign key (IdArticulo,IdEmpresa)references Inventario.Articulo,--relacion tablas de inventario,
foreign key (IdMarca)references Inventario.Marca,--relacion tablas de inventario,
foreign key (IdCodigoBarra) references ActivoFijo.CodigoBarra,
foreign key (IdEstado) references Seguridad.Estado--relacion tabla general de Estado
) 
go

--3 Esta es la tabla de TipoTerreno
create table ActivoFijo.TipoTerreno
(
IdTipoTerreno int primary key,
Descripcion varchar(50)not null
)
go


--2 Esta es la tabla de Terreno
create table ActivoFijo.Terreno
(
IdTerreno int primary key,
IdActivoFijo int not null,
direccion varchar(100)not null, 
observacion varchar(180)not null,
IdTipoTerreno int not null,
IdProveedor int not null,
DimensionAncho numeric not null,
DimensionLargo numeric not null,
FechaLegalizacion date not null,
--haciendo las referencias constraint
foreign key (IdActivoFijo) references ActivoFijo.ActivoFijo,
foreign key (IdProveedor) references RecursosHumanos.Proveedor,
foreign key (IdTipoTerreno) references ActivoFijo.TipoTerreno
)
go


--4 Esta es la tabla de EquipoComputo
create table ActivoFijo.EquipoMaquinariaMuebles
(
IdActivoFijo int primary key,
IdMarca int not null,--relacion tablas de inventario,
IdModelo int not null,--relacion tablas de inventario
IdColor int not null,--relacion tablas de inventario,
Descripcion varchar(50)not null,

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
Secuencia int primary key,
fecha date not null,
observacion varchar(150) not null
)
go

--5 Esta es la tabla de DepreciacionDet
create table ActivoFijo.DepreciacionDet
(
Secuencia int primary key,
IdCabecera int not null,
IdActivoFijo int not null,
valor_nominal float not null,
valor_actual float not null,

--haciendo las referencias constraint
 foreign key (IdActivoFijo) references ActivoFijo.ActivoFijo,
 foreign key (IdCabecera) references ActivoFijo.DepreciacionCab
)
go



--7 Esta es la tabla de Vehiculo
create table ActivoFijo.Vehiculo
(
IdActivoFijo int primary key,
IdMarca int not null,--relacion tablas de inventario,
IdModelo int not null,--relacion tablas de inventario
IdColor int not null,--relacion tablas de inventario,
IdMotor int not null,--relacion tablas de inventario,
IdChasis int not null,
placa varchar(10) not null,
numeropuerta numeric not null,
descripcion varchar (50) not null,
IdMaterial int not null,--relacion tablas de inventario,
matricula varchar (50) not null,
transmision varchar (30) not null,
carga float not null,
capacidad numeric not null,
kilometraje float not null,
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

--10 Esta es la tabla de Transferencia
create table ActivoFijo.TipoTransferencia
(
IdTipoTransferencia int primary key,
Observaciones varchar(250)
)
go

--9 Esta es la tabla de Transferencia
create table ActivoFijo.Transferencia
(
Idtransferencia int primary key,
IdActivoFijo int not null,
fecha date not null,
IdTipoTransferencia int not null,
IdEmpresa int not null,
IdResponsableFuturo int not null,
IdBodegaFuturo int not null,
IdDepartamento int not null,
Observaciones varchar(250),
--haciendo las referencias constraint
 foreign key (IdActivoFijo) references ActivoFijo.ActivoFijo,
 foreign key (IdTipoTransferencia) references ActivoFijo.TipoTransferencia,
foreign key (IdDepartamento)references RecursosHumanos.Departamento,--relacaion tablas de RRHH
foreign key (IdResponsableFuturo,IdEmpresa)references RecursosHumanos.Empleado,--relacaion tablas de RRHH
foreign key (IdBodegaFuturo,IdEmpresa)references Inventario.Bodega,--relacaion con Inventario 
)
go



--*************Nuevas tablas***********
create table ActivoFijo.Edifico
(
IdActivoFijo int primary key,
IdProveedor int not null,
FechaConstruccion date not null,
CodigoCatastral int not null,
NumeroPisos int not null,
AñosVidaUtil int not null,
Ubicacion varchar(100)not null, 
DimensionAncho numeric not null,
DimensionLargo numeric not null,
Avaluo float not null,
observacion varchar(180)not null,
--haciendo las referencias constraint
foreign key (IdActivoFijo) references ActivoFijo.ActivoFijo,
foreign key (IdProveedor) references RecursosHumanos.Proveedor
)
go

create table ActivoFijo.revalorizacion
(
IdRevalorizacion int primary key,
IdActivoFijo int not null,
ValorAtual float not null,
ValorRevalorizado float not null,
ValorResidual float not null,
foreign key (IdActivoFijo) references ActivoFijo.ActivoFijo--relacion tabla general de Estado
)
go

create table ActivoFijo.BajaActivo
(
idBajaActivo int primary key,
IdActivoFIjo int not null,
Fecha date not null,
IdEstado int not null,
IdEmpresa int not null,
Descripcion varchar(50) not null,
Motivo varchar(25) not null,
IdCabeceraComprobante numeric(4,0) not null,
Observacion varchar(300) not null,
--haciendo las referencias constraint
foreign key (IdActivoFIjo) references ActivoFijo.ActivoFijo,
foreign key (IdEstado) references Seguridad.Estado,--relacion tabla general de Estado
foreign key (IdEmpresa) references Seguridad.Empresa,--relacion tablas de Seguridad
foreign key (IdEmpresa, IdCabeceraComprobante) references Contabilidad.CabeceraComprobante
)
go

create table ActivoFijo.VentaGarageCab
(
idVentaGarage int,
IdEmpresa int,
NombreCliente  varchar(50) not null,
Direccion varchar(150) not null,
Identificador int not null,
Fecha date not null,
Telefono int not null,
IdFormaPagoMedioPago int not null,
CantidadEfectivo int not null,
CantidadCredito int not null,
CantidadTransferencia int not null,
CantidadDeposito int not null,
CantidadCheque int not null,
--haciendo las referencias constraint
primary key (idVentaGarage,IdEmpresa),
foreign key (IdEmpresa) references Seguridad.Empresa,
foreign key (IdFormaPagoMedioPago, IdEmpresa) references CuentaxPagar.MedioPago
)
go

create table ActivoFijo.VentaGarageDet
(
IdCabecera int not null,
IdVentaGarageDet int,
IdEmpresa int,
IdBajaActivo int not null,
cantidad int not null,
ValorUnitario int not null,
ValorTotal int not null,
SubTotal int not null,
Iva int not null,
Total int not null, 
IdCabeceraComprobante numeric(4,0) not null,
--haciendo las referencias constraint
primary key (IdCabecera,IdVentaGarageDet),
foreign key (IdCabecera,IdEmpresa)references ActivoFijo.VentaGarageCab,
foreign key (IdBajaActivo) references ActivoFijo.BajaActivo,
foreign key (IdEmpresa, IdCabeceraComprobante) references Contabilidad.CabeceraComprobante,
)
go


/******************COMPRAS************************/
CREATE TABLE Compras.MotivoDevolucion  --ok
(
	 idMotivo    int   NOT NULL,
	 Descripcion    int   NOT NULL,
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
	 Numero    int   NOT NULL,
	 IdEmpresa    int   NOT NULL,
	 Linea    int   NOT NULL,
	 IdArticulo    int   NOT NULL,
	 Cantidad    int   NOT NULL,
	 Precio    int   NOT NULL,
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
	 idProveedor		int   NOT NULL,
	 idEmpleado			int   NOT NULL,
	 NumeroFactura		int   NOT NULL, -- no es clave foranea
     Fecha				date NOT NULL,
     FechaModificacion	datetime NOT NULL,
	 idEstado			int   NOT NULL,
 	foreign key(IdEmpresa)references Seguridad.Empresa,
    foreign key(IdUsuario)references Seguridad.Usuario,
 	foreign key (IdEstado) references Seguridad.Estado,
	foreign key (idProveedor) references RecursosHumanos.Proveedor,
	foreign key (idEmpleado,IdEmpresa) references RecursosHumanos.Empleado,
	primary key(Numero,IdEmpresa)
)
GO

CREATE TABLE Compras.DevolucionCompraDet  --OK
(
	 Numero    int   NOT NULL,
	 idEmpresa    int   NOT NULL,
	 Linea    int   NOT NULL,
	 idArticulo    int   NOT NULL,
	 Cantidad    int   NOT NULL,
	 idMotivo    int   NOT NULL,
	 Obervaciones    varchar  (300),
	Foreign Key (Numero,IdEmpresa) references Compras.DevolucionCompra,
 	foreign key (idArticulo,IdEmpresa)references Inventario.Articulo,
 	foreign key (idMotivo)references Compras.MotivoDevolucion,
 	primary key(Numero,IdEmpresa,Linea)
)
go	

CREATE TABLE Compras.OrdenDespacho --ok 
(
	Numero		int   NOT NULL,
	idEmpresa	int   NOT NULL,
    idUsuario	int NOT NULL,
    idDepartamento int not null,
	idEmpleado	int   NOT NULL,
	Fecha		date NOT NULL,
    FechaModificacion datetime NOT NULL,
	idEstado	int   NOT NULL,
	foreign key(IdEmpresa)references Seguridad.Empresa,
    foreign key(IdUsuario)references Seguridad.Usuario,
 	foreign key (IdEstado) references Seguridad.Estado,
	foreign key (idEmpleado,IdEmpresa) references RecursosHumanos.Empleado,
	foreign key (idDepartamento) references RecursosHumanos.Departamento,
	primary key(Numero,IdEmpresa)
 )
GO

CREATE TABLE Compras.OrdenDespachoDet  --ok
(
	Numero    int   NOT NULL,
	idEmpresa    int   NOT NULL,
	Linea    int   NOT NULL,
	idArticulo    int   NOT NULL,
	Cantidad    int   NOT NULL,
	foreign key(Numero,IdEmpresa)references Compras.OrdenDespacho,
	foreign key (idArticulo,IdEmpresa) references Inventario.Articulo,
	primary key(Numero,IdEmpresa,Linea)
)
GO

CREATE TABLE Compras.Solicitud  --ok
(
	Numero			int		NOT NULL,
	idEmpresa		int		NOT NULL,
    IdUsuario		int		NOT NULL,
	IdArticulo		int		NOT NULL,
	idDepartamento	int		NOT NULL,
	idEmpleado		int		NOT NULL,
	Fecha			date	NOT NULL,
    FechaModificacion datetime NOT NULL,
	idEstado		int   NOT NULL,
	foreign key(IdEmpresa)references Seguridad.Empresa,
    foreign key(IdUsuario)references Seguridad.Usuario,
	foreign key (IdEstado) references Seguridad.Estado,
	foreign key (idArticulo,IdEmpresa) references Inventario.Articulo,
	foreign key (idEmpleado,IdEmpresa) references RecursosHumanos.Empleado,
	primary key(Numero,IdEmpresa)
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
	idDepartamento	int		NOT NULL,
	Fecha			date	NOT NULL,
    FechaModificacion datetime NOT NULL,
	idEstado		int		NOT NULL,
 	foreign key(IdEmpresa)references Seguridad.Empresa,
    foreign key(IdUsuario)references Seguridad.Usuario,
 	foreign key (IdEstado) references Seguridad.Estado,
	foreign key (idDepartamento) references RecursosHumanos.Departamento,	
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

/*******************TALLER***********************/
/*TipoPersona*/
/*
*/

/*ARTICULO DEL TALLER*/
create table Taller.Articulo
(
IdEmpresa		int,
IdArticulo		int not null,
Descripcion		varchar(100) not null,
FechaProduccion date,
CantidadMinima	numeric(5,0),
CantidadMaxima	numeric(5,0),
CantidadActual	numeric(5,0),
IdUnidadMedida	int not null,
FechaCaducidad	date,
IdTipoArticulo	int not null,
IdGrupo			int not null,
IdSubGrupo		int, 
IdChasis		int, 
IdTipoMotor		int,
NroPlaca		int,
IdTipoCombustible int,
IdColor			int,
IdMarca			int,
IdModelo		int,
IdTipoMaterial	int,
Observacion		varchar(100),
IdUsuario		int,
IdEstado		int,
primary key (IdArticulo, IdEmpresa),
foreign key(IdEstado)references Seguridad.Estado,
foreign key(IdEmpresa)references Seguridad.Empresa,
foreign key(IdUnidadMedida)references Inventario.UnidadMedida,
foreign key (IdTipoArticulo)references Inventario.TipoArticulo,
foreign key (IdGrupo)references Inventario.Grupo,
foreign key (IdSubGrupo)references Inventario.SubGrupo,
foreign key (IdChasis)references Inventario.Chasis,
foreign key (IdTipoMotor)references Inventario.TipoMotor,
foreign key (IdTipoCombustible)references Inventario.TipoCombustible,
foreign key (IdColor)references Inventario.Color,
foreign key (IdMarca)references Inventario.Marca,
foreign key (IdModelo)references Inventario.Modelo,
foreign key (IdTipoMaterial)references Inventario.TipoMaterial
)
go


/*EMPRESA ASEGURADORA*/
CREATE TABLE Taller.EmpresaAseguradora
( 
	IdEmpresaAseguradora int not null primary key,
	Descripcion          varchar(50)  not null,
	IdEstado 	     int not null,
	foreign key (IdEstado)references Seguridad.Estado
)
go


/*SEGURO*/
CREATE TABLE Taller.Seguro
( 
	IdSeguro             int  not null primary key,
	NroSeguro            int  not null,
	IdEmpresaAseguradora int  not null,
	IdEstado 	     int not null,
	foreign key (IdEstado)references Seguridad.Estado,
	foreign key(IdEmpresaAseguradora)references Taller.EmpresaAseguradora	
)
go


/*PRESUPUESTO*/
CREATE TABLE Taller.Presupuesto
( 
	IdPresupuesto        int  not null primary key,
	IdCliente            int  not null, 
	Fecha                date  not null,
	FechaModificacion datetime,
	IdSeguro             int  not null,
	TotalTiempoTrabajo   int  not null,
	TotalManoObra        numeric(10,0) not null,
	Iva                  numeric(10,0) not null,
	TotalPresupuesto     numeric(10,0) not null,
	Observacion          varchar(100)  NULL,
	IdEstado 	     int not null,
	foreign key (IdEstado)references Seguridad.Estado,
	foreign key(IdCliente)references RecursosHumanos.Cliente, 
	foreign key(IdSeguro)references Taller.Seguro	
)
go

/*ARTICULO POR PRESUPUESTO*/
CREATE TABLE Taller.ArticuloxPresupuesto
( 
	IdArticuloxPresupuesto int  not null primary key,
	IdEmpresa int,
	IdArticulo	     int  not null,
	IdPresupuesto        int  not null, 
	IdEstado 	     int not null,
	foreign key (IdEstado)references Seguridad.Estado,
	foreign key(IdArticulo,IdEmpresa)references Taller.Articulo,
	foreign key(IdPresupuesto)references Taller.Presupuesto	
)
go

/*TIPO DE TRABAJO*/
CREATE TABLE Taller.TipoTrabajo
( 
	IdTipoTrabajo        int  not null primary key,
	Descripcion          varchar(100)  not null, 
	IdEstado 	     int not null,
	foreign key (IdEstado)references Seguridad.Estado
)
go

/*MANO DE OBRA*/
create table Taller.ManoObra
( 
	IdManoObra           int  not null primary key,
	IdEmpresa			int,
	IdTipoTrabajo        int  not null,
	idEmpleado	     int not null,
	PrecioHora           numeric(10,0) not null,
	NroHoras             int  not null,
	Precio               numeric(10,0) not null,
	Observacion          varchar(100),
	IdEstado 	     int not null,
	foreign key (IdTipoTrabajo)references Taller.TipoTrabajo,
	foreign key (idEmpleado,idEmpresa)references RecursosHumanos.Empleado,
	foreign key(IdEstado)references Seguridad.Estado 
)
go

/*MANO DE OBRA POR PRESUPUESTO*/
CREATE TABLE Taller.ManoObraxPresupuesto
( 
	IdManoObraPresupuesto int  not null primary key,
	IdPresupuesto        int  not null,
	IdManoObra           int  not null, 
	IdEstado 	     int not null,
	foreign key (IdEstado)references Seguridad.Estado,
	foreign key (IdPresupuesto)references Taller.Presupuesto,
	foreign key (IdManoObra)references Taller.ManoObra
)
go


/*ORDEN TRABAJO*/
CREATE TABLE Taller.OrdenTrabajo
( 
	IdOrdenTrabajo       int  not null primary key,
	Numero               int  not null,
	IdPresupuesto        int  not null,
	FechaModificacion datetime,
	FechaRecepcion       date  not null,
	InicioReparacion     date  not null,
	FechaIngresoVehiculo date  not null,
	HoraIngreso          date  not null,
	FechaEstimadaEntrega date  not null,
	IdEstado 	     int not null, 
	foreign key(IdEstado)references Seguridad.Estado,
	foreign key(IdPresupuesto)references Taller.Presupuesto
)
go

/*SALIDA VEHICULO*/
CREATE TABLE Taller.SalidaVehiculo
( 
	IdSalidaVehiculo     int  not null primary key,
	IdOrdenTrabajo       int  not null,
	PorcentajeTrabajoRealizado int  not null,
	Fecha                date  not null,
	FechaModificacion datetime, 
	IdEstado 	     int not null, 
	foreign key(IdEstado)references Seguridad.Estado,
	foreign key(IdOrdenTrabajo)references Taller.OrdenTrabajo
)
go

 