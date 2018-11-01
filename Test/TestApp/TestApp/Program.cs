using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    class Client
    {
        static void Main(string[] args)
        {
            ElephantIn ei = new ElephantIn();
            ei.PutIn();
        }
    }
    public abstract class PutInFridge
    {
        public void PutIn()
        {
            this.Start();
            this.Active();
            this.End();
            Console.ReadKey();
        }
        private void Start()
        {
            Console.WriteLine("打开冰箱");
        }
        private void End()
        {
            Console.WriteLine("关闭冰箱");
        }
        abstract public void Active();
    }
    public class ElephantIn : PutInFridge
    {
        public override void Active()
        {
            Console.WriteLine("切块剁碎！");
        }
    }
}
