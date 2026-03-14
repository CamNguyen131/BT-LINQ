using System;
using System.Collections.Generic;
using System.Linq;

class Bai1
{
    static void Main()
    {
        Console.WriteLine("Nguyễn Thị Cẩm Nguyên - 23115053122328 - 225LTC#01");

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

        var result = numbers.Where(n => n % 2 == 0);

        Console.WriteLine("Cac so chan:");
        foreach (var n in result)
        {
            Console.Write(n + " ");
        }
    }
}