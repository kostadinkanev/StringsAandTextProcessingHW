using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

class Unicode
{
    static void Main()
    {
        string input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {
            char help = input[i];
            int he = help + 0;
            string myHex = he.ToString("X");
            Console.Write("\\00{0}", myHex);
        }


    }


    
}

