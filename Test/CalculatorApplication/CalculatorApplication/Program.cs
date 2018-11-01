using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    class NumberManipulator
    {
        public void GetValues(out int x, out int y)
        {
            Console.WriteLine("请输入第一个数字:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数字:");
            y = Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            int a, b;
            n.GetValues(out a, out b);
            Console.WriteLine("显示第一个数字:{0}",a);
            Console.WriteLine("显示第二个数字:{0}",b);
            Console.WriteLine("两个数值相加为:{0}", a+b);
            Console.ReadKey();
        }
    }
}
