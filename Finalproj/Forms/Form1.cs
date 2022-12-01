using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Finalproj
{
    public partial class Form1 : Form
    {
        checkOut checkOutfrm = null;

        public Form1()
        {
            InitializeComponent();
            navigationPanel.Height = birdButton.Height;
            birdControl1.BringToFront();

        }


        private void homeButton_Click(object sender, EventArgs e)
        {
            navigationPanel.Height = homeButton.Height;
            
        }

        private void catdogButton_Click(object sender, EventArgs e)
        {
            navigationPanel.Height = catdogButton.Height;
            catControl1.BringToFront();
        }

        private void birdButton_Click(object sender, EventArgs e)
        {
            navigationPanel.Height = birdButton.Height;
            birdControl1.BringToFront();
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

        private void SetFormProperties(Form frmSubForm)
        {
            frmSubForm.TopLevel = false;
            frmSubForm.AutoScroll = true;
            frmSubForm.Dock = DockStyle.Fill;
            this.navigationPanel.Controls.Add(frmSubForm);
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






    }
}
