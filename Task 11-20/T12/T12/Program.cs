using System;

class Tank
{
    private string _name;
    private string _type;
    private int _crewNumber;
    private float _speed;
    private readonly float _speedMax = 100;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Type
    {
        get { return _type; }
        set { _type = value; }
    }

    public int CrewNumber
    {
        get { return _crewNumber; }
        set
        {
            if (value >= 2 && value <= 6)
                _crewNumber = value;
        }
    }

    public float Speed
    {
        get { return _speed; }
    }

    public float SpeedMax
    {
        get { return _speedMax; }
    }

    public void AccelerateTo(float speed)
    {
        if (speed >= 0 && speed <= _speedMax)
        {
            _speed = speed;
        }
    }

    public void SlowTo(float speed)
    {
        if (speed >= 0 && speed <= _speedMax)
        {
            _speed = speed;
        }
    }
}

class TestTank
{
    static void Main()
    {
        Tank tank = new Tank();
        tank.Name = "Abrams";
        tank.Type = "Main Battle Tank";
        tank.CrewNumber = 4;

        Console.WriteLine($"Tank Name: {tank.Name}");
        Console.WriteLine($"Tank Type: {tank.Type}");
        Console.WriteLine($"Crew Number: {tank.CrewNumber}");
        Console.WriteLine($"Current Speed: {tank.Speed}");

        tank.AccelerateTo(50);
        Console.WriteLine($"Accelerated to 50. Current Speed: {tank.Speed}");

        tank.SlowTo(75);
        Console.WriteLine($"Slowed down to 75. Current Speed: {tank.Speed}");

        tank.SlowTo(120); // Speed should not change as it's out of range
        Console.WriteLine($"Attempt to slow down to 120. Current Speed: {tank.Speed}");
    }
}
