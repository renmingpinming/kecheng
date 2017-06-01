namespace test
{
    partial class updateIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.back = new System.Windows.Forms.Button();
            this.xiugai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.yuanpsd = new System.Windows.Forms.Label();
            this.newpsd = new System.Windows.Forms.Label();
            this.apsd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(129, 203);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 0;
            this.back.Text = "返回";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // xiugai
            // 
            this.xiugai.Location = new System.Drawing.Point(49, 203);
            this.xiugai.Name = "xiugai";
            this.xiugai.Size = new System.Drawing.Size(75, 23);
            this.xiugai.TabIndex = 1;
            this.xiugai.Text = "确认修改";
            this.xiugai.UseVisualStyleBackColor = true;
            this.xiugai.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "账号：";
            // 
            // yuanpsd
            // 
            this.yuanpsd.AutoSize = true;
            this.yuanpsd.Location = new System.Drawing.Point(47, 78);
            this.yuanpsd.Name = "yuanpsd";
            this.yuanpsd.Size = new System.Drawing.Size(53, 12);
            this.yuanpsd.TabIndex = 3;
            this.yuanpsd.Text = "原密码：";
            // 
            // newpsd
            // 
            this.newpsd.AutoSize = true;
            this.newpsd.Location = new System.Drawing.Point(47, 109);
            this.newpsd.Name = "newpsd";
            this.newpsd.Size = new System.Drawing.Size(53, 12);
            this.newpsd.TabIndex = 4;
            this.newpsd.Text = "新密码：";
            // 
            // apsd
            // 
            this.apsd.AutoSize = true;
            this.apsd.Location = new System.Drawing.Point(45, 151);
            this.apsd.Name = "apsd";
            this.apsd.Size = new System.Drawing.Size(65, 12);
            this.apsd.TabIndex = 5;
            this.apsd.Text = "确认密码：";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(116, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(116, 148);
            this.textBox4.Name = "textBox4";
            this.textBox4.PasswordChar = '*';
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 9;
            // 
            // updateIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.apsd);
            this.Controls.Add(this.newpsd);
            this.Controls.Add(this.yuanpsd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xiugai);
            this.Controls.Add(this.back);
            this.Name = "updateIn";
            this.Text = "updateIn";
            this.Load += new System.EventHandler(this.updateIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button xiugai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label yuanpsd;
        private System.Windows.Forms.Label newpsd;
        private System.Windows.Forms.Label apsd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}