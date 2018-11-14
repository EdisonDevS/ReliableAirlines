CREATE DATABASE ReliableAirlines

GO

USE ReliableAirlines

GO

CREATE TABLE USUARIO
(
	documento VARCHAR(11) PRIMARY KEY NOT NULL,
	tipoDocumento VARCHAR(3) NOT NULL,
	usuario VARCHAR(20) NOT NULL,
	contraseña VARCHAR(32) NOT NULL,
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
	documentoUsuario VARCHAR(11) PRIMARY KEY,
	tipoContrato VARCHAR(20) NOT NULL,
	puesto VARCHAR(20) NOT NULL,
	cuenta VARCHAR(30) NOT NULL,
	tipoCuenta VARCHAR(10) NOT NULL,
	banco VARCHAR(30) NOT NULL,
	EPS VARCHAR(30) NOT NULL,
	direccion VARCHAR(30) NOT NULL,
	ciudad INT NOT NULL,
	infoAdicional VARCHAR(250),
	sueldo VARCHAR(10),
	estado VARCHAR(15)
	
	CONSTRAINT RELACION_A_CIUDADES FOREIGN KEY (ciudad) REFERENCES CIUDADES(id),
	CONSTRAINT RELACION_A_USER FOREIGN KEY (documentoUsuario) REFERENCES USUARIO (documento) 
	ON UPDATE CASCADE,
)

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

GO

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
	estadoDeReserva INT NOT NULL

	CONSTRAINT RELACION_A_CLIENTE FOREIGN KEY (docCliente) REFERENCES CLIENTE(documentoUsuario),
	CONSTRAINT RELACION_A_VUELO FOREIGN KEY (numVuelo) REFERENCES VUELOS(numVuelo)
)

GO

CREATE TABLE TRIPULACION
(
	tripulante VARCHAR(11),
	vuelo BIGINT
	
	CONSTRAINT RELACION_AL_TRIPULANTE FOREIGN KEY(tripulante) REFERENCES EMPLEADO(documentoUsuario),
	CONSTRAINT RELACION_AL_VUELO FOREIGN KEY(vuelo) REFERENCES VUELOS(numVuelo)
)
GO
-----------------------------------------PROCEDIMIENTOS ALMACENADOS--------------------------------

CREATE PROC REGISTRO_EMPLEADO
	@documento VARCHAR(11),
	@tipoDocumento VARCHAR(2),
	@usuario VARCHAR(20),
	@contraseña VARCHAR(32),
	@permisos VARCHAR(4),
	@nombres VARCHAR(30),
	@apellidos VARCHAR(30),
	@fechaNacimiento DATE,
	@email VARCHAR(35),
	@telefono VARCHAR(10),
	@tipoContrato VARCHAR(20),
	@puesto VARCHAR(20),
	@cuenta VARCHAR(30),
	@tipoCuenta VARCHAR(10),
	@banco VARCHAR(30),
	@EPS VARCHAR(30),
	@direccion VARCHAR(30),
	@ciudad VARCHAR(30),
	@infoAdicional VARCHAR(250),
	@sueldo VARCHAR(10),
	@estado VARCHAR(15)
AS
INSERT INTO USUARIO VALUES(@documento,@tipoDocumento,@usuario,@contraseña,@permisos,
							@nombres,@apellidos,@fechaNacimiento,@email,@telefono)
INSERT INTO EMPLEADO VALUES(@documento,@tipoContrato,@puesto,@cuenta,@tipoCuenta,@banco,
							@EPS,@direccion,@ciudad,@infoAdicional,@sueldo,@estado)
GO

CREATE PROC CONSULTAR_CIUDADES
AS
SELECT CIUDADES.id, CIUDADES.nombre FROM CIUDADES
GO

CREATE PROC INICIAR_SESION
@Usuario VARCHAR(20),
@contraseña VARCHAR(32)
AS
SELECT documento, permisos FROM USUARIO WHERE usuario=@Usuario AND contraseña=@contraseña

GO 

CREATE PROC CONSULTA_DATOS_EMPLEADO
@document VARCHAR(11)
AS
SELECT * FROM USUARIO INNER JOIN EMPLEADO ON USUARIO.documento=EMPLEADO.documentoUsuario
WHERE documento=@document

GO

CREATE PROC REGISTRO_CLIENTE
	@documento VARCHAR(11),
	@tipoDocumento VARCHAR(2),
	@usuario VARCHAR(20),
	@contraseña VARCHAR(32),
	@permisos VARCHAR(4),
	@nombres VARCHAR(30),
	@apellidos VARCHAR(30),
	@fechaNacimiento DATE,
	@email VARCHAR(35),
	@telefono VARCHAR(10)
AS
INSERT INTO USUARIO VALUES(@documento,@tipoDocumento,@usuario,@contraseña,@permisos,
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
	@tipoContrato VARCHAR(20),
	@puesto VARCHAR(20),
	@cuenta VARCHAR(30),
	@tipoCuenta VARCHAR(10),
	@banco VARCHAR(30),
	@EPS VARCHAR(30),
	@direccion VARCHAR(30),
	@ciudad VARCHAR(30),
	@infoAdicional VARCHAR(250),
	@sueldo VARCHAR(10),
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
	tipoContrato=@tipoContrato,
	puesto=@puesto,
	cuenta=@cuenta,
	tipoCuenta=@tipoCuenta,
	banco=@banco,
	EPS=@EPS,
	direccion=@direccion,
	ciudad=@ciudad,
	infoAdicional=@infoAdicional,
	sueldo=@sueldo,
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

CREATE PROC CONSULTA_TRIPULANTE
	@documento VARCHAR(11)
AS 
SELECT EMPLEADO.puesto, EMPLEADO.ciudad, USUARIO.nombres, USUARIO.apellidos, EMPLEADO.estado FROM EMPLEADO INNER JOIN USUARIO ON 
EMPLEADO.documentoUsuario=USUARIO.documento AND USUARIO.documento=@documento
GO

CREATE PROC INGRESO_TRIPULANTE
	@documento VARCHAR(11),
	@vuelo BIGINT
AS
INSERT INTO TRIPULACION VALUES(@documento, @vuelo)
GO

CREATE PROC CARGAR_TRIPULANTE
	@doc VARCHAR(11)
AS 
SELECT USUARIO.nombres, USUARIO.apellidos, EMPLEADO.estado, EMPLEADO.puesto, USUARIO.email, USUARIO.telefono, EMPLEADO.ciudad FROM
EMPLEADO INNER JOIN USUARIO ON USUARIO.documento=EMPLEADO.documentoUsuario AND USUARIO.documento=@doc
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
SELECT numVuelo, pClase, tClase, salida, llegada, vlrPrimeraClase, vlrClaseTurista FROM VUELOS INNER JOIN RUTAS ON 
VUELOS.idRuta=RUTAS.idRuta WHERE RUTAS.aerOrigen=@aerSalida AND RUTAS.aerDestino=@aerLlegada AND MONTH(@fecha)=MONTH(VUELOS.salida
) AND DAY(@fecha)=DAY(VUELOS.salida) AND YEAR(@fecha)=YEAR(VUELOS.salida)
GO

CREATE PROC CONSULTA_USUARIO
	@doc VARCHAR(11)
AS
SELECT * FROM USUARIO WHERE USUARIO.documento=@doc
GO


CREATE PROC NUEVO_TIQUETE
	@doc VARCHAR(11),
	@estado INT,
	@numVuelo BIGINT
AS
INSERT INTO TIQUETE VALUES(@numVuelo, @doc, GETDATE(), @estado)
GO


SELECT * FROM TIQUETE