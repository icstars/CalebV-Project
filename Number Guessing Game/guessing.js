const targetNum = Math.floor(Math.random() * 100) + 1;
let attempts = 0;

function checkGuess() {
    const userGuess = parseInt(document.getElementById("userGuess").value);
    attempts++
    if (userGuess == targetNum) {
        document.getElementById("message").innerHTML = 'Correct! The number is' + (targetNum) + 'and you guessed in' + $(attempts);
    }
    else if (userGuess > targetNum) {
        document.getElementById("message").innerHTML = 'Reaching too high for that number.';
    }
    else {
        document.getElementById("message").innerHTML = 'Not shooting high enough. Aim Higher';
    }
}