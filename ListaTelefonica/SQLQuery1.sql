CREATE TABLE TiposTel
(
	[idTipo] INT IDENTITY (1,1) NOT NULL PRIMARY KEY,
	[nome] NVARCHAR(MAX)
);

INSERT INTO TiposTel (nome) VALUES ('Celular');
INSERT INTO TiposTel (nome) VALUES ('Telefone');