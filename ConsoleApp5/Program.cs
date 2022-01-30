using System;
using System.Linq;

class Program
{

    public static void Main()
    {
        int a1;
       
        a1 = new int[2, 2]
        {
           { 3, -14 }, { 11, 7 }
        }

        .Cast<int>().Aggregate(1, (y, x) => 0 < x && x < 10 ? y * x : y);
        Console.WriteLine(a1);
    }
    
}