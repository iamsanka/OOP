using System;
using System.Collections.Generic;
using System.Linq;

class WorkingHourEntry
{
    public string Initials { get; set; }
    public DateTime Date { get; set; }
    public int ProjectId { get; set; }
    public double HoursWorked { get; set; }
}

class Employee
{
    public string Initials { get; set; }
    public List<WorkingHourEntry> WorkingHours { get; set; } = new List<WorkingHourEntry>();
}

class WorkingHourTracker
{
    private List<Employee> employees = new List<Employee>();

    public void AddWorkingHour(string initials, DateTime date, int projectId, double hoursWorked)
    {
        Employee employee = employees.FirstOrDefault(e => e.Initials == initials);

        if (employee == null)
        {
            employee = new Employee { Initials = initials };
            employees.Add(employee);
        }

        employee.WorkingHours.Add(new WorkingHourEntry
        {
            Initials = initials,
            Date = date,
            ProjectId = projectId,
            HoursWorked = hoursWorked
        });
    }

    public void ShowHoursByFellows()
    {
        Console.WriteLine("Hours worked by fellows:");
        foreach (var employee in employees)
        {
            double totalHours = employee.WorkingHours.Sum(entry => entry.HoursWorked);
            Console.WriteLine($"{employee.Initials}: {totalHours} hours");
        }
    }

    public void ShowHoursByWeeks()
    {
        Console.WriteLine("Hours worked by weeks:");
        var groupedByWeek = employees
            .SelectMany(e => e.WorkingHours)
            .GroupBy(entry => GetWeekOfYearISO8601(entry.Date));

        foreach (var weekGroup in groupedByWeek)
        {
            double totalHours = weekGroup.Sum(entry => entry.HoursWorked);
            Console.WriteLine($"Week {weekGroup.Key}: {totalHours} hours");
        }
    }

    public void ShowHoursByProjects()
    {
        Console.WriteLine("Hours worked by projects:");
        var groupedByProject = employees
            .SelectMany(e => e.WorkingHours)
            .GroupBy(entry => entry.ProjectId);

        foreach (var projectGroup in groupedByProject)
        {
            double totalHours = projectGroup.Sum(entry => entry.HoursWorked);
            Console.WriteLine($"Project {projectGroup.Key}: {totalHours} hours");
        }
    }

    // Helper method to get ISO 8601 week number
    private int GetWeekOfYearISO8601(DateTime date)
    {
        return System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
            date,
            System.Globalization.CalendarWeekRule.FirstFourDayWeek,
            DayOfWeek.Monday
        );
    }
}

class Program
{
    static void Main(string[] args)
    {
        WorkingHourTracker tracker = new WorkingHourTracker();

        // Add sample working hours
        tracker.AddWorkingHour("EMP1", DateTime.Now.AddDays(-1), 1, 4.5);
        tracker.AddWorkingHour("EMP2", DateTime.Now.AddDays(-2), 2, 3.0);
        tracker.AddWorkingHour("EMP1", DateTime.Now.AddDays(-3), 1, 5.0);
        tracker.AddWorkingHour("EMP2", DateTime.Now.AddDays(-4), 2, 6.5);
        tracker.AddWorkingHour("EMP3", DateTime.Now.AddDays(-2), 3, 2.5);

        tracker.ShowHoursByFellows();
        tracker.ShowHoursByWeeks();
        tracker.ShowHoursByProjects();
    }
}
