let posX = 0;
let posY = 0;

const speed = 10;


document.addEventListener('DOMContentLoaded', function() {
    const redBall = document.getElementById('redball');
    redBall.style.position = 'absolute';
    redBall.style.left = posX + 'px';
    redBall.style.top = posY + 'px';
    
    document.addEventListener('keydown', function(event) {
        if ([37, 38, 39, 40].indexOf(event.keyCode) > -1) {
            event.preventDefault();
        }
        
        switch(event.keyCode) {
            case 37:
                posX = Math.max(0, posX - speed);
                break;
            case 38:
                posY = Math.max(0, posY - speed);
                break;
            case 39:
                posX = Math.min(window.innerWidth - redBall.offsetWidth, posX + speed);
                break;
            case 40:
                posY = Math.min(window.innerHeight - redBall.offsetHeight, posY + speed);
                break;
        }
        redBall.style.left = posX + 'px';
        redBall.style.top = posY + 'px';
    });
});