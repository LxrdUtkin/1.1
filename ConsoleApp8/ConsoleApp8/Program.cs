using System;

class Problem11
{
    static void Main()
    {
        int n, number;
        double nDigit;
        number = int.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());
        nDigit = (number / Math.Pow(10, n - 1)) % 10;
        if (nDigit < 1)
        {
            Console.WriteLine("-");
        }
        else
        {
            Console.WriteLine((int)nDigit);
        }



    }
}