
use TECA



--TABLA SUBGRUPO DE ACTIVOS FIJOS
insert into ActivoFijo.SubGrupos values (1,11,'Equipos de Computos','2013-07-28',null,'Activo',1);
insert into ActivoFijo.SubGrupos values (2,11,'Equipos de Oficina','2010-05-18',null,'Activo',2);
insert into ActivoFijo.SubGrupos values (3,10,'Muebles de oficina','1995-03-14',null,'Activo',3);
insert into ActivoFijo.SubGrupos values (4,10,'Enseres de oficina','1995-03-14',null,'Activo',4);
insert into ActivoFijo.SubGrupos values (5,6, 'Vehiculos Livianos','2002-08-21',null,'Activo',1);
insert into ActivoFijo.SubGrupos values (6,6, 'Vehiculos de Carga','2002-08-21',null,'Activo',2);
insert into ActivoFijo.SubGrupos values (7,12,'Maquinarias Livianas','1990-03-14',null,'Activo',3);
insert into ActivoFijo.SubGrupos values (8,12,'Maquinarias Pesadas','1990-03-14',null,'Activo',4);
insert into ActivoFijo.SubGrupos values (9,9,'Terenos Planos','1990-03-14',null,'Activo',1);
insert into ActivoFijo.SubGrupos values (10,9,'Terenos Escarpados','1990-03-14',null,'Activo',2);


--Talba de Activo Fijo
insert into ActivoFijo.ActivoFijo values (1,1,1,null,null,null,null,4,9,10,null,1,'Terreno en colina Semi-Empinada',200,300,0,300,null,'Activo','2013-08-20',0,1,'2013-08-29');
insert into ActivoFijo.ActivoFijo values (2,1,2,null,null,null,null,4,9,10,null,2,'Terreno en colina Empinado Parcial',200,300,0,300,null,'Activo','2013-08-20',0,1,'2013-08-29');
insert into ActivoFijo.ActivoFijo values (3,1,3,null,null,null,null,4,12,7,null,3,'Maquinaria de compreción',500,200,300,200,null,'Activo','2013-08-20',10,1,'2013-08-29');
insert into ActivoFijo.ActivoFijo values (4,1,4,null,null,null,null,4,6,6,null,4,'Remolcador',1000,600,400,600,null,'Activo','2013-08-20',5,1,'2013-08-29');
insert into ActivoFijo.ActivoFijo values (5,1,1,null,null,null,null,4,6,6,null,1,'Vehiculo Miniatura',1000,600,400,600,null,'Activo','2013-08-20',5,1,'2013-08-29');
insert into ActivoFijo.ActivoFijo values (6,1,2,null,null,null,null,4,10,3,null,2,'Butaca',1000,600,400,600,null,'Activo','2013-08-20',10,1,'2013-08-29');
insert into ActivoFijo.ActivoFijo values (7,1,3,null,null,null,null,4,11,6,null,3,'Notebook Hp',1000,600,400,600,null,'Activo','2013-08-20',3,1,'2013-08-29');
insert into ActivoFijo.ActivoFijo values (8,1,2,null,null,null,null,4,10,6,null,4,'ButacaPrueba',1000,600,400,600,null,'Activo','2013-08-20',10,1,'2013-08-29');

--Tabla de Terreno 
insert into ActivoFijo.Terreno values (1,'Sur','Terreno sin complicaciones','E-G-09-02-03',590.00,800.00,'2013-09-17');
insert into ActivoFijo.Terreno values (2,'Norte','Terreno sin complicaciones','E-G-12-20-53',400.00,500.00,'2013-09-17');
--Tabla de EquipoMauinariaMuebles
insert into ActivoFijo.EquipoMaquinariaMuebles values (3,null,null ,4,100.80,0,0.37,0.52,0.79,'Ninguna');
--Tabla de Vehiculo 
insert into ActivoFijo.Vehiculo values(4,null,null,4,3,'Serie3',2,'GRP-573',2,0,'Remolcador de transportación de Vehículos',3,'pkr-384','Manual',7000.00,2250,0,'2010-01-20');
insert into ActivoFijo .Vehiculo values(5,null,null,2,1,'Serie1',4,'GPk-8073',2,0,'Vehículos de transportación de repuesto interno',3,'csr-854','Automática',0.45,300,0,'2010-01-20');
--Tabla de EquipoMauinariaMuebles
insert into ActivoFijo.EquipoMaquinariaMuebles values(6,null,null ,5,20.00,0,0.50,0.60,0.40,'Confortable');
insert into ActivoFijo.EquipoMaquinariaMuebles values (7,null,null ,2,15.00,0,0.20,0.30,0.20,'Ligero');
insert into ActivoFijo.EquipoMaquinariaMuebles values(8,null,null ,2,15.00,0,0.45,0.55,0.35,'Confortable');


--Tabla TipoFormato
insert into ActivoFijo.TipoFormato values (1,'SJ11-002');
insert into ActivoFijo.TipoFormato values (2,'PJ11-001');
insert into ActivoFijo.TipoFormato values (3,'KH10-004');
insert into ActivoFijo.TipoFormato values (4,'RG11-004');

--Tabla de Codigo de Barra
insert into ActivoFijo.CodigoBarra values (1,1.50,2.30,'2013-08-29','2013-08-29','2014-08-29',3.5,3.2,1,1,null,'Activo');
insert into ActivoFijo.CodigoBarra values (2,3.50,2.30,'2013-08-26','2013-08-26','2014-08-26',3.5,3.2,0,2,null,'Activo');
insert into ActivoFijo.CodigoBarra values (3,5.50,3.30,'2013-08-28','2013-08-28','2014-08-28',3.5,3.2,0,3,null,'Activo');
insert into ActivoFijo.CodigoBarra values (4,4.50,4.30,'2013-08-27','2013-08-27','2014-08-27',3.5,3.2,1,4,null,'Activo');


go 