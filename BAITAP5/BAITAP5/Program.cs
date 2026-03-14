using System;
using System.Collections.Generic;
using System.Linq;

class Bai5
{
    static void Main()
    {
        Console.WriteLine("Nguyễn Thị Cẩm Nguyên - 23115053122328 - 225LTC#01");

        List<int> numbers = new List<int> { 1, 2, 3 };

        var result = numbers.Select(n => n * n);

        Console.WriteLine("Binh phuong:");
        foreach (var n in result)
        {
            Console.Write(n + " ");
        }
    }
}