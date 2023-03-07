const express = require('express');
const fs = require('fs');
const readline = require('readline');

// prepare Express.js and file reading
const app = express();
const port = 3000;

function readFileAsync() {
    return new Promise((resolve, reject) => {
        // prepare for file access
        const file = readline.createInterface({
            input: fs.createReadStream('Customers.csv'),
            output: process.stdout,
            terminal: false
        });
        const customerData = [];

        // read file line by line and push each line into an array
        file.on('line', (line) => {
            const data = line.split(';');
            const customer = {
                companyName: data[0],
                contactName: data[1],
                country: data[2]
            };
            customerData.push(customer);
        });

        // return customer data from the promise
        file.on('close', () => {
            resolve(customerData);
        });
    });
}

// define HTTP GET handler for customer data
app.get('/api/customers', async (req, res) => {
    const customerData = await readFileAsync();
    res.type("json");
    res.send(JSON.stringify(customerData));
});

app.listen(port, () => {
    console.log(`Express.js Web API v2 application listening on http://localhost:${port}/.`);
});
