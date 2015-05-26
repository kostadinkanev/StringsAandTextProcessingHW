using System;
using System.Collections.Generic;

class Palindromes
{
    static void Main()
    {
        string[] input = Console.ReadLine()
            .Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

        List<string> result = new List<string>();

        for (int i = 0; i < input.Length; i++)
        {
            string help = input[i];
            if (input[i].Length == 1)
            {
                result.Add(help);
                break;
            }
            if (help.Length % 2 == 0)
            {
                string a = "";
                string b = "";
                for (int j = 0; j < input[i].Length / 2; j++)
                {
                    a =a+ help[j];
                }
                for (int j = input[i].Length -1 ; j >= input[i].Length/2; j--)
                {
                    b = b + help[j];
                }
                if (a==b)
                {
                    result.Add(help);
                }
            }
            else
            {
                string a = "";
                string b = "";
                for (int j = 0; j < input[i].Length / 2; j++)
                {
                    a = a + help[j];
                }
                for (int j = input[i].Length - 1; j > input[i].Length / 2; j--)
                {
                    b = b + help[j];
                }
                if (a == b)
                {
                    result.Add(help);
                }
            }
            
          
        }

        result.Sort();
        Console.WriteLine(string.Join(", ", result));


    }
}


