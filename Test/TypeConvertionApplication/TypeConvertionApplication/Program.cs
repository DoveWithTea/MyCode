using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConvertionApplication
{
    class StringConversion
    {
        static void Main(string[] args)
        {
            int i = 1234;
            double d = 2.345;
            float f = 3.456f;
            bool b = true;
            Console.WriteLine(i.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(b.ToString());
            Console.ReadKey();
        }
    }
}
