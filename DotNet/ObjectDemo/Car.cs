class Car
{
    // properties
    public string color;
    int speed;
    bool engineRunning;

    // methods
    public void StartEngine()
    {
        engineRunning = true;
    }

    public void StopEngine()
    {
        engineRunning = false;
    }

    public void Accelerate()
    {
        speed += 10;
    }

    public void Decelerate()
    {
        speed -= 10;
    }
}
