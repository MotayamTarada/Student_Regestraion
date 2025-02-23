using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    class VariablesAndDataTypes
    {
        public void Test()
        {
            Int16 countt = 50;
            Int32 count = 0;
            int count1 = 10;
            int count2 = 100000;
            int count3 = 1000000;
            int count4 = 100000000;
            Int64 count5 = 10000000000;
            long count6 = 252525225;

            int First = 150;
            int second = 250;

            double AVG = 10.1;
            float AVG1 = 10.35f;
            decimal AVG2 = 105.325m;
            double result = AVG + AVG1;
            int AVG3 = Convert.ToInt32(AVG + AVG1);

            bool test1 = true;
            int test2 = 0;
            int test10 = Convert.ToInt32(test1);
            bool test3 = Convert.ToBoolean(test2);
            decimal test4 = Convert.ToDecimal(test2);

            char result2 = 'A';
            char result3 = 'B';

            int result4 = Convert.ToInt32(result3);
            //bool result5 = Convert.ToBoolean(result3);

            string str1 = "10";
            string str2 = "10.25";
            string str3 = "Ahmad";
            string str4 = Convert.ToString(AVG2);

            int result10 = Convert.ToInt32(str1);
            //int result11 = Convert.ToInt32(str2);
            //int result12 = Convert.ToInt32(str3);

            DateTime date1 = DateTime.Now;

            Console.WriteLine(date1);
            Console.WriteLine(date1.ToString("dd-mm-yyyy"));
            Console.WriteLine(date1.ToString("dd-MM-yyyy"));
            Console.WriteLine(date1.ToString("ddd-MMM-yyyy"));

            string str5 = "10/11/2023";
            string str6 = "10/18/2023";
            //string str7 = "18/10/2023";

            DateTime date2 = Convert.ToDateTime(str5);
            DateTime date3 = Convert.ToDateTime(str6);
            //DateTime date4 = Convert.ToDateTime(str7);

            DateTime date5 = DateTime.MaxValue;
            DateTime date6 = DateTime.MinValue;
            int result15 = DateTime.Now.Year;
            long result16 = DateTime.Now.Ticks;

            TimeSpan date7 = (DateTime.Now - date2);

            Console.WriteLine(date5);
            Console.WriteLine(date6);
            Console.WriteLine(result15);
            Console.WriteLine(result16);
            Console.WriteLine(date7);

            Console.WriteLine(date2);
            Console.WriteLine(date3);
            //Console.WriteLine(date4);
            //Console.WriteLine(First + second);
            //Console.WriteLine(AVG);
            //Console.WriteLine(AVG1);
            //Console.WriteLine(AVG2);
            //Console.WriteLine(result.ToString("00.00"));
            //Console.WriteLine(AVG3);
            //decimal test = Convert.ToDecimal(AVG1 + count4);
            //Console.WriteLine(test);
            //Console.WriteLine(AVG1 + count1);
            //Console.WriteLine(test10);
            //Console.WriteLine(test3);
            //Console.WriteLine(test4);
            //Console.WriteLine(result4);
            //Console.WriteLine(str1);
            //Console.WriteLine(str2);
            //Console.WriteLine(str3);
            //Console.WriteLine(str4);
            ////Console.WriteLine(result5);

            //Console.WriteLine("Ahmad" + 10 + 50); 
            //Console.WriteLine(10 + "Ahmad" + 50); 
            //Console.WriteLine(10 + 50 + "Ahmad"); 
            //Console.WriteLine("---------------------"); 
            //Console.WriteLine("Ahmad" + (10 + 50)); 
            //Console.WriteLine(10 + "Ahmad" + 50); 
            //Console.WriteLine((10 + 50) + "Ahmad"); 
            //Console.WriteLine("---------------------");
            //Console.WriteLine((10 - 50) * 3 + "Ahmad" + 5); //-120Ahmad5
            //Console.WriteLine("Ahmad" + 10 * 50); //Ahmad500
            //Console.WriteLine(50 + "Ahmad" + 10 * 25); //50Ahmad250
        }
    }
}
