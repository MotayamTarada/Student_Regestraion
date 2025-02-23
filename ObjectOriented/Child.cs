using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    public class Child : Base
    {
        public override int Add(int num1,int num2)
        {
            return num1 + num2 + num1 + num2;
        }
    }
}
