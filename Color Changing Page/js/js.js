/* document.getElementById("blueButton").addEventListener("click", function() {
    let blueColor = "blue";
    document.body.style.backgroundColor = blueColor;
});

document.getElementById("whiteButton").addEventListener("click", function() {
    let whiteColor = "white";
    document.body.style.backgroundColor = whiteColor;
});
 */
let rainbow; 

function Blue() {
    stopRainbowEffect();
    document.body.style.backgroundColor = "blue";
}

function White() {
    stopRainbowEffect();
    document.body.style.backgroundColor = "white";
}


function RainbowEffect() {
    stopRainbowEffect();

    let colors = ["red", "orange", "yellow", "green", "blue", "indigo", "violet"];
    let index = 0;

    rainbow = setInterval(() => {
        document.body.style.backgroundColor = colors[index];
        index = (index + 1) % colors.length; 
    }, 500); 
}

function stopRainbowEffect() {
    clearInterval(rainbow);
}

document.getElementById("blueButton").addEventListener("click", Blue);
document.getElementById("whiteButton").addEventListener("click", White);
document.getElementById("rainbowButton").addEventListener("click", RainbowEffect);
