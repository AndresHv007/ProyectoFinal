
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: Asignatura
DROP TABLE IF EXISTS Asignatura;

CREATE TABLE Asignatura (
    IDAsignatura INTEGER PRIMARY KEY AUTOINCREMENT,
    IDProfesor     INTEGER REFERENCES Profesor (IDProfesor),
    IDMateria     INTEGER REFERENCES Materia (IDMateria),
    IDGrupo       INTEGER REFERENCES GrupoEnEscuela (IDGrupo) 
);


-- Table: Grupo
DROP TABLE IF EXISTS GrupoEnEscuela;

CREATE TABLE GrupoEnEscuela (
    IDGrupo      INTEGER       PRIMARY KEY AUTOINCREMENT,
    IDTipoPeriodo INTEGER REFERENCES TipoPeriodo (IDTipoPeriodo),
    Nombre         VARCHAR (10),
    FechaInicio    DATE,
    FechaFinal    DATE
);


-- Table: TipoPeriodo
DROP TABLE IF EXISTS TipoPeriodo;

CREATE TABLE TipoPeriodo (
    IDTipoPeriodo INTEGER       PRIMARY KEY AUTOINCREMENT,
    Nombre         VARCHAR (100),
    Meses       INT
);


-- Table: Materia
DROP TABLE IF EXISTS Materia;

CREATE TABLE Materia (
    IDMateria        INTEGER       PRIMARY KEY AUTOINCREMENT,
    Nombre             VARCHAR (100),
    HorasTeoricas INT (10),
    HorasPracticas   INT (10) 
);


-- Table: Profesor
DROP TABLE IF EXISTS Profesor;

CREATE TABLE Profesor (
    IDProfesor     INTEGER       PRIMARY KEY AUTOINCREMENT,
    IDTipoProfesor INTEGER           REFERENCES TipoProfesor (IDTipoProfesor),
    PrimerNombre     VARCHAR (100),
    SegundoNombre    VARCHAR (100),
    ApellidoPaterno  VARCHAR (100),
    ApellidoMaterno VARCHAR (100),
    FechaNacimiento   DATE,
    RFC           VARCHAR (100),
    CURP          VARCHAR (100),
    Nomina INT (50),
    Contraseña      VARCHAR (100) 
);


-- Table: TipoProfesor
DROP TABLE IF EXISTS TipoProfesor;

CREATE TABLE TipoProfesor (
    IDTipoProfesor INTEGER       PRIMARY KEY AUTOINCREMENT,
    Nombre          VARCHAR (100),
    HorasMinimasTrabajadas      INT,
    HorasMaximasTrabajadas      INT
);


-- Table: ProfesorMateria
DROP TABLE IF EXISTS ProfesorMateria;

CREATE TABLE ProfesorMateria (
    IDProfesorMateria INTEGER PRIMARY KEY AUTOINCREMENT,
    IDProfesor        INTEGER REFERENCES Profesor (IDProfesor),
    IDMateria        INTEGER REFERENCES Materia (IDMateria) 
);


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;  