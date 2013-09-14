use TECA
go

--          .-+=*°"|:|:|[INSERTS A TABLA FRECUENCIA DE PAGO]|:|:|°*=+-.

insert into CuentaxPagar.FrecuenciaPago  values(1,'Dias', '2013-07-27',1,11,1)
go
insert into CuentaxPagar.FrecuenciaPago  values(2,'Semanas', '2013-07-27',1,11,1)
go
insert into CuentaxPagar.FrecuenciaPago  values(3,'Meses', '2013-07-27',1,11,1)
go
insert into CuentaxPagar.FrecuenciaPago  values(4,'Semestres', '2013-07-27',1,11,1)
go
insert into CuentaxPagar.FrecuenciaPago  values(5,'Años', '2013-07-27',1,11,1)
go

--            .-+=*°"|:|:|[INSERTS A TABLA MEDIO DE PAGO]|:|:|°*=+-.

insert into CuentaxPagar.MedioPago  values(1,'Efectivo', '2013-07-27',1,1,11)
go
insert into CuentaxPagar.MedioPago  values(2,'Cheque', '2013-07-27',1,1,11)
go
insert into CuentaxPagar.MedioPago  values(3,'Tarjeta Credito', '2013-07-27',1,1,11)
go
insert into CuentaxPagar.MedioPago  values(4,'Transferencia', '2013-07-27',1,1,11)
go
insert into CuentaxPagar.MedioPago  values(5,'Bien Mueble', '2013-07-27',1,1,11)
go

--               .-+=*°"|:|:|[INSERTS A TABLA IMPUESTO]|:|:|°*=+-.

insert into CuentaxPagar.Impuesto  values(1,'IVA 0%', 0.00,'2013-07-27',1,1,11)
go
insert into CuentaxPagar.Impuesto  values(2,'IVA 12%', 12.00,'2013-07-27',1,1,11)
go
insert into CuentaxPagar.Impuesto  values(3,'RETENCION 1%', 1.00, '2013-07-27',1,1,11)
go
insert into CuentaxPagar.Impuesto  values(4,'RETENCION 2%', 2.00, '2013-07-27',1,1,11)
go
insert into CuentaxPagar.Impuesto  values(5,'RETENCION 8%', 8.00, '2013-07-27',1,1,11)
go

--           .-+=*°"|:|:|[INSERTS A TABLA EMPRESA DE SERVICIO]|:|:|°*=+-.

insert into CuentaxPagar.EmpresaServicio values('0927771895001', '2013-07-27', 'Claro', 'Guayaquil', 'asda', 'asdafdf', 1, 1, 1, 11)
go
insert into CuentaxPagar.EmpresaServicio values('0982561267001', '2013-07-27', 'Movistar', 'Guayaquil', 'asda', 'asdafdf', 1, 1, 1, 11)
go
insert into CuentaxPagar.EmpresaServicio values('0982571267001', '2013-07-27', 'CNT', 'Guayaquil', 'asda', 'asdafdf', 1, 1, 1, 11)
go
insert into CuentaxPagar.EmpresaServicio values('0982561217001', '2013-07-27', 'TVCable', 'Guayaquil', 'asda', 'asdafdf', 1, 1, 1, 11)
go
insert into CuentaxPagar.EmpresaServicio values('0982531267001', '2013-07-27', 'Transporte ejecutivo', 'Guayaquil', 'asda', 'asdafdf', 1, 1, 1, 11)
go

--                 .-+=*°"|:|:|[INSERTS A TABLA BANCO DE CTAS X COB]|:|:|°*=+-.

insert into CuentasPorCobrar.Banco values(1, 1, 'Banco del Pichincha', 'A')
go
insert into CuentasPorCobrar.Banco values(1, 2, 'Banco del Pacífico', 'A')
go
insert into CuentasPorCobrar.Banco values(1, 3, 'Banco del Austro', 'A')
go
insert into CuentasPorCobrar.Banco values(1, 4, 'Banco Bolivariano', 'A')
go
insert into CuentasPorCobrar.Banco values(1, 5, 'Banco de CoopNacional', 'A')
go

--             .-+=*°"|:|:|[INSERTS A TABLA CUENTA BANCARIA 2]|:|:|°*=+-.

insert into CuentaxPagar.CuentaBancaria2 values(1, 'Ahorros', '0978173927846', 1, 1, '0927771895001')
go
insert into CuentaxPagar.CuentaBancaria2 values(2, 'Crédito', '0978171827846', 1, 1, '0927771895001')
go
insert into CuentaxPagar.CuentaBancaria2 values(3, 'Ahorros', '0970957927846', 1, 1, '0982561267001')
go
insert into CuentaxPagar.CuentaBancaria2 values(4, 'Crédito', '1046773927846', 1, 1, '0982561267001')
go
insert into CuentaxPagar.CuentaBancaria2 values(5, 'Ahorros', '1758173927846', 1, 1, '0982571267001')
go
insert into CuentaxPagar.CuentaBancaria2 values(6, 'Crédito', '0978187927846', 1, 1, '0982571267001')
go
insert into CuentaxPagar.CuentaBancaria2 values(7, 'Ahorros', '1198473927846', 1, 1, '0982561217001')
go
insert into CuentaxPagar.CuentaBancaria2 values(8, 'Crédito', '1984187927846', 1, 1, '0982561217001')
go
insert into CuentaxPagar.CuentaBancaria2 values(9, 'Ahorros', '1759377927846', 1, 1, '0982531267001')
go
insert into CuentaxPagar.CuentaBancaria2 values(10, 'Crédito', '8904187927846', 1, 1, '0982561217001')
go

--             .-+=*°"|:|:|[INSERTS A TABLA TIPO DE TELÉFONO DE RRHH]|:|:|°*=+-.

insert into RecursosHumanos.TipoTelefono values(1, 'Convencional', 1, 1)
go
insert into RecursosHumanos.TipoTelefono values(2, 'Celular', 1, 1)
go

--             .-+=*°"|:|:|[INSERTS A TABLA TELÉFONO DE RRHH]|:|:|°*=+-.

insert into RecursosHumanos.Telefono values(1, 2502617, 1)
go
insert into RecursosHumanos.Telefono values(2, 2502617, 1)
go
insert into RecursosHumanos.Telefono values(3, 2502617, 1)
go
insert into RecursosHumanos.Telefono values(4, 2502617, 1)
go
insert into RecursosHumanos.Telefono values(5, 2502617, 1)
go
insert into RecursosHumanos.Telefono values(6, 2502617, 1)
go
insert into RecursosHumanos.Telefono values(7, 2502617, 1)
go
insert into RecursosHumanos.Telefono values(8, 2502617, 1)
go
insert into RecursosHumanos.Telefono values(9, 2502617, 1)
go
insert into RecursosHumanos.Telefono values(10, 2502617, 1)
go

--             .-+=*°"|:|:|[INSERTS A TABLA TELÉFONO POR EMPRESA DE SERVICIO]|:|:|°*=+-.

insert into CuentaxPagar.TelefonoEmpresaServicio values(1, '0927771895001', 1)
go
insert into CuentaxPagar.TelefonoEmpresaServicio values(1, '0927771895001', 2)
go
insert into CuentaxPagar.TelefonoEmpresaServicio values(1, '0982561267001', 3)
go
insert into CuentaxPagar.TelefonoEmpresaServicio values(1, '0982561267001', 4)
go
insert into CuentaxPagar.TelefonoEmpresaServicio values(1, '0982571267001', 5)
go
insert into CuentaxPagar.TelefonoEmpresaServicio values(1, '0982571267001', 6)
go
insert into CuentaxPagar.TelefonoEmpresaServicio values(1, '0982561217001', 7)
go
insert into CuentaxPagar.TelefonoEmpresaServicio values(1, '0982561217001', 8)
go
insert into CuentaxPagar.TelefonoEmpresaServicio values(1, '0982561217001', 9)
go
insert into CuentaxPagar.TelefonoEmpresaServicio values(1, '0982561217001', 10)
go

--             .-+=*°"|:|:|[INSERTS A TABLA CUENTA POR PAGAR]|:|:|°*=+-.

insert into CuentaxPagar.CuentaPorPagar values(1, NULL,'2013-09-13', '0010010000001234', '2013-07-27', NULL, '0927771895001', 'Compra Servicio', NULL, 5000, NULL, 5550, '1', 1000, 12, 3, 329.17, 3950,11,1)
go
insert into CuentaxPagar.CuentaPorPagar values(2, NULL,'2013-09-13', '0010010000001235', '2013-08-19', NULL, '0982561267001', 'Compra Servicio', 'equipos móviles con plan de megas y tiempo aire para ejecutivos', 5000, NULL, 4950, '0', NULL, NULL, NULL, NULL, NULL,11,1)
go
insert into CuentaxPagar.CuentaPorPagar values(3, NULL,'2013-09-13', '0010010000001236', '2013-09-10', NULL, '0982561217001', 'Compra Servicio', 'Servicio de cable para sala de espera', 5000, NULL, 4950, '0', NULL, NULL, NULL, NULL, NULL,11,1)
go
insert into CuentaxPagar.CuentaPorPagar values(4, NULL,'2013-09-13', '0010010000076499', '2013-07-27', NULL, '0927771895001', 'Compra Servicio', NULL, 5000, NULL, 4950, '0', NULL, NULL, NULL, NULL, NULL,11,1)
go
insert into CuentaxPagar.CuentaPorPagar values(5, NULL,'2013-09-13', '0010010000093674', '2013-07-27', NULL, '0927771895001', 'Compra Servicio', NULL, 5000, NULL, 4950, '0', NULL, NULL, NULL, NULL, NULL,11,1)
go

--             .-+=*°"|:|:|[INSERTS A TABLA DEUDA DETALLE]|:|:|°*=+-.

insert into CuentaxPagar.DeudaDet values(1, 1, 1, 329.12, '2013-08-27', 2)
go
insert into CuentaxPagar.DeudaDet values(1, 1, 2, 329.12, '2013-09-27', 1)
go
insert into CuentaxPagar.DeudaDet values(1, 1, 3, 329.12, '2013-10-27', 1)
go
insert into CuentaxPagar.DeudaDet values(1, 1, 4, 329.12, '2013-11-27', 1)
go
insert into CuentaxPagar.DeudaDet values(1, 1, 5, 329.12, '2013-12-27', 1)
go
insert into CuentaxPagar.DeudaDet values(1, 1, 6, 329.12, '2014-01-27', 1)
go
insert into CuentaxPagar.DeudaDet values(1, 1, 7, 329.12, '2014-02-27', 1)
go
insert into CuentaxPagar.DeudaDet values(1, 1, 8, 329.12, '2014-03-27', 1)
go
insert into CuentaxPagar.DeudaDet values(1, 1, 9, 329.12, '2014-04-27', 1)
go
insert into CuentaxPagar.DeudaDet values(1, 1, 10, 329.12, '2014-05-27', 1)
go
insert into CuentaxPagar.DeudaDet values(1, 1, 11, 329.12, '2014-06-27', 1)
go
insert into CuentaxPagar.DeudaDet values(1, 1, 12, 329.12, '2014-07-27', 1)
go

--             .-+=*°"|:|:|[INSERTS A TABLA IMPUESTO POR CUENTA]|:|:|°*=+-.

insert into CuentaxPagar.ImpuestoCuenta values(2, 1, 600, 1)
go
insert into CuentaxPagar.ImpuestoCuenta values(3, 1, 50, 1)
go