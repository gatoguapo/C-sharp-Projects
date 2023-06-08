CREATE DATABASE ClinicaMedica
go
USE ClinicaMedica
GO

create TABLE Medico(
Clave numeric(4,0) not null,
Nombre nvarchar(40) not null,
Especialidad nvarchar(20) not null,
SubEspecialidad nvarchar(20),
Telefono nvarchar(20) not null,
Consultorio tinyint not null)
go
create table CitaMedica(
ClaveCita int not null IDENTITY,
ClaveMedico numeric(4,0) not null,
Fecha date not null,
Hora time(7) not null,
NombrePaciente nvarchar(30) not null,
TelefonoPaciente nvarchar(10) not null,
Observaciones nvarchar(50))
go
create table Consultorio(
IDConsultorio tinyint not null,
NombreConsultorio nvarchar(50) not null,
Domicilio nvarchar(50) not null,
)
go
ALTER TABLE Medico ADD CONSTRAINT PK_MEDICO_CLAVE
PRIMARY KEY (Clave)
go
ALTER TABLE CitaMedica ADD CONSTRAINT PK_CITAMEDICA_CLAVECITA
PRIMARY KEY (ClaveCita)
go
ALTER TABLE Consultorio ADD CONSTRAINT PK_CONSULTORIO_CLAVE
PRIMARY KEY (IDConsultorio)
go
ALTER TABLE CitaMedica ADD CONSTRAINT FK_CITAMEDICA_CLAVEMEDICO
FOREIGN KEY (ClaveMedico) REFERENCES Medico(Clave)
go
ALTER TABLE Medico ADD CONSTRAINT FK_MEDICO_CONSULTORIO
FOREIGN KEY (Consultorio) REFERENCES Consultorio(IDConsultorio)
go

INSERT Consultorio VALUES(1,'Consultorio Los Angeles', 'Blvrd Alfonso G. Calderón 2139')
INSERT Consultorio VALUES(2,'Consultorio Medico Escobedo', 'Escobedo 358, Primer Cuadro, 80000')
INSERT Consultorio VALUES(3,'Consultorio Medico Santa Cecilia', 'Calle Cristóbal Colón 278 Oriente')

INSERT Medico VALUES(1000, 'Jose Perez', 'Neumologo', 'Oftamologo', '6673434234', 1)
INSERT Medico VALUES(1002, 'Jaime Ramirez', 'Ortopedico', '', '6675436123', 2)
INSERT Medico VALUES(1004, 'Juan Colosio', 'Cardiologo', 'Neumologo', '6678946784', 3)

INSERT CitaMedica VALUES(1002, '2020-12-15' ,'12:00', 'Juan Rulfo', '6674564234', 'Huesos debiles')
INSERT CitaMedica VALUES(1000, '2022-05-10' ,'17:00', 'Luka Modric', '6673241231', '')
INSERT CitaMedica VALUES(1000, '2023-01-15' ,'15:00', 'Karim Benzema', '6674281216', 'Problemas Respiratorios')

Select * from Medico
Select * from CitaMedica
select * from Consultorio
