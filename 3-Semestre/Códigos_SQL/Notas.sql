ALTER PROCEDURE getExtratoNotas (@idAluno INT=null)
AS
BEGIN
    -- -----------------------------------------------------------
    IF @idAluno IS NOT NULL BEGIN

       IF NOT EXISTS (SELECT * from aluno where idAluno=@idAluno)
          print 'ALUNO NAO EXISTE'
       ELSE
          select a.nome,n.n1,n.n2, media = (n.n1 + n.n2)/2
          from aluno a inner join
               nota n on a.idaluno = n.idaluno
          WHERE a.idAluno=@idAluno
          order by a.nome
    END
    -- -----------------------------------------------------------
    ELSE
        select a.nome,n.n1,n.n2, media = (n.n1 + n.n2)/2
        from aluno a inner join
            nota n on a.idaluno = n.idaluno
        order by a.nome
END

-- Alterar a procedure getExtratoNotas
-- Inserir um parametro inteiro chamado @idAluno
-- Caso a procedure receba um valor de @idAluno diferente de NULL, apresentar os dados do aluno
-- Caso receba NULL, apresentar todos os alunos
-- Tratar o caso de @idAluno não existir, retornando mensagem indicativa