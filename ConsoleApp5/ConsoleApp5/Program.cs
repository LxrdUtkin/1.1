using System;

class Problem8
{
    static void Main()
    {
        double a, b, c, average;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        average = (a + b + c) / 3;
        Console.WriteLine(average);
    }
}