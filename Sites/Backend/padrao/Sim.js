// Importando o módulo http
const http = require('http');
const fs = require('fs');
const path = require('path');

// Criando o servidor
const server = http.createServer((req, res) => {
    //<br> para quebrar linha
    //200 sucesso, 404 sevidor nao encontrado, 500 erro no servidor, 1xx informativo, 3xx redirecionamento, 4xx erro do cliente
    if(req.url === '/') {
        res.writeHead(200, {'Content-Type': 'text/html'});
        res.end('BEm vindo a pagina inicial___(BETA) <br>Use /birb para acessar a pagina do Birb <br>Use /Erros para acessar a pagina que explica os erros e os codigos de status');

    }
    else if(req.url === '/birb') {
        res.writeHead(200, {'Content-Type': 'text/html'});
        res.end('Birb Page (°v°√7 (BETA) ');
    }
    else if(req.url === '/Erros'){
        res.writeHead(200, {'Content-Type': 'text/html'});
        res.end('Status e Erros (BETA) <br> . <br> 1xx(informativo) 2xx(sucesso) 3xx(redirecionamento) 4xx (erro do cliente) 5xx (Erro no seerver) <br> . <br> (400 (Erro do cliente) 404 (Servidor nao encontrado) 500 (Erro no servidor) <br> . <br> Use / para acessar a pagina inicial');
    }
    else {
    const filePath = path.join(__dirname, 'index.html');

    fs.readFile(filePath, (err, content) => {
        if (err){
            res.writeHead(500, {'Content-Type': 'text/html'})
            res.end('Erro interno do servidor');
        } else {
            res.writeHead(404, {'Content-Type': 'text/html'});
            res.end(content);
        }
    });

}
});
// Especificando a porta
const port = 3000;
server.listen(port, () => {
console.log(`Servidor rodando em http://localhost:${port}/`);
});