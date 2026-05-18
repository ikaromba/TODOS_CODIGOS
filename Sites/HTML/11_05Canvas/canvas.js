var canvas = document.getElementById("myCanvas");
canvas.width = window.innerWidth;
canvas.height = window.innerHeight;

var c = canvas.getContext('2d');

c.clearRect(0, 0, canvas.width, canvas.height);

let x1 = Math.random() * 800;  
let y1 = Math.random() * 600;
c.fillStyle = 'rgba(16, 207, 16, 0.5)';
c.fillRect(x1, y1, 100, 300);


let x2 = Math.random() * 800;
let y2 = Math.random() * 600;
c.fillStyle = 'rgba(16, 147, 207, 0.5)';
c.fillRect(x2, y2, 300, 50);

let x3 = Math.random() * 800;
let y3 = Math.random() * 600;
c.fillStyle = 'rgba(207, 16, 16, 0.5)';
c.fillRect(x3, y3, 150, 400);

let x4 = Math.random() * 800;
let y4 = Math.random() * 600;
c.fillStyle = 'rgba(204, 207, 16, 0.5)';
c.fillRect(x4, y4, 400, 150);

var cubos = [];

class Cubo {
    constructor(x, y) {
        this.x = x;
        this.y = y;
        this.vx = (Math.random() - 0.5) * 1; // Velocidade X insana
        this.vy = (Math.random() - 0.5) * 1; // Velocidade Y insana
        this.tamanho = Math.random() * 30 + 10;
        this.cor = `hsl(${Math.random()*360}, 100%, 50%)`;
    }
    
    // Atualiza posição e bate nas bordas
    update() {
        this.x += this.vx;
        this.y += this.vy;
        
        // BATE NAS BORDAS e inverte direção
        if (this.x < 0 || this.x > canvas.width - this.tamanho) {
            this.vx *= -1;
        }
        if (this.y < 0 || this.y > canvas.height - this.tamanho) {
            this.vy *= -1;
        }
    }
    
    // Desenha o cubo
    desenhar() {
        c.fillStyle = this.cor;
        c.fillRect(this.x, this.y, this.tamanho, this.tamanho);
    }
}

// Função principal do jogo (60 FPS)
function animar() {
    // Limpa canvas
    c.clearRect(0, 0, canvas.width, canvas.height);
    
    // Atualiza e desenha todos os cubos
    for(let cubo of cubos) {
        cubo.update();
        cubo.desenhar();
    }
    
    requestAnimationFrame(animar);
}

// BOTÃO - EXPLODE 100 CUBOS!
document.getElementById('botaoCubos').addEventListener('click', function() {
    cubos = []; // Limpa cubos antigos
    
    // Cria 100 cubos em posições aleatórias
    for(let i = 0; i < 100; i++) {
        cubos.push(new Cubo(
            Math.random() * canvas.width,
            Math.random() * canvas.height
        ));
    }
});

// Inicia a animação
animar();

