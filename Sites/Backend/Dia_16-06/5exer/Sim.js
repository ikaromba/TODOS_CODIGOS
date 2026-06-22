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
        res.end('Bem vindo a pagina inicial <br> Use /login para acessar a pagina de login <br> Use /dashboard para acessar o dashboard <br> Use /admin para acessar a area de admin  <br> Use /Erros para acessar a pagina de erros e status');

    }
    else if(req.url === '/login'){
        const filePath = path.join(__dirname, 'indexlogin.html');
        fs.readFile(filePath, (err, content) => {
            if (err){
                res.writeHead(500, {'Content-Type': 'text/html'})
                res.end('Erro interno do servidor');
            } else {
                res.writeHead(200, {'Content-Type': 'text/html'});
                res.end('Login realizado com sucesso!');
            }
        });
    }
    else if(req.url === '/dashboard') {
        const filePath = path.join(__dirname, 'indexdashboard.html');
        fs.readFile(filePath, (err, content) => {
            if (err){
                res.writeHead(500, {'Content-Type': 'text/html'})
                res.end('Erro interno do servidor');
            } else {
                res.writeHead(401, {'Content-Type': 'text/html'});
                res.end('Acesso negado. Faça login primeiro');
            }
        });
    }
    else if(req.url === '/admin') {
        const filePath = path.join(__dirname, 'indexadmin.html');
        fs.readFile(filePath, (err, content) => {
            if (err){
                res.writeHead(500, {'Content-Type': 'text/html'})
                res.end('Erro interno do servidor');
            } else {
                res.writeHead(403, {'Content-Type': 'text/html'});
                res.end('Você não tem permissão para acessar esta área');
            }
        });
    }
    else if(req.url === '/birb') {
        res.writeHead(200, {'Content-Type': 'text/html; charset=utf-8'});
        res.end('Birb Page (°v°√7 (BETA) ');
    }
    else if(req.url === '/Erros'){
        res.writeHead(200, {'Content-Type': 'text/html'});
        res.end('Status e Erros (BETA) <br> . <br> 1xx(informativo) 2xx(sucesso) 3xx(redirecionamento) 4xx (erro do cliente) 5xx (Erro no seerver) <br> . <br> 400 (Erro do cliente) <br> 404 (Servidor nao encontrado) <br> 500 (Erro no servidor) <br> 403 (O usuario nao tem o nivel de acesso necessario) <br> 401 (Erro quando o servidor nao reconhece quem voce e). <br> . <br> Use / para acessar a pagina inicial');
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