CREATE TABLE posicoes(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(20)
);

CREATE TABLE esportes(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(60),
	id_clube INTEGER,
	quantidade_jogadores_time INT,
	quantidade_atletas_clube INT,
	local_praticado VARCHAR(50),
	
	FOREIGN KEY (id_clube) REFERENCES clubes(id),
);

CREATE TABLE clubes(
	id INTEGER PRIMARY KEY IDENTITY(1,1),

	id_tecnico INTEGER,

	nome VARCHAR(72),
	cidade_sede VARCHAR(60),
	ano_fundacao DATETIME2

	FOREIGN KEY (id_tecnico) REFERENCES tecnicos(id)
);

CREATE TABLE jogadores(
	id INTEGER PRIMARY KEY IDENTITY(1,1),

	id_posicao INTEGER,
	id_clube INTEGER,

	nome VARCHAR(50),
	genero VARCHAR(20),
	cpf VARCHAR(14),
	data_nascimento DATETIME2,

	FOREIGN KEY (id_posicao) REFERENCES posicoes(id),
	FOREIGN KEY (id_clube) REFERENCES clubes(id)
);

CREATE TABLE competicoes(
	id INTEGER PRIMARY KEY IDENTITY(1,1),

	id_esportes INTEGER,

	nome VARCHAR(30),
	data_inicio DATETIME2,
	data_termino DATETIME2,

	FOREIGN KEY (id_esportes) REFERENCES esportes(id)
);

CREATE TABLE tecnicos(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(50),
	cpf VARCHAR(14),
	data_nascimento DATETIME2,
	cidade_natal VARCHAR(60)
);
