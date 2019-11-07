namespace WindowsFormsApp3
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
            this.hour = new System.Windows.Forms.Label();
            this.secund = new System.Windows.Forms.Label();
            this.minut = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.alarm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hour
            // 
            this.hour.AutoSize = true;
            this.hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hour.Location = new System.Drawing.Point(286, 150);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(44, 31);
            this.hour.TabIndex = 0;
            this.hour.Text = "00";
            this.hour.Click += new System.EventHandler(this.label1_Click);
            // 
            // secund
            // 
            this.secund.AutoSize = true;
            this.secund.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secund.Location = new System.Drawing.Point(386, 150);
            this.secund.Name = "secund";
            this.secund.Size = new System.Drawing.Size(44, 31);
            this.secund.TabIndex = 2;
            this.secund.Text = "00";
            this.secund.Click += new System.EventHandler(this.secund_Click);
            // 
            // minut
            // 
            this.minut.AutoSize = true;
            this.minut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minut.Location = new System.Drawing.Point(336, 150);
            this.minut.Name = "minut";
            this.minut.Size = new System.Drawing.Size(44, 31);
            this.minut.TabIndex = 3;
            this.minut.Text = "00";
            this.minut.Click += new System.EventHandler(this.label4_Click);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(276, 252);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(153, 78);
            this.button.TabIndex = 4;
            this.button.Text = "START";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // alarm
            // 
            this.alarm.AutoSize = true;
            this.alarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alarm.Location = new System.Drawing.Point(285, 195);
            this.alarm.Name = "alarm";
            this.alarm.Size = new System.Drawing.Size(0, 39);
            this.alarm.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alarm);
            this.Controls.Add(this.button);
            this.Controls.Add(this.minut);
            this.Controls.Add(this.secund);
            this.Controls.Add(this.hour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hour;
        private System.Windows.Forms.Label secund;
        private System.Windows.Forms.Label minut;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label alarm;
    }
}

