using System;
using System.Collections.Generic;
using System.Linq;

class Bai2
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        var result = numbers.Where(n => n > 5);

        foreach (var n in result)
            Console.Write(n + " ");
    }
}