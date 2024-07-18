create database peliculas;

use peliculas;

create table pelicula(
id int primary key identity(1,1),
titulo varchar(50),
fecha_estreno date,
director varchar(50),
recaudacion money);

insert into pelicula values('terminator', '2024-02-02', 'hubert', 123445);

select * from pelicula;

select * from pelicula where titulo like '%tone%';
