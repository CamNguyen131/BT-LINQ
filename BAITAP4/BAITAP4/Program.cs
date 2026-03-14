using System;
using System.Collections.Generic;
using System.Linq;

class Bai4
{
    static void Main()
    {
        Console.WriteLine("Nguyễn Thị Cẩm Nguyên - 23115053122328 - 225LTC#01");

        List<int> numbers = new List<int>{8,3,6,1,5};

        var result = numbers.OrderByDescending(n => n);

        foreach(var n in result)
            Console.Write(n + " ");

        Console.ReadKey();
    }
}
