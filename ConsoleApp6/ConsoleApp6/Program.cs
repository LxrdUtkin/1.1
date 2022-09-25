using System;

class Problem9
{
    static void Main()
    {
        double a, b, h, area;
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        h = int.Parse(Console.ReadLine());
        area = ((a + b) / 2) * h;
        Console.WriteLine(area);
    }
}
