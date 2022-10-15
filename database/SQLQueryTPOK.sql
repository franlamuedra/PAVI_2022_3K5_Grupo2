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
	Cod_Herramienta int identity (1,1) primary key,
	Cod_Proveedor int NULL,
	Marca_Herramienta nvarchar (50) NOT NULL,
	Modelo_Herramienta nvarchar (80) NOT NULL,	
	Vida_Util int NULL,
	Activo varchar (1) NOT NULL,
	CONSTRAINT fk_t_Herramientas FOREIGN KEY (Cod_Proveedor) REFERENCES t_Proveedores (Cod_Proveedor)
)
GO

CREATE TABLE t_Materiales(
	Nombre nvarchar (100) NOT NULL,
	Codigo_Material int identity (1,1) primary key,
	Cantidad float NULL,
	Unidad_Medida nvarchar (100) NULL,
	Cod_Proveedor int,
	Fecha_Ingreso nvarchar (100) NULL,
	Activo varchar (1) NOT NULL,
	CONSTRAINT fk_t_Materiales FOREIGN KEY (Cod_Proveedor) REFERENCES t_Proveedores (Cod_Proveedor)
)
GO

CREATE TABLE t_Mantenimientos(
	Numero_Mantenimiento int identity (1,1) primary key,
	Codigo_Herramienta int NOT NULL,
	Fecha nvarchar (100) NOT NULL,
	Nombre_Empleado nvarchar (100) NOT NULL,
	Cambio nvarchar (100) NULL,
	CONSTRAINT fk_t_Mantenimientos FOREIGN KEY (Codigo_Herramienta) REFERENCES t_Herramientas (Cod_Herramienta)
)
GO

CREATE PROCEDURE SP_Consultar_Herramientas
AS
BEGIN
	SELECT * from t_Herramientas
END
GO

CREATE PROCEDURE SP_Insertar_Mantenimiento
	@cod int,
	@fec nvarchar(100),
	@nom nvarchar (100),
	@cambio nvarchar (100),
	@num_man int OUTPUT
AS
BEGIN
	INSERT INTO t_Mantenimientos (Codigo_Herramienta, Fecha, Nombre_Empleado, Cambio) 
	VALUES (@cod, @fec, @nom, @cambio);
	SET @num_man = SCOPE_IDENTITY();

END
GO

CREATE PROCEDURE SP_Modificar_Mantenimiento
	@cod int,
	@nom nvarchar (100),
	@cambio nvarchar (100),
	@num_man int OUTPUT
AS
BEGIN
	UPDATE t_Mantenimientos SET Codigo_Herramienta = @cod, Nombre_Empleado = @nom, Cambio = @cambio
	WHERE Numero_Mantenimiento = @num_man;
END
GO
	