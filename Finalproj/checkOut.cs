using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilityLibrary;

namespace Finalproj
{
    public partial class checkOut : Form
    {
        public checkOut()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button9_Click(object sender, EventArgs e)
        {



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

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
