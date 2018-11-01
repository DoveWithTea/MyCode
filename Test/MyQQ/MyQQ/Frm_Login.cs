using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyQQ
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 创建数据库连接类
        /// </summary>
        DataOperator dataOper = new DataOperator();
        /// <summary>
        /// 数据检测
        /// </summary>
        /// <returns></returns>

        private bool ValidateInput()
        {
            if (txtID.Text.Trim()=="")
            {
                MessageBox.Show("请输入登陆账号!", "登陆提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();
                return false;
            }
            else if (int.Parse(txtID.Text.Trim())>65535)
            {
                MessageBox.Show("请输入正确的登陆账号!", "登陆提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();
                return false;
            }
            else if (txtID.Text.Length>5 && txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码!", "登陆提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPwd.Focus();
                return false;
            }
            return true;
        }
        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 只允许输入数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (e.KeyChar == '\r') || (e.KeyChar == '\b'))
                e.Handled = false;
            else
                e.Handled = true;
        }
        /// <summary>
        /// 登入主页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pBoxLogin_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string sql = "select count(*) from tb_User where id=" + int.Parse(txtID.Text.Trim()) + " and Pwd='" + txtPwd.Text.Trim() + "'";
                int num = dataOper.ExecSQL(sql);
                if (num == 1)
                {
                    PublicClass.LoginID = int.Parse(txtID.Text.Trim());
                    if (cboxRemember.Checked)
                    {
                        dataOper.ExecSQLResult("update tb_User set Remember=1 where id=" + int.Parse(txtID.Text.Trim()));
                        if (cboxAutoLogin.Checked)
                        {
                            dataOper.ExecSQLResult("update tb_User set AutoLogin=1 where id=" + int.Parse(txtID.Text.Trim()));
                        }
                    }
                    else
                    {
                        dataOper.ExecSQLResult("update tb_User set Remember=0 where id=" + int.Parse(txtID.Text.Trim()));
                        dataOper.ExecSQLResult("update tb_User set AutoLogin=0 where id=" + int.Parse(txtID.Text.Trim()));
                    }
                    dataOper.ExecSQLResult("update tb_User set Flag=1 where id=" + int.Parse(txtID.Text.Trim()));   //设置在线状态
                    frm_Main frmmain = new frm_Main();
                    frmmain.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("输入的账号密码有误!", "登陆提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        /// <summary>
        /// 密码框回车完成登入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                pBoxLogin_Click(sender, e);
        }

        private void cboxRemember_CheckedChanged(object sender, EventArgs e)
        {
            if (!cboxRemember.Checked)
                cboxAutoLogin.Checked = false;
        }
        /// <summary>
        /// 自动登录设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() != "")
            {
                ValidateInput();
                string sql = "select Pwd,Remember,AutoLogin from tb_User where id=" + int.Parse(txtID.Text.Trim()) + "";
                DataSet ds = dataOper.GetDataSet(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (Convert.ToInt32(ds.Tables[0].Rows[0][1]) == 1)
                    {
                        cboxRemember.Checked = true;
                        txtPwd.Text = ds.Tables[0].Rows[0][0].ToString();
                        if (Convert.ToInt32(ds.Tables[0].Rows[0][2]) == 1)
                        {
                            cboxAutoLogin.Checked = true;
                            pBoxLogin_Click(sender, e);
                        }
                    }
                }
            }
        }

        private void pBoxClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void linkLblReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Register frmRegister = new Frm_Register();
            frmRegister.Show();
        }

        private void pBoxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
