using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMathLibrary
{
    public enum ScoreOrderBy
    { Chinese, Math, English, Total }

    public class Student : IComparable
    {
        #region 屬性的定義

        public double Chinese { get; set; }

        public double English { get; set; }

        public double Math { get; set; }

        public double TotalScore
        {
            get { return Chinese + English + Math; }
        }

        private static Random random;
        public static ScoreOrderBy OrderByField;

        #endregion 屬性的定義

        #region 建構式

        public Student(double chinese, double english, double math)
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

        public static Student Generate(double min, double max)
        {
            if (Student.random == null)
                Student.random = new Random();

            double chinese = random.NextDouble(min, max);
            double english = random.NextDouble(min, max);
            double math = random.NextDouble(min, max);

            return new Student(chinese, english, math);
        }

        public static Student[] Generate(int count, double min, double max)
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
                case ScoreOrderBy.Chinese:
                    return Compare(this.Chinese, other.Chinese);

                case ScoreOrderBy.English:
                    return Compare(this.English, other.English);

                case ScoreOrderBy.Math:
                    return Compare(this.Math, other.Math);

                case ScoreOrderBy.Total:
                default:
                    return Compare(this.TotalScore, other.TotalScore);
            }
        }

        private int Compare(double a, double b)
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