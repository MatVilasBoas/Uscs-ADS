-- Qual o pedido mais caro?

SELECT TOP 1 ValorPedido = p.valor, NomeCliente = c.nome
FROM pedido p 
INNER JOIN
      cliente c ON c.idCliente = p.idCliente 
      ORDER BY valor desc

-- Qual produto nunca foi pedido?

SELECT * FROM produto
where idProduto not in
(SELECT DISTINCT idProduto from item)

-- Qual cliente nunca fez um pedido?

SELECT c.nome, p.idPedido
FROM cliente c 
LEFT OUTER JOIN
     pedido p ON c.idCliente = p.idCliente
     where p.idPedido is null

-- Que produtos nunca foram pedidos?

SELECT pd.descricao
FROM produto pd 
LEFT OUTER JOIN
     item i ON pd.idProduto = i.idProduto
     where i.idProduto is null
