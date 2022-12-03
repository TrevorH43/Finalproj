using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finalproj
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (userTextBox.Text.Length == 0)
            {
                errorProvider1.SetError(userTextBox, "User Name is required.");
                e.Cancel = true;
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (passTextBox.Text.Length == 0)
            {
                errorProvider1.SetError(passTextBox, "Password is required.");
                e.Cancel = true;
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (textBox5.Text.Length == 0)
            {
                errorProvider1.SetError(textBox5, "E-mail is required.");
                e.Cancel = true;
            }
        }

        private void loginTextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9 ,.-\\-_]*$");
            if (!regex.Match(userTextBox.Text).Success)
            {
                MessageBox.Show("Enter number correctly");
                    }
            else
            {
                MessageBox.Show("The User name or password is incorrect, try again");
                userTextBox.Clear();
                passTextBox.Clear();
                userTextBox.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text=="" && passwordTextBox.Text == "")
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The User name or password is incorrect, try again");
                loginTextBox.Clear();
                passwordTextBox.Clear();
                loginTextBox.Focus();
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
           
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
