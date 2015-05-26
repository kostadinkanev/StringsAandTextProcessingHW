using System;
using System.Security;

class Length
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input.Length >20)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.Write(input[i]);
            }
        }
        else
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);
            }
            for (int i = 0; i < 20-input.Length; i++)
            {
                Console.Write("*");
            }
        }
        Console.WriteLine();
    }
}

