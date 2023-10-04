-- TABELA AUXILIAR  

CREATE TABLE status(
    idStatus INT NOT NULL IDENTITY PRIMARY KEY,
    descricao varchar(50),
);

-- TABELAS PRINCIPAIS

CREATE TABLE cliente (
    idCliente int NOT NULL identity PRIMARY KEY,
    CPF VARCHAR(11) ,
    nome VARCHAR(45),
    nascimento DATE,
);
CREATE TABLE pedido (
    idPedido  INT not null IDENTITY PRIMARY KEY,
    idStatus  INT NOT NULL,
    idCliente INT not null,
    valor DECIMAL(10,2),
    data  DATE,
    FOREIGN KEY (idStatus)  REFERENCES status (idStatus),
    FOREIGN KEY (idCliente) REFERENCES cliente(idCliente),
);
CREATE TABLE produto (
    idProduto INT NOT NULL IDENTITY PRIMARY KEY,
    descricao VARCHAR(45),
    valor DECIMAL(10,2),
);

-- ITENS = CARRINHO
CREATE TABLE item (
    idItem    INT NOT NULL IDENTITY PRIMARY KEY,
    idPedido  INT NOT NULL,
    idProduto INT NOT NULL,
    quantidade INT,
    valor DECIMAL(10,2),
    FOREIGN KEY (idPedido)  REFERENCES pedido(idPedido),
    FOREIGN KEY (idProduto) REFERENCES produto(idProduto)
);
