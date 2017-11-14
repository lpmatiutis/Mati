--create database Turismo;
--use Turismo;

-- Tablas
--Tabla de tipo documento
CREATE TABLE TipoDocumento (
	TipoDocumentoID INT NOT NULL IDENTITY (1,1),
	Descripcion VARCHAR(50) NOT NULL,
	CONSTRAINT PK_TipoDocumento PRIMARY KEY (TipoDocumentoID),
);

--Tabla de profesion
CREATE TABLE Profesion(
	ProfesionID INT NOT NULL IDENTITY (1,1),
	Descripcion VARCHAR(50),
	CONSTRAINT PK_Profesion PRIMARY KEY (ProfesionID),
);

--Tabla de tipo cliente
CREATE TABLE TipoCliente(
	TipoClienteID INT NOT NULL IDENTITY(1,1),
	Descripcion VARCHAR(30) NOT NULL,
	CONSTRAINT PK_TipoCliente PRIMARY KEY (TipoClienteID),
);
--Tabla de Cliente
create table cliente(
ClienteID INT NOT NULL IDENTITY (1,1),
	Nombre VARCHAR(50) NOT NULL,
	Apellido VARCHAR(50) NOT NULL,
	TipoDocumentoID INT NOT NULL,
	NroDocumento VARCHAR(30) NOT NULL,
	EstadoCivil CHAR(1) NOT NULL,
	Telefono VARCHAR(30) NOT NULL,
	Direccion VARCHAR(100) NOT NULL,
	Email VARCHAR(50) NOT NULL,
	FechaNacimiento DATE NOT NULL,
	ProfesionID INT NOT NULL,
	Sexo BIT NOT NULL,
	TipoClienteID INT NOT NULL,
	EstadoSistema BIT NOT NULL DEFAULT 1,
	CONSTRAINT PK_Cliente PRIMARY KEY (ClienteID),
	CONSTRAINT FK_Cliente_TipoDocumento FOREIGN KEY (TipoDocumentoID) REFERENCES TipoDocumento(TipoDocumentoID),
	CONSTRAINT FK_Cliente_Profesion FOREIGN KEY (ProfesionID) REFERENCES Profesion(ProfesionID),
	CONSTRAINT FK_Cliente_TipoCliente FOREIGN KEY (TipoClienteID) REFERENCES TipoCliente(TipoClienteID),
	CONSTRAINT UQ_Cliente UNIQUE (TipoDocumentoID, NroDocumento),);

	--Tabla de cargo empleado
	CREATE TABLE CargoEmpleado (
	CargoEmpleadoID INT NOT NULL IDENTITY (1,1),
	Nombre VARCHAR(50) NOT NULL,
	Descripcion VARCHAR(256) NOT NULL,
	CONSTRAINT PK_CargoEmpleado PRIMARY KEY (CargoEmpleadoID),
);
	--Tabla de ciudad
	CREATE TABLE Ciudad (
	CiudadID INT NOT NULL IDENTITY (1,1),
	--DepartamentoID INT NOT NULL,
	--PaisID INT NOT NULL,
	Descripcion VARCHAR(50) NOT NULL,
	CONSTRAINT PK_Ciudad PRIMARY KEY (CiudadID),
	--CONSTRAINT FK_Ciudad_Departamento FOREIGN KEY (DepartamentoID) REFERENCES Departamento(DepartamentoID),
	--CONSTRAINT FK_Ciudad_Pais FOREIGN KEY (PaisID) REFERENCES Pais(PaisID),
);
	--Tabla de sucursal empresa
	CREATE TABLE SucursalEmpresa (
	SucursalEmpresaID INT NOT NULL IDENTITY (1,1),
	Nombre VARCHAR (50) NOT NULL,
	CiudadID INT NOT NULL,
	Telefono VARCHAR (30),
	Direccion VARCHAR (100),
	Email VARCHAR (50),
	CantidadEmpleados INT NOT NULL,
	EstadoSistema BIT NOT NULL DEFAULT 1,
	CONSTRAINT PK_SucursalEmpresa PRIMARY KEY (SucursalEmpresaID),
	CONSTRAINT FK_SucursalEmpresa_Ciudad FOREIGN KEY (CiudadID) REFERENCES Ciudad(CiudadID),
);
	--Tabla de Empleado
	CREATE TABLE Empleado (
	EmpleadoID INT NOT NULL IDENTITY (1,1),
	Nombre VARCHAR(50) NOT NULL,
	Apellido VARCHAR(50) NOT NULL,
	CargoEmpleadoID INT NOT NULL,
	TipoDocumentoID INT NOT NULL,
	NroDocumento VARCHAR(30) NOT NULL,
	FechaNacimiento DATE NOT NULL,
	SucursalEmpresaID INT NOT NULL,
	Telefono VARCHAR(30) NOT NULL,
	Direccion VARCHAR(100) NOT NULL,
	EstadoCivil CHAR(1) NOT NULL,
	Antiguedad INT NOT NULL,           -- en años
	EstadoSistema BIT NOT NULL DEFAULT 1,
	CONSTRAINT PK_Empleado PRIMARY KEY (EmpleadoID),
	CONSTRAINT FK_Empleado_CargoEmpleado FOREIGN KEY (CargoEmpleadoID) REFERENCES CargoEmpleado(CargoEmpleadoID),
	CONSTRAINT FK_Empleado_TipoDocumento FOREIGN KEY (TipoDocumentoID) REFERENCES TipoDocumento(TipoDocumentoID),
	CONSTRAINT FK_Empleado_SucursalEmpresa FOREIGN KEY (SucursalEmpresaID) REFERENCES SucursalEmpresa(SucursalEmpresaID),
);

	--Tabla de hotel
CREATE TABLE Alojamiento (
	AlojamientoID INT NOT NULL IDENTITY (1,1),
	--TipoAlojamientoID INT NOT NULL,
	--Imagen Image,
	Nombre VARCHAR(50),
	Direccion VARCHAR(100) NOT NULL,
	Telefono VARCHAR(30) NOT NULL,
	PaginaWeb VARCHAR(30) NOT NULL,
	Estrellas INT NOT NULL,
	EstadoSistema BIT NOT NULL DEFAULT 1,
	CONSTRAINT PK_Alojamiento PRIMARY KEY (AlojamientoID),
	--CONSTRAINT FK_Alojamiento_TipoAlojamiento FOREIGN KEY (TipoAlojamientoID) REFERENCES TipoAlojamiento(TipoAlojamientoID),
);

	--Tabla de reserva
	CREATE TABLE Reserva (
	ReservaID INT NOT NULL IDENTITY (1,1),
	ClienteID INT NOT NULL,
	AlojamientoID INT NOT NULL,
	--SucursalAlojamientoID INT NOT NULL,
	PrecioReserva MONEY NOT NULL,
	FechaReserva DATETIME NOT NULL,
	Pagado BIT NOT NULL,
	CONSTRAINT PK_Reserva PRIMARY KEY (ReservaID),
	CONSTRAINT FK_Reserva_Cliente FOREIGN KEY (ClienteID) REFERENCES Cliente (ClienteID),
	CONSTRAINT FK_Reserva_AlojamientoID FOREIGN KEY (AlojamientoID) REFERENCES Alojamiento(AlojamientoID),
	--CONSTRAINT FK_Reserva_Sucursal FOREIGN KEY (SucursalAlojamientoID) REFERENCES SucursalAlojamiento(SucursalAlojamientoID),
);

-- Procedimiento ActualizarCliente
create procedure [dbo].[spActualizarCliente] @ClienteID int,
@Nombre varchar(50), @Apellido varchar(50), @TipoDocumentoID int, @NroDocumento varchar(30), @EstadoCivil char(1), @Telefono varchar(30),
@Direccion varchar(100), @Email varchar(50), @FechaNacimiento date, @ProfesionID int, @Sexo bit, @TipoClienteID int, @EstadoSistema bit
as
Begin
	update cliente
	set Nombre = @Nombre,
	Apellido = @Apellido,
	TipoDocumentoID = @TipoDocumentoID,
	NroDocumento = @NroDocumento,
	EstadoCivil = @EstadoCivil,
	Telefono = @Telefono,
	Direccion = @Direccion,
	Email = @Email,
	FechaNacimiento = @FechaNacimiento,
	ProfesionID = @ProfesionID,
	Sexo = @Sexo,
	TipoClienteID = @TipoClienteID,
	EstadoSistema = @EstadoSistema
	where ClienteID = @ClienteID
End
	--Procedimiento InsertarCliente
	Create Procedure [dbo].[spInsertarCliente] @Nombre varchar(50), @Apellido varchar(50), @TipoDocumentoID int, @NroDocumento varchar(30), @EstadoCivil char(1), @Telefono varchar(30),
@Direccion varchar(100), @Email varchar(50), @FechaNacimiento date, @ProfesionID int, @Sexo bit, @TipoClienteID int, @EstadoSistema bit
As
Begin
-- Cuerpo
	Insert cliente values(@Nombre,@Apellido, @TipoDocumentoID, @NroDocumento, @EstadoCivil, @Telefono,
	@Direccion, @Email, @FechaNacimiento, @ProfesionID, @Sexo, @TipoClienteID, @EstadoSistema)
End
	--Procedimiento EliminarCliente
	create Procedure [dbo].[spEliminarClientea] @ClienteID int
as
begin
	delete from cliente where ClienteID = @ClienteID
end
	--Procedimiento ListarCliente
	create procedure [dbo].[spListarCliente]
as
begin
	select * from cliente order by Nombre
end
	--Procedimiento ListarClienteNombre
	create procedure [dbo].[spListarClienteNombre] @Nombre varchar(50)
as
begin
	select * from cliente where Nombre=@Nombre
end

	--Procedimiento para ActualizarEmpleado
create procedure [dbo].[spActualizarEmpleado] @EmpleadoID int, @Nombre varchar(50), @Apellido varchar(50), @CargoEmpleadoID int,
@TipoDocumentoID int, @NroDocumento varchar(50), @FechaNacimiento date, @SucursalEmpresaID int, @Telefono varchar(30),
@Direccion varchar(100), @EstadoCivil char(1), @Antiguedad int, @EstadoSistema bit
as
Begin
	update Empleado
	set Nombre = @Nombre,
	Apellido = @Apellido,
	CargoEmpleadoID = @CargoEmpleadoID,
	TipoDocumentoID = @TipoDocumentoID,
	NroDocumento = @NroDocumento,
	FechaNacimiento = @FechaNacimiento,
	SucursalEmpresaID = @SucursalEmpresaID,
	Telefono = @Telefono,
	Direccion = @Direccion,
	EstadoCivil = @EstadoCivil,
	Antiguedad = @Antiguedad,
	EstadoSistema = @EstadoSistema
	where EmpleadoID = @EmpleadoID
End
	--Procedimiento InsertarEmpleado
	Create Procedure [dbo].[spInsertarEmpleado] @Nombre varchar(50), @Apellido varchar(50), @CargoEmpleadoID int,
@TipoDocumentoID int, @NroDocumento varchar(50), @FechaNacimiento date, @SucursalEmpresaID int, @Telefono varchar(30),
@Direccion varchar(100), @EstadoCivil char(1), @Antiguedad int, @EstadoSistema bit
As
Begin
-- Cuerpo
	Insert Empleado values(@Nombre,@Apellido, @CargoEmpleadoID, @TipoDocumentoID, @NroDocumento, @FechaNacimiento,
	@SucursalEmpresaID, @Telefono, @Direccion, @EstadoCivil, @Antiguedad, @EstadoSistema)
End
	--Procedimiento EliminarEmpleado
	create Procedure [dbo].[spEliminarEmpleado] @EmpleadoID int
as
begin
	delete from Empleado where EmpleadoID = @EmpleadoID
end
	--Procedimiento ListarEmpleado
	create procedure [dbo].[spListarEmpleado]
as
begin
	select * from Empleado order by Nombre
end
	--Procedimiento ListarEmpleadoNombre
	create procedure [dbo].[spListarEmpleadoNombre] @Nombre varchar(50)
as
begin
	select * from Empleado where Nombre=@Nombre
end

	--Procedimiento ActualizarAlojamiento
	create procedure [dbo].[spActualizarAlojamiento] @AlojamientoID int, @Nombre varchar(50), @Direccion varchar(50),
	@Telefono varchar(30), @PaginaWeb varchar(30), @Estrellas int, @EstadoSistema bit
as
Begin
	update Alojamiento
	set Nombre = @Nombre,
	Direccion = @Direccion,
	Telefono = @Telefono,
	PaginaWeb = @PaginaWeb,
	Estrellas = @Estrellas,
	EstadoSistema = @EstadoSistema
	where AlojamientoID = @AlojamientoID
End
	--Procedimiento InsertarAlojamiento
	Create Procedure [dbo].[spInsertarAlojamiento] @Nombre varchar(50), @Direccion varchar(50),
	@Telefono varchar(30), @PaginaWeb varchar(30), @Estrellas int, @EstadoSistema bit
As
Begin
-- Cuerpo
	Insert Alojamiento values(@Nombre,@Direccion, @Telefono, @PaginaWeb, @Estrellas, @EstadoSistema)
End
	--Procedimiento EliminarAlojamiento
	create Procedure [dbo].[spEliminarAlojamiento] @AlojamientoID int
as
begin
	delete from Alojamiento where AlojamientoID = @AlojamientoID
end
	--Procedimiento ListarAlojamiento
	create procedure [dbo].[spListarAlojamientoD]
as
begin
	select * from Alojamiento order by Nombre
end
	--Procedimiento ListarAlojamientoNombre
	create procedure [dbo].[spListarAlojamientoNombre] @Nombre varchar(50)
as
begin
	select * from Alojamiento where Nombre=@Nombre 
end

	--Procedimiento ActualizarSucursal
	create procedure [dbo].[spActualizarSucursal] @SucursalEmpresaID int, @Nombre varchar(50), @CiudadID int,
	@Telefono varchar(30), @Direccion varchar(100), @Email varchar(50), @CantidadEmpleados int, @EstadoSistema bit
as
Begin
	update SucursalEmpresa
	set Nombre = @Nombre,
	CiudadID = @CiudadID,
	Telefono = @Telefono,
	Direccion = @Direccion,
	Email = @Email,
	CantidadEmpleados = @CantidadEmpleados,
	EstadoSistema = @EstadoSistema
	where SucursalEmpresaID = @SucursalEmpresaID
End
	--Procedimiento InsertarSucursal
	Create Procedure [dbo].[spInsertarSucursal] @Nombre varchar(50), @CiudadID int,
	@Telefono varchar(30), @Direccion varchar(100), @Email varchar(50), @CantidadEmpleados int, @EstadoSistema bit
As
Begin
-- Cuerpo
	Insert SucursalEmpresa values(@Nombre,@CiudadID, @Telefono, @Direccion, @Email, @CantidadEmpleados, @EstadoSistema)
End
	--Procedimiento EliminarSucursal
	create Procedure [dbo].[spEliminarSucursal] @SucursalID int
as
begin
	delete from SucursalEmpresa where SucursalEmpresaID = @SucursalID
end
	--Procedimiento ListarSucursal
	create procedure [dbo].[spListarSucursal]
as
begin
	select * from SucursalEmpresa order by Nombre
end
	--Procedimiento ListarSucursalNombre
	create procedure [dbo].[spListarSucursalNombre] @Nombre varchar(50)
as
begin
	select * from SucursalEmpresa where Nombre=@Nombre
end

	--Procedimiento ActualizarReservas
	create procedure [dbo].[spActualizarReserva] @ReservaId int, @ClienteID int, @AlojamientoID int,
	@PrecioReserva money, @FechaReserva datetime, @Pagado bit
as
Begin
	update Reserva
	set ClienteID = @ClienteID,
	AlojamientoID = @AlojamientoID,
	PrecioReserva = @PrecioReserva,
	FechaReserva = @FechaReserva,
	Pagado = @Pagado
	where ReservaID = @ReservaId
End
	--Procedimiento InsertarReservas
	Create Procedure [dbo].[spInsertarReserva] @ClienteID int, @AlojamientoID int,
	@PrecioReserva money, @FechaReserva datetime, @Pagado bit
As
Begin
-- Cuerpo
	Insert Reserva values(@ClienteID,@AlojamientoID, @PrecioReserva, @FechaReserva, @Pagado)
End
	--Procedimiento EliminarReservas
	create Procedure [dbo].[spEliminarReservas] @ReservaID int
as
begin
	delete from Reserva where ReservaID = @ReservaID
end
	--Procedimiento ListarReservas
	create procedure [dbo].[spListarReservas]
as
begin
	select * from Reserva order by FechaReserva
end
	--Procedimiento ListarReservas por Id
	create procedure [dbo].[spListarReservasID] @ReservaID int
as
begin
	select * from Reserva where ReservaID=@ReservaID
end

create procedure spListarClientePorID (@id int)
as
begin
	select * from Cliente where ClienteID=@id
end
go

create procedure [dbo].[spListarSucursalID] @id int
as
begin
	select * from SucursalEmpresa where SucursalEmpresaID = @id
end

create procedure [dbo].[spListarEmpleadoPorID] @id int
as
begin
	select * from Empleado where EmpleadoID=@id
end
