using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student[] students = Student.Generate(5, 30, 90);

            Console.WriteLine("排序前:");
            Console.Write("請選擇排序欄位: (1) 中文, (2) 英文, (3) 數學, (4)總分(預設): ");

            int orderBy = 4;
            int.TryParse(Console.ReadLine(), out orderBy);

            if (orderBy == 1)
                Student.OrderByField = OrderBy.Chinese;
            else if (orderBy == 2)
                Student.OrderByField = OrderBy.English;
            else if (orderBy == 3)
                Student.OrderByField = OrderBy.Math;
            else
                Student.OrderByField = OrderBy.Total;

            foreach (Student s in students)
                s.Print();

            Array.Sort(students);

            Console.WriteLine("排序後:");
            foreach (Student s in students)
                s.Print();
        }
    }
}