using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SID { get; set; }
    public string Group { get; set; }

    public Student(string firstName, string lastName, string group)
    {
        FirstName = firstName;
        LastName = lastName;
        Group = group;
        GenerateSID();
    }

    private static Dictionary<string, int> sidCount = new Dictionary<string, int>();

    private void GenerateSID()
    {
        string sidPrefix = $"{FirstName[0]}{LastName[0]}".ToUpper();
        if (!sidCount.ContainsKey(sidPrefix))
        {
            sidCount[sidPrefix] = 1;
        }
        else
        {
            sidCount[sidPrefix]++;
        }

        int runningNumber = sidCount[sidPrefix];
        SID = $"{sidPrefix}{runningNumber:D3}";
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} {SID} {Group}";
    }
}

class MiniPeppi
{
    private List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        if (!students.Any(s => s.SID == student.SID))
        {
            students.Add(student);
            Console.WriteLine($"{student.FirstName} {student.LastName} added successfully. There are now {students.Count} students in MiniPeppi.");
        }
        else
        {
            Console.WriteLine("A student with the same SID already exists in MiniPeppi.");
        }
    }

    public void DisplayAllStudents()
    {
        Console.WriteLine("The all students in MiniPeppi:");
        foreach (var student in students)
        {
            Console.WriteLine(student.ToString());
        }
    }

    public void DisplayStudentsInAlphabeticalOrder()
    {
        Console.WriteLine("The all students in alphabetical order in MiniPeppi:");
        var sortedStudents = students.OrderBy(s => s.FirstName).ThenBy(s => s.LastName);
        foreach (var student in sortedStudents)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MiniPeppi miniPeppi = new MiniPeppi();

        // Add the test students
        miniPeppi.AddStudent(new Student("Hanna", "Husso", "TTV19S1"));
        miniPeppi.AddStudent(new Student("Kirsi", "Kernell", "TTV19S2"));
        miniPeppi.AddStudent(new Student("Masa", "Niemi", "TTV19S3"));
        miniPeppi.AddStudent(new Student("Teppo", "Testaaja", "TTV19SM"));
        miniPeppi.AddStudent(new Student("Allan", "Aalto", "TTV19SMM"));

        miniPeppi.DisplayAllStudents();
        Console.WriteLine();

        miniPeppi.DisplayStudentsInAlphabeticalOrder();
        Console.WriteLine();

        // Ask the user for a new student's information
        Console.WriteLine("Please give data of a new Student:");
        Console.Write("SID: ");
        string sid = Console.ReadLine();
        Console.Write("First name: ");
        string firstName = Console.ReadLine();
        Console.Write("Surname: ");
        string lastName = Console.ReadLine();
        Console.Write("Group: ");
        string group = Console.ReadLine();

        Student newStudent = new Student(firstName, lastName, group);
        newStudent.SID = sid; // Use the provided SID

        miniPeppi.AddStudent(newStudent);
        miniPeppi.DisplayAllStudents();
        Console.WriteLine();
    }
}
