using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Ocenki
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void enterROBTN_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(this);
            mainForm.Show();
            this.Hide();
        }


        public string md5(string input)
        {
            MD5 md5Hasher = MD5.Create();

            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        private void enterRWBTN_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Логин_администратора == textBox1.Text && md5(enterRWTB.Text) == Properties.Settings.Default.Пароль_администратора)
            {
                MainForm mainForm = new MainForm(this, true);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(this);
            mainForm.Show();
            this.Hide();
        }
    }
}
