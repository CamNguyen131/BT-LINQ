using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class SinhVien
    {
        public int Id;
        public string Name;
        public double Score;
        public int KhoaId;
    }

    class Khoa
    {
        public int Id;
        public string TenKhoa;
    }

    static void Main()
    {
        Console.WriteLine("Nguyễn Thị Cẩm Nguyên - 23115053122328 - 225LTC#01");

        Random rd = new Random();

        //Danh sách khoa
        List<Khoa> khoas = new List<Khoa>()
        {
            new Khoa{Id=1,TenKhoa="Cong nghe so"},
            new Khoa{Id=2,TenKhoa="Dien - Dien tu"},
            new Khoa{Id=3,TenKhoa="Hoa hoc moi truong"}
        };

        //Random sinh viên
        List<SinhVien> sv = new List<SinhVien>();

        for (int i = 1; i <= 30; i++)
        {
            sv.Add(new SinhVien
            {
                Id = i,
                Name = "SV" + i,
                Score = Math.Round(rd.NextDouble() * 10, 2),
                KhoaId = rd.Next(1, 4)
            });
        }

        //1. Max điểm - Min điểm
        var maxScore = sv.Max(s => s.Score);
        var minScore = sv.Min(s => s.Score);

        Console.WriteLine("Max diem: " + maxScore);
        Console.WriteLine("Min diem: " + minScore);

        //2. Join sinh viên với khoa
        var joinData =
            from s in sv
            join k in khoas
            on s.KhoaId equals k.Id
            select new
            {
                s.Name,
                s.Score,
                k.TenKhoa
            };

        Console.WriteLine("\nDanh sach SV + Khoa:");
        foreach (var x in joinData)
        {
            Console.WriteLine(x.Name + " - " + x.Score + " - " + x.TenKhoa);
        }

        //3. Lấy 10 sinh viên điểm cao nhất
        var top10 =
            sv.OrderByDescending(s => s.Score)
              .Take(10);

        Console.WriteLine("\nTop 10 SV diem cao:");
        foreach (var x in top10)
        {
            Console.WriteLine(x.Name + " - " + x.Score);
        }

        //4. Bỏ qua 5 sinh viên điểm cao nhất
        var skip5 =
            sv.OrderByDescending(s => s.Score)
              .Skip(5);

        Console.WriteLine("\nDanh sach SV sau khi bo qua 5 SV diem cao:");
        foreach (var x in skip5)
        {
            Console.WriteLine(x.Name + " - " + x.Score);
        }

        Console.ReadKey();
    }
}