namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.enter = new System.Windows.Forms.Button();
            this.registr = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reg2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(392, 319);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(447, 116);
            this.enter.TabIndex = 0;
            this.enter.Text = "Вход";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // registr
            // 
            this.registr.Location = new System.Drawing.Point(464, 441);
            this.registr.Name = "registr";
            this.registr.Size = new System.Drawing.Size(308, 130);
            this.registr.TabIndex = 1;
            this.registr.Text = "регистрация";
            this.registr.UseVisualStyleBackColor = true;
            this.registr.Click += new System.EventHandler(this.registr_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1303, 604);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.password);
            this.tabPage1.Controls.Add(this.login);
            this.tabPage1.Controls.Add(this.enter);
            this.tabPage1.Controls.Add(this.registr);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1295, 578);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "вход";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reg2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1295, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "регистрация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(392, 56);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(447, 20);
            this.login.TabIndex = 2;
            this.login.Text = "логин";
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(392, 199);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(447, 20);
            this.password.TabIndex = 3;
            this.password.Text = "пароль";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(401, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(447, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "пароль";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(401, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(447, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "логин";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // reg2
            // 
            this.reg2.Location = new System.Drawing.Point(412, 308);
            this.reg2.Name = "reg2";
            this.reg2.Size = new System.Drawing.Size(398, 138);
            this.reg2.TabIndex = 7;
            this.reg2.Text = "зарегестрироваться";
            this.reg2.UseVisualStyleBackColor = true;
            this.reg2.Click += new System.EventHandler(this.reg2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 649);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button registr;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button reg2;
        private System.Windows.Forms.Label label1;
    }
}

