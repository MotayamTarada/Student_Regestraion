using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    class IfStatement
    {
        public void Test()
        {
            //if statement
            //else if statement
            //else statement

            int i = 10;
            int j = 15;
            int z = 20;

            if (z > j)
            {
                Console.WriteLine("z greater than j");
            }

            if (i > j)
            {
                Console.WriteLine("i greater than j");
            }

            if (i > z)
            {
                Console.WriteLine("i greater than z");
            }

            bool Gender = true;

            if (Gender == true)
            {
                // Male
            }
            else
            {
                // Female
            }

            string result = Gender == true ? "Male" : "Female";



            if (z > j)
            {
                Console.WriteLine("i greater than j");
            }
            else if (i > z)
            {
                Console.WriteLine("i greater than z");
            }
            else if (i > j)
            {
                Console.WriteLine("z greater than j");
            }


            int AVG = 85;

            if (AVG >= 90)
            {
                Console.WriteLine("Excellent");
            }
            else if (AVG < 90 && AVG >= 80)
            {
                Console.WriteLine("Very Good");
            }
            else if (AVG < 80 && AVG >= 70)
            {
                Console.WriteLine("Good");
            }
            else
            {
                Console.WriteLine("Bad");
            }


            switch (AVG)
            {
                case int x when (x > 90):
                    Console.WriteLine("Excellent");
                    break;
                case int x when (x < 90 && x > 80):
                    Console.WriteLine("Very Good");
                    break;
                case 70:
                    Console.WriteLine("Good");
                    break;
                case 60:
                    Console.WriteLine("Bad");
                    break;
                default:
                    Console.WriteLine("No Result");
                    break;
            }





            int NumberofStudent = 190;

            if (NumberofStudent < 200)
            {
                Console.WriteLine("NumberofStudent less than 200");
            }
            else if (NumberofStudent > 200)
            {
                Console.WriteLine("NumberofStudent greater than 200");
            }
            else
            {
                Console.WriteLine("NumberofStudent wrong");
            }
        }
    }
}
