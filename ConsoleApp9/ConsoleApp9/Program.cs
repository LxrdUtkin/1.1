﻿using System;

class Problem12
{
    static void Main()
    {
        int n;
        bool result;
        n = int.Parse(Console.ReadLine());
        if (n > 20 && n % 10 == 1)
        {
            result = true;
        }
        else
        {
            result = false;
        }
        Console.WriteLine(result);

    }
}