using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo2
{
    public partial class login : Form
    {
        public login(string str)
        {
            InitializeComponent();
            label3.Text = str;
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            if (TxtAccount.Text.Trim() == "1111" && TxtPassword.Text.Trim() == "1111")
            {
                MessageBox.Show("登录成功");
                Form1 f1 = (Form1)this.Owner;
                f1.id = 1;
                this.Close();
            }
            else
                MessageBox.Show("用户名或密码错误");
        }
    }
}
