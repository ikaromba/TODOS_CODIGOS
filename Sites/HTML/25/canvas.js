var canvas = document.getElementById("canvas");
canvas.width = 800;
canvas.height = 600;

var TC = {};

document.addEventListener("keydown", function(event) =>;{
    TC[event.key] = true;
    
});


var c = canvas.getContext("2d");

c.beginPath();
c.moveTo(50, 100);
c.lineTo(50, 300);
c.strokeStyle = "black";
c.stroke();

c.beginPath();
c.moveTo(700, 100);
c.lineTo(700, 300);
c.strokeStyle = "black";
c.stroke();


