SELECT NumeroPedido = p.idPedido,
       NomeCliente = c.nome,
	   idCliente = p.idCliente,
       StatusPedido = s.descricao,
	   ValorPedido = p.valor,
	   DataPedido = p.data,
	   idProduto = pd.idProduto,
	   NomeProduto = pd.descricao,
	   QuantProduto = i.quantidade,
	   ValorItem = i.valor 

FROM pedido p 
     INNER JOIN 
	 cliente c ON p.idCliente = c.idCliente 
     INNER JOIN 
	 status s ON p.idStatus = s.idStatus
	 INNER JOIN
	 item i ON p.idPedido = i.idPedido
	 INNER JOIN
	 produto pd ON pd.idProduto = i.idProduto
