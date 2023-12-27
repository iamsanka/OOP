using System;

delegate string StringManipulationDelegate(string input);

class Program
{
    static string ConvertToUpper(string input)
    {
        return input.ToUpper();
    }

    static string ConvertToLower(string input)
    {
        return input.ToLower();
    }

    static string ConvertToTitle(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        return char.ToUpper(input[0]) + input.Substring(1).ToLower();
    }

    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    static void Main()
    {
        Console.WriteLine("Enter the string to process:");
        string inputString = Console.ReadLine();

        StringManipulationDelegate manipulator = null;

        while (true)
        {
            Console.WriteLine("\nChoose the treatment you want, you can give several treatments at once");
            Console.WriteLine("as one string, e.g. '123'");
            Console.WriteLine("1: to capital letters");
            Console.WriteLine("2: lowercase");
            Console.WriteLine("3: as a title");
            Console.WriteLine("4: as a palindrome");
            Console.WriteLine("0: termination");
            Console.Write("\nSelection: ");
            string choice = Console.ReadLine();

            if (choice.Contains("1"))
                manipulator += ConvertToUpper;
            if (choice.Contains("2"))
                manipulator += ConvertToLower;
            if (choice.Contains("3"))
                manipulator += ConvertToTitle;
            if (choice.Contains("4"))
                manipulator += ReverseString;

            if (choice == "0")
                break;

            if (manipulator != null)
            {
                string result = manipulator(inputString);
                Console.WriteLine($"Result: {result}");
                manipulator = null;
            }
            else
            {
                Console.WriteLine("No valid operation selected.");
            }
        }
    }
}
