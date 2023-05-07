/*	
** script that contains the project triggers
**
** Miguel Nogueira & David Araújo
 */

--use Projeto;
use p2g2;



/* Apagar um concerto apaga também o seu soundcheck */
GO
CREATE TRIGGER delete_concert ON FP.Concerto
AFTER DELETE
AS
BEGIN
	DECLARE @sc_id AS VARCHAR(20);

	SELECT @sc_id = id_soundcheck FROM deleted;

	DELETE FROM FP.SoundCheck WHERE  id=@sc_id;
END
GO


/* Apagar um evento apaga também os seus concertos e soundchecks */
GO
CREATE TRIGGER delete_event ON FP.Evento
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @ev_id AS VARCHAR(20);
	
	SELECT @ev_id = id FROM deleted;

	DELETE FROM FP.Concerto WHERE id_evento = @ev_id;
	DELETE FROM FP.Evento WHERE id = @ev_id;
END
GO



/* Soundcheck não pode durar mais de 1 hora (se durar a sua duração é ajustada para 1 hora) */
GO
CREATE TRIGGER soundcheck_duration ON FP.SoundCheck
AFTER INSERT 
AS
BEGIN
	DECLARE @duracao AS INT;
	DECLARE @id AS VARCHAR(20);

	SELECT @id=id, @duracao = duracao  FROM inserted;

	IF (@duracao > 60)
	BEGIN
		PRINT 'Soundcheck duration must be less or equal than 1 hour'
		UPDATE FP.SoundCheck
		SET duracao = 60
		WHERE id = @id;
	END
END


/* não podem existir dois soundchecks ao mesmo tempo */
GO
CREATE TRIGGER simultaneos_soundchecks ON FP.Soundcheck
INSTEAD OF INSERT
AS
BEGIN
	DECLARE @dataini AS DATE;
	DECLARE @datafim AS DATE;
	DECLARE @d_ini AS DATE;
	DECLARE @d_fim AS DATE;
	DECLARE @duracao AS INT;
	
	SELECT @duracao = inserted.duracao, @dataini = inserted.dataInicio, @datafim = DATEADD(MINUTE, @duracao, @dataini) FROM inserted;

	DECLARE C CURSOR
	FOR
		SELECT dataInicio, DATEADD(MINUTE, @duracao, @dataini) AS fim
		FROM FP.Soundcheck;

	OPEN C;
	FETCH C INTO @d_ini, @d_fim;
	WHILE @@FETCH_STATUS = 0
	BEGIN
		IF ((@dataini >= @d_ini AND @dataini <= @d_fim) OR (@datafim >= @d_ini AND @datafim <= @d_fim)) 
		BEGIN
			RAISERROR('ERROR: Soundcheck date overlaps other soundchecks', 16, 1);
			CLOSE C;
			DEALLOCATE C;
			RETURN;
		END
		FETCH C INTO @d_ini, @d_fim;
	END
	CLOSE C;
	DEALLOCATE C;

	INSERT INTO FP.Soundcheck SELECT * FROM inserted;
END
