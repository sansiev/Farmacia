create database Proyecto_Farmaci
use Proyecto_Farmaci

create table Empleado(
ID_Empleado int identity(1,1) primary key,
Nombre varchar(50),
Apellido varchar(50),
telefono int,
cargo varchar (50),
Estado varchar(50),
contraseña varchar(50)
)

create table cliente(
ID_Cliente int identity(1,1) primary key,
Nombre varchar(50),
Apellido varchar(50),
Direccion varchar(100),
telefono int
)

create table Producto(
ID_Prod varchar(50) primary key,
 Nombre varchar(50),
 Descripcion Varchar(50),
 Existencia int,
 Precio money,
 FechaVenci date
)

create table Ventas(
ID_Ventas int identity(1,1) primary key,
ID_Produc varchar(50),
CantidadComprada int,
Fecha_Venta datetime 
)

create table Factura(
ID_Factura int identity(1,1) primary key, 
ID_Cliente int, --nombre
ID_Empleado int,
Fecha datetime,
ID_Ventas int,
numfact int
)

alter table Ventas
Add constraint FK_VentasProduc
foreign key(ID_Produc) references Producto(ID_Prod)
on update cascade
on delete cascade

alter table Factura
add Constraint FK_Facturacliente
foreign key(ID_Cliente) references cliente(ID_Cliente)
on update cascade
on delete cascade

alter table Factura
add Constraint FK_FacturaEmpleado
foreign key(ID_Empleado) references Empleado(ID_Empleado)
on update cascade
on delete cascade

alter table Factura
add Constraint FK_FacturaVentas
foreign key(ID_Ventas) references Ventas(ID_Ventas)
on update cascade
on delete cascade

--Registro Empleado
insert into Empleado values ('Valeria','Solis',89409131,'Gerente','Activo','lolita')
insert into Empleado values ('Jose','Lopez',88015023,'Trabajador','Activo','lolita')
insert into Empleado values ('Benito','Perez',83425918,'Trabajador','Activo','lolita')

--Registro Cliente
insert into cliente values ('Juan','Perez','San Judas',87911890)
insert into cliente values ('Manuel','Medrano','Santa Ana',89678090)
insert into cliente values ('Rosa','Pacheco','Dimitrov',76219087)

--Registro Producto
Insert into Producto values ('1001A','Acetaminofen','500mg',20,50,'04/10/2025')
Insert into Producto values ('1221B','Ibuprofeno','200mg',30,80,'07/10/2024')
Insert into Producto values ('4212N','Amoxicilina','400mg',10,20,'09/10/2024')

--Registro Factura
insert into Factura Values (1,1,'09/12/2022',1,1)
insert into Factura Values ('002BD',112,1002,'15/09/2022','02B')
insert into Factura Values ('003MN',113,1003,'10/09/2022','03C')

select * from Producto
select * from Ventas
select * from Empleado
select * from cliente
select * from Factura

Drop table Ventas 
Drop table Producto	
Drop table cliente
Drop table Empleado
Drop table Factura 

go

create proc sp_Ventas
@id_venta int,
@id_prod varchar(50),
@cantidadc int,
@fechav datetime
as
begin
insert into Ventas values(@id_prod,@cantidadc,@fechav)
update Producto set  Existencia=Existencia-@cantidadc where ID_Prod= @id_prod
end
go

exec sp_Ventas'','1221B',20,'13/08/2010'
go

with c as
(
select ID_Empleado,Nombre,Apellido,telefono,cargo,Estado,
row_number() OVER (partition by 
                  Nombre,Apellido,telefono,cargo 
				  order by ID_Empleado)  AS Duplicado 
from DBO.Empleado
)
select * from c
where Duplicado > 1


with c as
(
select ID_Empleado,Nombre,Apellido,telefono,cargo,Estado,
row_number() OVER (partition by 
                  Nombre,Apellido,telefono,cargo 
				  order by ID_Empleado)  AS Duplicado 
from DBO.Empleado
)
delete from c
where Duplicado > 1
go

delete from Empleado where ID_Empleado=16

select(select distinct top 1 numfact from Factura order by numfact desc)+1 as Numfactura