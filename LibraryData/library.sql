--
-- File generated with SQLiteStudio v3.3.3 on Wed Sep 29 21:01:31 2021
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: book
DROP TABLE IF EXISTS book;

CREATE TABLE book (
    BookName         VARCHAR,
    Author           VARCHAR,
    Photo            BLOB,
    YearOfPublishing INTEGER,
    id               INTEGER PRIMARY KEY AUTOINCREMENT
                             NOT NULL
);


-- Table: Client
DROP TABLE IF EXISTS Client;

CREATE TABLE Client (
    NameOfClient VARCHAR,
    Age          INTEGER,
    LibraryID    INTEGER,
    id           INTEGER PRIMARY KEY AUTOINCREMENT
                         NOT NULL
);


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
