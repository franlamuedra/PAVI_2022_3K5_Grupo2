CREATE DATABASE Ferreteria_Industrial
GO

USE Ferreteria_Industrial
GO

CREATE TABLE t_Usuarios(
	Usuario varchar (50) primary key,
	[Password] varchar (10) NOT NULL
)
GO

CREATE TABLE t_Proveedores(
	Cod_Proveedor int identity (1,1) NOT NULL,
	Nombre nvarchar (40) NULL,
	Telefono varchar (20) NULL,
	Mail nvarchar (80) NULL,
	Direccion nvarchar (200) NULL,
	Activo varchar (1) NOT NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[Cod_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE t_Herramientas(
	Cod_Herramienta int identity (1,1),
	Cod_Proveedor int NULL,
	Marca_Herramienta nvarchar (50) NOT NULL,
	Modelo_Herramienta nvarchar (80) NOT NULL,	
	Vida_Util int NULL,
	Activo varchar (1) NOT NULL,
	CONSTRAINT fk_t_Herramientas FOREIGN KEY (Cod_Proveedor) REFERENCES t_Proveedores (Cod_Proveedor),
CONSTRAINT [pk_t_Herramientas__33BEB70E03317E3D] PRIMARY KEY CLUSTERED 
(
	Cod_Herramienta ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE t_Materiales(
	Nombre nvarchar (100) NOT NULL,
	Codigo_Material int identity (1,1) primary key,
	Cantidad float NULL,
	Unidad_Medida nvarchar (100) NULL,
	Cod_Proveedor int,
	Fecha_Ingreso nvarchar (100),
	Activo varchar (1) NOT NULL,
	CONSTRAINT fk_t_Materiales FOREIGN KEY (Cod_Proveedor) REFERENCES t_Proveedores (Cod_Proveedor)
)
GO

CREATE TABLE t_Mantenimientos(
	Numero_Mantenimiento int identity (1,1) primary key,
	Fecha date NOT NULL,
	Nombre_Empleado nvarchar (100) NOT NULL,
)
GO

CREATE TABLE t_Detalles_Mantenimiento(
	Numero_Mantenimiento int NOT NULL,
	Numero_Detalle int NOT NULL,
	Codigo_Herramienta int NOT NULL,
	Cambios nvarchar (300) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	Numero_Mantenimiento ASC,
	Numero_Detalle ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE PROCEDURE SP_Consultar_Herramientas
AS
BEGIN
	SELECT * from t_Herramientas
END
GO

CREATE PROCEDURE SP_Insertar_Mantenimiento
	@nom Nvarchar (100),
	@num_man int OUTPUT
AS
BEGIN
	INSERT INTO t_Mantenimientos (Fecha, Nombre_Empleado) 
	VALUES (GETDATE(), @nom);
	SET @num_man = SCOPE_IDENTITY();
END
GO

CREATE PROCEDURE SP_Modificar_Mantenimiento
	@nom nvarchar (100),
	@num_man int OUTPUT
AS
BEGIN
	UPDATE t_Mantenimientos SET Nombre_Empleado = @nom
	WHERE Numero_Mantenimiento = @num_man;

	DELETE t_Detalles_Mantenimiento WHERE Numero_Mantenimiento = @num_man;
END
GO

CREATE PROCEDURE SP_Insert_Detalle
	@num_man int,
	@detalle int, 
	@cod_herramienta int, 
	@cambios nvarchar (300)
AS
BEGIN
	INSERT INTO t_Detalles_Mantenimiento(Numero_Mantenimiento, Numero_Detalle, Codigo_Herramienta, Cambios)
    VALUES (@num_man, @detalle, @cod_herramienta, @cambios);
END
GO

CREATE PROCEDURE SP_Eliminar_Mantenimiento 
	@num_man int
AS
BEGIN
	DELETE t_Mantenimientos	WHERE Numero_Mantenimiento = @num_man;
END
GO

CREATE PROCEDURE SP_Consultar_Mantenimientos
	@desde Datetime,
	@hasta Datetime,
	@empl nvarchar (100)
AS
BEGIN
	SELECT *
	FROM t_Mantenimientos 
	WHERE (@desde is null OR Fecha >= @desde)
	AND (@hasta is null OR Fecha <= @hasta)
	AND (@empl is null OR Nombre_Empleado LIKE '%' + @empl + '%');
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE SP_Proximo_Numero
@next int OUTPUT
AS
BEGIN
	SET @next = (SELECT MAX(Numero_Mantenimiento)+1 FROM t_Mantenimientos);
END
GO

CREATE PROCEDURE SP_Consultar_Detalles_Mantenimiento
	@num_man int
AS
BEGIN
	SELECT t.*, t2.Cod_Herramienta, t3.Nombre_Empleado, t3.Fecha
	FROM t_Detalles_Mantenimiento t, t_Herramientas t2, t_Mantenimientos t3
	WHERE t.Codigo_Herramienta = t2.Cod_Herramienta
	AND t.Numero_Mantenimiento = t3.Numero_Mantenimiento
	AND t.Numero_Mantenimiento = @num_man;
END
GO
	