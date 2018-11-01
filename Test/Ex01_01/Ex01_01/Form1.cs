using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ex01_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string address = System.Environment.CurrentDirectory;
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            this.openFileDialog1.ShowDialog();
            StreamWriter s = new StreamWriter(address + "\\Menu.ini",true);
            s.WriteLine(openFileDialog1.FileName);
            s.Flush();
            s.Close();
            ShowWindows(openFileDialog1.FileName);
        }
        public void ShowWindows(string FileName)
        {
            Image p = Image.FromFile(FileName);
            Form f = new Form();
            f.MdiParent = this;
            f.BackgroundImage = p;
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(address + "\\Menu.ini");
            int i = this.文件ToolStripMenuItem.DropDownItems.Count - 1;
            while(sr.Peek()>=0)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(sr.ReadLine());
                this.文件ToolStripMenuItem.DropDownItems.Insert(i, menuItem);
                i++;
                menuItem.Click += new EventHandler(menuItem_click);
            }
            sr.Close();
        }

        private void menuItem_click(object sender, EventArgs e)
        {
            ToolStripMenuItem Mymeun = (ToolStripMenuItem)sender;
            ShowWindows(Mymeun.Text);
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
