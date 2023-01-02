function callApiWithFetch() {

    console.log("Starting to call the Express.js API.");
    fetch('http://localhost:3000/')
        .then(response => response.json())
        .then(data => {
            console.log(data);
            document.getElementById("resultsArea").innerText = data.myproperty;
        });
}

console.log("Starting the Express.js API demo!");
