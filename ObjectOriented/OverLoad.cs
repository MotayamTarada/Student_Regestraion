using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    public class OverLoad
    {
        public int Add(double num1, double num2)
        {
            return Convert.ToInt32(num1 + num2);
        }

        public double Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public float Add(float num1, float num2)
        {
            return num1 + num2;
        }



        public string Add(string val1, string val2)
        {
            return val1 + " " + val2;
        }
    }
}
