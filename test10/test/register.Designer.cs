namespace test
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.zhanghao = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.psw = new System.Windows.Forms.TextBox();
            this.psdagain = new System.Windows.Forms.TextBox();
            this.zuce = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(40, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "账号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(39, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(39, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(37, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "确认密码";
            // 
            // zhanghao
            // 
            this.zhanghao.Location = new System.Drawing.Point(109, 51);
            this.zhanghao.Name = "zhanghao";
            this.zhanghao.Size = new System.Drawing.Size(100, 21);
            this.zhanghao.TabIndex = 4;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(109, 82);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 21);
            this.name.TabIndex = 5;
            // 
            // psw
            // 
            this.psw.Location = new System.Drawing.Point(109, 110);
            this.psw.Name = "psw";
            this.psw.PasswordChar = '*';
            this.psw.Size = new System.Drawing.Size(100, 21);
            this.psw.TabIndex = 6;
            // 
            // psdagain
            // 
            this.psdagain.Location = new System.Drawing.Point(109, 138);
            this.psdagain.Name = "psdagain";
            this.psdagain.PasswordChar = '*';
            this.psdagain.Size = new System.Drawing.Size(100, 21);
            this.psdagain.TabIndex = 7;
            // 
            // zuce
            // 
            this.zuce.Location = new System.Drawing.Point(39, 185);
            this.zuce.Name = "zuce";
            this.zuce.Size = new System.Drawing.Size(75, 23);
            this.zuce.TabIndex = 8;
            this.zuce.Text = "注册";
            this.zuce.UseVisualStyleBackColor = true;
            this.zuce.Click += new System.EventHandler(this.zuce_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(155, 185);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 9;
            this.back.Text = "返回";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.back);
            this.Controls.Add(this.zuce);
            this.Controls.Add(this.psdagain);
            this.Controls.Add(this.psw);
            this.Controls.Add(this.name);
            this.Controls.Add(this.zhanghao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "register";
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox zhanghao;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox psw;
        private System.Windows.Forms.TextBox psdagain;
        private System.Windows.Forms.Button zuce;
        private System.Windows.Forms.Button back;
    }
}