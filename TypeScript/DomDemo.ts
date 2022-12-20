interface Person {
    name: string;
    age: number;
}

function addTable(): void {

    // sample data
    const persons: Person[] = [
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
    let tableHtml: string = "<table><thead><tr><th>Number</th>" +
        "<th>Name</th><th>Age</th></tr></thead><tbody>";

    for (let index: number = 0; index < persons.length; index++) {
        const person: Person = persons[index];

        const tableRow: string = `<tr><td>${index + 1}</td>` +
            `<td>${person.name}</td>` +
            `<td>${person.age}</td></tr>`;
        tableHtml += tableRow;
    }

    tableHtml += "</tbody></table>";

    // show the table in the user interface
    const results = document.getElementById("myDivArea");
    if (results) {
        results.innerHTML = tableHtml;
    }
}

console.log("Starting the DOM demo in TypeScript!");
