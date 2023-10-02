CREATE TABLE [dbo].[nota](
    [chnota] [int] IDENTITY(1,1) NOT NULL,
    [chaluno] [int] NULL,
    [n1] [decimal](10, 2) NULL,
    [n2] [decimal](10, 2) NULL,
    [n3] [decimal](10, 2) NULL
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[aluno](
    [chaluno] [int] IDENTITY(1,1) NOT NULL,
    [nome] [varchar](50) NULL
) ON [PRIMARY]
GO
insert into aluno (nome)
select 'ANA' union select 'Pedro' union select 'Beth'
go
insert into nota (chaluno, n1,n2,n3)
select 1, 10, 2, 0 union
select 2, 4, 4, 4    union
select 3, 5, 5, 8
go

-- Criar tabela de alunos e notas