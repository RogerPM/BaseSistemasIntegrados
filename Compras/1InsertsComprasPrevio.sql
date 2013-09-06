use TECA
go
/*													SEGURIDAD												*/
--go
/******************ESTADO********************/
insert into Seguridad.Estado values(1,'Activa')
go
insert into Seguridad.Estado values(2,'Inactiva')
go
insert into Seguridad.Estado values(3,'Remodelacion')
go
insert into Seguridad.Estado values(4,'Bancarota')
go
insert into Seguridad.Estado values(5,'Proceso de Fusion')
go
insert into Seguridad.Estado values(6,'Incautada')
go
insert into Seguridad.Estado values(7,'Clausurada')
go
insert into Seguridad.Estado values(8,'Nuevo')
go
insert into Seguridad.Estado values(9,'Usado')
go
--truncate table Seguridad.Empresa
/*********************EMPRESA*****************/
insert into Seguridad.Empresa values(1,'Empresa XYZ SA','XYZ','0981357236001','Mexico DF',null,null,'informacion@xyz.org','www.xyzmundial.org','Sector publico','Institucion publica conocida mundialmente dedicada al analisis financiero',1)
go
insert into Seguridad.Empresa values(2,'Sandy Corporation','Veterinarias Sandy','0944254432001','Clda Sauces 7 manzana 16 villa 5b, edificio de tres plantas',null,null,'info@sandy.com.ec','www.sandy.blogspot.com' ,'Sector privado','Dedicada al cuidado de animales en general',4)
go
insert into Seguridad.Empresa values(3,'Bayerische Motoren Werke','BMW','0977281371001','Alemania',null,null,'bavarian@bmw.gr','www.bmw.gr','Sector privado','Proveedor internacional de vehiculos',5)
go
insert into Seguridad.Empresa values(4,'Textiles Judas SA','Prendas Judas','0972254938001','Km 5.5 via samborondon',null,null,'pedidos@judas.com','www.sanjudas.com.ec','Sector privado','Empresa dedicada a la manofactura de vestimentas',3)
go
/*																RRHH											*/

/***************tipo de persona*************/
insert into RecursosHumanos.TipoPersona values (1,'Natural',1,1)
go
insert into RecursosHumanos.TipoPersona values (2,'Juridica',1,1)
go

/*tipo de identificacion*/
insert into RecursosHumanos.TipoIdentificacion values (1,'Cedula',1,1)
go
insert into RecursosHumanos.TipoIdentificacion values (2,'Ruc',1,1)
go
insert into RecursosHumanos.TipoIdentificacion values (3,'Pasaporte',1,1)
go
insert into RecursosHumanos.TipoIdentificacion values (4,'carnet',1,1)
go

-------------------------------INSERTS DE PERSONAS X COMPRAS		-----------------------------------------
insert into RecursosHumanos.Persona (IdPersona,Identificacion,IdTipoPersona,IdEmpresa,NombreRazonSocial,
Apellido,TipoIdentificacion,direccion,TelefonoMovil,TelefonoCasa,mail,IdEstado)
values(101,0927083782,1,1,'FEDIT S.A','Mayorga',1,'Norte',0990543893,0429017,'jorg_mayo@hotmail.com',1)

insert into RecursosHumanos.Persona (IdPersona,Identificacion,IdTipoPersona,IdEmpresa,NombreRazonSocial,
Apellido,TipoIdentificacion,direccion,TelefonoMovil,TelefonoCasa,mail,IdEstado)
values(102,0926073777,1,1,'SAP S.A','Silva',1,'Este',0994373503,04290677,'ja_@hotmail.com',1)

insert into RecursosHumanos.Persona (IdPersona,Identificacion,IdTipoPersona,IdEmpresa,NombreRazonSocial,
Apellido,TipoIdentificacion,direccion,TelefonoMovil,TelefonoCasa,mail,IdEstado)
values(103,0904083791,1,1,'INK S.A','Leon',1,'Oeste',0980963810,04293327,'p_@gmail.com',1)

insert into RecursosHumanos.Persona (IdPersona,Identificacion,IdTipoPersona,IdEmpresa,NombreRazonSocial,
Apellido,TipoIdentificacion,direccion,TelefonoMovil,TelefonoCasa,mail,IdEstado)
values(104,0929993522,1,1,'INNOBAN S.A','Guachizaca',1,'Sur',0900548763,04277527,'al_@yahoo.com',1)

insert into RecursosHumanos.Persona (IdPersona,Identificacion,IdTipoPersona,IdEmpresa,NombreRazonSocial,
Apellido,TipoIdentificacion,direccion,TelefonoMovil,TelefonoCasa,mail,IdEstado)
values(105,0930073155,1,1,'ALISC S.A','Jativa',1,'Norte',0988373773,04296211,'jat_@hotmail.com',1)

insert into RecursosHumanos.Persona (IdPersona,Identificacion,IdTipoPersona,IdEmpresa,NombreRazonSocial,
Apellido,TipoIdentificacion,direccion,TelefonoMovil,TelefonoCasa,mail,IdEstado)
values(106,0904093791,1,1,'MAMUT S.A','Peña',1,'Sur',0910961843,04273132,'mipe_@gmail.com',1)

insert into RecursosHumanos.Persona (IdPersona,Identificacion,IdTipoPersona,IdEmpresa,NombreRazonSocial,
Apellido,TipoIdentificacion,direccion,TelefonoMovil,TelefonoCasa,mail,IdEstado)
values(107,0927183782,1,1,'BASKIN S.A','Moscoso',1,'oeste',0990543893,0429017,'edimos_@yahoo.com',1)

insert into RecursosHumanos.Persona (IdPersona,Identificacion,IdTipoPersona,IdEmpresa,NombreRazonSocial,
Apellido,TipoIdentificacion,direccion,TelefonoMovil,TelefonoCasa,mail,IdEstado)
values(108,0921073777,1,1,'BASEGES S.A','Moreno',1,'Este',0994373503,0420677,'andres_@gmail.com',1)

insert into RecursosHumanos.Persona (IdPersona,Identificacion,IdTipoPersona,IdEmpresa,NombreRazonSocial,
Apellido,TipoIdentificacion,direccion,TelefonoMovil,TelefonoCasa,mail,IdEstado)
values(109,0976044799,1,1,'P&G S.A','Catuto',1,'Este',0980963810,0423327,'FEX_@hotmail.com',1)

insert into RecursosHumanos.Persona (IdPersona,Identificacion,IdTipoPersona,IdEmpresa,NombreRazonSocial,
Apellido,TipoIdentificacion,direccion,TelefonoMovil,TelefonoCasa,mail,IdEstado)
values(110,0920073772,1,1,'MODENA S.A','Salinas',1,'Norte',0981234389,0428015,'eduardo_@hotmail.com',1)

insert into RecursosHumanos.Persona (IdPersona,Identificacion,IdTipoPersona,IdEmpresa,NombreRazonSocial,
Apellido,TipoIdentificacion,direccion,TelefonoMovil,TelefonoCasa,mail,IdEstado)
values(111,0922353123,1,1,'ELEFONT S.A','Gonzabay',1,'Sur',0926843610,04230321,'pedr_gon@gmail.com',1)

insert into RecursosHumanos.Persona (IdPersona,Identificacion,IdTipoPersona,IdEmpresa,NombreRazonSocial,
Apellido,TipoIdentificacion,direccion,TelefonoMovil,TelefonoCasa,mail,IdEstado)
values(112,0905567837,1,1,'TREVALI S.A','Limon',1,'Sur',0912345677,04254321,'carlos@espol.edu.ec',1)

insert into RecursosHumanos.Persona (IdPersona,Identificacion,IdTipoPersona,IdEmpresa,NombreRazonSocial,
Apellido,TipoIdentificacion,direccion,TelefonoMovil,TelefonoCasa,mail,IdEstado)
values(113,0912345678,1,1,'SLP S.A','Daluz',1,'Norte',0998765432,04295347,'johndaluz@gmail.com',1)

insert into RecursosHumanos.Persona (IdPersona,Identificacion,IdTipoPersona,IdEmpresa,NombreRazonSocial,
Apellido,TipoIdentificacion,direccion,TelefonoMovil,TelefonoCasa,mail,IdEstado)
values(114,0930012345,1,1,'OPTIFULL S.A','Mendez',1,'Oeste',0924683773,04135792,'patom_@hotmail.com',1)

insert into RecursosHumanos.Persona (IdPersona,Identificacion,IdTipoPersona,IdEmpresa,NombreRazonSocial,
Apellido,TipoIdentificacion,direccion,TelefonoMovil,TelefonoCasa,mail,IdEstado)
values(115,0913141516,1,1,'TRASCENDA S.A','Reyes',1,'Oeste',0923452626,04414253,'bettyr_@espol.edu.ec',1)

insert into RecursosHumanos.Persona (IdPersona,Identificacion,IdTipoPersona,IdEmpresa,NombreRazonSocial,
Apellido,TipoIdentificacion,direccion,TelefonoMovil,TelefonoCasa,mail,IdEstado)
values(116,0992939495,1,1,'QUALCOMM S.A','Mero',1,'Norte',0981828384,04727374,'joseM_@gmail.com',1)
go
--------------------------------Usuario compras2013------------------------------------------------------------
insert into RecursosHumanos.Persona (IdPersona,Identificacion,IdTipoPersona,IdEmpresa,NombreRazonSocial,
Apellido,TipoIdentificacion,direccion,TelefonoMovil,TelefonoCasa,mail,IdEstado)
values(117,0998889293,1,1,'CMP SA','Cuenca',1,'Sur',0981252627,04398373,'LuisC_@hotmail.com',1)
go
insert into Seguridad.Usuario (IdUsuario,NombreUsuario,Contrasena,IdEstado)
values (117,'compras2013','compras',1)



/*										RRHH.DEPARTAMENTO										*/
insert into RecursosHumanos.Departamento values(1,'Ventas',1)
insert into RecursosHumanos.Departamento values(2,'Atención al cliente',1)
insert into RecursosHumanos.Departamento values(3,'Contabilidad',1)
insert into RecursosHumanos.Departamento values(4,'Recursos Humanos',1)
GO

--														Inventario
--++++++++++++++++++++++++++++++++++ TIPO_ARTICULO +++++++++++++++++++++++++++++++++++++
-- BARRIDA DE INSERTS PARA LA EMPRESA 1, SI SE QUIEREN PARA LAS DEMAS EMPRESAS SE PUEDEN REUTILIZAR 
-- LOS MISMOS O CREAR APARTE, DEPENDE DE COMO VALIDARAN
insert into Inventario.TipoArticulo values (1,1,'SuministrosdeOficina',1)
insert into Inventario.TipoArticulo values (1,2,'SuministrosdeLimpieza',1)
insert into Inventario.TipoArticulo values (1,3,'Mercaderia',1)
insert into Inventario.TipoArticulo values (1,4,'ActivoFijo',1)
Go
--++++++++++++++++++++++++++++++++++ GRUPO +++++++++++++++++++++++++++++++++++++
insert into Inventario.Grupo values (1,1, 'Papeleria', 1, 1)
insert into Inventario.Grupo values (1,2, 'InsumosdeOficina',1, 1)
insert into Inventario.Grupo values (1,3, 'Detergentes', 2,1)
insert into Inventario.Grupo values (1,4, 'Desinfectantes',2, 1)
insert into Inventario.Grupo values (1,5, 'InstrumentodeLimpieza',2, 1)
insert into Inventario.Grupo values (1,6, 'Vehiculos',3,1)
insert into Inventario.Grupo values (1,7, 'Accesorios',3, 1)
insert into Inventario.Grupo values (1,8, 'Edificio',4, 1)
insert into Inventario.Grupo values (1,9, 'Terreno', 4,1)
insert into Inventario.Grupo values (1,10, 'MueblesyEnseres',4, 1)
insert into Inventario.Grupo values (1,11, 'Equipos',4, 1)
insert into Inventario.Grupo values (1,12, 'Maquinaria',4, 1)
go
--++++++++++++++++++++++++++++++++++ UNIDAD_MEDIDA +++++++++++++++++++++++++++++++++++++
insert into Inventario.UnidadMedida values (1,1, 'lts.', 1)
insert into Inventario.UnidadMedida values (2,2, 'kg', 2)
insert into Inventario.UnidadMedida values (3,3, 'lb', 3)
insert into Inventario.UnidadMedida values (4,4, 'gr', 2)
go
--++++++++++++++++++++++++++++++++++ CHASIS +++++++++++++++++++++++++++++++++++++
insert into Inventario.Chasis values (2,1, 'En escalera', 1)
insert into Inventario.Chasis values (3,2, 'Tubular', 3)
insert into Inventario.Chasis values (4,3, 'MultiTubular', 2)
insert into Inventario.Chasis values (1,4, 'Cercha', 1)
insert into Inventario.Chasis values (2,5, 'MonoCasco', 3)
go
--++++++++++++++++++++++++++++++++++ TIPOMOTOR +++++++++++++++++++++++++++++++++++++
--select * from Inventario.TipoMotor
insert into Inventario.TipoMotor values (1,1, 'Motor Electrico', 1)
insert into Inventario.TipoMotor values (2,2, 'Motor de Combustion Interna', 1)
insert into Inventario.TipoMotor values (1,3, 'Motor Hibrido', 1)
go
--++++++++++++++++++++++++++++++++++ TIPO_COMBUSTIBLE +++++++++++++++++++++++++++++++++++++
insert into Inventario.TipoCombustible values (2,1, 'Gasolina', 1)
insert into Inventario.TipoCombustible values (2,2, 'Diesel', 2)
insert into Inventario.TipoCombustible values (1,3, 'Gas', 3)
insert into Inventario.TipoCombustible values (3,4, 'Electricidad', 1)
go
--++++++++++++++++++++++++++++++++++ COLOR +++++++++++++++++++++++++++++++++++++
Insert into Inventario.Color values (1,1, 'Gris', 2)
insert into Inventario.Color values (2,2, 'Negro',4)
insert into Inventario.Color values (2,3, 'Blanco',3)
insert into Inventario.Color values (3,4, 'Azul', 2)
insert into Inventario.Color values (1,5, 'Rojo', 1)
go
--++++++++++++++++++++++++++++++++++ MARCA +++++++++++++++++++++++++++++++++++++
insert into Inventario.Marca values (1,1, 'Renault', 1)
insert into Inventario.Marca values (2,2, 'Chevrolet',1)
insert into Inventario.Marca values (3,3, 'Peugeot', 2)
insert into Inventario.Marca values (4,4, 'Toyota', 1)
insert into Inventario.Marca values (1,5, 'Suzuki', 1)
insert into Inventario.Marca values (2,6, 'BIC',  1)
insert into Inventario.Marca values (3,7, 'CopyLaser', 1)
insert into Inventario.Marca values (4,8, 'Deja', 1)
go
--++++++++++++++++++++++++++++++++++ MODELO +++++++++++++++++++++++++++++++++++++
insert into Inventario.Modelo values (1,1,'Sandero',1,1)
insert into Inventario.Modelo values (2,2,'Sail',2,1)
insert into Inventario.Modelo values (3,3,'RCZ',3,2)
insert into Inventario.Modelo values (4,4,'Corolla',4,1)
insert into Inventario.Modelo values (1,5,'Grand Vitara',5,1)
--++++++++++++++++++++++++++++++++++ TIPO_MATERIAL +++++++++++++++++++++++++++++++++++++
go
insert into Inventario.TipoMaterial values (1,1, 'Acero', 1)
insert into Inventario.TipoMaterial values (2,2, 'Aluminio', 2)
insert into Inventario.TipoMaterial values (3,3, 'Hierro', 3)
insert into Inventario.TipoMaterial values (1,5, 'Titanio', 4)
insert into Inventario.TipoMaterial values (2,4, 'Madera', 3)
insert into Inventario.TipoMaterial values (1,6, 'Plastico',3)
go

--insert de articulos x compras



insert into Inventario.articulo  (idEmpresa,idArticulo, Descripcion,CantidadActual,IdUnidadMedida,IdTipoArticulo,
IdGrupo,idEstado)
values(1,101,'Resma Papel Bond',50,2,1,1,1)
go
insert into Inventario.articulo  (idEmpresa,idArticulo, Descripcion,CantidadActual,IdUnidadMedida,IdTipoArticulo,
IdGrupo,idEstado)
values(1,102,'Resma Papel Carta',100,2,1,1,1)
go
insert into Inventario.articulo  (idEmpresa,idArticulo, Descripcion,CantidadActual,IdUnidadMedida,IdTipoArticulo,IdGrupo,idEstado)
values(1,103,'Resma Papel couche',50,2,1,1,1)
go

insert into Inventario.articulo  (idEmpresa,idArticulo, Descripcion,CantidadActual,IdUnidadMedida,IdTipoArticulo,IdGrupo,IdEstado)
values(1,104,'caja de lapices',5,4,1,2,1)
go
insert into Inventario.articulo  (idEmpresa,idArticulo, Descripcion,CantidadActual,IdUnidadMedida,IdTipoArticulo,IdGrupo,IdEstado)
values(1,105,'caja de plumas Bic',8,4,1,2,1)
go
insert into Inventario.articulo  (idEmpresa,idArticulo, Descripcion,CantidadActual,IdUnidadMedida,IdTipoArticulo,IdGrupo,IdEstado)
values(1,106,'caja de clip',2,4,1,2,1)
go
insert into Inventario.articulo  (idEmpresa,idArticulo, Descripcion,CantidadActual,IdUnidadMedida,IdTipoArticulo,IdGrupo,IdEstado)
values(1,107,'OMO',5,2,2,3,1)
go
insert into Inventario.articulo  (idEmpresa,idArticulo, Descripcion,CantidadActual,IdUnidadMedida,IdTipoArticulo,IdGrupo,IdEstado)
values(1,108,'Ciclon',10,2,2,3,1)
go
insert into Inventario.articulo  (idEmpresa,idArticulo, Descripcion,CantidadActual,IdUnidadMedida,IdTipoArticulo,IdGrupo,IdEstado)
values(1,109,'Fab',5,2,2,3,1)

insert into Inventario.articulo  (idEmpresa,idArticulo, Descripcion,CantidadActual,IdUnidadMedida,IdTipoArticulo,IdGrupo,IdEstado)
values(1,110,'Olimpia',6,1,2,4,1)
go
insert into Inventario.articulo  (idEmpresa,idArticulo, Descripcion,CantidadActual,IdUnidadMedida,IdTipoArticulo,IdGrupo,IdEstado)
values(1,111,'Pinoklin',5,1,2,4,1)
go
insert into Inventario.articulo  (idEmpresa,idArticulo, Descripcion,CantidadActual,IdUnidadMedida,IdTipoArticulo,IdGrupo,IdEstado)
values(1,112,'fresh',5,1,2,4,1)
go
insert into Inventario.articulo  (idEmpresa,idArticulo, Descripcion,CantidadActual,IdUnidadMedida,IdTipoArticulo,IdGrupo,IdEstado)
values(1,113,'limpia vidrio',5,1,2,5,1)
go
insert into Inventario.articulo  (idEmpresa,idArticulo, Descripcion,CantidadActual,IdUnidadMedida,IdTipoArticulo,IdGrupo,IdEstado)
values(1,114,'BRIGHT',5,1,2,5,1)
go
insert into Inventario.articulo  (idEmpresa,idArticulo, Descripcion,CantidadActual,IdUnidadMedida,IdTipoArticulo,IdGrupo,IdEstado)
values(1,115,'Vidrioclean',5,1,2,5,1)
go

insert into Inventario.articulo  (idEmpresa,idArticulo, Descripcion,CantidadActual,IdUnidadMedida,IdTipoArticulo,IdGrupo,IdChasis,
IdTipoMotor,IdTipoCombustible,IdColor,IdMarca,IdModelo,IdTipoMaterial,IdEstado)
values(1,116,'Vehiculo',5,2,3,6,2,2,1,2,2,5,2,1)
go
insert into Inventario.articulo  (idEmpresa,idArticulo, Descripcion,CantidadActual,IdUnidadMedida,IdTipoArticulo,IdGrupo,IdChasis,
IdTipoMotor,IdTipoCombustible,IdColor,IdMarca,IdModelo,IdTipoMaterial,IdEstado)
values(1,117,'Vehiculo',3,2,3,6,2,2,1,2,2,1,2,1)
go
insert into Inventario.articulo  (idEmpresa,idArticulo, Descripcion,CantidadActual,IdUnidadMedida,IdTipoArticulo,IdGrupo,IdChasis,
IdTipoMotor,IdTipoCombustible,IdColor,IdMarca,IdModelo,IdTipoMaterial,IdEstado)
values(1,118,'Vehiculo',1,2,3,6,2,2,1,2,2,2,2,1)
go

insert into Inventario.articulo  (idEmpresa,idArticulo, Descripcion,CantidadActual,IdUnidadMedida,IdTipoArticulo,IdGrupo,IdTipoMaterial,IdEstado)
values(1,119,'Radio',5,2,3,7,5,1)
go
insert into Inventario.articulo  (idEmpresa,idArticulo, Descripcion,CantidadActual,IdUnidadMedida,IdTipoArticulo,IdGrupo,IdTipoMaterial,IdEstado)
values(1,120,'Amplificador',10,2,3,7,5,1)
go
insert into Inventario.articulo  (idEmpresa,idArticulo, Descripcion,CantidadActual,IdUnidadMedida,IdTipoArticulo,IdGrupo,IdTipoMaterial,IdEstado)
values(1,121,'Detector de radar',5,2,3,7,5,1)
go
--------------------------------------------------------------------------------------------
/*					--				--			--			COMPRAS			--			--			--		*/	

--INSERT DE COMPRAS.ESTADO
insert into Compras.Estado values (1, 'Activo')
insert into Compras.estado values (2, 'Inactivo')
insert into Compras.estado values (3, 'Procesado')
go

--------------------------------proveedor---------------------------------------------------

insert into Compras.Proveedor (IdProveedor,IdEmpresa,IdPersona,IdTipoArticulo,Estado)
values (1,1,101,1,1)

insert into Compras.Proveedor (IdProveedor,IdEmpresa,IdPersona,IdTipoArticulo,Estado)
values (2,1,102,1,1)

insert into Compras.Proveedor (IdProveedor,IdEmpresa,IdPersona,IdTipoArticulo,Estado)
values (3,1,103,1,1)

insert into Compras.Proveedor (IdProveedor,IdEmpresa,IdPersona,IdTipoArticulo,Estado)
values (4,1,104,1,1)

insert into Compras.Proveedor (IdProveedor,IdEmpresa,IdPersona,IdTipoArticulo,Estado)
values (5,1,105,2,1)

insert into Compras.Proveedor (IdProveedor,IdEmpresa,IdPersona,IdTipoArticulo,Estado)
values (6,1,106,2,1)

insert into Compras.Proveedor (IdProveedor,IdEmpresa,IdPersona,IdTipoArticulo,Estado)
values (7,1,107,2,1)

insert into Compras.Proveedor (IdProveedor,IdEmpresa,IdPersona,IdTipoArticulo,Estado)
values (8,1,108,2,1)

insert into Compras.Proveedor (IdProveedor,IdEmpresa,IdPersona,IdTipoArticulo,Estado)
values (9,1,109,3,1)

insert into Compras.Proveedor (IdProveedor,IdEmpresa,IdPersona,IdTipoArticulo,Estado)
values (10,1,110,3,1)

insert into Compras.Proveedor (IdProveedor,IdEmpresa,IdPersona,IdTipoArticulo,Estado)
values (11,1,111,3,1)

insert into Compras.Proveedor (IdProveedor,IdEmpresa,IdPersona,IdTipoArticulo,Estado)
values (12,1,112,3,1)

insert into Compras.Proveedor (IdProveedor,IdEmpresa,IdPersona,IdTipoArticulo,Estado)
values (13,1,113,4,1)

insert into Compras.Proveedor (IdProveedor,IdEmpresa,IdPersona,IdTipoArticulo,Estado)
values (14,1,114,4,1)

insert into Compras.Proveedor (IdProveedor,IdEmpresa,IdPersona,IdTipoArticulo,Estado)
values (15,1,115,4,1)
insert into Compras.Proveedor (IdProveedor,IdEmpresa,IdPersona,IdTipoArticulo,Estado)
values (16,1,116,4,1)

/*							PROCESOS COMPRAS											*/
--												SOLICITUDES CAB Y DET
insert into Compras.Solicitud (Numero, idEmpresa,IdtipoArticulo, IdUsuario,idDepartamento, idEstado)
values		(1,1,2,117,3,1)-----cab
insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(1,1,1,107,15)-------det
insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(1,1,2,108,3)--------det
go

insert into Compras.Solicitud (Numero, idEmpresa,IdtipoArticulo, IdUsuario,idDepartamento, idEstado)
values		(2,1,3,117,4,1)
insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(2,1,1,116,2)
insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(2,1,2,117,1)
go

insert into Compras.Solicitud (Numero, idEmpresa,IdtipoArticulo, IdUsuario,idDepartamento, idEstado)
values		(3,1,3,117,2,1)
insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(3,1,1,117,2)
insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(3,1,2,118,2)
go

insert into Compras.Solicitud (Numero, idEmpresa,IdtipoArticulo, IdUsuario,idDepartamento, idEstado)
values		(4,1,1,117,2,1)
insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(4,1,1,102,8)
insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(4,1,2,103,8)
go

insert into Compras.Solicitud (Numero, idEmpresa,IdtipoArticulo, IdUsuario,idDepartamento, idEstado)
values		(5,1,1,117,1,1)
insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(5,1,1,105,10)
insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(5,1,2,106,5)
go

insert into Compras.Solicitud (Numero, idEmpresa,IdtipoArticulo, IdUsuario,idDepartamento, idEstado)
values		(6,1,1,117,3,1)
insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(6,1,1,103,2)
insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(6,1,2,104,15)
go

insert into Compras.Solicitud (Numero, idEmpresa,IdtipoArticulo, IdUsuario,idDepartamento, idEstado)
values		(7,1,2,117,3,1)
insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(7,1,1,109,10)
insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(7,1,2,110,5)
go

insert into Compras.Solicitud (Numero, idEmpresa,IdtipoArticulo, IdUsuario,idDepartamento, idEstado)
values		(8,1,3,117,4,1)
insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(8,1,1,119,1)
insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(8,1,2,120,3)
go

insert into Compras.Solicitud (Numero, idEmpresa,IdtipoArticulo, IdUsuario,idDepartamento, idEstado)
values		(9,1,3,117,2,1)
insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(9,1,1,120,1)
insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(9,1,2,121,2)
go

insert into Compras.Solicitud (Numero, idEmpresa,IdtipoArticulo, IdUsuario,idDepartamento, idEstado)
values		(10,1,1,117,2,1)
insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(10,1,1,101,3)
insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(10,1,2,105,5)
go

insert into Compras.Solicitud (Numero, idEmpresa,IdtipoArticulo, IdUsuario,idDepartamento, idEstado)
values		(11,1,1,117,1,1)

insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(11,1,1,101,10)
insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(11,1,2,103,5)

insert into Compras.Solicitud (Numero, idEmpresa,IdtipoArticulo, IdUsuario,idDepartamento, idEstado)
values		(12,1,2,117,3,1)
insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(12,1,1,112,2)
insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(12,1,2,113,10)
go
---solicitudCab
insert into Compras.Solicitud (Numero, idEmpresa,IdtipoArticulo, IdUsuario,idDepartamento, idEstado)
values		(13,1,2,117,1,1),
            (14,1,3,117,3,1),
            (15,1,1,117,4,1),
            (16,1,2,117,4,1),
            (17,1,3,117,3,1),
            (18,1,2,117,1,1)
go

----solicitudDet
insert into Compras.SolicitudDet (Numero, idEmpresa,Linea,idArticulo,Cantidad)
values		(13,1,1,107,1),
            (13,1,2,108,5),
            
            (14,1,1,116,1),
            (14,1,2,117,1),
            
            (15,1,1,104,20),
            (15,1,2,105,25),
            
            (16,1,1,108,30),
            (16,1,2,109,33),
            
            (17,1,1,120,3),
            (17,1,2,121,2),
            
            (18,1,1,114,52),
            (18,1,2,115,55)

------------------insert Pedido Cab--------------------------------------------------
insert into Compras.Pedido (Numero, idEmpresa, idUsuario,idTipoarticulo, idEstado)
values (1,1,117,1,1)--sol1
insert into Compras.Pedido (Numero, idEmpresa, idUsuario,idTipoArticulo, idEstado)
values (2,1,117,2,1)--sol2
insert into Compras.Pedido (Numero, idEmpresa, idUsuario,idTipoarticulo, idEstado)
values (3,1,117,3,1)--sol3
insert into Compras.Pedido (Numero, idEmpresa, idUsuario,idTipoarticulo, idEstado)
values (4,1,117,2,1)--sol4
-- -----------insert Pedido Detalle--------------------------------------------------
insert into Compras.PedidoDet (Numero, idEmpresa, Linea, idArticulo, Cantidad)
values (1,1,1,102,27),
       (1,1,2,103,10),
       (1,1,3,104,15)
insert into Compras.PedidoDet (Numero, idEmpresa, Linea, idArticulo, Cantidad)
values (2,1,1,107,1),
       (2,1,2,108,35),
       (2,1,3,109,33)
insert into Compras.PedidoDet (Numero, idEmpresa, Linea, idArticulo, Cantidad)
values (3,1,1,116,2),
       (3,1,2,117,3),
       (3,1,3,118,2)
insert into Compras.PedidoDet (Numero, idEmpresa, Linea, idArticulo, Cantidad)
values (4,1,1,109,10),
       (4,1,2,110,5),
       (4,1,3,112,2),
       (4,1,4,113,10) 

-------------------------cotizacion-----------------------------------------------
insert into compras.Cotizacion(Numero,idEmpresa,IdUsuario,idProveedor,idEstado)
values (1,1,117,2,1)
insert into compras.Cotizacion(Numero,idEmpresa,IdUsuario,idProveedor,idEstado)
values (2,1,117,3,1)
insert into compras.Cotizacion(Numero,idEmpresa,IdUsuario,idProveedor,idEstado)
values (3,1,117,4,1)

insert into compras.Cotizacion(Numero,idEmpresa,IdUsuario,idProveedor,idEstado)
values (4,1,117,9,1)
insert into compras.Cotizacion(Numero,idEmpresa,IdUsuario,idProveedor,idEstado)
values (5,1,117,10,1)
insert into compras.Cotizacion(Numero,idEmpresa,IdUsuario,idProveedor,idEstado)
values (6,1,117,11,1)

insert into compras.Cotizacion(Numero,idEmpresa,IdUsuario,idProveedor,idEstado)
values (7,1,117,5,1)
insert into compras.Cotizacion(Numero,idEmpresa,IdUsuario,idProveedor,idEstado)
values (8,1,117,6,1)
insert into compras.Cotizacion(Numero,idEmpresa,IdUsuario,idProveedor,idEstado)
values (9,1,117,7,1)


--------------------------cotizaciondet--------------------------------------------
insert into Compras.CotizacionDet (Numero,idEmpresa,Linea,NumeroPedido)
values (1,1,1,1),--pedido 1
       (2,1,1,1),
       (3,1,1,1)
       
insert into Compras.CotizacionDet (Numero,idEmpresa,Linea,NumeroPedido)
values (4,1,1,3),--pedido 3
       (5,1,1,3),
       (6,1,1,3)

insert into Compras.CotizacionDet (Numero,idEmpresa,Linea,NumeroPedido)
values (7,1,1,2),--pedido 2
       (8,1,1,2),
       (9,1,1,2)

-------------------------------------OrdenCompra----------------------------------------------------------

insert into Compras.OrdenCompra (IdOrdenCompra,idEmpresa,IdUsuario,idProveedor,NumeroCotizacion,idEstado)
values (1,1,117,7,9,1)
insert into Compras.OrdenCompra (IdOrdenCompra,idEmpresa,IdUsuario,idProveedor,NumeroCotizacion,idEstado)
values (2,1,117,4,3,1)

-------------------------------------OrdenCompraDet------------------------------------------------------
insert into Compras.OrdenCompraDet (Numero,IdEmpresa,Linea,IdArticulo,Cantidad,Precio)
values (1,1,1,107,1,1),
       (1,1,2,108,35,3),
       (1,1,3,109,33,2)
insert into Compras.OrdenCompraDet (Numero,IdEmpresa,Linea,IdArticulo,Cantidad,Precio)
values (2,1,1,102,27,3),
       (2,1,2,103,10,5),
       (2,1,3,104,15,7)

       
