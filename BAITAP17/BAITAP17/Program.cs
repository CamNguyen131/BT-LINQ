using System;
using System.Collections.Generic;
using System.Linq;

class Bai17
{
    class Student
    {
        public int Id;
        public string Name;
        public double Score;
    }

    static void Main()
    {
        Console.WriteLine("Nguyễn Thị Cẩm Nguyên - 23115053122328 - 225LTC#01");

        List<Student> students = new List<Student>()
        {
            new Student{Id=1,Name="An",Score=8},
            new Student{Id=2,Name="Binh",Score=6},
            new Student{Id=3,Name="Chi",Score=9}
        };

        double avg = students.Average(s => s.Score);

        Console.WriteLine("Diem TB: " + avg);

        Console.ReadKey();
    }
}
