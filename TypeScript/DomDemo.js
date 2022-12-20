function addTable() {
    // sample data
    var persons = [
        {
            name: "John Doe",
            age: 35
        },
        {
            name: "Jane Doe",
            age: 33
        }
    ];
    // create HTML table from the persons
    var tableHtml = "<table class='table table-striped w-25'>" +
        "<thead><tr><th>Number</th>" +
        "<th>Name</th><th>Age</th></tr></thead><tbody>";
    for (var index = 0; index < persons.length; index++) {
        var person = persons[index];
        var tableRow = "<tr><td>".concat(index + 1, "</td>") +
            "<td>".concat(person.name, "</td>") +
            "<td>".concat(person.age, "</td></tr>");
        tableHtml += tableRow;
    }
    tableHtml += "</tbody></table>";
    // show the table in the user interface
    var results = document.getElementById("myDivArea");
    if (results) {
        results.innerHTML = tableHtml;
    }
}
console.log("Starting the DOM demo in TypeScript!");
