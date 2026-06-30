// Importando o módulo http
const http = require('http');
const fs = require('fs');
const path = require('path');
const port = 3000;

// Criando o servidor único e correto
const server = http.createServer((req, res) => {
    // Tratando os parâmetros e caminhos da URL
    const urlParams = new URL(req.url, `http://localhost:${port}`);
    const endpoint = urlParams.pathname;

    // 1. Rota básica/inicial
    if (endpoint === '/') {
        res.writeHead(200, { 'Content-Type': 'text/plain; charset=utf-8' });
        res.end('TESTE!');
    }

    // 2. Rota hello
    else if (endpoint === '/hello') {
        const nome = urlParams.searchParams.get('nome')
        const idadeTexto= urlParams.searchParams.get('idade')
        res.writeHead(200, { 'Content-Type': 'text/plain; charset=utf-8' });

        if (nome && idadeTexto){
            // Convertendo a idade de texto para número inteiro
            const idade = parseInt(idadeTexto, 10);
            // Criamos a variável para guardar a resposta do status
            let statusIdade = "";

            if(idade <= 17){
             statusIdade ="MEnor de idade";
            }else{
            statusIdade="MAior de idade";
            }

            res.end(`Bem vindo, ${nome}. Voce é ${statusIdade} e tem ${idade} anos.`);//retorna o nome e se vc é menor de idade ou n
            }else{
            res.end('insira um nome na e idade na URL. Exemplo: /hello?nome=SeuNome&idade=Suaidade');
        }
    }

    // 3. Rota para a pag birb (°v°√7)
    else if (endpoint === '/birb') {
        res.writeHead(200, { 'Content-Type': 'text/html; charset=utf-8' });
        res.end('Birb Page (°v°√7 (BETA) ');
    }

    // 4. Rota para a pag de erros
    else if (endpoint === '/Erros') {
        res.writeHead(200, { 'Content-Type': 'text/html; charset=utf-8' });
        res.end('Status e Erros (BETA) <br> . <br> 1xx(informativo) 2xx(sucesso) 3xx(redirecionamento) 4xx (erro do cliente) 5xx (Erro no seerver) <br> . <br> (400 (Erro do cliente) 404 (Servidor nao encontrado) 500 (Erro no servidor) <br> . <br> Use / para acessar a pagina inicial');
    }
    
    // 5. Página de erro 404
    else {
        const filePath = path.join(__dirname, 'index404.html');
        fs.readFile(filePath, (err, content) => {
            if (err) {
                res.writeHead(500, { 'Content-Type': 'text/html; charset=utf-8' });
                res.end('Erro interno do servidor');
            } else {
                res.writeHead(404, { 'Content-Type': 'text/html; charset=utf-8' });
                res.end(content);
            }
        });
    }
});

// Especificando a porta e escutando as requisições
server.listen(port, () => {
    console.log(`Servidor rodando em http://localhost:${port}/`);
});