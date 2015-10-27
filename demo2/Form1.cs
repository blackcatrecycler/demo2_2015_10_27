using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//更多窗口传值可以浏览        http://www.cnblogs.com/xuhuan/articles/1418705.html
//或者是                   http://www.cnblogs.com/bison1989/archive/2010/12/12/1903705.html
namespace demo2
{
    public partial class Form1 : Form
    {
        public int ID=0;
        public Form1()
        {
            InitializeComponent();
            ID = 0;

        }
        public int id {
            set {
                ID = value;
            }
            get { return ID; }
        }

        private void CheRewrite_CheckedChanged(object sender, EventArgs e)
        {
            if (CheRewrite.Checked == true) textBox1.ReadOnly = false;
            else textBox1.ReadOnly = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Login1.Text == "登录")
            {
                login lo = new login(textBox1.Text);
                lo.Owner = this;
                lo.StartPosition = FormStartPosition.CenterScreen;
                //lo.Show();
                lo.ShowDialog();
                if (ID == 1)
                {
                    label1.Visible = true;
                    textBox1.Visible = true;
                    CheRewrite.Visible = true;
                    Login1.Text = "注销";
                }
            }
            else
            {
                if (MessageBox.Show("确定注销吗？", "注销确认", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) != DialogResult.OK)
                {
                    //如果不是OK则取消。
                }
                else 
                {
                    label1.Visible = false;
                    textBox1.Visible = false;
                    CheRewrite.Visible = false;
                    ID = 0;
                    Login1.Text = "登录";
                }
            }
        }
    }
}
