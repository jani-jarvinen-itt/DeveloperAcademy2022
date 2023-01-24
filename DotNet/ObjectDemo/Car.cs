class Car
{
    // properties
    public string color;
    public int topSpeed;
    public int speed;
    private bool engineRunning;

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
        // if (engineRunning)
        // {
        //     speed += 10;
        // }

        if (!engineRunning)
        {
            throw new Exception("Cannot accelerate without the engine running.");
        }
        speed += 10;

        if (speed > topSpeed) 
        {
            speed = topSpeed;
        }
    }

    public void Decelerate()
    {
        speed -= 10;
        if (speed < 0)
        {
            speed = 0;
        }
    }
}
