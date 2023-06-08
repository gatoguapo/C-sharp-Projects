Create procedure Medico_Listar
as
begin
select Clave as 'CLAVE MEDICO', Nombre as 'NOMBRE MEDICO', Especialidad as 'ESPECIALIDAD',
SubEspecialidad as 'SUBESPECIALIDAD', TELEFONO = Telefono, Consultorio as 'NUMERO DE CONSULTORIO'
from Medico m
inner join Consultorio c on m.Consultorio = c.IDConsultorio
order by Clave asc
end

go
exec Medico_Listar
go

Create procedure CitaMedica_Listar
as
begin
select C.ClaveCita as 'CLAVE DE LA CITA', C.ClaveMedico as 'CLAVE DEL MEDICO', M.Nombre as 'NOMBRE DEL MEDICO' ,C.Fecha as 'FECHA DE LA CITA', 
C.Hora as 'HORA DE LA CITA', C.NombrePaciente as 'NOMBRE DEL PACIENTE', C.TelefonoPaciente as 'TELEFONO DEL PACIENTE',
OBSERVACIONES = Observaciones
from CitaMedica C
inner join Medico M on C.ClaveMedico = M.Clave
order by ClaveCita asc
end
go

exec CitaMedica_Listar
select * from CitaMedica

go
Create Proc Medico_Insertar
@clave numeric(4,0),
@nombre nvarchar(40),
@especialidad nvarchar(20),
@subespecialidad nvarchar(20),
@telefono nvarchar(20),
@consultorio tinyint
as
insert into Medico (Clave, Nombre, Especialidad, SubEspecialidad, Telefono, Consultorio)
values (@clave, @nombre, @especialidad, @subespecialidad, @telefono, @consultorio)

go
create proc Medico_ExisteNombre
@nombre nvarchar(40),
@existe int output
as
if exists (select nombre from Medico where Nombre = LTRIM(rtrim(@nombre)))
	begin
		set @existe = 1
	end
else
	begin
		set @existe = 0
	end

go

go
create proc Medico_ExisteClave
@clave int,
@existe int output
as
if exists (select clave from Medico where Clave = @clave)
	begin
		set @existe = 1
	end
else
	begin
		set @existe = 0
	end
go

create proc CitaMedica_ExisteHora
@claveMedico int,
@fecha Date,
@hora time(7),
@existe int output
AS
BEGIN
	if exists (select Fecha, Hora from CitaMedica where ClaveMedico = @claveMedico AND Fecha = @fecha AND Hora = @hora)
	BEGIN
		set @existe = 1;
		print @existe
	END
	ELSE
	BEGIN
		set @existe = 0;
	END
END
go

Create Proc CitaMedica_Insertar
@claveMedico numeric(4,0),
@fecha date,
@hora time,
@pacienteNombre nvarchar(30),
@telefono nvarchar(10),
@observaciones nvarchar(50)
as
insert into CitaMedica(ClaveMedico, Fecha, Hora, NombrePaciente, TelefonoPaciente, Observaciones)
values (@claveMedico, @fecha, @hora, @pacienteNombre, @telefono, @observaciones)
go

Create procedure Consultorio_Listar
as
begin
select IDConsultorio as 'CLAVE CONSULTORIO', NombreConsultorio as 'NOMBRE CONSULTORIO', Domicilio as 'DOMICILIO'
from Consultorio
order by IDConsultorio asc
end
go

exec Consultorio_Listar
go

create proc Consultorio_ExisteClave
@consultorio int,
@existe int output
as
if exists (select IDConsultorio from Consultorio where IDConsultorio = @consultorio)
	begin
		set @existe = 1
	end
else
	begin
		set @existe = 0
	end
go

create proc Consultorio_ExisteNombre
@nombreConsultorio nvarchar(50),
@existe int output
as
if exists (select NombreConsultorio from Consultorio where NombreConsultorio = @nombreConsultorio)
	begin
		set @existe = 1
	end
else
	begin
		set @existe = 0
	end
go

Create Proc Consultorio_Insertar
@consultorio tinyint,
@nombreConsultorio nvarchar(50),
@domicilio nvarchar(50)
as
insert into Consultorio(IDConsultorio, NombreConsultorio, Domicilio)
values (@consultorio, @nombreConsultorio, @domicilio)
go