use master
go
drop database condomanagerdb
go

create database condomanagerdb
go
use condomanagerdb
go

create schema condomanager
go


CREATE TABLE CONDOMANAGER.Gestor_Condominio(
	NIF VARCHAR(9),
	Nome VARCHAR(40) NOT NULL,
	Telemovel VARCHAR(9) NOT NULL UNIQUE,
	Email VARCHAR(40) NOT NULL UNIQUE,
	hashed_pass VARCHAR(40) NOT NULL,

	PRIMARY KEY(NIF)
)

 CREATE TABLE CONDOMANAGER.Condominio(
	Endereco VARCHAR(40),
	Orcam_Anual MONEY,
	nif_gestor varchar(9),
	PRIMARY KEY(Endereco),
	foreign key(nif_gestor) references CONDOMANAGER.Gestor_Condominio(nif)
 )

 CREATE TABLE CONDOMANAGER.Condomino(
	NIF varchar(9),
	Nome VARCHAR(40) NOT NULL,
	Telemovel VARCHAR(9) NOT NULL UNIQUE,
	Email VARCHAR(40) NOT NULL UNIQUE,
	PRIMARY KEY(NIF),
)

 CREATE TABLE CONDOMANAGER.Fracao(
	Ref_fracao varchar(5),
	Endereco varchar(40),
	Permilagem money not null,
	piso varchar(5) not null,
	leitura_gas float,
	leitura_luz float,
	leitura_agua float,
	nif_condomino varchar(9),
	PRIMARY KEY(Ref_fracao, Endereco), 
	FOREIGN KEY(Endereco) references CONDOMANAGER.Condominio(Endereco),
	foreign key(nif_condomino) references condomanager.condomino(nif)
 )

 


 CREATE TABLE CONDOMANAGER.Reclamacao(
	Id int not null Identity(1,1),
	Data date,
	Descricao varchar(100),
	nif_condomino varchar(9),
	nif_gestor varchar(9),
	endereco varchar(40),
	ref_fracao varchar(5)
	PRIMARY KEY(Id),
	foreign key (nif_condomino) references CONDOMANAGER.condomino(nif),
	foreign key (nif_gestor) references CONDOMANAGER.gestor_condominio(nif),
	foreign key (ref_fracao, endereco) references CONDOMANAGER.fracao(ref_fracao, endereco)
 )

 CREATE TABLE CONDOMANAGER.Reuniao(
	Id int not null Identity(1,1),
	Nome varchar(40),
	Data date,
	Descricao varchar(100),
	localizacao varchar(40),
	nif_gestor varchar(9),
	PRIMARY KEY(Id),
	foreign key(nif_gestor) references CONDOMANAGER.Gestor_Condominio(nif)
 )

 CREATE TABLE CONDOMANAGER.Reparacao(
	Id int not null Identity(1,1),
	Nome varchar(40),
	Data date,
	Descricao varchar(100),
	Danificado varchar(50),
	nif_gestor varchar(9),
	PRIMARY KEY(Id),
	foreign key(nif_gestor) references condomanager.gestor_condominio(nif)
 )

  CREATE TABLE CONDOMANAGER.Tipo_Fornecedor(
	Id int,
	Descricao varchar(40),
	PRIMARY KEY(Id)
 )

 CREATE TABLE CONDOMANAGER.Fornecedor_Servicos(
	NIF varchar(9),
	Nome varchar(15),
	Telemovel varchar(9),
	Morada varchar(40),
	tipo int
	PRIMARY KEY(NIF)
	foreign key(tipo) references condomanager.tipo_fornecedor(id)
 )


 CREATE TABLE CONDOMANAGER.Pagamento_Quotas(
	Id int not null Identity(1,1),
	Data date,
	NIF_condomino varchar(9),
	Descricao varchar(100),
	Valor money,
	PRIMARY KEY(Id),
	foreign key(nif_condomino) references condomanager.condomino(nif)
 )
 CREATE TABLE CONDOMANAGER.Fatura_Quotas(
	Id_Fatura int not null Identity(1,1),
	Data date,
	nif_gestor varchar(9),
	nif_Consumidor varchar(9),
	id_pagamento int,
	Quantia money,

	PRIMARY KEY(Id_Fatura),
	foreign key(nif_gestor) references condomanager.gestor_condominio(nif),
	foreign key(nif_consumidor) references condomanager.condomino(nif),
	foreign key(id_pagamento) references condomanager.pagamento_quotas(id)
 )

  CREATE TABLE CONDOMANAGER.Pagamento_Servicos(
	Id int not null Identity(1,1),
	Data date,
	NIF_gestor varchar(9),
	Descricao varchar(40),
	Valor money,
	PRIMARY KEY(Id),
	foreign key(nif_gestor) references condomanager.gestor_condominio(nif)

 )


 CREATE TABLE CONDOMANAGER.Fatura_Servicos(
	Id_Fatura int not null identity(1,1),
	Data date,
	Id_Fornec varchar(9),
	Id_Consumidor varchar(9),
	id_pagamento int,
	Quantia money,

	PRIMARY KEY(Id_Fatura),
	foreign key(id_fornec) references condomanager.fornecedor_servicos(nif),
	foreign key (id_consumidor) references condomanager.gestor_condominio(nif),
	foreign key( id_pagamento) references condomanager.pagamento_servicos(id)

 )

 Create table condomanager.fotosprediais(
	id varchar(40),
	localizacao varchar(256),
	primary key(localizacao, id),
	foreign key(id) references condomanager.condominio(endereco)
 
 )

 Insert into condomanager.Gestor_Condominio(NIF, Nome, Telemovel, Email, hashed_pass) values
			('250238280', 'Joaquim Inácio', '918273646', 'joaquim.inac@sapo.pt', 'pass123'),
			('123876530', 'João Melão', '927659386', 'joao.melao@sapo.pt', 'pass123'),
			('265904536', 'Pedro Vieira', '967230185', 'pedro.vieira@sapo.pt', 'pass123')

insert into condomanager.Condominio(Endereco, Orcam_Anual, nif_gestor) values
			('Rua São Martinho', 10000, '250238280'),
			('Rua Nova', 20000, '123876530'),
			('Avenida dos Combatentes', 50000, '265904536'),
			('Rua 25 de Abril', 40000, '250238280'),
			('Rua Direita', 340000, '123876530'),
			('Avenida Guerra Junqueiro', 500000, '265904536')


insert into condomanager.Condomino(NIF, Nome, Email, Telemovel) values
			('213564756', 'Maria Albertina', 'maria.albertina@sapo.pt', '918278497'),
			('263547859', 'Carlos Costa', 'carlos.costa@sapo.pt', '918276476'),
			('126374659', 'Tomás Ferreira', 'tomas.ferreira@sapo.pt', '254673875'),
			('167485967', 'Diogo Teixeira', 'diogo.teixeira@sapo.pt', '938476583'),
			('143567467', 'Joana Madalena', 'joana.madalena@sapo.pt', '917283746'),
			('237168594', 'Tiago Andrade', 'tiago.andrade@sapo.pt', '918276473'),
			('216374865', 'Rúben Matias', 'ruben.matias@sapo.pt', '918274630')







insert into condomanager.Fracao(Endereco, Ref_fracao, Permilagem, piso, nif_condomino) values
			('Rua São Martinho', 'A1', 10000, 'RC/D','213564756'),
			('Rua São Martinho', 'A2', 3000, 'RC/E', '263547859'),
			('Rua São Martinho', 'A3', 100, '1Dt','126374659'),
			('Rua São Martinho', 'A4', 12300, '1Esq', '167485967'),
			('Rua São Martinho', 'A5', 1000, '2DT', '213564756'),
			('Rua São Martinho', 'A6', 10000, '2Esq', '143567467'),
			('Rua Nova', 'A1', 123743, 'RC/D', '237168594'),
			('Rua Nova', 'A2', 12243, 'RC/E', '216374865'),
			('Rua Nova', 'A3', 121743, '1Dt', '213564756'),
			('Avenida dos Combatentes','B1', 12322, 'RC/D', '237168594'),
			('Avenida dos Combatentes','B2', 12322, 'RC/E', '216374865')


select * from condomanager.Condomino join condomanager.Fracao on nif=nif_condomino where endereco='Rua Nova'