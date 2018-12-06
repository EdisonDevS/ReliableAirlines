
CREATE DATABASE ReliableAirlines

GO

USE ReliableAirlines

GO

CREATE TABLE USUARIO
(
	documento VARCHAR(11) PRIMARY KEY NOT NULL,
	tipoDocumento VARCHAR(3) NOT NULL,
	usuario VARCHAR(20) NOT NULL,
	contrase�a VARCHAR(32) NOT NULL,
	permisos VARCHAR(4) NOT NULL,
	nombres VARCHAR(30) NOT NULL,
	apellidos VARCHAR(30) NOT NULL,
	fechaNacimiento DATE NOT NULL,
	email VARCHAR(35) NOT NULL,
	telefono VARCHAR(10)
)
GO

CREATE TABLE CLIENTE
(
	documentoUsuario VARCHAR(11) PRIMARY KEY,	

	CONSTRAINT RELACION_A_USUARIO FOREIGN KEY (documentoUsuario) REFERENCES USUARIO(documento)
	ON UPDATE CASCADE
)

GO

CREATE TABLE AERONAVES
(
	idAeronave VARCHAR(15) PRIMARY KEY NOT NULL,
	tipo VARCHAR(20) NOT NULL,
	capacidadPrimeraClase INT NOT NULL,
	capacidadClaseTurista INT NOT NULL,
	proveedor VARCHAR(20) NOT NULL,
	capacidadEquipaje INT NOT NULL,
	fechaAdquisicion DATE NOT NULL,
	estadoActual VARCHAR(20)
)

GO

CREATE TABLE PAISES
(
	id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	nombre VARCHAR(20) NOT NULL
)

CREATE TABLE ESTADOS
(
	id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	idPais INT NOT NULL,
	nombre VARCHAR(20) NOT NULL

	CONSTRAINT RELACION_AL_PAIS FOREIGN KEY (idPais) REFERENCES PAISES(id)
)


CREATE TABLE CIUDADES
(
	id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	idEstado INT NOT NULL,
	nombre VARCHAR(20) NOT NULL,

	CONSTRAINT RELACION_AL_ESTADO FOREIGN KEY(idEstado) REFERENCES ESTADOS(id),
)

GO

CREATE TABLE EMPLEADO
(
	documentoUsuario VARCHAR(11) PRIMARY KEY ,
	EPS VARCHAR(30) NOT NULL,
	direccion VARCHAR(30) NOT NULL,
	ciudad INT NOT NULL,
	infoAdicional VARCHAR(2000),
	estado VARCHAR(15)
	
	CONSTRAINT RELACION_A_CIUDADES FOREIGN KEY (ciudad) REFERENCES CIUDADES(id),
	CONSTRAINT RELACION_A_USER FOREIGN KEY (documentoUsuario) REFERENCES USUARIO (documento) 
	ON UPDATE CASCADE,
)
GO

CREATE TABLE CONTRATO
(
	idContrato BIGINT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	documento VARCHAR(11) NOT NULL,
	tipo VARCHAR(12) NOT NULL,
	puesto VARCHAR(30) NOT NULL,
	sueldoHora VARCHAR(10) NOT NULL,
	inicio DATE NOT NULL,
	fin DATE NOT NULL,
	numCuenta VARCHAR(30) NOT NULL,
	tipoCuenta VARCHAR(15) NOT NULL,
	banco VARCHAR(30) NOT NULL

	CONSTRAINT RELACION_A_EMPLEADO FOREIGN KEY(documento) REFERENCES EMPLEADO(documentoUsuario)
)
GO

CREATE TABLE AEROPUERTOS
(
	idAeropuerto INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	nombre VARCHAR(20) NOT NULL,
	idCiudad INT

	CONSTRAINT RELACION_A_CIUDAD FOREIGN KEY (idCiudad) REFERENCES CIUDADES(id)
)

GO

CREATE TABLE RUTAS
(
	idRuta BIGINT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	nombreRuta VARCHAR(15) NOT NULL,
	aerOrigen INT NOT NULL,
	aerDestino INT NOT NULL,
	estado VARCHAR(15) NOT NULL,
	
	CONSTRAINT LLAMADO_A_AEROPUERTO_ORIGEN FOREIGN KEY (aerOrigen) REFERENCES AEROPUERTOS(idAeropuerto),
	CONSTRAINT LLAMADO_A_AEROPUERTO_DESTINO FOREIGN KEY (aerDestino) REFERENCES AEROPUERTOS(idAeropuerto)
)

CREATE TABLE VUELOS
(
	numVuelo BIGINT PRIMARY KEY NOT NULL,
	idRuta BIGINT NOT NULL,
	idAeronave VARCHAR(15),
	pClase INT, --ASIENTOS OCUPADOS PRIMERA CLASE
	tClase INT,	--ASIENTOS OCUPADOS CLASE TURISTA
	salida DATETIME NOT NULL,
	llegada DATETIME NOT NULL,
	vlrPrimeraClase VARCHAR(10),
	vlrClaseTurista VARCHAR(10),

	CONSTRAINT RELACION_A_AERONAVE FOREIGN KEY (idAeronave) REFERENCES AERONAVES(idAeronave),
	CONSTRAINT RELACION_A_RUTA FOREIGN KEY (idRuta) REFERENCES RUTAS(idRuta)
)

GO

CREATE TABLE TIQUETE
(
	idTiquete BIGINT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	numVuelo BIGINT NOT NULL,
	docCliente VARCHAR(11) NOT NULL,
	fechaReserva DATETIME NOT NULL,
	estadoDeReserva VARCHAR(15) NOT NULL,
	clase INT NOT NULL,

	CONSTRAINT RELACION_A_CLIENTE FOREIGN KEY (docCliente) REFERENCES CLIENTE(documentoUsuario),
	CONSTRAINT RELACION_A_VUELO FOREIGN KEY (numVuelo) REFERENCES VUELOS(numVuelo)
)

GO

CREATE TABLE CONTACTO
(
	nit VARCHAR(11) PRIMARY KEY NOT NULL,
	nombre VARCHAR(50),
	direccion VARCHAR(20),
	correo VARCHAR(30)
)
GO

CREATE TABLE CELULAR_CONTACTO
(
	idCelular BIGINT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	nit VARCHAR(11),
	numero VARCHAR(10),
	contesta VARCHAR(50)

	CONSTRAINT RELACION_A_CONTACTO FOREIGN KEY (nit) REFERENCES CONTACTO(nit)
)
GO

CREATE TABLE MOVIMIENTOS_FINANCIEROS_EXTERNOS
(
	id BIGINT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	descripcion VARCHAR(2000),
	valor VARCHAR(10),
	destino VARCHAR(11) NOT NULL,
	TIPO INT NOT NULL,
	fecha DATE NOT NULL,

	CONSTRAINT RELACION_A_CONTACTOS FOREIGN KEY(destino) REFERENCES CONTACTO(nit)
)
GO

CREATE TABLE TRIPULACION
(
	tripulante VARCHAR(11) NOT NULL,
	vuelo BIGINT NOT NULL,
	rol VARCHAR(20) NOT NULL
	
	CONSTRAINT RELACION_AL_TRIPULANTE FOREIGN KEY(tripulante) REFERENCES EMPLEADO(documentoUsuario),
	CONSTRAINT RELACION_AL_VUELO FOREIGN KEY(vuelo) REFERENCES VUELOS(numVuelo)
)
GO

CREATE TABLE PAGOS_DE_NOMINA
(
	idPago BIGINT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	documento VARCHAR(11),
	contrato BIGINT,
	estado VARCHAR(15),
	fecha DATE,
	diasLaborados INT,
	horasExtra INT,
	totalPagado VARCHAR(10)
	
	CONSTRAINT RELACION_AL_EMPLEADO FOREIGN KEY(documento) REFERENCES EMPLEADO(documentoUsuario),
	CONSTRAINT RELACION_A_CONTRATO FOREIGN KEY(contrato) REFERENCES CONTRATO(idContrato)
)
GO

CREATE TABLE REEMBOLSOS
(
	id BIGINT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	autoriza VARCHAR(11) NOT NULL,
	justificacion VARCHAR(2000),
	tiquete BIGINT NOT NULL,
	fecha DATETIME NOT NULL

	CONSTRAINT RELACION_A_TIQUETE FOREIGN KEY(tiquete) REFERENCES TIQUETE(idTiquete),
	CONSTRAINT AUTORIZA FOREIGN KEY(autoriza) REFERENCES EMPLEADO(documentoUsuario)
)
GO

CREATE TABLE INFORMES_DE_VUELO
(
	idInforme BIGINT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	numVuelo BIGINT NOT NULL,
	calificacion VARCHAR(15),
	comentarios VARCHAR(2000),
	tripulante VARCHAR(11),
	fecha DATETIME

	CONSTRAINT REFERENCIA_A_VUELO FOREIGN KEY(numVuelo) REFERENCES VUELOS(numVuelo),
	CONSTRAINT REFERENCIA_A_TRIPULANTE FOREIGN KEY(tripulante) REFERENCES EMPLEADO(documentoUsuario)
)
GO

CREATE TABLE INFORMES_DE_EMPLEADOS
(
	idInforme BIGINT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	comentarios VARCHAR(2000),
	empleado VARCHAR(11),
	fecha DATETIME

	CONSTRAINT REFERENCIA_A_EMPLEADO FOREIGN KEY (empleado) REFERENCES EMPLEADO(documentoUsuario)
)
GO
-------------------------------------PROCEDIMIENTOS ALMACENADOS--------------------------------
CREATE PROC GENERAR_INFORME_EMPLEADO
	@comentarios VARCHAR(2000),
	@empleado VARCHAR(11)
AS
INSERT INTO INFORMES_DE_EMPLEADOS VALUES(@comentarios, @empleado, GETDATE())
GO

CREATE PROC CONSULTA_INFORMES_EMPLEADOS
AS
SELECT USUARIO.nombres, USUARIO.apellidos, USUARIO.documento, INFORMES_DE_EMPLEADOS.comentarios, INFORMES_DE_EMPLEADOS.fecha
FROM USUARIO INNER JOIN INFORMES_DE_EMPLEADOS ON USUARIO.documento=INFORMES_DE_EMPLEADOS.empleado
GO

CREATE PROC CONSULTA_INFORMES_VUELOS
AS
SELECT USUARIO.nombres, USUARIO.apellidos, USUARIO.documento, INFORMES_DE_VUELO.comentarios, INFORMES_DE_VUELO.fecha,
INFORMES_DE_VUELO.calificacion FROM USUARIO INNER JOIN INFORMES_DE_VUELO ON USUARIO.documento=INFORMES_DE_VUELO.tripulante
GO


CREATE PROC GENERAR_INFORME_VUELO
	@numVuelo BIGINT,
	@calificacion VARCHAR(15),
	@comentarios VARCHAR(2000),
	@tripulante VARCHAR(11)
AS
INSERT INTO INFORMES_DE_VUELO VALUES(@numVuelo,@calificacion,@comentarios,@tripulante,GETDATE())
GO

CREATE PROC GENERAR_REEMBOLSO
	@autoriza VARCHAR(11),
	@justificacion VARCHAR(50),
	@tiquete BIGINT
AS 
INSERT INTO REEMBOLSOS VALUES(@autoriza, @justificacion, @tiquete, GETDATE())
UPDATE TIQUETE SET estadoDeReserva=6 WHERE TIQUETE.idTiquete=@tiquete
GO

CREATE PROC CONSULTA_TIQUETE_REEMBOLSO
	@id BIGINT
AS
SELECT USUARIO.nombres, USUARIO.apellidos, TIQUETE.docCliente, VUELOS.salida, VUELOS.llegada, ORI.nombre, DEST.nombre, 
TIQUETE.clase, VUELOS.vlrClaseTurista, VUELOS.vlrPrimeraClase FROM
(((((((TIQUETE INNER JOIN USUARIO ON USUARIO.documento=TIQUETE.docCliente) INNER JOIN VUELOS ON TIQUETE.numVuelo=VUELOS.numVuelo)
INNER JOIN RUTAS ON VUELOS.idRuta=RUTAS.idRuta) INNER JOIN AEROPUERTOS AS AERORI ON RUTAS.aerOrigen=AERORI.idAeropuerto)
INNER JOIN AEROPUERTOS AS AERDES ON RUTAS.aerDestino=AERDES.idAeropuerto) INNER JOIN CIUDADES AS ORI ON ORI.id=AERORI.idCiudad)
INNER JOIN CIUDADES AS DEST ON DEST.id=AERDES.idCiudad) WHERE TIQUETE.idTiquete=@id
GO

CREATE PROC CONSULTA_JUSTIFICACION_REEMBOLSO
	@id BIGINT
AS
SELECT REEMBOLSOS.justificacion, REEMBOLSOS.fecha FROM REEMBOLSOS WHERE REEMBOLSOS.tiquete=@id
GO

CREATE PROC VERIFICAR_REEMBOLSO
	@id BIGINT
AS
SELECT COUNT(*) FROM REEMBOLSOS WHERE REEMBOLSOS.tiquete=@id
GO

CREATE PROC GENERAR_PAGO
AS

DECLARE @tabla TABLE(documento VARCHAR(11))
INSERT INTO @tabla(documento) SELECT EMPLEADO.documentoUsuario FROM EMPLEADO WHERE EMPLEADO.estado='Activo'

DECLARE @CANT_EMPLEADOS INT = (SELECT COUNT(*) FROM @tabla)

WHILE @CANT_EMPLEADOS>0
	BEGIN
		DECLARE @doc VARCHAR(11)=(SELECT TOP(1) documento FROM @tabla ORDER BY documento)
		DECLARE @contr BIGINT=(SELECT CONTRATO.idContrato FROM CONTRATO WHERE CONTRATO.documento=@doc)

		INSERT INTO PAGOS_DE_NOMINA VALUES(@doc,@contr,'No pago',GETDATE(),NULL,NULL,NULL)

		DELETE @tabla WHERE documento=@doc

		SET @CANT_EMPLEADOS = (SELECT COUNT(*) FROM @tabla)

	END

GO

CREATE PROC CONSULTA_PAGOS_PENDIENTES
AS
SELECT USUARIO.documento, USUARIO.nombres, USUARIO.apellidos, CONTRATO.sueldoHora, PAGOS_DE_NOMINA.idPago, PAGOS_DE_NOMINA.fecha FROM (PAGOS_DE_NOMINA INNER JOIN USUARIO ON 
PAGOS_DE_NOMINA.documento=USUARIO.documento) INNER JOIN CONTRATO ON PAGOS_DE_NOMINA.contrato=CONTRATO.idContrato WHERE PAGOS_DE_NOMINA.estado='No pago'
GO

CREATE PROC CONSULTA_PAGOS_REALIZADOS
AS
SELECT USUARIO.documento, USUARIO.nombres, USUARIO.apellidos, CONTRATO.sueldoHora, PAGOS_DE_NOMINA.idPago, PAGOS_DE_NOMINA.fecha FROM (PAGOS_DE_NOMINA INNER JOIN USUARIO ON 
PAGOS_DE_NOMINA.documento=USUARIO.documento) INNER JOIN CONTRATO ON PAGOS_DE_NOMINA.contrato=CONTRATO.idContrato WHERE PAGOS_DE_NOMINA.estado='Pagado'
GO

CREATE PROC  CONSULTA_PERSONAL_PAGOS
	@doc varchar(11)
AS
SELECT USUARIO.documento, USUARIO.nombres, USUARIO.apellidos, CONTRATO.sueldoHora, PAGOS_DE_NOMINA.idPago, PAGOS_DE_NOMINA.fecha FROM (PAGOS_DE_NOMINA INNER JOIN USUARIO ON 
PAGOS_DE_NOMINA.documento=USUARIO.documento) INNER JOIN CONTRATO ON PAGOS_DE_NOMINA.contrato=CONTRATO.idContrato WHERE PAGOS_DE_NOMINA.estado='Pagado' AND USUARIO.documento=@doc
GO

CREATE PROC CONSULTA_DATOS_DE_PAGO
	@doc VARCHAR(11)
AS
SELECT USUARIO.nombres, USUARIO.apellidos, USUARIO.documento, CONTRATO.idContrato, CONTRATO.sueldoHora FROM (USUARIO INNER JOIN CONTRATO ON
USUARIO.documento=CONTRATO.documento) WHERE USUARIO.documento=@doc
GO

CREATE PROC CONSULTA_DATOS_DE_PAGO_REALIZADO
	@id BIGINT
AS
SELECT USUARIO.nombres, USUARIO.apellidos, USUARIO.documento, CONTRATO.idContrato, CONTRATO.sueldoHora, PAGOS_DE_NOMINA.diasLaborados, 
PAGOS_DE_NOMINA.horasExtra, PAGOS_DE_NOMINA.totalPagado FROM (USUARIO INNER JOIN CONTRATO ON USUARIO.documento=CONTRATO.documento) 
INNER JOIN PAGOS_DE_NOMINA ON USUARIO.documento=PAGOS_DE_NOMINA.documento WHERE PAGOS_DE_NOMINA.idPago=@id
GO

CREATE PROC CONSULTA_MOVIMIENTOS_EXTERNOS
	@tipo INT,
	@inicio DATE,
	@fin DATE
AS
SELECT MOVIMIENTOS_FINANCIEROS_EXTERNOS.descripcion, MOVIMIENTOS_FINANCIEROS_EXTERNOS.fecha, MOVIMIENTOS_FINANCIEROS_EXTERNOS.valor,
CONTACTO.nombre, CONTACTO.nit FROM MOVIMIENTOS_FINANCIEROS_EXTERNOS INNER JOIN CONTACTO ON 
MOVIMIENTOS_FINANCIEROS_EXTERNOS.destino=CONTACTO.nit WHERE MOVIMIENTOS_FINANCIEROS_EXTERNOS.TIPO=@tipo AND
(MOVIMIENTOS_FINANCIEROS_EXTERNOS.fecha >= @inicio AND MOVIMIENTOS_FINANCIEROS_EXTERNOS.fecha <= @fin)
GO

CREATE PROC VALIDAR_PAGO
	@id BIGINT,
	@dias INT,
	@horas INT,
	@total VARCHAR(10)
AS
UPDATE PAGOS_DE_NOMINA SET estado='Pagado', diasLaborados=@dias, horasExtra=@horas, totalPagado=@total WHERE idPago=@id
GO

CREATE PROC REGISTRO_EMPLEADO
	@documento VARCHAR(11),
	@tipoDocumento VARCHAR(2),
	@usuario VARCHAR(20),
	@contrase�a VARCHAR(32),
	@permisos VARCHAR(4),
	@nombres VARCHAR(30),
	@apellidos VARCHAR(30),
	@fechaNacimiento DATE,
	@email VARCHAR(35),
	@telefono VARCHAR(10),
	@EPS VARCHAR(30),
	@direccion VARCHAR(30),
	@ciudad VARCHAR(30),
	@infoAdicional VARCHAR(2000),
	@estado VARCHAR(15)
AS
INSERT INTO USUARIO VALUES(@documento,@tipoDocumento,@usuario,@contrase�a,@permisos,
							@nombres,@apellidos,@fechaNacimiento,@email,@telefono)
INSERT INTO EMPLEADO VALUES(@documento,@EPS,@direccion,@ciudad,@infoAdicional,@estado)
GO

CREATE PROC CREAR_CNTRATO
	@documento VARCHAR(11),
	@tipo VARCHAR(12),
	@puesto VARCHAR(30),
	@sueldo VARCHAR(10),
	@inicio DATE,
	@fin DATE,
	@numCuenta VARCHAR(30),
	@tipoCuenta VARCHAR(15),
	@banco VARCHAR(30)
AS
IF((SELECT COUNT(*) FROM CONTRATO WHERE CONTRATO.documento=@documento)>0)
	UPDATE CONTRATO SET CONTRATO.banco=@banco, CONTRATO.fin=@fin, CONTRATO.inicio=@inicio, CONTRATO.numCuenta=@numCuenta,
	CONTRATO.puesto=@puesto, CONTRATO.sueldoHora=@sueldo, CONTRATO.tipo=@tipo, CONTRATO.tipoCuenta=@tipoCuenta
	WHERE CONTRATO.documento=@documento
ELSE
	INSERT INTO CONTRATO VALUES(@documento,@tipo,@puesto,@sueldo,@inicio,@fin,@numCuenta,@tipoCuenta,@banco)
GO

CREATE PROC VERIFICAR_DOCUMENTO
	@doc VARCHAR(11)
AS
SELECT * FROM EMPLEADO WHERE documentoUsuario=@doc
GO

CREATE PROC CONSULTAR_CIUDADES
AS
SELECT CIUDADES.id, CIUDADES.nombre FROM CIUDADES
GO

CREATE PROC INICIAR_SESION
@Usuario VARCHAR(20),
@contrase�a VARCHAR(32)
AS
SELECT documento, permisos FROM USUARIO WHERE usuario=@Usuario AND contrase�a=@contrase�a

GO 

CREATE PROC CONSULTA_DATOS_EMPLEADO
@document VARCHAR(11)
AS
SELECT * FROM USUARIO INNER JOIN EMPLEADO ON USUARIO.documento=EMPLEADO.documentoUsuario
WHERE documento=@document

GO

CREATE PROC CARGAR_DATOS_USUARIO
	@doc VARCHAR(11)
AS
SELECT USUARIO.usuario, USUARIO.nombres, USUARIO.apellidos, USUARIO.tipoDocumento, USUARIO.documento, USUARIO.fechaNacimiento, 
USUARIO.telefono FROM USUARIO WHERE USUARIO.documento=@doc
GO 

CREATE PROC REGISTRO_CLIENTE
	@documento VARCHAR(11),
	@tipoDocumento VARCHAR(2),
	@usuario VARCHAR(20),
	@contrase�a VARCHAR(32),
	@permisos VARCHAR(4),
	@nombres VARCHAR(30),
	@apellidos VARCHAR(30),
	@fechaNacimiento DATE,
	@email VARCHAR(35),
	@telefono VARCHAR(10)
AS
INSERT INTO USUARIO VALUES(@documento,@tipoDocumento,@usuario,@contrase�a,@permisos,
							@nombres,@apellidos,@fechaNacimiento,@email,@telefono)
INSERT INTO CLIENTE VALUES (@documento)

GO

CREATE PROC ACTUALIZAR_DATOS_CLIENTE
	@documento VARCHAR(11),
	@tipoDocumento VARCHAR(2),
	@usuario VARCHAR(20),
	@nombres VARCHAR(30),
	@apellidos VARCHAR(30),
	@fechaNacimiento DATE,
	@email VARCHAR(35),
	@telefono VARCHAR(10)
AS
UPDATE USUARIO SET
	tipoDocumento=@tipoDocumento,
	usuario=@usuario,
	nombres=@nombres,
	apellidos=@apellidos,
	fechaNacimiento=@fechaNacimiento,
	email=@email,
	telefono=@telefono
WHERE documento=@documento

GO

CREATE PROC ACTUALIZAR_DATOS_EMPLEADO
	@documento VARCHAR(11),
	@tipoDocumento VARCHAR(2),
	@usuario VARCHAR(20),
	@nombres VARCHAR(30),
	@apellidos VARCHAR(30),
	@fechaNacimiento DATE,
	@email VARCHAR(35),
	@telefono VARCHAR(10),
	@EPS VARCHAR(30),
	@direccion VARCHAR(30),
	@ciudad VARCHAR(30),
	@infoAdicional VARCHAR(2000),
	@estado VARCHAR(15)
AS
UPDATE USUARIO SET
	tipoDocumento=@tipoDocumento,
	usuario=@usuario,
	nombres=@nombres,
	apellidos=@apellidos,
	fechaNacimiento=@fechaNacimiento,
	email=@email,
	telefono=@telefono
WHERE documento=@documento

UPDATE EMPLEADO SET
	EPS=@EPS,
	direccion=@direccion,
	ciudad=@ciudad,
	infoAdicional=@infoAdicional,
	estado=@estado
WHERE documentoUsuario=@documento

GO

CREATE PROC CREAR_PAIS
	@nombre VARCHAR(20)
AS
INSERT INTO PAISES VALUES(@nombre)

GO

CREATE PROC CREAR_ESTADO
	@pais INT,
	@nombre VARCHAR(20)
AS
INSERT INTO ESTADOS VALUES(@pais, @nombre)

GO

CREATE PROC CREAR_CIUDAD
	@estado INT,
	@ciudad VARCHAR(20)
AS
INSERT INTO CIUDADES VALUES(@estado,@ciudad)

GO

CREATE PROC CREAR_AEROPUERTO
	@nombre VARCHAR(20),
	@ciudad INT
AS
INSERT INTO AEROPUERTOS VALUES(@nombre, @ciudad)
GO

CREATE PROC CONSULTA_PAISES
AS
SELECT * FROM PAISES
GO

CREATE PROC CONSULTA_ESTADOS
	@pais INT
AS
SELECT id, nombre FROM ESTADOS WHERE idPais=@pais
GO

CREATE PROC CONSULTA_CIUDADES
	@estado INT
AS
SELECT id, nombre FROM CIUDADES WHERE idEstado=@estado
GO

CREATE PROC CONSULTA_AEROPUERTOS
	@ciudad INT
AS
SELECT idAeropuerto, nombre FROM AEROPUERTOS WHERE idCiudad=@ciudad
GO

CREATE PROC CREAR_RUTA
	@nombre VARCHAR(15),
	@origen INT,
	@destino INT,
	@estado VARCHAR(15)
AS
INSERT INTO RUTAS VALUES(@nombre, @origen, @destino, @estado)
GO

CREATE PROC CONSULTA_GENERAL_RUTAS
AS
SELECT RUTAS.idRuta, RUTAS.nombreRuta, ori.nombre,dest.nombre FROM RUTAS, CIUDADES AS ori, CIUDADES AS dest, AEROPUERTOS AS AORI,
AEROPUERTOS AS ADES WHERE RUTAS.aerOrigen=AORI.idAeropuerto AND RUTAS.aerDestino=ADES.idAeropuerto AND AORI.idCiudad=ori.id 
AND ADES.idCiudad=dest.id
GO

CREATE PROC CONSULTA_ESPECIFICA_RUTAS
	@id INT
AS
SELECT RUTAS.idRuta, RUTAS.nombreRuta, AORI.nombre, ORI.nombre, ADES.nombre, DEST.nombre, RUTAS.estado FROM RUTAS, AEROPUERTOS AS AORI, 
AEROPUERTOS AS ADES, CIUDADES AS ORI, CIUDADES AS DEST WHERE RUTAS.idRuta=@id AND RUTAS.aerOrigen=AORI.idAeropuerto AND
RUTAS.aerDestino=ADES.idAeropuerto AND AORI.idCiudad=ORI.id AND ADES.idCiudad=DEST.id
GO

CREATE PROC ACTUALIZAR_ESTADO_RUTA
	@idRuta INT,
	@estado VARCHAR(15)
AS
UPDATE RUTAS SET estado = @estado WHERE RUTAS.idRuta = @idRuta
GO

CREATE PROC CREAR_AERONAVE
	@id VARCHAR(15),
	@tipo VARCHAR(20),
	@capPclase INT,
	@capCturista INT,
	@proveedor VARCHAR(20),
	@equipaje INT,
	@adquisicion DATE,
	@estado VARCHAR(20)
AS
INSERT INTO AERONAVES VALUES(@id, @tipo,@capPclase,@capCturista,@proveedor,@equipaje,@adquisicion,@estado)
GO

CREATE PROC CONSULTA_MATRICULAS
AS
SELECT idAeronave FROM AERONAVES
GO

CREATE PROC CONSULTA_AERONAVE_MATRICULA
	@matricula VARCHAR(15)
AS
SELECT * FROM AERONAVES WHERE idAeronave=@matricula
GO

CREATE PROC ACTUALIZAR_DATOS_AERONAVE
	@id VARCHAR(15),
	@tipo VARCHAR(20),
	@capPclase INT,
	@capCturista INT,
	@proveedor VARCHAR(20),
	@equipaje INT,
	@adquisicion DATE,
	@estado VARCHAR(20)
AS
UPDATE AERONAVES SET tipo=@tipo,capacidadPrimeraClase=@capPclase, capacidadClaseTurista=@capCturista, proveedor=@proveedor,
capacidadEquipaje=@equipaje, fechaAdquisicion=@adquisicion, estadoActual=@estado WHERE idAeronave=@id
GO

CREATE PROC CREAR_VUELO
	@numVuelo BIGINT,
	@idRuta BIGINT,
	@idAeronave VARCHAR(15),
	@pClase INT,
	@tClase INT,
	@salida DATETIME,
	@llegada DATETIME,
	@vlrPrimeraClase VARCHAR(10),
	@vlrClaseTurista VARCHAR(10)
AS
INSERT INTO VUELOS VALUES(@numVuelo,@idRuta,@idAeronave,@pClase,@tClase,@salida,@llegada,@vlrPrimeraClase,@vlrClaseTurista)
GO

CREATE PROC INGRESO_TRIPULANTE
	@documento VARCHAR(11),
	@vuelo BIGINT,
	@rol VARCHAR(20)
AS
INSERT INTO TRIPULACION VALUES(@documento, @vuelo, @rol)
GO

CREATE PROC CONSULTA_TRIPULANTE
	@vuelo BIGINT
AS
SELECT TRIPULACION.tripulante, TRIPULACION.rol FROM TRIPULACION WHERE TRIPULACION.vuelo=@vuelo
GO

CREATE PROC CARGAR_TRIPULANTE
	@doc VARCHAR(11)
AS
SELECT USUARIO.nombres, USUARIO.apellidos, CONTRATO.puesto FROM USUARIO INNER JOIN CONTRATO ON USUARIO.documento=CONTRATO.documento
WHERE USUARIO.documento=@doc
GO

CREATE PROC CARGAR_DATOS_VUELO
	@vuelo BIGINT
AS
SELECT VUELOS.numVuelo, ORI.nombre, DEST.nombre, VUELOS.idAeronave, VUELOS.pClase, VUELOS.tClase, VUELOS.salida, VUELOS.llegada,
VUELOS.vlrPrimeraClase, VUELOS.vlrClaseTurista FROM VUELOS, RUTAS, AEROPUERTOS AS ORI, AEROPUERTOS AS DEST WHERE VUELOS.numVuelo=@vuelo 
AND ORI.idAeropuerto=RUTAS.aerOrigen AND DEST.idAeropuerto=RUTAS.aerDestino AND VUELOS.idRuta=RUTAS.idRuta 
GO

CREATE PROC CARGAR_DATOS_VUELO_AERO
	@origen BIGINT,
	@destino BIGINT
AS
SELECT VUELOS.numVuelo, ORI.nombre, DEST.nombre, VUELOS.idAeronave, VUELOS.pClase, VUELOS.tClase, VUELOS.salida, VUELOS.llegada,
VUELOS.vlrPrimeraClase, VUELOS.vlrClaseTurista FROM VUELOS, RUTAS, AEROPUERTOS AS ORI, AEROPUERTOS AS DEST WHERE RUTAS.aerOrigen=@origen
AND RUTAS.aerDestino=@destino AND ORI.idAeropuerto=RUTAS.aerOrigen AND DEST.idAeropuerto=RUTAS.aerDestino AND VUELOS.idRuta=RUTAS.idRuta 
GO

CREATE PROC ACTUALIZAR_DATOS_VUELO
	@vuelo BIGINT,
	@idRuta BIGINT,
	@idAer VARCHAR(15),
	@pClase INT,
	@tClase INT,
	@salida DATETIME,
	@llegada DATETIME,
	@vlrPrimeraClase VARCHAR(10),
	@vlrClaseTurista VARCHAR(10)
AS
UPDATE VUELOS SET VUELOS.idRuta=@idRuta, VUELOS.pClase=@pClase, VUELOS.tClase=@tClase, VUELOS.salida=@salida,
VUELOS.llegada=@llegada, VUELOS.vlrPrimeraClase=@vlrPrimeraClase, VUELOS.vlrClaseTurista=@vlrClaseTurista WHERE VUELOS.numVuelo=@vuelo
GO 

CREATE PROC CONSULTA_VUELO_FECHA
	@fecha DATE,
	@aerSalida INT,
	@aerLlegada INT
AS
SELECT numVuelo, AERONAVES.capacidadPrimeraClase-VUELOS.pClase, AERONAVES.capacidadClaseTurista-VUELOS.tClase, salida, llegada, vlrPrimeraClase, vlrClaseTurista FROM 
(VUELOS INNER JOIN RUTAS ON VUELOS.idRuta=RUTAS.idRuta) INNER JOIN AERONAVES ON AERONAVES.idAeronave=VUELOS.idAeronave 
WHERE RUTAS.aerOrigen=@aerSalida AND RUTAS.aerDestino=@aerLlegada AND MONTH(@fecha)=MONTH(VUELOS.salida) AND DAY(@fecha)=DAY(VUELOS.salida) AND YEAR(@fecha)=YEAR(VUELOS.salida)
GO

CREATE PROC CONSULTA_USUARIO
	@doc VARCHAR(11)
AS
SELECT * FROM USUARIO WHERE USUARIO.documento=@doc
GO


CREATE PROC NUEVO_TIQUETE
	@doc VARCHAR(11),
	@estado VARCHAR(15),
	@numVuelo BIGINT,
	@clase INT
AS
INSERT INTO TIQUETE VALUES(@numVuelo, @doc, GETDATE(), @estado, @clase)

UPDATE VUELOS SET VUELOS.pClase=(SELECT COUNT(*) FROM TIQUETE WHERE TIQUETE.clase=1 AND TIQUETE.estadoDeReserva=2 AND VUELOS.numVuelo=@numVuelo)

UPDATE VUELOS SET VUELOS.tClase=(SELECT COUNT(*) FROM TIQUETE WHERE TIQUETE.clase=2 AND TIQUETE.estadoDeReserva=2 AND VUELOS.numVuelo=@numVuelo)
GO


CREATE PROC VUELOS_PENDIENTES
	@doc VARCHAR(11)
AS
SELECT VUELOS.numVuelo, ORI.nombre, DEST.nombre, VUELOS.salida, VUELOS.llegada, TIQUETE.estadoDeReserva, TIQUETE.idTiquete FROM ((((VUELOS INNER JOIN TIQUETE ON
TIQUETE.numVuelo=VUELOS.numVuelo) INNER JOIN  RUTAS ON VUELOS.idRuta=RUTAS.idRuta) INNER JOIN AEROPUERTOS AS ORI ON
RUTAS.aerOrigen=ORI.idAeropuerto) INNER JOIN AEROPUERTOS AS DEST ON RUTAS.aerDestino=DEST.idAeropuerto) 
WHERE TIQUETE.docCliente=@doc AND VUELOS.salida > GETDATE()

GO

CREATE PROC HISTORIAL_VUELOS
	@doc VARCHAR(11)
AS
SELECT VUELOS.numVuelo, ORI.nombre, DEST.nombre, VUELOS.salida, VUELOS.llegada, TIQUETE.estadoDeReserva, TIQUETE.idTiquete FROM ((((VUELOS INNER JOIN TIQUETE ON
TIQUETE.numVuelo=VUELOS.numVuelo) INNER JOIN  RUTAS ON VUELOS.idRuta=RUTAS.idRuta) INNER JOIN AEROPUERTOS AS ORI ON
RUTAS.aerOrigen=ORI.idAeropuerto) INNER JOIN AEROPUERTOS AS DEST ON RUTAS.aerDestino=DEST.idAeropuerto) 
WHERE TIQUETE.docCliente=@doc AND VUELOS.salida < GETDATE()

GO

CREATE PROC CONSULTA_VUELOS_PASADOS_TRIPULANTE
	@doc VARCHAR(11)
AS SELECT VUELOS.numVuelo, VUELOS.salida, VUELOS.llegada, RUTAS.nombreRuta FROM (VUELOS INNER JOIN RUTAS ON VUELOS.idRuta=RUTAS.idRuta)
INNER JOIN TRIPULACION ON TRIPULACION.vuelo=VUELOS.numVuelo WHERE TRIPULACION.tripulante=@doc AND VUELOS.salida<GETDATE()
GO

CREATE PROC CONSULTA_VUELOS_FUTUROS_TRIPULANTE
	@doc VARCHAR(11)
AS SELECT VUELOS.numVuelo, VUELOS.salida, VUELOS.llegada, RUTAS.nombreRuta FROM (VUELOS INNER JOIN RUTAS ON VUELOS.idRuta=RUTAS.idRuta)
INNER JOIN TRIPULACION ON TRIPULACION.vuelo=VUELOS.numVuelo WHERE TRIPULACION.tripulante=@doc AND VUELOS.salida>GETDATE()
GO

CREATE PROC CONSULTA_ESPECIFICA_VUELO_TRIPULANTE
	@vuelo BIGINT
AS
SELECT AERONAVES.capacidadPrimeraClase-(SELECT COUNT(*) FROM TIQUETE WHERE TIQUETE.clase=1), 
AERONAVES.capacidadClaseTurista-(SELECT COUNT(*) FROM TIQUETE WHERE TIQUETE.clase=1), VUELOS.salida, VUELOS.llegada, VUELOS.vlrPrimeraClase, 
VUELOS.vlrClaseTurista FROM AERONAVES INNER JOIN VUELOS ON VUELOS.idAeronave=AERONAVES.idAeronave WHERE VUELOS.numVuelo=@vuelo
GO

CREATE PROC CONSULTA_ESPECIFICA_VUELO_TRIPULACION
	@vuelo BIGINT
AS
SELECT TRIPULACION.tripulante, USUARIO.nombres, USUARIO.apellidos, TRIPULACION.rol FROM (TRIPULACION INNER JOIN USUARIO ON USUARIO.documento=TRIPULACION.tripulante)
INNER JOIN VUELOS ON TRIPULACION.vuelo=VUELOS.numVuelo WHERE VUELOS.numVuelo=@vuelo
GO

CREATE PROC CANCELAR_TIQUETE
	@doc VARCHAR(11),
	@vuelo BIGINT
AS
UPDATE TIQUETE SET estadoDeReserva=4 WHERE TIQUETE.docCliente=@doc AND TIQUETE.numVuelo=@vuelo

UPDATE VUELOS SET VUELOS.pClase=(SELECT COUNT(*) FROM TIQUETE WHERE TIQUETE.clase=1 AND TIQUETE.estadoDeReserva=2 AND VUELOS.numVuelo=@vuelo)

UPDATE VUELOS SET VUELOS.tClase=(SELECT COUNT(*) FROM TIQUETE WHERE TIQUETE.clase=2 AND TIQUETE.estadoDeReserva=2 AND VUELOS.numVuelo=@vuelo)
GO

CREATE PROC VALIDAR_TIQUETE
	@id BIGINT
AS
UPDATE TIQUETE SET estadoDeReserva=2 WHERE TIQUETE.idTiquete=@id

declare @numVuelo INT =(SELECT TIQUETE.numVuelo FROM TIQUETE WHERE TIQUETE.idTiquete=@id)

UPDATE VUELOS SET VUELOS.pClase=(SELECT COUNT(*) FROM TIQUETE WHERE TIQUETE.clase=1 AND TIQUETE.estadoDeReserva=2 AND TIQUETE.numVuelo=@numVuelo) 

UPDATE VUELOS SET VUELOS.tClase=(SELECT COUNT(*) FROM TIQUETE WHERE TIQUETE.clase=2 AND TIQUETE.estadoDeReserva=2 AND TIQUETE.numVuelo=@numVuelo)  

GO

CREATE PROC INFO_VENTA
	@id BIGINT
AS
SELECT USUARIO.nombres, USUARIO.apellidos, TIQUETE.docCliente, VUELOS.salida, VUELOS.llegada, ORI.nombre, DEST.nombre, TIQUETE.clase,
TIQUETE.numVuelo FROM(((((((TIQUETE INNER JOIN USUARIO ON USUARIO.documento=TIQUETE.docCliente) INNER JOIN VUELOS ON TIQUETE.numVuelo=VUELOS.numVuelo)
INNER JOIN RUTAS ON VUELOS.idRuta=RUTAS.idRuta) INNER JOIN AEROPUERTOS AS AERORI ON RUTAS.aerOrigen=AERORI.idAeropuerto)
INNER JOIN AEROPUERTOS AS AERDES ON RUTAS.aerDestino=AERDES.idAeropuerto) INNER JOIN CIUDADES AS ORI ON ORI.id=AERORI.idCiudad)
INNER JOIN CIUDADES AS DEST ON DEST.id=AERDES.idCiudad) WHERE TIQUETE.idTiquete=@id
GO

CREATE PROC CREAR_CONTACTO
	@nit VARCHAR(11),
	@nombre VARCHAR(50),
	@direccion VARCHAR(20),
	@correo VARCHAR(30)
AS
INSERT INTO CONTACTO VALUES(@nit, @nombre, @direccion, @correo)
GO

CREATE PROC CREAR_NUM_CONTACTO
	@nit VARCHAR(11),
	@num VARCHAR(10),
	@contesta VARCHAR(50)
AS
INSERT INTO CELULAR_CONTACTO VALUES(@nit, @num, @contesta)
GO

CREATE PROC CONULTA_NUM_CONTACTO
	@nit VARCHAR(11)
AS
SELECT CELULAR_CONTACTO.idCelular ,CELULAR_CONTACTO.contesta, CELULAR_CONTACTO.numero FROM CELULAR_CONTACTO WHERE nit=@nit
GO

CREATE PROC CONSULTA_CONTACTO
	@nit VARCHAR(11)
AS
SELECT * FROM CONTACTO WHERE nit=@nit
GO

CREATE PROC ACTUALIZAR_NUMERO
	@id BIGINT,
	@numero VARCHAR(10),
	@contesta VARCHAR(50)
AS
UPDATE CELULAR_CONTACTO SET numero=@numero, contesta=@contesta WHERE idCelular=@id
GO

CREATE PROC MODIFICAR_CONTACTO
	@nit VARCHAR(11),
	@nombre VARCHAR(50),
	@direccion VARCHAR(20),
	@correo VARCHAR(30)
AS
UPDATE CONTACTO SET nombre=@nombre, direccion=@direccion, correo=@correo WHERE nit=@nit
GO

CREATE PROC CONSULTA_GRAL_CONTACTO
AS
SELECT CONTACTO.nit,CONTACTO.nombre FROM CONTACTO
GO

CREATE PROC MOVIMIENTO_FINANCIERO
	@desc VARCHAR(2000),
	@valor VARCHAR(10),
	@destino VARCHAR(11),
	@tipo INT,
	@fecha DATE
AS
INSERT INTO MOVIMIENTOS_FINANCIEROS_EXTERNOS VALUES(@desc,@valor,@destino,@tipo,@fecha)
GO

CREATE PROC CONSULTAR_VENTAS
	@inicio DATE,
	@final DATE
AS
SELECT TIQUETE.idTiquete, TIQUETE.numVuelo, TIQUETE.fechaReserva, USUARIO.nombres, USUARIO.apellidos, USUARIO.documento FROM
TIQUETE INNER JOIN USUARIO ON USUARIO.documento=TIQUETE.docCliente WHERE TIQUETE.estadoDeReserva=2 AND (TIQUETE.fechaReserva >= @inicio AND TIQUETE.fechaReserva <= @final)
GO


CREATE PROC CONSULTAR_REEMBOLSOS
	@inicio DATE,
	@final DATE
AS
SELECT TIQUETE.idTiquete, TIQUETE.numVuelo, TIQUETE.fechaReserva, USUARIO.nombres, USUARIO.apellidos, USUARIO.documento FROM
TIQUETE INNER JOIN USUARIO ON USUARIO.documento=TIQUETE.docCliente WHERE TIQUETE.estadoDeReserva=6 AND (TIQUETE.fechaReserva >= @inicio AND TIQUETE.fechaReserva <= @final)
GO

CREATE PROC CAMBIAR_CONTRASE�A
	@nueva VARCHAR(32),
	@doc VARCHAR(11)
AS
UPDATE USUARIO SET contrase�a=@nueva WHERE documento=@doc
GO

CREATE PROC CONSULTA_CIUDADES_TIQUETE
	@id BIGINT
AS
SELECT ORI.nombre, DEST.nombre, TIQUETE.clase, USUARIO.nombres, USUARIO.apellidos FROM ((((((TIQUETE INNER JOIN VUELOS ON TIQUETE.numVuelo=VUELOS.numVuelo) INNER JOIN RUTAS ON RUTAS.idRuta=VUELOS.idRuta)
INNER JOIN AEROPUERTOS AS AERORI ON AERORI.idAeropuerto=RUTAS.aerOrigen) INNER JOIN AEROPUERTOS AS AERDES ON RUTAS.aerDestino=AERDES.idAeropuerto)
INNER JOIN CIUDADES AS ORI ON ORI.id=AERORI.idCiudad)INNER JOIN CIUDADES AS DEST ON DEST.id=AERDES.idCiudad) INNER JOIN USUARIO ON
USUARIO.documento=TIQUETE.docCliente WHERE TIQUETE.idTiquete=@id
GO

CREATE PROC CONSULTA_ID_TIQUETE
	@vuelo BIGINT,
	@doc VARCHAR(11)
AS
SELECT TIQUETE.idTiquete FROM TIQUETE WHERE TIQUETE.docCliente=@doc AND TIQUETE.numVuelo=@vuelo
GO

CREATE PROC CONSULTA_SUM_GRAL_MES_INGRESOS
	@mes INT,
	@a�o VARCHAR(4)
AS
	DECLARE @primeraClase INT=(SELECT SUM(CAST(VUELOS.vlrPrimeraClase AS INT)) FROM VUELOS INNER JOIN TIQUETE ON 
								VUELOS.numVuelo=TIQUETE.numVuelo WHERE TIQUETE.clase=1 AND TIQUETE.estadoDeReserva!=6 AND 
								TIQUETE.estadoDeReserva!=1 AND MONTH(TIQUETE.fechaReserva)=@mes AND YEAR(TIQUETE.fechaReserva)=@a�o)

	DECLARE @claseTurista INT=(SELECT SUM(CAST(VUELOS.vlrClaseTurista AS INT)) FROM VUELOS INNER JOIN TIQUETE ON 
								VUELOS.numVuelo=TIQUETE.numVuelo WHERE TIQUETE.clase=2 AND TIQUETE.estadoDeReserva!=6 AND 
								TIQUETE.estadoDeReserva!=1 AND MONTH(TIQUETE.fechaReserva)=@mes AND YEAR(TIQUETE.fechaReserva)=@a�o)

	DECLARE @externos INT=(SELECT SUM(CAST(MOVIMIENTOS_FINANCIEROS_EXTERNOS.valor AS INT)) FROM MOVIMIENTOS_FINANCIEROS_EXTERNOS 
							WHERE MOVIMIENTOS_FINANCIEROS_EXTERNOS.TIPO=1 AND MONTH(MOVIMIENTOS_FINANCIEROS_EXTERNOS.fecha)=@mes AND
							YEAR(MOVIMIENTOS_FINANCIEROS_EXTERNOS.fecha)=@a�o)


	DECLARE @total INT=(ISNULL(@primeraClase,0) + ISNULL(@claseTurista,0) + ISNULL(@externos,0))
									
	SELECT @total
GO


CREATE PROC CONSULTA_SUM_GRAL_MES_GASTOS
	@mes INT,
	@a�o VARCHAR(4)
AS
	DECLARE @primeraClase INT=(SELECT SUM(CAST(VUELOS.vlrPrimeraClase AS INT)) FROM VUELOS INNER JOIN TIQUETE ON 
								VUELOS.numVuelo=TIQUETE.numVuelo WHERE TIQUETE.clase=1 AND TIQUETE.estadoDeReserva=6
								AND MONTH(TIQUETE.fechaReserva)=@mes AND YEAR(TIQUETE.fechaReserva)=@a�o)

	DECLARE @claseTurista INT=(SELECT SUM(CAST(VUELOS.vlrClaseTurista AS INT)) FROM VUELOS INNER JOIN TIQUETE ON 
								VUELOS.numVuelo=TIQUETE.numVuelo WHERE TIQUETE.clase=2 AND TIQUETE.estadoDeReserva=6 
								AND MONTH(TIQUETE.fechaReserva)=@mes AND YEAR(TIQUETE.fechaReserva)=@a�o)

	DECLARE @externos INT=(SELECT SUM(CAST(MOVIMIENTOS_FINANCIEROS_EXTERNOS.valor AS INT)) FROM MOVIMIENTOS_FINANCIEROS_EXTERNOS 
							WHERE MOVIMIENTOS_FINANCIEROS_EXTERNOS.TIPO=2 AND MONTH(MOVIMIENTOS_FINANCIEROS_EXTERNOS.fecha)=@mes AND
							YEAR(MOVIMIENTOS_FINANCIEROS_EXTERNOS.fecha)=@a�o)


	DECLARE @total INT=(ISNULL(@primeraClase,0) + ISNULL(@claseTurista,0) + ISNULL(@externos,0))
									
	SELECT @total
GO

CREATE PROC CONSULTA_SUM_PASAJEROS_RUTA
	@idRuta BIGINT,
	@a�o VARCHAR(4),
	@mes INT
AS
	SELECT COUNT(*) FROM (TIQUETE INNER JOIN VUELOS ON TIQUETE.numVuelo=VUELOS.numVuelo) INNER JOIN RUTAS ON RUTAS.idRuta=VUELOS.idRuta
	WHERE TIQUETE.estadoDeReserva=2 AND RUTAS.idRuta=@idRuta AND YEAR(VUELOS.salida)=@a�o AND MONTH(VUELOS.salida)=@mes
GO 

CREATE PROC CONSULTA_SUM_VUELOS_SALIDA_CIUDAD
	@idCiudad BIGINT,
	@a�o VARCHAR(4),
	@mes INT
AS
	SELECT COUNT(*) FROM (((TIQUETE INNER JOIN VUELOS ON TIQUETE.numVuelo=VUELOS.numVuelo) INNER JOIN RUTAS ON VUELOS.idRuta=RUTAS.idRuta)
	INNER JOIN AEROPUERTOS ON RUTAS.aerOrigen=AEROPUERTOS.idAeropuerto) INNER JOIN CIUDADES ON CIUDADES.id=AEROPUERTOS.idCiudad WHERE
	CIUDADES.id=@idCiudad AND YEAR(VUELOS.salida)=@a�o AND MONTH(VUELOS.salida)=@mes
GO

CREATE PROC CONSULTA_SUM_VUELOS_LLEGADA_CIUDAD
	@idCiudad BIGINT,
	@a�o VARCHAR(4),
	@mes INT
AS
	SELECT COUNT(*) FROM (((TIQUETE INNER JOIN VUELOS ON TIQUETE.numVuelo=VUELOS.numVuelo) INNER JOIN RUTAS ON VUELOS.idRuta=RUTAS.idRuta)
	INNER JOIN AEROPUERTOS ON RUTAS.aerDestino=AEROPUERTOS.idAeropuerto) INNER JOIN CIUDADES ON CIUDADES.id=AEROPUERTOS.idCiudad WHERE
	CIUDADES.id=@idCiudad AND YEAR(VUELOS.salida)=@a�o AND MONTH(VUELOS.salida)=@mes
GO

CREATE PROC CONSULTA_SUM_VENTAS_MES
	@mes INT,
	@a�o VARCHAR(4)
AS
	DECLARE @primeraClase INT=(SELECT SUM(CAST(VUELOS.vlrPrimeraClase AS INT)) FROM VUELOS INNER JOIN TIQUETE ON 
								VUELOS.numVuelo=TIQUETE.numVuelo WHERE TIQUETE.clase=1 AND TIQUETE.estadoDeReserva!=6 AND 
								TIQUETE.estadoDeReserva!=1 AND MONTH(TIQUETE.fechaReserva)=@mes AND YEAR(TIQUETE.fechaReserva)=@a�o)

	DECLARE @claseTurista INT=(SELECT SUM(CAST(VUELOS.vlrClaseTurista AS INT)) FROM VUELOS INNER JOIN TIQUETE ON 
								VUELOS.numVuelo=TIQUETE.numVuelo WHERE TIQUETE.clase=2 AND TIQUETE.estadoDeReserva!=6 AND 
								TIQUETE.estadoDeReserva!=1 AND MONTH(TIQUETE.fechaReserva)=@mes AND YEAR(TIQUETE.fechaReserva)=@a�o)

	DECLARE @total INT=(ISNULL(@primeraClase,0) + ISNULL(@claseTurista,0))
									
	SELECT @total
GO

CREATE PROC CONSULTA_SUM_EXTERNOS_MES_INGRESOS
	@mes INT,
	@a�o VARCHAR(4)
AS
	DECLARE @externos INT=(SELECT SUM(CAST(MOVIMIENTOS_FINANCIEROS_EXTERNOS.valor AS INT)) FROM MOVIMIENTOS_FINANCIEROS_EXTERNOS 
							WHERE MOVIMIENTOS_FINANCIEROS_EXTERNOS.TIPO=1 AND MONTH(MOVIMIENTOS_FINANCIEROS_EXTERNOS.fecha)=@mes AND
							YEAR(MOVIMIENTOS_FINANCIEROS_EXTERNOS.fecha)=@a�o)


	DECLARE @total INT=(ISNULL(@externos,0))
									
	SELECT @total
GO

CREATE PROC CONSULTA_SUM_REEMBOLSOS_MES
	@mes INT,
	@a�o VARCHAR(4)
AS
	DECLARE @primeraClase INT=(SELECT SUM(CAST(VUELOS.vlrPrimeraClase AS INT)) FROM VUELOS INNER JOIN TIQUETE ON 
								VUELOS.numVuelo=TIQUETE.numVuelo WHERE TIQUETE.clase=1 AND TIQUETE.estadoDeReserva=6
								AND MONTH(TIQUETE.fechaReserva)=@mes AND YEAR(TIQUETE.fechaReserva)=@a�o)

	DECLARE @claseTurista INT=(SELECT SUM(CAST(VUELOS.vlrClaseTurista AS INT)) FROM VUELOS INNER JOIN TIQUETE ON 
								VUELOS.numVuelo=TIQUETE.numVuelo WHERE TIQUETE.clase=2 AND TIQUETE.estadoDeReserva=6 
								AND MONTH(TIQUETE.fechaReserva)=@mes AND YEAR(TIQUETE.fechaReserva)=@a�o)

	DECLARE @total INT=(ISNULL(@primeraClase,0) + ISNULL(@claseTurista,0))
									
	SELECT @total
GO

CREATE PROC CONSULTA_SUM_EXTERNOS_MES_GASTOS
	@mes INT,
	@a�o VARCHAR(4)
AS

	DECLARE @externos INT=(SELECT SUM(CAST(MOVIMIENTOS_FINANCIEROS_EXTERNOS.valor AS INT)) FROM MOVIMIENTOS_FINANCIEROS_EXTERNOS 
							WHERE MOVIMIENTOS_FINANCIEROS_EXTERNOS.TIPO=2 AND MONTH(MOVIMIENTOS_FINANCIEROS_EXTERNOS.fecha)=@mes AND
							YEAR(MOVIMIENTOS_FINANCIEROS_EXTERNOS.fecha)=@a�o)


	DECLARE @total INT=(ISNULL(@externos,0))
									
	SELECT @total
GO

CREATE PROC VUELOS_FUTUROS
AS
SELECT VUELOS.numVuelo FROM VUELOS WHERE VUELOS.salida>=GETDATE();
GO

CREATE PROC SOLICITAR_TRIPULANTES
AS
SELECT CONCAT(USUARIO.nombres, ' ', USUARIO.apellidos, ' - ', USUARIO.documento) AS inf , USUARIO.documento FROM USUARIO WHERE USUARIO.permisos='3'
GO

INSERT INTO USUARIO VALUES('1','NN','ROOT','7b24afc8bc80e548d66c4e7ff72171c5','1','USUARIO','ADMINISTRADOR','1999/1/1','ADMIN@ADMIN.COM','123546789')
GO
