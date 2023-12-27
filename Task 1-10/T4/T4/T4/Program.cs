using System;

class Program
{
    // Static method to check if a string is a palindrome
    static bool IsPalindrome(string str)
    {
        // Removing spaces and convert to lowercase for case-insensitive comparison
        str = str.Replace(" ", "").ToLower();
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false; // Not a palindrome
            }
            left++;
            right--;
        }
        return true; // It is a palindrome
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a sentence or word: ");
        string input = Console.ReadLine();

        // Check if the input is a palindrome
        bool isPalindrome = IsPalindrome(input);

        // Display the result
        if (isPalindrome)
        {
            Console.WriteLine($"'{input}' is a palindrome.");
        }
        else
        {
            Console.WriteLine($"'{input}' is not a palindrome.");
        }
    }
}
