Database

CREATE DATABASE SGC_UNAPEC;
GO

USE SGC_UNAPEC;
GO

-- Tabla de Tipo de Usuarios
CREATE TABLE tipo_usuarios (
    id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    tipo_usuario VARCHAR(20) NOT NULL,
    descripcion VARCHAR(100) NULL,
    estado TINYINT NOT NULL DEFAULT 1
);
GO

-- Tabla de Marcas
CREATE TABLE marcas (
    id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    marca VARCHAR(30) NOT NULL,
    descripcion VARCHAR(100) NULL,
    estado TINYINT NOT NULL DEFAULT 1,
    fecha_registro DATETIME NOT NULL DEFAULT GETDATE(),
    fecha_modificacion DATETIME NULL
);
GO

-- Tabla de Campus
CREATE TABLE campus (
    id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    campus VARCHAR(30) NOT NULL,
    descripcion VARCHAR(100) NOT NULL,
    estado TINYINT NOT NULL DEFAULT 1,
    fecha_registro DATETIME NOT NULL DEFAULT GETDATE(),
    fecha_modificacion DATETIME NULL
);
GO

-- Tabla de Proveedores
CREATE TABLE proveedores (
    id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    nombre_comercial VARCHAR(70) NOT NULL,
    rnc VARCHAR(20) NOT NULL,
    estado TINYINT NOT NULL DEFAULT 1,
    fecha_registro DATETIME NOT NULL DEFAULT GETDATE(),
    fecha_modificacion DATETIME NULL
);
GO

CREATE UNIQUE INDEX idx_proveedores_rnc ON proveedores(rnc);
GO

-- Tabla de Cafeterías
CREATE TABLE cafeterias (
    id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    cafeteria VARCHAR(70) NOT NULL,
    descripcion VARCHAR(100) NOT NULL,
    campus_id INT NOT NULL,
    encargado VARCHAR(50) NULL,
    estado TINYINT NOT NULL DEFAULT 1,
    fecha_registro DATETIME NOT NULL DEFAULT GETDATE(),
    fecha_modificacion DATETIME NULL,
    CONSTRAINT FK_cafeterias_campus FOREIGN KEY (campus_id) REFERENCES campus(id)
);
GO

-- Tabla de Usuarios
CREATE TABLE usuarios (
    id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    cedula VARCHAR(13) NOT NULL,
    tipo_usuario_id INT NOT NULL,
    limite_credito INT NOT NULL,
    clave VARCHAR(128) NOT NULL,
    estado TINYINT NOT NULL DEFAULT 1,
    fecha_registro DATETIME NOT NULL DEFAULT GETDATE(),
    fecha_modificacion DATETIME NULL,
    CONSTRAINT FK_usuarios_tipo_usuario FOREIGN KEY (tipo_usuario_id) REFERENCES tipo_usuarios(id)
);
GO

-- Tabla de Empleados
CREATE TABLE empleados (
    id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    cedula VARCHAR(13) NOT NULL,
    tanda_labor VARCHAR(10) NOT NULL,
    porciento_comision INT NULL,
    estado TINYINT NOT NULL DEFAULT 1,
    fecha_registro DATETIME NOT NULL DEFAULT GETDATE()
);
GO

-- Tabla de Artículos
CREATE TABLE articulos (
    id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    descripcion VARCHAR(100) NOT NULL,
    marca_id INT NOT NULL,
    costo FLOAT NOT NULL,
    proveedor_id INT NOT NULL,
    existencia INT NOT NULL DEFAULT 0,
    estado TINYINT NOT NULL DEFAULT 1,
    fecha_registro DATETIME NOT NULL DEFAULT GETDATE(),
    fecha_modificacion DATETIME NULL,
    CONSTRAINT FK_articulos_marcas FOREIGN KEY (marca_id) REFERENCES marcas(id),
    CONSTRAINT FK_articulos_proveedores FOREIGN KEY (proveedor_id) REFERENCES proveedores(id)
);
GO

-- Tabla de Facturación de Artículos
CREATE TABLE facturacion_articulos (
    no_factura INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    empleado_id INT NOT NULL,
    articulo_id INT NOT NULL,
    usuario_id INT NOT NULL,
    fecha_venta DATETIME NOT NULL DEFAULT GETDATE(),
    monto_articulo FLOAT NOT NULL DEFAULT 0,
    unidades_vendidas INT NOT NULL,
    comentario VARCHAR(100) NULL,
    estado TINYINT NOT NULL DEFAULT 1,
    CONSTRAINT FK_facturacion_empleado FOREIGN KEY (empleado_id) REFERENCES empleados(id),
    CONSTRAINT FK_facturacion_articulo FOREIGN KEY (articulo_id) REFERENCES articulos(id),
    CONSTRAINT FK_facturacion_usuario FOREIGN KEY (usuario_id) REFERENCES usuarios(id)
);
GO
