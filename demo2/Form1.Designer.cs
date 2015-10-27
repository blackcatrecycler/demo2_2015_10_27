namespace demo2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.CheRewrite = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Login1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // CheRewrite
            // 
            this.CheRewrite.AutoSize = true;
            this.CheRewrite.Location = new System.Drawing.Point(407, 189);
            this.CheRewrite.Name = "CheRewrite";
            this.CheRewrite.Size = new System.Drawing.Size(59, 19);
            this.CheRewrite.TabIndex = 0;
            this.CheRewrite.Text = "修改";
            this.CheRewrite.UseVisualStyleBackColor = true;
            this.CheRewrite.Visible = false;
            this.CheRewrite.CheckedChanged += new System.EventHandler(this.CheRewrite_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(233, 25);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "哈哈哈哈哈哈";
            this.textBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "预留信息";
            this.label1.Visible = false;
            // 
            // Login1
            // 
            this.Login1.AutoSize = true;
            this.Login1.Location = new System.Drawing.Point(445, 24);
            this.Login1.Name = "Login1";
            this.Login1.Size = new System.Drawing.Size(37, 15);
            this.Login1.TabIndex = 3;
            this.Login1.TabStop = true;
            this.Login1.Text = "登录";
            this.Login1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Login1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 303);
            this.Controls.Add(this.Login1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CheRewrite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox CheRewrite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel Login1;
    }
}

