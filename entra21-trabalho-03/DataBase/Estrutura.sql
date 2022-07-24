CREATE TABLE posicoes(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(20)
);

CREATE TABLE paises(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(60),
	continente VARCHAR(10)
);

CREATE TABLE clubes(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(72),
	cidade_sede VARCHAR(60),
);

CREATE TABLE jogadores(
	id INTEGER PRIMARY KEY IDENTITY(1,1),

	id_posicao INTEGER,
	id_clube INTEGER,

	nome VARCHAR(50),
	cpf VARCHAR(14),
	data_nascimento DATETIME2,

	FOREIGN KEY (id_posicao) REFERENCES posicoes(id),
	FOREIGN KEY (id_clube) REFERENCES clubes(id)
);

CREATE TABLE competicoes(
	id INTEGER PRIMARY KEY IDENTITY(1,1),

	id_pais INTEGER,

	nome VARCHAR(30),
	data_inicio DATETIME2,
	data_termino DATETIME2
);


CREATE TABLE tecnicos(
	id INTEGER PRIMARY KEY IDENTITY(1,1),

	id_clube INTEGER,

	nome VARCHAR(50),
	cpf VARCHAR(14),
	data_nascimento DATETIME2,

	FOREIGN KEY (id_clube) REFERENCES clubes(id)
);