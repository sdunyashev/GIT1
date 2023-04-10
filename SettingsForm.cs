using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Ocenki
{
    public partial class SettingsForm : Form
    {
        Form parent;
        public SettingsForm(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (md5(maskedTextBox1.Text) == Properties.Settings.Default.Пароль_администратора)
            {
                if (maskedTextBox2.Text == maskedTextBox3.Text)
                {
                    Properties.Settings.Default.Пароль_администратора = md5(maskedTextBox2.Text);
                    MessageBox.Show("Пароль успешно изменён!");
                }
                else
                {
                    MessageBox.Show("Введённые пароли должны совпадать!");
                }
            }
            else
            {
                MessageBox.Show("Старый парль введён неверно!");
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.Логин_администратора;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Логин_администратора = textBox1.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Логин изменён!");
        }
    }
}
