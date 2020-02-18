/** CREACION DE SCHEMA **/

IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'HOTEL_CUATRIVAGOS')
BEGIN
    EXEC ('CREATE SCHEMA HOTEL_CUATRIVAGOS AUTHORIZATION gdHotel2018')
END
GO

/** FIN CREACION DE SCHEMA**/


/** VALIDACION DE TABLAS **/

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'HOTEL_CUATRIVAGOS.USUARIOS_X_ROL_X_HOTEL'))
    DROP TABLE HOTEL_CUATRIVAGOS.USUARIOS_X_ROL_X_HOTEL

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL'))
    DROP TABLE HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL
        
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'HOTEL_CUATRIVAGOS.FUNCIONALIDADES'))
    DROP TABLE HOTEL_CUATRIVAGOS.FUNCIONALIDADES

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'HOTEL_CUATRIVAGOS.REGIMEN_X_HOTEL'))
    DROP TABLE HOTEL_CUATRIVAGOS.REGIMEN_X_HOTEL

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'HOTEL_CUATRIVAGOS.HOTEL_MANTENIMIENTO'))
    DROP TABLE HOTEL_CUATRIVAGOS.HOTEL_MANTENIMIENTO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'HOTEL_CUATRIVAGOS.ESTADIAS'))
    DROP TABLE HOTEL_CUATRIVAGOS.ESTADIAS

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'HOTEL_CUATRIVAGOS.CONSUMIBLES_X_HABITACION'))
    DROP TABLE HOTEL_CUATRIVAGOS.CONSUMIBLES_X_HABITACION

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'HOTEL_CUATRIVAGOS.CONSUMIBLES'))
    DROP TABLE HOTEL_CUATRIVAGOS.CONSUMIBLES
	
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'HOTEL_CUATRIVAGOS.USUARIOS'))
    DROP TABLE HOTEL_CUATRIVAGOS.USUARIOS

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'HOTEL_CUATRIVAGOS.ROLES'))
    DROP TABLE HOTEL_CUATRIVAGOS.ROLES

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'HOTEL_CUATRIVAGOS.FACTURA_ITEM'))
    DROP TABLE HOTEL_CUATRIVAGOS.FACTURA_ITEM

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'HOTEL_CUATRIVAGOS.FACTURAS'))
    DROP TABLE HOTEL_CUATRIVAGOS.FACTURAS

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'HOTEL_CUATRIVAGOS.DATOS_TARJETA'))
    DROP TABLE HOTEL_CUATRIVAGOS.DATOS_TARJETA

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'HOTEL_CUATRIVAGOS.HUESPEDES_X_HABITACION'))
    DROP TABLE HOTEL_CUATRIVAGOS.HUESPEDES_X_HABITACION
	
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION'))
    DROP TABLE HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'HOTEL_CUATRIVAGOS.HABITACIONES'))
    DROP TABLE HOTEL_CUATRIVAGOS.HABITACIONES

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'HOTEL_CUATRIVAGOS.TIPO_HABITACION'))
    DROP TABLE HOTEL_CUATRIVAGOS.TIPO_HABITACION

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'HOTEL_CUATRIVAGOS.LOG_RESERVA'))
    DROP TABLE HOTEL_CUATRIVAGOS.LOG_RESERVA

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'HOTEL_CUATRIVAGOS.RESERVAS'))
    DROP TABLE HOTEL_CUATRIVAGOS.RESERVAS

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'HOTEL_CUATRIVAGOS.HOTELES'))
    DROP TABLE HOTEL_CUATRIVAGOS.HOTELES

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'HOTEL_CUATRIVAGOS.REGIMENES_ESTADIA'))
    DROP TABLE HOTEL_CUATRIVAGOS.REGIMENES_ESTADIA

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'HOTEL_CUATRIVAGOS.CLIENTES'))
    DROP TABLE HOTEL_CUATRIVAGOS.CLIENTES
	
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'HOTEL_CUATRIVAGOS.DATOS_PERSONALES'))
    DROP TABLE HOTEL_CUATRIVAGOS.DATOS_PERSONALES
	
	
/** FIN VALIDACION DE TABLAS **/

/**  VALIDACION DE PROCEDIMIENTOS **/

drop procedure [HOTEL_CUATRIVAGOS].[login_usuario]
drop procedure [HOTEL_CUATRIVAGOS].[baja_rol]
drop procedure [HOTEL_CUATRIVAGOS].[alta_funcionalidad_por_rol]
drop procedure [HOTEL_CUATRIVAGOS].[baja_funcionalidad_por_rol]
drop procedure [HOTEL_CUATRIVAGOS].[alta_usuario]
drop procedure [HOTEL_CUATRIVAGOS].[alta_hotel]
drop procedure [HOTEL_CUATRIVAGOS].[alta_habitacion]
drop procedure [HOTEL_CUATRIVAGOS].[alta_cliente]
drop procedure [HOTEL_CUATRIVAGOS].[alta_rol]
drop procedure [HOTEL_CUATRIVAGOS].[modificacion_usuario]
drop procedure [HOTEL_CUATRIVAGOS].[modificacion_cliente]
drop procedure [HOTEL_CUATRIVAGOS].[modificacion_hotel]
drop procedure [HOTEL_CUATRIVAGOS].[modificacion_habitacion]
drop procedure [HOTEL_CUATRIVAGOS].[modificacion_rol]
drop procedure [HOTEL_CUATRIVAGOS].[check_in]
drop procedure [HOTEL_CUATRIVAGOS].[check_out]
drop procedure [HOTEL_CUATRIVAGOS].[alta_consumible_habitacion]
drop procedure [HOTEL_CUATRIVAGOS].[generar_factura]
drop procedure [HOTEL_CUATRIVAGOS].[agregar_items]
drop procedure [HOTEL_CUATRIVAGOS].[generar_reserva]
drop procedure [HOTEL_CUATRIVAGOS].[modificar_reserva]
drop procedure [HOTEL_CUATRIVAGOS].[agregar_tarjeta]
drop procedure [HOTEL_CUATRIVAGOS].[cancelar_reserva]
drop procedure [HOTEL_CUATRIVAGOS].[cancelar_reservas]
drop procedure [HOTEL_CUATRIVAGOS].[alta_periodo_cierre]
GO

/**  FIN DE PROCEDIMIENTOS **/

/**  VALIDACION DE FUNCION **/

drop function [HOTEL_CUATRIVAGOS].[costo_estadia]
drop function [HOTEL_CUATRIVAGOS].[hoteles_reservas_mas_canceladas]
drop function [HOTEL_CUATRIVAGOS].[hoteles_consumibles_facturados]
drop function [HOTEL_CUATRIVAGOS].[hoteles_fuera_de_servicio]
drop function [HOTEL_CUATRIVAGOS].[habitaciones_mas_ocupadas]
drop function [HOTEL_CUATRIVAGOS].[clientes_mas_puntos]
GO
/**  FIN VALIDACION FUNCIONES **/

----------------------------------------------------    Creacion de Tablas   ----------------------------------------------------

CREATE TABLE HOTEL_CUATRIVAGOS.ROLES(
		Rol_Id numeric(18,0) primary key,
		Rol_Desc nvarchar(255),
		Rol_estado bit default 0
		)
GO

CREATE TABLE HOTEL_CUATRIVAGOS.FUNCIONALIDADES(
		Func_Id numeric(18,0) Primary Key,
		Func_Desc nvarchar(255)		
		)
GO

CREATE TABLE HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(
		Rol_Id numeric(18,0)references HOTEL_CUATRIVAGOS.ROLES(Rol_Id),
		Func_Id numeric(18,0) references HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id),	
		Primary Key (Rol_Id,Func_Id)
		)
GO

CREATE TABLE HOTEL_CUATRIVAGOS.DATOS_PERSONALES(
		Datos_Id numeric(18,0) primary key identity,
		Datos_Nombre nvarchar(255),
		Datos_Apellido nvarchar(255),
		Datos_Telefono numeric(18,0),
		Datos_Tipo_Ident nvarchar(30),
		Datos_Nro_Ident numeric(18,0),
		Datos_Mail nvarchar(255),
		Datos_Dom_Calle nvarchar(255),
		Datos_Dom_Nro_Calle numeric(18,0),
		Datos_Dom_Piso numeric(18,0),
		Datos_Dom_Depto nvarchar(50),
		Datos_Fecha_Nac datetime
		)
GO

CREATE TABLE HOTEL_CUATRIVAGOS.USUARIOS(
		Usuario_Id numeric(18,0) Primary Key Identity,
		Usuario_name varchar(30) Unique,
		Usuario_pass nvarchar (255),
		Usuario_Intentos numeric (18,0) default 0,
		Usuario_estado bit default 0,
		Usuario_Deshabilitado bit default 0,
		Usuario_Baja bit default 0,
		Usuario_datos numeric(18,0) references HOTEL_CUATRIVAGOS.DATOS_PERSONALES(Datos_Id)
		)
GO

CREATE TABLE HOTEL_CUATRIVAGOS.HOTELES(
		Hotel_Id numeric(18,0) primary key identity,
		Hotel_Nombre nvarchar(255) default '',
		Hotel_Mail nvarchar(255),
		Hotel_Telefono numeric(18,0),
		Hotel_Calle nvarchar(255),
		Hotel_Nro_Calle numeric(18,0),
		Hotel_Ciudad nvarchar(255),
		Hotel_Pais nvarchar(255),
		Hotel_Fecha_Creacion datetime,
		Hotel_Cerrado bit default 0,
		Hotel_Cant_Est numeric(18,0),
		Hotel_Recarga_Estrella numeric(18,0)
		)
GO

CREATE TABLE HOTEL_CUATRIVAGOS.USUARIOS_X_ROL_X_HOTEL(
		Usuario_Id numeric(18,0) references HOTEL_CUATRIVAGOS.USUARIOS(Usuario_Id),
		Hotel_Id numeric(18,0) references HOTEL_CUATRIVAGOS.HOTELES(Hotel_Id),
		Rol_Id numeric(18,0) references HOTEL_CUATRIVAGOS.ROLES(Rol_Id)
		Primary Key(Usuario_Id, Hotel_Id, Rol_Id)
	
	)
GO

CREATE TABLE HOTEL_CUATRIVAGOS.HOTEL_MANTENIMIENTO(
		Periodo_Id numeric(18,0) primary key identity,
		Periodo_Hotel numeric(18,0) references HOTEL_CUATRIVAGOS.HOTELES(Hotel_Id),
		Periodo_FechaInicio datetime,
		Periodo_FechaFin datetime,
		Periodo_Motivo nvarchar(255)
		)
GO

CREATE TABLE HOTEL_CUATRIVAGOS.REGIMENES_ESTADIA(
		Regimen_Id numeric(18,0) primary key identity,
		Regimen_Desc nvarchar(255),
		Regimen_Precio numeric(18,2),
		Regimen_Inactivo bit default 0
		)
GO

CREATE TABLE HOTEL_CUATRIVAGOS.REGIMEN_X_HOTEL(
		Hotel_Id numeric(18,0) references HOTEL_CUATRIVAGOS.HOTELES(Hotel_Id),
		Regimen_Id numeric(18,0) references HOTEL_CUATRIVAGOS.REGIMENES_ESTADIA(Regimen_Id)
		Primary Key(Hotel_Id,Regimen_Id)
		)
GO

CREATE TABLE HOTEL_CUATRIVAGOS.TIPO_HABITACION(
		Tipo_Hab_Id numeric(18,0) primary key,
		Tipo_Hab_Desc nvarchar(255),
		Tipo_Cant_Maxima_Huespedes numeric(1,0),
		Tipo_Hab_Porc numeric(18,2)
		)
GO

CREATE TABLE HOTEL_CUATRIVAGOS.HABITACIONES(
		Habitacion_Id numeric(18,0) primary key identity,
		Habitacion_Num numeric(18,0),
		Habitacion_Piso numeric(18,0),
		Habitacion_Hotel numeric(18,0) references HOTEL_CUATRIVAGOS.HOTELES(Hotel_Id),
		Habitacion_Tipo numeric(18,0) references HOTEL_CUATRIVAGOS.TIPO_HABITACION(Tipo_Hab_Id),
		Habitacion_Vista nvarchar(50), 
		Habitacion_Desc nvarchar(255) default '',
		Habitacion_Ocupada bit default 0,
		Habitacion_Cerrada bit default 0
		)
GO

CREATE TABLE HOTEL_CUATRIVAGOS.CLIENTES(
		Cliente_Id numeric(18,0) primary key identity,
		Cliente_Datos numeric(18,0) references HOTEL_CUATRIVAGOS.DATOS_PERSONALES(Datos_Id),
		Cliente_Nacionalidad nvarchar(255),
		Cliente_Deshabilitado bit default 0,
		)
GO		

CREATE TABLE HOTEL_CUATRIVAGOS.RESERVAS(
		Reserva_Id numeric(18,0) primary key,
		Reserva_Cliente numeric(18,0) references HOTEL_CUATRIVAGOS.CLIENTES(Cliente_Id),
		Reserva_Fecha datetime,
		Reserva_FechaIng datetime,
		Reserva_CantNoches numeric(18,0),
		Reserva_Estado nvarchar(255),
		Reserva_Regimen numeric(18,0) references HOTEL_CUATRIVAGOS.REGIMENES_ESTADIA(Regimen_Id),
		Reserva_Hotel numeric(18,0) references HOTEL_CUATRIVAGOS.HOTELES(Hotel_Id)
		)
GO

CREATE TABLE HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION(
		RPH_Id numeric(18,0) primary key identity, 
		Reserva_Id numeric(18,0) references HOTEL_CUATRIVAGOS.RESERVAS(Reserva_Id) not null,
		Habitacion_Id numeric(18,0) references HOTEL_CUATRIVAGOS.HABITACIONES(Habitacion_Id)not null,
		Unique(Reserva_Id,Habitacion_Id)
		)
GO

CREATE TABLE HOTEL_CUATRIVAGOS.HUESPEDES_X_HABITACION(
		Huesped_Por_Habitacion_Id numeric(18,0) primary key identity, 
		RPH_Id numeric(18,0) references HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION(RPH_Id) not null,
		Cliente_Id numeric(18,0) references HOTEL_CUATRIVAGOS.CLIENTES(Cliente_Id) not null 
		)
GO

CREATE TABLE HOTEL_CUATRIVAGOS.LOG_RESERVA(
		Log_Reserva_id numeric(18,0) primary key identity,
        Log_Fecha datetime,
        Log_Descripcion nvarchar(50),
        Log_Reservador numeric(18,0),
        Log_Reserva numeric(18,0) references HOTEL_CUATRIVAGOS.RESERVAS(Reserva_Id)
        )
GO

CREATE TABLE HOTEL_CUATRIVAGOS.CONSUMIBLES(
		Consumible_Id numeric(18,0) primary key,
		Consumible_Desc nvarchar(255),
		Consumible_precio numeric(18,2)
		)
GO

CREATE TABLE HOTEL_CUATRIVAGOS.DATOS_TARJETA(
	Datos_Tarjeta_Id numeric(18,0) Primary Key identity,
	Datos_Tarjeta_Nro numeric(16,0),
	Datos_Duenio_Tarjeta nvarchar(80),
	Datos_Tarjeta_Fecha_Venc datetime,
	Datos_Tipo_Tarjeta nvarchar(30)
	)
GO

CREATE TABLE HOTEL_CUATRIVAGOS.FACTURAS(
		Factura_Id numeric(18,0) primary key,
		Factura_Cliente numeric(18,0) references HOTEL_CUATRIVAGOS.CLIENTES(Cliente_Id),
		Factura_Fecha datetime,
		Factura_Total numeric(18,2) default 0,
		Factura_Tarjeta numeric(18,0) references HOTEL_CUATRIVAGOS.DATOS_TARJETA(Datos_Tarjeta_Id)--si esta en null es efectivo
		)
GO

CREATE TABLE HOTEL_CUATRIVAGOS.FACTURA_ITEM(
		Item_Factura_Id numeric(18,0) primary key,
		Item_Factura_Cantidad numeric(18,0) default 1,
		Item_Factura_Monto numeric(18,2),
		Item_Factura numeric(18,0) references HOTEL_CUATRIVAGOS.FACTURAS(Factura_Id) 
		)
GO

CREATE TABLE HOTEL_CUATRIVAGOS.CONSUMIBLES_X_HABITACION(
		Consumible_Por_Habitacion_Id numeric(18,0) primary key references HOTEL_CUATRIVAGOS.FACTURA_ITEM(Item_Factura_Id),
		Consumible_Id numeric(18,0) references HOTEL_CUATRIVAGOS.CONSUMIBLES(Consumible_Id),
		RPH_Id numeric(18,0) references HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION(RPH_Id),
		Consumible_Cantidad numeric(18,0)
		)
GO

CREATE TABLE HOTEL_CUATRIVAGOS.ESTADIAS(
		Estadia_Id numeric(18,0) primary key references HOTEL_CUATRIVAGOS.FACTURA_ITEM(Item_Factura_Id),
		Estadia_RPH numeric(18,0) references HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION(RPH_Id),
		Estadia_Fecha_Salida datetime
		)
GO


----------------------------------------------------  MIGRACION DE DATOS  ----------------------------------------------------


/**  TABLA  ROL **/

Insert into HOTEL_CUATRIVAGOS.ROLES(Rol_Id, Rol_Desc) values (1, 'Administrador')
Insert into HOTEL_CUATRIVAGOS.ROLES(Rol_Id, Rol_Desc) values (2, 'Recepcionista')
Insert into HOTEL_CUATRIVAGOS.ROLES(Rol_Id, Rol_Desc) values (3, 'Administrador General')
GO


/** TABLA  FUNCIONALIDAD   **/

Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (1,'Alta de Rol')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (2,'Baja de Rol')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (3,'Modificacion de Rol')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (4,'Login')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (5,'Alta de usuario')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (6,'Baja de usuario')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (7,'Modificacion de usuario')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (8,'Alta de Cliente')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (9,'Baja de Cliente')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (10,'Modificacion de Cliente')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (11,'Generar reserva')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (12,'Alta de Hotel')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (13,'Baja de Hotel')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (14,'Modificacion de Hotel')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (15,'Alta de Habitacion')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (16,'Baja de Habitacion')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (17,'Modificacion de Habitacion')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (18,'Alta de Regimen')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (19,'Baja de Regimen')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (20,'Modificacion de Regimen')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (21,'Modificar Reserva')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (22,'Cancelar Reserva')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (23,'Check-In')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (24,'Check-Out')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (25,'Registrar Consumibles')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (26,'Emitir Factura')
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id,Func_Desc) values (27,'Listado Estadístico')
GO


/** TABLA  FUNCIONALIDAD POR ROL   **/

Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (1,1)		
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (1,2)	
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (1,3)	
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (1,4)	
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (2,4)	
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (1,5)	
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (1,6)	
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (1,7)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (1,8)	
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (2,8)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (1,9)	
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (2,9)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (1,10)	
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (2,10)	
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (2,11)	
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (1,12)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (1,13)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (1,14)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (1,15)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (1,16)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (1,17)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (1,18)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (1,19)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (1,20)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (2,21)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (2,22)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (2,23)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (2,24)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (2,25)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (2,26)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,1)		
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,2)	
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,3)	
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,4)	
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,5)	
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,6)	
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,7)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,8)	
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,9)	
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,10)	
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,11)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,12)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,13)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,14)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,15)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,16)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,17)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,18)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,19)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,20)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,21)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,22)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,23)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,24)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,25)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,26)
Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id) values (3,27)
GO


/** REGIMEN   **/

Insert into HOTEL_CUATRIVAGOS.REGIMENES_ESTADIA(Regimen_Desc, Regimen_Precio)
                               (select distinct Regimen_Descripcion, Regimen_Precio
                                from gd_esquema.Maestra)
GO                                


/** TABLA  TIPO DE HABITACIÓN   **/

Insert into HOTEL_CUATRIVAGOS.TIPO_HABITACION(Tipo_Hab_Id, Tipo_Hab_Desc, Tipo_Hab_Porc, Tipo_Cant_Maxima_Huespedes)
                                       (select distinct Habitacion_Tipo_Codigo, Habitacion_Tipo_Descripcion, Habitacion_Tipo_Porcentual,
                                                        case Habitacion_Tipo_Descripcion when 'Base Simple' then 1
                                                                                         when 'Base Doble' then 2
                                                                                         when 'Base Triple' then 3
                                                                                         when 'Base Cuadruple' then 4
                                                                                         else 5 end
                                        from gd_esquema.Maestra)    
GO     

 
/** TABLA  HOTEL   **/
                  
Insert into HOTEL_CUATRIVAGOS.HOTELES(Hotel_Calle, Hotel_Nro_Calle, Hotel_Ciudad, Hotel_Cant_Est, Hotel_Recarga_Estrella)
			(select distinct Hotel_Calle, 
							 Hotel_Nro_Calle, 
							 Hotel_Ciudad,
							 Hotel_CantEstrella,
							 Hotel_Recarga_Estrella
			 from gd_esquema.Maestra)
GO     


/** TABLA  REGIMEN POR HOTEL   **/

Insert into HOTEL_CUATRIVAGOS.REGIMEN_X_HOTEL(Hotel_Id, Regimen_Id)
	(select distinct (select h.Hotel_Id from HOTEL_CUATRIVAGOS.HOTELES h 
							where h.Hotel_Calle=g.Hotel_Calle and
								  h.Hotel_Nro_Calle=g.Hotel_Nro_Calle and 
								h.Hotel_Ciudad=g.Hotel_Ciudad),
					 (select r.Regimen_Id from HOTEL_CUATRIVAGOS.REGIMENES_ESTADIA r 
							where r.Regimen_Desc= g.Regimen_Descripcion)
		 from gd_esquema.Maestra g)
GO


/** TABLA  HABITACION   **/
                       
Insert into HOTEL_CUATRIVAGOS.HABITACIONES(Habitacion_Num, Habitacion_Piso, Habitacion_Hotel, Habitacion_Tipo, Habitacion_Vista)
				(select distinct g.Habitacion_Numero,
						 g.Habitacion_Piso,
						 (select h.Hotel_Id from HOTEL_CUATRIVAGOS.HOTELES h 
							where h.Hotel_Calle=g.Hotel_Calle and 
								  h.Hotel_Nro_Calle=g.Hotel_Nro_Calle and 
								  h.Hotel_Ciudad=g.Hotel_Ciudad),
						 g.Habitacion_Tipo_Codigo,
						 g.Habitacion_Frente
		 from gd_esquema.Maestra g)
GO
 
 
/** TABLAS  CLIENTE, DATOS_PERSONALES   **/

Insert into HOTEL_CUATRIVAGOS.DATOS_PERSONALES(Datos_Nombre,Datos_Apellido,Datos_Mail,Datos_Dom_Calle, Datos_Dom_Nro_Calle,
                                         Datos_Dom_Piso, Datos_Dom_Depto, Datos_Fecha_Nac, Datos_Tipo_Ident, Datos_Nro_Ident)
			(select distinct Cliente_Nombre,
					    Cliente_Apellido,
						Cliente_Mail,
						Cliente_Dom_Calle,
						Cliente_Nro_Calle,
						Cliente_Piso,
						Cliente_Depto,
						Cliente_Fecha_Nac,
						'DNI',
						Cliente_Pasaporte_Nro
					from gd_esquema.Maestra)

Insert into HOTEL_CUATRIVAGOS.CLIENTES (Cliente_Nacionalidad)
(select Cliente_Nacionalidad
		from gd_esquema.Maestra 
			group by Cliente_Mail,Cliente_Fecha_Nac,Cliente_Pasaporte_Nro,Cliente_Nacionalidad)

update HOTEL_CUATRIVAGOS.CLIENTES
	set Cliente_Datos=s.datos_id
	from  (select d.Datos_Id datos_id from HOTEL_CUATRIVAGOS.DATOS_PERSONALES d)s
		where datos_id=Cliente_Id

GO


/** TABLA  RESERVA   **/

insert into HOTEL_CUATRIVAGOS.RESERVAS(Reserva_Id, Reserva_CantNoches, Reserva_FechaIng, Reserva_Fecha, Reserva_Hotel, 
								Reserva_Regimen, Reserva_Cliente) 
	(select distinct g.Reserva_Codigo, g.Reserva_Cant_Noches, g.Reserva_Fecha_Inicio, g.Reserva_Fecha_Inicio,
		(select h.Hotel_Id from HOTEL_CUATRIVAGOS.HOTELES h 
				where h.Hotel_Calle=g.Hotel_Calle and
					  h.Hotel_Nro_calle=g.Hotel_Nro_Calle and
					  h.Hotel_Ciudad=g.Hotel_Ciudad),
		(select r.Regimen_Id from HOTEL_CUATRIVAGOS.REGIMENES_ESTADIA r where r.Regimen_Desc = g.Regimen_Descripcion),
		(select d.Datos_Id from HOTEL_CUATRIVAGOS.DATOS_PERSONALES d 
				where d.Datos_Mail= g.Cliente_Mail and
					  d.Datos_Fecha_Nac=g.Cliente_Fecha_Nac and
					  d.Datos_Nro_Ident=g.Cliente_Pasaporte_Nro)
		from gd_esquema.Maestra g)
		order by Reserva_Codigo 

update HOTEL_CUATRIVAGOS.RESERVAS
	set Reserva_Estado= 'Efectivizada'
		from (select distinct Reserva_Codigo from gd_esquema.Maestra where Estadia_Fecha_Inicio is not null)t
			where Reserva_Id=t.Reserva_Codigo
			
update HOTEL_CUATRIVAGOS.RESERVAS
	set Reserva_Estado= 'Correcta'
		where Reserva_Estado is null
GO


/** TABLA   RESERVA POR HABITACIÓN   **/

insert into HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION(Reserva_Id, Habitacion_Id)
			(select distinct g.Reserva_Codigo,
				    (select h.Habitacion_Id from HOTEL_CUATRIVAGOS.HABITACIONES h
							where h.Habitacion_Num= g.Habitacion_Numero and
								  h.Habitacion_Hotel=(select ho.Hotel_Id from HOTEL_CUATRIVAGOS.HOTELES ho
														where ho.Hotel_Calle=g.Hotel_Calle and
															  ho.Hotel_Nro_Calle=g.Hotel_Nro_Calle and
															  ho.Hotel_Ciudad=g.Hotel_Ciudad) ) 
				from gd_esquema.Maestra g)
				order by g.Reserva_Codigo
GO


/** TABLA  FACTURA   **/

Insert into HOTEL_CUATRIVAGOS.FACTURAS(Factura_Id, Factura_Cliente, Factura_Fecha, Factura_Total)
	(select distinct g.Factura_Nro,
	                (select d.Datos_Id from HOTEL_CUATRIVAGOS.DATOS_PERSONALES d 
					 where d.Datos_Mail= g.Cliente_Mail and
						   d.Datos_Fecha_Nac=g.Cliente_Fecha_Nac and
					       d.Datos_Nro_Ident=g.Cliente_Pasaporte_Nro),
					 g.Factura_Fecha,
					 g.Factura_Total			       
	 from gd_esquema.Maestra g
	 where g.Factura_Nro is not null)
	 order by g.Factura_Nro
GO


/** TABLA  CONSUMIBLE   **/

Insert into HOTEL_CUATRIVAGOS.CONSUMIBLES(Consumible_Id, Consumible_Desc, Consumible_precio)
            (select distinct Consumible_Codigo,
							 Consumible_Descripcion,
							 Consumible_Precio
             from gd_esquema.Maestra
             where Consumible_Codigo is not null)
GO


/** ESTADIA, TIPO ITEM FACTURA   **/

Declare
@reserva_id numeric(18,0),   
@item_cant numeric(18,0),
@item_monto numeric(18,2),
@fact_num numeric(18,0),
@habitacion_id numeric(18,0)             
Declare cursor_migracion_estadia cursor
	for (select g.Reserva_Codigo, g.Item_Factura_Cantidad, g.Item_Factura_Monto, g.Factura_Nro,
         (select h.Habitacion_Id from HOTEL_CUATRIVAGOS.HABITACIONES h
							where h.Habitacion_Num= g.Habitacion_Numero and
								  h.Habitacion_Hotel=(select ho.Hotel_Id from HOTEL_CUATRIVAGOS.HOTELES ho
														where ho.Hotel_Calle=g.Hotel_Calle and
															  ho.Hotel_Nro_Calle=g.Hotel_Nro_Calle and
															  ho.Hotel_Ciudad=g.Hotel_Ciudad) )
         from gd_esquema.Maestra g
         where g.Estadia_Cant_Noches is not null and
			   g.Estadia_Fecha_Inicio is not null and
			   g.Item_Factura_Cantidad is not null and
			   g.Consumible_Codigo is null)   
           
Open cursor_migracion_estadia
fetch cursor_migracion_estadia into @reserva_id, @item_cant, @item_monto, @fact_num, @habitacion_id
                             
while(@@fetch_status=0)
begin 

declare @id_item_fact numeric(18,0)
set @id_item_fact = (ISNULL((select MAX(Item_Factura_Id)from HOTEL_CUATRIVAGOS.FACTURA_ITEM),0)) + 1

declare @rph_id numeric(18,0)
set @rph_id = (select rph.RPH_Id from HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION rph
					where rph.Reserva_Id = @reserva_id and
						  rph.Habitacion_Id = @habitacion_id)
						  	
Insert into HOTEL_CUATRIVAGOS.FACTURA_ITEM(Item_Factura_Id, Item_Factura_Cantidad, Item_Factura_Monto, Item_Factura) 
					values (@id_item_fact, @item_cant, @item_monto, @fact_num)
	
Insert into HOTEL_CUATRIVAGOS.ESTADIAS(Estadia_Id,Estadia_RPH) values(@id_item_fact,@rph_id)

fetch cursor_migracion_estadia into @reserva_id, @item_cant, @item_monto, @fact_num, @habitacion_id
end	
close cursor_migracion_estadia
deallocate cursor_migracion_estadia
GO


/** TABLA  CONSUMIBLE POR HABITACION    **/


Declare 
@codigo numeric(18,0),
@item_cant numeric(18,0),
@item_monto numeric(18,2),
@factura_id numeric(18,0),
@reserva_id numeric(18,0),
@numero_habitacion numeric(18,0)
Declare cursor_migracion_consumible cursor
	for(select Consumible_Codigo, 
					    Item_Factura_Cantidad,
					    Item_Factura_Monto,
					    Factura_Nro,
					    Reserva_Codigo,
					    Habitacion_Numero
        from gd_esquema.Maestra
        where Consumible_Codigo is not null)

           
Open cursor_migracion_consumible
fetch cursor_migracion_consumible into @codigo, @item_cant, @item_monto, @factura_id, @reserva_id, @numero_habitacion
                             
while(@@fetch_status=0)
begin 

declare @id_item_fact numeric(18,0)
set @id_item_fact = (ISNULL((select MAX(Item_Factura_Id)from HOTEL_CUATRIVAGOS.FACTURA_ITEM),0)) + 1

declare @reserva_por_habitacion numeric(18,0)
set @reserva_por_habitacion = (select r.RPH_Id 
							   from HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION r,HOTEL_CUATRIVAGOS.HABITACIONES h
							   where @reserva_id = r.Reserva_Id and
									 r.Habitacion_Id=h.Habitacion_Id and
						             @numero_habitacion = h.Habitacion_Num)


Insert into HOTEL_CUATRIVAGOS.FACTURA_ITEM(Item_Factura_Id, Item_Factura_Cantidad, Item_Factura_Monto, Item_Factura)
										values(@id_item_fact, @item_cant, @item_monto, @factura_id)

Insert into HOTEL_CUATRIVAGOS.CONSUMIBLES_X_HABITACION(Consumible_Por_Habitacion_Id, Consumible_Id, RPH_Id, 
												  Consumible_Cantidad)
                                        values(@id_item_fact, @codigo, @reserva_por_habitacion, @item_cant)           

fetch cursor_migracion_consumible into @codigo, @item_cant, @item_monto, @factura_id, @reserva_id, @numero_habitacion
end
close  cursor_migracion_consumible
deallocate cursor_migracion_consumible                              

update HOTEL_CUATRIVAGOS.FACTURA_ITEM
	set Item_Factura_Monto = Item_Factura_Monto * r.Reserva_CantNoches
	from HOTEL_CUATRIVAGOS.ESTADIAS e, HOTEL_CUATRIVAGOS.RESERVAS r, HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION rph
	where Item_Factura_Id = e.Estadia_Id and
	      e.Estadia_RPH = rph.RPH_Id and
		  rph.Reserva_Id = r.Reserva_Id

update HOTEL_CUATRIVAGOS.FACTURAS
	set Factura_Total = (select SUM(i.Item_Factura_Monto) from HOTEL_CUATRIVAGOS.FACTURA_ITEM i
						 where i.Item_Factura = Factura_Id)

GO



/** INSERT LOGIN   **/

--Insert de Administrador General

declare @fecha datetime
set @fecha = '19900423'

Insert into HOTEL_CUATRIVAGOS.DATOS_PERSONALES(Datos_Nombre, Datos_Apellido, Datos_Telefono, Datos_Tipo_Ident, Datos_Nro_Ident, Datos_Mail,
							 Datos_Dom_Calle, Datos_Dom_Nro_Calle, Datos_Dom_Piso, Datos_Dom_Depto, Datos_Fecha_Nac)
			values('James', 'Bond', 45855047, 'DNI', 35486987, 'admingral@gmail.com', 'Corrientes', 458, 5, 'A', @fecha)
			
Insert into HOTEL_CUATRIVAGOS.USUARIOS(Usuario_name, Usuario_Pass, Usuario_Datos)
				values('admin','e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', (select MAX(Datos_Id) from HOTEL_CUATRIVAGOS.DATOS_PERSONALES))

Insert into HOTEL_CUATRIVAGOS.USUARIOS_X_ROL_X_HOTEL(Usuario_Id, Hotel_Id, Rol_Id)
					values((select max(Usuario_Id) from HOTEL_CUATRIVAGOS.USUARIOS),8,3)
GO

/*			     
--Insert de Administrador

declare @fecha datetime
set @fecha = '19900423'

Insert into HOTEL_CUATRIVAGOS.DATOS_PERSONALES(Datos_Nombre, Datos_Apellido, Datos_Telefono, Datos_Tipo_Ident, Datos_Nro_Ident, Datos_Mail,
							 Datos_Dom_Calle, Datos_Dom_Nro_Calle, Datos_Dom_Piso, Datos_Dom_Depto, Datos_Fecha_Nac)
			values('Admin', 'Daniel Avila', 1164873414, 'DNI', 35218197, 'danii.avila@live.com', 'Aguilar', 4560 , 5, 'A', @fecha)
			
Insert into HOTEL_CUATRIVAGOS.USUARIOS(Usuario_name, Usuario_Pass, Usuario_Datos)
				values('AdminAvila','8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', (select MAX(Datos_Id) from HOTEL_CUATRIVAGOS.DATOS_PERSONALES))

Insert into HOTEL_CUATRIVAGOS.USUARIOS_X_ROL_X_HOTEL(Usuario_Id, Hotel_Id, Rol_Id)
					values((select max(Usuario_Id) from HOTEL_CUATRIVAGOS.USUARIOS),8,1)
GO

--Insert de Recepcionista

declare @fecha datetime
set @fecha = '19900423'

Insert into HOTEL_CUATRIVAGOS.DATOS_PERSONALES(Datos_Nombre, Datos_Apellido, Datos_Telefono, Datos_Tipo_Ident, Datos_Nro_Ident, Datos_Mail,
							 Datos_Dom_Calle, Datos_Dom_Nro_Calle, Datos_Dom_Piso, Datos_Dom_Depto, Datos_Fecha_Nac)
			values('Recep', 'Leo Messi', 45896047, 'DNI', 25586987, 'recepMessi@gmail.com', 'Mozart', 274, 5, 'A', @fecha)
			
Insert into HOTEL_CUATRIVAGOS.USUARIOS(Usuario_name, Usuario_Pass, Usuario_Datos)
				values('RecepMessi','8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', (select MAX(Datos_Id) from HOTEL_CUATRIVAGOS.DATOS_PERSONALES))

Insert into HOTEL_CUATRIVAGOS.USUARIOS_X_ROL_X_HOTEL(Usuario_Id, Hotel_Id, Rol_Id)
					values((select max(Usuario_Id) from HOTEL_CUATRIVAGOS.USUARIOS),8,2)
GO

*/




----------------------------------------------------   Procedimientos    ----------------------------------------------------
/** PROCEDURE LOGIN  **/

create Procedure HOTEL_CUATRIVAGOS.login_usuario @usuario varchar(30),@userpass nvarchar(255),@return numeric(1,0) out
as 
begin
set @return=0 --El usuario ingresa correctamente
if exists (select Usuario_name from HOTEL_CUATRIVAGOS.USUARIOS where Usuario_name=@usuario and Usuario_pass=@userpass)
	begin 
	update HOTEL_CUATRIVAGOS.USUARIOS 
	set Usuario_Intentos = 0
	where Usuario_name = @usuario;
	declare @deshabilitado bit
	declare @baja bit
	set @deshabilitado = (select Usuario_Deshabilitado from HOTEL_CUATRIVAGOS.USUARIOS where @usuario=Usuario_name)
	set @baja = (select Usuario_Baja from HOTEL_CUATRIVAGOS.USUARIOS where @usuario=Usuario_name)
		if (@deshabilitado=1)
		begin
		   raiserror('El usuario esta deshabilitado.',16,1)	
		   set @return=1 --El usuario no ingresa por estar deshabilitado
		   return
		end
		else
			if(@baja=1)
			begin
				raiserror('El usuario esta dado de baja.',16,1)
				set @return=2 --El usuario no ingresa por estar dado de baja
				return
			end
	end
else
	begin
		if exists (select Usuario_name from HOTEL_CUATRIVAGOS.USUARIOS where Usuario_name=@usuario and Usuario_pass!=@userpass)
		begin
			if((select Usuario_Intentos from HOTEL_CUATRIVAGOS.USUARIOS where @usuario = Usuario_name) = 2)
			begin
				
				raiserror('La contraseÃ±a ingresada no es correcta y el usuario quedo inhabilitado',16,1)
				update HOTEL_CUATRIVAGOS.USUARIOS set Usuario_Deshabilitado = 1
				where Usuario_name = @usuario
				set @return = 1
			end
			else
			begin
				update HOTEL_CUATRIVAGOS.USUARIOS set Usuario_Intentos = Usuario_Intentos + 1
				where Usuario_name = @usuario;
				raiserror('La contraseÃ±a ingresada no es correcta.',16,1)
				set @return = 3 --El usuario no ingresa por ingresar una contraseÃ±a incorrecta
				return
			end
		end
		else
		begin
			raiserror ('El usuario no existe.',16,1)
			set @return = 4 --El usuario no existe
		end
	end
end
GO

/** PROCEDURE ALTA DE ROL **/

create procedure HOTEL_CUATRIVAGOS.alta_rol @desc nvarchar(255), @estado bit, @funcionalidad nvarchar(255)
as begin transaction
	if exists(select r.Rol_Desc from HOTEL_CUATRIVAGOS.ROLES r where r.Rol_Desc = @desc)
		begin
			rollback
			raiserror('El rol ya existe.',16,1)
			return
		end
	declare @id numeric(18,0)
	set @id = (select MAX(Rol_Id) from HOTEL_CUATRIVAGOS.ROLES) + 1
	
	Insert into HOTEL_CUATRIVAGOS.ROLES(Rol_Id, Rol_Desc,Rol_estado) 
			values (@id, @desc, @estado)
			
	Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Rol_Id, Func_Id)
			values(@id, (select Func_Id from HOTEL_CUATRIVAGOS.FUNCIONALIDADES where Func_Desc = @funcionalidad))

commit
GO

/** PROCEDURE BAJA DEL ROL **/

create procedure HOTEL_CUATRIVAGOS.baja_rol @rol nvarchar(255)
as
begin transaction
	
	update HOTEL_CUATRIVAGOS.ROLES
		 set Rol_estado = 1
		 where Rol_Desc = @rol
	
commit 
GO 

/** PROCEDURE MODIFICACION DE ROL **/

create procedure HOTEL_CUATRIVAGOS.modificacion_rol @rol_id numeric(18,0), @descripcion nvarchar(255), @estado bit
as
begin transaction
	
	if exists(select r.Rol_Desc from HOTEL_CUATRIVAGOS.ROLES r 
				where r.Rol_Desc = @descripcion and 
					  r.Rol_Id != @rol_id)
		begin
			raiserror('El rol ya existe',16,1)
		end
	
	update HOTEL_CUATRIVAGOS.ROLES  
		set Rol_Desc = @descripcion,
			Rol_estado = @estado		
		where Rol_Id = @rol_id
commit
GO

/** PROCEDURE ALTA DE FUNCIONALIDAD POR ROL. **/

create procedure  HOTEL_CUATRIVAGOS.alta_funcionalidad_por_rol @funcionalidad nvarchar(255) , @rol nvarchar(255)
as
begin transaction
	
	if ((select r.Rol_estado from HOTEL_CUATRIVAGOS.ROLES r where r.Rol_Desc = @rol) = 1)
		begin
			rollback
			raiserror('El rol estÃ¡ dado de baja',16,1)
			return
		end
		
	if(not(exists(select f.Func_Id from HOTEL_CUATRIVAGOS.FUNCIONALIDADES f where @funcionalidad = Func_Desc)))
		begin 
			Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES(Func_Id, Func_Desc) values ((select MAX(Func_Id) from HOTEL_CUATRIVAGOS.FUNCIONALIDADES) + 1, @funcionalidad)
		end
	
	Insert into HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL(Func_Id,Rol_Id) 
	values ((select f.Func_Id from HOTEL_CUATRIVAGOS.FUNCIONALIDADES f where f.Func_Desc = @funcionalidad),
	        (select r.Rol_Id from HOTEL_CUATRIVAGOS.ROLES r where r.Rol_Desc = @rol))

commit
GO

/** PROCEDURE BAJA DE FUNCIONALIDAD POR ROL. **/

create procedure  HOTEL_CUATRIVAGOS.baja_funcionalidad_por_rol @funcionalidad nvarchar(255) , @rol nvarchar(255)
as
begin transaction
	
	declare @rol_id numeric(18,0)
	declare @func_id numeric(18,0)
	
	set @rol_id = (select r.Rol_Id from HOTEL_CUATRIVAGOS.ROLES r where r.Rol_Desc = @rol)
	set @func_id = (select f.Func_Id from HOTEL_CUATRIVAGOS.FUNCIONALIDADES f where @funcionalidad = Func_Desc)
	
	if ((select r.Rol_estado from HOTEL_CUATRIVAGOS.ROLES r where r.Rol_Desc = @rol) = 1)
		begin
			rollback
			raiserror('El rol está¡ dado de baja',16,1)
		end
		
	if (@rol_id is null)
		begin
			rollback
			raiserror('El rol no existe',16,1)
		end
		
	if(@func_id is null)
		begin 
			rollback
			raiserror('La funcionalidad no existe',16,1)
		end
		
	delete from HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL
	where Rol_Id = @rol_id and Func_Id = @func_id

commit
GO

/** PROCEDURE ALTA DE USUARIO  **/

create procedure HOTEL_CUATRIVAGOS.alta_usuario @username varchar(30), @pass nvarchar(255), @rol nvarchar(255), @nombre nvarchar(255), 
										  @apellido nvarchar(255), @telefono numeric(18,0), @tipo_ident nvarchar(30),
										  @nro_ident numeric(18,0), @mail nvarchar(255), @calle nvarchar(255),
										  @nro_calle numeric(18,0), @piso numeric(18,0), @depto nvarchar(50),
										  @fecha_nacimiento nvarchar(15), @hotel numeric(18,0)
as
begin transaction
	
	if exists(select *  from HOTEL_CUATRIVAGOS.DATOS_PERSONALES d where d.Datos_Tipo_Ident = @tipo_ident and Datos_Nro_Ident = @nro_ident)
		begin
			rollback
			raiserror('Ya existe un usuario con ese tipo y numero de documento',16,1)
			return
		end
		
	if exists(select *  from HOTEL_CUATRIVAGOS.USUARIOS u where u.Usuario_name = @username)
		begin
			rollback
			raiserror('Ya existe un usuario con ese nombre de usuario',16,1)
			return
		end		

	if exists(select *  from HOTEL_CUATRIVAGOS.DATOS_PERSONALES d where d.Datos_Mail = @mail)
		begin
			rollback
			raiserror('Ya existe un usuario con ese mail',16,1)
			return
		end
		
	if exists(select *  from HOTEL_CUATRIVAGOS.DATOS_PERSONALES d where d.Datos_Telefono = @telefono)
		begin
			rollback
			raiserror('Ya existe un usuario con ese telefono',16,1)
			return
		end
		
	if (not(exists (select h.Hotel_Id from HOTEL_CUATRIVAGOS.HOTELES h where h.Hotel_Id = @hotel)))
	
		begin
			rollback
			raiserror('El Hotel no existe.',16,1)
			return
		end	
		
	declare @fecha_correcta datetime
	set @fecha_correcta = @fecha_nacimiento
	Insert into HOTEL_CUATRIVAGOS.DATOS_PERSONALES(Datos_Nombre, Datos_Apellido, Datos_Telefono, Datos_Tipo_Ident,
											 Datos_Nro_Ident, Datos_Mail, Datos_Dom_Calle, Datos_Dom_Nro_Calle,
											 Datos_Dom_Piso, Datos_Dom_Depto, Datos_Fecha_Nac)
									  values(@nombre, @apellido, @telefono, @tipo_ident, @nro_ident, @mail,
									         @calle, @nro_calle, @piso, @depto, @fecha_correcta)
									         
    Insert into HOTEL_CUATRIVAGOS.USUARIOS(Usuario_name, Usuario_pass, Usuario_datos)
                             values(@username, @pass, (select MAX(Datos_Id) from HOTEL_CUATRIVAGOS.DATOS_PERSONALES))
                             
        
    Insert into HOTEL_CUATRIVAGOS.USUARIOS_X_ROL_X_HOTEL(Usuario_Id, Hotel_Id, Rol_Id) 
			values ((select MAX(Usuario_Id) from HOTEL_CUATRIVAGOS.USUARIOS), 
					@hotel, 
					(select Rol_Id from HOTEL_CUATRIVAGOS.ROLES where Rol_Desc = @rol) )

commit
GO
/** PROCEDURE MODIFICACION USUARIO **/

create procedure HOTEL_CUATRIVAGOS.modificacion_usuario @username varchar(30), @pass nvarchar(255),@nombre nvarchar(255), 
												  @apellido nvarchar(255), @telefono numeric(18,0), @tipo_ident nvarchar(30),
												  @nro_ident numeric(18,0), @mail nvarchar(255), @calle nvarchar(255),
												  @nro_calle numeric(18,0), @piso numeric(18,0), @depto nvarchar(50),
												  @fecha_nacimiento nvarchar(15), @usuario_id numeric(18,0), @hotel_id numeric(18,0),
												  @rol_desc nvarchar(255)
as
begin transaction
	
	if exists(select *  from HOTEL_CUATRIVAGOS.DATOS_PERSONALES d, HOTEL_CUATRIVAGOS.USUARIOS u 
				where u.Usuario_datos = d.Datos_Id and
					  d.Datos_Tipo_Ident = @tipo_ident and 
					  d.Datos_Nro_Ident = @nro_ident and
					  u.Usuario_Id != @usuario_id)
		begin
			rollback
			raiserror('Ya existe un usuario con ese tipo y numero de documento',16,1)
			return
		end
		
	if exists(select *  from HOTEL_CUATRIVAGOS.USUARIOS u
				 where u.Usuario_name = @username and
					   u.Usuario_Id != @usuario_id)
		begin
			rollback
			raiserror('Ya existe un usuario con ese nombre de usuario',16,1)
			return
		end		

	if exists(select *  from HOTEL_CUATRIVAGOS.DATOS_PERSONALES d, HOTEL_CUATRIVAGOS.USUARIOS u 
				where u.Usuario_datos = d.Datos_Id and
					  d.Datos_Mail = @mail and
					  u.Usuario_Id != @usuario_id)
		begin
			rollback
			raiserror('Ya existe un usuario con ese mail',16,1)
			return
		end
		
	if exists(select *  from HOTEL_CUATRIVAGOS.DATOS_PERSONALES d, HOTEL_CUATRIVAGOS.USUARIOS u 
				where u.Usuario_datos = d.Datos_Id and
					  d.Datos_Telefono = @telefono and
					  u.Usuario_Id != @usuario_id)
		begin
			rollback
			raiserror('Ya existe un usuario con ese telefono',16,1)
			return
		end
		
	if (not(exists (select h.Hotel_Id from HOTEL_CUATRIVAGOS.HOTELES h where h.Hotel_Id = @hotel_id)))
	
		begin
			rollback
			raiserror('El Hotel no existe.',16,1)
			return
		end	
		
	declare @rol_id numeric(18,0)
	set @rol_id = (select Rol_Id from HOTEL_CUATRIVAGOS.ROLES where Rol_Desc = @rol_desc)
		

	declare @fecha_correcta datetime
	set @fecha_correcta = @fecha_nacimiento
	declare @datos_id numeric(18,0)
	set @datos_id = (select u.Usuario_datos from HOTEL_CUATRIVAGOS.USUARIOS u
						where u.Usuario_Id = @usuario_id)
	
	
	Update HOTEL_CUATRIVAGOS.DATOS_PERSONALES
		set Datos_Nombre = @nombre,
			Datos_Apellido = @apellido,
			Datos_Telefono = @telefono,
			Datos_Tipo_Ident = @tipo_ident,
			Datos_Nro_Ident = @nro_ident,
			Datos_Mail = @mail,
			Datos_Dom_Calle = @calle, 
			Datos_Dom_Nro_Calle = @nro_calle,
			Datos_Dom_Piso = @piso, 
			Datos_Dom_Depto = @depto, 
			Datos_Fecha_Nac = @fecha_correcta		
		where Datos_Id = @datos_id
	
	Update HOTEL_CUATRIVAGOS.USUARIOS
		set Usuario_name = @username
		where Usuario_Id = @usuario_id
		
if(@pass != 'NULL')
	begin
		Update HOTEL_CUATRIVAGOS.USUARIOS
		set Usuario_pass = @pass
		where Usuario_Id = @usuario_id
	end

		
if (select COUNT(u.Usuario_Id)  from HOTEL_CUATRIVAGOS.USUARIOS_X_ROL_X_HOTEL u 
				where u.Hotel_Id = @hotel_id and
					  u.Rol_Id = @rol_id and 
					  u.Usuario_Id = @usuario_id)=0
	begin
		Insert into HOTEL_CUATRIVAGOS.USUARIOS_X_ROL_X_HOTEL(Usuario_Id, Rol_Id, Hotel_Id)
			values(@usuario_id, @rol_id, @hotel_id)
	end
									         
commit
GO

/** PROCEDURE ALTA DE CLIENTE **/

create procedure HOTEL_CUATRIVAGOS.alta_cliente @nombre nvarchar(255), @apellido nvarchar(255), @telefono numeric(18,0), 
										  @tipo_ident nvarchar(30), @nro_ident numeric(18,0), @mail nvarchar(255), 
										  @calle nvarchar(255), @nro_calle numeric(18,0), @piso numeric(18,0), 
										  @depto nvarchar(50), @fecha_nacimiento nvarchar(15), @nacionalidad nvarchar(255),
										  @id_cliente numeric(18,0) out
as
begin transaction
	
		
	if exists(select *  from HOTEL_CUATRIVAGOS.DATOS_PERSONALES d where d.Datos_Tipo_Ident = @tipo_ident and Datos_Nro_Ident = @nro_ident)
		begin
			rollback
			raiserror('Ya existe un cliente con ese tipo y numero de identificacion.',16,1)
			return
		end

	if exists(select *  from HOTEL_CUATRIVAGOS.DATOS_PERSONALES d where d.Datos_Mail = @mail)
		begin
			rollback
			raiserror('Ya existe un cliente con ese mail.',16,1)
			return
		end
		
	if exists(select *  from HOTEL_CUATRIVAGOS.DATOS_PERSONALES d where d.Datos_Telefono = @telefono)
		begin
			rollback
			raiserror('Ya existe un cliente con ese telefono.',16,1)
			return
		end
		
	declare @fecha_correcta datetime
	set @fecha_correcta = @fecha_nacimiento
	
	Insert into HOTEL_CUATRIVAGOS.DATOS_PERSONALES(Datos_Nombre, Datos_Apellido, Datos_Telefono, Datos_Tipo_Ident,
											 Datos_Nro_Ident, Datos_Mail, Datos_Dom_Calle, Datos_Dom_Nro_Calle,
											 Datos_Dom_Piso, Datos_Dom_Depto, Datos_Fecha_Nac)
									  values(@nombre, @apellido, @telefono, @tipo_ident, @nro_ident, @mail,
									         @calle, @nro_calle, @piso, @depto, @fecha_correcta)
									         
    Insert into HOTEL_CUATRIVAGOS.CLIENTES(Cliente_Nacionalidad, Cliente_Datos)
                             values(@nacionalidad, (select MAX(Datos_Id) from HOTEL_CUATRIVAGOS.DATOS_PERSONALES))
     
	set @id_cliente = (select MAX(c.Cliente_Id) from HOTEL_CUATRIVAGOS.CLIENTES c)     
commit
    return @id_cliente                         
GO

/** PROCEDURE MODIFICACION CLIENTE **/

create procedure HOTEL_CUATRIVAGOS.modificacion_cliente @nombre nvarchar(255), @apellido nvarchar(255), @telefono numeric(18,0), 
												  @tipo_ident nvarchar(30), @nro_ident numeric(18,0), @mail nvarchar(255), 
												  @calle nvarchar(255), @nro_calle numeric(18,0), @piso numeric(18,0), 
												  @depto nvarchar(50), @fecha_nacimiento nvarchar(15), @nacionalidad nvarchar(255),
												  @cliente_id numeric(18,0)
as
begin transaction
	
		
	if exists(select *  from HOTEL_CUATRIVAGOS.DATOS_PERSONALES d, HOTEL_CUATRIVAGOS.CLIENTES c 
				where c.Cliente_Datos = d.Datos_Id and
					  d.Datos_Tipo_Ident = @tipo_ident and 
					  d.Datos_Nro_Ident = @nro_ident and
					  c.Cliente_Id != @cliente_id)
		begin
			rollback
			raiserror('Ya existe un cliente con ese tipo y numero de identificacion.',16,1)
			return
		end

	if exists(select *  from HOTEL_CUATRIVAGOS.DATOS_PERSONALES d, HOTEL_CUATRIVAGOS.CLIENTES c 
				where c.Cliente_Datos = d.Datos_Id and
					  d.Datos_Mail = @mail and
					  c.Cliente_Id != @cliente_id)
		begin
			rollback
			raiserror('Ya existe un cliente con ese mail.',16,1)
			return
		end
		
	if exists(select *  from HOTEL_CUATRIVAGOS.DATOS_PERSONALES d, HOTEL_CUATRIVAGOS.CLIENTES c 
				where c.Cliente_Datos = d.Datos_Id and
					  d.Datos_Telefono = @telefono and
					  c.Cliente_Id != @cliente_id)
		begin
			rollback
			raiserror('Ya existe un cliente con ese telefono.',16,1)
			return
		end
		
	declare @fecha_correcta datetime
	set @fecha_correcta = @fecha_nacimiento
	declare @datos_id numeric(18,0)
	set @datos_id = (select c.Cliente_Datos from HOTEL_CUATRIVAGOS.CLIENTES c
						where c.Cliente_Id = @cliente_id )
	
	update HOTEL_CUATRIVAGOS.DATOS_PERSONALES
	set Datos_Nombre = @nombre,
			Datos_Apellido = @apellido,
			Datos_Telefono = @telefono,
			Datos_Tipo_Ident = @tipo_ident,
			Datos_Nro_Ident = @nro_ident,
			Datos_Mail = @mail,
			Datos_Dom_Calle = @calle, 
			Datos_Dom_Nro_Calle = @nro_calle,
			Datos_Dom_Piso = @piso, 
			Datos_Dom_Depto = @depto, 
			Datos_Fecha_Nac = @fecha_correcta		
		where Datos_Id = @datos_id
		
	update HOTEL_CUATRIVAGOS.CLIENTES
		set Cliente_Nacionalidad = @nacionalidad
		where Cliente_Id = @cliente_id

commit
GO

/** PROCEDURE ALTA DE HOTEL **/

create procedure HOTEL_CUATRIVAGOS.alta_hotel @nombre nvarchar(255), @mail nvarchar(255), @telefono numeric(18,0),
                                        @calle nvarchar(255), @nro_calle numeric(18,0), @ciudad nvarchar(255),
                                        @pais nvarchar(255), @fecha_creacion nvarchar(15), @estrellas numeric(18,0),
                                        @recarga_estrella numeric(18,0), @hotel_id numeric(18,0) out

as
begin transaction
	

	if exists(select *  from HOTEL_CUATRIVAGOS.HOTELES h where h.Hotel_Mail = @mail)
		begin
			rollback
			raiserror('Ya existe un hotel con este mail',16,1)
			return
		end

	if exists(select *  from HOTEL_CUATRIVAGOS.HOTELES h where h.Hotel_Telefono = @telefono)
		begin
			rollback
			raiserror('Ya existe un hotel con este telefono',16,1)
			return
		end
		
	if exists(select *  from HOTEL_CUATRIVAGOS.HOTELES h where h.Hotel_Ciudad = @ciudad and
	                                                   h.Hotel_Pais = @pais and
	                                                   h.Hotel_Calle = @calle and
	                                                   h.Hotel_Nro_Calle = @nro_calle)
		begin
			rollback
			raiserror('Ya existe un hotel en esta direccion',16,1)
			return
		end	
		
	declare @fecha_correcta datetime
	set @fecha_correcta = @fecha_creacion
		
	Insert into HOTEL_CUATRIVAGOS.HOTELES(Hotel_Nombre, Hotel_Mail, Hotel_Telefono, Hotel_Calle, Hotel_Nro_Calle, 
	                              Hotel_Ciudad, Hotel_Pais, Hotel_Fecha_Creacion, Hotel_Cant_Est, Hotel_Recarga_Estrella)
		                   values(@nombre, @mail, @telefono, @calle, @nro_calle, @ciudad, @pais, @fecha_correcta,
		                          @estrellas, @recarga_estrella)	                 
	set @hotel_id = (select max(Hotel_Id)from HOTEL_CUATRIVAGOS.HOTELES)
commit
	return @hotel_id
GO

/** PROCEDURE MODIFICACION DE HOTEL **/

create procedure HOTEL_CUATRIVAGOS.modificacion_hotel @nombre nvarchar(255), @mail nvarchar(255), @telefono numeric(18,0),
												@calle nvarchar(255), @nro_calle numeric(18,0), @ciudad nvarchar(255),
												@pais nvarchar(255), @estrellas numeric(18,0),
												@recarga_estrella numeric(18,0), @hotel_id numeric(18,0)

as
begin transaction
	
	if exists(select *  from HOTEL_CUATRIVAGOS.HOTELES h 
				where h.Hotel_Nombre = @nombre and
				      h.Hotel_Id != @hotel_id)
		begin
			rollback
			raiserror('Ya existe un hotel con este nombre',16,1)
			return
		end

	if exists(select *  from HOTEL_CUATRIVAGOS.HOTELES h 
				where h.Hotel_Mail = @mail and
				      h.Hotel_Id != @hotel_id)
		begin
			rollback
			raiserror('Ya existe un hotel con este mail',16,1)
			return
		end

	if exists(select *  from HOTEL_CUATRIVAGOS.HOTELES h 
				where h.Hotel_Telefono = @telefono and
				      h.Hotel_Id != @hotel_id)
		begin
			rollback
			raiserror('Ya existe un hotel con este telefono',16,1)
			return
		end
		
	if exists(select *  from HOTEL_CUATRIVAGOS.HOTELES h where h.Hotel_Ciudad = @ciudad and
	                                                   h.Hotel_Pais = @pais and
	                                                   h.Hotel_Calle = @calle and
	                                                   h.Hotel_Nro_Calle = @nro_calle and
													   h.Hotel_Id != @hotel_id)
		begin
			rollback
			raiserror('Ya existe un hotel en esta direccion',16,1)
			return
		end	

	update HOTEL_CUATRIVAGOS.HOTELES
	set Hotel_Nombre = @nombre,
	    Hotel_Mail = @mail,
	    Hotel_Telefono = @telefono,
	    Hotel_Calle = @calle,
	    Hotel_Nro_Calle = @nro_calle,
	    Hotel_Ciudad = @ciudad,
	    Hotel_Pais = @pais,
	    Hotel_Cant_Est = @estrellas,
	    Hotel_Recarga_Estrella = @recarga_estrella		
		where Hotel_Id = @hotel_id		
                 
commit
GO

/** PROCEDURE ALTA PERIODO DE CIERRE **/

create procedure HOTEL_CUATRIVAGOS.alta_periodo_cierre @hotel numeric(18,0), @fechaInicio nvarchar(15), @fechaFin nvarchar(15),
												 @motivo nvarchar(255)
as 
begin transaction
	declare
	@fecha_inicio_correcta datetime,
	@fecha_fin_correcta datetime
	
	set @fecha_inicio_correcta = @fechaInicio
	set @fecha_fin_correcta = @fechaFin
	
	if (@fecha_fin_correcta <= @fecha_inicio_correcta)
		begin
			rollback
			raiserror('La Fecha de fin es menor a la Fecha de Inicio',16,1)
			return	
		end
		
	Insert into HOTEL_CUATRIVAGOS.HOTEL_MANTENIMIENTO(Periodo_Hotel, Periodo_FechaInicio, Periodo_FechaFin, Periodo_Motivo)
				values (@hotel, @fecha_inicio_correcta, @fecha_fin_correcta, @motivo)


commit
GO

/** PROCEDURE ALTA DE HABITACION **/

create procedure HOTEL_CUATRIVAGOS.alta_habitacion @numero numeric(18,0), @piso numeric(18,0), @hotel numeric(18,0),
                                             @tipo numeric(18,0), @vista nvarchar(50), @descripcion nvarchar(255)
as
begin transaction

	if exists(select h.Habitacion_Id from HOTEL_CUATRIVAGOS.HABITACIONES h where h.Habitacion_Num = @numero and
	                                                                     h.Habitacion_Piso = @piso and
	                                                                     h.Habitacion_Hotel = @hotel)
		begin
			rollback
			raiserror('La habitacion ya existe en el hotel',16,1)
			return
		end
	
	Insert into HOTEL_CUATRIVAGOS.HABITACIONES(Habitacion_Num, Habitacion_Piso, Habitacion_Hotel, Habitacion_Tipo,
	                                   Habitacion_Vista, Habitacion_Desc) 
	                            values(@numero, @piso, @hotel, @tipo, @vista, @descripcion)                                                                    
	
commit 
GO

/** PROCEDURE MODIFICAR HABITACION **/

create procedure HOTEL_CUATRIVAGOS.modificacion_habitacion @numero numeric(18,0), @piso numeric(18,0), @hotel numeric(18,0),
													 @tipo numeric(18,0), @vista nvarchar(50), @descripcion nvarchar(255),
													 @habitacion_id numeric(18,0)
as
begin transaction
	
	if (not(exists (select h.Hotel_Id from HOTEL_CUATRIVAGOS.HOTELES h where h.Hotel_Id = @hotel)))
	
		begin
			rollback
			raiserror('El Hotel no existe.',16,1)
			return
		end
		
	if (not(exists (select t.Tipo_Hab_Id from HOTEL_CUATRIVAGOS.TIPO_HABITACION t where t.Tipo_Hab_Id = @tipo)))
	
		begin
			rollback
			raiserror('El Tipo no existe.',16,1)
			return
		end
	if exists(select h.Habitacion_Id from HOTEL_CUATRIVAGOS.HABITACIONES h where h.Habitacion_Num = @numero and
	                                                                     h.Habitacion_Piso = @piso and
	                                                                     h.Habitacion_Hotel = @hotel and
	                                                                     h.Habitacion_Id != @habitacion_id)
		begin
			rollback
			raiserror('La habitacion ya existe en el hotel',16,1)
			return
		end
		
		
		update HOTEL_CUATRIVAGOS.HABITACIONES
		set Habitacion_Num = @numero,
		    Habitacion_Piso = @piso,
		    Habitacion_Hotel = @hotel,
		    Habitacion_Tipo = @tipo,
		    Habitacion_Vista = @vista,
		    Habitacion_Desc = @descripcion		
		where Habitacion_Id = @habitacion_id		
                 
commit 
GO

/** PROCEDURE GENERAR RESERVA **/

create procedure HOTEL_CUATRIVAGOS.generar_reserva @fecha_reserva nvarchar(15), @fecha_desde nvarchar(15),
		                                     @fecha_hasta nvarchar(15), @tipo_regimen numeric(18,0), 
		                                     @id_cliente numeric(18,0), @id_hotel numeric(18,0),
		                                     @user_reservador numeric(18,0), @id_reserva numeric(18,0) out		                                     		                                     
as
begin transaction
	declare 
	@fecha_reserva_correcta datetime,
	@fecha_desde_correcta datetime,
	@fecha_hasta_correcta datetime,
	@cant_noches numeric(18,0)
	set @fecha_reserva_correcta = @fecha_reserva
	set @fecha_desde_correcta = @fecha_desde
	set @fecha_hasta_correcta = @fecha_hasta
	set @cant_noches = DATEDIFF(DAY,@fecha_desde_correcta,@fecha_hasta_correcta)
	set @id_reserva = (select MAX(r.Reserva_Id) from HOTEL_CUATRIVAGOS.RESERVAS r) + 1
	
	
	if (@fecha_hasta < @fecha_desde)
		begin
			rollback
			raiserror('Fecha de Ingreso mayor Fecha Egreso.',16,1)
			return
		end
	
	
	if exists (select p.Periodo_Id
			   from HOTEL_CUATRIVAGOS.HOTEL_MANTENIMIENTO p
			   where p.Periodo_Hotel = @id_hotel and
	                 (@fecha_desde_correcta between p.Periodo_FechaInicio and p.Periodo_FechaFin or
	                  @fecha_hasta_correcta between p.Periodo_FechaInicio and p.Periodo_FechaFin or 
	                  p.Periodo_FechaInicio between @fecha_desde_correcta and @fecha_hasta_correcta or
	                  p.Periodo_FechaFin between @fecha_desde_correcta and @fecha_hasta_correcta))
	    begin
			rollback
			raiserror('Hotel cerrado.',16,1)
			return 
		end
		
	
	Insert into HOTEL_CUATRIVAGOS.RESERVAS(Reserva_Id,Reserva_Cliente,Reserva_Fecha,Reserva_FechaIng,Reserva_CantNoches,
	                                Reserva_Estado,Reserva_Regimen,Reserva_Hotel)
	                         values(@id_reserva, @id_cliente, @fecha_reserva_correcta, @fecha_desde_correcta, @cant_noches,
	                                'Correcta', @tipo_regimen, @id_hotel)
    
    Insert into HOTEL_CUATRIVAGOS.LOG_RESERVA(Log_Fecha, Log_Reservador, Log_Descripcion, Log_Reserva) 
                                 values(@fecha_reserva_correcta, @user_reservador, 'Nueva Reserva', @id_reserva)                      
commit 
	return @id_reserva
GO

/** PROCEDURE MODIFICAR_RESERVA **/

create procedure HOTEL_CUATRIVAGOS.modificar_reserva @fecha_modificacion nvarchar(15), @fecha_desde nvarchar(15),
											   @fecha_hasta nvarchar(15), @tipo_regimen numeric(18,0), 
		                                       @id_cliente numeric(18,0), @user_reservador numeric(18,0),
		                                       @reserva_id numeric(18,0), @id_hotel numeric(18,0)

as
begin transaction


if exists(select * from HOTEL_CUATRIVAGOS.RESERVAS r where r.Reserva_Id = @reserva_id and r.Reserva_Estado = 'Cancelada')
	begin
		rollback
		raiserror('No se puede modificar una reserva cancelada.',16,1)
		return
	end
	
if exists(select * from HOTEL_CUATRIVAGOS.RESERVAS r where r.Reserva_Id = @reserva_id and r.Reserva_Estado = 'Efectivizada')
	begin
		rollback
		raiserror('No se puede modificar una reserva efectivizada.',16,1)
		return
	end

	declare
	@fecha_modificacion_correcta datetime,
	@fecha_desde_correcta datetime,
	@fecha_hasta_correcta datetime,
	@cant_noches numeric(18,0)
	set @fecha_modificacion_correcta = @fecha_modificacion
	set @fecha_desde_correcta = @fecha_desde
	set @fecha_hasta_correcta = @fecha_hasta
	set @cant_noches = DATEDIFF(DAY,@fecha_desde_correcta,@fecha_hasta_correcta)
	
	UPDATE HOTEL_CUATRIVAGOS.RESERVAS
	set Reserva_CantNoches = @cant_noches,
	    Reserva_FechaIng = @fecha_desde_correcta,
	    Reserva_Regimen = @tipo_regimen,
	    Reserva_Estado = 'Modificada',
	    Reserva_Hotel = @id_hotel
	where Reserva_Id = @reserva_id
	
	 Insert into HOTEL_CUATRIVAGOS.LOG_RESERVA(Log_Fecha, Log_Reservador, Log_Descripcion, Log_Reserva) 
                                 values(@fecha_modificacion_correcta, @user_reservador, 'Modificacion Reserva', @reserva_id)                      
commit 
GO

/** PROCEDURE CANCELAR RESERVA **/

create procedure HOTEL_CUATRIVAGOS.cancelar_reserva @fecha_cancelacion nvarchar(15), @reserva_id numeric(18,0),
                                              @user_cancelador numeric(18,0), @motivo nvarchar(50)
as
begin transaction
	
	declare @fecha_cancelacion_correcta datetime
	set @fecha_cancelacion_correcta = @fecha_cancelacion
		
	if (select r.Reserva_Estado from HOTEL_CUATRIVAGOS.RESERVAS r where r.Reserva_Id = @reserva_id) = 'Cancelada'
	begin
		rollback
		raiserror('Reserva ya cancelada.',16,1)
		return
	end
	
	
	if exists (select e.Estadia_Id from HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION rph, HOTEL_CUATRIVAGOS.ESTADIAS e, HOTEL_CUATRIVAGOS.FACTURA_ITEM i
					 where rph.Reserva_Id = @reserva_id and
						   e.Estadia_RPH = rph.RPH_Id and
						   e.Estadia_Id = i.Item_Factura_Id) 
	begin
		rollback
		raiserror('No se puede cancelar una reserva ya efectivizada.',16,1)
		return
	end
	
	
	if (select r.Reserva_FechaIng from HOTEL_CUATRIVAGOS.RESERVAS r where r.Reserva_Id = @reserva_id) >  DATEADD(DAY, 1, @fecha_cancelacion_correcta)
	begin
		rollback
		raiserror('No se puede cancelar a un dÃ­a de la reserva',16,1)
		return
	end
	
	Insert into HOTEL_CUATRIVAGOS.LOG_RESERVA(Log_Fecha, Log_Reservador, Log_Descripcion, Log_Reserva)
	                            values(@fecha_cancelacion_correcta, @user_cancelador, 'Cancelada por:'+' '+@motivo, @reserva_id)
	UPDATE HOTEL_CUATRIVAGOS.RESERVAS
	set Reserva_Estado = 'Cancelada'
	where Reserva_Id = @reserva_id
	
commit 
GO

/** PROCEDURE CANCELAR RESERVAS  **/

create procedure HOTEL_CUATRIVAGOS.cancelar_reservas @fecha nvarchar(15)
as begin transaction

declare @fecha_correcta datetime
	set @fecha_correcta = @fecha

Update HOTEL_CUATRIVAGOS.RESERVAS
	set Reserva_Estado = 'Cancelada por No Show'
	where Reserva_Estado = 'Correcta' or
		  Reserva_Estado != 'Modificada' and
		  Reserva_FechaIng < @fecha_correcta

commit
GO

/** PROCEDURE CHECK IN - ITEM FACTURA  **/

create procedure HOTEL_CUATRIVAGOS.check_in @rph_id numeric(18,0), @fecha_entrada nvarchar(15)
as
begin transaction

if exists (select * from HOTEL_CUATRIVAGOS.ESTADIAS where Estadia_RPH = @rph_id)
	begin
	rollback
	raiserror('Reserva ya efectivizada.',16,1)
	return
	end

if exists (select * from HOTEL_CUATRIVAGOS.RESERVAS r, HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION rph
						 where rph.RPH_Id = @rph_id and
							   rph.Reserva_Id = r.Reserva_Id and
							   r.Reserva_Estado = 'Cancelada')
	begin
	rollback
	raiserror('Reserva cancelada.',16,1)
	return
	end
	
	
	declare @fecha_correcta datetime
	set @fecha_correcta = @fecha_entrada
	
if exists (select * from HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION rph, HOTEL_CUATRIVAGOS.RESERVAS r 
							where rph.RPH_Id= @rph_id and
								  rph.Reserva_Id = r.Reserva_Id and
								  r.Reserva_FechaIng != @fecha_correcta)
	begin
	rollback
	raiserror('Imposible realizar el Check-In, fecha de ingreso incorrecta.',16,1)
	return
	end

	declare @id_item_fact numeric(18,0)
	set @id_item_fact = (ISNULL((select MAX(Item_Factura_Id)from HOTEL_CUATRIVAGOS.FACTURA_ITEM),0)) + 1

	declare @cant_noches numeric(18,0)
	set @cant_noches = (select r.Reserva_CantNoches 
						from HOTEL_CUATRIVAGOS.RESERVAS r, HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION rph
						where rph.RPH_Id = @rph_id and
							  r.Reserva_Id = rph.Reserva_Id)

	declare @item_monto numeric(18,2)
	set @item_monto = (select HOTEL_CUATRIVAGOS.costo_estadia (@rph_id, @cant_noches))


		
		Insert into HOTEL_CUATRIVAGOS.FACTURA_ITEM(Item_Factura_Id, Item_Factura_Cantidad, Item_Factura_Monto) 
						values (@id_item_fact, 1, @item_monto)
		

		Insert into HOTEL_CUATRIVAGOS.ESTADIAS(Estadia_Id, Estadia_RPH) values(@id_item_fact,@rph_id)
		
		declare 
		@reserva_id numeric(18,0),
		@habitacion_id numeric(18,0)
		
		set @reserva_id = (select r.Reserva_Id from RESERVAS_X_HABITACION r where r.RPH_Id = @rph_id)
		set @habitacion_id = (select r.Habitacion_Id from RESERVAS_X_HABITACION r where r.RPH_Id = @rph_id)
		
		UPDATE HOTEL_CUATRIVAGOS.RESERVAS
		set Reserva_Estado = 'Efectivizada'
		where Reserva_Id = @reserva_id
		
		UPDATE HOTEL_CUATRIVAGOS.HABITACIONES
		set Habitacion_Ocupada = 1
		where Habitacion_Id = @habitacion_id
		 
commit 
GO

/** PROCEDURE CHECK OUT - ITEM FACTURA de Estadia **/

create procedure HOTEL_CUATRIVAGOS.check_out @rph_id numeric(18,0), @fecha_salida nvarchar(15)
as 
begin transaction

if (select top 1 Estadia_Fecha_Salida from HOTEL_CUATRIVAGOS.ESTADIAS where Estadia_RPH = @rph_id) is not null
	begin
	rollback
	raiserror('Ya se registró el egreso de esa Habitación.',16,1)
	return
	end
	
if exists (select * from HOTEL_CUATRIVAGOS.RESERVAS r, HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION rph
						 where rph.RPH_Id = @rph_id and
							   rph.Reserva_Id = r.Reserva_Id and
							   r.Reserva_Estado = 'Cancelada')
	begin
	rollback
	raiserror('Reserva cancelada.',16,1)
	return
	end	

	declare @fecha_correcta datetime
	set @fecha_correcta = @fecha_salida
	
	declare @fecha_fin datetime
	set @fecha_fin = (select res.Reserva_FechaIng+res.Reserva_CantNoches from HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION rph, HOTEL_CUATRIVAGOS.RESERVAS res
								where rph.Reserva_Id = res.Reserva_Id and
									  rph.RPH_Id = @rph_id)
	declare @fecha_ing datetime
	set @fecha_ing = (select r.Reserva_FechaIng from HOTEL_CUATRIVAGOS.RESERVAS r, HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION rph
									where rph.RPH_Id = @rph_id and rph.Reserva_Id = r.Reserva_Id)
	
	if(@fecha_fin > @fecha_correcta and @fecha_correcta != @fecha_ing)
		begin
					
			declare @cant_noches_efectivizadas numeric(3,0)
			set @cant_noches_efectivizadas = DATEDIFF(DAY,@fecha_correcta,@fecha_fin)
			
			declare @id_item_fact numeric(18,0)
			set @id_item_fact = (ISNULL((select MAX(Item_Factura_Id)from HOTEL_CUATRIVAGOS.FACTURA_ITEM),0)) + 1

			declare @cant_noches numeric(18,0)
			set @cant_noches = (select r.Reserva_CantNoches 
								from HOTEL_CUATRIVAGOS.RESERVAS r, HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION resph
								where resph.RPH_Id = @rph_id and
									  r.Reserva_Id = resph.Reserva_Id)
			
			declare @item_monto_nuevo numeric(18,2)
			set @item_monto_nuevo = (select HOTEL_CUATRIVAGOS.costo_estadia (@rph_id, @cant_noches-@cant_noches_efectivizadas))
			

			Update HOTEL_CUATRIVAGOS.FACTURA_ITEM
				set Item_Factura_Monto = (select HOTEL_CUATRIVAGOS.costo_estadia (@rph_id, @cant_noches_efectivizadas))
					where Item_Factura_Id = (select est.Estadia_Id from HOTEL_CUATRIVAGOS.ESTADIAS est where est.Estadia_RPH = @rph_id)
			
			Insert into HOTEL_CUATRIVAGOS.FACTURA_ITEM(Item_Factura_Id, Item_Factura_Cantidad, Item_Factura_Monto) 
							values (@id_item_fact, 1, @item_monto_nuevo)
			
			Update HOTEL_CUATRIVAGOS.ESTADIAS 
				set Estadia_Fecha_Salida = @fecha_correcta
					where Estadia_RPH = @rph_id
			
			Insert into HOTEL_CUATRIVAGOS.ESTADIAS(Estadia_Id, Estadia_RPH,Estadia_Fecha_Salida) 
							values(@id_item_fact,@rph_id,@fecha_correcta)
							
		
		end
		
	else --cuando se retira en la fecha
		begin 
			
			Update HOTEL_CUATRIVAGOS.ESTADIAS 
			set Estadia_Fecha_Salida = @fecha_correcta
				where Estadia_RPH = @rph_id
				
		end

		Update HOTEL_CUATRIVAGOS.HABITACIONES
			set Habitacion_Ocupada = 0
				where Habitacion_Id in (select rph.Habitacion_Id from HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION rph
												 where rph.RPH_Id = @rph_id)
		
		Delete from HOTEL_CUATRIVAGOS.HUESPEDES_X_HABITACION
			where RPH_Id = @rph_id
		
commit
GO

/** PROCEDURE AGREGAR CONSUMIBLE POR HABITACION - ITEM FACTURA de Consumible **/

create procedure HOTEL_CUATRIVAGOS.alta_consumible_habitacion @rph_id numeric(18,0), @consumible_id numeric(18,0), @cant numeric(5,0)
as
begin transaction

if exists(select * from HOTEL_CUATRIVAGOS.RESERVAS r, HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION rph
			where @rph_id = rph.RPH_Id and
				  rph.Reserva_Id = r.Reserva_Id and
				  r.Reserva_Estado = 'Cancelada')
				  
	begin
	rollback
	raiserror('Reserva Cancelada.',16,1)
	return
	end

if exists(select r.Reserva_Id from HOTEL_CUATRIVAGOS.RESERVAS r, HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION rph
			where rph.RPH_Id = @rph_id and
				  rph.Reserva_Id = r.Reserva_Id and
				  r.Reserva_Estado != 'Efectivizada')
				  
	begin
	rollback
	raiserror('Reserva no efectivizada.',16,1)
	return
	end


if (select i.Item_Factura from HOTEL_CUATRIVAGOS.ESTADIAS e, HOTEL_CUATRIVAGOS.FACTURA_ITEM i
			where e.Estadia_RPH = @rph_id and
				  i.Item_Factura_Id = e.Estadia_Id) is not null
	begin
	rollback
	raiserror('Reserva ya facturada.',16,1)
	return
	end


declare @id_item_fact numeric(18,0)
set @id_item_fact = (ISNULL((select MAX(Item_Factura_Id)from HOTEL_CUATRIVAGOS.FACTURA_ITEM),0)) + 1

	
	Insert into HOTEL_CUATRIVAGOS.FACTURA_ITEM(Item_Factura_Id, Item_Factura_Cantidad, Item_Factura_Monto) 
					values (@id_item_fact, @cant, 
							(select c.Consumible_precio*@cant from HOTEL_CUATRIVAGOS.CONSUMIBLES c
									where c.Consumible_Id = @consumible_id))
	

	Insert into HOTEL_CUATRIVAGOS.CONSUMIBLES_X_HABITACION(Consumible_Por_Habitacion_Id, Consumible_Id, RPH_Id, Consumible_Cantidad) 
					values(@id_item_fact, @consumible_id, @rph_id, @cant)
commit 
GO

/** PROCEDURE GENERAR FACTURA **/

create procedure HOTEL_CUATRIVAGOS.generar_factura @cliente_id numeric(18,0), @fecha nvarchar(15), @fact_nro numeric(18,0) out
as
begin transaction

set @fact_nro = (ISNULL((select MAX(f.Factura_Id)from HOTEL_CUATRIVAGOS.FACTURAS f),0)) + 1

declare @fecha_correcta datetime
	set @fecha_correcta = @fecha

	insert into HOTEL_CUATRIVAGOS.FACTURAS(Factura_Id, Factura_Cliente, Factura_Fecha)
					values(@fact_nro, @cliente_id, @fecha_correcta)
	
commit 
	return @fact_nro
GO

/** PROCEDURE AGREGAR ITEMS A FACTURA **/

create procedure HOTEL_CUATRIVAGOS.agregar_items @fact_nro numeric(18,0), @rph_id numeric(18,0)
as
begin transaction

if exists (select * from HOTEL_CUATRIVAGOS.ESTADIAS e 
				where e.Estadia_RPH = @rph_id and
				      e.Estadia_Fecha_Salida is null)
	begin 
	
	rollback
	raiserror('No se ha realizado el Check-In en esa Reserva.',16,1)
	return
	
	end


if exists (select * from HOTEL_CUATRIVAGOS.FACTURA_ITEM i, HOTEL_CUATRIVAGOS.ESTADIAS 
				where i.Item_Factura_Id = Estadia_Id and
					  Estadia_RPH = @rph_id and 
					  i.Item_Factura is not null)
	begin 
	
	rollback
	raiserror('La Estadia ya se facturo.',16,1)
	return
	
	end
	
if exists (select * from HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION rph, HOTEL_CUATRIVAGOS.RESERVAS r
				where rph.RPH_Id = @rph_id and
					  rph.Reserva_Id = r.Reserva_Id and
					  r.Reserva_Estado = 'Cancelada')
	begin 
	
	rollback
	raiserror('La Reserva esta cancelada.',16,1)
	return
	
	end

update HOTEL_CUATRIVAGOS.FACTURA_ITEM
	set Item_Factura = @fact_nro
		where Item_Factura_Id in (select e.Estadia_Id from HOTEL_CUATRIVAGOS.ESTADIAS e where e.Estadia_RPH = @rph_id) or
			  Item_Factura_Id in (select c.Consumible_Por_Habitacion_Id from HOTEL_CUATRIVAGOS.CONSUMIBLES_X_HABITACION c where c.RPH_Id = @rph_id)

-- si es all inclusive no le cobramos los consumibles, solo la estadia

update HOTEL_CUATRIVAGOS.FACTURAS
	set Factura_Total = (select case when (select reg.Regimen_Desc from HOTEL_CUATRIVAGOS.RESERVAS r, HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION rph, HOTEL_CUATRIVAGOS.REGIMENES_ESTADIA reg
												where rph.RPH_Id = @rph_id and
													  r.Reserva_Id = rph.Reserva_Id and
													  r.Reserva_Regimen = reg.Regimen_Id) in ('All inclusive', 'All Inclusive moderado')
													  then (select i.Item_Factura_Monto 
																from HOTEL_CUATRIVAGOS.FACTURA_ITEM i 
																where i.Item_Factura = @fact_nro and
																	  i.Item_Factura_Id in 
																	  (select e.Estadia_Id from HOTEL_CUATRIVAGOS.ESTADIAS e))
								else (select SUM(i.Item_Factura_Monto) from HOTEL_CUATRIVAGOS.FACTURA_ITEM i
											where i.Item_Factura = @fact_nro)
								end)
	where Factura_Id = @fact_nro
	
commit 
GO

/** PROCEDURE AGREGAR TARJETA A FACTURA **/

create procedure HOTEL_CUATRIVAGOS.agregar_tarjeta @fact_nro numeric(18,0), @tarjeta_nro numeric(16,0), @duenio nvarchar(80), 
											 @tarjeta_fecha_venc nvarchar(15), @tipo_tarjeta nvarchar(30)
as begin transaction

declare @fecha_correcta datetime
set @fecha_correcta = @tarjeta_fecha_venc
declare @tarjeta numeric(16,0)

if exists(select d.Datos_Tarjeta_Id from HOTEL_CUATRIVAGOS.DATOS_TARJETA d where 
			d.Datos_Tarjeta_Nro = @tarjeta_nro and
			(d.Datos_Duenio_Tarjeta != @duenio or
			d.Datos_Tarjeta_Fecha_Venc != @fecha_correcta or
			d.Datos_Tipo_Tarjeta != @tipo_tarjeta))
	begin
		rollback
		raiserror('Datos de Tarjeta Incorrectos.',16,1)
		return	
	end			

if exists(select d.Datos_Tarjeta_Id from HOTEL_CUATRIVAGOS.DATOS_TARJETA d where 
			d.Datos_Tarjeta_Nro = @tarjeta_nro and
			d.Datos_Duenio_Tarjeta = @duenio and
			d.Datos_Tarjeta_Fecha_Venc = @fecha_correcta and
			d.Datos_Tipo_Tarjeta = @tipo_tarjeta)
	begin
	
		set @tarjeta = (select d.Datos_Tarjeta_Id from HOTEL_CUATRIVAGOS.DATOS_TARJETA d where 
							d.Datos_Tarjeta_Nro = @tarjeta_nro and
							d.Datos_Duenio_Tarjeta = @duenio and
							d.Datos_Tarjeta_Fecha_Venc = @fecha_correcta and
							d.Datos_Tipo_Tarjeta = @tipo_tarjeta)
		
	end
	
else
	begin
			
		Insert into HOTEL_CUATRIVAGOS.DATOS_TARJETA(Datos_Tarjeta_Nro, Datos_Duenio_Tarjeta, Datos_Tarjeta_Fecha_Venc, Datos_Tipo_Tarjeta)
							values(@tarjeta_nro, @duenio, @fecha_correcta, @tipo_tarjeta)
				
		set @tarjeta = (select MAX(Datos_Tarjeta_Id) from HOTEL_CUATRIVAGOS.DATOS_TARJETA)
		
	end	
	
		Update HOTEL_CUATRIVAGOS.FACTURAS
			set Factura_Tarjeta = @tarjeta
				where Factura_Id = @fact_nro
		
commit
GO


----------------------------------------------------   Funciones    ----------------------------------------------------

/** PROCEDURE COSTO DE LAS ESTADIAS **/

create function HOTEL_CUATRIVAGOS.costo_estadia (@rph_id numeric(18,0), @cant_noches numeric(18,0))
returns numeric(18,0)
as
begin
	declare @costo_Estadia numeric(18,0)
	set @costo_estadia = (select ((reg.Regimen_Precio*tipo.Tipo_Hab_Porc)+(ho.Hotel_Recarga_Estrella*ho.Hotel_Cant_Est))*@cant_noches
						  from HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION rph, HOTEL_CUATRIVAGOS.HABITACIONES ha, HOTEL_CUATRIVAGOS.HOTELES ho, 
							   HOTEL_CUATRIVAGOS.REGIMENES_ESTADIA reg, HOTEL_CUATRIVAGOS.RESERVAS r, HOTEL_CUATRIVAGOS.TIPO_HABITACION tipo
						  where rph.RPH_Id = @rph_id and
							    rph.Habitacion_Id = ha.Habitacion_Id and
							    ho.Hotel_Id = ha.Habitacion_Hotel and
							    ha.Habitacion_Tipo = tipo.Tipo_Hab_Id and
							    rph.Reserva_Id = r.Reserva_Id and
							    r.Reserva_Regimen = reg.Regimen_Id)
   return @costo_estadia
end
GO

----------------------------------------------------   Estadisticas   ----------------------------------------------------

/** PROCEDURE HOTELES CON MAYOR CANTIDAD DE RESERVAS CANCELADAS **/

create function HOTEL_CUATRIVAGOS.hoteles_reservas_mas_canceladas (@anio numeric(4,0),@mesInicio numeric(2,0), @mesFin numeric(2,0))
returns @tabla table (hotel_nombre nvarchar(255),
					  hotel_mail nvarchar(255),
					  hotel_telefono numeric(18,0),
					  hotel_ciudad nvarchar(255),
					  hotel_pais nvarchar(255) )
	as begin 
	
	insert into @tabla (hotel_nombre, hotel_mail, hotel_telefono, hotel_ciudad, hotel_pais)
			(select top 5 h.Hotel_Nombre, h.Hotel_Mail, h.Hotel_Telefono, h.Hotel_Ciudad, h.Hotel_Pais
				  from HOTEL_CUATRIVAGOS.RESERVAS r, HOTEL_CUATRIVAGOS.HOTELES h
						where r.Reserva_Estado='Cancelada' and 
							  r.Reserva_Hotel=h.Hotel_Id and
							  year(r.Reserva_Fecha)=@anio and
							  month(r.Reserva_Fecha) between @mesInicio and @mesFin
								group by h.Hotel_Id,h.Hotel_Nombre, h.Hotel_Mail, h.Hotel_Telefono, h.Hotel_Ciudad, h.Hotel_Pais)
								order by count(r.Reserva_Id) desc
	
	return 
end
GO

/** PROCEDURE HOTELES CON MAYOR CANTIDAD DE CONSUMIBLES FACTURADOS **/

create function HOTEL_CUATRIVAGOS.hoteles_consumibles_facturados(@anio numeric(4,0),@mesInicio numeric(2,0), @mesFin numeric(2,0))
returns @tabla table (hotel_nombre nvarchar(255),
					  hotel_mail nvarchar(255),
					  hotel_telefono numeric(18,0),
					  hotel_ciudad nvarchar(255),
					  hotel_pais nvarchar(255) )
	as begin 
	
	insert into @tabla (hotel_nombre, hotel_mail, hotel_telefono, hotel_ciudad, hotel_pais)
			(select top 5 ho.Hotel_Nombre, ho.Hotel_Mail, ho.Hotel_Telefono, ho.Hotel_Ciudad, ho.Hotel_Pais
				  from HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION r, HOTEL_CUATRIVAGOS.HOTELES ho, HOTEL_CUATRIVAGOS.HABITACIONES ha,
				       HOTEL_CUATRIVAGOS.CONSUMIBLES_X_HABITACION c, HOTEL_CUATRIVAGOS.FACTURAS f, HOTEL_CUATRIVAGOS.FACTURA_ITEM i
				  where c.RPH_Id = r.RPH_Id and
				        r.Habitacion_Id = ha.Habitacion_Id and
				        ha.Habitacion_Hotel = ho.Hotel_Id and
				        i.Item_Factura = f.Factura_Id and
				        i.Item_Factura_Id = c.Consumible_Por_Habitacion_Id and
						year(f.Factura_Fecha)=@anio and
						month(f.Factura_Fecha) between @mesInicio and @mesFin
				  group by ho.Hotel_Id ,ho.Hotel_Nombre, ho.Hotel_Mail, ho.Hotel_Telefono, ho.Hotel_Ciudad, ho.Hotel_Pais)
				  order by count(c.Consumible_Por_Habitacion_Id) desc
		return 
end
GO

/** PROCEDURE HOTELES CON MAYOR CANTIDAD DE DIAS FUERA DE SERVICIO  **/

create function HOTEL_CUATRIVAGOS.hoteles_fuera_de_servicio(@anio numeric(4,0),@mesInicio numeric(2,0), @mesFin numeric(2,0))
returns @tabla table (hotel_nombre nvarchar(255),
					  hotel_mail nvarchar(255),
					  hotel_telefono numeric(18,0),
					  hotel_ciudad nvarchar(255),
					  hotel_pais nvarchar(255) )
	as begin 
	
	insert into @tabla (hotel_nombre, hotel_mail, hotel_telefono, hotel_ciudad, hotel_pais)
			(select top 5 ho.Hotel_Nombre, ho.Hotel_Mail, ho.Hotel_Telefono, ho.Hotel_Ciudad, ho.Hotel_Pais
				  from HOTEL_CUATRIVAGOS.HOTELES ho, HOTEL_CUATRIVAGOS.HOTEL_MANTENIMIENTO p
				  where p.Periodo_Hotel = ho.Hotel_Id and
						year(p.Periodo_FechaInicio)=@anio and
						month(p.Periodo_FechaInicio) between @mesInicio and @mesFin
				  group by ho.Hotel_Id,ho.Hotel_Nombre, ho.Hotel_Mail, ho.Hotel_Telefono, ho.Hotel_Ciudad, ho.Hotel_Pais)
				  order by SUM(DATEDIFF(DAY,p.Periodo_FechaInicio,p.Periodo_FechaFin)) desc
	return 
end
GO

/** PROCEDURE HABITACIONES CON MAYOR CANTIDAD DE DIAS Y VECES QUE FUERON OCUPADAS  **/

create function HOTEL_CUATRIVAGOS.habitaciones_mas_ocupadas(@anio numeric(4,0),@mesInicio numeric(2,0), @mesFin numeric(2,0))
returns @tabla table (habitacion_num numeric(18,0),
					  habitacion_piso numeric(18,0),
					  descripcion_tipo nvarchar(255),
					  habitacion_desc nvarchar(255),
					  hotel_nombre nvarchar(255),
					  hotel_ciudad nvarchar(255),
					  hotel_pais nvarchar(255) )
	as begin 
	
	insert into @tabla (habitacion_num, habitacion_piso, descripcion_tipo, habitacion_desc, hotel_nombre, hotel_ciudad, hotel_pais)
			(select top 5 ha.Habitacion_Num, ha.Habitacion_Piso, t.Tipo_Hab_Desc, ha.Habitacion_Desc, 
						  ho.Hotel_Nombre, ho.Hotel_Ciudad, ho.Hotel_Pais
					from HOTEL_CUATRIVAGOS.RESERVAS r, HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION rph, HOTEL_CUATRIVAGOS.HABITACIONES ha, 
					     HOTEL_CUATRIVAGOS.HOTELES ho, HOTEL_CUATRIVAGOS.TIPO_HABITACION t
					where year(r.Reserva_Fecha)=@anio and
						  month(r.Reserva_Fecha) between @mesInicio and @mesFin and
						  r.Reserva_Id = rph.Reserva_Id and
						  ha.Habitacion_Id = rph.Habitacion_Id and
						  ha.Habitacion_Hotel = ho.Hotel_Id and
						  ha.Habitacion_Tipo = t.Tipo_Hab_Id
					group by ha.Habitacion_Id, ha.Habitacion_Num, ha.Habitacion_Piso, t.Tipo_Hab_Desc, ha.Habitacion_Desc, 
							 ho.Hotel_Nombre, ho.Hotel_Ciudad, ho.Hotel_Pais)
					order by SUM(r.Reserva_CantNoches)desc, COUNT(rph.RPH_Id) desc
		return 
end
GO

/** PROCEDURE CLIENTES CON MAS PUNTOS **/

create function HOTEL_CUATRIVAGOS.clientes_mas_puntos(@anio numeric(4,0),@mesInicio numeric(2,0), @mesFin numeric(2,0))
returns @tabla table (nombre nvarchar(255),
					  apellido nvarchar(255),
					  tipo_ident nvarchar(30),
					  nro_ident numeric(18,0),
					  nacionalidad nvarchar(255))
	as begin 
	
	insert into @tabla (nombre, apellido, tipo_ident, nro_ident, nacionalidad)
			(select top 5 d.Datos_Nombre, d.Datos_Apellido, d.Datos_Tipo_Ident, d.Datos_Nro_Ident, c.Cliente_Nacionalidad
		from HOTEL_CUATRIVAGOS.CLIENTES c, HOTEL_CUATRIVAGOS.DATOS_PERSONALES d
			 where c.Cliente_Datos = d.Datos_Id)
		order by ((select floor(SUM(i.Item_Factura_Monto)/10)  from HOTEL_CUATRIVAGOS.FACTURAS f, HOTEL_CUATRIVAGOS.FACTURA_ITEM i
			where f.Factura_Cliente = c.Cliente_Id and
				  year(f.Factura_Fecha)=@anio and
				  month(f.Factura_Fecha) between @mesInicio and @mesFin and
				  i.Item_Factura = f.Factura_Id and
				  i.Item_Factura_Id in (select e.Estadia_Id from HOTEL_CUATRIVAGOS.ESTADIAS e))+
		(select floor(SUM(i.Item_Factura_Monto)/5)  from HOTEL_CUATRIVAGOS.FACTURAS f, HOTEL_CUATRIVAGOS.FACTURA_ITEM i
			where f.Factura_Cliente = c.Cliente_Id and
				  year(f.Factura_Fecha)=@anio and
				  month(f.Factura_Fecha) between @mesInicio and @mesFin and
				  i.Item_Factura = f.Factura_Id and
				  i.Item_Factura_Id in (select c.Consumible_Por_Habitacion_Id from HOTEL_CUATRIVAGOS.CONSUMIBLES_X_HABITACION c))) desc
	return 
end
GO

----------------------------------------------------   Trigger    ----------------------------------------------------

create trigger tr_delete_regimen_por_hotel on HOTEL_CUATRIVAGOS.REGIMEN_X_HOTEL
instead of DELETE
as 
begin transaction 
	
	if not(exists (select r.Reserva_Id 
	               from HOTEL_CUATRIVAGOS.RESERVAS r, Deleted d 
	               where d.Regimen_Id = r.Reserva_Regimen and
	                     d.Hotel_Id = r.Reserva_Hotel))
		
		DELETE from HOTEL_CUATRIVAGOS.REGIMEN_X_HOTEL
		where Hotel_Id = (select d.Hotel_Id from Deleted d) and
		      Regimen_Id = (select d.Regimen_Id from Deleted d)
		      
commit
GO













