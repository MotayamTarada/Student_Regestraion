using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    class PublicTwo : PublicOne
    {
        public void Test()
        {
            //PublicOne objPublicOne = new PublicOne();
            //objPublicOne.ResultOne();
            //objPublicOne.ResultFour();


            //int xx = objPublicOne.TestOne;
            //int yy = objPublicOne.TestFour;



            TestTwo = 10;
            TestOne = 20;
            TestFour = 30;

            ResultOne();
            ResultTwo();
            ResultFour();
        }
    }
}
