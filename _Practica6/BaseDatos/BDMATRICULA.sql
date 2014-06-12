CREATE DATABASE BDMatricula
go
USE BDMatricula
go
CREATE TABLE tblPrograma
( id_PRO int Primary key not Null,
  idFAC_PRO int not null,
  strNombre_PRO varchar(30) not Null
)
go
CREATE TABLE tblJORnada
(
id_Jor int Primary key NOT NULL,
strNombre_Jor varchar(10) NOT NULL
)
go
CREATE TABLE tblEstudiante
(
id_Est varchar(10) Primary key NOT NULL,
intNroDoc_EST int NOT NULL,
strNombre_EST varchar(50) NOT NULL,
idPRO_EST int NOT NULL,
blnActivo_EST bit default 1 NOT NULL,
idJOR_EST int NOT NULL,
strObservac_EST varchar(500) Null
)
go
CREATE TABLE tblMATricula
(
id_MAT int identity(1,1) Primary key Not null,
dtmFecha_Mat datetime default getdate(),
idPER_MAT int Not Null,
idEst_MAT varchar(10) NOT NULL,
idASI_MAT varchar(8) Not Null
)
go
CREATE TABLE tblFacultad
(
id_FAC int Primary key NOT NULL,
strNombre_Fac varchar(30) Not NULL
)
go
CREATE TABLE tblAsignatura
(
id_ASI varchar(8) Primary key not null,
idPRO_ASI int not NULL,
strNombre_ASI varchar(50) NOt Null
)
go
CREATE TABLE tblPEriodo
(
id_PER int Primary key not NULL,
strNombre_PER varchar(30) not NULL
)
go

ALTER TABLE tblPrograma add Foreign key(idFAC_PRO ) REFERENCES tblFacultad(id_FAC)
ALTER TABLE tblAsignatura add Foreign key(idPRO_ASI) REFERENCES tblPrograma( id_PRO)
ALTER TABLE tblEstudiante add Foreign key(idJOR_EST) REFERENCES tblJORnada(id_Jor)
ALTER TABLE tblMATricula add Foreign key(idPER_MAT) REFERENCES tblPEriodo(id_PER)
ALTER TABLE tblMATricula add Foreign key(idEst_MAT) REFERENCES  tblEstudiante(id_Est)
ALTER TABLE tblMATricula add Foreign key(idASI_MAT) REFERENCES tblAsignatura(id_ASI)
ALTER TABLE tblEstudiante add Foreign key(idPRO_EST) REFERENCES tblPrograma(id_PRO)
go
INSERT INTO tblFacultad values (1,'Tecnologias'),(2,'Ingenierias');

INSERT INTO tblPrograma values(10, 1, 'Tec. Sistemas de informacion');
INSERT INTO tblPrograma values(20, 2, 'Ing. de sistemas');
INSERT INTO tblPrograma values(30, 1, 'Tecn. En telecomunicaciones');
INSERT INTO tblPrograma values(40,2,'Ing. de Telecomunicaciones');
INSERT INTO tblPrograma values(50,1,'Tecn. Electromecánica');
INSERT INTO tblPrograma values(60,2,'Ing.Electromecánica');
INSERT INTO tblPrograma values(70,1,'Tecn. en calidad');

INSERT INTO tblAsignatura values('BDI44',10, 'Base de Datos');
INSERT INTO tblAsignatura values('PAI74',20, 'Programacion Avanzada');
INSERT INTO tblAsignatura values('CXT34',30, 'Circuitos Digitales I');
INSERT INTO tblAsignatura values('ANT32',40, 'Antenas I');
INSERT INTO tblAsignatura values('MQN22',50, 'Maquinas');
INSERT INTO tblAsignatura values('MAT24',60, 'Materiales I');
INSERT INTO tblAsignatura values('MTL44',70, 'Metrología');
INSERT INTO tblAsignatura values('DSI54',10, 'Desarrollo de SoftWare Empresarial');
INSERT INTO tblAsignatura values('ACI82',20, 'Arquitectura de Computadores');
INSERT INTO tblAsignatura values('CXT44',30, 'Circuitos Digitales II');
INSERT INTO tblAsignatura values('ANT42',40, 'Antenas II');
INSERT INTO tblAsignatura values('CNT34',50, 'Controles Digitales');
INSERT INTO tblAsignatura values('MAT34',60, 'Materiales I');
INSERT INTO tblAsignatura values('EST14',70, 'Estadistica');

INSERT INTO tblPEriodo values(55,'2012-1'),(56,'2012-2'),(57,'2013-1');
INSERT INTO tblPEriodo values(58,'2013-2'),(59,'2014-1'),(60,'2014-2');

INSERT INTO tblJORnada values (1,'Mañana'),(2,'Tarde'),(3,'Noche'),(4,'única');

INSERT INTO  tblEstudiante values('10101010',70500600,'Roberto Melendez D.',10,1,1,'Ppto Partic.');
INSERT INTO  tblEstudiante values('10102020',1020500600,'Mario A. Martinez',20,1,2,'Fondo EPM');
INSERT INTO  tblEstudiante values('10102021',32100100,'Natalia Castrillon',70,1,3,'');

INSERT INTO  tblEstudiante values('90909090',457450600,'Ruben Dario Soto',30,1,1,'Prueba');
INSERT INTO  tblEstudiante values('40404040',456500600,'Mariana Aguirre',50,1,2,'Reserva');
INSERT INTO  tblEstudiante values('50505051',86100100,'Jazmin Angarita',70,1,3,'Ppto Partic.');
go
--==FACULTAD==--
create procedure USP_Facultad_BuscarGeneral
As
begin 
 select id_FAC  codigo,
  strNombre_FAC Nombre
  From tblFacultad
order by Nombre
--EXEC USP_Facultad_BuscarGeneral
END
Go
--==PROgrama==--
create procedure USP_Programa_llenarCombo
@idFac int
AS
BEGIN
 select id_PRO codigo,
        strNombre_PRO Nombre
		From tblPrograma
where idFAC_PRO=@idFac
Order by Nombre
--EXEC USP_Programa_llenarCombo 1
ENd
Go

--==Asignatura--==
create procedure USP_Asignatura_llenarCombo
@idPrograma int
As
BEGIN
 SELECT id_ASI    codigo,
 strNombre_ASI Nombre
 FROM tblAsignatura
 where idPRO_ASI=@idPrograma
 Order by Nombre
 --EXEC USP_Asignatura_llenarCombo 10
 END
 Go

 --==PERIODO=--
 create procedure USP_Periodo_LlenarCombo
 AS
 Begin
 select id_PER codigo,
        strNombre_PER Nombre
		FROM tblPEriodo
		Order by Nombre

--EXEC USP_Periodo_LlenarCombo
END
Go
--==JORNADA==--
create PROCEDURE USP_jornada_BuscarGeneral
AS
Begin
SELECT id_JOR codigo,
strNombre_JOR Nombre
FROM tblJORnada
order By codigo
--EXEC USP_jornada_BuscarGeneral
END
Go

--==Estudiante==--
create procedure USP_Estudiante_BuscarXCodigo
@strCodigo varchar(10)
AS
Begin
select id_EST as Codigo,
       intNroDoc_EST Nro_Doc,
	   strNombre_EST Nombre,
	   idFAC_PRO idFac,
	   idPRO_EST idPro,
	   blnActivo_EST Activo,
	   idJOR_EST idjor,
	   strObservac_EST Observaciones,
	   strNombre_PRO Programa
	   FROM tblEstudiante
	      inner join tblPrograma ON id_PRO=idPRO_EST
	 where id_EST=@strCodigo
	 --EXEC USP_Estudiante_BuscarXCodigo '10101010';
END
Go

create procedure USP_Estudiante_Grabar
@strCodigo varchar(10),
@intNroDoc int,
@strNombre varchar(50),
@intPrograma int,
@bitActivo bit,
@intldjor int,
@strObserv varchar(500)

AS
BEGIN
IF EXISTS(SELECT *
                 FROM tblEstudiante
				 where id_EST=@strCodigo)
begin
select-1 AS Rpta
return
end
ELSE
BEGIN
BEGIN TRANSACTION tx
  insert into tblEstudiante
              values(@strCodigo,@intNroDoc,
			         @strNombre,@intPrograma,@bitActivo,
					 @intldjor,@strObserv);
IF(@@ERROR>0)
BEGIN
ROLLBACK TRANSACTION tx
SELECT 0 AS Rpta
return
End
COMMIT TRANSACTION tx
select  @strCodigo AS Rpta --Select @@identity as Rpta
return
END
--EXEC USP_Estudiante_Grabar '09090909',71458632,'Rocardo Corazón de León',70,1,2,'Test'
ENd
Go

create procedure USP_Estudiante_Modificar
@strCodigo Varchar (10),
@intNroDoc int,
@strNombre varchar(50),
@intPrograma int,
@bitActivo bit,
@intldjor int,
@strObserv varchar(500)

As
BEGIN
BEGIN TrANSACTION tx
 Update tblEstudiante
 set intNroDoc_EST=@intNroDoc,
     strNombre_EST=@strNombre,
	 idPRO_EST=@intPrograma,
	 blnActivo_EST=@bitActivo, 
	 idJOR_EST=@intldjor,
	 strObservac_EST=@strObserv
where id_Est=@strCodigo
IF(@@ERROR>0)
begin
ROLLBACK TRANSACTION tx
select 0 AS RPTA
return
END
Commit transaction tx
select @strCodigo As Rpta
return
--EXEC USP_Estudiante_Modificar'09090909',71458632,'Juan Diaz',60,1,4,'Otro test'
--EXEC  USP_Estudiante_BuscarXCodigo '09090909'
ENd
Go

create procedure USP_Estudiante_Buscar_Imprimir
@strCodigo varchar (10)
AS
Begin
 select id_Est as Codigo,
        intNroDoc_EST as Nro_Doc,
		strNombre_EST as Nombre,
		strNombre_FAC as Facultad,
		strNombre_PRO as Programa,
		CASE blnActivo_EST
		   WHEN '1' THEN 'Si'
		   ELSE 'No' END as Activo,
		strNombre_JOR as jornada,
		strObservac_EST as Observaciones
FROM  tblEstudiante
inner join tblPrograma on id_PRO=idPRO_EST
inner join tblFacultad on id_FAC=idFAC_PRO
inner join tblJORnada  on idJOR_EST=id_JOR
where id_EST=@strCodigo
--EXEC USP_Estudiante_Buscar_Imprimir '10101010'
END
Go

--==MATRICULA==--
create procedure USP_MATRICULA_BUSCAR
@strCarnet varchar(10),
@strPeriodo int
as 
begin
select strNombre_EST as Estudiante,
idPRO_EST as programa
FROM tblMATricula
inner join tblEstudiante on idEst_MAT=id_Est
where idEst_MAT=@strCarnet And idPER_MAT=@strPeriodo
--EXCE USP_MATRICULA_BUSCAR '10101010', 59
ENd
GO

Create Procedure USP_Matricula_llenarGrid
@strCarnet Varchar(10),
@strPeriodo int 
as
begin
select strNombre_PER as Periodo,
       strNombre_ASI as Asignatura,
	   dtmFecha_MAT as Fecha
	   FROM tblMATricula
	   inner join tblPEriodo on idPER_MAT=id_PER
	   inner join tblAsignatura on id_ASI=idASI_MAT
where idEst_MAT=@strCarnet AND idPER_MAT=@strPeriodo
--EXEC USP_Matricula_llenarGrid '10101010',59
END
GO

DROP PROCEDURE USP_Matricula_llenarGrid

create procedure USP_MATRICULA_GRABAR
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
--EXCE USP_MATRICULA_GRABAR 59,'10101010','BDI44'
END
Go


create procedure USP_Matricula_Buscar_Imprimir
@strCarnet varchar(10),
@strPeriodo int

AS
begin
select id_Est as carné,
       intNroDoc_EST as Nro_Doc,
	   strNombre_EST as Nombre,
	   strNombre_FAC as Facultad,
	   strNombre_PRO as Programa,
	   @strPeriodo as Periodo
	   FROM tblEstudiante
	        inner join tblPrograma on idPRO_EST=id_PRO
			inner join tblFacultad on idFAC_PRO=id_FAC
			where id_EST=@strCarnet
		Select strNombre_PER as Periodo,
		strNombre_ASI as Asignatura,
		dtmFecha_MAT as Fecha_Matricula
		FROM tblMATricula
		   inner join tblPEriodo on idPER_MAT=id_PER
		   inner join tblAsignatura on id_ASI=idASI_MAT
	where idEst_MAT=@strCarnet AND
	       idPER_MAT=@strPeriodo

--EXEC USP_Matricula_Buscar_Imprimir '10101010',59
ENd
GO

create procedure usp_EstudianteXFactura
@intFac int 
as
begin
select pro.strNombre_PRO as Programa,
est.id_EST as Carnet,
Est.strNombre_EST as Nombres,
jor.strNombre_JOR as jornada
FROM tblEstudiante Est
inner join tblPrograma Pro on Est.idPRO_EST=pro.id_PRO
inner join tblFacultad Fac on Pro.idFAC_PRO=fac.id_FAC
inner join tblJORnada jor on est.idJOR_EST=jor.id_Jor
where fac.id_FAC=@intFac
order by Carnet
--EXEC usp_EstudianteXFactura
ENd
Go
						 