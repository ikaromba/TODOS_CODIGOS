var canvas = document.getElementById("canvas");
canvas.width = window.innerWidth;
canvas.height = window.innerHeight;

var ctx = canvas.getContext("2d");
var x =200;

c.fillStyle="rgba(0,255,0,0.5)";
c.fillRect(100, 100, 200, 200);

function animate(){
    requestAnimationFrame(animate);

    ctx.fillStyle = "#d22200";
    ctx.fillRect(200, 200, 200, 200);

}

animate();