function fetchUsers() {

    fetch('https://jsonplaceholder.typicode.com/users')
        .then(response => response.json())
        .then(json => console.log(json))
}

console.log("Starting the Fetch API demo!");
