CREATE DATABASE ReliableAirlines

GO

USE ReliableAirlines

GO

CREATE TABLE USUARIO
(
	documento VARCHAR(11) PRIMARY KEY NOT NULL,
	tipoDocumento VARCHAR(3) NOT NULL,
	usuario VARCHAR(20) NOT NULL,
	contraseņa VARCHAR(32) NOT NULL,
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
	ciudad VARCHAR(30) NOT NULL,
	infoAdicional VARCHAR(250),
	sueldo VARCHAR(10)
	
	CONSTRAINT RELACION_A_USER FOREIGN KEY (documentoUsuario) REFERENCES USUARIO (documento) 
	ON UPDATE CASCADE,
)
GO

CREATE TABLE AERONAVE
(
	idAeronave VARCHAR(7) PRIMARY KEY NOT NULL,
	tipo VARCHAR(20) NOT NULL,
	capacidadPrimeraClase INT NOT NULL,
	capacidadClaseTurista INT NOT NULL,
	proveedor VARCHAR(20) NOT NULL,
	capacidadEquipaje INT NOT NULL,
	fechaAdquisicion DATE NOT NULL
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
	estado INT NOT NULL,
	nombre VARCHAR(20) NOT NULL,

	CONSTRAINT RELACION_AL_ESTADO FOREIGN KEY(estado) REFERENCES ESTADOS(id),
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

CREATE TABLE RUTA
(
	idRuta BIGINT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	nombreRuta VARCHAR(15) NOT NULL,
	aerOrigen INT NOT NULL,
	aerDestino INT NOT NULL,
	estado VARCHAR(8) NOT NULL,
	
	CONSTRAINT LLAMADO_A_AEROPUERTO_ORIGEN FOREIGN KEY (aerOrigen) REFERENCES AEROPUERTOS(idAeropuerto),
	CONSTRAINT LLAMADO_A_AEROPUERTO_DESTINO FOREIGN KEY (aerDestino) REFERENCES AEROPUERTOS(idAeropuerto)
)

GO

CREATE TABLE VUELO
(
	numVuelo BIGINT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	idRuta BIGINT NOT NULL,
	idAeronave VARCHAR(7),
	pClase INT,
	tClase INT,
	salida DATETIME NOT NULL,
	llegada DATETIME NOT NULL,
	vlrPrimeraClase VARCHAR(10),
	vlrClaseTurista VARCHAR(10),

	CONSTRAINT RELACION_A_AERONAVE FOREIGN KEY (idAeronave) REFERENCES AERONAVE(idAeronave),
	CONSTRAINT RELACION_A_RUTA FOREIGN KEY (idRuta) REFERENCES RUTA(idRuta)
)

GO

CREATE TABLE TIQUETE
(
	idTiquete BIGINT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	numVuelo BIGINT NOT NULL,
	docCliente VARCHAR(11) NOT NULL,

	CONSTRAINT RELACION_A_CLIENTE FOREIGN KEY (docCliente) REFERENCES CLIENTE(documentoUsuario),
	CONSTRAINT RELACION_A_VUELO FOREIGN KEY (numVuelo) REFERENCES VUELO(numVuelo)
)

GO

-----------------------------------------PROCEDIMIENTOS ALMACENADOS--------------------------------

CREATE PROC REGISTRO_EMPLEADO
	@documento VARCHAR(11),
	@tipoDocumento VARCHAR(2),
	@usuario VARCHAR(20),
	@contraseņa VARCHAR(32),
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
	@sueldo VARCHAR(10)
AS
INSERT INTO USUARIO VALUES(@documento,@tipoDocumento,@usuario,@contraseņa,@permisos,
							@nombres,@apellidos,@fechaNacimiento,@email,@telefono)
INSERT INTO EMPLEADO VALUES(@documento,@tipoContrato,@puesto,@cuenta,@tipoCuenta,@banco,
							@EPS,@direccion,@ciudad,@infoAdicional,@sueldo)
GO

CREATE PROC INICIAR_SESION
@Usuario VARCHAR(20),
@contraseņa VARCHAR(32)
AS
SELECT documento, permisos FROM USUARIO WHERE usuario=@Usuario AND contraseņa=@contraseņa

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
	@contraseņa VARCHAR(32),
	@permisos VARCHAR(4),
	@nombres VARCHAR(30),
	@apellidos VARCHAR(30),
	@fechaNacimiento DATE,
	@email VARCHAR(35),
	@telefono VARCHAR(10)
AS
INSERT INTO USUARIO VALUES(@documento,@tipoDocumento,@usuario,@contraseņa,@permisos,
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
	@sueldo VARCHAR(10)
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
	sueldo=@sueldo
WHERE documentoUsuario=@documento

GO

CREATE PROC CREAR_PAIS
	@nombre VARCHAR(20)
AS
INSERT INTO PAISES VALUES(@nombre)

GO

CREATE PROC CREAR_ESTADO
	@nombre VARCHAR(20),
	@pais INT
AS
INSERT INTO ESTADOS VALUES(@nombre, @pais)

GO

CREATE PROC CREAR_CIUDAD
	@pais VARCHAR(20),
	@estado VARCHAR(20),
	@ciudad VARCHAR(20)
AS
INSERT INTO CIUDADES VALUES(@pais,@estado,@ciudad)

GO

CREATE PROC CREAR_AEROPUERTO
	@nombre VARCHAR(20),
	@ciudad INT
AS
INSERT INTO AEROPUERTOS VALUES(@nombre,@ciudad)

GO

CREATE PROC CONSULTA_PAISES
AS
SELECT * FROM PAISES

GO

