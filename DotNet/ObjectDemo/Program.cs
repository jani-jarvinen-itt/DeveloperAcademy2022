Console.WriteLine("Hello, OOP!");

Car myCar = new();
myCar.Color = "black";
myCar.TopSpeed = 220;
// myCar.Speed = -1500;
Console.WriteLine(myCar.Speed);


SportsCar sport = new();
sport.RoofDown = true;
sport.StartEngine();
sport.Accelerate();
Console.WriteLine(sport.Speed);

/*
myCar.StartEngine();
for (int i = 0; i < 25; i++)
{
    myCar.Accelerate();
}
System.Console.WriteLine(myCar.speed);
*/

// myCar.StartEngine();

/*
Car cousinsCar = new();
cousinsCar.Color = "grey";
*/