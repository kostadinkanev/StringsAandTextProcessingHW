using System;

class Count
{
    static void Main()
    {
        string input = Console.ReadLine().ToUpper();
        string word = Console.ReadLine().ToUpper();
        int count = 0;

        

        for (int i = 0; i < input.Length-word.Length+1; i++)
        {
            if (input[i] == word[0])
            {
                int k = i;
                int help = 0;
                for (int j = 0; j < word.Length; j++)
                {
                    if (input[k] == word[j])
                    {
                        help = help + 1;
                    }
                    k++;
                    if (help == word.Length)
                    {
                        count = count + 1;
                    }

                }
            }
        }
        Console.WriteLine(count);
    }
}

