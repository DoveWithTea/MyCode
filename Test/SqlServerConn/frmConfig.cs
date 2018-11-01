using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices;
using System.Net;
namespace SqlServerConn
{
    public partial class FormConn : Form
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        SqlConnection conn = null;
        readonly string Address = "C:\\MyConfig.INI";
        /// <summary>
        /// 定义数据库所在位置
        /// </summary>

        public FormConn()
        {
            InitializeComponent();
        }
        private void btnCS_Click(object sender, EventArgs e)
        {
            string ConnStr = "Server=" + txtServer.Text;
            ConnStr += ";initial catalog=" + txtDB.Text;
            ConnStr += ";user id=" + txtUserName.Text;
            ConnStr += ";password=" + txtPWD.Text;
            bool CanConnectDB = false;
            using (SqlConnection ObjConnection = new SqlConnection(ConnStr))
            {
                try
                {
                    ObjConnection.Open();
                    CanConnectDB = true;
                    ObjConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("服务器[" + txtServer.Text + "]连接失败!原因:" + ex.Message);
                }
                if (CanConnectDB) MessageBox.Show("服务器[" + txtServer.Text + "]连接成功!");
            }
        }

        private void FormConn_Load(object sender, EventArgs e)
        {
            try
            {
                txtServer.Text = ReadIniData("Database", "Server", null, Address);
                string CReadLocal = ReadIniData("Database", "ReadLocal", null, Address);
                if (CReadLocal == "1") txtServer.Text = GetLocalIp(); //获取本地IP
                txtDB.Text = ReadIniData("Database", "DBName", null, Address);
                txtUserName.Text = ReadIniData("Database", "UserName", null, Address);
                txtPWD.Text = ReadIniData("Database", "PassWord", null, Address);
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取[" + Address + "]文件失败!原因:" + ex.Message);
            }
            txtDB.ReadOnly = true;
            txtServer.ReadOnly = true;
            txtUserName.ReadOnly = true;
            txtPWD.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            try
            {
                IniWriteValue("Database", "Server", txtServer.Text);
                IniWriteValue("Database", "DBName", txtDB.Text);
                IniWriteValue("Database", "UserName", txtUserName.Text);
                IniWriteValue("Database", "PassWord", txtPWD.Text);
            }
            catch (Exception ex) {
                MessageBox.Show("写入[" + Address + "]文件失败!原因:" + ex.Message);
            }
            MessageBox.Show("保存成功!");
            this.Close();
        }

        private void BtnAlt_Click(object sender, EventArgs e)
        {
            txtDB.ReadOnly = false;
            txtServer.ReadOnly = false;
            txtUserName.ReadOnly = false;
            txtPWD.ReadOnly = false;
        }
        public string ReadIniData(string Section, string Key, string NoText, string iniFilePath)//读取INI文件
        {
            if (File.Exists("" + Address + ""))
            {
                StringBuilder temp = new StringBuilder(1024);
                GetPrivateProfileString(Section, Key, NoText, temp, 1024, iniFilePath);
                return temp.ToString();
            }
            else
            {
                return String.Empty;
            }
        }
        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.Address);
        }
        /// <summary>
        /// 获取本地IP地址
        /// </summary>
        /// <returns></returns>
        public static string GetLocalIp()
        {
            IPAddress localIp = null;

            try
            {
                IPAddress[] ipArray;
                ipArray = Dns.GetHostAddresses(Dns.GetHostName());
                localIp = ipArray.First(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);

            }
            catch (Exception ex)
            {
            }
            if (localIp == null)
            {
                localIp = IPAddress.Parse("127.0.0.1");
            }
            return localIp.ToString();
        }
    }
}
