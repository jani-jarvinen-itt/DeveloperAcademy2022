class Car
{
    // properties
    public string Color { get; set; }
    public int TopSpeed { get; set; }
    public int Speed { get; private set; }
    private bool EngineRunning { get; set; }

    // methods
    public void StartEngine()
    {
        EngineRunning = true;
    }

    public void StopEngine()
    {
        EngineRunning = false;
    }

    public void Accelerate()
    {
        // if (engineRunning)
        // {
        //     speed += 10;
        // }

        if (!EngineRunning)
        {
            throw new Exception("Cannot accelerate without the engine running.");
        }
        Speed += 10;

        if (Speed > TopSpeed) 
        {
            Speed = TopSpeed;
        }
    }

    public void Decelerate()
    {
        Speed -= 10;
        if (Speed < 0)
        {
            Speed = 0;
        }
    }
}
