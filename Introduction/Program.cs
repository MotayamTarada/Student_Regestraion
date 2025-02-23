using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    class Program 
    {
         static void Main(string[] args)
        {
            try
            {
                string xx = "Ahmad";
                int yyyy = Convert.ToInt32(xx);
            }
            catch (Exception ex)
            {
              
             
            }











            PublicOne obj = new PublicOne();
            Console.WriteLine(obj.TestOne);
            Console.WriteLine(obj.TestFour);


            // TestFour = 10;


            
            



            Console.WriteLine("Ahmad Saleh");


            if (((10 * 5) + 3 / 8 * ((1 + 5) - 105) > 250))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


            //int outerLoop = 0;
            //int innerloop = 0;

            //for (int i = 1; i <= 5; i++)
            //{
            //    outerLoop++;
            //    for (int j = 1; j <5 ; j++)
            //    {
            //        innerloop++;
            //    }
            //}

            //Console.WriteLine("Outer Loop is " + outerLoop); // 6  // 5  // 5
            //Console.WriteLine("Inner Loop is " + innerloop); // 36 // 25  // 20

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i ; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}


            //int i = 0;
            //while (i < 2)
            //{
            //    int j = 0;
            //    while (j < 2)
            //    {
            //        Console.Write("({0},{1}) ", i, j);
            //        j++;
            //    }
            //    i++;
            //    Console.WriteLine();
            //}


            int i = 0;
            do
            {
                int j = 0;
                do
                {
                    Console.Write("({0},{1}) ", i, j);
                    j++;
                } while (j < 2);
                i++;
                Console.WriteLine();

            } while (i < 2);


            // (0,0) (0,1)
            // (1,0) (1,1)


            // For
            // While
            // Do While

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            //for (int i = 1; i < 25; i++)
            //{
            //    if(i % 2 == 0)
            //    Console.WriteLine("This is an even number " + i);
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.WriteLine(j);
            //    }
            //}

            //int z = 0;
            //while (z < 25)
            //{
            //    Console.WriteLine(z);
            //    z++;
            //}

            int y = 0;
            do
            {
                y++;
                Console.WriteLine("y" + y);
            } while (y < 10);

            int yy = 0;
            do
            {
               
                Console.WriteLine("yy" + yy);
                yy++;
            } while (yy < 10);

            //*
            //***
            //*****
            //*******
            //*****
            //***
            //*

        }
    }
}
