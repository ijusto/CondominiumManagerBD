--use p2g8
use condomanagerdb
go

 




Insert into condomanager.Gestor_Condominio(NIF, Nome, Telemovel, Email, hashed_pass) values
			('250238280', 'Joaquim Inácio', '918273646', 'joaquim.inac@sapo.pt', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8'),
			('123876530', 'João Melão', '927659386', 'joao.melao@sapo.pt', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8'),
			('265904536', 'Pedro Vieira', '967230185', 'pedro.vieira@sapo.pt', '5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8')

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







insert into condomanager.Fracao(Endereco, Ref_fracao, Permilagem, piso, nif_condomino, leitura_agua, leitura_gas, leitura_luz) values
			('Rua São Martinho', 'A1', 100, 'RC/D','213564756', 130, 120, 345),
			('Rua São Martinho', 'A2', 200, 'RC/E', '263547859', 234, 126, 178),
			('Rua São Martinho', 'A3', 200, '1Dt','126374659', 187, 265, 97),
			('Rua São Martinho', 'A4', 200, '1Esq', '167485967', 167, 111, 67),
			('Rua São Martinho', 'A5', 110, '2DT', '213564756', 175, 265, 999),
			('Rua São Martinho', 'A6', 90, '2Esq', '143567467', 726, 165, 34),
			('Rua Nova', 'A1', 100, 'RC/D', '237168594', 62, 156, 183),
			('Rua Nova', 'A2', 200, 'RC/E', '216374865', 23, 165, 176),
			('Rua Nova', 'A3', 75, '1Dt', '213564756', 108, 203, 367),
			('Avenida dos Combatentes','B1', 350, 'RC/D', '237168594', 164, 238, 145),
			('Avenida dos Combatentes','B2', 200, 'RC/E', '216374865', 198, 256, 356)

insert into condomanager.Fracao(Endereco, Ref_fracao, Permilagem, piso) values
			('Rua São Martinho', 'A7', 100, 'Loft')


insert into condomanager.tipo_reclamacao(tipo, descricao) values
			(1, 'Reclamação relativa a uma fração'),
			(2, 'Reclamação relativa a um condomínio')

insert into condomanager.Reclamacao(endereco, ref_fracao, nif_condomino, Data, Descricao, tipo) values
			('Rua São Martinho', 'A3', '126374659', '20190604', 'Contador da água com valores acima do normal',1),
			('Rua São Martinho', 'A1', '213564756', '20190604', 'Contador da luz com valores acima do normal',1),
			('Rua Nova', 'A2','216374865', '20190601', 'Luz da entrada fundida',1),
			('Avenida dos Combatentes', 'B2', '216374865', '20190602', 'Quadro Elétrico estragado',1)

insert into condomanager.Reclamacao(endereco, nif_condomino, Data, Descricao, tipo) values
			('Avenida dos Combatentes', '237168594', '20190603', 'Elevador não funcional',2)
			


insert into condomanager.Tipo_Fornecedor(Id, Descricao) values
			(1, 'Fornecedor de Água'),
			(2, 'Fornecedor de Luz'),
			(3, 'Fornecedor de Gás'),
			(4, 'Fornecedor de Material de Reparação'),
			(5, 'Forencedor de Material de Construcão')

insert into condomanager.Fornecedor_Servicos(NIF, Nome, Morada, Telemovel, tipo) values
			('501654738', 'Endesa', 'Rua Marquês de Pombal', '213423569', 2),
			('501276453', 'GALP Energia', 'Rua da Constituição', '217635487', 3),
			('502645787', 'Águas de Portugal', 'Praçeta de Lisboa', '217489203', 1),
			('501746539', 'ReparaTudo', 'Rua de Espinho', '228376476', 4),
			('504982746', 'Cimento&Afins', 'Rua da Ladra', '217364895', 5)


insert into condomanager.Reparacao(Nome, Data, Danificado, Descricao, endereco) values
			('Mudança da Luz', '20190603', 'Luz da entrada', 'Mudou-se a luz da entrada', 'Rua Nova'),
			('Composto o elevador', '20190610', 'Elevador', 'Motor do Elevador', 'Rua São Martinho')


insert into condomanager.Reuniao(Nome, Data, Descricao, localizacao, endereco) values
			('Mudança de Orçamento', '20190610', 'Alteração do Orçamento do 1º Direito', 'Cave do edificio da Rua São Martinho',
			 'Rua São Martinho')

insert into condomanager.Fatura_Servicos( nif_Fornec, endereco, Data, Quantia, descricao) values
			('501654738', 'Rua Direita', '20190617',65, 'Pagamento da Luz do prédio'),
			('502645787', 'Rua São Martinho', '20190617',66, 'Pagamento da agua do prédio'),
			('504982746', 'Avenida dos Combatentes', '20190412', 150, 'Pagamento do Elevador'),
			('501746539', 'Rua 25 de Abril', '20190107', 50, 'Pagamento da reparação do quadro elétrico'),
			('502645787', 'Rua Nova', '20190318', 40, 'Pagamento da água do prédio'),
			('501276453', 'Avenida Guerra Junqueiro', '20190605', 20, 'Pagamento da Luz do Prédio')



insert into condomanager.Reuniao(Nome, Data, Descricao, localizacao, endereco) values
			('Mudança de Orçamento 2', '20190611', 'Alteração do Orçamento do 1º Direito', 'Cave do edificio da Rua São Martinho',
			 'Rua São Martinho')

insert into condomanager.Fatura_Quotas(descricao, Data, endereco, ref_fracao, Quantia) values
	('Pagamento Quota Junho 2019', '20190608 12:00:00', 'Rua São Martinho', 'A1', 60),
	('Pagamento Quota Junho 2018', '20190608 12:00:00', 'Rua São Martinho', 'A1', 60)


Insert into condomanager.fotosprediais(endereco, localizacao) values
			('Rua São Martinho','https://vidalasalle.ca/images/community/hero-condos.jpg'),
			('Rua Nova','https://cdn2.torontorentals.com/photos/medium/7d9a1911-55d4-4ad9-ba03-6180384978b8_720x405.jpg'),
			('Avenida dos Combatentes','https://thewindsorcondos.com/wp-content/uploads/2018/04/yourdeveloper_box.jpg'),
			('Rua 25 de Abril','https://images1.apartments.com/i2/HK5HlUEEAcFR_I8vSthPquldbXKJzB_8aT6zFQMRBDs/117/1-br-1-bath-condo---200-n-jefferson-st-1405-chicago-il-foto-principal.jpg'),
			('Rua Direita','http://www.apra-usa.com/resources/Homepage%20Slideshow/condos.jpg'),
			('Avenida Guerra Junqueiro','https://media.propertypassbook.com/rx/848/prime/media/2016/11/the-saxony-condominiums-burlington-maple-0.jpg')

