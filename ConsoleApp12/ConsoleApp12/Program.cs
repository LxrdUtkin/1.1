using System;

class Problem15
{
    static void Main()
    {
        int a, b, c;
        int product = 1;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        product = a * b * c;
        if (Math.Sign(product) == -1)
        {
            Console.WriteLine("Negative");
        }
        else
        {
            Console.WriteLine("Positive");
        }
        /*if (Math.Sign(a) == -1)
        {
            product++;
        }
        if (Math.Sign(b) == -1)
        {
            product++;
        }
        if (Math.Sign(c) == -1)
        {
            product++;
        }
        if (product == 1 || product == 3)
        {
            Console.WriteLine("Negative");
        }
        else if(product == 0 || product == 2)
        {
            Console.WriteLine("Positive");
        }*/
    }
}