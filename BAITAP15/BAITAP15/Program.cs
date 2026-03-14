using System;
using System.Collections.Generic;
using System.Linq;

class Bai15
{
    static void Main()
    {
        Console.WriteLine("Nguyễn Thị Cẩm Nguyên - 23115053122328 - 225LTC#01");

        List<int> numbers = new List<int>{1,2,2,3,3,4,5};

        var result = numbers.Distinct();

        foreach(var n in result)
        {
            Console.Write(n + " ");
        }

        Console.ReadKey();
    }
}
