function mySimpleFunction(anotherFunc) {
    console.log("1. Hello from MySimpleFunction!");
    anotherFunc();
}

/*
function secondFunction() {
    console.log("2. Hello from SecondFunction!");
}
*/
// mySimpleFunction(secondFunction);
// mySimpleFunction(function() { console.log("2. Hello from SecondFunction!") });

mySimpleFunction(() => console.log("2. Hello from SecondFunction!"));
