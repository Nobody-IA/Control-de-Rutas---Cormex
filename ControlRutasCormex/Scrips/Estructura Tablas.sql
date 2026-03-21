create database ControlRutasCormex

USE ControlRutasCormex

CREATE TABLE Ciudades (
    IdCiudad INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL
);

INSERT INTO Ciudades (Nombre) 
VALUES 
('Angostura'),
('Badiraguato'),
('Choix'),
('Concordia'),
('Cosalá'),
('Culiacán Rosales'),
('Eldorado'),
('El Fuerte'),
('El Rosario'),
('Escuinapa de Hidalgo'),
('Guamúchil'),
('Guasave'),
('Juan José Ríos'),
('La Cruz'),
('Los Mochis'),
('Mazatlán'),
('Mocorito'),
('Navolato'),
('San Ignacio'),
('Sinaloa de Leyva');

CREATE TABLE Empleados (
    IdEmpleado INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(15) NOT NULL,
    ApellidoPaterno VARCHAR(15) NOT NULL,
    ApellidoMaterno VARCHAR(15) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    Sueldo DECIMAL(10,2) NOT NULL,
    IdCiudad INT NOT NULL,
    Activo BIT DEFAULT 1,

    CONSTRAINT FK_Empleado_Ciudad FOREIGN KEY (IdCiudad)
    REFERENCES Ciudades(IdCiudad)
);

CREATE TABLE Rutas (
    IdRuta INT IDENTITY(1,1) PRIMARY KEY,
    NombreRuta VARCHAR(15) NOT NULL,
    Tipo INT NOT NULL, -- 1 = Personal, 2 = Artículos
    Capacidad INT NOT NULL,
    IdCiudad INT NOT NULL,
    IdEmpleado INT NOT NULL,

    CONSTRAINT FK_Ruta_Ciudad FOREIGN KEY (IdCiudad)
    REFERENCES Ciudades(IdCiudad),

    CONSTRAINT FK_Ruta_Empleado FOREIGN KEY (IdEmpleado)
    REFERENCES Empleados(IdEmpleado)
);

ALTER TABLE Rutas
ADD CONSTRAINT CHK_Tipo CHECK (Tipo IN (1,2));

ALTER TABLE Rutas
ADD CONSTRAINT CHK_Capacidad
CHECK (
    (Tipo = 1 AND Capacidad <= 34) OR
    (Tipo = 2 AND Capacidad <= 100)
);

ALTER TABLE Rutas
ADD CONSTRAINT FK_Ruta_Empleado_NoDelete
FOREIGN KEY (IdEmpleado)
REFERENCES Empleados(IdEmpleado)
ON DELETE NO ACTION;

GO 
CREATE PROCEDURE InsertarRuta
    @NombreRuta VARCHAR(15),
    @Tipo INT,
    @Capacidad INT,
    @IdCiudad INT,
    @IdEmpleado INT
AS 
BEGIN
    INSERT INTO Rutas (NombreRuta, Tipo, Capacidad, IdCiudad, IdEmpleado)
    VALUES (@NombreRuta, @Tipo, @Capacidad, @IdCiudad, @IdEmpleado);
END;


GO


CREATE PROCEDURE ObtenerRutasPorCiudad
    @IdCiudad INT
AS
BEGIN
    SELECT 
        R.IdRuta,
        R.NombreRuta,
        R.Tipo,
        R.Capacidad,
        E.Nombre + ' ' + E.ApellidoPaterno AS Chofer
    FROM Rutas R
    INNER JOIN Empleados E ON R.IdEmpleado = E.IdEmpleado
    WHERE R.IdCiudad = @IdCiudad;
END;

