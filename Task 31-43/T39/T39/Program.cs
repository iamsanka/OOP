using System;
using System.Threading;

class Timer
{
    private int timeInSeconds;
    private string notificationMessage;

    public Timer(int timeInSeconds, string notificationMessage = "Wake wake, the little bird")
    {
        this.timeInSeconds = timeInSeconds;
        this.notificationMessage = notificationMessage;
    }

    public void Start()
    {
        Console.WriteLine($"Timer set for {TimeSpan.FromSeconds(timeInSeconds)} with notification: {notificationMessage}");

        // Convert the time to milliseconds
        int timeInMilliseconds = timeInSeconds * 1000;

        // Create a timer and wait for the specified time
        System.Threading.Timer timer = new System.Threading.Timer(OnTimerElapsed, null, timeInMilliseconds, Timeout.Infinite);

        // Allow the user to exit the application
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    private void OnTimerElapsed(object state)
    {
        Console.WriteLine($"Timer elapsed! Notification: {notificationMessage}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Timer Application");

        // Prompt the user to enter the alarm time
        Console.Write("Enter the alarm time (in seconds or minutes): ");
        string input = Console.ReadLine();

        int time;
        if (int.TryParse(input, out time))
        {
            if (time >= 1 && time <= 60)
            {
                // Default notification message
                string defaultNotification = "Wake wake, the little bird";

                Timer timer = new Timer(time, defaultNotification);
                timer.Start();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a time between 1 second and 60 minutes.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
