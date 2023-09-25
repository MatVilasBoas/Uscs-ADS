ALTER PROCEDURE Contagem (@limite int, @tipo int)
AS BEGIN
	DECLARE @i int
	if @tipo = 1 -- Regressiva
	BEGIN
		SET @i = @limite
		while @i >= 1
		BEGIN
			SELECT Valor = @i
			SET @i = @i - 1
		END
	END
	if @tipo = 2 -- Crescente
	BEGIN
		SET @i = 1
		while @i <= @limite
		BEGIN
			SELECT Valor = @i
			SET @i = @i + 1
		END
	END
END

-----------------------------------------------------

exec contagem 10, 1
-- limite , tipo
