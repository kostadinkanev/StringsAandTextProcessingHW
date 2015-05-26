using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

class Filter
{
    static void Main()
    {
        List<string> input = Console.ReadLine().Split(',').ToList();

        string text = Console.ReadLine();
        
        for (int i = 0; i < input.Count; i++)
        {
            string help = input[i];

            string stars = new string('*',help.Length);

            text = text.Replace(help.Trim(), stars);

        }
        Console.WriteLine(text);
    }
}

