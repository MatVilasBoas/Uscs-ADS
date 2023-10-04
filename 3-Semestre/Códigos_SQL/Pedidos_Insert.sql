-- -------------------------------------------
INSERT INTO    status (descricao)
    VALUES
    ('Em andamento'),
    ('Concluído');
-- -------------------------------------------
INSERT INTO    cliente (CPF, nome, nascimento)
    VALUES
    ('12745678801', 'João Silva', '1990-01-15'),
    ('98745732109', 'Maria Souza', '1985-05-20');
-- -------------------------------------------
INSERT INTO    produto (descricao, valor)
    VALUES
    ('Coca-cola', 10.00),
    ('xBurger', 15.50),
    ('xSalada', 20.00);
-- -------------------------------------------
INSERT INTO    pedido (idstatus, idcliente, valor, data)
select                   1,         1,        1000, getdate()
-- -------------------------------------------
INSERT INTO    item (idPedido, idProduto, quantidade, valor)
select                 1,         1,         100,      1000
-- -------------------------------------------
select * from item
select * from produto
select * from pedido
select * from status
select * from cliente
-- -------------------------------------------
