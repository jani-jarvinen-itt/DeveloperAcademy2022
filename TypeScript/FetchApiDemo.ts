interface UserDetails {
    id: number;
    name: string;
    username: string;
    email: string;
    // ...
}

function fetchUsers() {

    fetch('https://jsonplaceholder.typicode.com/users')
        .then(response => response.json())
        .then((users: UserDetails[]) => {
            console.log(users);

            let userNames: string = "";
            for (let index: number = 0; index < users.length; index++) {
                const user: UserDetails = users[index];
                console.log(user.name);

                userNames += user.name + "\r\n";
            }

            // show the user names in the user interface
            const results = document.getElementById("resultsArea");
            if (results) {
                results.innerText = userNames;
            }
        });
}

console.log("Starting the Fetch API demo!");
