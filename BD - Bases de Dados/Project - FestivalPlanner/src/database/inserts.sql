/*
	Script to insert data on the Tables from the Databases Project
	Miguel Nogueira & David Araújo
*/
--use Projeto;
use p2g2;

/*	EMPRESAS DE CATERING DONE*/

INSERT INTO FP.EmpresaCatering(nif, nome, email, telefone, endereco)
VALUES (100000012, 'MealsRus', 'mlr@gmail.com', 351236228556, 'Porto, Amarante, R. do Dr. José de Azeredo Perdigão 4');

INSERT INTO FP.EmpresaCatering 
VALUES (123000112, 'Comes&Bebes', 'cb@gmail.com', 351236228456, 'Porto, Baixo, R. Carlos Azevedo Nº 54');

INSERT INTO FP.EmpresaCatering 
VALUES (100540212, 'MiliEventos', 'meventos@gmail.com', 351236333556, 'Aveiro, Avenida Santa Joana, Nº 49');

INSERT INTO FP.EmpresaCatering 
VALUES (101200312, 'MyCatering', 'mc@hotmail.com', 351236222555, 'Aveiro, Avenida Carlos Peixoto, Nº 84'); 

INSERT INTO FP.EmpresaCatering 
VALUES (103120412, 'Food4You', 'f4y@hotmail.com', 351236223553, 'Leiria, Pombal, R. Albergaria dos Doze Nº 14');

INSERT INTO FP.EmpresaCatering 
VALUES (100355512, 'CateringAveiro', 'caveiro@gmail.com', 351236233533, 'Aveiro, Avenida Lourenço Peixinho, Nº 24');

INSERT INTO FP.EmpresaCatering 
VALUES (100011612, 'MealsFromLisbon', 'mfl@gmail.com', 351236111533, 'Lisboa, Cascais, Avenida Alberto Caeiro, Nº 12');

INSERT INTO FP.EmpresaCatering 
VALUES (100132712, 'Eventos Silva', 'esilva@gmail.com', 35123666533, 'Leiria, Rua Dr. Marco Alves, Nº 35');

INSERT INTO FP.EmpresaCatering 
VALUES (100455812, 'MyEvents', 'me@gmail.com', 351236233555, 'Aveiro, Anadia, Rua da Escola, Nº 12');

INSERT INTO FP.EmpresaCatering 
VALUES (101234912, 'OliveiraCatering', 'ocateging@gmail.com', 351236222233, 'Viseu, Oliveira de Frades , Avenida Alexandre Paxeco, Nº 24'); 

--SELECT * FROM FP.EmpresaCatering;

/*	PROMOTORES	DONE*/


INSERT INTO FP.Pessoa VALUES (10120012, 'ac@gmail.com', 'Álvaro Covões', 351921195315,'m'),
							 (20330304, 'aguiar@gmail.com', 'Carlos Aguiar', 351921115365,'m'),
							 (10220022, 'alves@gmail.com', 'Ana Alves', 351921195522,'f'),
							 (01020333, 'joana1234@gmail.com', 'Joana Pacheco', 351965591311,'f'),
							 (00114444, 'ca12@gmail.com', 'Cláudio Aveiro', 351922299315, 'm'),
							 (01231110, 'rocha@gmail.com', 'Sara Rocha', 351921155515,'f');
INSERT INTO FP.Promotor VALUES(10120012, 'Nacional'),
							 (20330304, 'Nacional'),
							 (10220022, 'Nacional'),
							 (01020333, 'Internacional'),
							 (00114444, 'Nacional'),
							 (01231110, 'Internacional');


INSERT INTO FP.Pessoa VALUES (04545450, 'asilva@gmail.com', 'Alfredo Silva', 351921195333,'m'),
							 (11545451, 'asilva@gmail.com', 'Cátia Lourenço', 351961111333,'f'),
							 (01532400, 'pa789@gmail.com', 'Paulo Alves', NULL,'m'),
							 (04200120, 'abreu@gmail.com', 'Lucas Abreu', 351923405333,'m'),
							 (01134000, 'amarco@gmail.com', 'António Marco', 351929951115, 'm'),
							 (01102001, 'luisaalves@gmail.com', 'Luísa Alves', 351923451115,'f');
INSERT INTO FP.Promotor VALUES(04545450, 'Internacional'),
							 (11545451, 'Nacional'),
							 (01532400, 'Nacional'),
							 (04200120, 'Internacional'),
							 (01134000, 'Nacional'),
							 (01102001, 'Internacional');

INSERT INTO FP.Pessoa VALUES (01552001, NULL, 'Fernando Alvim', 351923451115,'m'),
							 (31034010, 'calmeida@hotmail.com', 'Cândida Almeida', 351929953333,'f'),
							 (11110000, 'asilva@gmail.com', 'Mariana Almeida', 351965551115,'f'),
							 (01234050, 'rcosta2008@hotmail.com', 'Ricardo Costa', 351923352215,'m'),
							 (02134022, 'henriquem.gam@hotmail.com', 'Henrique Gameiro', 351963359915, 'm'),
							 (32130011, 'ma19@gmail.com', 'Miguel Azevedo', 351961153315,'m');
INSERT INTO FP.Promotor VALUES(01552001, 'Internacional'),
							 (31034010, 'Nacional'),
							 (11110000, 'Nacional'),
							 (01234050, 'Internacional'),
							 (02134022, 'Nacional'),
							 (32130011, 'Nacional');


INSERT INTO FP.Pessoa VALUES (32330002, 'mv@gmail.com', 'Martim Vazconcellos', 351912113315,'m'),
							 (22303412, 'jn10@gmail.com', 'Jorje Nuno', 351942313215,'m');
INSERT INTO FP.Promotor VALUES(32330002, 'Nacional'),
							 (22303412, 'Internacional');

--SELECT * FROM FP.Promotor;


/*	MANAGER DONE*/

INSERT INTO FP.Pessoa VALUES (02113011, 'tm@gmail.com', 'Tiago Martins', 351963333915, 'm'),
							 (11113011, 'cs@gmail.com', 'Carolina Simões', 351923343111, 'f'),
							 (12003011, 'andreia.pereira@gmail.com', 'Andreia Pereira', 351925656395, 'f'),
							 (32113211, 'mara2020@gmail.com', 'Mara Simões', 351913333915, 'f'),
							 (27124021, 'pn752@gmail.com', 'Pedro Neves', 351963388315, 'm'),
							 (77023011, 'gomedaniel@gmail.com', 'Daniel Gomes', 351951133415, 'm');

INSERT INTO FP.Manager VALUES(02113011, 'Nacional'),
							 (11113011, 'Internacional'),
							 (12003011, 'Nacional'),
							 (32113211, 'Internacional'),
							 (27124021, 'Nacional'),
							 (77023011, 'Nacional');


INSERT INTO FP.Pessoa VALUES (21121011, 'msg@gmail.com', 'Marco Gonçalves', 351922340015, 'm'),
							 (33101021, NULL, 'André Lopes', 351920342015, 'm'),
							 (42131011, 'rmartins@gmail.com', 'Roberto Martins', 351953332415, 'm'),
							 (55513001, 'jc.scp@gmail.com', 'José Costa', 351953312915, 'm'),
							 (77103010, 'jg.452@gmail.com', 'Joaquim Gameiro', 351960030015, 'm'),
							 (12100010, 'tm@gmail.com', 'Anabela Neves', 351953322945, 'f');

INSERT INTO FP.Manager VALUES(21121011, 'Nacional'),
							 (33101021, 'Nacional'),
							 (42131011, 'Internacional'),
							 (55513001, 'Nacional'),
							 (77103010, 'Internacional'),
							 (12100010, 'Nacional');


INSERT INTO FP.Pessoa VALUES (21204011, 'mcr@gmail.com', 'Maria Carvalho', NULL, 'f'),
							 (12333051, 'js@gmail.com', 'Joana Simões', 351960136615, 'f'),
							 (22000011, 'rm.fcp@hotmail.com', 'Rodrigo Marques', 351920134415, 'm'),
							 (32030311, 'ma2052@hotmail.com', 'Marcelo Azevedo', 351910233315, 'm'),
							 (32032541, 'cv@hotmail.com', 'Carmo Ventura', 351920203010, 'f'),
							 (22032242, 'js.scp@hotmail.com', 'José Luís', 351911103110, 'm');

INSERT INTO FP.Manager VALUES(21204011, 'Nacional'),
							 (12333051, 'Nacional'),
							 (22000011, 'Internacional'),
							 (32030311, 'Nacional'),
							 (32032541, 'Internacional'),
							 (22032242, 'Nacional');


INSERT INTO FP.Pessoa VALUES (12012141, 'bdc@gmail.com', 'Bruno Carvalho', 353931402120, 'm'),
							 (32435255, 'jsg789@gmail.com', 'Joana Gameiro', 351912203212, 'f');

INSERT INTO FP.Manager VALUES(12012141, 'Nacional'),
							 (32435255, 'Internacional');
--SELECT * FROM FP.Manager;


/*  EVENTOS	 DONE*/
INSERT INTO FP.Evento(id, nome, nDias, dataInicio, dataFim, nBilhetes, dataProposta, cc_promotor, cc_manager)
VALUES(1, 'RockFest', 2, '2018-06-01', '2018-06-02', 1500, '2017-12-01', 00114444, 32032541);

INSERT INTO FP.Evento(id, nome, nDias, dataInicio, dataFim, nBilhetes, dataProposta, cc_promotor, cc_manager)
VALUES(2, 'GoodJazz Festival', 5, '2019-04-01', '2019-04-05', 2500, '2018-11-01', 10120012, 22000011);

INSERT INTO FP.Evento(id, nome, nDias, dataInicio, dataFim, nBilhetes, dataProposta, cc_promotor, cc_manager)
VALUES(3, 'Rap Summer Fest', 3, '2019-06-01', '2019-06-03', 2700, '2018-11-09', 11545451, 12333051);

INSERT INTO FP.Evento(id, nome, nDias, dataInicio, dataFim, nBilhetes, dataProposta, cc_promotor, cc_manager)
VALUES(4, 'Xutos&Pontapés 20Anos', 1, '2019-05-02', '2019-05-02', 1000, '2019-01-02', 04545450, 22000011);

INSERT INTO FP.Evento(id, nome, nDias, dataInicio, dataFim, nBilhetes, dataProposta, cc_promotor, cc_manager)
VALUES(5, 'MetalWeek', 5, '2020-05-01', '2020-05-05', 3000, '2019-11-02', 01231110, 32030311);

INSERT INTO FP.Evento(id, nome, nDias, dataInicio, dataFim, nBilhetes, dataProposta, cc_promotor, cc_manager)
VALUES(6, 'Orquestra Sinfónica de Chicago', 1, '2020-06-05', '2020-06-05', 1200, '2020-01-01', 02134022, 12100010);

INSERT INTO FP.Evento(id, nome, nDias, dataInicio, dataFim, nBilhetes, dataProposta, cc_promotor, cc_manager)
VALUES(7, 'Feira da Música', 4, '2021-01-30', '2021-02-02', 900, '2020-11-11', 11110000, 42131011);

INSERT INTO FP.Evento(id, nome, nDias, dataInicio, dataFim, nBilhetes, dataProposta, cc_promotor, cc_manager)
VALUES(8, 'NOS Cool Music', 2, '2020-08-01', '2020-08-02', 1900, '2020-02-01', 04200120, 12333051);

INSERT INTO FP.Evento(id, nome, nDias, dataInicio, dataFim, nBilhetes, dataProposta, cc_promotor, cc_manager)
VALUES(9, 'Blues Night', 1, '2018-04-07', '2018-04-07', 3000, '2018-01-01', 20330304, 55513001);

INSERT INTO FP.Evento(id, nome, nDias, dataInicio, dataFim, nBilhetes, dataProposta, cc_promotor, cc_manager)
VALUES(10, 'Música Portuguesa', 3, '2019-05-01', '2019-05-03', 1500, '2019-01-30', 02134022, 32032541);

INSERT INTO FP.Evento(id, nome, nDias, dataInicio, dataFim, nBilhetes, dataProposta, cc_promotor, cc_manager)
VALUES(11, 'Foo Fighters Live1', 1, '2021-06-01', '2021-06-01', 4000, '2020-01-01', 11545451, 22032242);

INSERT INTO FP.Evento(id, nome, nDias, dataInicio, dataFim, nBilhetes, dataProposta, cc_promotor, cc_manager)
VALUES(12, 'Pop Culture Fest', 2, '2019-02-02', '2019-02-03', 5000, '2018-10-01', 01134000, 55513001);

INSERT INTO FP.Evento(id, nome, nDias, dataInicio, dataFim, nBilhetes, dataProposta, cc_promotor, cc_manager)
VALUES(13, 'Foo Fighters Live2', 1, '2021-09-02', '2021-09-02', 4000, '2021-01-02', 31034010, 21204011);

INSERT INTO FP.Evento(id, nome, nDias, dataInicio, dataFim, nBilhetes, dataProposta, cc_promotor, cc_manager)
VALUES(14, 'IndieGente', 3, '2022-05-02', '2022-05-04', 800, '2021-01-02', 01134000, 21121011);

INSERT INTO FP.Evento(id, nome, nDias, dataInicio, dataFim, nBilhetes, dataProposta, cc_promotor, cc_manager)
VALUES(15, 'FadoFest', 4, '2019-05-01', '2019-05-04', 500, '2019-01-02', 22303412, 32113211);

INSERT INTO FP.Evento(id, nome, nDias, dataInicio, dataFim, nBilhetes, dataProposta, cc_promotor, cc_manager)
VALUES(16, 'HarcoreMetalNight', 1, '2019-08-01', '2019-08-01', 500, '2019-05-02', 22303412, 12012141);

INSERT INTO FP.Evento(id, nome, nDias, dataInicio, dataFim, nBilhetes, dataProposta, cc_promotor, cc_manager)
VALUES(17, 'Hanz Zimmer Live', 1, '2019-08-02', '2019-08-02', 500, '2019-05-03', 10220022, 12100010);

INSERT INTO FP.Evento(id, nome, nDias, dataInicio, dataFim, nBilhetes, dataProposta, cc_promotor, cc_manager)
VALUES(18, 'Festa Pimba', 2, '2020-03-02', '2020-03-03', 100, '2019-05-03', 32330002, 21204011);

INSERT INTO FP.Evento(id, nome, nDias, dataInicio, dataFim, nBilhetes, dataProposta, cc_promotor, cc_manager)
VALUES(19, '90s', 2, '2021-03-02', '2021-03-03', 800, '2020-10-03', 22303412, 12003011);

INSERT INTO FP.Evento(id, nome, nDias, dataInicio, dataFim, nBilhetes, dataProposta, cc_promotor, cc_manager)
VALUES(20, '80s Pop week', 5, '2022-03-02', '2022-03-03', 800, '2021-10-03',  10220022, 33101021);

--SELECT * FROM EM.EVENTO;


/*	REFEICAO DONE*/
INSERT INTO FP.Refeicao VALUES(20, 100000012, 0, 'Carne', 'Gelado', 'Agua'),
							  (20, 100000012, 1, 'Peixe', 'Bolo de Chocolate', 'Agua'),
							  (20, 100000012, 2, 'Vegetariano', 'Fruta', 'Vinho Verde');

INSERT INTO FP.Refeicao VALUES(19, 100011612, 3, 'Carne', 'Bolo de Mel', 'Agua'),
							  (19, 100011612, 4, 'Peixe', 'Gelado', 'Vinho Branco'),
							  (18, 100011612, 5, 'Vegetariano', 'Pudim', 'Vinho Verde');

INSERT INTO FP.Refeicao VALUES(18, 100132712, 6, 'Carne', 'Salada de Fruta', 'Agua'),
							  (17, 100132712, 7, 'Peixe', 'Gelado', 'Vinho Branco'),
							  (16, 100132712, 8, 'Vegetariano', 'Fruta', 'Vinho Verde');

INSERT INTO FP.Refeicao VALUES(15, 100355512, 9, 'Carne', 'Semi-Frio', 'Agua'),
							  (14, 100355512, 10, 'Peixe', 'Bolo de Ananás', 'Agua'),
							  (13, 100355512, 11, 'Vegetariano', 'Fruta', 'Sumo de Laranja');

INSERT INTO FP.Refeicao VALUES(13, 100455812, 12, 'Carne', 'Salada de Fruta', 'Agua'),
							  (12, 100540212, 13, 'Carne', 'Arroz Doce', 'Refrigerantes'),
							  (12, 101200312, 14, 'Carne', 'Fruta', 'Sumo de Laranja');

INSERT INTO FP.Refeicao VALUES(11, 101234912, 15, 'Carne', 'Salada de Fruta', 'Agua'),
							  (10, 101234912, 16, 'Vegetariano', 'Bolo de Ananás', 'Refrigerantes'),
							  (9, 101234912, 17, 'Vegan', 'Bolo de Chocolate', 'Vinho Branco');

INSERT INTO FP.Refeicao VALUES(8, 100000012, 18, 'Carne', 'Bolo de Iogurte', 'Agua'),
							  (7, 100355512, 19, 'Carne', 'Fruta', 'Vinho Verde'),
							  (5, 100455812, 20, 'Peixe', 'Bolo de Chocolate', 'Vinho Branco');

INSERT INTO FP.Refeicao VALUES(1, 101234912, 21, 'Carne', 'Bolo de Iogurte', 'Agua'),
							  (1, 100011612, 22, 'Carne', 'Fruta', 'Vinho Verde'),
							  (2, 100455812, 23, 'Peixe', 'Bolo de Chocolate', 'Vinho Branco');

INSERT INTO FP.Refeicao VALUES(4, 101234912, 24, 'Carne', 'Bolo de Iogurte', 'Agua'),
							  (3, 100355512, 25, 'Carne', 'Fruta', 'Vinho Verde'),
							  (4, 101234912, 26, 'Peixe', 'Bolo de Chocolate', 'Vinho Branco');
--SELECT * FROM FP.Refeicao;	


/* SOUNDCHECK DONE */
INSERT INTO FP.SoundCheck VALUES(1, 30,'2021-06-01 11:00:00'),
								(2, 30,'2021-09-02 10:00:00'),
								(3, 20,'2019-05-02 10:00:00'),
								(4, 40,'2019-08-02 09:00:00'),
								(5, 50,'2020-06-05 08:00:00'),
								(6, 30,'2018-06-01 09:00:00'),
								(7, 30,'2018-06-01 09:30:00'),
								(8, 30,'2018-06-02 09:00:00'),
								(9, 30,'2018-06-02 09:30:00'),
								(10, 30,'2019-04-01 08:00:00'),
								(11, 30,'2019-04-02 08:00:00'),
								(12, 30,'2019-04-03 08:00:00'),
								(13, 30,'2019-04-04 08:00:00'),
								(14, 30,'2019-04-05 08:00:00'),
								(15, 20,'2019-06-01 15:00:00'),
								(16, 20,'2019-06-02 15:00:00'),
								(17, 20,'2019-06-03 15:00:00'),
								(18, 40,'2020-05-01 10:00:00'),
								(19, 40,'2020-05-02 10:00:00'),
								(20, 40,'2020-05-03 10:00:00'),
								(21, 40,'2020-05-04 10:00:00'),
								(22, 40,'2020-05-05 10:00:00'),
								(23, 30,'2021-01-30 11:00:00'),
								(24, 30,'2021-01-31 11:00:00'),
								(25, 30,'2021-02-01 11:00:00'),
								(26, 30,'2021-02-02 11:00:00'),
								(27, 25,'2020-08-01 11:00:00'),
								(28, 25,'2020-08-02 11:00:00'),
								(29, 25,'2020-08-01 10:30:00'),
								(30, 25,'2020-08-02 11:00:00'),
								(31, 20,'2019-05-01 10:00:00'),
								(32, 20,'2019-05-02 10:00:00'),
								(33, 20,'2019-05-03 10:00:00'),
								(34, 25,'2019-02-02 10:00:00'),
								(35, 25,'2019-02-03 10:00:00'),
								(36, 30,'2022-05-02 10:00:00'),
								(37, 30,'2022-05-03 10:00:00'),
								(38, 30,'2022-05-04 10:00:00'),
								(39, 30,'2019-05-01 10:00:00'),
								(40, 30,'2019-05-02 10:00:00'),
								(41, 30,'2019-05-03 10:00:00'),
								(42, 30,'2019-05-04 10:00:00'),
								(43, 30,'2019-08-01 10:00:00'),
								(44, 30,'2019-08-01 10:30:00'),
								(45, 30,'2020-03-02 10:30:00'),
								(46, 30,'2020-03-03 10:30:00'),
								(47, 30,'2021-03-02 10:00:00'),
								(48, 30,'2021-03-03 10:00:00'),
								(49, 30,'2022-03-02 10:00:00');
--SELECT * FROM FP.SoundCheck;


/* PALCO DONE */

INSERT INTO FP.Palco VALUES		(1, 'Aveiro, Estádio Municipal', 15000, 4),
								(2, 'Leiria, Pombal, R. Albergaria dos Doze Nº 14', 33456, 2),
								(3, 'Porto, Avenida dos Aliados', 21154, 6),
								(4, 'Porto, R. Sá da Bandeira Nº 10', 6754, 11),
								(5, 'Braga, Teatro Circo', 1500, 14),
								(6, 'Aveiro, Parque de Feiras e Exposições', 12342, 1),
								(7, 'Av. Eusébio da Silva Ferreira, 1500-313 Lisboa', 65647, 13),
								(8, 'Rossio dos Olivais, 1990-231 Lisboa', 12500, 7),
								(9, 'Via Futebol Clube do Porto, 4350-415 Porto', 50033, 15),
								(10, 'Porto, Coliseu', 23665, 18),
								(11, 'Lisboa, Coiseu dos Recreios', 2334, 2),
								(12, 'Faro, Teatro Municipal, Fórum Algarve', 1421, 3),
								(13, 'Évora, Teatro Garcia de Resende', 500, 7),
								(14, 'Beja, Teatro Pax Julia', 4892, 8),
								(15, 'Évora, Arena de Évora', 56, 10),
								(16, 'Beja, Cinetratro de Sousa Telles', 9574, 19),
								(17, 'Aveiro, Cineteatro Aveirense', 10298, 16),
								(18, 'Lisboa, Estádio do Restelo', 18209, 12),
								(19, 'Vila Real, Teatro Municipal', 1927, 11),
								(20, 'Setúbal, Teatro Luisa Todi', 1372, 7),
								(21, 'Vila Real, Estádio Municipal', 17282, 16),
								(22, 'Porto, Pavilhão Rosa Mota', 15000, 17),
								(23, 'Lisboa, Meo Arena', 20000, 19),
								(24, 'Lisboa, Estádio de Alvalade', 30000, 20),
								(25, 'Ílhavo, Centro Cultural', 5485, 3),
								(26, 'Alentejo, Zambujeira do Mar', 84578, 18),
								(27, 'Lisboa, Passeio Marítimo de Alcântara', 87654, 15),
								(28, 'Porto, Estádio do Dragão', 45657, 1),
								(29, 'Viseu, Fórum Viseu', 5644, 4),
								(30, 'Guarda, Teatro Municipal', 3333, 9);
--SELECT * FROM FP.SoundCheck;

/*  BANDA  DONE  */

INSERT INTO FP.Banda VALUES ('ff', 'Foo Fighters', 142555501002, 'ff@hotmail.com', 6),
							('cc', 'Calvin Connors Band', 142525304502, 'ccband@gmail.com', 4),
							('es', 'Ed Sheeran', 142500304300, 'eds@gmail.com', 1),
							('osdc', 'Orquestra Sinfónica de Chicago', 142511104110, 'osdc@gmail.com', 10),
							('bnz', 'Benzi', 351920100010, 'benzi@gamil.com', 1),
							('mm', 'Minem', 351920100010, 'nm25@gmail.com', 1),
							('tbk', 'The Black Keys', 142520100010, 'tbk@gmail.com', 2),
							('xp', 'Xutos & Pontapés', 351920102310, 'xp1999@gmail.com', 4),
							('on', 'Orelha Negra', 351962657150, 'on87@hotmail', 5),
							('spn', '(s)Pain', 351928865113, 'pain1000@gmail.com', 3),
							('gd', 'Green Day', 142525005113, 'gd1039@gmail.com', 3),
							('pbld', 'Royal Blood', 142525505213, 'pbld@gmail.com', 2),
							('lm', 'Luís Miguel', 351925055213, 'pizzimusic@hotmail.com', 1),
							('ma', 'Miguel Araújo', 351926665213, 'pizzimusic@hotmail.com', 1),
							('cr', 'Comme Restus', 351920005003, 'eat@hotmail.com', 5),
							('jw', 'Jack White', 142522335233, 'jw@hotmail.com', 1),
							('subs', 'Submarines in The Sky',  351960343570, 'sits@gmail.com', 3),
							('db&men', 'David Bruno & Mike El Night', 351920035233, 'inatl@gmail.com', 2),
							('slr', 'Slayer',  142520034733, 'slr@hotmail.com', 5),
							('nj', 'Norah Jones',  142520011133, 'nj10@hotmail.com', 1),
							('cdb', 'Clive Davis Band',  142520313189, 'cdb2000@hotmail.com', 5),
							('tba', 'The Black Angels',  142520322289, 'angels@hotmail.com', 5),
							('mmj', 'My Morning Jacket',  142500327787, 'jacket@hotmail.com', 5),
							('db', 'DeadCombo',  351920327787, 'dead10combo@hotmail.com', 2),
							('tk', 'The Kills',  142590345080, 'tkills@hotmail.com', 2),
							('rv', 'Rui Veloso',  351950242020, 'veloso@gmail.com', 1),
							('jp', 'Jorje Palma',  351920232044, 'jpalma@gmail.com', 1),
							('cpt', 'Carminho',  351910111044, 'carminho@gmail.com', 1),
							('anm', 'Ana Moura',  351923123344, 'moura@gmail.com', 1),
							('qb', 'Quim Barreiros',  351911113344, 'quim.barreiros@gmail.com', 1),
							('toy', 'Toy',  351933133224, 'toy@gmail.com', 1),
							('hz', 'Hanz Zimmer',  351922233224, 'hz@gmail.com', 1),
							('ib', 'IssaBella',  351923430024, 'ib@gmail.com', 3),
							('lb', 'Luisa Sobral',  351911233224, 'sobral@gmail.com', 1),
							('tht', 'Toothless',  351910939724, 'toothless@gmail.com', 3),
							('gj', 'Gojira',  351910939724, 'gjr@gmail.com', 5),
							('reo', 'Reo Speedwagon',  351920222724, 'reo.speed@gmail.com', 5);

--SELECT * FROM FP.Banda;



/* CONCERTO DONE */

INSERT INTO FP.Concerto VALUES  (2, 13, 23,'ff', 180,'2021-09-02 21:00:00', 2),
								(1, 11, 22,'ff', 180,'2021-06-01 21:00:00', 1),
								(3, 4, 14,'xp', 60,'2021-09-02 22:00:00', 3),
								(4, 17, 15,'hz', 60,'2019-08-02 20:00:00', 4),
								(5, 6, 11,'osdc', 120,'2020-06-05 21:00:00', 5),
								(6, 1, 3,'ff', 120,'2018-06-01 19:00:00', 6),
								(7, 1, 12,'gd', 120,'2018-06-01 21:30:00', 7),
								(8, 1, 1,'subs', 120,'2018-06-02 19:00:00', 8),
								(9, 1, 5,'xp', 120,'2018-06-02 21:30:00', 9),
								(10, 2, 30,'nj', 60,'2019-04-01 21:00:00', 10),
								(11, 2, 25,'cdb', 60,'2019-04-02 21:00:00', 11),
								(12, 2, 26,'db', 60,'2019-04-03 21:00:00', 12),
								(13, 2, 27,'ib', 60,'2019-04-04 21:00:00', 13),
								(14, 2, 14,'lb', 60,'2019-04-05 21:00:00', 14),
								(15, 3, 11,'bnz', 60,'2019-06-01 22:00:00', 15),
								(16, 3, 12,'db&men', 60,'2019-06-02 22:00:00', 16),
								(17, 3, 5,'mm', 60,'2019-06-03 22:00:00', 17),
								(18, 5, 6, 'cr', 120,'2020-05-01 23:00:00', 18),
								(19, 5, 7,'pbld', 120,'2020-05-02 23:00:00', 19),
								(20, 5, 8,'slr', 120,'2020-05-03 23:00:00', 20),
								(21, 5, 9,'tht', 120,'2020-05-04 23:00:00', 21),
								(22, 5, 2,'gj', 120,'2020-05-05 23:00:00', 22),
								(23, 7, 13,'rv', 120,'2020-01-30 21:00:00', 23),
								(24, 7, 21,'cpt', 120,'2020-01-31 21:00:00', 24),
								(25, 7, 22,'db', 120,'2020-02-01 21:00:00', 25),
								(26, 7, 23,'jp', 90,'2020-02-02 21:00:00', 26),
								(27, 8, 24,'toy', 120,'2020-08-01 22:00:00', 27),
								(28, 8, 25, 'xp', 100,'2020-08-02 22:00:00', 28),
								(29, 9, 21,'tbk', 120,'2020-08-01 20:00:00', 29),
								(30, 9, 16,'jw', 150,'2018-08-01 22:00:00', 30),
								(31, 10, 17,'rv', 120,'2019-05-01 20:00:00', 30),
								(32, 10, 18,'on', 120,'2019-05-02 20:00:00', 32),
								(33, 10, 19,'anm', 60,'2019-05-03 20:00:00', 33),
								(34, 12, 30,'es', 120,'2019-02-02 20:00:00', 34),
								(35, 12, 29,'cc', 120,'2019-02-03 20:00:00', 35),
								(36, 14, 28,'mmj', 120,'2022-05-02 20:00:00', 36),
								(37, 14, 13, 'tba', 120,'2022-05-03 20:00:00', 37),
								(38, 14, 15,'tk', 120,'2022-05-04 20:00:00', 38),
								(39, 15, 16,'anm', 120,'2019-05-01 20:00:00', 39),
								(40, 15, 12,'cpt', 120,'2019-05-02 20:00:00', 40),
								(41, 15, 11,'anm', 200,'2019-05-03 20:00:00', 41),
								(42, 15, 19,'cpt', 120,'2019-05-04 20:00:00', 42),
								(43, 16, 10,'slr', 120,'2019-08-01 19:45:00', 43),
								(44, 16, 10,'gj', 120,'2019-08-01 22:25:00', 44),
								(45, 18, 8,'qb', 180,'2020-03-02 22:00:00', 45),
								(46, 18, 7,'toy', 120,'2020-03-03 22:00:00', 46),
								(47, 19, 9,'gd', 120,'2020-03-02 22:00:00', 47),
								(48, 19, 5,'ff', 120,'2021-03-03 22:00:00', 48),
								(49, 20, 3,'reo', 120,'2022-03-02 22:00:00', 49);

--SELECT * FROM FP.Concerto;



/* GENEROMUSICAL DONE*/

INSERT INTO FP.GeneroMusical VALUES ('ff', 'Rock'),
									('cc', 'Pop'),
									('es', 'Pop'),
									('osdc', 'Clássico'),
									('bnz', 'Rap'),
									('mm', 'Rap'),
									('tbk', 'Blues Rock'),
									('xp', 'Rock'),
									('on', 'Rap'),
									('spn', 'Punk'),
									('gd', 'Punk'),
									('pbld', 'Metal'),
									('lm', 'Pop'),
									('ma', 'Pop'),
									('cr', 'Metal'),
									('jw', 'Blues Rock'),
									('subs', 'Rock'),
									('db&men', 'Rap'),
									('slr', 'Metal'),
									('nj', 'Jazz'),
									('cdb', 'Jazz'),
									('tba', 'Indie'),
									('mmj', 'Indie'),
									('db', 'Indie'),
									('tk', 'Indie'),
									('rv', 'Pop'),
									('jp', 'Pop'),
									('cpt', 'Fado'),
									('anm', 'Fado'),
									('qb', 'Pimba'),
									('toy', 'Pimba'),
									('hz', 'Clássico'),
									('ib', 'Jazz'),
									('lb', 'Jazz'),
									('tht', 'Metal'),
									('gj', 'Metal'),
									('reo', 'Pop');

-- SELECT * FROM FP.GeneroMusical;



/*  COMITIVA  DONE*/

INSERT INTO FP.Comitiva VALUES  ('Comitivaff', 'ffcomitive@hotmail.com', 142522301102, 3, 6, 3,'ff'),
								('Comitivanm', 'mouracm@hotmail.com', 351921101182, 3, 6, 3,'anm'),
								('Comitivacc', 'comitiveconnors@hotmail.com', 142188081102, 2, 4, 2,'cc'),
								('Comitivacdb', 'comitivecdb@hotmail.com', 142132281302, 1, 4, 3,'cdb'),
								('Comitivacpt', 'carminho.comitiva@gmail.com', 351927783302, 1, 4, 3,'cpt'),
								('Comitivadb', 'combo.comitiva@gmail.com', 351927182121, 3, 7, 4,'db'),
								('Comitivaes', 'comitive.sheeran@hotmail.com', 142535686662, 3, 7, 4,'es'),
								('Comitivagd', 'green.comitive@hotmail.com', 142525282222, 1, 5, 4,'gd'),
								('Comitivajp', 'palma.comitive@hotmail.com', 351925112302, 2, 6, 4,'jp'),
								('Comitivajw', 'cm.white@hotmail.com', 351933087302, 1, 2, 1,'jw'),
								('Comitivama', 'araujo.comitive@hotmail.com', 351921012300, 5, 10, 5,'ma'),
								('Comitivammj', 'jacket.comitive@hotmail.com', 351935332102, 5, 10, 5,'mmj'),
								('Comitivanj', 'jones.comitive@hotmail.com', 142515080266, 2, 5, 3,'nj'),
								('Comitivaon', 'negra.com@gmail.com', 351966316102, 2, 4, 2,'on'),
								('Comitivaosdc', 'chicago.comitive@gmail.com', 351911410000, 3, 6, 3,'osdc'),
								('Comitivaqb', 'barreiros.comitive@gmail.com', 351926417802, 3, 9, 6,'qb'),
								('Comitivarv', 'veloso.comitive@gmail.com', 351922010002, 2, 10, 8,'rv'),
								('Comitivaslr', 'slayer.comitive@gmail.com', 142527232120, 2, 6, 4,'slr'),
								('Comitivatba', 'angels.comitive@gmail.com', 142521212110, 2, 12, 10,'tba'),
								('Comitivatbk', 'comitive.keys@gmail.com', 142527838327, 4, 16, 12,'tbk'),
								('Comitivatk', 'comitive.kills@gmail.com', 142527131337, 5, 10, 5,'tk'),
								('Comitivatoy', 'comitiva.toy@gmail.com', 351927001017, 3, 11, 8,'toy'),
								('Comitivaxp', 'comitiva.xutos@gmail.com', 351937343447, 2, 5, 3,'xp'),
								('Comitivalb', 'comitiva.sobral@gmail.com', 351937343447, 1, 3, 2,'lb'),
								('Comitivagj', 'comitive.gojira@gmail.com', 351931111447, 2, 7, 5,'gj'),
								('Comitivareo', 'comitive.reo@gmail.com', 351921222447, 5, 15, 10,'reo');

--SELECT * FROM FP.Comitiva;


/*	PESSOA MUSICO ACOMPANHANTE TECNICO 	*/

INSERT INTO FP.Pessoa VALUES (32133603, 'antonio@gmail.com', 'Paulo António', 351927001017, 'm'),
							 (10122303, 'americo@gmail.com', 'Américo Alves',351967001017, 'm'),
							 (12125545, 'gomes2010@gmail.com', 'Laura Gomes', 351963121017,'f'),
							 (32135313, 'marco2010@gmail.com', 'Marco António', 351964321011,'m'),
							 (22135444, 'imaculada@gmail.com', 'Maria Imaculada Nogueira', 351967221017,'f'),
							 (10136732, 'ct@gmail.com', 'Cláudio Teixeira',351917001023, 'm');
INSERT INTO FP.Tecnico VALUES(32133603, 'Técnico de Som','Comitivaxp'),
							 (10122303, 'Técnico de Luz', 'Comitivaxp'),
							 (12125545, 'Técnico de Som', 'Comitivaxp'),
							 (32135313, 'Técnico de Som',  'Comitivaxp');
INSERT INTO FP.Acompanhante VALUES(22135444, 'Familiar','Comitivaxp' ),
								  (10136732, 'Amigo','Comitivaxp');


INSERT INTO FP.Pessoa VALUES(90930932, 'pp@gmail.com', 'Peter Parker', 351927111222, 'm'),
							(91911911, 'af@gmail.com', 'Ana Futre', 351915331222, 'f'),
							(92922911, 'pab@gmail.com', 'Paulo A. Bartolomeu', 351936666222, 'm'),
							(92922933, 'aab@gmail.com', 'André A. Bartolomeu', 351924231222, 'm');
INSERT INTO FP.Tecnico VALUES(90930932, 'Técnico de Som','Comitivatoy'),
							(91911911, 'Técnico de Luz', 'Comitivatoy');
INSERT INTO FP.Musico VALUES(92922911, 'Bartolomeu', 'toy'),
							(92922933, 'AA Bartolomeu', 'toy');


INSERT INTO FP.Pessoa VALUES(02021133, 'tm@gmail.com', 'Tony Mosshart', 351926453456, 'm'),
							(12321333, 'th@gmail.com', 'Tony Hince',351926453412, 'm'),
							(42424134, 'tm@gmail.com', 'Alex Santos',351926457856, 'm'),
							(12114134, 'tm@gmail.com', 'Mary Rose', 351914453456, 'f');
INSERT INTO FP.Acompanhante VALUES(02021133, 'Familiar', 'Comitivatk'),
								  (12321333, 'Familiar', 'Comitivatk'),
								  (42424134, 'Amigo', 'Comitivatk');
INSERT INTO FP.Tecnico VALUES(12114134, 'Técnico de Som', 'Comitivatk');

INSERT INTO FP.Pessoa VALUES(52524134, 'kind@gmail.com', 'Richard Kind', 351919953456, 'm'),
							(52524111, 'mcarney@gmail.com', 'Michael Carney', 351918853488, 'm'),
							(62524134, 'at2020@gmail.com', 'Antony Theron', 351916453411,'m'),
							(72524134, 'lt2020@gmail.com', 'Louise Theron', 351926453432,'m'),
							(78884134, 'am@gmail.com', 'Arma Louis', 351926453477,'f'),
							(92220011, 'switft@gmail.com', 'Richard Switf',351926453888, 'm'),
							(92220033, 'tompson@gmail.com', 'Paul Tompson', 351916455656,'m');
INSERT INTO FP.Acompanhante VALUES(52524134, 'Amigo', 'Comitivatbk'),
								  (52524111, 'Familiar', 'Comitivatbk');
INSERT INTO FP.Tecnico VALUES(62524134, 'Técnico de Som', 'Comitivatbk'),
							 (72524134, 'Técnico de Guitarras', 'Comitivatbk'),
							 (78884134, 'Técnico de Guitarras', 'Comitivatbk');
INSERT INTO FP.Musico VALUES(92220011, 'Richard Switf', 'tbk'),
							(92220033, 'Paul Tompson', 'tbk');


INSERT INTO FP.Pessoa VALUES(33534134, 'cc2020@gmail.com', 'Carla Costa', 351911453422, 'f'),
							(12111134, 'lt2020@gmail.com', 'Paulo Dias', 351912453432, 'm'),
							(78114134, 'msmith@gmail.com', 'Mary Smith', 351926453765, 'f');
INSERT INTO FP.Tecnico VALUES(33534134, 'Técnico de Guitarras', 'Comitivatba'),
							 (78114134, 'Técnico de Luz', 'Comitivatba');
INSERT INTO FP.Acompanhante VALUES(12111134, 'Familiar', 'Comitivatba');


INSERT INTO FP.Pessoa VALUES(77884134, 'robbins@gmail.com', 'Tony Robbins',351932253433, 'm'),
							(72821111, 'hal@gmail.com', 'Hal Smith',351922153722, 'm'),
							(12421411, 'msmith@gmail.com', 'Mathew Smith',351921453411, 'm'),
							(13421433, 'all1999@gmail.com', 'Allison Carlson Smith',351931433422, 'f');
INSERT INTO FP.Tecnico VALUES(77884134, 'Técnico de Guitarras', 'Comitivaslr'),
							 (12421411, 'Técnico de Luz', 'Comitivaslr'),
							 (13421433, 'Técnico de Som', 'Comitivaslr');
INSERT INTO FP.Acompanhante VALUES(72821111, 'Familiar', 'Comitivaslr');


INSERT INTO FP.Pessoa VALUES(73727433, 'pv456@gmail.com', 'Paulo Veloso', 351912251133, 'm'),
					        (88827433, 'amv@gmail.com', 'Alma Veloso', 351912253333,'f'),
							(18821431, 'jr@gmail.com', 'José Rodrigues', 351912251122,'m'),
							(28221431, 'al234@gmail.com', 'Isabel Alves', 351932291933,'f');
INSERT INTO FP.Acompanhante VALUES(73727433, 'Familiar', 'Comitivarv'),
								  (88827433, 'Familiar', 'Comitivarv');
INSERT INTO FP.Tecnico VALUES(18821431, 'Técnico de Som', 'Comitivarv'),
							 (28221431, 'Técnico de Luz', 'Comitivarv');


INSERT INTO FP.Pessoa VALUES(28221432, 'al232@gmail.com', 'Alice Oliveira', 351922291923, 'f'),
							(78223432, 'al234@gmail.com', 'Paulo Souza', 351912291888, 'm'),
							(24521431, 'ms23@gmail.com', 'Mariana Soares', 351922291666,'f');
INSERT INTO FP.Tecnico VALUES(28221432, 'Técnico de Luz', 'Comitivaqb'),
							 (78223432, 'Técnico de Luz', 'Comitivaqb');
INSERT INTO FP.Acompanhante VALUES(24521431, 'Amigo', 'Comitivaqb');


INSERT INTO FP.Pessoa VALUES(33241432, 'mc1232@gmail.com', 'Mike Cranston', 351912291911, 'm'),
							(12251431, 'fields@gmail.com', 'Susan Fields', 351922291923, 'f'),
							(73511000, 'hl3@gmail.com', 'Harry Lorne', 351922291777, 'm'),
							(22211033, 'lewisl@gmail.com', 'Lewis Fields', 351922291333, 'm'),
							(44211033, 'mf232@gmail.com', 'Mary Fields', 351922391911, 'f');
INSERT INTO FP.Tecnico VALUES(33241432, 'Técnico de Som', 'Comitivaosdc'),
							 (12251431, 'Técnico de Luz', 'Comitivaosdc'),
							 (73511000, 'Técnico de Guitarras', 'Comitivaosdc');
INSERT INTO FP.Acompanhante VALUES(22211033, 'Amigo', 'Comitivaosdc'),
								  (44211033, 'Familiar', 'Comitivaosdc');


INSERT INTO FP.Pessoa VALUES(13600732, 'anibalc@gmail.com', 'Anibal Cardoso', 351922391911,'m'),
							(12601231, 'fields@gmail.com', 'Susana Augusto', 351922391922,'f'),
							(12611660, 'cardosopaulo@gmail.com', 'Paulo Cardoso', 351922391945,'m'),
							(10572223, 'andrade.marco@gmail.com', 'Marco Andrade', 351922561911,'m'),
							(22772773, 'antunes@gmail.com', 'António Antunes', 351922391932,'m'),
							(27271077, 'luisa.costa232@gmail.com', 'Luísa Costa', 351922761911,'f');
INSERT INTO FP.Tecnico VALUES(12611660, 'Técnico de Som', 'Comitivaon'),
							 (10572223, 'Técnico de Luz', 'Comitivaon'),
							 (22772773, 'Técnico de Guitarras', 'Comitivaon');
INSERT INTO FP.Acompanhante VALUES(13600732, 'Amigo', 'Comitivaon'),
								  (12601231, 'Familiar', 'Comitivaon'),
								  (27271077, 'Amigo', 'Comitivaon');



INSERT INTO FP.Pessoa VALUES(12622032, 'benneth45@gmail.com', 'Jonh Benneth', 351912391932,'m'),
							(92708291, 'ratherdonny@gmail.com', 'Donny Rahter', 351912391911,'m'),
							(10332260, 'murphy@gmail.com', 'Anne Murphy', 351922391199,'f'),
							(16642003, 'rose.jonnhy@gmail.com', 'Jonnhy Rose', 351922391765,'m'),
							(32300003, 'milakunis@gmail.com', 'Mila Kunis', 351922391345,'f'),
							(12301103, 'mhj@gmail.com', 'Mark Hensen Jones', 351922391781,'m');
INSERT INTO FP.Tecnico VALUES(12622032, 'Técnico de Som', 'Comitivanj'),
							 (10332260, 'Técnico de Luz', 'Comitivanj'),
							 (92708291, 'Técnico de Som', 'Comitivanj');
INSERT INTO FP.Acompanhante VALUES(16642003, 'Amigo', 'Comitivanj'),
								  (32300003, 'Amigo', 'Comitivanj');
INSERT INTO FP.Musico VALUES(12301103, 'Mark Jones', 'nj');



INSERT INTO FP.Pessoa VALUES(13623033, 'stan.smith@gmail.com', 'Stan Smith', 351922392345,'m'),
							(77708222, 'alice456@gmail.com', 'Alice Cantrell', 351922396789,'m'),
							(16316660, 'f.smith@gmail.com', 'Francine Smith', 351922398900,'f'),
							(96122405, 'tony.h@gmail.com', 'Tony Hawkins', 35192239000,'m'),
							(72300000, 'louise.michaels@gmail.com', 'Louise Michaels', 351922391721,'f');
INSERT INTO FP.Tecnico VALUES(77708222, 'Técnico de Som', 'Comitivammj'),
							 (96122405, 'Técnico de Luz', 'Comitivammj'),
							 (72300000, 'Técnico de Som', 'Comitivammj');
INSERT INTO FP.Acompanhante VALUES(13623033, 'Amigo', 'Comitivammj'),
								  (16316660, 'Amigo', 'Comitivammj');


								  
INSERT INTO FP.Pessoa VALUES(24623033, 'gameiro.joana@gmail.com', 'Joana Gameiro', 35192239000, 'f'),
							(66708266, 'soares.alex@gmail.com', 'Alexandre Soares', 35192239021, 'm'),
							(13336161, 'marquesmariana@gmail.com', 'Mariana Marques', 35192239034, 'f'),
							(76180005, 'jss1205@gmail.com', 'José Santos Silva', 35192239067, 'm'),
							(72333300, 'costa453@gmail.com', 'Martim Costa', 35192239023, 'm');
INSERT INTO FP.Tecnico VALUES(13336161, 'Técnico de Som', 'Comitivama'),
							 (76180005, 'Técnico de Luz', 'Comitivama'),
							 (72333300, 'Técnico de Som', 'Comitivama');
INSERT INTO FP.Acompanhante VALUES(24623033, 'Amigo', 'Comitivama'),
								  (66708266, 'Familiar', 'Comitivama');



INSERT INTO FP.Pessoa VALUES(99923033, 'azar.drummer@gmail.com', 'Carla Azar', 35192239456, 'f'),
							(66238266, 'soares.alex@gmail.com', 'Meg White', 35192239321, 'f'),
							(11136551, 'marquesmariana@gmail.com', 'Jimmy Fallon', 3519223678, 'm'),
							(06155505, 'jss1205@gmail.com', 'Paul Tomphson', 35192239888, 'm'),
							(02111301, 'costa453@gmail.com', 'Lois Griffin', 35192239000, 'f');
INSERT INTO FP.Tecnico VALUES(99923033, 'Técnico de Som', 'Comitivajw'),
							 (06155505, 'Técnico de Luz', 'Comitivajw'),
							 (02111301, 'Técnico de Som', 'Comitivajw');
INSERT INTO FP.Acompanhante VALUES(66238266, 'Familiar', 'Comitivajw'),
								  (11136551, 'Amigo', 'Comitivajw');



INSERT INTO FP.Pessoa VALUES(70007433, 'pv456@gmail.com', 'Carlos Palma', 35192239111, 'm'),
					        (80227433, 'ap456@gmail.com', 'Artur Palma', 35192239222, 'm'),
							(18111400, 'th.mar@gmail.com', 'Thiago Martins', 35192239333, 'm'),
							(20000431, 'al234@gmail.com', 'Isabel Alves', 35192239444, 'f');
INSERT INTO FP.Acompanhante VALUES(70007433, 'Familiar', 'Comitivajp'),
								  (80227433, 'Familiar', 'Comitivajp');
INSERT INTO FP.Tecnico VALUES(18111400, 'Técnico de Som', 'Comitivajp'),
							 (20000431, 'Técnico de Luz', 'Comitivajp');



INSERT INTO FP.Pessoa VALUES(70608436, 'cavallo456@gmail.com', 'Rob Cavallo', 351922392121, 'm'),
					        (80527506, 'addrianne@gmail.com', 'Adrianne Armstrong', 35192239322, 'f'),
							(28220000, 'tim.armstrong@gmail.com', 'Tim Armstrong', 35192239434, 'm'),
							(26620431, 'dirnt.isabel@gmail.com', 'Isabel Dirnt', 35192239545, 'f'),
							(20700771, 'lewis.2050@gmail.com', 'Mike Lewis', 35192239656, 'm'),
							(90220431, 'cohen.4789@gmail.com', 'Rob Cohen', 35192239767, 'm'),
							(80807712, 'freeze.jason@gmail.com', 'Jason Freeze', 35192239878, 'm');
INSERT INTO FP.Acompanhante VALUES(80527506, 'Familiar', 'Comitivagd'),
								  (28220000, 'Familiar', 'Comitivagd'),
								  (26620431, 'Familiar', 'Comitivagd');
INSERT INTO FP.Tecnico VALUES(70608436, 'Técnico de Som', 'Comitivagd'),
							 (20700771, 'Técnico de Luz', 'Comitivagd'),
							 (90220431, 'Técnico de Guitarras', 'Comitivagd');
INSERT INTO FP.Musico VALUES(80807712, 'Jason Freeze', 'gd');


INSERT INTO FP.Pessoa VALUES(10648434, 'ellie.789@gmail.com', 'Ellie Sheeran', 35191239821, 'f'),
					        (19110306, 'harrington.123@gmail.com', 'Hal Harrington', 35191239833, 'm'),
							(77720000, 'gold.jennie@gmail.com', 'Jennie Gold', 35191239867, 'm'),
							(46444431, 'ricky.spanish@gmail.com', 'Ricky Spanish', 35191239898, 'm');
INSERT INTO FP.Acompanhante VALUES(10648434, 'Familiar', 'Comitivaes'),
								  (19110306, 'Amigo', 'Comitivaes');
INSERT INTO FP.Tecnico VALUES(77720000, 'Técnico de Som', 'Comitivaes'),
							 (46444431, 'Técnico de Luz', 'Comitivaes');



INSERT INTO FP.Pessoa VALUES(21060004, 'palmeirim@gmail.com', 'Vasco Palmeirim', 35193239844, 'm'),
					        (11110006, 'gomes.patricia@gmail.com', 'Patricia Gomes', 35193239855, 'f'),
							(07620330, 'pimpao@gmail.com', 'João Pimpão', 35193239877, 'm'),
							(84644561, 'lisboa.123@gmail.com', 'José Lisboa', 35193239889, 'm');
INSERT INTO FP.Acompanhante VALUES(84644561, 'Familiar', 'Comitivadb'),
								  (07620330, 'Amigo', 'Comitivadb');
INSERT INTO FP.Tecnico VALUES(11110006, 'Técnico de Som', 'Comitivadb'),
							 (21060004, 'Técnico de Luz', 'Comitivadb');



INSERT INTO FP.Pessoa VALUES(21300334, 'ponte.maria@gmail.com', 'Maria Ponte', 35193239812, 'f'),
					        (13310336, 'pires.123@gmail.com', 'Fábio Pires', 35193239823, 'f'),
							(17600440, 'ferreira.123@gmail.com', 'Hinácio Ferreira', 35193239834, 'm'),
							(04600561, 'mendes.francisco@gmail.com', 'Francisco Mendes', 35193239845, 'm');
INSERT INTO FP.Acompanhante VALUES(04600561, 'Familiar', 'Comitivacpt'),
								  (21300334, 'Amigo', 'Comitivacpt');
INSERT INTO FP.Tecnico VALUES(17600440, 'Técnico de Som', 'Comitivacpt'),
							 (13310336, 'Técnico de Luz', 'Comitivacpt');



INSERT INTO FP.Pessoa VALUES (39149996, 'connors.mary@gmail.com', 'Mary Connors', 35193239113, 'f'),
							 (08818124, 'carlsberg@gmail.com', 'Carl Carlsberg', 35193232321, 'm'),
							 (77607375, 'prince.stuar@gmail.com', 'Stuart Prince', 35193239834, 'm'),
							 (55145513, 'phill.dunphy@gmail.com', 'Phill Dunphy', 35193239876, 'm'),
							 (22230001, 'luke.dunphy@gmail.com', 'Luke Dunphy', 35193239887, 'm');
INSERT INTO FP.Tecnico VALUES(08818124, 'Técnico de Som', 'Comitivacc'),
							 (55145513, 'Técnico de Luz', 'Comitivacc'),
							 (22230001, 'Técnico de Som', 'Comitivacc');
INSERT INTO FP.Acompanhante VALUES(77607375, 'Amigo', 'Comitivacc'),
								  (39149996, 'Familiar', 'Comitivacc');



INSERT INTO FP.Pessoa VALUES (19119911, 'davies.elizabeth@gmail.com', 'Elizabeth Davies', 35191239887, 'f'),
							 (38313134, 'oliver.jonh@gmail.com', 'Jonh Oliver', 35192239111, 'm'),
							 (75657555, 'mclaren@gmail.com', 'Michelle Mclaren', 35193239222, 'f'),
							 (55818583, 'hayley.smith@gmail.com', 'Hayley Smith', 35191239333, 'f'),
							 (22290999, 'donovan@gmail.com', 'Mike Donovan', 35192239444, 'm');
INSERT INTO FP.Tecnico VALUES(38313134, 'Técnico de Som', 'Comitivacdb'),
							 (75657555, 'Técnico de Luz', 'Comitivacdb'),
							 (22290999, 'Técnico de Som', 'Comitivacdb');
INSERT INTO FP.Acompanhante VALUES(55818583, 'Amigo', 'Comitivacdb'),
								  (19119911, 'Familiar', 'Comitivacdb');



INSERT INTO FP.Pessoa VALUES (37140566, 'pp@gmail.com', 'Pedro Pedrosa', 35193239111, 'm'),
							 (00111124, 'alenquer@gmail.com', 'Catarina Alenquer', 35193239222, 'f'),
							 (54606305, 'lina7895@gmail.com', 'Lina Almeida', 35193239234, 'f'),
							 (43147413, 'f.santos@gmail.com', 'Filipa Santos', 35194239111, 'f'),
							 (61131141, 'horacio@gmail.com', 'Horácio Costa', 35192239121, 'm');
INSERT INTO FP.Tecnico VALUES(61131141, 'Técnico de Som', 'Comitivanm'),
							 (54606305, 'Técnico de Luz', 'Comitivanm'),
							 (37140566, 'Técnico de Som', 'Comitivanm');
INSERT INTO FP.Acompanhante VALUES(43147413, 'Amigo', 'Comitivanm'),
								  (00111124, 'Familiar', 'Comitivanm');



INSERT INTO FP.Pessoa VALUES (07100703, 'griffin.dale@gmail.com', 'Dale Griffin', 35192223121, 'm'),
							 (20122224, 'vig.butch@gmail.com', 'Butch Vig', 35192234121, 'm'),
							 (44124005, 'kurstin@gmail.com', 'Greg Kurstin', 35195639121, 'm'),
							 (02167313, 'violet@gmail.com', 'Violet Grohl', 35192779121, 'f'),
							 (62135744, 'rick.hawk@gmail.com', 'Rick Hawkins', 35198939121, 'm'),
							 (10446732, 'm.smear@gmail.com', 'Mary Smear', 35192089121, 'f');
INSERT INTO FP.Tecnico VALUES(07100703, 'Técnico de Som', 'Comitivaff'),
							 (20122224, 'Técnico de Luz', 'Comitivaff'),
							 (44124005, 'Técnico de Som', 'Comitivaff');
INSERT INTO FP.Acompanhante VALUES(02167313, 'Familiar', 'Comitivaff'),
								  (62135744, 'Familiar', 'Comitivaff'),
								  (10446732, 'Familiar', 'Comitivaff');



INSERT INTO FP.Pessoa VALUES (07122733, 'sobral.salvador@gmail.com', 'Salvador Sobral', 35192089121, 'm'),
							 (20123334, 'andrade.artur@gmail.com', 'Artur Andrade', 35192089121, 'm'),
							 (50556732, 'm.matias@gmail.com', 'Mariana Matias', 35192089121, 'f'),
							 (10111732, 'reamos@gmail.com', 'Sara Ramos', 35192089121, 'f');
INSERT INTO FP.Tecnico VALUES(20123334, 'Técnico de Som', 'Comitivalb'),
							 (50556732, 'Técnico de Luz', 'Comitivalb');
INSERT INTO FP.Acompanhante VALUES(07122733, 'Familiar', 'Comitivalb');
INSERT INTO FP.Musico VALUES(10111732, 'Sara Ramos', 'lb');


INSERT INTO FP.Pessoa VALUES (00166733, 'matthew.lewis@gmail.com', 'Matthew Lewis', 35192089131, 'm'),
							 (20122234, 'susan.silver@gmail.com', 'Susan Silver', 35192089141,'f'),
							 (80588732, 'stan.r@gmail.com', 'Stan Reynolds', 35192089151,'m');
INSERT INTO FP.Tecnico VALUES(20122234, 'Técnico de Som', 'Comitivagj'),
							 (80588732, 'Técnico de Luz', 'Comitivagj');
INSERT INTO FP.Acompanhante VALUES(00166733, 'Amigo', 'Comitivagj');



INSERT INTO FP.Pessoa VALUES (02122233, 'robert.lewis@gmail.com', 'Robert Lewis', 35192089161,'m'),
							 (24433234, 'marty.silver@gmail.com', 'Marty Silver', 35192089171,'f');
INSERT INTO FP.Tecnico VALUES(02122233, 'Técnico de Som', 'Comitivareo'),
							 (24433234, 'Técnico de Luz', 'Comitivareo');

--SELECT * FROM FP.Pessoa;
--SELECT * FROM FP.Tecnico;
--SELECT * FROM FP.Acompanhante;
--SELECT * FROM FP.Musico;

					

/*	MUSICOS (membros de bandas não parte de comitivas)	*/
INSERT INTO FP.Pessoa VALUES(00222432, NULL, 'Ana Moura Peireira', 35192089172,'f');
INSERT INTO FP.Musico VALUES(00222432, 'Ana Moura', 'anm');

INSERT INTO FP.Pessoa VALUES(11120032, NULL, 'Rafael Benzinho', 35192089173,'m');
INSERT INTO FP.Musico VALUES(11120032, 'Benzi', 'bnz');


INSERT INTO FP.Pessoa VALUES(22020032, 'csc@gmail.com', 'Calvin Stuart Connors', 35192089174,'m');
INSERT INTO FP.Musico VALUES(22020032, 'Calvin Connors', 'cc');

INSERT INTO FP.Pessoa VALUES(22121566, 'mconnors@gmail.com', 'Mary Connors', 35192089175,'f');
INSERT INTO FP.Musico VALUES(22121566, 'Mary Connors', 'cc');

INSERT INTO FP.Pessoa VALUES(12144566, 'gstuart@gmail.com', 'Gary Stuart', 35192089176,'m');
INSERT INTO FP.Musico VALUES(12144566, 'Gary Stuart', 'cc');

INSERT INTO FP.Pessoa VALUES(12133566, 'paul.davis@gmail.com', 'Paul Davis', 35192089177,'m');
INSERT INTO FP.Musico VALUES(12133566, 'Paul Davis', 'cc');


INSERT INTO FP.Pessoa VALUES(2003766, 'clive.davis@gmail.com', 'Clive Davis', 35192089178,'m');
INSERT INTO FP.Musico VALUES(2003766, 'Clive Davis', 'cdb');

INSERT INTO FP.Pessoa VALUES(1023766, 't.stone@gmail.com', 'Tony Stone', 35192089179,'m');
INSERT INTO FP.Musico VALUES(1023766, 'T-Stone', 'cdb');

INSERT INTO FP.Pessoa VALUES(1223465, 'mls@gmail.com', 'Mary Lewis Stone', 35192089180,'f');
INSERT INTO FP.Musico VALUES(1223465, 'ML-Stone', 'cdb');

INSERT INTO FP.Pessoa VALUES(1621166, 'm.rupert@gmail.com', 'Mark Rupert', 35192089181,'m');
INSERT INTO FP.Musico VALUES(1621166, 'Mark Rupert', 'cdb');

INSERT INTO FP.Pessoa VALUES(12234566, 't.lewis@hotmail.com', 'Tommy Lewis', 35192089182,'m');
INSERT INTO FP.Musico VALUES(12234566, 'T-Tommy', 'cdb');


INSERT INTO FP.Pessoa VALUES(12122032, 'gosmo@gmail.com', 'Manuel Tomás', 35192089183,'m');
INSERT INTO FP.Musico VALUES(12122032, 'Gosmo', 'cr');

INSERT INTO FP.Pessoa VALUES(12722737, 'tortulho@gmail.com', 'João Carlos', 35192089184,'m');
INSERT INTO FP.Musico VALUES(12722737, 'Jonh Tortulho', 'cr');

INSERT INTO FP.Pessoa VALUES(32322332, 'galhao@gmail.com', 'Artur Fonseca', 35192089185,'m');
INSERT INTO FP.Musico VALUES(32322332, 'Dr Fonseca Galhao', 'cr');

INSERT INTO FP.Pessoa VALUES(77772732, 'las@gmail.com', 'Luís Andrade Fonseca', 35192089186,'m');
INSERT INTO FP.Musico VALUES(77772732, 'Homem Sugo', 'cr');

INSERT INTO FP.Pessoa VALUES(66166032, 'mfonseca@gmail.com', 'Marco Fonseca', 35192089187,'m');
INSERT INTO FP.Musico VALUES(66166032, 'Maxado El Rosa', 'cr');


INSERT INTO FP.Pessoa VALUES(06146042, 'pgc@gmail.com', 'Pedro Gonçalves', 35192089188,'m');
INSERT INTO FP.Musico VALUES(06146042, 'Pedro Gonçalves', 'db');

INSERT INTO FP.Pessoa VALUES(86148048, 'totrips@gmail.com', 'Marco Artur Gonçalves', 35192089189,'m');
INSERT INTO FP.Musico VALUES(86148048, 'Tó Trips', 'db');


INSERT INTO FP.Pessoa VALUES(22146042, 'ml@gmail.com', 'Miguel Luz', 35192089190,'m');
INSERT INTO FP.Musico VALUES(22146042, 'Mike El Night', 'db&men');

INSERT INTO FP.Pessoa VALUES(36156542, 'bruno.david@gmail.com', 'David Bruno', 35192089191,'m');
INSERT INTO FP.Musico VALUES(36156542, 'David Bruno', 'db&men');


INSERT INTO FP.Pessoa VALUES(16149942, NULL, 'Edward Sheeran', 35192089192,'m');
INSERT INTO FP.Musico VALUES(16149942, 'Ed Sheeran', 'es');


INSERT INTO FP.Pessoa VALUES(11141142, 'davegrohl@gmail.com', 'Dave Grohl', 35192089193,'m');
INSERT INTO FP.Musico VALUES(11141142, 'Dave Grohl', 'ff');

INSERT INTO FP.Pessoa VALUES(33143142, 'hawk@gmail.com', 'Taylor Hawkins', 35192089194,'m');
INSERT INTO FP.Musico VALUES(33143142, 'Taylor Hawkins', 'ff');

INSERT INTO FP.Pessoa VALUES(55141142, 'natemendel@gmail.com', 'Nate Mendel', 35192089195,'m');
INSERT INTO FP.Musico VALUES(55141142, 'Nate Mendel', 'ff');

INSERT INTO FP.Pessoa VALUES(17177142, 'smearpat@gmail.com', 'Pat Smear', 35192089196,'m');
INSERT INTO FP.Musico VALUES(17177142, 'Pat Smear', 'ff');

INSERT INTO FP.Pessoa VALUES(87187142, 'jj.ff@gmail.com', 'Jami Jaffe', 35192089197,'m');
INSERT INTO FP.Musico VALUES(87187142, 'Jami Jaffe', 'ff');


INSERT INTO FP.Pessoa VALUES(47147442, 'bja@gmail.com', 'Billie Joe Armstrong', 35192089198,'m');
INSERT INTO FP.Musico VALUES(47147442, 'Billie Joe Armstrong', 'gd');

INSERT INTO FP.Pessoa VALUES(87177882, 'dirnt.mike@gmail.com', 'Mike Dirnt', 35192089199,'m');
INSERT INTO FP.Musico VALUES(87177882, 'Mike Dirnt', 'gd');

INSERT INTO FP.Pessoa VALUES(13337142, 'smearpat@gmail.com', 'Frank Edwin Wright', 35192089200,'m');
INSERT INTO FP.Musico VALUES(13337142, 'Tre Cool', 'gd');


INSERT INTO FP.Pessoa VALUES(18337128, 'candreu@gmail.com', 'Christian Andreu', 35192089201,'m');
INSERT INTO FP.Musico VALUES(18337128, 'Christian Andreu', 'gj');

INSERT INTO FP.Pessoa VALUES(15535142, 'joe.dupl@gmail.com', 'Joe Duplantier', 35192089202,'m');
INSERT INTO FP.Musico VALUES(15535142, 'Joe Duplantier', 'gj');

INSERT INTO FP.Pessoa VALUES(25535142, 'mario.dupl@gmail.com', 'Mario Duplantier', 35192089203,'m');
INSERT INTO FP.Musico VALUES(25535142, 'Mario Duplantier', 'gj');

INSERT INTO FP.Pessoa VALUES(15665142, 'jean.michel@gmail.com', 'Jean-Michel Labadie', 35192089204,'m');
INSERT INTO FP.Musico VALUES(15665142, 'Jean-Michel Labadie', 'gj');

INSERT INTO FP.Pessoa VALUES(15939192, 'corm@gmail.com', 'Alexandre Cormillon', 35192089205,'m');
INSERT INTO FP.Musico VALUES(15939192, 'Alexandre Cormillon', 'gj');


INSERT INTO FP.Pessoa VALUES(12239292, NULL, 'Hans Florian Zimmer', 35192089206,'m');
INSERT INTO FP.Musico VALUES(12239292, 'Hanz Zimmer', 'hz');


INSERT INTO FP.Pessoa VALUES(22232292, 'r.cavalheiro@hotmail.com', 'Rui Cavalheiro', 35192089207,'m');
INSERT INTO FP.Musico VALUES(22232292, 'Ruy Cavalheiro', 'ib');

INSERT INTO FP.Pessoa VALUES(12231792, 'jl.issabella@hotmail.com', 'José Luís', 35192089208,'m');
INSERT INTO FP.Musico VALUES(12231792, 'José Luís', 'ib');

INSERT INTO FP.Pessoa VALUES(33771792, 'andre.malheiro@hotmail.com', 'André Malheiro', 35192089209,'m');
INSERT INTO FP.Musico VALUES(33771792, 'André Malheiro', 'ib');


INSERT INTO FP.Pessoa VALUES(13331755, NULL,'Jorje Palma', 35192089210,'m');
INSERT INTO FP.Musico VALUES(13331755, 'Jorje Palma', 'jp');


INSERT INTO FP.Pessoa VALUES(44231492, NULL, 'John Anthony White', 35192089211,'m');
INSERT INTO FP.Musico VALUES(44231492, 'Jack White', 'jw');


INSERT INTO FP.Pessoa VALUES(11631462, NULL, 'Luísa Sobral', 35192089212,'f');
INSERT INTO FP.Musico VALUES(11631462, 'Luísa Sobral', 'lb');


INSERT INTO FP.Pessoa VALUES(33631362, NULL, 'Luís Miguel', 35192089213,'m');
INSERT INTO FP.Musico VALUES(33631362, 'Luís Miguel', 'lm');


INSERT INTO FP.Pessoa VALUES(22232462, NULL, 'Miguel Araújo', 35192089214,'m');
INSERT INTO FP.Musico VALUES(22232462, 'Miguel Araújo', 'ma');


INSERT INTO FP.Pessoa VALUES(23332462, NULL, 'Marcio Tavares', 35192089215,'m');
INSERT INTO FP.Musico VALUES(23332462, 'Minem', 'mm');


INSERT INTO FP.Pessoa VALUES(23332111, NULL, 'Norah Jones', 35192089216,'f');
INSERT INTO FP.Musico VALUES(23332111, 'Norah Jones', 'nj');


INSERT INTO FP.Pessoa VALUES(11551162, 'ym.yames@gmail.com', 'Jim James', 35192089217,'m');
INSERT INTO FP.Musico VALUES(11551162, 'Jim James', 'mmj');

INSERT INTO FP.Pessoa VALUES(11222162, 'jones.tommy@gmail.com', 'Tommy Jones', 35192089218,'m');
INSERT INTO FP.Musico VALUES(11222162, 'Two Tone Tommy', 'mmj');

INSERT INTO FP.Pessoa VALUES(11331162, 'carl.broemel@gmail.com', 'Carl Broemel', 35192089219,'m');
INSERT INTO FP.Musico VALUES(11331162, 'Carl Broemel', 'mmj');

INSERT INTO FP.Pessoa VALUES(11331188, 'ptrk@gmail.com', 'Patrick Hallaham', 35192089220,'m');
INSERT INTO FP.Musico VALUES(11331188, 'Patrick Hallaham', 'mmj');

INSERT INTO FP.Pessoa VALUES(11373632, 'bo.koster@gmail.com', 'Robert Koster', 35192089221,'m');
INSERT INTO FP.Musico VALUES(11373632, 'Bo Koster', 'mmj');


INSERT INTO FP.Pessoa VALUES(15351562, 'carlos.cruz@gmail.com', 'Carlos Cruz', 35192089222,'m');
INSERT INTO FP.Musico VALUES(15351562, 'DJ Cruzfader', 'on');

INSERT INTO FP.Pessoa VALUES(12338192, 'thekid@gmail.com', 'Samuel Antunes', 35192089223,'m');
INSERT INTO FP.Musico VALUES(12338192, 'Sam The Kid', 'on');

INSERT INTO FP.Pessoa VALUES(71734160, 'gomes.12@gmail.com', 'João Gomes', 35192089224,'m');
INSERT INTO FP.Musico VALUES(71734160, 'João Gomes', 'on');

INSERT INTO FP.Pessoa VALUES(78834880, 'fred12ff@gmail.com', 'Fred Ferreira', 35192089225,'m');
INSERT INTO FP.Musico VALUES(78834880, 'Fred Ferreira', 'on');

INSERT INTO FP.Pessoa VALUES(81884160, 'f.rebelo@gmail.com', 'Francisco Rebelo', 35192089226,'m');
INSERT INTO FP.Musico VALUES(81884160, 'Francisco Rebelo', 'on');


INSERT INTO FP.Pessoa VALUES(61736880, NULL, 'Quim Barreiros', 35192089227,'m');
INSERT INTO FP.Musico VALUES(61736880, 'Quim Barreiros', 'qb');

INSERT INTO FP.Pessoa VALUES(61736550, NULL, 'Rui Veloso', 35192089171,'m');
INSERT INTO FP.Musico VALUES(61736550, 'Rui Veloso', 'rv');

INSERT INTO FP.Pessoa VALUES(88800880, NULL, 'António Manuel Neves Ferrão', 35192089228,'m');
INSERT INTO FP.Musico VALUES(88800880, 'Toy', 'toy');


INSERT INTO FP.Pessoa VALUES(84222881, 'mike.kerr@gmail.com', 'Mike Kerr', 35192089229,'m');
INSERT INTO FP.Musico VALUES(84222881, 'Mike Kerr', 'pbld');

INSERT INTO FP.Pessoa VALUES(14212881, 'ben.tatcher@gmail.com', 'Ben Tatcher', 35192089230,'m');
INSERT INTO FP.Musico VALUES(14212881, 'Ben Tatcher', 'pbld');


INSERT INTO FP.Pessoa VALUES(13212331, 'dan.auerbach@gmail.com', 'Dan Auerbach', 35192089231,'m');
INSERT INTO FP.Musico VALUES(13212331, 'Dan Auerbach', 'tbk');

INSERT INTO FP.Pessoa VALUES(10210301, 'pat.carney@gmail.com', 'Patrick Carney', 35192089232,'m');
INSERT INTO FP.Musico VALUES(10210301, 'Patick Carney', 'tbk');


INSERT INTO FP.Pessoa VALUES(16205301, 'all.kills@gmail.com', 'Allison Mosshart', 35192089233,'f');
INSERT INTO FP.Musico VALUES(16205301, 'Allison Mosshart', 'tk');

INSERT INTO FP.Pessoa VALUES(88205301, 'jamie.kills@gmail.com', 'Jamie Hince', 35192089234,'m');
INSERT INTO FP.Musico VALUES(88205301, 'Jamie Hince', 'tk');


INSERT INTO FP.Pessoa VALUES(30321303, 'jpcg@gmail.com', 'João Gameiro', 35192089235,'m');
INSERT INTO FP.Musico VALUES(30321303, 'João Gameiro', 'subs');

INSERT INTO FP.Pessoa VALUES(35321223, 'job@gmail.com', 'João Job', 35192089236,'m');
INSERT INTO FP.Musico VALUES(35321223, 'João Job', 'subs');

INSERT INTO FP.Pessoa VALUES(30551353, 'adielma@gmail.com', 'Diogo Almeida', 35192089237,'m');
INSERT INTO FP.Musico VALUES(30551353, 'Diogo Almeida', 'subs');


INSERT INTO FP.Pessoa VALUES(30558859, 'neal@gmail.com', 'Neal Doughty', 35192089238,'m');
INSERT INTO FP.Musico VALUES(30558859, 'Neal Douthy', 'reo');

INSERT INTO FP.Pessoa VALUES(07550359, 'grich@gmail.com', 'Gary Richrath', 35192089239,'m');
INSERT INTO FP.Musico VALUES(07550359, 'Gary RichRath', 'reo');

INSERT INTO FP.Pessoa VALUES(48658353, 'gregg@gmail.com', 'Gregg Phillbin', 35192089240,'m');
INSERT INTO FP.Musico VALUES(48658353, 'Gregg Phillbin', 'reo');

INSERT INTO FP.Pessoa VALUES(37757373, 'tl2500@gmail.com', 'Terry Lutrel', 35192089241,'m');
INSERT INTO FP.Musico VALUES(37757373, 'Terry Lutrel', 'reo');

INSERT INTO FP.Pessoa VALUES(37758390, 'kcr@gmail.com', 'Kevin Cronin', 35192089242,'m');
INSERT INTO FP.Musico VALUES(37758390, 'Kevin Cronin', 'reo');


INSERT INTO FP.Pessoa VALUES(33058090, 'kking@gmail.com', 'Kerry King', 35192089243,'m');
INSERT INTO FP.Musico VALUES(33058090, 'Kerry King', 'slr');

INSERT INTO FP.Pessoa VALUES(00656390, 'ayara@gmail.com', 'Tom Araya', 35192089244,'m');
INSERT INTO FP.Musico VALUES(00656390, 'Tom Araya', 'slr');

INSERT INTO FP.Pessoa VALUES(11456390, 'hot.gary@gmail.com', 'Gary Holt', 35192089245,'m');
INSERT INTO FP.Musico VALUES(11456390, 'Gary Holt', 'slr');

INSERT INTO FP.Pessoa VALUES(00657790, 'davelombardo@gmail.com', 'Dave Lombardo', 35192089246,'m');
INSERT INTO FP.Musico VALUES(00657790, 'Dave Lombardo', 'slr');

INSERT INTO FP.Pessoa VALUES(02656391, 'dette@gmail.com', 'Jon Dette', 35192089247,'m');
INSERT INTO FP.Musico VALUES(02656391, 'Jon Dette', 'slr'); 


INSERT INTO FP.Pessoa VALUES(02336391, 'kingharry@gmail.com', 'Harry Stuart Lewis', 35192089248,'m');
INSERT INTO FP.Musico VALUES(02336391, 'KingHarry', 'spn'); 

INSERT INTO FP.Pessoa VALUES(02436581, 'swango.nikki@gmail.com', 'Mary Elizabeth Winstead', 35192089249,'f');
INSERT INTO FP.Musico VALUES(02436581, 'Nikki Swango', 'spn'); 

INSERT INTO FP.Pessoa VALUES(02446398, 'marc.foster@gmail.com', 'Marc Foster', 35192089250,'m');
INSERT INTO FP.Musico VALUES(02446398, 'Marc Foster', 'spn'); 


INSERT INTO FP.Pessoa VALUES(01306491, 'ryan.nate@gmail.com', 'Nate Ryan', 35192089251,'m');
INSERT INTO FP.Musico VALUES(01306491, 'Nate Ryan', 'tba');

INSERT INTO FP.Pessoa VALUES(12307391, 'steph@gmail.com', 'Stephanie Bailey', 35192089252,'f');
INSERT INTO FP.Musico VALUES(12307391, 'Stephanie Bailey', 'tba');

INSERT INTO FP.Pessoa VALUES(33333391, 'hunt.kyle@gmail.com', 'Kyle Hunt', 35192089253,'m');
INSERT INTO FP.Musico VALUES(33333391, 'Kyle Hunt', 'tba'); 

INSERT INTO FP.Pessoa VALUES(33134391, 'alx.maas@gmail.com', 'Alex Maas', 35192089254,'m');
INSERT INTO FP.Musico VALUES(33134391, 'Alex Maas', 'tba'); 

INSERT INTO FP.Pessoa VALUES(34435391, 'bland@gmail.com', 'Christian Bland', 35192089255,'m');
INSERT INTO FP.Musico VALUES(34435391, 'Christian Bland', 'tba'); 


INSERT INTO FP.Pessoa VALUES(14131851, 'd.antunes@gmail.com', 'Diogo Antunes', 35192089256,'m');
INSERT INTO FP.Musico VALUES(14131851, 'Diogo Antunes', 'tht'); 

INSERT INTO FP.Pessoa VALUES(32235391, 'mauro.pereira@gmail.com', 'Mauro Pereira', 35192089257,'m');
INSERT INTO FP.Musico VALUES(32235391, 'Mauro Pereira', 'tht'); 

INSERT INTO FP.Pessoa VALUES(38835881, 'vitor.pereira@gmail.com', 'Vitor Pereira', 35192089258,'m');
INSERT INTO FP.Musico VALUES(38835881, 'Vitor Pereira', 'tht'); 


INSERT INTO FP.Pessoa VALUES(11215391, 'tim@gmail.com', 'António Manuel', 35192089259,'m');
INSERT INTO FP.Musico VALUES(11215391, 'Tim', 'xp'); 

INSERT INTO FP.Pessoa VALUES(18218398, 'cabeleira@gmail.com', 'João Cabeleira',35192089260, 'm');
INSERT INTO FP.Musico VALUES(18218398, 'João Cabeleira', 'xp'); 

INSERT INTO FP.Pessoa VALUES(86615391, 'kalu@gmail.com', 'Carlos Eduardo ',35192089261, 'm');
INSERT INTO FP.Musico VALUES(86615391, 'Kalu', 'xp'); 

INSERT INTO FP.Pessoa VALUES(86688398, 'gui@gmail.com', 'Guilherme Cabral ', 35192089262,'m');
INSERT INTO FP.Musico VALUES(86688398, 'Gui', 'xp'); 


INSERT INTO FP.Pessoa VALUES(81645391, 'mc.osdc@gmail.com', 'Mary Carlson',35192089263, 'f');
INSERT INTO FP.Musico VALUES(81645391, 'Mary Carlson', 'osdc'); 

INSERT INTO FP.Pessoa VALUES(16615191, NULL, 'Peter Edwards ', 35192089264,'m');
INSERT INTO FP.Musico VALUES(16615191, 'Peter Edwards', 'osdc'); 

INSERT INTO FP.Pessoa VALUES(18185391, NULL, 'Candy Start ', 35192089265,'f');
INSERT INTO FP.Musico VALUES(18185391, 'Candy Start', 'osdc'); 

INSERT INTO FP.Pessoa VALUES(98900301, NULL, 'Marianne Lewis ',35192089266, 'f');
INSERT INTO FP.Musico VALUES(98900301, 'Marianne Lewis', 'osdc'); 

INSERT INTO FP.Pessoa VALUES(18445491, NULL, 'Anthony Alexander',35192089267, 'm');
INSERT INTO FP.Musico VALUES(18445491, 'Alexander', 'osdc'); 

INSERT INTO FP.Pessoa VALUES(11645391, 'banks.osdc@gmail.com', 'Cody Banks', 35192089268,'m');
INSERT INTO FP.Musico VALUES(11645391, 'Cody Banks', 'osdc'); 

INSERT INTO FP.Pessoa VALUES(88675891, 'arielwinter@gmail.com', 'Ariel Winter', 35192089269,'f');
INSERT INTO FP.Musico VALUES(88675891, 'Ariel WInter', 'osdc'); 

INSERT INTO FP.Pessoa VALUES(48145391, 'nola.gould@gmail.com', 'Nolan Gould ', 3519208270,'m');
INSERT INTO FP.Musico VALUES(48145391, 'Nolan Gould', 'osdc'); 

INSERT INTO FP.Pessoa VALUES(98910201, NULL, 'Patrick Dempsey', 35192089271,'m');
INSERT INTO FP.Musico VALUES(98910201, 'Patrick Dempsey', 'osdc'); 

INSERT INTO FP.Pessoa VALUES(18666491, NULL, 'Arthur Hobbs', 35192089272,'m');
INSERT INTO FP.Musico VALUES(18666491, 'Arthur Hobbs', 'osdc'); 


--SELECT * FROM FP.Musico;


/*	INSTRUMENTO	DONE*/

INSERT INTO FP.Instrumento VALUES(1, 'Fender','Fender',	'Stratocaster-369', 10111732),
								 (2, 'Ludwig', 'Ludwig','Ludwig Drumset-456', 10210301),
								 (3, 'Fender', 'Fender','Precision Bass-456', 1023766),
								 (4, 'Gibson', 'Gibson','Trini Lopez Standard ES-335', 11141142),
								 (5, 'Gibson', 'Gibson','Trini Lopez Standard ES-335', 11141142),
								 (6, 'Fender', 'Fender','Precision Bass-456', 11215391),
								 (7, 'Gretsch', 'Gretsch','Bass Series 789', 11222162),
								 (8, 'Gibson', 'Gibson','Les Paul Series 700', 11331162),
								 (9, 'Gibson','Gibson', 'Hollowbody ES-365', 11331162),
								 (10, 'Tama', 'Tama', 'Tama Drums 750', 11331188),
								 (11, 'Yamaha', 'Yamaha','1975 Sound Keyboard', 11331188),
								 (12, 'Gibson', 'Gibson','Flying V', 11456390),
								 (13, 'Gibson', 'Gibson','Flying V', 11551162),
								 (14, 'Gibson', 'Gibson','Hollowbody ES-365', 11331162),
								 (15, 'Taylor', 'Taylor','Acoustic v789', 11631462),
								 (16, 'Cecilio', 'Cecilio','CCO-100', 11645391),
								 (17, 'Guild', 'Guild','F-20 ', 12122032),
								 (18, 'Yahamaha', 'Yahamaha','Keyboard 456 ', 12133566),
								 (19, 'Yahamaha', 'Yahamaha','Acoustic Serie 6 ', 12144566),
								 (20, 'Fender', 'Fender','Stratocaster White Model ', 12231792),
								 (21, 'Getzen', 'Getzen','Trumpet 590S-S',12234566),
								 (22, 'Ibanez', 'Ibanez','SR375EF-BBT 5string freteless bass',1223465),
								 (23, 'Tama', 'Tama','Tama Drums 750', 12301103),
								 (24, 'Yamaha', 'Yamaha','187 Drums', 12307391),
								 (25, 'Ibanez', 'Ibanez','ADSA bass', 12722737),
								 (26, 'Gibson', 'Gibson','L-5 CES', 1306491),
								 (27, 'Guild', 'Guild','S-200 Thunderbird Electric Guitar',13212331),
								 (28, 'Harmony', 'Harmony','H78 Electric Guitar', 13212331), 
								 (29, 'Yamaha', 'Yamaha','Electric-Acoustic 458-ESC Guitar', 13331755),
								 (30, 'SJC', 'SJC','Custom 78 drumset', 13337142),
								 (31, 'Gibson', 'Gibson','White Line Les Paul', 14131851),
								 (32, 'Gretsch', 'Gretsch','Renown Maple Drumset', 14212881),
								 (33, 'Pioneer', 'Pioneer','DJ DJ-400', 15351562),
								 (34, 'San Dimas', 'San Dimas','SIGNATURE PRO-MOD', 15535142),
								 (35, 'Fender', 'Fender','Precision Bass-456', 15665142),
								 (36, 'Fender', 'Fender','Precision Bass-456', 15939192),
								 (37, 'Martin', 'Martin','LX', 16149942),
								 (38, 'Ibanez', 'Ibanez','AS200', 1621166),
								 (39, 'Miraphone', 'Ibanez','ER564 Tuba', 16615191),
								 (40, 'Hagström', 'Hagström','ES365', 17177142),
								 (41, 'Yamaha', 'Yamaha','YFL 372 B-Stock Flaut', 18185391),
								 (42, 'Washburn', 'Washburn','EC-29 Spitfire', 18218398),
								 (43, 'Gibson', 'Gibson','Flying V Spitfire', 18337128),
								 (44, 'Fender', 'Fender','Precision Bass-456', 18445491),
								 (45, 'Bösendorfer', 'Bösendorfer','45678ES-Piano', 18666491),
								 (46, 'Pearl', 'Pearl','8ES-DrumSet', 22121566),
								 (47, 'Fender', 'Fender','EESS-Bass', 22232292),
								 (48, 'AS', 'AS','AS-Cavaquinho', 22232462),
								 (49, 'Fender', 'Fender','Statocaster Classic', 22232462),
								 (50, 'Fender', 'Fender','Mustang Electric', 23332111),
								 (51, 'Fender', 'Fender','Mustang Electric', 2336391),
								 (52, 'Fender', 'Fender','Precision Bass-456', 2436581),
								 (53, 'Ludwig', 'Ludwig','FTT-789', 2446398),
								 (54, 'Tama', 'Tama','Tama Drums 750', 25535142),
								 (55, 'Tama', 'Tama','Tama Drums 750', 2656391),
								 (56, 'Pearl', 'Pearl','ERT-Drums 4645', 30321303),
								 (57, 'Epiphone', 'Epiphone','Les-paul Special ii', 30551353),
								 (58, 'Yamaha', 'Yamaha','EWS-keyboard ii', 30558859),
								 (59, 'Pearl', 'Pearl','ERT-Drums 4645', 32235391),
								 (60, 'Ibanez', 'Ibanez','AS200', 33058090),
								 (61, 'Gretsch', 'Gretsch','THL-789 Drums', 33143142),
								 (62, 'Fender', 'Fender','Jaguar-7894', 33333391),
								 (63, 'Yamaha', 'Yamaha','ASD Dum set', 33771792),
								 (64, 'Fender', 'Fender','Jaguar-7894', 34435391),
								 (65, 'Fender', 'Fender','Precision Bass-456', 35321223),
								 (66, 'Yamaha', 'Yamaha','EWS-keyboard ii', 37758390),
								 (67, 'Gretsch', 'Gretsch', 'Series ii basses', 38835881),
								 (68, 'Valco', 'Valco','1964 Montgomery Ward JB Hutto Airline', 44231492),
								 (69, 'Fender', 'Fender','Statocaster', 47147442),
								 (70, 'Tama', 'Tama','SAAA drumset', 48658353),
								 (71, 'Fender', 'Fender','Precision Bass-456', 55141142),
								 (72, 'Cecilio', 'Cecilio','CDB-W', 6146042),
								 (73, 'Gretsch', 'Gretsch','G2622-P90', 61736550),
								 (74, 'Hohner', 'Hohner','Compadre GCF black', 61736880),
								 (75, 'Ibanez', 'Ibanez','SR305E', 656390),
								 (76, 'Tama', 'Tama','Double kick, 324stf', 657790),
								 (77, 'Fender', 'Fender','Statocaster', 66166032),
								 (78, 'Pioneer', 'Pioneer','DJ DJ-400', 71734160),
								 (79, 'Gibson', 'Gibson','Les Paul Classic', 7550359),
								 (80, 'Tama', 'Tama','SAAA drumset', 78834880),
								 (81, 'Yamaha', 'Yamaha','YAS-280', 80807712),
								 (82, 'Yamaha', 'Yamaha','YAS-280', 81645391),
								 (83, 'Fender', 'Fender', 'Supersonic 60', 84222881),
								 (84, 'Epiphone','Epiphone','ESS 2360', 86148048),
								 (85, 'Pearl','Pearl','RoadShow Studio', 86615391),
								 (86, 'Yamaha', 'Yamaha','YAS-280', 86688398),
								 (87, 'Fender', 'Fender','Squier Paranormal Bass', 87177882),
								 (88, 'Moog Grandmother', 'Moog Grandmother','32-Key Semi-Modular', 87187142),
								 (89, 'Höfner', 'Höfner','176 Galaxie Sunburstr', 88205301),
								 (90, 'Yamaha', 'Yamaha','Electric-Acoustic 458-ESC Guitar', 88800880),
								 (91, 'Fender', 'Fender','Telecaster', 92220011),
								 (92, 'Fender', 'Fender','Squier Paranormal Bass', 92220033),
								 (93, 'Pearl','Pearl','RoadShow Studio', 92922911),
								 (94, 'Ibanez','Ibanez','456 EST Bass', 92922933),
								 (95, 'Cecilio', 'Cecilio','CDB-W ', 98900301),
								 (96, 'GRACE', 'GRACE','Student Natural Upright Double Bass ', 98910201);

/*	FAMILIAINSTRUMENTO	DONE*/
INSERT INTO FP.FamiliaInstrumento VALUES(1, 'Cordas'),
								 (2, 'Percussão'),
								 (3, 'Cordas'),
								 (4, 'Cordas'),
								 (5, 'Cordas'),
								 (6, 'Cordas'),
								 (7, 'Cordas'),
								 (8, 'Cordas'),
								 (9, 'Cordas'),
								 (10, 'Percussão'),
								 (11, 'Teclas'),
								 (12, 'Cordas'),
								 (13, 'Cordas'),
								 (14, 'Cordas'),
								 (15, 'Cordas'),
								 (16, 'Cordas'),
								 (17, 'Cordas'),
								 (18, 'Teclas'),
								 (19, 'Cordas'),
								 (20, 'Cordas'),
								 (21, 'Sopro'),
								 (22, 'Cordas'),
								 (23, 'Percussão'),
								 (24, 'Percussão'),
								 (25, 'Cordas'),
								 (26, 'Cordas'),
								 (27, 'Cordas'),
								 (28, 'Cordas'), 
								 (29, 'Cordas'),
								 (30, 'Percussão'),
								 (31, 'Cordas'),
								 (32, 'Percussão'),
								 (33, 'Teclas'),
								 (34, 'Cordas'),
								 (35, 'Cordas'),
								 (36, 'Cordas'),
								 (37, 'Cordas'),
								 (38, 'Cordas'),
								 (39, 'Sopro'),
								 (40, 'Cordas'),
								 (41, 'Sopro'),
								 (42, 'Cordas'),
								 (43, 'Cordas'),
								 (44, 'Cordas'),
								 (45, 'Teclas'),
								 (46, 'Percussão'),
								 (47, 'Cordas'),
								 (48, 'Cordas'),
								 (49, 'Cordas'),
								 (50, 'Cordas'),
								 (51, 'Cordas'),
								 (52, 'Cordas'),
								 (53, 'Percussão'),
								 (54, 'Percussão'),
								 (55, 'Percussão'),
								 (56, 'Percussão'),
								 (57, 'Cordas'),
								 (58, 'Teclas'),
								 (59, 'Percussão'),
								 (60, 'Cordas'),
								 (61, 'Percussão'),
								 (62, 'Cordas'),
								 (63, 'Percussão'),
								 (64, 'Cordas'),
								 (65, 'Cordas'),
								 (66, 'Cordas'),
								 (67, 'Cordas'),
								 (68, 'Cordas'),
								 (69, 'Cordas'),
								 (70, 'Percussão'),
								 (71, 'Cordas'),
								 (72, 'Cordas'),
								 (73, 'Cordas'),
								 (74, 'Teclas'),
								 (75, 'Cordas'),
								 (76, 'Percussão'),
								 (77, 'Cordas'),
								 (78, 'Teclas'),
								 (79, 'Cordas'),
								 (80, 'Percussão'),
								 (81, 'Sopro'),
								 (82, 'Sopro'),
								 (83, 'Cordas'),
								 (84, 'Cordas'),
								 (85, 'Percussão'),
								 (86, 'Sopro'),
								 (87, 'Cordas'),
								 (88, 'Teclas'),
								 (89, 'Cordas'),
								 (90, 'Cordas'),
								 (91, 'Cordas'),
								 (92, 'Cordas'),
								 (93, 'Percussão'),
								 (94, 'Cordas'),
								 (95, 'Cordas'),
								 (96, 'Cordas');

--SELECT * FROM FP.Musico;
--SELECT * FROM FP.Instrumento;
--SELECT * FROM FP.FamiliaInstrumento;

