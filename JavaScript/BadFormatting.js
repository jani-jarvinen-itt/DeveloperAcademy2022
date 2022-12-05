const number = parseInt(        prompt(
    'Enter a positive integer: '));
    
                if (number<
    0) {
        console.log(
        
        'Error! Factorial for negative number does not exist.');
    }
    
    else
                        if (
            number === 0) { console.log(`The factorial of ${number} is 1.`);}
    
    // if number is positive
    else {let
                                fact = 1;
        for (i = 1;i<=
    number; i++) {fact
                   *=
    i;}
        console.log(
                                `The factorial of ${number} is ${fact}.`);}
    
    function reverseString(str) {
    let newString = "";
                    for (let i = str.length - 1;
                    i >= 0; i--) {				newString
    += str[i];}
        return
        newString
        ;}
    
    const string = prompt(
                                'Enter a string: ');const result =
                reverseString(string);
    console.log(  result)
    ;
    