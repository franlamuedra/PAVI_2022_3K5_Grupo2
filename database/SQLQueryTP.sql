CREATE DATABASE [Ferreteria_Industrial]
GO

USE [Ferreteria_Industrial]
GO
/****** Object:  Table [dbo].[Alquileres]    Script Date: 24/9/2022 17:41:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alquileres](
	[Marca_Herramienta] [nvarchar](50) NOT NULL,
	[Modelo_Herramienta] [nvarchar](80) NOT NULL,
	[Fecha_Hora_Entrega] [datetime] NOT NULL,
	[Direccion] [nvarchar](200) NOT NULL,
	[Patente_Camion] [nvarchar](10) NOT NULL,
	[Periodo_Alquilado] [int] NULL,
	[Obra] [nvarchar](50) NULL,
	[Responsable_Devolucion] [nvarchar](20) NULL,
 CONSTRAINT [PK_Alquileres] PRIMARY KEY CLUSTERED 
(
	[Marca_Herramienta] ASC,
	[Modelo_Herramienta] ASC,
	[Fecha_Hora_Entrega] ASC,
	[Direccion] ASC,
	[Patente_Camion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Camion]    Script Date: 24/9/2022 17:41:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Camion](
	[Patente] [nvarchar](50) NOT NULL,
	[Marca_Camion] [nvarchar](20) NULL,
	[Año_Modelo] [int] NULL,
	[Capacidad] [int] NULL,
 CONSTRAINT [PK_Camion] PRIMARY KEY CLUSTERED 
(
	[Patente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Composiciones]    Script Date: 24/9/2022 17:41:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Composiciones](
	[Cod_Material] [nvarchar](20) NOT NULL,
	[Cod_Material_Componente] [nvarchar](20) NOT NULL,
	[Porcentaje] [int] NULL,
 CONSTRAINT [PK_Composiciones] PRIMARY KEY CLUSTERED 
(
	[Cod_Material] ASC,
	[Cod_Material_Componente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Entregas]    Script Date: 24/9/2022 17:41:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Entregas](
	[Fecha_Hora_Entrega] [datetime] NOT NULL,
	[Direccion] [nvarchar](200) NOT NULL,
	[Patente] [nvarchar](50) NOT NULL,
	[Cod_Material] [nchar](10) NOT NULL,
	[Cantidad] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Detalle_Entregas] PRIMARY KEY CLUSTERED 
(
	[Fecha_Hora_Entrega] ASC,
	[Direccion] ASC,
	[Patente] ASC,
	[Cod_Material] ASC,
	[Cantidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 24/9/2022 17:41:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[Cod_Empleado] [nchar](10) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Telefono] [nchar](10) NULL,
	[Documento] [nchar](10) NULL,
	[Direccion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[Cod_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entregas]    Script Date: 24/9/2022 17:41:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entregas](
	[Fecha_Hora_Entrega] [datetime] NOT NULL,
	[Direccion] [nvarchar](200) NOT NULL,
	[Patente] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Entregas] PRIMARY KEY CLUSTERED 
(
	[Fecha_Hora_Entrega] ASC,
	[Direccion] ASC,
	[Patente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Herramientas]    Script Date: 24/9/2022 17:41:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Herramientas](
	[Marca_Herramienta] [nvarchar](50) NOT NULL,
	[Modelo_Herramienta] [nvarchar](80) NOT NULL,
	[Cod_Tipo_Herramienta] [nvarchar](50) NULL,
	[Cod_Proveedor] [nvarchar](50) NULL,
	[Vida_Util] [int] NULL,
 CONSTRAINT [PK_Herramientas] PRIMARY KEY CLUSTERED 
(
	[Marca_Herramienta] ASC,
	[Modelo_Herramienta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mantenimientos]    Script Date: 24/9/2022 17:41:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mantenimientos](
	[Marca_Herram] [nvarchar](50) NOT NULL,
	[Modelo_Herramienta] [nvarchar](80) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Cod_Empleado] [nchar](10) NULL,
	[Cambio] [bit] NULL,
 CONSTRAINT [PK_Mantenimientos] PRIMARY KEY CLUSTERED 
(
	[Marca_Herram] ASC,
	[Modelo_Herramienta] ASC,
	[Fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materiales]    Script Date: 24/9/2022 17:41:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materiales](
	[Codigo_Material] [nvarchar](20) NOT NULL,
	[Cantidad] [int] NULL,
	[Unidad_Medida] [nvarchar](50) NULL,
	[Cod_Proveedor] [nvarchar](50) NULL,
	[Fecha_Ingreso] [datetime] NULL,
 CONSTRAINT [PK_Materiales] PRIMARY KEY CLUSTERED 
(
	[Codigo_Material] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 24/9/2022 17:41:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[Cod_Proveedor] [nvarchar](50) NOT NULL,
	[Nombre] [nvarchar](40) NULL,
	[Telefono] [int] NULL,
	[Mail] [nvarchar](80) NULL,
	[Direccion] [nvarchar](200) NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[Cod_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Repuestos]    Script Date: 24/9/2022 17:41:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Repuestos](
	[Modelo_Respuesto] [nvarchar](50) NOT NULL,
	[Marca_Repuesto] [nvarchar](50) NOT NULL,
	[Tipo_Repuesto] [nvarchar](50) NULL,
	[Cantidad] [nchar](10) NULL,
 CONSTRAINT [PK_Repuestos] PRIMARY KEY CLUSTERED 
(
	[Modelo_Respuesto] ASC,
	[Marca_Repuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Repuestos_x_Mantenimiento]    Script Date: 24/9/2022 17:41:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Repuestos_x_Mantenimiento](
	[Marca_Herram] [nvarchar](50) NOT NULL,
	[Modelo_Herram] [nvarchar](80) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Modelo_Repuesto] [nvarchar](50) NOT NULL,
	[Marca_Repuesto] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Repuestos_x_Mantenimiento] PRIMARY KEY CLUSTERED 
(
	[Marca_Herram] ASC,
	[Modelo_Herram] ASC,
	[Fecha] ASC,
	[Modelo_Repuesto] ASC,
	[Marca_Repuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Repuestos_x_Proveedores]    Script Date: 24/9/2022 17:41:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Repuestos_x_Proveedores](
	[Modelo_Repuesto] [nvarchar](50) NOT NULL,
	[Marca_Repuesto] [nvarchar](50) NOT NULL,
	[Cod_Proveedor] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Repuestos_x_Proveedores] PRIMARY KEY CLUSTERED 
(
	[Modelo_Repuesto] ASC,
	[Marca_Repuesto] ASC,
	[Cod_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Responsables_Devolucion]    Script Date: 24/9/2022 17:41:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Responsables_Devolucion](
	[Tipo_Doc] [nvarchar](10) NOT NULL,
	[Nro_Doc] [nvarchar](20) NOT NULL,
	[Direccion] [nvarchar](200) NULL,
	[Jefe] [nvarchar](50) NULL,
 CONSTRAINT [PK_Responsables_Devolucion] PRIMARY KEY CLUSTERED 
(
	[Tipo_Doc] ASC,
	[Nro_Doc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Telefonos]    Script Date: 24/9/2022 17:41:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telefonos](
	[Tipo_Doc] [nvarchar](10) NOT NULL,
	[Nro_doc] [nvarchar](20) NOT NULL,
	[Telefono] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Telefonos] PRIMARY KEY CLUSTERED 
(
	[Tipo_Doc] ASC,
	[Nro_doc] ASC,
	[Telefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipos_Herramientas]    Script Date: 24/9/2022 17:41:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipos_Herramientas](
	[Cod_Tipo_Herramientas] [nvarchar](20) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Descripcion] [nvarchar](80) NULL,
 CONSTRAINT [PK_Tipos_Herramientas] PRIMARY KEY CLUSTERED 
(
	[Cod_Tipo_Herramientas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Alquileres]  WITH CHECK ADD  CONSTRAINT [FK_Alquileres_Herramientas] FOREIGN KEY([Marca_Herramienta], [Modelo_Herramienta])
REFERENCES [dbo].[Herramientas] ([Marca_Herramienta], [Modelo_Herramienta])
GO
ALTER TABLE [dbo].[Alquileres] CHECK CONSTRAINT [FK_Alquileres_Herramientas]
GO
ALTER TABLE [dbo].[Composiciones]  WITH CHECK ADD  CONSTRAINT [FK_Composiciones_Materiales] FOREIGN KEY([Cod_Material_Componente])
REFERENCES [dbo].[Materiales] ([Codigo_Material])
GO
ALTER TABLE [dbo].[Composiciones] CHECK CONSTRAINT [FK_Composiciones_Materiales]
GO
ALTER TABLE [dbo].[Detalle_Entregas]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Entregas_Entregas] FOREIGN KEY([Fecha_Hora_Entrega], [Direccion], [Patente])
REFERENCES [dbo].[Entregas] ([Fecha_Hora_Entrega], [Direccion], [Patente])
GO
ALTER TABLE [dbo].[Detalle_Entregas] CHECK CONSTRAINT [FK_Detalle_Entregas_Entregas]
GO
ALTER TABLE [dbo].[Entregas]  WITH CHECK ADD  CONSTRAINT [FK_Entregas_Camion] FOREIGN KEY([Patente])
REFERENCES [dbo].[Camion] ([Patente])
GO
ALTER TABLE [dbo].[Entregas] CHECK CONSTRAINT [FK_Entregas_Camion]
GO
ALTER TABLE [dbo].[Herramientas]  WITH CHECK ADD  CONSTRAINT [FK_Herramientas_Proveedores] FOREIGN KEY([Cod_Proveedor])
REFERENCES [dbo].[Proveedores] ([Cod_Proveedor])
GO
ALTER TABLE [dbo].[Herramientas] CHECK CONSTRAINT [FK_Herramientas_Proveedores]
GO
ALTER TABLE [dbo].[Mantenimientos]  WITH CHECK ADD  CONSTRAINT [FK_Mantenimientos_Empleados] FOREIGN KEY([Cod_Empleado])
REFERENCES [dbo].[Empleados] ([Cod_Empleado])
GO
ALTER TABLE [dbo].[Mantenimientos] CHECK CONSTRAINT [FK_Mantenimientos_Empleados]
GO
ALTER TABLE [dbo].[Mantenimientos]  WITH CHECK ADD  CONSTRAINT [FK_Mantenimientos_Herramientas] FOREIGN KEY([Marca_Herram], [Modelo_Herramienta])
REFERENCES [dbo].[Herramientas] ([Marca_Herramienta], [Modelo_Herramienta])
GO
ALTER TABLE [dbo].[Mantenimientos] CHECK CONSTRAINT [FK_Mantenimientos_Herramientas]
GO
ALTER TABLE [dbo].[Materiales]  WITH CHECK ADD  CONSTRAINT [FK_Materiales_Proveedores] FOREIGN KEY([Cod_Proveedor])
REFERENCES [dbo].[Proveedores] ([Cod_Proveedor])
GO
ALTER TABLE [dbo].[Materiales] CHECK CONSTRAINT [FK_Materiales_Proveedores]
GO
ALTER TABLE [dbo].[Repuestos_x_Mantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_Repuestos_x_Mantenimiento_Repuestos] FOREIGN KEY([Modelo_Repuesto], [Marca_Repuesto])
REFERENCES [dbo].[Repuestos] ([Modelo_Respuesto], [Marca_Repuesto])
GO
ALTER TABLE [dbo].[Repuestos_x_Mantenimiento] CHECK CONSTRAINT [FK_Repuestos_x_Mantenimiento_Repuestos]
GO
ALTER TABLE [dbo].[Repuestos_x_Mantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_Repuestos_x_Mantenimiento_Repuestos_x_Mantenimiento] FOREIGN KEY([Marca_Herram], [Modelo_Herram], [Fecha], [Modelo_Repuesto], [Marca_Repuesto])
REFERENCES [dbo].[Repuestos_x_Mantenimiento] ([Marca_Herram], [Modelo_Herram], [Fecha], [Modelo_Repuesto], [Marca_Repuesto])
GO
ALTER TABLE [dbo].[Repuestos_x_Mantenimiento] CHECK CONSTRAINT [FK_Repuestos_x_Mantenimiento_Repuestos_x_Mantenimiento]
GO
ALTER TABLE [dbo].[Repuestos_x_Proveedores]  WITH CHECK ADD  CONSTRAINT [FK_Repuestos_x_Proveedores_Proveedores] FOREIGN KEY([Cod_Proveedor])
REFERENCES [dbo].[Proveedores] ([Cod_Proveedor])
GO
ALTER TABLE [dbo].[Repuestos_x_Proveedores] CHECK CONSTRAINT [FK_Repuestos_x_Proveedores_Proveedores]
GO
ALTER TABLE [dbo].[Repuestos_x_Proveedores]  WITH CHECK ADD  CONSTRAINT [FK_Repuestos_x_Proveedores_Repuestos] FOREIGN KEY([Modelo_Repuesto], [Marca_Repuesto])
REFERENCES [dbo].[Repuestos] ([Modelo_Respuesto], [Marca_Repuesto])
GO
ALTER TABLE [dbo].[Repuestos_x_Proveedores] CHECK CONSTRAINT [FK_Repuestos_x_Proveedores_Repuestos]
GO
ALTER TABLE [dbo].[Telefonos]  WITH CHECK ADD  CONSTRAINT [FK_Telefonos_Responsables_Devolucion] FOREIGN KEY([Tipo_Doc], [Nro_doc])
REFERENCES [dbo].[Responsables_Devolucion] ([Tipo_Doc], [Nro_Doc])
GO
ALTER TABLE [dbo].[Telefonos] CHECK CONSTRAINT [FK_Telefonos_Responsables_Devolucion]
GO
