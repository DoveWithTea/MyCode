using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MyService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }
        Process pr = new Process();
        protected override void OnStart(string[] args)
        {    
            pr.StartInfo.FileName = "E:\\代码改造\\YXSOFT\\IPChange.exe";
            pr.Start();
        }

        protected override void OnStop()
        {
            pr.Close();
        }
    }
}
