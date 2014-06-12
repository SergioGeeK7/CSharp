CREATE DATABASE BDMatricula

go
USE BDMatricula
go

CREATE TABLE tblPROgrama
(
id_PRO int Primary Key NOT NULL,
idFAC_PRO int NOT NULL,
strNombre_PRO varchar(30) NOT NULL
)
go


CREATE TABLE tblJORnada
(
id_JOR int Primary Key NOT NULL,
strNombre_JOR varchar(10) NOT NULL
)
go

CREATE TABLE tblESTudiante
(
id_EST varchar(10) Primary KEy NOT NULL,
intNroDoc_EST int NOT NULL,
strNombre_EST varchar(50) NOT NULL,
idPRO_EST int NOT NULL,
blnActivo_EST bit default 1 NOT NULL,
idJOR_EST int NOT NULL,
strObservac_EST varchar(500) NULL
)
go

CREATE TABLE tblMATricula
(
id_MAT int identity(1,1) Primary Key NOT NULL,
dtmFecha_MAT datetime default getdate(),
idPER_MAT int NOT NULL,
idEST_MAT varchar(10) NOT NULL,
idASI_MAT varchar(8) NOT NULL
)
go

CREATE TABLE tblFACultad
(
id_FAC int Primary Key NOT NULL,
strNombre_FAC varchar(30) NOT NULL
)
go

CREATE TABLE tblASIgnatura
(
id_ASI varchar(8) Primary Key NOT NULL,
idPRO_ASI int NOT NULL,
strNombre_ASI varchar(50) NOT NULL
)
go	

CREATE TABLE tblPERiodo
(
id_PER int Primary Key NOT NULL,
strNombre_PER varchar(30) NOT NULL
)
go

ALTER TABLE tblPROgrama add Foreign Key (idFAC_PRO) REFERENCES tblFACultad (id_FAC)
ALTER TABLE tblASIgnatura add Foreign Key (idPRO_ASI) REFERENCES tblPROgrama(id_PRO)
ALTER TABLE tblESTudiante add Foreign Key (idJOR_EST) REFERENCES tblJORnada(id_JOR)
ALTER TABLE tblMATricula add Foreign Key(idPER_MAT) REFERENCES tblPERiodo(id_PER)
ALTER TABLE tblMATricula add Foreign Key(idEST_MAT) REFERENCES tblESTudiante(id_EST)
ALTER TABLE tblMATricula add Foreign Key(idASI_MAT) REFERENCES tblASIgnatura(id_ASI)
ALTER TABLE tblESTudiante add Foreign Key (idPRO_EST) REFERENCES tblPROgrama(id_PRO)
go

INSERT INTO tblFACultad VALUES (1,'Tecnologias'),(2,'Ingenierias');

INSERT INTO tblPROgrama VALUES (10, 1, 'Tecn. Sistemas de Informacion');
INSERT INTO tblPROgrama VALUES (20, 2, 'Ing. de Sistemas');
INSERT INTO tblPROgrama VALUES (30, 1, 'Tecn. en Telecomunicaciones');
INSERT INTO tblPROgrama VALUES (40, 2, 'Ing. de Telecomunicaciones');
INSERT INTO tblPROgrama VALUES (50, 1, 'Tecn. en Electromecanica');
INSERT INTO tblPROgrama VALUES (60, 2, 'Ing. Electromecanica');
INSERT INTO tblPROgrama VALUES (70, 1, 'Tecn. en Calidad');


INSERT INTO tblASIgnatura VALUES ('BDI44', 10, 'Bases de Datos');
INSERT INTO tblASIgnatura VALUES ('PAI74', 20, 'Programacion Avanzada')
INSERT INTO tblASIgnatura VAlUES ('CXT34', 30, 'Circuitos Digitales I');
INSERT INTO tblASIgnatura VAlUES ('ANT32', 40, 'Antenas I');
INSERT INTO tblASIgnatura VAlUES ('MQN22', 50, 'Maquinas');
INSERT INTO tblASIgnatura VAlUES ('MAT24', 60, 'Materiales I');
INSERT INTO tblASIgnatura VAlUES ('MTL44', 70, 'Metrologia'); 
INSERT INTO tblASIgnatura VAlUES ('DSI54', 10, 'Desarrollo de Software Empresarial');
INSERT INTO tblASIgnatura VAlUES ('ACI82', 20, 'Arquitectura de Computadores');
INSERT INTO tblASIgnatura VAlUES ('CXT44', 30, 'Circuitos Digitales II');
INSERT INTO tblASIgnatura VAlUES ('ANT42', 40, 'Antenas II');
INSERT INTO tblASIgnatura VAlUES ('CNT34', 50, 'Controles Digitales');
INSERT INTO tblASIgnatura VAlUES ('MAT34', 60, 'Materiales II')
INSERT INTO tblASIgnatura VAlUES ('EST14', 70, 'Estadistica');

INSERT INTO tblPERiodo VAlUES (55, '2012-1'), (56, '212-2'), (57, '2013-1');
INSERT INTO tblPERiodo VAlUES (58, '2013-2'), (59, '2014-1'), (60, '2014-2');

INSERT INTO  tblJORnada VAlUES (1, 'Mañana' ), (2, 'Tarde'),  (3, 'Noche'), (4, 'Unica');

INSERT INTO  tblESTudiante VAlUES ('10101010', 70500600, 'Roberto Melendez D.', 10, 1, 1, 'Ppto Partic.');  
INSERT INTO  tblESTudiante VAlUES ('10102020', 1020500600, 'Mario A. Martinez', 20, 1, 2, 'Fondo EPM');
INSERT INTO  tblESTudiante VAlUES ('10102021', 32100100, 'Natalia Castrillon', 70, 1 , 3, '');

INSERT INTO  tblESTudiante VAlUES ('90909090', 457450600, 'Ruben Dario Soto', 30, 1, 1, 'Prueba');
INSERT INTO  tblESTudiante VAlUES ('40404040', 456500600, 'Mariana Aguirre', 50, 1, 2,'Reserva');
INSERT INTO  tblESTudiante VAlUES ('50505051', 86100100, 'Jazmin Angarita', 70, 1, 3, 'Ppto Partic.');
go

CREATE PROCEDURE USP_Facultad_BuscarGeneral
AS
 BEGIN
   SELECT id_FAC Codigo, strNombre_FAC Nombre
   FROM tblFACultad
   ORDER BY Nombre
   --EXEC USP_Facultad_BuscarGeneral
 END

GO

CREATE PROCEDURE USP_Programa_LlenarCombo
@idFac int

AS
 BEGIN
   SELECT id_PRO Codigo, strNombre_PRO Nombre
   FROM tblPROgrama
   WHERE idFAC_PRO = @idFAC
   ORDER BY Nombre
   --EXEC USP_Programa_LlenarCombo
 END
GO

CREATE PROCEDURE USP_Asignatura_LlenarCombo
@idPrograma int


AS
 BEGIN
   SELECT id_ASI Codigo, strNombre_ASI Nombre
   FROM tblASIgnatura
   WHERE idPRO_ASI = @idPrograma
   ORDER BY Nombre
   -- EXEC USP_Asignatura_LlenarCombo
 END
GO

CREATE PROCEDURE USP_Periodo_LlenarCombo

AS
 BEGIN
  SELECT id_PER Codigo, strNombre_PER Nombre
  FROM tblPERiodo
  ORDER BY Nombre
  --EXEC USP_Periodo_LlenarCombo
 END
GO

CREATE PROCEDURE USP_Jornada_BuscarGeneral
AS
  BEGIN
    SELECT id_JOR Codigo, strNombre_JOR Nombre
	FROM tblJORnada
	ORDER BY Codigo
	--EXEC USP_Jornada_BuscarGeneral
  END
GO

CREATE PROCEDURE USP_Estudiante_BuscarXCodigo
@strCodigo Varchar(10)
AS
 BEGIN
   SELECT id_EST as Codigo,
          intNroDOC_EST as Nro_Doc,
		  strNombre_EST as Nombre,
		  idFAC_PRO as idFac,
		  idPRO_EST as idPro,
		  blnActivo_EST as Activo,
		  idJOR_EST as idJor,
		  strObservac_EST as Observaciones,
		  strNombre_PRO as Programa
  FROM  tblESTudiante inner join tblPROgrama ON id_PRO = idPRO_EST
  WHERE id_EST = @strCodigo
  --EXEC USP_Estudiante_BuscarXCodigo
  END
GO

CREATE PROCEDURE USP_Estudiante_Grabar
@strCodigo varchar(10),
@intNroDoc int,
@strNombre varchar(50),
@intPrograma int,
@bitActivo bit,
@intidjor int,
@strObserv varchar(500)

AS
 BEGIN
   IF EXISTS(SELECT * 
             FROM tblESTudiante
			 WHERE id_EST = @strCodigo)

		Begin
		 SELECT -1 AS Rpta
		 return
		END
  ELSE
   Begin
     BEGIN TRANSACTION tx
	  INSERT INTO tblESTudiante
	     VALUES(@strCodigo, @intNroDoc,
		        @strNombre, @intPrograma, @bitActivo,
				@intidjor, @strObserv);
		IF (@@ERROR > 0)
		 BEGIN
		 ROLLBACK TRANSACTION tx
		 SELECT 0 AS Rpta
		 return
		 END
		COMMIT TRANSACTION tx
		SELECT @strCodigo AS Rpta --SELECT @@identity AS Rpta
		Return
	   END
	--EXEC USP_Estudiante_Grabar '09201010','98100100','Juan Diaz', 50, 1, 3, null
	END
GO

CREATE PROCEDURE USP_Estudiante_Modificar
@strCodigo varchar(10),
@intNroDoc int,
@strNombre varchar(50),
@intPrograma int,
@bitActivo bit,
@intidjor int,
@strObserv varchar(500)

AS
 BEGIN
  BEGIN TRANSACTION tx
    UPDATE tblESTudiante
	   SET intNroDoc_EST = @intNroDoc,
	       strNombre_EST = @strNombre,
		   idPRO_EST = @intPrograma,
		   blnActivo_EST = @bitActivo,
		   idJOR_EST = @intidjor,
		   strObservac_EST = @strObserv
		WHERE id_EST = @strCodigo
	IF(@@ERROR > 0)
	 Begin
	 ROLLBACK TRANSACTION tx
	 SELECT 0 AS Rpta
	 return
	End
   COMMIT TRANSACTION tx
   SELECT @strCodigo AS Rpta
   return
   --EXEC USP_Estudiante_Modificar '09201010','98100100',''Juan Diaz',50,1,3,'T'
   --EXEC USP_Estudiante_BuscarXCodigo '09201010'
   END
go
		 


CREATE PROCEDURE USP_Estudiante_Buscar_Imprimir
@strCodigo varchar(10)

AS
 BEGIN
   SELECT id_EST as Codigo,
          intNroDoc_EST as nto_Doc,
		  strNombre_EST as Nombre,
		  strNombre_FAC as Facultad,
		  strNombre_PRO as Programa,
		  CASE blnActivo_EST
		    WHEN '1' THEN 'Si'
			ELSE 'No' END as Activo,
		  strNombre_JOR as Jornada,
		  strObservac_EST as Observaciones
	FROM  tblESTudiante inner join tblPROgrama ON id_PRO = idPRO_EST
	                    inner join tblFACultad ON id_FAC = idFAC_PRO
						inner join tblJORnada ON idJOR_EST = id_JOR
	WHERE id_EST = @strCodigo
	--EXEC USP_Estudiante_Buscar_Imprimir '10101010'
 END
GO

CREATE  PROCEDURE USP_Matricula_Buscar
@strCarnet varchar(10),
@strPeriodo int
AS
  BEGIN
    SELECT strNombre_EST as Estudiante,
	       idPRO_EST as Programa
	FROM tblMATricula
	     inner join tblESTudiante ON idEST_MAT = id_EST
    WHERE idEST_MAT = @strCarnet AND idPER_MAT = @strPeriodo
	--EXEC USP_Matricula_Buscar '10101010', 59
	END
GO

CREATE PROCEDURE USP_Matricula_LlenarGrid
@strCarnet varchar(10),
@strPeriodo int
AS
  BEGIN
     SELECT strNombre_PER as Periodo,
	        strNombre_ASI as Asignatura,
			dtmFecha_MAT as Fecha
	FROM tblMATricula
	        inner join tblPERiodo ON idPER_MAT = id_PER
			inner join tblASIgnatura ON id_ASI = idASI_MAT
	WHERE   idEST_MAT = @strCarnet AND idPER_MAT = @strPeriodo
  --EXEC USP_Matricula_LlenarGrid '10101010' 59
  END
GO


create procedure USP_Matricula_Grabar
@intPeriodo int,
@strCarnet varchar(10),
@strAsig varchar(8)
AS
begin
IF EXISTS(select *
           FROM tblMATricula
		   where idPER_MAT=@intPeriodo AND
		         idEST_MAT=@strCarnet AND
				 idASI_MAT=@strAsig)
begin
select-1 AS Rpta
return
END
ELSE
Begin
begin TRANSACTION tx
insert into tblMATricula
                        (dtmFecha_Mat, idPER_MAT,
						 idEst_MAT, idASI_MAT)
           Values(getdate(), @intPeriodo,@strCarnet,@strAsig);
IF(@@ERROR>0)
begin
ROLLBACK TRANSACTION tx
select 0 as Rpta
return
End
Commit transaction tx
select @strcarnet As Rpta--Select @@identity as Rpta
Return
END
--USP_Matricula_Grabar 59,'10101010','BDI44'
END
Go

CREATE PROCEDURE USP_Matricula_Buscar_Imprimir
@strCarnet varchar(10),
@strPeriodo int

AS
 BEGIN
   SELECT id_EST as Carne,
          intNroDoc_EST as Nro_DOC,
          strNombre_EST as Nombre,
          strNombre_FAC as Facultad,
          strNombre_PRO as Programa,
          @strPeriodo as Periodo
   FROM tblESTudiante
       inner join tblPROgrama ON idPRO_EST = id_PRO
	   inner join tblFACultad ON idFAC_PRO = id_FAC
   WHERE id_EST = @strCarnet

   SELECT strNombre_PER as Periodo,
          strNombre_ASI as Asignatura,
		  dtmFecha_MAT as Fecha_Matricula
   FROM   tblMATricula
          inner join tblPERiodo ON idPER_MAT = id_PER
		  inner join tblASIgnatura ON id_ASI = idASI_MAT
   WHERE  idEST_MAT = @strCarnet AND
          idPER_MAT = @strPeriodo
	--EXEC USP_Matricula_Buscar_Imprimir '10101010' 59
END
GO

CREATE PROCEDURE USP_EstudianteXFacultad
@intFact int
AS
 BEGIN
   SELECT pro.strNombre_PRO as Programa,
          est.id_EST as Carnet,
		  Est.strNombre_EST AS Nombres,
		  jor.strNombre_JOR as Jornada
   FROM   tblESTudiante Est
          inner join tblPROgrama Pro ON Est.idPRO_EST = pro.id_PRO
		  inner join tblFACultad Fac ON Pro.id_PRO = fac.id_FAC
		  inner join tblJORnada Jor ON est.idJOR_EST = Jor.id_JOR
   WHERE fac.id_FAC = @intFact
   ORDER BY Carnet
   --EXEC USP_EstudianteXFacultad 1
END
go




