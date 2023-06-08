CREATE DATABASE ControlEscolar
GO

USE ControlEscolar
GO


/*
	CREACIÓN DE TABLAS
*/
CREATE TABLE Carrera
(
	ClaveCarr INT IDENTITY(10, 1) NOT NULL,	--	PK
	NombreCarr NVARCHAR(50) NOT NULL,	--	No Permitir Dupes.
	FechaCarr DATETIME 
)
GO

CREATE TABLE Estudiante
(
	ClaveEst INT IDENTITY(20230001,1) NOT NULL,	--	PK
	NombreEst NVARCHAR(100) NOT NULL,
	SemestreEst INT NOT NULL,
	CarreraEst INT NOT NULL,	--	FK
	DomicilioEst NVARCHAR(200),
	CorreoEst NVARCHAR(100),
	TelefonoEst NVARCHAR(20)
)
GO

CREATE TABLE Materia
(
	ClaveMat INT IDENTITY(100,1) NOT NULL,	--	PK
	NombreMat NVARCHAR(50) NOT NULL,
	CarreraMat INT NOT NULL,	--	FK
	CreditosMat INT NOT NULL,
	NombreMaestroMat NVARCHAR(100),
	HoraMat TIME NOT NULL,
	AlumnosInscritosMat INT NOT NULL,
	MaxAlumnosMat INT NOT NULL,
)
GO

CREATE TABLE CargaAcademica
(
	ClaveEstudianteCA INT NOT NULL,	--	PK
	ClaveMateria1CA INT NOT NULL,	--	FK
	ClaveMateria2CA INT,			--	FK
	ClaveMateria3CA INT,			--	FK
	ClaveMateria4CA INT,			--	FK
	ClaveMateria5CA INT,			--	FK
)
GO

CREATE TABLE Calificacion
(
	CveEstudianteCal INT NOT NULL,			-- PK, FK
	CveMateriaCal INT NOT NULL,				--	PK, FK
	CalificacionCal NUMERIC(3,1) NOT NULL
)
GO


/*
	CONSTRAINTS
*/

--	Carrera
ALTER TABLE Carrera 
	ADD CONSTRAINT PK_Carrera PRIMARY KEY (ClaveCarr)
GO

--	Estudiante
ALTER TABLE Estudiante
	ADD CONSTRAINT PK_Estudiante PRIMARY KEY (ClaveEst)
ALTER TABLE Estudiante
	ADD CONSTRAINT FK_Estudiante_Carrera
	FOREIGN KEY (CarreraEst) REFERENCES Carrera (ClaveCarr)
GO

--	Materias
ALTER TABLE Materia
	ADD CONSTRAINT PK_Materias PRIMARY KEY (ClaveMat)
ALTER TABLE Materia
	ADD CONSTRAINT FK_Materia_Carrera
	FOREIGN KEY (CarreraMat) REFERENCES Carrera (ClaveCarr)
GO

--	Carga Academica
ALTER TABLE CargaAcademica
	ADD CONSTRAINT PK_CargaAcademica PRIMARY KEY (ClaveEstudianteCA)
ALTER TABLE CargaAcademica
	ADD CONSTRAINT FK_CargaAcademica_Estudiante
	FOREIGN KEY (ClaveEstudianteCA) REFERENCES Estudiante (ClaveEst)
ALTER TABLE CargaAcademica
	ADD CONSTRAINT FK_CargaAcademica_Materia1
	FOREIGN KEY (ClaveMateria1CA) REFERENCES Materia (ClaveMat)
ALTER TABLE CargaAcademica
	ADD CONSTRAINT FK_CargaAcademica_Materia2
	FOREIGN KEY (ClaveMateria2CA) REFERENCES Materia (ClaveMat)
ALTER TABLE CargaAcademica
	ADD CONSTRAINT FK_CargaAcademica_Materia3
	FOREIGN KEY (ClaveMateria3CA) REFERENCES Materia (ClaveMat)
ALTER TABLE CargaAcademica
	ADD CONSTRAINT FK_CargaAcademica_Materia4
	FOREIGN KEY (ClaveMateria4CA) REFERENCES Materia (ClaveMat)
ALTER TABLE CargaAcademica
	ADD CONSTRAINT FK_CargaAcademica_Materia5
	FOREIGN KEY (ClaveMateria5CA) REFERENCES Materia (ClaveMat)
GO

--	Calificacion
ALTER TABLE Calificacion
	ADD CONSTRAINT PK_Calificacion PRIMARY KEY (CveEstudianteCal, CveMateriaCal)
ALTER TABLE Calificacion
	ADD CONSTRAINT FK_Calificacion_Estudiante
	FOREIGN KEY (CveEstudianteCal) REFERENCES Estudiante (ClaveEst)
ALTER TABLE Calificacion
	ADD CONSTRAINT FK_Calificacion_Materia
	FOREIGN KEY (CveMateriaCal) REFERENCES Materia (ClaveMat)
GO


/*
	INSERCIONES
*/
INSERT INTO Carrera (NombreCarr, FechaCarr)
VALUES ('INGENIERIA EN SISTEMAS COMPUTACIONALES', '2022-01-01'),
	   ('INGENIERIA EN MECATRONICA', '2022-01-01'),
	   ('INGENERIA MECANICA', '2022-01-01')
GO

INSERT INTO Estudiante (NombreEst, SemestreEst, CarreraEst, DomicilioEst, CorreoEst, TelefonoEst)
VALUES ('JUAN PEREZ', 3, 10, 'CALLE 123, CIUDAD', 'JUAN@EXAMPLE.com', '1234567890'),
	   ('MARIA LOPEZ', 4, 10, 'AVENIDA ABC, CIUDAD', 'MARIA@EXAMPLE.com', '0987654321')
GO

INSERT INTO Materia (NombreMat, CarreraMat, CreditosMat, NombreMaestroMat, HoraMat, AlumnosInscritosMat, MaxAlumnosMat)
VALUES ('MATEMATICAS DISCRETAS', 10, 4, 'JORGE ELIAS CAMPOS', '09:00:00', 20, 30),
	   ('FUNDAMENTOS DE PROGRAMACION', 10, 5, 'BENZEMA VINICIUS JR', '14:00:00', 15, 25),
	   ('TESEBADA', 10, 5, 'CLEMENTE GARCIA GERARDO', '11:00:00', 5, 30),
	   ('TOPICOS AVANZADOS DE PROGRAMACION', 10, 5, 'GLORIA EKATERINE PERALTA', '12:00:00', 25, 25),
	   ('CALCULO VECTORIAL', 10, 5, 'CARLOS GERARDO CAMACHO', '14:00:00', 15, 25)
GO

INSERT INTO CargaAcademica (ClaveEstudianteCA, ClaveMateria1CA, ClaveMateria2CA, ClaveMateria3CA, ClaveMateria4CA, ClaveMateria5CA)
VALUES (20230001, 100, 101, NULL, NULL, NULL),
	   (20230002, 100, 101, NULL, NULL, NULL)
GO

INSERT INTO Calificacion (CveEstudianteCal, CveMateriaCal, CalificacionCal)
VALUES (20230001, 100, 9.5),
	   (20230001, 101, 8.7)
GO