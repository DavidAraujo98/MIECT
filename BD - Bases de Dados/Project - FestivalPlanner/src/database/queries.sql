/*	
** script that includes queries to the database
**
** Miguel Nogueira & David Araújo
 */


--use Projeto;

use p2g2;



/*	Promotores com mais do que um evento */
SELECT FP.Pessoa.cc, FP.Pessoa.nome, FP.Pessoa.cc, email, COUNT(FP.Evento.id) AS numEventos
FROM FP.Pessoa, FP.Promotor, FP.Evento
WHERE cc_promotor = FP.Promotor.cc AND FP.Promotor.cc = FP.Pessoa.cc
GROUP BY FP.Pessoa.nome, FP.Pessoa.cc, FP.Pessoa.email
HAVING  COUNT(FP.Evento.id) > 1;


/* Eventos cujo número de bilhetes seja maior que a média de todos os bilhetes vendidos */
SELECT id, nome, nDias, nBilhetes 
FROM FP.Evento
WHERE nBilhetes > ANY( SELECT AVG(nBilhetes) as media_bilhetes
						 FROM FP.Evento);


/* Promotores dos eventos a acontecer a partir de 2022 */
SELECT FP.Pessoa.cc, FP.Pessoa.nome, FP.Pessoa.email, FP.Pessoa.telefone, FP.Evento.nome
FROM FP.Evento, FP.Pessoa, FP.Promotor
WHERE cc_promotor = FP.Promotor.cc AND FP.Promotor.cc = FP.Pessoa.cc AND dataInicio > '2021-12-31';


/* Empresas de catering e o número de eventos aos quais fornecem serviços */
SELECT FP.EmpresaCatering.nif, FP.EmpresaCatering.nome, COUNT(FP.Evento.nome) as numEventos 
FROM FP.Refeicao, FP.EmpresaCatering, FP.Evento
WHERE nif_empresa = nif AND id_evento = FP.Evento.id
GROUP BY nif, FP.EmpresaCatering.nome
ORDER BY numEventos;


/* Número de Musicos de cada comitiva */
SELECT FP.Comitiva.id, FP.Comitiva.id_banda, COUNT(*) AS num_Musicos
FROM FP.Comitiva, FP.Banda, FP.Musico
WHERE FP.Comitiva.id_banda = FP.Banda.id AND FP.Banda.id = FP.Musico.id_banda
GROUP BY FP.Comitiva.id, FP.Comitiva.id_banda
ORDER BY COUNT(*)


/* Número de Instrumentos que cada banda traz */
SELECT FP.Banda.id, FP.Banda.nome, COUNT(model) as numInstumentos
FROM FP.Instrumento, FP.Musico, FP.Banda
WHERE FP.Musico.id_banda=FP.Banda.id AND FP.Instrumento.cc_musico = FP.Musico.cc
GROUP BY FP.Banda.id, FP.Banda.nome;


/* Eventos, número de dias e de concertos */
SELECT FP.Evento.id, FP.Evento.nome, FP.Evento.nDias, COUNT(FP.Concerto.id) as num_concertos
FROM FP.Evento, FP.Concerto
WHERE FP.Evento.id=FP.Concerto.id_evento
GROUP BY FP.Evento.id, FP.Evento.nome, FP.Evento.nDias
ORDER BY FP.Evento.nDias;



SELECT * FROM FP.Banda;