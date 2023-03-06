const express = require('express');
const app = express();
const port = 3000;

app.get('/api/customers', (req, res) => {
    res.type("json");
    const customerData = [{
        companyName: "Demo Oy",
        contactName: "John Doe",
        country: "Finland"
    }, {
        companyName: "Customer Inc.",
        contactName: "Jane Doe",
        country: "Sweden"
    }];
    res.send(JSON.stringify(customerData));
});

app.listen(port, () => {
  console.log(`Express.js Web API application listening on http://localhost:${port}/.`);
});