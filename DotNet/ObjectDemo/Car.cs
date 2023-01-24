class Car
{
    // properties
    string color;
    int speed;
    bool engineRunning;

    // methods
    void StartEngine()
    {
        engineRunning = true;
    }

    void StopEngine()
    {
        engineRunning = false;
    }

    void Accelerate()
    {
        speed += 10;
    }

    void Decelerate()
    {
        speed -= 10;
    }
}
