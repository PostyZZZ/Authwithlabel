using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authwithlabel
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            DatabaseHelper dbHelper = new DatabaseHelper("Host=localhost;Port=5432;Username=postgres;Password=123;Database=authlbl;");

            if (dbHelper.VerifyLogin(username, password))
            {
                MessageBox.Show("Авторизация успешна!");

                Form2 form2 = new Form2(username);
                form2.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильное имя пользователя или пароль!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
