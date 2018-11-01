using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.IO;
using System.Net;

namespace SqlConnDb
{
    public class SqlConnDb
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        SqlConnection conn = null;
        readonly string Address = "C:\\MyConfig.INI";
        /// <summary>
        /// 构造函数,连接数据库，数据库连接字符在C:\MyConfig.INI中配置
        /// </summary>
        public SqlConnDb()
        {
            //try
            //{
            //    if (conn == null)
            //    {
            //        string ConnStr = "Server=" + GetLocalIp();
            //        ConnStr += ";initial catalog=" + ReadIniData("Database", "DBName", null, Address);
            //        ConnStr += ";user id=" + ReadIniData("Database", "UserName", null, Address);
            //        ConnStr += ";password=" + ReadIniData("Database", "PassWord", null, Address);
            //        conn = new SqlConnection(ConnStr);
            //        try
            //        {
            //            conn.Open();
            //            conn.Close();
            //        }
            //        catch (Exception ex)
            //        {
            //            Console.WriteLine("服务器[" + GetLocalIp() + "]连接失败!原因:" + ex.Message);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //}
        }
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
        /// <summary>
        /// 从数据库中查询数据的,返回为DataSet
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataSet Query(string sql)
        {
            DataSet ds = new DataSet();//DataSet是表的集合
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);//从数据库中查询
            da.Fill(ds);//将数据填充到DataSet
            ConnClose();//关闭连接
            return ds;//返回结果
        }
        /// <summary>
        /// 更新数据库
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int Update(string sql)
        {
            SqlCommand oc = new SqlCommand
            {
                CommandText = sql,//设置命令的文本
                CommandType = CommandType.Text,//设置命令的类型
                Connection = conn//设置命令的连接
            };//表示要对数据源执行的SQL语句或存储过程
            int x = oc.ExecuteNonQuery();//执行SQL语句
            ConnClose();//关闭连接
            return x;  //返回一个影响行数
        }
        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void ConnClose()
        {
            if (conn.State == ConnectionState.Open)
            {
                //判断数据库的连接状态，如果状态是打开的话就将它关闭
                conn.Close();
            }
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
    }
}
