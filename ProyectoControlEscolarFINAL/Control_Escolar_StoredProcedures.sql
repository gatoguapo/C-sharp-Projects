USE ControlEscolar
GO
--LISTAR
CREATE PROCEDURE Carrera_Listar
AS
BEGIN
	SELECT 'CLAVE CARRERA' = ClaveCarr, 'NOMBRE CARRERA' = NombreCarr, 'FECHA CARRERA' = FechaCarr 
	FROM Carrera
	ORDER BY ClaveCarr
END
GO

CREATE PROCEDURE EstudiantesTotal_Listar
AS
BEGIN
	SELECT 'CLAVE ESTUDIANTE' = ClaveEst, 'NOMBRE ESTUDIANTE' = NombreEst, 'SEMESTRE DEL ESTUDIANTE' = SemestreEst,
	'CARRERA CLAVE' = CarreraEst, 'CARRERA DEL ESTUDIANTE' = Ca.NombreCarr, 'DOMICILIO ESTUDIANTE' = DomicilioEst, 
	'CORREO ESTUDIANTE' = CorreoEst, 'TELEFONO ESTUDIANTE' = TelefonoEst
	FROM Estudiante E
	INNER JOIN Carrera Ca on Ca.ClaveCarr = E.CarreraEst
END
GO

CREATE PROCEDURE Estudiante_Listar
AS
BEGIN
	SELECT 'CLAVE ESTUDIANTE' = ClaveEst, 'NOMBRE ESTUDIANTE' = NombreEst, 'SEMESTRE DEL ESTUDIANTE' = SemestreEst,
	'CARRERA CLAVE' = CarreraEst, 'CARRERA DEL ESTUDIANTE' = Ca.NombreCarr, 'MATERIA 1' = isnull(M1.NombreMat,'NO CARGADA'),  'MATERIA 2' = isnull(M2.NombreMat,'NO CARGADA'),
	'MATERIA 3' = isnull(M3.NombreMat,'NO CARGADA'), 'MATERIA 4' = isnull(M4.NombreMat,'NO CARGADA'), 'MATERIA 5' = isnull(M5.NombreMat,'NO CARGADA'),
	'DOMICILIO ESTUDIANTE' = DomicilioEst, 'CORREO ESTUDIANTE' = CorreoEst,
	'TELEFONO ESTUDIANTE' = TelefonoEst
	FROM Estudiante E
	INNER JOIN	CargaAcademica C on E.ClaveEst = C.ClaveEstudianteCA
	INNER JOIN Carrera Ca on Ca.ClaveCarr = E.CarreraEst
	LEFT JOIN Materia M1 on M1.ClaveMat = C.ClaveMateria1CA
	LEFT JOIN Materia M2 on M2.ClaveMat = C.ClaveMateria2CA
	LEFT JOIN Materia M3 on M3.ClaveMat = C.ClaveMateria3CA
	LEFT JOIN Materia M4 on M4.ClaveMat = C.ClaveMateria4CA
	LEFT JOIN Materia M5 on M5.ClaveMat = C.ClaveMateria5CA
	ORDER BY ClaveEst
END
GO
CREATE PROCEDURE Materia_Listar
AS
BEGIN
	SELECT 'CLAVE MATERIA' = ClaveMat, 'NOMBRE MATERIA' = NombreMat, 'CLAVE DE LA CARRERA' = CarreraMat,
	'CARRERA DE LA MATERIA' = c.NombreCarr, 'CREDITOS DE LA MATERIA' = CreditosMat, 'MAESTRO MATERIA' = NombreMaestroMat, 
	'HORA DE MATERIA' = HoraMat, 'ALUMNOS INSCRITOS' = AlumnosInscritosMat, 'MAXIMO DE ALUMNOS' = MaxAlumnosMat
	FROM Materia m
	INNER JOIN Carrera c on m.CarreraMat = c.ClaveCarr
	ORDER BY ClaveMat
END
GO
CREATE PROCEDURE Calificaciones_Listar
AS
BEGIN
	SELECT 'CLAVE ESTUDIANTE' = CveEstudianteCal,'NOMBRE ESTUDIANTE' = e.NombreEst, 'SEMESTRE' = e.SemestreEst, 'CLAVE MATERIA' = CveMateriaCal, 
	'NOMBRE MATERIA' =  m.NombreMat, 'CALIFICACIÓN' = CalificacionCal 
	FROM Calificacion c
	INNER JOIN Estudiante e on c.CveEstudianteCal = e.ClaveEst
	INNER JOIN Materia m on c.CveMateriaCal = m.ClaveMat
	ORDER BY CveEstudianteCal
END
GO
CREATE PROCEDURE CargaAcademica_Listar
AS
BEGIN
	SELECT 'CLAVE ESTUDIANTE' = ClaveEstudianteCA, 'NOMBRE ESTUDIANTE' = E.NombreEst, 
	'CLAVE DE MATERIA 1' = isnull(ClaveMateria1CA,0), 'NOMBRE MATERIA 1' = isnull(M1.NombreMat,'NO CARGADA'),
	'CLAVE DE MATERIA 2' = isnull(ClaveMateria2CA,0), 'NOMBRE MATERIA 2' = isnull(M2.NombreMat,'NO CARGADA'),
	'CLAVE DE MATERIA 3' = isnull(ClaveMateria3CA,0), 'NOMBRE MATERIA 3' = isnull(M3.NombreMat,'NO CARGADA'), 
	'CLAVE DE MATERIA 4' = isnull(ClaveMateria4CA,0), 'NOMBRE MATERIA 4' = isnull(M4.NombreMat,'NO CARGADA'),
	'CLAVE DE MATERIA 5' = isnull(ClaveMateria5CA,0), 'NOMBRE MATERIA 5' = isnull(M5.NombreMat,'NO CARGADA') 
	FROM CargaAcademica C
	INNER JOIN Estudiante E ON E.ClaveEst = C.ClaveEstudianteCA
	LEFT JOIN Materia M1 ON M1.ClaveMat = c.ClaveMateria1CA
	LEFT JOIN Materia M2 ON M2.ClaveMat = c.ClaveMateria2CA
	LEFT JOIN Materia M3 ON M3.ClaveMat = c.ClaveMateria3CA
	LEFT JOIN Materia M4 ON M4.ClaveMat = c.ClaveMateria4CA
	LEFT JOIN Materia M5 ON M5.ClaveMat = c.ClaveMateria5CA
	ORDER BY ClaveEstudianteCA
END
GO

--BUSCAR
CREATE PROCEDURE Carrera_Buscar @Buscar nvarchar(100)
AS
BEGIN
	SELECT 'CLAVE CARRERA' = ClaveCarr, 'NOMBRE CARRERA' = NombreCarr, 'FECHA CARRERA' = FechaCarr 
	FROM Carrera
	WHERE NombreCarr like CONCAT('%',@Buscar,'%')
	ORDER BY ClaveCarr
END
GO

CREATE PROCEDURE Estudiante_Buscar @Buscar nvarchar(100)
AS
BEGIN
	SELECT 'CLAVE ESTUDIANTE' = ClaveEst, 'NOMBRE ESTUDIANTE' = NombreEst, 'SEMESTRE DEL ESTUDIANTE' = SemestreEst,
	'CARRERA CLAVE' = CarreraEst, 'CARRERA DEL ESTUDIANTE' = Ca.NombreCarr, 'MATERIA 1' = isnull(M1.NombreMat,'NO CARGADA'),  'MATERIA 2' = isnull(M2.NombreMat,'NO CARGADA'),
	'MATERIA 3' = isnull(M3.NombreMat,'NO CARGADA'), 'MATERIA 4' = isnull(M4.NombreMat,'NO CARGADA'), 'MATERIA 5' = isnull(M5.NombreMat,'NO CARGADA'),
	'DOMICILIO ESTUDIANTE' = DomicilioEst, 'CORREO ESTUDIANTE' = CorreoEst,
	'TELEFONO ESTUDIANTE' = TelefonoEst
	FROM Estudiante E
	INNER JOIN	CargaAcademica C on E.ClaveEst = C.ClaveEstudianteCA
	INNER JOIN Carrera Ca on Ca.ClaveCarr = E.CarreraEst
	LEFT JOIN Materia M1 on M1.ClaveMat = C.ClaveMateria1CA
	LEFT JOIN Materia M2 on M2.ClaveMat = C.ClaveMateria2CA
	LEFT JOIN Materia M3 on M3.ClaveMat = C.ClaveMateria3CA
	LEFT JOIN Materia M4 on M4.ClaveMat = C.ClaveMateria4CA
	LEFT JOIN Materia M5 on M5.ClaveMat = C.ClaveMateria5CA
	WHERE NombreEst like CONCAT('%',@Buscar,'%')
	ORDER BY ClaveEst
END
GO
CREATE PROCEDURE NombreEstudianteCal_Buscar @Buscar nvarchar(100)
AS
BEGIN
	SELECT 'CLAVE ESTUDIANTE' = CveEstudianteCal,'NOMBRE ESTUDIANTE' = e.NombreEst, 'SEMESTRE' = e.SemestreEst, 'CLAVE MATERIA' = CveMateriaCal, 
	'NOMBRE MATERIA' =  m.NombreMat, 'CALIFICACIÓN' = CalificacionCal 
	FROM Calificacion c
	INNER JOIN Estudiante e ON c.CveEstudianteCal = e.ClaveEst
	INNER JOIN Materia m on c.CveMateriaCal = m.ClaveMat
	WHERE E.NombreEst like CONCAT('%',@Buscar,'%')
	ORDER BY CveEstudianteCal
END
GO
CREATE PROCEDURE Materia_Buscar @Buscar nvarchar(100)
AS
BEGIN
	SELECT 'CLAVE MATERIA' = ClaveMat, 'NOMBRE MATERIA' = NombreMat, 'CLAVE DE LA MATERIA' = CarreraMat,
	'CARRERA DE LA MATERIA' = c.NombreCarr, 'CREDITOS DE LA MATERIA' = CreditosMat, 'MAESTRO MATERIA' = NombreMaestroMat, 
	'HORA DE MATERIA' = HoraMat, 'ALUMNOS INSCRITOS' = AlumnosInscritosMat, 'MAXIMO DE ALUMNOS' = MaxAlumnosMat
	FROM Materia m
	INNER JOIN Carrera c on m.CarreraMat = c.ClaveCarr
	WHERE NombreMat like CONCAT('%',@Buscar,'%')
	ORDER BY ClaveMat
END
GO
CREATE PROCEDURE MateriaCarrera_Buscar @Clave INT
AS
BEGIN
	SELECT 'CLAVE MATERIA' = ClaveMat, 'NOMBRE MATERIA' = NombreMat, 'CLAVE DE LA MATERIA' = CarreraMat,
	'CARRERA DE LA MATERIA' = c.NombreCarr, 'CREDITOS DE LA MATERIA' = CreditosMat, 'MAESTRO MATERIA' = NombreMaestroMat, 
	'HORA DE MATERIA' = HoraMat, 'ALUMNOS INSCRITOS' = AlumnosInscritosMat, 'MAXIMO DE ALUMNOS' = MaxAlumnosMat
	FROM Materia m
	INNER JOIN Carrera c on m.CarreraMat = c.ClaveCarr
	WHERE ClaveCarr = @Clave
	ORDER BY ClaveMat
END
GO
CREATE PROCEDURE NombreEstudianteCarga_Buscar @Buscar nvarchar(100)
AS
BEGIN
	SELECT 'CLAVE ESTUDIANTE' = ClaveEstudianteCA, 'NOMBRE ESTUDIANTE' = E.NombreEst, 
	'CLAVE DE MATERIA 1' = isnull(ClaveMateria1CA,0), 'NOMBRE MATERIA 1' = isnull(M1.NombreMat,'NO CARGADA'),
	'CLAVE DE MATERIA 2' = isnull(ClaveMateria2CA,0), 'NOMBRE MATERIA 2' = isnull(M2.NombreMat,'NO CARGADA'),
	'CLAVE DE MATERIA 3' = isnull(ClaveMateria3CA,0), 'NOMBRE MATERIA 3' = isnull(M3.NombreMat,'NO CARGADA'), 
	'CLAVE DE MATERIA 4' = isnull(ClaveMateria4CA,0), 'NOMBRE MATERIA 4' = isnull(M4.NombreMat,'NO CARGADA'),
	'CLAVE DE MATERIA 5' = isnull(ClaveMateria5CA,0), 'NOMBRE MATERIA 5' = isnull(M5.NombreMat,'NO CARGADA') 
	FROM CargaAcademica C
	INNER JOIN Estudiante E ON E.ClaveEst = C.ClaveEstudianteCA
	LEFT JOIN Materia M1 ON M1.ClaveMat = c.ClaveMateria1CA
	LEFT JOIN Materia M2 ON M2.ClaveMat = c.ClaveMateria2CA
	LEFT JOIN Materia M3 ON M3.ClaveMat = c.ClaveMateria3CA
	LEFT JOIN Materia M4 ON M4.ClaveMat = c.ClaveMateria4CA
	LEFT JOIN Materia M5 ON M5.ClaveMat = c.ClaveMateria5CA
	WHERE E.NombreEst like CONCAT('%',@Buscar,'%')
	ORDER BY ClaveEstudianteCA
END
go
--INSERTAR

CREATE PROC Carrera_Insertar
@nombre NVARCHAR(50),
@fecha DATETIME
AS
INSERT INTO Carrera(NombreCarr, FechaCarr)
VALUES (@nombre, @fecha)
GO

CREATE PROC Estudiante_Insertar
@nombreEstudiante NVARCHAR(100),
@semestre INT,
@carreraClave INT,
@domicilioEstudiante NVARCHAR(200),
@correoEstudiante NVARCHAR(100),
@telefonoEstudiante NVARCHAR(20)

AS
INSERT INTO Estudiante(NombreEst, SemestreEst, CarreraEst, DomicilioEst, CorreoEst, TelefonoEst)
VALUES (@nombreEstudiante, @semestre, @carreraClave, @domicilioEstudiante, @correoEstudiante , @telefonoEstudiante)
GO

CREATE PROC Materia_Insertar
@nombreMat NVARCHAR(50),
@carreraMat INT,
@creditosMat INT,
@nombreMaestroMat NVARCHAR(100),
@horaMat TIME,
@alumnosInscritosMat INT,
@maxAlumnosMat INT

AS
INSERT INTO Materia(NombreMat, CarreraMat, CreditosMat, NombreMaestroMat,HoraMat, AlumnosInscritosMat, MaxAlumnosMat)
VALUES (@nombreMat, @carreraMat, @creditosMat, @nombreMaestroMat, @horaMat, @alumnosInscritosMat, @maxAlumnosMat)
GO

CREATE PROC CargaAcademica_Insertar
@claveEstudianteCA INT,	
@claveMateria1CA INT,	
@claveMateria2CA INT,			
@claveMateria3CA INT,			
@claveMateria4CA INT,			
@claveMateria5CA INT		

AS
INSERT INTO CargaAcademica(ClaveEstudianteCA, ClaveMateria1CA, ClaveMateria2CA, ClaveMateria3CA, ClaveMateria4CA, ClaveMateria5CA)
VALUES (@claveEstudianteCA,	@claveMateria1CA, @claveMateria2CA, @claveMateria3CA, @claveMateria4CA, @claveMateria5CA)
GO

CREATE PROC Calificacion_Insertar
@cveEstudianteCal INT,					
@cveMateriaCal INT,				
@calificacionCal NUMERIC(3,1)

AS
INSERT INTO Calificacion(CveEstudianteCal, CveMateriaCal, CalificacionCal)
VALUES (@cveEstudianteCal, @cveMateriaCal, @calificacionCal)
GO

--VALIDACIONES
create proc Carrera_Existe
@nombre nvarchar(50),
@existe int output
as
if exists (select NombreCarr from Carrera where NombreCarr = LTRIM(rtrim(@nombre)))
	begin
		set @existe = 1
	end
else
	begin
		set @existe = 0
	end

go

CREATE PROC Calificacion_Existe
@cveEstudiante int,
@cveMateria int,
@existe int output
AS
BEGIN
     IF EXISTS (SELECT CveEstudianteCal, CveMateriaCal FROM Calificacion WHERE CveEstudianteCal=@cveEstudiante AND CveMateriaCal=@cveMateria)
	 BEGIN
	      SET @existe=1;
	 END
	 ELSE
	      BEGIN
	           SET @existe=0;
	      END
END
GO

create proc Estudiante_Existe
@nombre nvarchar(100),
@existe int output
as
if exists (select NombreEst from Estudiante where NombreEst = LTRIM(rtrim(@nombre)))
	begin
		set @existe = 1
	end
else
	begin
		set @existe = 0
	end

go

create proc Materia_Existe
@nombre nvarchar(50),
@existe int output
as
if exists (select NombreMat from Materia where NombreMat = LTRIM(rtrim(@nombre)))
	begin
		set @existe = 1
	end
else
	begin
		set @existe = 0
	end

go

create proc CargaAcademica_Existe
@clave int,
@existe int output
as
if exists (select ClaveEstudianteCA from CargaAcademica where ClaveEstudianteCA = @clave)
	begin
		set @existe = 1
	end
else
	begin
		set @existe = 0
	end

go
create trigger TR_ValidaCarga
on CargaAcademica for insert as
begin
	--Materia 1
	declare @materia1 int, @alumnos int, @maxAlusmnos int, @materiaNombre nvarchar(50), @error nvarchar(50)
	select @materia1 = ClaveMateria1CA from inserted
	select @materiaNombre = NombreMat from Materia where ClaveMat = @materia1
	select @alumnos = AlumnosInscritosMat from Materia where ClaveMat = @materia1
	select @maxAlusmnos = MaxAlumnosMat from Materia where ClaveMat = @materia1
	select @error = concat('El cupo de la materia ',@materiaNombre,' esta lleno')
	if (@alumnos+1 > @maxAlusmnos)
	begin
		rollback tran
		raiserror(@error,16,1)
	end
	--Materia 2
	declare @materia2 int

	select @materia2 = ClaveMateria2CA from inserted
	select @materiaNombre = NombreMat from Materia where ClaveMat = @materia2
	select @alumnos = AlumnosInscritosMat from Materia where ClaveMat = @materia2
	select @maxAlusmnos = MaxAlumnosMat from Materia where ClaveMat = @materia2
	select @error = concat('El cupo de la materia ',@materiaNombre,' esta lleno')
	if (@alumnos+1 > @maxAlusmnos)
	begin
		rollback tran
		raiserror(@error,16,1)
	end

	--Materia 3
	declare @materia3 int

	select @materia3 = ClaveMateria3CA from inserted
	select @materiaNombre = NombreMat from Materia where ClaveMat = @materia3
	select @alumnos = AlumnosInscritosMat from Materia where ClaveMat = @materia3
	select @maxAlusmnos = MaxAlumnosMat from Materia where ClaveMat = @materia3
	select @error = concat('El cupo de la materia ',@materiaNombre,' esta lleno')
	if (@alumnos+1 > @maxAlusmnos)
	begin
		rollback tran
		raiserror(@error,16,1)
	end

	--Materia 4
	declare @materia4 int

	select @materia4 = ClaveMateria4CA from inserted
	select @materiaNombre = NombreMat from Materia where ClaveMat = @materia4
	select @alumnos = AlumnosInscritosMat from Materia where ClaveMat = @materia4
	select @maxAlusmnos = MaxAlumnosMat from Materia where ClaveMat = @materia4
	select @error = concat('El cupo de la materia ',@materiaNombre,' esta lleno')
	if (@alumnos+1 > @maxAlusmnos)
	begin
		rollback tran
		raiserror(@error,16,1)
	end
	else

	--Materia 5
	declare @materia5 int

	select @materia5 = ClaveMateria5CA from inserted
	select @materiaNombre = NombreMat from Materia where ClaveMat = @materia5
	select @alumnos = AlumnosInscritosMat from Materia where ClaveMat = @materia5
	select @maxAlusmnos = MaxAlumnosMat from Materia where ClaveMat = @materia5
	select @error = concat('El cupo de la materia ',@materiaNombre,' esta lleno')
	if (@alumnos+1 > @maxAlusmnos)
	begin
		rollback tran
		raiserror(@error,16,1)
	end
	
	update Materia set AlumnosInscritosMat = AlumnosInscritosMat+1 where ClaveMat = @materia1
	update Materia set AlumnosInscritosMat = AlumnosInscritosMat+1 where ClaveMat = @materia2
	update Materia set AlumnosInscritosMat = AlumnosInscritosMat+1 where ClaveMat = @materia3
	update Materia set AlumnosInscritosMat = AlumnosInscritosMat+1 where ClaveMat = @materia4
	update Materia set AlumnosInscritosMat = AlumnosInscritosMat+1 where ClaveMat = @materia5
end
go
create trigger TR_ValidaCargaInsertar
on CargaAcademica for insert as
begin
	declare @cveMateria1 INT, @cveMateria2 INT, @cveMateria3 INT, @cveMateria4 INT, @cveMateria5 INT
	select @cveMateria1 = ClaveMateria1CA from inserted
	select @cveMateria2 = ClaveMateria2CA from inserted
	select @cveMateria3 = ClaveMateria3CA from inserted
	select @cveMateria4 = ClaveMateria4CA from inserted
	select @cveMateria5 = ClaveMateria5CA from inserted

	if (@cveMateria1 = @cveMateria2 or @cveMateria1 = @cveMateria3 or @cveMateria1 = @cveMateria4 or @cveMateria1 = @cveMateria5) 
	begin
		rollback tran
		raiserror('ERROR, No puedes agregar la misma clave de la materia mas de una vez', 16, 1)
	end
	if (@cveMateria2 = @cveMateria1 or @cveMateria2 = @cveMateria3 or @cveMateria2 = @cveMateria4 or @cveMateria2 = @cveMateria5) 
	begin
		rollback tran
		raiserror('ERROR, No puedes agregar la misma clave de la materia mas de una vez', 16, 1)
	end
	if (@cveMateria3 = @cveMateria1 or @cveMateria3 = @cveMateria2 or @cveMateria3 = @cveMateria4 or @cveMateria3 = @cveMateria5) 
	begin
		rollback tran
		raiserror('ERROR, No puedes agregar la misma clave de la materia mas de una vez', 16, 1)
	end
	if (@cveMateria4 = @cveMateria1 or @cveMateria4 = @cveMateria2 or @cveMateria4 = @cveMateria3 or @cveMateria4 = @cveMateria5) 
	begin
		rollback tran
		raiserror('ERROR, No puedes agregar la misma clave de la materia mas de una vez', 16, 1)
	end
	if (@cveMateria5 = @cveMateria1 or @cveMateria5 = @cveMateria2 or @cveMateria5 = @cveMateria3 or @cveMateria5 = @cveMateria4) 
	begin
		rollback tran
		raiserror('ERROR, No puedes agregar la misma clave de la materia mas de una vez', 16, 1)
	end
end
go

--OBTENER IDENTITYS
CREATE OR ALTER PROC Carrera_ObtenerIdentity
@clave INT OUTPUT
AS
    SET @clave = IDENT_CURRENT('Carrera') + 1
GO

CREATE OR ALTER PROC Estudiante_ObtenerIdentity
@clave INT OUTPUT
AS
    SET @clave = IDENT_CURRENT('Estudiante') + 1
GO

CREATE OR ALTER PROC Materia_ObtenerIdentity
@clave INT OUTPUT
AS
    SET @clave = IDENT_CURRENT('Materia') + 1
GO
--ELIMINAR
CREATE or ALTER PROCEDURE Carrera_Eliminada
@claveCarr INT
AS
BEGIN
     DELETE Carrera 
	 WHERE ClaveCarr=@claveCarr
END
go

--ACTUALIZA
CREATE OR ALTER PROCEDURE ActualizarMateria
@claveMat INT,
@nombre NVARCHAR(50),
@claveCarrera INT,
@creditos INT,
@nombreMaestro NVARCHAR(100),
@hora TIME,
@alumnosInsc INT,
@maxAlumnos INT
AS
BEGIN	
UPDATE Materia 
	SET NombreMat = @nombre,
		CarreraMat = @claveCarrera,
		CreditosMat= @creditos,
		NombreMaestroMat=@nombreMaestro,
		HoraMat =@hora,
		AlumnosInscritosMat =@alumnosInsc,
		MaxAlumnosMat= @maxAlumnos
	WHERE ClaveMat = @claveMat;
UPDATE CargaAcademica
    SET    
	ClaveMateria1CA=@claveMat,
	ClaveMateria2CA=@claveMat,
	ClaveMateria3CA=@claveMat,
	ClaveMateria4CA=@claveMat,
	ClaveMateria5CA=@claveMat
    WHERE ClaveMateria1CA=@claveMat AND ClaveMateria2CA=@claveMat AND ClaveMateria3CA=@claveMat AND ClaveMateria4CA=@claveMat AND ClaveMateria5CA=@claveMat
END
GO

CREATE OR ALTER PROCEDURE ModificarEstudiante	
@ClaveEstudiante INT,
@NombreEst NVARCHAR(100),
@CarreraEst INT,
@DomicilioEst NVARCHAR(200),
@CorreoEst NVARCHAR(100),
@TelefonoEst NVARCHAR(20)
AS
BEGIN
	UPDATE Estudiante
	SET NombreEst = @NombreEst,
		CarreraEst = @CarreraEst,
		DomicilioEst = @DomicilioEst,
		CorreoEst = @CorreoEst,
		TelefonoEst = @TelefonoEst
	WHERE ClaveEst = @ClaveEstudiante;
END
GO
