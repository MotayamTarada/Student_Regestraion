using Introduction.Sample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    public class TestClass
    {
        TestClass2 objTestClass2 = new TestClass2();
        TestClass3 objTestClass3 = new TestClass3();

        public void TestTest()
        {

            objTestClass2.PrintFirstName();
            objTestClass2.PrintFullName();


            objTestClass3.PrintTestClass3();
        }

        public void Test10()
        {

            objTestClass2.PrintFirstName();
        }

        public void Test11()
        {

            objTestClass2.PrintFirstName();
        }

    }
}
