namespace WindowsFormsApp2
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
            System.Windows.Forms.Button umn;
            this.oneBT = new System.Windows.Forms.Button();
            this.threeBT = new System.Windows.Forms.Button();
            this.twoBT = new System.Windows.Forms.Button();
            this.sevenBT = new System.Windows.Forms.Button();
            this.eightBT = new System.Windows.Forms.Button();
            this.nineBT = new System.Windows.Forms.Button();
            this.fourBT = new System.Windows.Forms.Button();
            this.fiveBT = new System.Windows.Forms.Button();
            this.sixBT = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.TextBox();
            umn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // umn
            // 
            umn.Location = new System.Drawing.Point(305, 245);
            umn.Name = "umn";
            umn.Size = new System.Drawing.Size(27, 23);
            umn.TabIndex = 12;
            umn.Text = "*";
            umn.UseVisualStyleBackColor = true;
            umn.Click += new System.EventHandler(this.umn_Click);
            // 
            // oneBT
            // 
            this.oneBT.Location = new System.Drawing.Point(173, 187);
            this.oneBT.Name = "oneBT";
            this.oneBT.Size = new System.Drawing.Size(38, 23);
            this.oneBT.TabIndex = 0;
            this.oneBT.Text = "1";
            this.oneBT.UseVisualStyleBackColor = true;
            this.oneBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // threeBT
            // 
            this.threeBT.Location = new System.Drawing.Point(261, 187);
            this.threeBT.Name = "threeBT";
            this.threeBT.Size = new System.Drawing.Size(38, 23);
            this.threeBT.TabIndex = 1;
            this.threeBT.Text = "3";
            this.threeBT.UseVisualStyleBackColor = true;
            this.threeBT.Click += new System.EventHandler(this.threeBT_Click);
            // 
            // twoBT
            // 
            this.twoBT.Location = new System.Drawing.Point(217, 187);
            this.twoBT.Name = "twoBT";
            this.twoBT.Size = new System.Drawing.Size(38, 23);
            this.twoBT.TabIndex = 2;
            this.twoBT.Text = "2";
            this.twoBT.UseVisualStyleBackColor = true;
            this.twoBT.Click += new System.EventHandler(this.twoBT_Click);
            // 
            // sevenBT
            // 
            this.sevenBT.Location = new System.Drawing.Point(173, 245);
            this.sevenBT.Name = "sevenBT";
            this.sevenBT.Size = new System.Drawing.Size(38, 23);
            this.sevenBT.TabIndex = 3;
            this.sevenBT.Text = "7";
            this.sevenBT.UseVisualStyleBackColor = true;
            this.sevenBT.Click += new System.EventHandler(this.sevenBT_Click);
            // 
            // eightBT
            // 
            this.eightBT.Location = new System.Drawing.Point(217, 245);
            this.eightBT.Name = "eightBT";
            this.eightBT.Size = new System.Drawing.Size(38, 23);
            this.eightBT.TabIndex = 4;
            this.eightBT.Text = "8";
            this.eightBT.UseVisualStyleBackColor = true;
            this.eightBT.Click += new System.EventHandler(this.eightBT_Click);
            // 
            // nineBT
            // 
            this.nineBT.Location = new System.Drawing.Point(261, 245);
            this.nineBT.Name = "nineBT";
            this.nineBT.Size = new System.Drawing.Size(38, 23);
            this.nineBT.TabIndex = 5;
            this.nineBT.Text = "9";
            this.nineBT.UseVisualStyleBackColor = true;
            this.nineBT.Click += new System.EventHandler(this.nineBT_Click);
            // 
            // fourBT
            // 
            this.fourBT.Location = new System.Drawing.Point(173, 214);
            this.fourBT.Name = "fourBT";
            this.fourBT.Size = new System.Drawing.Size(38, 23);
            this.fourBT.TabIndex = 6;
            this.fourBT.Text = "4";
            this.fourBT.UseVisualStyleBackColor = true;
            this.fourBT.Click += new System.EventHandler(this.button6_Click);
            // 
            // fiveBT
            // 
            this.fiveBT.Location = new System.Drawing.Point(217, 216);
            this.fiveBT.Name = "fiveBT";
            this.fiveBT.Size = new System.Drawing.Size(38, 23);
            this.fiveBT.TabIndex = 7;
            this.fiveBT.Text = "5";
            this.fiveBT.UseVisualStyleBackColor = true;
            this.fiveBT.Click += new System.EventHandler(this.fiveBT_Click);
            // 
            // sixBT
            // 
            this.sixBT.Location = new System.Drawing.Point(261, 216);
            this.sixBT.Name = "sixBT";
            this.sixBT.Size = new System.Drawing.Size(38, 23);
            this.sixBT.TabIndex = 8;
            this.sixBT.Text = "6";
            this.sixBT.UseVisualStyleBackColor = true;
            this.sixBT.Click += new System.EventHandler(this.sixBT_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(217, 274);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(82, 23);
            this.result.TabIndex = 9;
            this.result.Text = "результат";
            this.result.UseVisualStyleBackColor = true;
            this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(305, 216);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(27, 23);
            this.minus.TabIndex = 11;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(305, 274);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(27, 23);
            this.del.TabIndex = 13;
            this.del.Text = "/";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 16;
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(173, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 17;
            this.label1.TextChanged += new System.EventHandler(this.Label1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.del);
            this.Controls.Add(umn);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.sixBT);
            this.Controls.Add(this.fiveBT);
            this.Controls.Add(this.fourBT);
            this.Controls.Add(this.nineBT);
            this.Controls.Add(this.eightBT);
            this.Controls.Add(this.sevenBT);
            this.Controls.Add(this.twoBT);
            this.Controls.Add(this.threeBT);
            this.Controls.Add(this.oneBT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button oneBT;
        private System.Windows.Forms.Button threeBT;
        private System.Windows.Forms.Button twoBT;
        private System.Windows.Forms.Button sevenBT;
        private System.Windows.Forms.Button eightBT;
        private System.Windows.Forms.Button nineBT;
        private System.Windows.Forms.Button fourBT;
        private System.Windows.Forms.Button fiveBT;
        private System.Windows.Forms.Button sixBT;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox label1;
    }
}

