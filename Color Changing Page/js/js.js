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
        /* debugger; added for when I recorded a video showing one of the many ways to debug
        console.log("Colors list index value:", index); */ // Just for debugging to show which color is being called.
        document.body.style.backgroundColor = colors[index];
        index = (index + 1) % colors.length; 
    }, 500); 
}

function stopRainbowEffect() {
    clearInterval(rainbow);
}

document.getElementById("blue").addEventListener("click", Blue);
document.getElementById("white").addEventListener("click", White);
document.getElementById("rainbow").addEventListener("click", RainbowEffect);
