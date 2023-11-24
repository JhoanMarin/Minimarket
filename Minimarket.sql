-- Active: 1693573825264@@127.0.0.1@3306@minimarket
Create database Minimarket;
Use database Minimarket;
Create table minimarket(

idminimarket INT AUTO_INCREMENT,
nit VARCHAR (15) NOT NULL,
razon_social varchar(50) not null,
telefono varchar (10) not null,
nomenclatura varchar (50) not null,
ciudad varchar (30) not null,
departamento varchar (50) not null,
correo_Electronico varchar (50) not null,
sitio_Web varchar (50) not null,
facebook varchar (50) not null,
whatsapp varchar (50) not null,

constraint pk_minimarket primary key (idminimarket),
constraint unico_nit UNIQUE (nit),
constraint unico_razonsocial UNIQUE (razon_social));


create table proveedor (

idproveedor int  AUTO_INCREMENT,
nit varchar (15) not null,
razon_social varchar(50) not null,
telefono varchar (10) not null,
correo_Electronico varchar (50) not null,
nomenclatura varchar (50) not null,
ciudad varchar (30) not null,
departamento varchar (50) not null,

constraint pk_proveedor primary key (idproveedor),
constraint unico_nit_proveedor UNIQUE (nit),
constraint unico_razonsocial_proveedor UNIQUE (razon_social));


create table categoria (
idcategoria int  AUTO_INCREMENT,
nombre varchar (50) not null,
descripcion varchar (200) null,

constraint pk_categoria primary key (idcategoria),
constraint unico_nombre UNIQUE (nombre));

create table cliente (

idcliente int AUTO_INCREMENT,
tipodoc ENUM('Cedula','Pasaporte','PPT','PEP','CE','Otro'), 

identificacion  varchar (50) not null,
nombre varchar (30) not null,
apellido varchar (30) not null,
correo_Electronico varchar (50) not null,
celular varchar (11) not null,

constraint pk_cliente primary key (idcliente),
constraint unico_identificacion_cliente UNIQUE (identificacion));




create table producto(

idproducto int AUTO_INCREMENT,
nombre varchar (50) not null,
marca varchar (50) not null,
Stock int not null default 0,
pvp MONEY NOT NULL,

descripcion varchar (200) null,
unidadMedida ENUM('UND','gr'),

idcategoria int not null,

constraint pk_producto primary key (idproducto),
constraint unico_nombre_producto UNIQUE (nombre),
constraint fk_categoria foreign key (idcategoria) References categoria (idcategoria));

ALTER TABLE producto MODIFY COLUMN pvp Decimal(10,2);

Insert into producto (nombre ,marca,Stock,pvp,descripcion,unidadMedida,idcategoria) VALUES (
    'Cerveza Corona', 'Corona', 200, 6000, 'Cerveza Exportada', 'UND',1
);

select * from producto;
    

                


create table empleado(

idempleado int AUTO_INCREMENT,

tipodoc ENUM ('Cedula','Pasaporte','PPT','PEP','CE','Otro'), 
identificacion  varchar (50) not null,

nombres varchar (30) not null,
apellidos varchar (30) not null,
correo_Electronico varchar (50) not null,
celular varchar (11) not null,
clave varchar  (50) not null,
idminimarket int not null,

constraint pk_empleado PRIMARY KEY (idempleado),
constraint unico_identificacion_empleado UNIQUE (identificacion),
constraint unico_correo_Empleado UNIQUE (correo_Electronico),
constraint fk_minimarket foreign key (idminimarket) REFERENCES minimarket(idminimarket));

create table factura(
idfactura int AUTO_INCREMENT,
codigofactura varchar (8) not null,
fechageneracion datetime not null,
IVA int not null,
sinIVA INT NOT NULL,
total int not null,
idempleado int not null,
idcliente int not null,

constraint pk_factura primary key (idfactura),
constraint unico_factura UNIQUE (codigofactura),
constraint fk_empleado FOREIGN KEY (idempleado) references empleado (idempleado),
constraint fk_cliente FOREIGN KEY (idcliente) references cliente (idcliente));


create table detalleFactura(
idDetalleFactura int AUTO_INCREMENT,
cantidadproductos int not null,
precioventa INT  not null,
subtotal INT not null,
idproducto int not null,
idfactura int not null,

constraint pk_detallefactura primary key (idDetalleFactura),
constraint fk_producto_detallefactura foreign key (idproducto) references producto (idproducto),
constraint fk_factura_detallefactura foreign key (idfactura) references factura (idfactura));


CREATE TABLE ordendecompra(
idordendecompra int AUTO_INCREMENT,
codigoordendecompra varchar (8) not null,
IVA NUMERIC(25,2)  NOT NULL,
preciototal NUMERIC(25,2) not null,
fechapedido datetime not null,
fechaentrega datetime not null,
totalsiniva NUMERIC(25,2)   NOT NULL,

idproveedor int not null,
idempleado INT NOT NULL,

CONSTRAINT pk_idordendecompra primary key(idordendecompra ),
CONSTRAINT unico_codigoordendecompra UNIQUE (codigoordendecompra),
CONSTRAINT fk_idproveedor_ordendecompra FOREIGN KEY (idempleado) REFERENCES proveedor (idproveedor),
CONSTRAINT Fk_idempleado_ordendecompra Foreign Key (idempleado) references empleado (idempleado)

);

CREATE TABLE detalleordendecompra(

iddetalleordendecompra int AUTO_INCREMENT,
codigodetalleordendecompra varchar (8) not null,
cantidadproductos int not null,
preciocompra NUMERIC(25,2)  not null,
Subtotal NUMERIC(25,2)  NOT NULL,

idordendecompra int not null,
idproducto int  not null,


CONSTRAINT pk_iddetalleordendecompra PRIMARY KEY (iddetalleordendecompra),
CONSTRAINT unico_codigodetalleordendecompra UNIQUE (codigodetalleordendecompra),
CONSTRAINT fk_idordendecompra_detalleordendecompra FOREIGN KEY (idordendecompra) REFERENCES ordendecompra (idordendecompra),
CONSTRAINT fk_idproducto_detalleordendecompra FOREIGN KEY (idproducto) REFERENCES producto (idproducto)
);
SELECT * from minimarket;
UPDATE minimarket
SET nomenclatura = 'Calle 80E # 26c-60'
WHERE idminimarket=3;

SELECT * from minimarket;
SELECT* from categoria;
SELECT* from proveedor;
DELETE from minimarket where idminimarket= 1;
DELETE from minimarket where idminimarket= 2;
SELECT * from minimarket;
SELECT*from cliente;

UPDATE categoria set nombre= "Carnicos", 
descripcion="Productos provenientes del sacrificio animal"
where idcategoria=1;
Delete From categoria where idcategoria>=4 and idcategoria<=7;