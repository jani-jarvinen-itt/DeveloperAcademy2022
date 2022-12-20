interface Person {
    name: string;
    age: number;
}

function addTable(): void {

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
}

console.log("Starting the DOM demo in TypeScript!");
