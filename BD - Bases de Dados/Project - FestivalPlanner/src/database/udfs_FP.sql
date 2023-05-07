/*	
** script that contains the project UDFs
**
** Miguel Nogueira & David Araújo
 */

 --use Projeto;
 use p2g2;

 --Dado um id devolve um evento
GO 
CREATE FUNCTION getEventoById (@id VARCHAR(20)) RETURNS TABLE AS
	RETURN(SELECT * FROM FP.EVENTO
		   WHERE id = @id)
GO
 --Teste
--SELECT * FROM getEventoById(10);
--drop function getEventoById;



--Dado um nome devolve um evento
GO 
CREATE FUNCTION getEventoByNome (@nome VARCHAR(150)) RETURNS TABLE AS
	RETURN(SELECT * FROM FP.EVENTO
		   WHERE nome LIKE '%' + @nome + '%')
GO
 --Teste
--SELECT * FROM getEventoByNome('Foo');
--SELECT * FROM FP.EVENTO;
--drop function getEventoByNome;


--Dado um ccPromotor devolve um evento
GO 
CREATE FUNCTION getEventosByPromotor (@promotor_cc VARCHAR(12)) RETURNS TABLE AS
	RETURN(SELECT * FROM FP.EVENTO
		   WHERE cc_promotor = @promotor_cc)
GO
 --Teste
--SELECT * FROM getEventosByPromotor(114444);
-- drop function getEventosByPromotor;


--Dado um ccManager devolve um evento
GO 
CREATE FUNCTION getEventosByManager (@manager_cc VARCHAR(12)) RETURNS TABLE AS
	RETURN(SELECT * FROM FP.EVENTO
		   WHERE cc_manager = @manager_cc)
GO
 --Teste
--SELECT * FROM getEventosByManager(32032541);
-- drop function getEventosByManager;


--Dado o id de um Evento devolver os seus concertos
GO
CREATE FUNCTION getConcertosByIdEvento (@evento_id VARCHAR(20)) RETURNS TABLE AS
	RETURN(SELECT * FROM FP.CONCERTO
		   WHERE id_evento = @evento_id)
GO
--Teste
--SELECT * FROM getConcertosByIdEvento(14);
-- drop function getConcertosByIdEvento;


--Dado o id de um Evento devolver os seus concertos e respectivos soundchecks
GO
CREATE FUNCTION getConcertosSounchecksByIDEvento (@evento_id VARCHAR(20)) RETURNS TABLE AS
	RETURN(SELECT FP.CONCERTO.id, id_evento, FP.CONCERTO.id_palco as palco, id_banda, FP.CONCERTO.duracao as duracao_concerto, FP.CONCERTO.dataInicio as init_concerto, id_soundcheck, FP.SOUNDCHECK.duracao as duracao_soundcheck, FP.SOUNDCHECK.dataInicio as ini_soundcheck 
		   FROM FP.CONCERTO, FP.SOUNDCHECK
		   WHERE id_evento = 14 AND id_soundcheck = FP.SOUNDCHECK.id)
GO
--Teste
--SELECT * FROM getConcertosSounchecksByIDEvento(14);
-- drop function getConcertosSounchecksByIDEvento;


--Dado o id de um Evento devolver as bandas que vão tocar
GO
CREATE FUNCTION getBandasByIDEvento (@evento_id VARCHAR(20)) RETURNS TABLE AS
	RETURN(SELECT FP.BANDA.id, nome, telefone, email, nElementos FROM FP.CONCERTO, FP.BANDA
		   WHERE id_evento = @evento_id AND id_banda = FP.BANDA.id)
GO
--Teste
--SELECT * FROM getBandasByIDEvento(14);
-- drop function getBandasByIDEvento;

--Dado o id de uma Banda devolver os seus concertos
GO
CREATE FUNCTION getConcertosByIDBanda (@banda_id VARCHAR(20)) RETURNS TABLE AS
	RETURN(SELECT * FROM FP.CONCERTO
		   WHERE id_banda = @banda_id)
GO
--Teste
--SELECT * FROM geTConcertosByIDBanda('gd');
-- drop function geTConcertosByIDBanda;


--Dado o nome de uma Banda devolver os seus concertos
GO
CREATE FUNCTION getConcertosByNomeBanda( @nome VARCHAR(150)) RETURNS TABLE AS
	RETURN(SELECT FP.CONCERTO.id AS id, FP.CONCERTO.id_evento, FP.BANDA.nome, id_banda,  dataInicio, duracao 
		   FROM FP.BANDA, FP.CONCERTO
		   WHERE FP.BANDA.nome=@nome AND FP.BANDA.id=id_banda);
GO
--Teste
--SELECT * FROM getConcertosByNomeBanda('Green Day');
-- drop function getConcertosByNomeBanda;


-- Pesquisar músico por CC do músico
GO
CREATE FUNCTION getMusicoByCC (@cc VARCHAR(12)) RETURNS TABLE AS
	RETURN(SELECT nomeArtistico, id_banda
		   FROM FP.MUSICO
		   WHERE cc= @cc);
GO
--Teste
--SELECT * FROM getMusicoByCC(10111732);
-- drop function getMusicoByCC;


-- Pesquisar músico por Nome Artístico
GO
CREATE FUNCTION getMusicoByName (@name VARCHAR(12)) RETURNS TABLE AS
	RETURN(SELECT *
		   FROM FP.MUSICO
		   WHERE nomeArtistico LIKE '%' + @name + '%');
GO
--Teste
--SELECT * FROM getMusicoByName('Sara Ramos');
-- drop function getMusicoByName;



--Dado um id devolver a banda
GO
CREATE FUNCTION getBandaById (@id VARCHAR(20)) RETURNS TABLE AS
	RETURN(SELECT * FROM FP.BANDA
		   WHERE id=@id)
GO
--Teste
--SELECT * FROM getBandaById('ff');
-- drop function getBandaById;

GO
CREATE FUNCTION getBandByConcertoId(@id VARCHAR(20)) RETURNS TABLE AS
	RETURN(SELECT FP.Banda.*
			FROM FP.Concerto INNER JOIN
			FP.Palco ON FP.Palco.id = FP.Concerto.id_palco INNER JOIN
			FP.Banda ON FP.Banda.id = FP.Concerto.id_banda
			WHERE FP.Concerto.id = @id)
GO
--SELECT * FROM getBandByConcertoId('3');
-- drop function getBandByConcertoId;

--Dado um nome devolver a banda
GO
CREATE FUNCTION getBandaByNome (@nome VARCHAR(250)) RETURNS TABLE AS
	RETURN(SELECT * FROM FP.BANDA
		   WHERE nome LIKE '%' + @nome + '%')
GO
--Teste
--SELECT * FROM getBandaByNome('Foo Fighters');
-- drop function getBandaByNome;


--Dado um género devolver bandas
GO
CREATE FUNCTION getBandaByGenre (@genre VARCHAR(200)) RETURNS TABLE AS
	RETURN(SELECT FP.GeneroMusical.genero AS GeneroMusical, FP.Banda.nome AS NomeBanda 
		FROM FP.GeneroMusical, FP.BANDA
		   WHERE genero=@genre)
GO
--Teste
--SELECT * FROM getBandaByGenre('Punk');
-- drop function getBandaByGenre;



--Dado o id de uma Banda devolver os músicos constituintes que vão tocar
GO
CREATE FUNCTION getMusicosByIDBanda (@banda_id VARCHAR(20)) RETURNS TABLE AS
	RETURN(SELECT * FROM FP.MUSICO
		   WHERE id_banda = @banda_id)
GO
--Teste
--SELECT * FROM getMusicosByIDBanda('gd');
-- drop function getMusicosByIDBanda;



-- Dado uma data de inicio e de fim dar os eventos aí dentro
GO
CREATE FUNCTION getEventosInBetween (@data_inicio DATE, @data_fim DATE) RETURNS TABLE AS
	RETURN(SELECT * 
		   FROM FP.EVENTO
		   WHERE (dataInicio >= @data_inicio AND dataFim <= @data_fim) OR (dataFim >= @data_inicio AND dataFim <= @data_fim)) 
GO
--Teste
--SELECT * FROM FP.EVENTO;
--SELECT * FROM getEventosInBetween('2018-05-28', '2018-06-03');
-- drop function getEventosInBetween;



-- Dada uma duração minima e uma duração máxima devolver todos os concertos cuja duração se encontra entre esses valores
GO
CREATE FUNCTION getConcertosDuracaoInBetween (@min INT, @max INT) RETURNS TABLE AS
	RETURN(SELECT * FROM FP.CONCERTO
		   WHERE (duracao >= @min AND duracao <= @max)) 
GO
--Teste
--SELECT * FROM FP.CONCERTO;
--SELECT * FROM getConcertosDuracaoInBetween(50, 70);
-- drop function getConcertosDuracaoInBetween;

---------------------------
----------------------------
-- Dado um nome do evento, devolver informação sobre o mesmo
go
CREATE FUNCTION getOverviewByNome (@nome VARCHAR(20)) RETURNS TABLE AS
	RETURN(SELECT * FROM FP.V_GERAL
		   WHERE EVENTO_NOME LIKE  '%' + @nome + '%')
GO
--select * from getOverviewByNome('Festa')
-- drop function getOverviewByNome;

-- Dado um número de dias do evento, devolver informação sobre o mesmo
go
CREATE FUNCTION getOverviewByNumdias (@numdias VARCHAR(20)) RETURNS TABLE AS
	RETURN(SELECT * FROM FP.V_GERAL
		   WHERE nDias LIKE  '%' + @numdias + '%')
GO
--select * from getOverviewByNumdias(2)
-- drop function getOverviewByNumdias;

-- Dado um nome da banda, devolver informação sobre o evento em que a banda participa
go
CREATE FUNCTION getOverviewByBanda (@banda VARCHAR(20)) RETURNS TABLE AS
	RETURN(SELECT * FROM FP.V_GERAL
		   WHERE nome LIKE  '%' + @banda + '%')
GO
--select * from getOverviewByBanda('Foo')
-- drop function getOverviewByBanda;
GO
CREATE FUNCTION getOverviewByPromotorName (@promotor_nome VARCHAR(20)) RETURNS TABLE AS
	RETURN(SELECT * FROM FP.V_GERAL
		   WHERE PROMOTOR_NOME LIKE  '%' + @promotor_nome + '%')
--select * from getOverviewByPromotorName('Álvaro')
-- drop function getOverviewByPromotorName;
GO
CREATE FUNCTION getOverviewByPromotorEmail (@promotor_email VARCHAR(20)) RETURNS TABLE AS
	RETURN(SELECT * FROM FP.V_GERAL
		   WHERE PROMOTOR_EMAIL LIKE  '%' + @promotor_email + '%')
--select * from getOverviewByPromotorEmail('ac@gmail.com')
-- drop function getOverviewByPromotorEmail;
GO
CREATE FUNCTION getOverviewBy (@nome VARCHAR(20),@numdias VARCHAR(20),@promotor_nome VARCHAR(20), @promotor_email VARCHAR(20),@phone VARCHAR(12),@banda VARCHAR(20)  ) RETURNS TABLE AS
	RETURN(SELECT * FROM FP.V_GERAL
			WHERE EVENTO_NOME LIKE '%' + @nome + '%'
			AND nDias LIKE  '%' + @numdias + '%'
			AND PROMOTOR_NOME LIKE  '%' + @promotor_nome + '%'
			AND PROMOTOR_EMAIL LIKE  '%' + @promotor_email + '%'
			AND nome LIKE  '%' + @banda + '%'
			AND PROMOTOR_TELEFONE LIKE '%' + @phone + '%')
--select * from getOverviewBy('Rap', '3', '','','', 'Benzi')
--drop function getOverviewBy;