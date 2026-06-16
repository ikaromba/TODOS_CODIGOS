// Importando o módulo http
const http = require('http');
const fs = require('fs');
const path = require('path');

// Criando o servidor
const server = http.createServer((req, res) => {
    // __dirname garante que o Node procure o arquivo na pasta correta do script
    // path.join(__dirname, 'index.html') chama seu html
    res.statusCode = 200;
    res.setHeader('Content-Type', 'text/html');
    re
    const caminhoHtml = path.join(__dirname, 'index.html');
    fs.readFile(caminhoHtml, (err, data) => {
        if (err) {
            res.statusCode = 500;
            res.setHeader('Content-Type', 'text/plain');
            res.end('Erro ao ler o arquivo index.html\\n');
        } else {
            res.statusCode = 200;
            res.setHeader('Content-Type', 'text/html');
            res.end(data);
        }
    });
});

// Especificando a porta
//Portas de Usuário ou Registradas (de 1024 até 49151).Elas são livres para qualquer programa comum usar.
const port = 8080;
server.listen(port, () => {
console.log(`Servidor rodando em http://localhost:${port}/`);
});