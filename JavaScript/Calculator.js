const readline = require('readline');
const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

rl.question('Please enter the first number: ', function (num1) {
  rl.question('Please enter the second number: ', function (num2) {
    let sum = parseInt(num1) + parseInt(num2);
    console.log(`The sum is: ${sum}.`);
    rl.close();
  });
});
