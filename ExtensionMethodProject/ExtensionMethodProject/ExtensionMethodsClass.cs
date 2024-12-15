using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodProject
{
    internal static class ExtensionMethodsClass // This class must be static class 
    {
        public static void Test3(this Program program) // pass this keyword to bound this function to Program class while defininf this function will be static but once it bound with program class it will turn into non static class
        {
            Console.WriteLine("I am the test 3 (extened function)");
        }

        public static long Factorial(this Int32 x) // adding factorial method in int32 structure
        {
            if (x == 1) return 1;
            if (x == 2) return 2;
            else
                return x * Factorial(x - 1);
        }

        public static String ToProperCase(this String oldstring)
        {
            String final = null;
            if (!String.IsNullOrEmpty(oldstring))
            {
                String newstr = null;
                oldstring = oldstring.ToLower();
                string[] srry = oldstring.Split(' ');
                foreach (String s in srry)
                {
                    char[] charr = s.ToCharArray();
                    charr[0] = char.ToUpper(charr[0]);
                    newstr = new String(charr);
                    final.Concat(newstr);
                }
                return final;
            }
            return oldstring;
        }
    }
}
