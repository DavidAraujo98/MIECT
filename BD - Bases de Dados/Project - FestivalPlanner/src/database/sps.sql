/*	
** script that contains the project Procedures
**
** Miguel Nogueira & David Araújo
 */

 --use Projeto;
 use p2g2;

/* Criar um evento */
GO
CREATE PROCEDURE create_evento( @id VARCHAR(20), @nome VARCHAR(150), @numdias INT, @dataini DATE, @datafim DATE, @numbilhetes INT, @dataproposta DATE, @cc_promotor VARCHAR(12), @cc_manager VARCHAR(12))
AS
BEGIN
	BEGIN TRY
		INSERT INTO FP.Evento VALUES(@id, @nome, @numdias, @dataini, @datafim, @numbilhetes, @dataproposta, @cc_promotor, @cc_manager);
		PRINT 'Event created successfully!'
	END TRY
	BEGIN CATCH
		PRINT ERROR_MESSAGE()
	END CATCH
END

--SELECT * FROM FP.Evento;
--drop procedure create_evento;
/* Teste */
EXEC create_evento 50, 'Evento Teste', 1,'2021-06-01', '2021-06-01',1400,'2020-01-30', 2134022, 12003011;


/* Criar um concerto e um soundcheck para uma determinada banda*/
GO
CREATE PROCEDURE create_concerto( @id VARCHAR(20), @id_evento VARCHAR(20), @id_palco VARCHAR(20), @id_banda VARCHAR(20), @duracao INT, @datatimeini DATETIME, @id_soundcheck VARCHAR(20), @duracao_soundcheck INT, @data_soundcheck DATETIME)
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			INSERT INTO FP.SOUNDCHECK VALUES(@id_soundcheck, @duracao_soundcheck, @data_soundcheck); 
			INSERT INTO FP.CONCERTO VALUES(@id, @id_evento, @id_palco, @id_banda, @duracao, @datatimeini, @id_soundcheck);
			PRINT 'Concert created successfully!'
		COMMIT
	END TRY
	BEGIN CATCH
		PRINT ERROR_MESSAGE()
		ROLLBACK
	END CATCH
END

/* Teste */
--SELECT * FROM FP.CONCERTO;
--SELECT * FROM FP.SOUNDCHECK;
--SELECT * FROM FP.EVENTO;
--drop procedure create_concerto;
EXEC create_concerto 80, 20, 15, 'asdasd', 30, '2022-03-02', 50, 30, '2020-05-04 10:00:00';





/*Apagar um evento dado o id do mesmo*/
GO
CREATE PROCEDURE delete_evento_byId( @id VARCHAR(20))
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM FP.EVENTO WHERE id=@id; 
			PRINT 'Event deleted successfully!'
		COMMIT
	END TRY
	BEGIN CATCH
		PRINT ERROR_MESSAGE()
		ROLLBACK
	END CATCH
END

/* Teste */
--SELECT * FROM FP.EVENTO;
--drop procedure delete_evento_byId;
EXEC delete_evento_byId 40;




/*Apagar um concerto dado o id do mesmo*/
GO
CREATE PROCEDURE delete_concerto_byId( @id VARCHAR(20))
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM FP.CONCERTO WHERE id=@id; 
			PRINT 'Concert deleted successfully!'
		COMMIT
	END TRY
	BEGIN CATCH
		PRINT ERROR_MESSAGE()
		ROLLBACK
	END CATCH
END

/* Teste */
--SELECT * FROM FP.CONCERTO;
--drop procedure delete_concerto_byId;
EXEC delete_concerto_byId 49;


/*Editar um evento */
GO
CREATE PROCEDURE alter_evento( @id VARCHAR(20), @nome VARCHAR(150), @numdias INT, @dataini DATETIME, @datafim DATETIME, @numBilhetes INT, @dataproposta DATETIME, @cc_promotor VARCHAR(12), @cc_manager VARCHAR(12) )
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DECLARE @id_old AS VARCHAR(20);
			DECLARE @nome_old AS VARCHAR(150);
			DECLARE @numdias_old AS INT;
			DECLARE @dataini_old AS DATE;
			DECLARE @datafim_old AS DATE;
			DECLARE @numBilhetes_old INT;
			DECLARE @dataproposta_old DATE;
			DECLARE @cc_promotor_old VARCHAR(12);
			DECLARE @cc_manager_old VARCHAR(12);

			SELECT @id_old = id, @nome_old = nome, @numdias_old = nDias, @dataini_old = dataInicio, @datafim_old = dataFim, @numBilhetes_old = nBilhetes, @dataproposta_old = dataProposta, @cc_promotor_old = cc_promotor, @cc_manager_old = cc_manager
			FROM FP.EVENTO
			WHERE FP.EVENTO.id = @id;

			IF @id_old != @id
			BEGIN
				UPDATE FP.EVENTO SET id = @id WHERE id=@id_old;
				PRINT 'Event id updated with success'
			END

			IF @nome_old != @nome
			BEGIN
				UPDATE FP.EVENTO SET nome = @nome WHERE @id_old = id;
				PRINT 'Event name updated with success'
			END

			IF @numdias_old != @numdias
			BEGIN
				UPDATE FP.EVENTO SET nDias = @numdias WHERE @id_old = id;
				PRINT 'Event days updated with success'
			END

			IF @dataini_old != @dataini
			BEGIN
				UPDATE FP.EVENTO SET dataInicio = @dataini WHERE @id_old = id;
				PRINT 'Event start date updated with success'
			END

			IF @datafim_old != @datafim
			BEGIN
				UPDATE FP.EVENTO SET dataFim = @datafim WHERE @id_old = id;
				PRINT 'Event end date updated with success'
			END

			IF @numbilhetes_old != @numbilhetes
			BEGIN
				UPDATE FP.EVENTO SET nBilhetes = @numbilhetes WHERE @id_old = id;
				PRINT 'Event tickets updated with success'
			END

			IF @dataproposta_old != @dataproposta
			BEGIN
				UPDATE FP.EVENTO SET dataProposta = @dataproposta WHERE @id_old = id;
				PRINT 'Event proposal date updated with success'
			END

			IF @cc_promotor_old != @cc_promotor
			BEGIN
				UPDATE FP.EVENTO SET cc_promotor = @cc_promotor WHERE @id_old = id;
				PRINT 'Event end promotor updated with success'
			END

			IF @cc_manager != @cc_manager_old
			BEGIN
				UPDATE FP.EVENTO SET cc_manager =  @cc_manager WHERE @id_old = id;
				PRINT 'Event stage manager updated with success'
			END

		COMMIT
	END TRY
	BEGIN CATCH
		PRINT ERROR_MESSAGE()
		ROLLBACK
	END CATCH
END

/* Teste */
--SELECT * FROM FP.EVENTO;
--drop procedure alter_evento;
EXEC alter_evento 1, 'RockFest', 2, '2018-06-02', '2018-06-03', 1450, '2017-12-01', 1134000, 22032242;