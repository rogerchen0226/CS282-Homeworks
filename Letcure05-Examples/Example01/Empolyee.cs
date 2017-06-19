using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class Empolyee
    {
        private int baseSalary;
        private int benefit;

        public int BaseSalary
        {
            get
            {
                return baseSalary;
            }
            set
            {
                if (value < 0)
                {
                    this.baseSalary = 0;
                }
                else
                    this.baseSalary = value;
            }
        }

        public int Salary
        {
            get { return BaseSalary + Benefit; }
        }

        public int Benefit
        {
            get
            {
                return benefit;
            }
            set
            {
                this.benefit = value;
            }
        }
    }
}