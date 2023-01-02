const express = require('express');
const app = express();
const port = 3000;

app.get('/', (req, res) => {
    res.type("json");
    res.send('{ "myproperty": "abcd" }');
});

app.get('/another', (req, res) => {
    res.type("json");
    res.send('{ "anotherProperty": 1234 }');
});

app.listen(port, () => {
    console.log(`Example app listening on http://localhost:${port}/`);
});
