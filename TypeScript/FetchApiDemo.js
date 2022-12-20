function fetchUsers() {
    fetch('https://jsonplaceholder.typicode.com/users')
        .then(function (response) { return response.json(); })
        .then(function (users) {
        console.log(users);
        var userNames = "";
        for (var index = 0; index < users.length; index++) {
            var user = users[index];
            console.log(user.name);
            userNames += user.name + "\r\n";
        }
        // show the user names in the user interface
        var results = document.getElementById("resultsArea");
        if (results) {
            results.innerText = userNames;
        }
    });
}
console.log("Starting the Fetch API demo!");
