using System;

class Elevator
{
    private int currentFloor;

    public int CurrentFloor
    {
        get { return currentFloor; }
    }

    public Elevator()
    {
        currentFloor = 1; // Initialize the elevator on the first floor
    }

    public bool GoTo(int floor, out string message)
    {
        if (floor < 1)
        {
            message = "Floor is too small!";
            return false;
        }
        else if (floor > 5)
        {
            message = "Floor is too big!";
            return false;
        }

        currentFloor = floor;
        message = $"Elevator is now on floor: {currentFloor}";
        return true;
    }
}

class Program
{
    static void Main()
    {
        Elevator elevator = new Elevator();
        Console.WriteLine($"Elevator is now on floor: {elevator.CurrentFloor}");

        while (true)
        {
            Console.Write("Give a new floor number (1-5) > ");
            if (int.TryParse(Console.ReadLine(), out int desiredFloor))
            {
                string message;
                if (elevator.GoTo(desiredFloor, out message))
                {
                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine(message);
                    Console.WriteLine($"Elevator is still on floor: {elevator.CurrentFloor}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
            }
        }
    }
}
