CREATE DATABASE matriculas

go
USE matriculas
go
CREATE TABLE cursosmatriculad
(
ced int,
codigocur int,
idperiodo int,
idjornada int,
idpago int,
estado decimal(18,0),
codEmpleado int,
PRIMARY KEY(ced,codigocur,idperiodo,idjornada)
)
go

CREATE TABLE jornada
(
id int primary key NOT NULL,
nombre varchar(255),
codEmpleado int
)
go


CREATE TABLE Materiajornada
(
idjornada int NOT NULL,
idcurso int, 
codprof int,
codEmpleado int
)
go

CREATE TABLE periodo
(
id int Primary Key NOT NULL,
nombre varchar(30) NOT NULL,
codEmpleado int
)
---------------------------------------
go
CREATE TABLE prerequicito
(
codcurso int ,
codrequicito int,
Esrequicito bit,
codEmpleado int,
PRIMARY KEY(codcurso,codrequicito)
)
go
CREATE TABLE profesores
(
codprof int primary key not null,
cedula int,
nombre varchar(255),
telefono int,
fechaIngreso date,
codEmpleado int
)
go
CREATE TABLE cursos
(
codigo int primary key not null,
titulo varchar(50),
numeroHoras int,
valor decimal(18,0),
codEmpleado int
)
go
CREATE TABLE formapagos
(
id int primary key not null,
nombre varchar(70),
codEmpleado int
)
go
CREATE TABLE clientes
(
	cedula int primary key not null,
	nombre varchar(70),
	apellidos varchar(70),
	direccion varchar(70),
	telefono int,
	codEmpleado int
)
go
CREATE TABLE empleados
(
	codEmpleado int primary key not null,
	usuario varchar(50),
	password varchar(255),
	nombre varchar(70),
	direccion varchar(70),
	telefono int
)
go

CREATE TABLE temas
(
	id int primary key not null,
	titulo varchar(55),
	descripcion varchar(255),
	codEmpleado int
)
go

go
CREATE TABLE Materiatemas
(
	codcurso int,
	idtema int,
	codEmpleado int,
	PRIMARY KEY(codcurso,idtema)
)
go

ALTER TABLE cursosmatriculad -- ADD CLAVE FORANEA
ADD FOREIGN KEY (codigocur)	
REFERENCES cursos(codigo) 

ALTER TABLE cursosmatriculad -- ADD CLAVE FORANEA
ADD FOREIGN KEY (ced)	
REFERENCES clientes(cedula)  

ALTER TABLE cursosmatriculad -- ADD CLAVE FORANEA
ADD FOREIGN KEY (idpago)	
REFERENCES formapagos(id)

ALTER TABLE prerequicito -- ADD CLAVE FORANEA
ADD FOREIGN KEY (codcurso)	
REFERENCES cursos(codigo) 

ALTER TABLE prerequicito -- ADD CLAVE FORANEA
ADD FOREIGN KEY (codrequicito)	
REFERENCES cursos(codigo) 

ALTER TABLE Materiatemas -- ADD CLAVE FORANEA
ADD FOREIGN KEY (codcurso)	
REFERENCES cursos(codigo)  

ALTER TABLE Materiatemas -- ADD CLAVE FORANEA
ADD FOREIGN KEY (idtema)	
REFERENCES temas(id)  


ALTER TABLE cursosmatriculad -- ADD CLAVE FORANEA
ADD FOREIGN KEY (idperiodo)	
REFERENCES periodo(id)  

ALTER TABLE cursosmatriculad -- ADD CLAVE FORANEA
ADD FOREIGN KEY (idjornada)	
REFERENCES jornada(id) 

ALTER TABLE Materiajornada -- ADD CLAVE FORANEA
ADD FOREIGN KEY (idjornada)	
REFERENCES jornada(id) 

ALTER TABLE Materiajornada -- ADD CLAVE FORANEA
ADD FOREIGN KEY (idcurso)	
REFERENCES cursos(codigo) 

----
ALTER TABLE cursosmatriculad -- ADD CLAVE FORANEA
ADD FOREIGN KEY (codEmpleado)	
REFERENCES empleados(codEmpleado)  

ALTER TABLE prerequicito -- ADD CLAVE FORANEA
ADD FOREIGN KEY (codEmpleado)	
REFERENCES empleados(codEmpleado)  

ALTER TABLE profesores -- ADD CLAVE FORANEA
ADD FOREIGN KEY (codEmpleado)	
REFERENCES empleados(codEmpleado)  

ALTER TABLE cursos -- ADD CLAVE FORANEA
ADD FOREIGN KEY (codEmpleado)	
REFERENCES empleados(codEmpleado)  

ALTER TABLE formapagos -- ADD CLAVE FORANEA
ADD FOREIGN KEY (codEmpleado)	
REFERENCES empleados(codEmpleado)  

ALTER TABLE clientes -- ADD CLAVE FORANEA
ADD FOREIGN KEY (codEmpleado)	
REFERENCES empleados(codEmpleado)  

ALTER TABLE Materiatemas -- ADD CLAVE FORANEA
ADD FOREIGN KEY (codEmpleado)	
REFERENCES empleados(codEmpleado) 

ALTER TABLE temas -- ADD CLAVE FORANEA
ADD FOREIGN KEY (codEmpleado)	
REFERENCES empleados(codEmpleado)  

ALTER TABLE jornada -- ADD CLAVE FORANEA
ADD FOREIGN KEY (codEmpleado)	
REFERENCES empleados(codEmpleado)  

ALTER TABLE Materiajornada -- ADD CLAVE FORANEA
ADD FOREIGN KEY (codEmpleado)	
REFERENCES empleados(codEmpleado) 

ALTER TABLE periodo -- ADD CLAVE FORANEA
ADD FOREIGN KEY (codEmpleado)	
REFERENCES empleados(codEmpleado)  

go

-- inserts testings ----

INSERT INTO  empleados 
VAlUES (1, 'sergio','559D555C374C5625','sergio andres','cr 88',5703940);

INSERT INTO  profesores 
VAlUES (1, 115268877,'alberto',5808090,'02/02/13',1),
(2, 115268878,'mario',5809090,'02/12/13',1);


INSERT INTO  cursos 
VAlUES (1,'python',4,100000,1), (2,'CSharp',4,150000,1),
(3,'Android',2,250000,1);

INSERT INTO  formapagos 
VAlUES (1,'debito',1);

INSERT INTO  clientes
VAlUES (1152689777,'lalio najapeta','apu','cr 88 tienda principal',5111111,1),
(1152689778,'homero','pacha','cr 90 avenida siempre viva',5222222,1);

--periodo
--jornada
INSERT INTO periodo VALUES (1,'2012-1',1)
INSERT INTO jornada VALUES (1,'Noche',1),(2,'Tarde',1),(3,'Noche',1);
INSERT INTO Materiajornada VALUES (1,1,1,1), (2,1,2,1),(3,2,2,1),(1,3,1,1);


INSERT INTO  cursosmatriculad
VAlUES (1152689777,1,1,1,1,100000,1);

INSERT INTO temas VALUES 
(1,'Programacion multiplataforma',
	'poder programar sin problemas de compativilidad',1),
(2,'Programacion para windows',
	'programa para el SO mas demandado',1),
(3,'Programacion para dispositivos moviles',
	'programa navitamente para el SO mas utilizado en moviles',1)



INSERT INTO Materiatemas VALUES (1,1,1),(1,2,1),(2,2,1),(3,3,1);
INSERT INTO prerequicito VALUES (2,1,1,1),(3,2,1,1);

--ALTER TABLE LIBRO -- ADD CLAVE FORANEA
--ADD FOREIGN KEY (CODGENERO)	
--REFERENCES GENERO(CODIGO) 

go
CREATE procedure Valida_Requicito
@codMateria int,
@Cedula int
AS
DECLARE @CodRequicito INT
DECLARE @NomRequicito varchar(50)

DECLARE MICURSOR CURSOR FOR
		select codrequicito
           FROM prerequicito
		   where codcurso=@codMateria AND
		         Esrequicito=1
	OPEN MICURSOR
	FETCH MICURSOR INTO @CodRequicito
		WHILE (@@FETCH_STATUS =0)
			BEGIN 
					IF NOT EXISTS(select *
							   FROM cursosmatriculad
							   WHERE ced=@Cedula AND
								codigocur=@CodRequicito) begin
						select @NomRequicito=titulo from cursos where codigo=@CodRequicito
						select 'Necesita matricular antes la materia '+@NomRequicito as requicito
						CLOSE MICURSOR
						DEALLOCATE MICURSOR
						return
						end
				FETCH MICURSOR INTO @CodRequicito
			END
			select '1' as bien
			CLOSE MICURSOR
	DEALLOCATE MICURSOR


--exec Valida_Requicito 2, 1152689777


go

CREATE PROCEDURE GetCurso
@codigo int
AS
 BEGIN
 SELECT C.*,idtema FROM cursos C INNER JOIN Materiatemas ON codcurso = C.codigo WHERE codigo=@codigo
  --EXEC GetCurso 1
  END
GO


CREATE PROCEDURE Login
@usuario varchar(50),
@password varchar(255)
AS
 BEGIN
 SELECT codEmpleado FROM empleados WHERE usuario=@usuario AND password=@password
  --EXEC Login sergio, Encrypta(@password)
  END
GO



--SELECT codEmpleado FROM empleados WHERE usuario='"+usuario+"' AND password='"+password+"' 



go

CREATE PROCEDURE GetTemas
AS
 BEGIN
 select id,titulo from temas
  --EXEC GetTemas
  END
GO



CREATE PROCEDURE UpdateTemas
@codcurso int,
@idtema int,
@codEmpleado int

AS
 BEGIN
   IF EXISTS(SELECT * 
             FROM Materiatemas
			 WHERE codcurso = @codcurso AND idtema=@idtema) 
		Begin
		 SELECT -1 AS Rpta
		 return
		END
  ELSE
   Begin
     BEGIN TRANSACTION tx
	  INSERT INTO Materiatemas VALUES (@codcurso,@idtema,@codEmpleado);
		IF (@@ERROR > 0)
		 BEGIN
		 ROLLBACK TRANSACTION tx
		 SELECT 0 AS Rpta
		 return
		 END
		COMMIT TRANSACTION tx
		SELECT @codcurso AS Rpta --SELECT @@identity AS Rpta
		Return
	   END
	--EXEC UpdateTemas 3,1,1
	END
	go


  


CREATE PROCEDURE UpdateCurso
@codigo int,
@valor decimal(18, 0),
@titulo varchar(50),
@numeroHoras int,
@codEmpleado int
AS
 BEGIN
  BEGIN TRANSACTION tx
    UPDATE cursos 
    SET titulo=@titulo, numeroHoras=@numeroHoras,valor=@valor ,
     codEmpleado=@codEmpleado 
     WHERE codigo=@codigo;
     DELETE FROM Materiatemas WHERE codcurso=@codigo;
	IF(@@ERROR > 0)
	 Begin
	 ROLLBACK TRANSACTION tx
	 SELECT 0 AS Rpta
	 return
	End
   COMMIT TRANSACTION tx
   SELECT @codigo AS Rpta
   return
   --EXEC UpdateCurso 1, 50000, 'python !!!' ,7,1
   END
go



CREATE PROCEDURE LlenaComboCurso

AS
 BEGIN
 select titulo,codigo from cursos
  --EXEC LlenaComboCurso
  END
GO

CREATE PROCEDURE LlenaComboPeriodo

AS
 BEGIN
 select id,nombre from periodo
  --EXEC LlenaComboPeriodo
  END
GO


CREATE PROCEDURE LlenaComboJornada
@id int
AS
 BEGIN
 select idjornada,nombre from Materiajornada M INNER JOIN jornada j ON M.idjornada=j.id WHERE m.idcurso=@id
  --EXEC LlenaComboJornada 1
  END
GO


CREATE PROCEDURE LlenaComboFormaPagos

AS
 BEGIN
 select id,nombre from formapagos
  --EXEC LlenaComboFormaPagos
  END
GO


CREATE PROCEDURE GetMatricula
@cedula int,
@codcurso int
AS
 BEGIN
 select * from cursosmatriculad where ced=@cedula AND codigocur=@codcurso;
  --EXEC GetMatricula 152689760, 1
  END
GO



CREATE PROCEDURE UpdateMatricula
@ced int,
@codigocur int,
@idperiodo int,
@idjornada int,
@idpago int,
@estado decimal(18, 0),
@codEmpleado int
AS
 BEGIN
  BEGIN TRANSACTION tx
    UPDATE cursosmatriculad 
    SET codigocur=@codigocur, idperiodo=@idperiodo, idjornada=@idjornada,
    idpago=@idpago, estado=@estado, codEmpleado=@codEmpleado 
    WHERE ced=@ced AND codigocur=@codigocur
	IF(@@ERROR > 0)
	 Begin
	 ROLLBACK TRANSACTION tx
	 SELECT 0 AS Rpta
	 return
	End
   COMMIT TRANSACTION tx
   SELECT @codigocur AS Rpta
   return
   --EXEC UpdateMatricula ced, codigocur, idperiodo ,idjornada,idpago,estado,codEmpleado
   END
GO

CREATE PROCEDURE InsertMatricula
@ced int,
@codigocur int,
@idperiodo int,
@idjornada int,
@idpago int,
@estado decimal(18, 0),
@codEmpleado int

AS
 BEGIN
   IF EXISTS(SELECT * 
             FROM cursosmatriculad
			 WHERE codigocur = @codigocur AND ced=@ced) 
		Begin
		 SELECT -1 AS Rpta
		 return
		END
  ELSE
   Begin
     BEGIN TRANSACTION tx
	   INSERT INTO cursosmatriculad VAlUES (@ced,@codigocur,@idperiodo,@idjornada,@idpago,@estado,@codEmpleado);
		IF (@@ERROR > 0)
		 BEGIN
		 ROLLBACK TRANSACTION tx
		 SELECT 0 AS Rpta
		 return
		 END
		COMMIT TRANSACTION tx
		SELECT @codigocur AS Rpta --SELECT @@identity AS Rpta
		Return
	   END
	--EXEC InsertMatricula ced, codigocur, idperiodo ,idjornada,idpago,estado,codEmpleado
	END
	go

-----------------------------------------------------------------------------------------
CREATE PROCEDURE InsertCurso
@codigo int,
@valor decimal(18, 0),
@titulo varchar(50),
@numeroHoras int,
@codEmpleado int
AS
 BEGIN
   IF EXISTS(SELECT * 
             FROM cursos
			 WHERE codigo = @codigo) 
		Begin
		 SELECT -1 AS Rpta
		 return
		END
  ELSE
   Begin
     BEGIN TRANSACTION tx
	  INSERT INTO cursos VAlUES (@codigo,@titulo,@numeroHoras,@valor,@codEmpleado)
		IF (@@ERROR > 0)
		 BEGIN
		 ROLLBACK TRANSACTION tx
		 SELECT 0 AS Rpta
		 return
		 END
		COMMIT TRANSACTION tx
		SELECT @codigo AS Rpta --SELECT @@identity AS Rpta
		Return
	   END
	--EXEC InsertCurso 4,50000,'HTML',4,1
	END
	GO



CREATE PROCEDURE GridCursos
AS
  BEGIN
      SELECT codigo,titulo as 'Materia',
	  numeroHoras as 'Numero de Horas',valor as 'Costo',nombre as 'nombre Empleado'  
	  FROM cursos 
	  inner join empleados on empleados.codEmpleado = cursos.codEmpleado
    -- EXEC GridCursos 
  END
GO


CREATE PROCEDURE GridMatriculas
AS
  BEGIN
      SELECT clientes.nombre as 'Nombre Estudiante',clientes.apellidos,cursos.titulo as 'Nombre del curso',
	  periodo.nombre as 'Nombre del periodo',jornada.nombre as 'Jornada',formapagos.nombre as 'Tipo de pago',
	  cursosmatriculad.estado as 'Estado actual',empleados.nombre as 'Nombre del empleado'
	  FROM cursosmatriculad 
	  inner join cursos ON cursosmatriculad.codigocur = cursos.codigo
	  inner join periodo ON cursosmatriculad.idperiodo = periodo.id
	  inner join jornada ON cursosmatriculad.idjornada = jornada.id
	  inner join formapagos ON cursosmatriculad.idpago = formapagos.id
	  inner join empleados ON cursosmatriculad.codEmpleado = empleados.codEmpleado
	  inner join clientes ON cursosmatriculad.ced = clientes.cedula
    -- EXEC GridMatriculas
  END

GO


CREATE FUNCTION dbo.getCommonFields
(
@ID int
)
RETURNS varchar(1000)
AS
BEGIN
 
DECLARE @valores VARCHAR(1000)
SELECT @valores= COALESCE(@valores + ', ', '') + temas.titulo FROM Materiatemas inner join temas on Materiatemas.idtema = temas.id where codcurso=@id
RETURN @valores
END









	select * from cursos
	select * from Materiatemas
	select * from temas

	select * from clientes
	select * from prerequicito
	select * from cursosmatriculad
	select * from periodo
	select * from jornada
	select * from Materiajornada
	