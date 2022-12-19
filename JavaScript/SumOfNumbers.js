const fs = require('fs');
const readline = require('readline');

const file = readline.createInterface({
    input: fs.createReadStream('Numbers.txt'),
    output: process.stdout,
    terminal: false
});

let sum = 0;
file.on('line', (line) => {
    // console.log(line);
    sum += parseInt(line);
});

file.on('close', () => {
    console.log("Sum of numbers: " + sum);
});
