using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    public class PublicOne
    {

        public  int TestOne = 10;
        protected  int TestTwo = 20;
        private  int TestThree = 30;
        internal  int TestFour = 40;


        public void ResultOne()
        {
            int TestOne = 10;
            TestOne = 150;
        }

        protected void ResultTwo()
        {
            TestOne = 150;
        }

        private void ResultThree()
        {
            TestOne = 150;
        }

        internal void ResultFour()
        {

        }
    }
}
