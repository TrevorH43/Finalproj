using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLibrary;

namespace Finalproj
{
    public partial class checkOut : Form
    {
        checkOut frmcheckOut = null;
        public checkOut()
        {
            InitializeComponent();
        }

        private void checkOut_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Utility.IsValid(ccNumberTextBox.Text))
            {
                MessageBox.Show("Credit Card Valid");
            }
            else
            {
                MessageBox.Show("Credit Card is Invalid");
            }
        }
        private void ShowForm(Form frmSubForm)
        {
            foreach (Control control in this.panel1.Controls)
            {
                if (control != frmSubForm)
                {
                    control.Hide();
                }
                else
                {
                    control.Show();
                }
            }
        }
        private void exitButton_Validating(object sender, CancelEventArgs e)
        {

        }

        private void ccNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (ccNumberTextBox.Text.Length == 0)
            {
                errorProvider1.SetError(ccNumberTextBox, "Credit card number is required");
                e.Cancel = true;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            if (frmcheckOut == null)
            {
                frmcheckOut = new checkOut();
                SetFormProperties(frmcheckOut);
            }
            ShowForm(frmcheckOut);
        }

        private void birdButton_Click(object sender, EventArgs e)
        {

        }

        private void catdogButton_Click(object sender, EventArgs e)
        {

        }

        private void fishButton_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetFormProperties(Form frmSubForm)
        {
            frmSubForm.TopLevel = false;
            frmSubForm.AutoScroll = true;
            frmSubForm.Dock = DockStyle.Fill;
            this.itemsPanel.Controls.Add(frmSubForm);
        }

    }
}
