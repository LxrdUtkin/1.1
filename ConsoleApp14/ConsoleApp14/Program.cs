using System;

class Problem17
{
    static void Main()
    {
        int n, factorial;
        factorial = 1;
        n = int.Parse(Console.ReadLine());
        for (int i = 2; i <= n; i++)
        {
            factorial = factorial * i;
        }
        Console.WriteLine(factorial);
    }
}

