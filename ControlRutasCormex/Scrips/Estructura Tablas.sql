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

Go

CREATE PROCEDURE InsertarEmpleado
    @Nombre VARCHAR(15),
    @ApellidoPaterno VARCHAR(15),
    @ApellidoMaterno VARCHAR(15),
    @FechaNacimiento DATE,
    @Sueldo DECIMAL(10,2),
    @IdCiudad INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Validar mayoría de edad
    IF (DATEDIFF(YEAR, @FechaNacimiento, GETDATE()) < 18)
    BEGIN
        RAISERROR('El empleado debe ser mayor de edad', 16, 1);
        RETURN;
    END

    -- Insertar empleado
    INSERT INTO Empleados (
        Nombre,
        ApellidoPaterno,
        ApellidoMaterno,
        FechaNacimiento,
        Sueldo,
        IdCiudad,
        Activo
    )
    VALUES (
        @Nombre,
        @ApellidoPaterno,
        @ApellidoMaterno,
        @FechaNacimiento,
        @Sueldo,
        @IdCiudad,
        1
    );

    -- Opcional: devolver el ID insertado
    SELECT SCOPE_IDENTITY() AS IdEmpleado;
END;

SELECT * FROM Empleados;

Go

CREATE PROCEDURE ActualizarEmpleado
    @IdEmpleado INT,
    @FechaNacimiento DATE,
    @Sueldo DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;

    IF (DATEDIFF(YEAR, @FechaNacimiento, GETDATE()) < 18)
    BEGIN
        RAISERROR('El empleado debe ser mayor de edad', 16, 1);
        RETURN;
    END

    IF (@Sueldo <= 0)
    BEGIN
        RAISERROR('El sueldo debe ser mayor a cero', 16, 1);
        RETURN;
    END

    UPDATE Empleados
    SET FechaNacimiento = @FechaNacimiento,
        Sueldo = @Sueldo
    WHERE IdEmpleado = @IdEmpleado;
END;
Go


IF OBJECT_ID('ActualizarRuta', 'P') IS NOT NULL
    DROP PROCEDURE ActualizarRuta;
GO

CREATE PROCEDURE ActualizarRuta
    @IdRuta INT,
    @Tipo INT,
    @Capacidad INT,
    @IdEmpleado INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Validar tipo
    IF (@Tipo NOT IN (1,2))
    BEGIN
        RAISERROR('Tipo inválido', 16, 1);
        RETURN;
    END

    -- Validar capacidad
    IF (@Capacidad <= 0)
    BEGIN
        RAISERROR('La capacidad debe ser mayor a cero', 16, 1);
        RETURN;
    END

    -- Validar capacidad por tipo
    IF (@Tipo = 1 AND @Capacidad > 34)
    BEGIN
        RAISERROR('Máximo 34 para Personal', 16, 1);
        RETURN;
    END

    IF (@Tipo = 2 AND @Capacidad > 100)
    BEGIN
        RAISERROR('Máximo 100 para Artículos', 16, 1);
        RETURN;
    END

    -- Validar chofer
    IF (@IdEmpleado IS NULL)
    BEGIN
        RAISERROR('Debe seleccionar un chofer', 16, 1);
        RETURN;
    END

    -- Actualizar
    UPDATE Rutas
    SET 
        Tipo = @Tipo,
        Capacidad = @Capacidad,
        IdEmpleado = @IdEmpleado
    WHERE IdRuta = @IdRuta;
END;
go
-- Cambiamos el tipo de dato de 15 a 150 caracteres
ALTER TABLE Rutas
ALTER COLUMN NombreRuta VARCHAR(150) NOT NULL;
Go
ALTER PROCEDURE InsertarRuta
    @NombreRuta VARCHAR(150), -- Actualizamos de 15 a 150
    @Tipo INT,
    @Capacidad INT,
    @IdCiudad INT,
    @IdEmpleado INT
AS
BEGIN
    INSERT INTO Rutas (NombreRuta, Tipo, Capacidad, IdCiudad, IdEmpleado)
    VALUES (@NombreRuta, @Tipo, @Capacidad, @IdCiudad, @IdEmpleado);
END