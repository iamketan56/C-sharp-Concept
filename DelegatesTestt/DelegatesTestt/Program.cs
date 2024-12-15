using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesTestt
{
    public delegate void  AddNumDelegate(int i, int j);
    public delegate void RectDelegates(double h, double w);

    public delegate string GreetsDelegate(string s);

    internal class Program
    {
            public static void addnum(int i , int j)
            {
            Console.WriteLine("Sum is " + (i + j));
             }

        public  static int sum(int i, int j)
        {
           return (i + j);
        }

        public static bool IsZero(int i)
        {
            return (i == 0);
        }

        public void GetAreaRect(double width, double height)
        {
            Console.WriteLine("Area of the Rectangle : " + width * height);
        }
        public void GetPerimeterRect(double width, double height)
        {

            Console.WriteLine("Perimaeter of the Rectangle : " + 2 * (width * height));
        }


        static void Main(string[] args)
        {
            // simple degates
                //program program = new program();
                //addnumdelegate ad = new addnumdelegate(program.addnum);
                //ad.invoke(1, 3);
                //console.readline();

            // multicast delegets
                Program md = new Program();
                //RectDelegates rd = new RectDelegates(md.GetAreaRect); // 1st binding 
                //rd += md.GetPerimeterRect; // 2nd binding
                //rd.Invoke(12.34, 56.78);
                //Console.ReadLine();

            // lamda and anonyumos fucntion
                //  GreetsDelegate d =  (name) =>
                //     {
                //         return "Hello " + name;
                //     };

                //string greet = d.Invoke("ketan");
                // Console.WriteLine(greet);
                // Console.ReadLine();

            // Func Action Predict - > generic degelets 
                Func<int, int, int> obj = sum; // func is used where function is retuning something
                int res = obj.Invoke(1, 2);
                Console.WriteLine(res);


                Predicate<int> obj2 = IsZero; // Predicate is used when fucntion is returing boolean value
                bool result = obj2.Invoke(3);
                Console.WriteLine(result);

                Action<int, int> obj1 = addnum; // func is used where function is not retuning something 
                obj1.Invoke(1, 2);
                Console.ReadLine();
        }
    }
}
