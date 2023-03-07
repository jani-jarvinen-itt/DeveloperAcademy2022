const express = require('express');
const fs = require('fs');
const readline = require('readline');

// prepare Express.js and file reading
const app = express();
const port = 3000;
const file = readline.createInterface({
    input: fs.createReadStream('Customers.csv'),
    output: process.stdout,
    terminal: false
});

// define HTTP GET handler for customer data
app.get('/api/customers', (req, res) => {
    /*
    const customerData = [{
        companyName: "Demo Oy",
        contactName: "John Doe",
        country: "Finland"
    }, {
        companyName: "Customer Inc.",
        contactName: "Jane Doe",
        country: "Sweden"
    }];
    */

    const customerData = [];
    file.on('line', (line) => {
        // TODO: add CSV line parsing
        customerData.push(line);
    });

    // NOTE: this handler won't work because of timing issues
    file.on('close', () => {
        res.type("json");
        res.send(JSON.stringify(customerData));
    });
});

app.listen(port, () => {
  console.log(`Express.js Web API application listening on http://localhost:${port}/.`);
});