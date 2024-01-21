CREATE TABLE estantes(
	id INT PRIMARY KEY IDENTITY(1, 1),
	NOME VARCHAR(25),
	SIGLA VARCHAR(3)
);

select id, nome from categorias;

select id, nome, sigla from estantes

