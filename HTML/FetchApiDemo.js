function fetchUsers() {

    fetch('https://jsonplaceholder.typicode.com/users')
        .then(response => response.json())
        .then(users => {
            console.log(users);

            for (let index = 0; index < users.length; index++) {
                const user = users[index];
                console.log(user.name);
            }
        });
}

console.log("Starting the Fetch API demo!");
