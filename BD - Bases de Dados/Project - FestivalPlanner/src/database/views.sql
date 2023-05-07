/*	
** script that includes views of the database
**
** Miguel Nogueira & David Araújo
 */
--use Projeto;
use p2g2;
GO

CREATE VIEW FP.V_BANDAS AS
	SELECT		id, nome, telefone, email, nElementos
	FROM		FP.Banda;
GO

CREATE VIEW FP.V_GERAL AS
	SELECT		FP.Evento.id, FP.Evento.nome AS EVENTO_NOME, FP.Evento.dataInicio, FP.Evento.nDias, FP.Pessoa.nome AS PROMOTOR_NOME, FP.Pessoa.email AS PROMOTOR_EMAIL, FP.Pessoa.telefone AS PROMOTOR_TELEFONE, FP.Banda.nome
	FROM		FP.Pessoa INNER JOIN
				FP.Promotor ON FP.Pessoa.cc = FP.Promotor.cc INNER JOIN 
				FP.Evento ON FP.Promotor.cc = FP.Evento.cc_promotor LEFT JOIN
				FP.Concerto	ON FP.Concerto.id_evento = FP.Evento.id LEFT JOIN
				FP.Banda ON FP.Banda.id = FP.Concerto.id_banda; 

CREATE VIEW FP.V_CONCERTO AS
	SELECT		FP.Evento.id AS event_id, FP.Concerto.id, FP.Banda.id AS band_id, FP.Palco.id AS stage_id,  FP.Concerto.dataInicio AS dataInicio, FP.Concerto.duracao AS concertoDuracao, FP.SoundCheck.duracao AS soundckDuracao, FP.Palco.endereco, FP.Palco.lotacao, FP.Banda.nome, FP.SoundCheck.id AS sound_id
	FROM		FP.Concerto INNER JOIN
				FP.Evento ON FP.Concerto.id_evento=FP.Evento.id INNER JOIN
				FP.Palco ON FP.Concerto.id_palco = FP.Palco.id INNER JOIN
				FP.SoundCheck ON FP.Concerto.id_soundcheck = FP.SoundCheck.id INNER JOIN
				FP.Banda ON FP.Concerto.id_banda = FP.Banda.id
--DROP VIEW FP.V_BANDAS;
--DROP VIEW FP.V_GERAL;
--DROP VIEW FP.V_CONCERTO;

--SELECT * FROM FP.V_BANDAS;
--SELECT * FROM FP.V_GERAL;
--SELECT * FROM FP.V_CONCERTO;