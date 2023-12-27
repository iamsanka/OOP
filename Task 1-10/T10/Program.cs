using System;
using System.Collections.Generic;

public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Major { get; set; }

    public Student(string firstName, string lastName, int age, string major)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Major = major;
    }

    public override string ToString()
    {
        return $"Name: {FirstName} {LastName}, Age: {Age}, Major: {Major}";
    }
}

class Program
{
    static void Main()
    {
        // Create a list to store students
        List<Student> students = new List<Student>();

        // Create and add five student objects to the list
        students.Add(new Student("John", "Doe", 20, "Computer Science"));
        students.Add(new Student("Alice", "Smith", 22, "Mathematics"));
        students.Add(new Student("Bob", "Johnson", 21, "Physics"));
        students.Add(new Student("Emily", "Davis", 19, "Biology"));
        students.Add(new Student("Charlie", "Brown", 23, "History"));

        // Iterate through the list and print student data
        Console.WriteLine("Student Information:");
        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }
    }
}
