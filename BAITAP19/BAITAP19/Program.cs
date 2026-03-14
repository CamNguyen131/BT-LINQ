using System;
using System.Collections.Generic;
using System.Linq;

class Bai19
{
    static void Main()
    {
        Console.WriteLine("Nguyễn Thị Cẩm Nguyên - 23115053122328 - 225LTC#01");

        List<int> numbers = new List<int>{1,2,2,3,3,3,4};

        var most = numbers
                    .GroupBy(x => x)
                    .OrderByDescending(g => g.Count())
                    .First();

        Console.WriteLine("So xuat hien nhieu nhat: " + most.Key);

        Console.ReadKey();
    }
}
