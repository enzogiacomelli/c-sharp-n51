﻿--CREATE TABLE estantes(
--	id INT PRIMARY KEY IDENTITY(1, 1),
--	NOME VARCHAR(25),
--	SIGLA VARCHAR(3)
--);

--select id, nome from categorias;

--select id, nome, sigla from estantes

--select id, nome, sigla from estantes WHERE nome LIKE '%ant%'

--CREATE TABLE produtos(
--	id INT PRIMARY KEY IDENTITY(1, 1),
--	nome VARCHAR(150) NOT NULL,
--	preco_unitario DECIMAL(10,2) NOT NULL,
--	id_categoria INT NOT NULL,
--	FOREIGN KEY (id_categoria) REFERENCES categorias(id)
--);


--INSERT INTO categorias (nome) VALUES
--	('Padaria'),
--	('Limpeza'),
--	('Higiene'),
--	('Frutas'),
--	('Verduras');

--INSERT INTO produtos (nome, preco_unitario, id_categoria) VALUES
--	('Ajax multiuso', 16.00, 8),
--	('Sabonete Dove', 4.99, 9);


select * from produtos
select * from categorias


