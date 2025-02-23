using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriented
{
    class Program
    {
        static void Main(string[] args)
        {

            Base objBase;
            objBase = new Base();
            Console.WriteLine("This is Base Class:" + objBase.Add(10, 5));


            objBase = new Child();
            Console.WriteLine("This is Base Class:" + objBase.Add(10, 5));

            OverLoad objLoad = new OverLoad();
            Console.WriteLine(objLoad.Add(10.5f, 10.5f));
            Console.WriteLine(objLoad.Add(150, 150, 150));
            Console.WriteLine(objLoad.Add(20.3, 20.1));


            IUsers obj = new Users();
            Console.WriteLine(obj.ReturnFullName());

            Users obj2 = new Users();
            Console.WriteLine(obj2.ReturnFullName());


            ChildAnimal objAnimal = new ChildAnimal();
            objAnimal.SleepSound();
            objAnimal.AnimalSound();



            ////////////// myName "Ahmad"
            ///[  ][    ] = [    ];
            string myName = "Ahmad";

            // "Ahmad Saleh"
            //string xx = "Ahmad Saleh";
            //Console.WriteLine("helsA damhA");

            string temp = "Ahmad Saleh";
            Console.WriteLine(temp);

            char[] name = temp.ToCharArray();
            Array.Reverse(name);
            string reversedStr = new string(name);
            Console.WriteLine(reversedStr);

  
         
            

        }
    }
}
