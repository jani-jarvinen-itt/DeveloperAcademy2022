function calculateSum() {
    console.log("Button clicked!");

    let number1 = document.getElementById("num1").value;
    let number2 = document.getElementById("num2").value;

    let sum = parseInt(number1) + parseInt(number2);
    alert("Sum on the numbers is: " + sum);
}

console.log("Starting JavaScript calculator demo.");
