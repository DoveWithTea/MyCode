using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeiBo
{
    class Feibo
    {
        static void Main(string[] args)
        {
            int N = 50;
            //由于数字太大，我只能用计算金融的decimal来作为类型
            decimal[] feiBo = new decimal[N];  //定义数组
            feiBo[0] = 1;    //C#数组从0开始！！！！
            feiBo[1] = 1;    //定义了前两项
                             //while 循环，计算数组斐波那契数列的每一项
            int x = 2;
            while (x <= N - 1)
            {
                feiBo[x] = feiBo[x - 1] + feiBo[x - 2];
                x++;
            }
            //foreach遍历数组，具体用法请百度，这里不再赘述。
            foreach (decimal i in feiBo)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
