use dbPortafolioDocentes;
/* ************ tabla docente * ************/
create table tDocente(
idDocente varchar(8) not null,
Nombre varchar(30) not null,
ApellidoPat varchar(50) not null,
ApellidoMat varchar(50) not null,
DNI varchar(8) not null,
Telefono varchar(12) ,
Direccion varchar(50),
primary key (idDocente));

/* ***************tabla portafolio * *******************/
create table tPortafolio(
idPortafolio varchar(8) not null,
FilosofiaDocente char(100) ,
Curriculum char(100) ,
MisionVision char(100) ,
ObjetivosEducacionales char(100) ,
PerfilDeIngresanteEP char(100) ,
PerfilEgresadoEP char(100) ,
PlanDeEstudiosEP char(100) ,
MallaCurricularEP char(100) ,
RelacionEstudiantesMAtriculados char(100) ,
RegistroAsistencia char(100) ,
AvanceDeSesionesPorClase char(100) ,
RegistroEntregaSilabo char(500) ,
SilaboUnsaac char(100) ,
SilaboIcacid char(100) ,
PresentacionPowerPoint char(100) ,
FichaLectura char(100) ,
EjerciciosPracticos char(100) ,
ActividadesInvestigacion char(100) ,
GuiasLaboratorio char(100) ,
TrabajoCampo char(100) ,
Visitas char(100) ,
ActividadesProyeccionSocial char(100) ,
TextosEspecialidad char(100) ,
Evauaciones char(100) ,
ProyectosIndividualesGrupales char(100) ,
Anexos char(100) ,
primary key (idPortafolio));

/*********************************/
create table tDetallePortafolio(
idDocente varchar(8) not null,
idPortafolio varchar(8) not null,
primary key(idDocente,idPortafolio),
foreign key(idDocente) references tDocente(idDocente),
foreign key(idPortafolio) references tPortafolio(idPortafolio));



/* *************  tabla usuario * *******************/
create table tUsuario(
idUsuario varchar(8) not null,
idPerfil varchar(8) not null,
Nombre varchar(30) not null,
ApellidoPat varchar(50)not null, 
ApellidoMat varchar(50) not null,
DNI varchar(8),
Telefono varchar(12) ,
Direccion varchar(50),
Nick varchar(30) not null,
Contraseña varchar(20) not null,
primary key (idUsuario),
foreign key(idPerfil) references tPerfil(idPerfil)
);

/***********************************************/
create table tPerfil(
idPerfil varchar(8) not null,
idPrivilegios varchar(8) not null,
Rol varchar(40) not null,
primary key(idPerfil),
foreign key(idPrivilegios) references tPrivilegios(idPrivilegios));

/*************************************************/
create table tPrivilegios(
idPrivilegios varchar(8) not null,
Administrador varchar(20) not null,
UsuarioPrincipal varchar(20) not null,
UsuarioComun varchar(20) not null,
primary key(idPrivilegios));





/***************insertar datos*************/




/*================// Stored Procedures \\===================*/
/*procedimiento almacenado para insertar docente*/
create procedure spInsertar_Docente
@iddocente varchar(8),
@nombre varchar(30),
@apellidopat varchar(50),
@apellidomat varchar(50),
@dni varchar(8),
@telefono varchar(12),
@direccion varchar(50),
@mjs varchar(50)out
as begin
if(exists(select * from tDocente where idDocente=@iddocente))
set @mjs='Codigo ya Existe'
else
begin
               insert into tDocente values(@iddocente,@nombres,@apellidopat,@apellidomat,@dni,@telefono,@direccion)
               set  @mjs='Docente Registrado' 
end
end
go
/*===================================*/
/*procedimiento almacenado para actualizar docente*/
create procedure spActualizar_Docente
@iddocente varchar(8),
@nombre varchar(30),
@apellidopat varchar(50),
@apellidomat varchar(50),
@dni varchar(8),
@telefono varchar(12),
@direccion varchar(50),
@mjs varchar(50)out
as begin
if(not exists(select * from tDocente where idDocente=@iddocente))
set @mjs='Codigo no Existe'
else
begin
                update tDocente set idDocente=@iddocente,Nombre=@nombre,ApellidoPat=@apellidopat,ApellidoMat=@apellidomat,DNI=@dni,Telefono=@telefono,Direccion=@direccion where idDocente=@iddocente
               set  @mjs='Docente Modificado' 
end
end
go

/*===================================*/

/*procedimiento almacenado para eliminar docente*/
create procedure spEliminar_Docente
@iddocente varchar(8),
@mjs varchar(50)out
as begin
if(not exists(select * from TDocente where idDocente=@iddocente))
set @mjs='Codigo no Existe'
else
begin
          delete from TDocente where idDocente=@iddocente 
          set @mjs='Docente Eliminado' 
end
end
go
/*===================================*/
/*procedimiento almacenado para buscar docente*/
create procedure spBuscar_Docente
@idDocente varchar(8),
@mjs varchar(50)out
as begin
if(not exists(select * from tDocente where idDocente=@iddocente ))
set @mjs='Codigo no Existe'
else
begin
           select * from tDocente where idDocente=@iddocente  
          set @mjs='Docente Encontrado' 
end
end
go
/*===================================*/