--use Projeto;
use p2g2;

CREATE INDEX idx_eventId ON FP.Evento(id);

CREATE INDEX idx_concertoId ON FP.Concerto(id);

CREATE INDEX idx_BandaId ON FP.Banda(id);

CREATE INDEX idx_Musico ON FP.Musico(cc);


--DROP INDEX FP.Evento.idx_eventId;
--DROP INDEX FP.Concerto.idx_concertoId;
--DROP INDEX FP.Banda.idx_BandaId;
--DROP INDEX FP.Musico.idx_Musico;