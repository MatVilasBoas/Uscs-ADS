-- Exemplo WHERE

WHERE Aluno = 2 OR Aluno = 4
WHERE Aluno IN (2,4)

WHERE nome LIKE 'A%' = começa com A
                '%A' = termina com A 
                '%A%' = todos que tenham A

-- Exemplo INSERT

INSERT INTO Aluno(nome) VALUES ('Ana')
                               ('José')
                               ('Pedro')
                               ('Beth')

INSERT INTO Aluno(nome)
SELECT ('Ana') UNION
SELECT ('José') UNION
SELECT ('Pedro') UNION
SELECT ('Beth')

-- Exemplo PROCEDURE 

CREATE PROCEDURE setLimite (@idCliente int, @fator decimal(10,2))
AS BEGIN
        UPDATE cliente
        SET limite = limite * @fator
        WHERE idCliente = @idCliente
END

SELECT * FROM cliente
EXEC setLimite 5,3


CREATE PROCEDURE getResultados (@aluno int)
AS BEGIN 
        DECLARE @media int
        SET @media = (SELECT(n1 + n2) / 2 FROM nota WHERE idAluno = @aluno)

        IF @media >= 6 SELECT + 'Aprovado'
        ELSE SELECT 'Reprovado'
END

EXEC getResultados1





