namespace BD
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
            this.comboBox_Login = new System.Windows.Forms.ComboBox();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Pass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox_Login
            // 
            this.comboBox_Login.FormattingEnabled = true;
            this.comboBox_Login.Location = new System.Drawing.Point(102, 36);
            this.comboBox_Login.Name = "comboBox_Login";
            this.comboBox_Login.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Login.TabIndex = 0;
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Location = new System.Drawing.Point(102, 90);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(121, 20);
            this.textBox_Pass.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Location = new System.Drawing.Point(23, 36);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(33, 13);
            this.label_Login.TabIndex = 4;
            this.label_Login.Text = "Login";
            // 
            // label_Pass
            // 
            this.label_Pass.AutoSize = true;
            this.label_Pass.Location = new System.Drawing.Point(26, 90);
            this.label_Pass.Name = "label_Pass";
            this.label_Pass.Size = new System.Drawing.Size(53, 13);
            this.label_Pass.TabIndex = 5;
            this.label_Pass.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 343);
            this.Controls.Add(this.label_Pass);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Pass);
            this.Controls.Add(this.comboBox_Login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Login;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_Pass;
    }
}

