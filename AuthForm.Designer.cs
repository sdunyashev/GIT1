namespace Ocenki
{
    partial class AuthForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterROLBL = new System.Windows.Forms.Label();
            this.enterRWLBL = new System.Windows.Forms.Label();
            this.enterRWTB = new System.Windows.Forms.MaskedTextBox();
            this.enterRWBTN = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterROLBL
            // 
            this.enterROLBL.AutoSize = true;
            this.enterROLBL.Location = new System.Drawing.Point(12, 9);
            this.enterROLBL.Name = "enterROLBL";
            this.enterROLBL.Size = new System.Drawing.Size(38, 13);
            this.enterROLBL.TabIndex = 0;
            this.enterROLBL.Text = "Логин";
            // 
            // enterRWLBL
            // 
            this.enterRWLBL.AutoSize = true;
            this.enterRWLBL.Location = new System.Drawing.Point(12, 48);
            this.enterRWLBL.Name = "enterRWLBL";
            this.enterRWLBL.Size = new System.Drawing.Size(45, 13);
            this.enterRWLBL.TabIndex = 2;
            this.enterRWLBL.Text = "Пароль";
            // 
            // enterRWTB
            // 
            this.enterRWTB.Location = new System.Drawing.Point(12, 64);
            this.enterRWTB.Name = "enterRWTB";
            this.enterRWTB.Size = new System.Drawing.Size(292, 20);
            this.enterRWTB.TabIndex = 3;
            this.enterRWTB.UseSystemPasswordChar = true;
            // 
            // enterRWBTN
            // 
            this.enterRWBTN.Location = new System.Drawing.Point(12, 90);
            this.enterRWBTN.Name = "enterRWBTN";
            this.enterRWBTN.Size = new System.Drawing.Size(143, 23);
            this.enterRWBTN.TabIndex = 4;
            this.enterRWBTN.Text = "Войти как админ";
            this.enterRWBTN.UseVisualStyleBackColor = true;
            this.enterRWBTN.Click += new System.EventHandler(this.enterRWBTN_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Администратор";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(161, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Войти как пользователь";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 118);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.enterRWBTN);
            this.Controls.Add(this.enterRWTB);
            this.Controls.Add(this.enterRWLBL);
            this.Controls.Add(this.enterROLBL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterROLBL;
        private System.Windows.Forms.Label enterRWLBL;
        private System.Windows.Forms.MaskedTextBox enterRWTB;
        private System.Windows.Forms.Button enterRWBTN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

