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
            Empolyee empolyee = new Empolyee();

            Console.WriteLine("請輸入底薪:");
            int baseSalary = int.Parse(Console.ReadLine());
            empolyee.BaseSalary = baseSalary;
            Console.WriteLine("請輸入獎金:");
            int benefit = int.Parse(Console.ReadLine());
            empolyee.Benefit = benefit;
            Console.WriteLine("你的薪水是:{0}", empolyee.Salary);
        }
    }
}