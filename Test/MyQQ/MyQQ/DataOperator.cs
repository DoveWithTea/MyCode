using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using SqlConnDb;

namespace MyQQ
{
    class DataOperator
    {
        public SqlConnection connection = new SqlConnection(SqlConDb.GetSqlConnStr());

        public DataSet GetDataSet(string sql)
        {
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            sqlda.Fill(ds);
            return ds;
        }

        public int ExecSQL(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            if (connection.State == ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            int num = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();
            return num;
        }
        public int ExecSQLResult(string sql)
        {
            SqlCommand command = new SqlCommand(sql, connection);
            if (connection.State == ConnectionState.Closed)
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            int result = Convert.ToInt32(command.ExecuteNonQuery());
            connection.Close();
            return result;
        }
    }
}

