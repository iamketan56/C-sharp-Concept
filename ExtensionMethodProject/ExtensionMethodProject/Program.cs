using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodProject
{
    internal class Program
    {
        public void test()
        {
            Console.WriteLine("I am test 1");
        }
        public void test1()
        {
            Console.WriteLine("I am test 2");

        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.test();   
            p.test1();
            p.Test3();
            // extended method bind with program class ...
            // if the same name of the method is already present in the class then extesnion method will not be called preference goes to the origincal method
           // Console.ReadLine();

            int i = 5; // int 32 is struct
            Console.WriteLine(i.Factorial()); //  calling extendted fact method 
            Console.ReadLine();

            String s = "my name is ketan"; // string is sealed class
            s = s.ToProperCase();
            Console.WriteLine(s);
            Console.ReadLine();
        }

    }
}
