USE [Turismo]
GO
/****** Object:  Table [dbo].[Alojamiento]    Script Date: 5/11/2017 23:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alojamiento](
	[AlojamientoID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Direccion] [varchar](100) NOT NULL,
	[Telefono] [varchar](30) NOT NULL,
	[PaginaWeb] [varchar](30) NOT NULL,
	[Estrellas] [int] NOT NULL,
	[EstadoSistema] [bit] NOT NULL,
 CONSTRAINT [PK_Alojamiento] PRIMARY KEY CLUSTERED 
(
	[AlojamientoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CargoEmpleado]    Script Date: 5/11/2017 23:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CargoEmpleado](
	[CargoEmpleadoID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](256) NOT NULL,
 CONSTRAINT [PK_CargoEmpleado] PRIMARY KEY CLUSTERED 
(
	[CargoEmpleadoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ciudad]    Script Date: 5/11/2017 23:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudad](
	[CiudadID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Ciudad] PRIMARY KEY CLUSTERED 
(
	[CiudadID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 5/11/2017 23:29:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[ClienteID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[TipoDocumentoID] [int] NOT NULL,
	[NroDocumento] [varchar](30) NOT NULL,
	[EstadoCivil] [char](1) NOT NULL,
	[Telefono] [varchar](30) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[ProfesionID] [int] NOT NULL,
	[Sexo] [bit] NOT NULL,
	[TipoClienteID] [int] NOT NULL,
	[EstadoSistema] [bit] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[ClienteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_Cliente] UNIQUE NONCLUSTERED 
(
	[TipoDocumentoID] ASC,
	[NroDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[EmpleadoID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[CargoEmpleadoID] [int] NOT NULL,
	[TipoDocumentoID] [int] NOT NULL,
	[NroDocumento] [varchar](30) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[SucursalEmpresaID] [int] NOT NULL,
	[Telefono] [varchar](30) NOT NULL,
	[Direccion] [varchar](100) NOT NULL,
	[EstadoCivil] [char](1) NOT NULL,
	[Antiguedad] [int] NOT NULL,
	[EstadoSistema] [bit] NOT NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[EmpleadoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesion]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesion](
	[ProfesionID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Profesion] PRIMARY KEY CLUSTERED 
(
	[ProfesionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[ReservaID] [int] IDENTITY(1,1) NOT NULL,
	[ClienteID] [int] NOT NULL,
	[AlojamientoID] [int] NOT NULL,
	[PrecioReserva] [money] NOT NULL,
	[FechaReserva] [datetime] NOT NULL,
	[Pagado] [bit] NOT NULL,
 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[ReservaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SucursalEmpresa]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SucursalEmpresa](
	[SucursalEmpresaID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[CiudadID] [int] NOT NULL,
	[Telefono] [varchar](30) NULL,
	[Direccion] [varchar](100) NULL,
	[Email] [varchar](50) NULL,
	[CantidadEmpleados] [int] NOT NULL,
	[EstadoSistema] [bit] NOT NULL,
 CONSTRAINT [PK_SucursalEmpresa] PRIMARY KEY CLUSTERED 
(
	[SucursalEmpresaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoCliente]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoCliente](
	[TipoClienteID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](30) NOT NULL,
 CONSTRAINT [PK_TipoCliente] PRIMARY KEY CLUSTERED 
(
	[TipoClienteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDocumento]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDocumento](
	[TipoDocumentoID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoDocumento] PRIMARY KEY CLUSTERED 
(
	[TipoDocumentoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Alojamiento] ADD  DEFAULT ((1)) FOR [EstadoSistema]
GO
ALTER TABLE [dbo].[cliente] ADD  DEFAULT ((1)) FOR [EstadoSistema]
GO
ALTER TABLE [dbo].[Empleado] ADD  DEFAULT ((1)) FOR [EstadoSistema]
GO
ALTER TABLE [dbo].[SucursalEmpresa] ADD  DEFAULT ((1)) FOR [EstadoSistema]
GO
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Profesion] FOREIGN KEY([ProfesionID])
REFERENCES [dbo].[Profesion] ([ProfesionID])
GO
ALTER TABLE [dbo].[cliente] CHECK CONSTRAINT [FK_Cliente_Profesion]
GO
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_TipoCliente] FOREIGN KEY([TipoClienteID])
REFERENCES [dbo].[TipoCliente] ([TipoClienteID])
GO
ALTER TABLE [dbo].[cliente] CHECK CONSTRAINT [FK_Cliente_TipoCliente]
GO
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_TipoDocumento] FOREIGN KEY([TipoDocumentoID])
REFERENCES [dbo].[TipoDocumento] ([TipoDocumentoID])
GO
ALTER TABLE [dbo].[cliente] CHECK CONSTRAINT [FK_Cliente_TipoDocumento]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_CargoEmpleado] FOREIGN KEY([CargoEmpleadoID])
REFERENCES [dbo].[CargoEmpleado] ([CargoEmpleadoID])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_CargoEmpleado]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_SucursalEmpresa] FOREIGN KEY([SucursalEmpresaID])
REFERENCES [dbo].[SucursalEmpresa] ([SucursalEmpresaID])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_SucursalEmpresa]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_TipoDocumento] FOREIGN KEY([TipoDocumentoID])
REFERENCES [dbo].[TipoDocumento] ([TipoDocumentoID])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_TipoDocumento]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_AlojamientoID] FOREIGN KEY([AlojamientoID])
REFERENCES [dbo].[Alojamiento] ([AlojamientoID])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_AlojamientoID]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Cliente] FOREIGN KEY([ClienteID])
REFERENCES [dbo].[cliente] ([ClienteID])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Cliente]
GO
ALTER TABLE [dbo].[SucursalEmpresa]  WITH CHECK ADD  CONSTRAINT [FK_SucursalEmpresa_Ciudad] FOREIGN KEY([CiudadID])
REFERENCES [dbo].[Ciudad] ([CiudadID])
GO
ALTER TABLE [dbo].[SucursalEmpresa] CHECK CONSTRAINT [FK_SucursalEmpresa_Ciudad]
GO
/****** Object:  StoredProcedure [dbo].[spActualizarAlojamiento]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[spActualizarCliente]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[spActualizarEmpleado]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[spActualizarReserva]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[spActualizarSucursal]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[spEliminarAlojamiento]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[spEliminarAlojamiento] @AlojamientoID int
as
begin
	delete from Alojamiento where AlojamientoID = @AlojamientoID
end
GO
/****** Object:  StoredProcedure [dbo].[spEliminarClientea]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[spEliminarClientea] @ClienteID int
as
begin
	delete from cliente where ClienteID = @ClienteID
end
GO
/****** Object:  StoredProcedure [dbo].[spEliminarEmpleado]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[spEliminarEmpleado] @EmpleadoID int
as
begin
	delete from Empleado where EmpleadoID = @EmpleadoID
end
GO
/****** Object:  StoredProcedure [dbo].[spEliminarReservas]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[spEliminarReservas] @ReservaID int
as
begin
	delete from Reserva where ReservaID = @ReservaID
end
GO
/****** Object:  StoredProcedure [dbo].[spEliminarSucursal]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[spEliminarSucursal] @SucursalID int
as
begin
	delete from SucursalEmpresa where SucursalEmpresaID = @SucursalID
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertarAlojamiento]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[spInsertarAlojamiento] @Nombre varchar(50), @Direccion varchar(50),
	@Telefono varchar(30), @PaginaWeb varchar(30), @Estrellas int, @EstadoSistema bit
As
Begin
-- Cuerpo
	Insert Alojamiento values(@Nombre,@Direccion, @Telefono, @PaginaWeb, @Estrellas, @EstadoSistema)
End
GO
/****** Object:  StoredProcedure [dbo].[spInsertarCliente]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[spInsertarCliente] @Nombre varchar(50), @Apellido varchar(50), @TipoDocumentoID int, @NroDocumento varchar(30), @EstadoCivil char(1), @Telefono varchar(30),
@Direccion varchar(100), @Email varchar(50), @FechaNacimiento date, @ProfesionID int, @Sexo bit, @TipoClienteID int, @EstadoSistema bit
As
Begin
-- Cuerpo
	Insert cliente values(@Nombre,@Apellido, @TipoDocumentoID, @NroDocumento, @EstadoCivil, @Telefono,
	@Direccion, @Email, @FechaNacimiento, @ProfesionID, @Sexo, @TipoClienteID, @EstadoSistema)
End
GO
/****** Object:  StoredProcedure [dbo].[spInsertarEmpleado]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[spInsertarEmpleado] @Nombre varchar(50), @Apellido varchar(50), @CargoEmpleadoID int,
@TipoDocumentoID int, @NroDocumento varchar(50), @FechaNacimiento date, @SucursalEmpresaID int, @Telefono varchar(30),
@Direccion varchar(100), @EstadoCivil char(1), @Antiguedad int, @EstadoSistema bit
As
Begin
-- Cuerpo
	Insert Empleado values(@Nombre,@Apellido, @CargoEmpleadoID, @TipoDocumentoID, @NroDocumento, @FechaNacimiento,
	@SucursalEmpresaID, @Telefono, @Direccion, @EstadoCivil, @Antiguedad, @EstadoSistema)
End
GO
/****** Object:  StoredProcedure [dbo].[spInsertarReserva]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[spInsertarReserva] @ClienteID int, @AlojamientoID int,
	@PrecioReserva money, @FechaReserva datetime, @Pagado bit
As
Begin
-- Cuerpo
	Insert Reserva values(@ClienteID,@AlojamientoID, @PrecioReserva, @FechaReserva, @Pagado)
End
GO
/****** Object:  StoredProcedure [dbo].[spInsertarSucursal]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[spInsertarSucursal] @Nombre varchar(50), @CiudadID int,
	@Telefono varchar(30), @Direccion varchar(100), @Email varchar(50), @CantidadEmpleados int, @EstadoSistema bit
As
Begin
-- Cuerpo
	Insert SucursalEmpresa values(@Nombre,@CiudadID, @Telefono, @Direccion, @Email, @CantidadEmpleados, @EstadoSistema)
End
GO
/****** Object:  StoredProcedure [dbo].[spListarAlojamientoD]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarAlojamientoD]
as
begin
	select * from Alojamiento order by Nombre
end
GO
/****** Object:  StoredProcedure [dbo].[spListarAlojamientoNombre]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarAlojamientoNombre] @Nombre varchar(50)
as
begin
	select * from Alojamiento where Nombre=@Nombre 
end
GO
/****** Object:  StoredProcedure [dbo].[spListarCliente]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarCliente]
as
begin
	select * from cliente order by Nombre
end
GO
/****** Object:  StoredProcedure [dbo].[spListarClienteNombre]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarClienteNombre] @Nombre varchar(50)
as
begin
	select * from cliente where Nombre=@Nombre
end
GO
/****** Object:  StoredProcedure [dbo].[spListarEmpleado]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarEmpleado]
as
begin
	select * from Empleado order by Nombre
end
GO
/****** Object:  StoredProcedure [dbo].[spListarEmpleadoNombre]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarEmpleadoNombre] @Nombre varchar(50)
as
begin
	select * from Empleado where Nombre=@Nombre
end
GO
/****** Object:  StoredProcedure [dbo].[spListarReservas]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarReservas]
as
begin
	select * from Reserva order by FechaReserva
end
GO
/****** Object:  StoredProcedure [dbo].[spListarReservasID]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarReservasID] @ReservaID int
as
begin
	select * from Reserva where ReservaID=@ReservaID
end
GO
/****** Object:  StoredProcedure [dbo].[spListarSucursal]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarSucursal]
as
begin
	select * from SucursalEmpresa order by Nombre
end
GO
/****** Object:  StoredProcedure [dbo].[spListarSucursalNombre]    Script Date: 5/11/2017 23:29:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarSucursalNombre] @Nombre varchar(50)
as
begin
	select * from SucursalEmpresa where Nombre=@Nombre
end
GO
