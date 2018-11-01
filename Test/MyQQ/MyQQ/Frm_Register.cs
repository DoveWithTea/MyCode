using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQQ
{
    public partial class Frm_Register : Form
    {
        public Frm_Register()
        {
            InitializeComponent();
        }
        DataOperator dataOper = new DataOperator();

        private void Frm_Register_Load(object sender, EventArgs e)
        {
            cboxStar.SelectedIndex = cboxBlooadType.SelectedIndex = 0;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtNiceName.Text.Trim() == "" || txtNiceName.Text.Length>20)
            {
                MessageBox.Show("输入昵称有误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNiceName.Focus();
                return;
            }
            if (txtAge.Text.Trim() == "")
            {
                MessageBox.Show("请输入年龄！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAge.Focus();
                return;
            }
            if (!rbtnMale.Checked && !rbtnFamale.Checked)
            {
                MessageBox.Show("请选择性别！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rbtnFamale.Focus();
                return;
            }
            if (txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwd.Focus();
                return;
            }
            if (txtPwdAgain.Text.Trim() == "")
            {
                MessageBox.Show("请输入确认密码！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwdAgain.Focus();
                return;
            }
            if (txtPwd.Text.Trim()!=txtPwdAgain.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不一致，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwdAgain.Focus();
                return;
            }
            int myQQNum = 0;
            string message;
            string sex = rbtnMale.Checked ? rbtnMale.Text : rbtnFamale.Text;
            string sql = string.Format("insert into tb_User(Pwd,NickName,Sex,Age,Name,Star,BloodType) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');" +
                "select @@Identity from tb_User", txtPwd.Text.Trim(), txtNiceName.Text.Trim(), sex, int.Parse(txtAge.Text.Trim()), txtName.Text.Trim(), cboxStar.Text,cboxBlooadType.Text);
            MessageBox.Show(sql, "SQL语句", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SqlCommand command = new SqlCommand(sql,dataOper.connection);
            dataOper.connection.Open();
            int result = command.ExecuteNonQuery();
            if (result == 1)
            {
                sql = "select @@Identity from tb_User";
                command = new SqlCommand(sql, dataOper.connection);
                myQQNum = Convert.ToInt32(command.ExecuteScalar());
                message = string.Format("注册成功!你的QQ号码为" + myQQNum);
            }
            else
            {
                message = "注册失败,请重试！";
            }
            dataOper.connection.Close();
            MessageBox.Show(message, "注册结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
