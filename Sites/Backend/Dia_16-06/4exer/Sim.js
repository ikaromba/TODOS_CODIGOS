// Importando o módulo http
const http = require('http');
const fs = require('fs');
const path = require('path');

// Criando o servidor
const server = http.createServer((req, res) => {
    //<br> para quebrar linha
    //200 sucesso, 404 sevidor nao encontrado, 500 erro no servidor, 1xx informativo, 3xx redirecionamento, 4xx erro do cliente
    if(req.url === '/') {
        res.writeHead(200, {'Content-Type': 'text/html; charset=utf-8'});
        res.end('Bem vindo a pagina inicial <br>Use /seg para acessar o cardapio de segunda <br>Use /ter para acessar o cardapio de Terça <br>Use /qua para acessar o cardapio de Quarta <br>Use /qui para acessar o cardapio de Quinta <br>Use /sex para acessar o cardapio de Sexta');

    }
    else if(req.url === '/seg') {
        res.writeHead(200, {'Content-Type': 'text/html'});
        res.end('Cardapio de Segunda (BETA) <br> . <br> Prato 1 <br> Prato 2 <br> Prato 3');
    }
    else if(req.url === '/ter') {
        res.writeHead(200, {'Content-Type': 'text/html'});
        res.end('Cardapio de Terca (BETA) <br> . <br> Prato 1 <br> Prato 2 <br> Prato 3');
    }
    else if(req.url === '/qua') {
        res.writeHead(200, {'Content-Type': 'text/html'});
        res.end('Cardapio de Quarta (BETA) <br> . <br> Prato 1 <br> Prato 2 <br> Prato 3');
    }
    else if(req.url === '/qui') {
        res.writeHead(200, {'Content-Type': 'text/html'});
        res.end('Cardapio de Quinta (BETA) <br> . <br> Prato 1 <br> Prato 2 <br> Prato 3');
    }
    else if(req.url === '/sex') {
        res.writeHead(200, {'Content-Type': 'text/html'});
        res.end('Cardapio de Sexta (BETA) <br> . <br> Prato 1 <br> Prato 2 <br> Prato 3');
    }
    else if(req.url === '/birb') {
        res.writeHead(200, {'Content-Type': 'text/html; charset=utf-8'});
        res.end('Birb Page (°v°√7 (BETA) ');
    }
    else if(req.url === '/Erros'){
        res.writeHead(200, {'Content-Type': 'text/html'});
        res.end('Status e Erros (BETA) <br> . <br> 1xx(informativo) 2xx(sucesso) 3xx(redirecionamento) 4xx (erro do cliente) 5xx (Erro no seerver) <br> . <br> (400 (Erro do cliente) 404 (Servidor nao encontrado) 500 (Erro no servidor) <br> . <br> Use / para acessar a pagina inicial');
    }
    else {
    const filePath = path.join(__dirname, 'index404.html');

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