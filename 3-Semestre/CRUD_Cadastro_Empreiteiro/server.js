// Importação das bibliotecas necessárias
const express = require('express');
const mysql = require('mysql');
const app = express();
const cors = require('cors')

app.use(cors())
app.use(express.json());

// Definição da porta do servidor
const port = 3002;

// Conecta com o banco de dados
const db =  mysql.createConnection({
    host: 'localhost',
    user: 'root',
    password: '',
    database: 'profissionaldb'
})

// Conecta ao banco de dados
db.connect((err) => {
    console.log('Conectado ao banco de dados!');
});

// Obter todos os Empreiteiros
app.get('/empreiteiros', cors(), (req, res) => {
    console.log("Get");
    let sql = 'SELECT * FROM empreiteiro';
    db.query(sql, (err, results) => {
        res.send(results);
    });
});

// Obter um Empreiteiro
app.get('/empreiteiros/:cpf', (req, res) => {
    let sql = `SELECT * FROM empreiteiro WHERE cpf=${req.params.cpf}`;
    db.query(sql, (err, results) => {
        res.json(results);
    });
});

// Adiciona Empreiteiros
app.post('/empreiteiros', (req, res) => {

    let empreiteiro = req.body;
    let sql = 'INSERT INTO empreiteiro SET ?';
    db.query(sql, empreiteiro, (err, result) => {
        console.log(result);
    });
    res.status(201).json(empreiteiro);
});

// Deleta Empreiteiros
app.delete('/empreiteiros/:cpf', (req, res) => {
    let sql = `DELETE FROM empreiteiro
    WHERE cpf=${req.params.cpf}`;
    db.query(sql, (err, result) => {
        res.send(result);
    });
});

// Altera Empreiteiros
app.put('/empreiteiros/:cpf', cors(), (req, res) => {
    let empreiteiro = req.body;
    let sql = `UPDATE empreiteiro
    SET
    cpf='${empreiteiro.cpf}', 
    nome='${empreiteiro.nome}',
    email='${empreiteiro.email}',
    senha='${empreiteiro.senha}',
    endereco='${empreiteiro.endereco}',
    especialidade='${empreiteiro.especialidade}',
    certificados='${empreiteiro.certificados}' 
    WHERE cpf='${req.params.cpf}'`;
    
    db.query(sql, (err, result) => {
        if (err) {
            console.error(err);
            res.status(500).json({ error: 'Ocorreu um erro durante a atualização do Empreiteiro.' });
        } else {
            console.log(result);
            res.json(empreiteiro);
        }
    });
});


app.get('/', (request, response) => {
    response.send("Olá");
});

app.listen(port, () => {
    console.log(`Servidor aberto na porta ${port}`);
});