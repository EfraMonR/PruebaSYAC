CREATE DATABASE PruebaIngreso
GO

USE PruebaIngreso

/****CREACION TABLAS****/

CREATE TABLE Cliente (
	idcliente INT IDENTITY(1,1) PRIMARY KEY,
	nombre NVARCHAR(100) NOT NULL,
	identificacion NVARCHAR(100) NOT NULL,
	direccion NVARCHAR(100) NOT NULL
);

CREATE TABLE Producto (
	idproducto INT IDENTITY(1,1) PRIMARY KEY,
	nombre NVARCHAR(100) NOT NULL,
	codigo NVARCHAR(100) NOT NULL,
	valorunitario DECIMAL(20,2) NOT NULL
);

CREATE TABLE ProductoPedido (
	idproductopedido INT IDENTITY(1,1) PRIMARY KEY,
	idproducto INT NOT NULL,
	idpedido INT NOT NULL,
	valorunitario DECIMAL(20,2) NOT NULL,
	cantidad INT NOT NULL
);

CREATE TABLE OrdenPedido (
	idpedido INT IDENTITY(1,1) PRIMARY KEY,
	idcliente INT NOT NULL,
	fecharegistro DATETIME,
	estado INT NOT NULL,
	direccionentrega NVARCHAR(100) NOT NULL,
	prioridad INT NOT NULL,
	valortotal DECIMAL(20,2)
);

/****CREACION RELACIONES****/

ALTER TABLE OrdenPedido
ADD FOREIGN KEY (idcliente) REFERENCES Cliente(idcliente)

ALTER TABLE ProductoPedido
ADD FOREIGN KEY (idproducto) REFERENCES Producto(idproducto)

ALTER TABLE ProductoPedido
ADD FOREIGN KEY (idpedido) REFERENCES OrdenPedido(idpedido)

/****INSERTAR CLIENTES****/

INSERT INTO Cliente (nombre, identificacion, direccion)
VALUES ('Homero Sanchez', '123456789', 'Calle Falsa123')

INSERT INTO Cliente (nombre, identificacion, direccion)
VALUES ('Marge Bubbie', '987654321', 'Av Siempre Viva 742')

INSERT INTO Cliente (nombre, identificacion, direccion)
VALUES ('Bartolomeo Simpson', '852369741', 'Planta Nuclear')

INSERT INTO Cliente (nombre, identificacion, direccion)
VALUES ('Lisa Simpson', '789456123', 'Escuela Primaria')

INSERT INTO Cliente (nombre, identificacion, direccion)
VALUES ('Maggie Simpson', '456789123', 'Cuarto de Bebes 123456')

/****INSERTAR PRODUCTOS****/

INSERT INTO Producto (nombre, codigo, valorunitario)
VALUES ('CocaCola', 'AB01', 100 )

INSERT INTO Producto (nombre, codigo, valorunitario)
VALUES ('PonyMalta', 'CD05', 75 )

INSERT INTO Producto (nombre, codigo, valorunitario)
VALUES ('Pepsi', 'Z052', 90 )

INSERT INTO Producto (nombre, codigo, valorunitario)
VALUES ('JugoHit', 'TA02', 60 )

INSERT INTO Producto (nombre, codigo, valorunitario)
VALUES ('AguaBrisa', 'AG09', 50 )

INSERT INTO Producto (nombre, codigo, valorunitario)
VALUES ('BigCola', 'FK03', 40 )
