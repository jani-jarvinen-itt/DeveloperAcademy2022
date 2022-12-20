function fetchUsers() {

    fetch('https://jsonplaceholder.typicode.com/users')
        .then(response => response.json())
        .then(users => {
            console.log(users);

            let userNames = "";
            for (let index = 0; index < users.length; index++) {
                const user = users[index];
                console.log(user.name);

                userNames += user.name + "\r\n";
            }

            // show the user names in the user interface
            document.getElementById("resultsArea").innerText = userNames;
        });
}

console.log("Starting the Fetch API demo!");
