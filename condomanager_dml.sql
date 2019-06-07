use condomanagerdb
go


Insert into condomanager.Gestor_Condominio(NIF, Nome, Telemovel, Email, hashed_pass) values
			('250238280', 'Joaquim In�cio', '918273646', 'joaquim.inac@sapo.pt', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8'),
			('123876530', 'Jo�o Mel�o', '927659386', 'joao.melao@sapo.pt', 'pass123'),
			('265904536', 'Pedro Vieira', '967230185', 'pedro.vieira@sapo.pt', 'pass123')

insert into condomanager.Condominio(Endereco, Orcam_Anual, nif_gestor) values
			('Rua S�o Martinho', 10000, '250238280'),
			('Rua Nova', 20000, '123876530'),
			('Avenida dos Combatentes', 50000, '265904536'),
			('Rua 25 de Abril', 40000, '250238280'),
			('Rua Direita', 340000, '123876530'),
			('Avenida Guerra Junqueiro', 500000, '265904536')


insert into condomanager.Condomino(NIF, Nome, Email, Telemovel) values
			('213564756', 'Maria Albertina', 'maria.albertina@sapo.pt', '918278497'),
			('263547859', 'Carlos Costa', 'carlos.costa@sapo.pt', '918276476'),
			('126374659', 'Tom�s Ferreira', 'tomas.ferreira@sapo.pt', '254673875'),
			('167485967', 'Diogo Teixeira', 'diogo.teixeira@sapo.pt', '938476583'),
			('143567467', 'Joana Madalena', 'joana.madalena@sapo.pt', '917283746'),
			('237168594', 'Tiago Andrade', 'tiago.andrade@sapo.pt', '918276473'),
			('216374865', 'R�ben Matias', 'ruben.matias@sapo.pt', '918274630')







insert into condomanager.Fracao(Endereco, Ref_fracao, Permilagem, piso, nif_condomino) values
			('Rua S�o Martinho', 'A1', 100, 'RC/D','213564756'),
			('Rua S�o Martinho', 'A2', 200, 'RC/E', '263547859'),
			('Rua S�o Martinho', 'A3', 200, '1Dt','126374659'),
			('Rua S�o Martinho', 'A4', 200, '1Esq', '167485967'),
			('Rua S�o Martinho', 'A5', 110, '2DT', '213564756'),
			('Rua S�o Martinho', 'A6', 90, '2Esq', '143567467'),
			('Rua Nova', 'A1', 100, 'RC/D', '237168594'),
			('Rua Nova', 'A2', 200, 'RC/E', '216374865'),
			('Rua Nova', 'A3', 75, '1Dt', '213564756'),
			('Avenida dos Combatentes','B1', 350, 'RC/D', '237168594'),
			('Avenida dos Combatentes','B2', 200, 'RC/E', '216374865')

insert into condomanager.Fracao(Endereco, Ref_fracao, Permilagem, piso) values
			('Rua S�o Martinho', 'A7', 100, 'Loft')

insert into condomanager.Reclamacao(endereco, ref_fracao, nif_condomino, Data, Descricao) values
			('Rua S�o Martinho', 'A3', '126374659', '20190604', 'Contador da �gua com valores acima do normal'),
			('Rua S�o Martinho', 'A1', '213564756', '20190604', 'Contador da luz com valores acima do normal'),
			('Rua Nova', 'A2','216374865', '20190601', 'Luz da entrada fundida'),
			('Avenida dos Combatentes', 'B2', '216374865', '20190602', 'Quadro El�trico estragado')

insert into condomanager.Reclamacao(endereco_cond, nif_condomino, Data, Descricao) values
			('Avenida dos Combatentes', '237168594', '20190603', 'Elevador n�o funcional')
			


insert into condomanager.Tipo_Fornecedor(Id, Descricao) values
			(1, 'Fornecedor de �gua'),
			(2, 'Fornecedor de Luz'),
			(3, 'Fornecedor de G�s'),
			(4, 'Fornecedor de Material de Repara��o'),
			(5, 'Forencedor de Material de Construc�o')

insert into condomanager.Fornecedor_Servicos(NIF, Nome, Morada, Telemovel, tipo) values
			('501654738', 'Endesa', 'Rua Marqu�s de Pombal', '213423569', 2),
			('501276453', 'GALP Energia', 'Rua da Constitui��o', '217635487', 3),
			('502645787', '�guas de Portugal', 'Pra�eta de Lisboa', '217489203', 1),
			('501746539', 'ReparaTudo', 'Rua de Espinho', '228376476', 4),
			('504982746', 'Cimento&Afins', 'Rua da Ladra', '217364895', 5)


insert into condomanager.Reparacao(Nome, Data, Danificado, Descricao, endereco) values
			('Mudan�a da Luz', '20190603', 'Luz da entrada', 'Mudou-se a luz da entrada', 'Rua Nova'),
			('Composto o elevador', '20190610', 'Elevador', 'Motor do Elevador', 'Rua S�o Martinho')


insert into condomanager.Reuniao(Nome, Data, Descricao, localizacao, endereco) values
			('Mudan�a de Or�amento', '20190610', 'Altera��o do Or�amento do 1� Direito', 'Cave do edificio da Rua S�o Martinho',
			 'Rua S�o Martinho')

insert into condomanager.Fatura_Servicos( nif_Fornec, endereco, Data, Quantia, descricao) values
			('501654738', 'Rua Direita', '20190617',65, 'Pagamento da Luz do pr�dio'),
			('501654738', 'Rua Direita', '20190617',66, 'Pagamento da agua do pr�dio')


insert into condomanager.Reuniao(Nome, Data, Descricao, localizacao, endereco) values
			('Mudan�a de Or�amento 2', '20190611', 'Altera��o do Or�amento do 1� Direito', 'Cave do edificio da Rua S�o Martinho',
			 'Rua S�o Martinho')

insert into condomanager.Fatura_Quotas(descricao, Data, endereco, ref_fracao, Quantia) values
	('Pagamento Quota Junho 2019', '20190608 12:00:00', 'Rua S�o Martinho', 'A1', 60),
	('Pagamento Quota Junho 2018', '20190608 12:00:00', 'Rua S�o Martinho', 'A1', 60)