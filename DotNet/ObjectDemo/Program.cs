Console.WriteLine("Hello, OOP!");

Car myCar = new();
myCar.color = "black";
myCar.topSpeed = 220;
myCar.StartEngine();
for (int i = 0; i < 25; i++)
{
    myCar.Accelerate();
}
System.Console.WriteLine(myCar.speed);

// myCar.StartEngine();






Car cousinsCar = new();
cousinsCar.color = "grey";
