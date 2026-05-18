var canvas = document.querySelector("canvas");
canvas.width = window.innerWidth;
canvas.height = window.innerHeight;

var c = canvas.getContext("2d");
var x =200;
var dx=4;

function animate(){
    requestAnimationFrame(animate);

    c.fillStyle = "#00d200";
    c.fillRect(x, 200, 200, 200);
    
    if((x + 200) > innerWidth){
        dx = -dx;
    }
    x = x+dx;
}

animate();
