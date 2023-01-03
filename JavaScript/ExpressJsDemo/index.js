const express = require('express');
const cors = require('cors');

const app = express();
const port = 3300;

app.use(cors({
    // origin: 'http://127.0.0.1:5500'
    origin: 'http://localhost:3000'
}));

app.get('/', (req, res) => {
    res.type("json");
    res.setHeader("X-My-Own-Header", "Testing123");
    res.send('{ "myproperty": "abcd" }');
});

app.get('/another', (req, res) => {

    const headerName = "MySuperSecret";
    console.log(req.headers);
    let secretValue = req.header(headerName);
    res.type("json");

    if (secretValue == "abcd1234") {
        console.log("Header OK.");
        res.send('{ "anotherProperty": 1234 }');
    }
    else {
        console.log("Header invalid.");
        res.send('{ "anotherProperty": "invalid header value" }');
    }
});

app.listen(port, () => {
    console.log(`Example app listening on http://localhost:${port}/`);
});
