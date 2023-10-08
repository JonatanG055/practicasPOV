CREATE DATABASE GestionEstudiantes;
USE GestionEstudiantes;

CREATE TABLE Estudiantes
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre VARCHAR(50),
    Codigo VARCHAR(20),
    Telefono VARCHAR(15),
    Ciudad VARCHAR(50)
);
