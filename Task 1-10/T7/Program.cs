using System;

class WashingMachine
{
    private bool isOn;
    private int waterTemperature;
    private string washCycle;
    private int remainingTime;
    private int maxCapacity;
    private int currentLoad;

    public WashingMachine()
    {
        isOn = false;
        waterTemperature = 0;
        washCycle = "";
        remainingTime = 0;
        maxCapacity = 10; // Default max capacity
        currentLoad = 0;
    }

    public WashingMachine(int maxCapacity)
    {
        isOn = false;
        waterTemperature = 0;
        washCycle = "";
        remainingTime = 0;
        this.maxCapacity = maxCapacity;
        currentLoad = 0;
    }

    public void TurnOn()
    {
        isOn = true;
    }

    public void TurnOff()
    {
        isOn = false;
    }

    public void SetWaterTemperature(int temp)
    {
        waterTemperature = temp;
    }

    public void SetWashCycle(string cycle)
    {
        washCycle = cycle;
    }

    public void StartWash(int load)
    {
        currentLoad = load;
        // Logic to start the wash cycle and calculate remaining time.
        remainingTime = 30; // Example: 30 minutes wash cycle.
    }

    public void PauseWash()
    {
        // Logic to pause the wash cycle.
    }

    public void ResumeWash()
    {
        // Logic to resume the wash cycle.
    }

    public void CancelWash()
    {
        // Logic to cancel the wash cycle.
        currentLoad = 0;
        remainingTime = 0;
    }

    public int GetRemainingTime()
    {
        return remainingTime;
    }

    public int GetCurrentLoad()
    {
        return currentLoad;
    }

    public bool IsOn()
    {
        return isOn;
    }

    public int GetWaterTemperature()
    {
        return waterTemperature;
    }

    public string GetWashCycle()
    {
        return washCycle;
    }
}

class Program
{
    static void Main(string[] args)
    {
        WashingMachine washingMachine = new WashingMachine(15); // Set max capacity to 15.

        // Simulate user interactions
        washingMachine.TurnOn();
        washingMachine.SetWaterTemperature(40);
        washingMachine.SetWashCycle("Normal");
        washingMachine.StartWash(10);

        // Display washing machine state
        Console.WriteLine($"Is On: {washingMachine.IsOn()}");
        Console.WriteLine($"Water Temperature: {washingMachine.GetWaterTemperature()}°C");
        Console.WriteLine($"Wash Cycle: {washingMachine.GetWashCycle()}");
        Console.WriteLine($"Current Load: {washingMachine.GetCurrentLoad()} kg");
        Console.WriteLine($"Remaining Time: {washingMachine.GetRemainingTime()} minutes");

        // Pause and resume wash
        washingMachine.PauseWash();
        Console.WriteLine("Wash paused.");

        // Display remaining time after pause
        Console.WriteLine($"Remaining Time: {washingMachine.GetRemainingTime()} minutes");

        washingMachine.ResumeWash();
        Console.WriteLine("Wash resumed.");

        // Cancel the wash
        washingMachine.CancelWash();
        Console.WriteLine("Wash canceled.");

        // Display washing machine state after cancel
        Console.WriteLine($"Current Load: {washingMachine.GetCurrentLoad()} kg");
        Console.WriteLine($"Remaining Time: {washingMachine.GetRemainingTime()} minutes");

        washingMachine.TurnOff();
        Console.WriteLine("Washing machine turned off.");
    }
}
