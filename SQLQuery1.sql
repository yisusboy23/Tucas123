CREATE DATABASE Practico1;

CREATE TABLE Computadora (
    IdComputadora Int Identity (1,1) not null,
    Nombre NVARCHAR (50) not null,
    Descripcion NVARCHAR (100) not null,
    Precio money not null,
    FechaFabricacion DATETIME not null,
);
Select* From Computadora
insert into Computadora values('Asus 750','Laptop','3500','2023-02-09 21:40:00');
insert into Computadora values('Asus 780','Pc','3500','2023-02-09 21:40:00');
insert into Computadora values('Asus 790','Pc','3500','2023-02-09 21:40:00');