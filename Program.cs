using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        int length = inputString.Length;
        int count = 0;

        for (int i = 0; i < length; i += 2)
        {
            char currentChar = inputString[i];

            if (IsConsonant(currentChar))
            //if(!"aeiouAEIOU".Contains(currentChar))   This will also count integers as a consonant.
            {
                count++;
            }
        }

        Console.WriteLine("Number of consonants at even indices: " + count);
        Console.ReadKey();
    }

    static bool IsConsonant(char c)
    {
        return char.IsLetter(c) && !"aeiouAEIOU".Contains(c);
    }
}
