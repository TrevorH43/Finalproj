using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finalproj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            navigationPanel.Height = catdogButton.Height;

        }


        private void ShowForm(Form frmSubForm)
        {
            foreach (Control control in this.navigationPanel.Controls)
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

        private void homeButton_Click(object sender, EventArgs e)
        {

        }

        private void catdogButton_Click(object sender, EventArgs e)
        {

        }

        private void birdButton_Click(object sender, EventArgs e)
        {

        }

        private void aquaticButton_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
