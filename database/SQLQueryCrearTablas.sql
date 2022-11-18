USE Ferreteria_Industrial
GO

/*INSERT INTO t_Usuarios VALUES('admin', 'admin')
GO

INSERT INTO t_Proveedores VALUES ('Luca', 3745324233,'prlu@gmail.com','Buchardo 4535', 'S')
INSERT INTO t_Proveedores VALUES ('Masa', 3745324233,'masa@gmail.com','PPR 333', 'S')
INSERT INTO t_Proveedores VALUES ('Fuerza SA', 3745324233,'safuerza@gmail.com','Independencia 1000', 'S')
GO

INSERT INTO t_Herramientas (Marca_Herramienta, Modelo_Herramienta, Vida_Util, Cod_Proveedor, Activo) VALUES ('CAT', 'CE', 3, 1, 'S')
INSERT INTO t_Herramientas (Marca_Herramienta, Modelo_Herramienta, Vida_Util, Cod_Proveedor, Activo) VALUES ('Gato', 'B', 10, 3, 'S')
INSERT INTO t_Herramientas (Marca_Herramienta, Modelo_Herramienta, Vida_Util, Cod_Proveedor, Activo) VALUES ('CAT', 'D', 16, 2, 'S')
INSERT INTO t_Herramientas (Marca_Herramienta, Modelo_Herramienta, Vida_Util, Cod_Proveedor, Activo) VALUES ('CAT', '25', 5, 2, 'S')
GO*/

/*INSERT INTO t_Mantenimientos (Fecha, Nombre_Empleado) VALUES (CAST(0x80420B00 AS Date), 'Juan')
INSERT INTO t_Mantenimientos (Fecha, Nombre_Empleado) VALUES (CAST(0x80420B00 AS Date), 'Pablo')
INSERT INTO t_Mantenimientos (Fecha, Nombre_Empleado) VALUES (CAST(0x91420B00 AS Date), 'Pedro')
INSERT INTO t_Mantenimientos (Fecha, Nombre_Empleado) VALUES (CAST(0x64440B00 AS Date), 'Juan')
GO*/

/*INSERT INTO t_Detalles_Mantenimiento (Numero_Mantenimiento, Numero_Detalle, Codigo_Herramienta, Cambios) VALUES (2, 1, 1, 'reparacion')
INSERT INTO t_Detalles_Mantenimiento (Numero_Mantenimiento, Numero_Detalle, Codigo_Herramienta, Cambios) VALUES (3, 2, 2, 'reparacion')
INSERT INTO t_Detalles_Mantenimiento (Numero_Mantenimiento, Numero_Detalle, Codigo_Herramienta, Cambios) VALUES (4, 2, 3, 'reparacion')
INSERT INTO t_Detalles_Mantenimiento (Numero_Mantenimiento, Numero_Detalle, Codigo_Herramienta, Cambios) VALUES (5, 3, 4, 'reparacion')
GO*/

INSERT INTO t_Alquileres (Fecha_Entrega, Fecha_Devolucion, Direccion) VALUES (CAST(0x80420B00 AS Date), CAST(0x80420B00 AS Date), 'pUE 345')
INSERT INTO t_Alquileres (Fecha_Entrega, Fecha_Devolucion, Direccion) VALUES (CAST(0x80420B00 AS Date), CAST(0x80420B00 AS Date), 'rE 345')

INSERT INTO t_Detalles_Alquiler(Numero_Alquiler, Numero_Detalle, Codigo_Herramienta) VALUES (1, 1, 1)
INSERT INTO t_Detalles_Alquiler(Numero_Alquiler, Numero_Detalle, Codigo_Herramienta) VALUES (2, 2, 2)



