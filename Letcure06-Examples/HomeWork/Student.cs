using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace HomeWork
{
    public enum OrderBy
    { Chinese, Math, English, Total }

    public class Student : IComparable
    {
        #region 屬性的定義

        public int Chinese { get; set; }

        public int English { get; set; }

        public int Math { get; set; }

        public int TotalScore
        {
            get { return Chinese + English + Math; }
        }

        private static Random random;
        public static OrderBy OrderByField;

        #endregion 屬性的定義

        #region 建構式

        public Student(int chinese, int english, int math)
        {
            this.Chinese = chinese;
            this.English = english;
            this.Math = math;
        }

        public Student() : this(0, 0, 0)
        {
        }

        public Student(Student student) : this(student.Chinese, student.English, student.Math)
        {
        }

        #endregion 建構式

        public void Print()
        {
            Console.WriteLine("國文:{0}, 英文:{1}, 數學:{2}, 總分:{3} ", this.Chinese, this.English, this.Math, this.TotalScore);
        }

        public Student Clone()
        {
            return new Student(this);
        }

        public static Student Generate(int min, int max)
        {
            if (Student.random == null)
                Student.random = new Random();

            int chinese = random.Next(min, max);
            int english = random.Next(min, max);
            int math = random.Next(min, max);

            return new Student(chinese, english, math);
        }

        public static Student[] Generate(int count, int min, int max)
        {
            Student[] students = new Student[count];
            for (int index = 0; index < students.Length; index++)
            {
                students[index] = Student.Generate(min, max);
            }
            return students;
        }

        public int CompareTo(object obj)
        {
            Student other = obj as Student;

            switch (OrderByField)
            {
                case OrderBy.Chinese:
                    return Compare(this.Chinese, other.Chinese);

                case OrderBy.English:
                    return Compare(this.English, other.English);

                case OrderBy.Math:
                    return Compare(this.Math, other.Math);

                case OrderBy.Total:
                default:
                    return Compare(this.TotalScore, other.TotalScore);
            }
        }

        private int Compare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a < b)
                return -1;
            else
                return 0;
        }
    }
}