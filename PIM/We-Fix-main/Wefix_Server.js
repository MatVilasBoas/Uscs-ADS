const express = require('express')
const mysql = require('mysql')
const cors = require('cors')
const app = express();

app.use(cors())
app.use(express.json());

const port = 3002

// Conecta com o banco de dados
const db =  mysql.createConnection({
    host: 'localhost',
    user: 'root',
    password: '',
    database: 'wefixdb'
})

// Conecta no banco de dados
db.connect((err) => {
    console.log("Conectado ao banco de dados.")
})

// ---------------- GETs ----------------

// Obter todos os clientes
app.get('/clientes', cors(), (req, res) => {
    let sql = 'SELECT * FROM cliente';
    db.query(sql, (err, resultados) => {
        res.json(resultados);
    });
});

// Obter um Cliente por CPF
app.get('/clientes/:cpf_cliente', (req, res) => {
    let sql = `SELECT * FROM cliente WHERE cpf_cliente=${req.params.cpf_cliente}`;
    db.query(sql, (err, resultados) => {
        res.json(resultados);
    });
});

// Obtem um cliente por email
app.get('/clientes/email/:email', (req, res) => {
    let sql = `SELECT * FROM cliente WHERE email='${req.params.email}'`;
    db.query(sql, (err, resultados) => {
        res.json(resultados);
    })
})

// ---- ARQUITETOS

// Obtem Arquitetos
app.get('/arquitetos', cors(), (req, res) => {
    let sql = 'SELECT * FROM arquiteto';
    db.query(sql, (err, resultados) => {
        res.json(resultados);
    });
});

// Obter um Arquitetos por CPF
app.get('/arquitetos/:cpf_arquiteto', (req, res) => {
    let sql = `SELECT * FROM arquiteto WHERE cpf_arquiteto=${req.params.cpf_arquiteto}`;
    db.query(sql, (err, resultados) => {
        res.json(resultados);
    });
});

// Obtem um arquiteto por email
app.get('/arquitetos/email/:email', (req, res) => {
    let sql = `SELECT * FROM arquiteto WHERE email='${req.params.email}'`;
    db.query(sql, (err, resultados) => {
        res.json(resultados);
    })
})



// ---- ENGENHEIROS ! ! ! !

// Obtem Engenheiros
app.get('/engenheiros', cors(), (req, res) => {
    let sql = 'SELECT * FROM engenheiro';
    db.query(sql, (err, resultados) => {
        res.json(resultados);
    });
});

// Obter um Engenheiro por CPF
app.get('/engenheiros/:cpf_engenheiro', (req, res) => {
    let sql = `SELECT * FROM engenheiro WHERE cpf_engenheiro=${req.params.cpf_engenheiro}`;
    db.query(sql, (err, resultados) => {
        res.json(resultados);
    });
});

// Obtem um Engenheiro por email
app.get('/engenheiros/email/:email', (req, res) => {
    let sql = `SELECT * FROM engenheiro WHERE email='${req.params.email}'`;
    db.query(sql, (err, resultados) => {
        res.json(resultados);
    })
})

// ---- PROFISSIONAL GERAL ! ! ! !

// Obtem Profissional Geral
app.get('/profissionalgeral', cors(), (req, res) => {
    let sql = 'SELECT * FROM profissionalgeral';
    db.query(sql, (err, resultados) => {
        res.json(resultados);
    });
});

// Obter um Profissional Geral por CPF
app.get('/profissionalgeral/:cpf_profissional', (req, res) => {
    let sql = `SELECT * FROM profissionalgeral WHERE cpf_profissional=${req.params.cpf_profissional}`;
    db.query(sql, (err, resultados) => {
        res.json(resultados);
    });
});

// Obtem um Profissional Geral por email
app.get('/profissionalgeral/email/:email', (req, res) => {
    let sql = `SELECT * FROM profissionalgeral WHERE email='${req.params.email}'`;
    db.query(sql, (err, resultados) => {
        res.json(resultados);
    })
})

// ---- OBRAS ----

// Obter todas as obras
app.get('/obras', cors(), (req, res) => {
    let sql = 'SELECT * FROM obra';
    db.query(sql, (err, resultados) => {
        res.json(resultados);
    });
});

// Obter obra por id
app.get('/obras/:id_obra', cors(), (req, res) => {
    let sql = `SELECT * FROM obra WHERE id_obra='${req.params.id_obra}'`;
    db.query(sql, (err, resultados) => {
        res.json(resultados);
    });
});

// Obter todas as obras por cpf_cliente
app.get('/obras/cpfcliente/:cpf_cliente', cors(), (req, res) => {
    let sql = `SELECT * FROM obra WHERE cpf_cliente='${req.params.cpf_cliente}'`;
    db.query(sql, (err, resultados) => {
        res.json(resultados);
    });
});

// Obter todas as obras que estão PENDENTES
app.get('/obras/pendentes', cors(), (req, res) => {
    let sql = "SELECT * FROM `obra` WHERE `status`='PENDENTE'";
    db.query(sql, (err, resultados) => {
        res.json(resultados);
    });
});

// Obter todas as obras que estão EM ANDAMENTO
app.get('/obras/emandamento', cors(), (req, res) => {
    let sql = "SELECT * FROM `obra` WHERE `status`='EM ANDAMENTO'";
    db.query(sql, (err, resultados) => {
        res.json(resultados);
    });
});

// Obter todas as obras que estão FINALIZADAS
app.get('/obras/finalizadas', cors(), (req, res) => {
    let sql = "SELECT * FROM `obra` WHERE `status`='FINALIZADAS'";
    db.query(sql, (err, resultados) => {
        res.json(resultados);
    });
});

// Obter todas as obras que estão PENDENTES por cpf_cliente
app.get('/obras/pendentes/:cpf_cliente', cors(), (req, res) => {
    let cpf_cliente = req.params.cpf_cliente;
    let sql = `SELECT * FROM obra WHERE status='PENDENTE' AND cpf_cliente='${cpf_cliente}'`;
    db.query(sql, (err, resultados) => {
        if (err) {
            console.log(err);
            res.status(500).send(err);
        } else {
            res.json(resultados);
        }
    });
});

// Obter todas as obras que estão EM ANDAMENTO por cpf_cliente
app.get('/obras/emandamento/:cpf_cliente', cors(), (req, res) => {
    let cpf_cliente = req.params.cpf_cliente;
    let sql = `SELECT * FROM obra WHERE status='EM ANDAMENTO' AND cpf_cliente='${cpf_cliente}'`;
    db.query(sql, (err, resultados) => {
        if (err) {
            console.log(err);
            res.status(500).send(err);
        } else {
            res.json(resultados);
        }
    });
});

// Obter todas as obras que estão FINALIZADAS por cpf_cliente
app.get('/obras/finalizadas/:cpf_cliente', cors(), (req, res) => {
    let cpf_cliente = req.params.cpf_cliente;
    let sql = `SELECT * FROM obra WHERE status='FINALIZADAS' AND cpf_cliente='${cpf_cliente}'`;
    db.query(sql, (err, resultados) => {
        if (err) {
            console.log(err);
            res.status(500).send(err);
        } else {
            res.json(resultados);
        }
    });
});


// ---- SOLICITAÇÕES ----

// Obter todas as Solicitações
app.get('/solicitacao', cors(), (req, res) => {
    let sql = 'SELECT * FROM solicitacao';
    db.query(sql, (err, resultados) => {
        res.json(resultados);
    });
});

// ---------------- POSTs ----------------

// Adiciona Clientes
app.post('/clientes', (req, res) => {
    let cliente = req.body;
    let sql = 'INSERT INTO cliente SET ?';
    db.query(sql, cliente, (err, resultados) => {
        console.log(resultados);
    });
    res.status(201).json(cliente);
})

// Adiciona Arquitetos
app.post('/arquitetos', (req, res) => {
    let arquiteto = req.body;
    let sql = 'INSERT INTO arquiteto SET ?';
    db.query(sql, arquiteto, (err, resultados) => {
        console.log(resultados);
    });
    res.status(201).json(arquiteto);
})

// Adiciona Engenheiros
app.post('/engenheiros', (req, res) => {
    let engenheiro = req.body;
    let sql = 'INSERT INTO engenheiro SET ?';
    db.query(sql, engenheiro, (err, resultados) => {
        console.log(resultados);
    });
    res.status(201).json(engenheiro);
})

// Adiciona Profissionais Gerais
app.post('/profissionalgeral', (req, res) => {
    let profissionalgeral = req.body;
    let sql = 'INSERT INTO profissionalgeral SET ?';
    db.query(sql, profissionalgeral, (err, resultados) => {
        console.log(resultados);
    });
    res.status(201).json(profissionalgeral);
})

// ---- OBRA ----

// Adiciona Obra
app.post('/obras', (req, res) => {
    let obra = req.body;
    let sql = 'INSERT INTO obra SET ?';
    db.query(sql, obra, (err, resultados) => {
        console.log(resultados);
    });
    res.status(201).json(obra);
})

// Transforma Solicitação em Obra
app.post('/obras/solicitacao/:id_solicitacao/:user_email', (req, res) => {
    let id_solicitacao = req.params.id_solicitacao;
    let user_email = req.params.user_email; 

    getCpfTipo(user_email, (err, user) => {
        if (err) {
            console.log(err);
            res.status(500).send(err);
        } else {
            let sql = `SELECT * FROM solicitacao WHERE id_solicitacao='${id_solicitacao}'`;
            db.query(sql, (err, solicitacao) => {
                if (err) {
                    console.log(err);
                    res.status(500).send(err);
                } else {
                    console.log(solicitacao)
                    let dataInicio = new Date();
                    let dataTermino = new Date();
                    dataTermino.setDate(dataInicio.getDate() + 31);
                    let newObra = {
                        id_obra: Math.floor(100000 + Math.random() * 900000),
                        local_obra: solicitacao[0].local,
                        descricao_obra: solicitacao[0].descricao,
                        data_inicio: dataInicio,
                        data_termino: dataTermino,
                        cpf_arquiteto: user.type === 'arquiteto' ? user.cpf : null,
                        cpf_engenheiro: user.type === 'engenheiro' ? user.cpf : null,
                        cpf_profissional: user.type === 'profissionalgeral' ? user.cpf : null,
                        cpf_cliente: solicitacao[0].cpf_cliente,
                        status: "EM ANDAMENTO"
                    };

                    // Cria Obra com as informaçoes acima
                    let insertSql = `INSERT INTO obra SET ?`;
                    db.query(insertSql, newObra, (insertErr, insertResult) => {
                        if (insertErr) {
                            console.log(insertErr);
                            res.status(500).send(insertErr);
                        } else {
                            // Deleta solicitacao dps que foi criada com sucesso
                            let deleteSql = `DELETE FROM solicitacao WHERE id_solicitacao='${id_solicitacao}'`;
                            db.query(deleteSql, (deleteErr, deleteResult) => {
                                if (deleteErr) {
                                    console.log(deleteErr);
                                    res.status(500).send(deleteErr);
                                } else {
                                    res.json(insertResult);
                                }
                            });
                        }
                    });
                }
            });
        }
    });
});



// ---- SOLICITAÇÕES ----

// Adiciona Solicitacao
app.post('/solicitacao', (req, res) => {
    let solicitacao = req.body;
    let sql = 'INSERT INTO solicitacao SET ?';
    db.query(sql, solicitacao, (err, resultados) => {
        console.log(resultados);
    });
    res.status(201).json(solicitacao);
})

// Function pra pegar cpf e tipo de conta por email
function getCpfTipo(email, callback) {
    let sql = `SELECT cpf_arquiteto as cpf, 'arquiteto' as type FROM arquiteto WHERE email='${email}' 
               UNION ALL SELECT cpf_engenheiro as cpf, 'engenheiro' as type FROM engenheiro WHERE email='${email}' 
               UNION ALL SELECT cpf_profissional as cpf, 'profissionalgeral' as type FROM profissionalgeral WHERE email='${email}'`;

    db.query(sql, (err, results) => {
        if (err) {
            console.log(err);
            callback(err, null);
        } else {
            let user = results[0];
            callback(null, user);
        }
    });
}

// Ola mundo!
app.get('/', (request, response) => {
    response.send("Ola mundo")
})

// Printa Mensagem ao conectar com a porta
app.listen(port, () => {
    console.log("Servidor conectado na porta " + port)
})
