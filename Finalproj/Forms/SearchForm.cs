using Finalproj.Controls;
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
    public partial class SearchForm : Form
    {
        public Animals animals = null;
        BirdControl birdControl = new BirdControl();
        CatControl catControl = new CatControl();
        DogControl dogControl = new DogControl();
        FishControl fishControl = new FishControl();

        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == "1")
            {
                DisplayControl(birdControl);
            }
            else if  (textBox1.Text == "2")
            {
                DisplayControl(catControl);
            }
            else if  (textBox1.Text == "3")
            {
                DisplayControl(dogControl);
            }
            else if (textBox1.Text == "4")
            {
                DisplayControl(fishControl);
            }
            else 
            {
                 errorProvider1.SetError(textBox1, "Pet number is required.");
                 e.Cancel = true;
            }

        }
        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBox1, "Type of pet is required.");
                e.Cancel = true;
            }
        }

        private void comboBox2_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox2.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBox2, "Type of pet is required.");
                e.Cancel = true;
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                errorProvider1.SetError(textBox2, "Price of pet is required.");
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void DisplayControl(Control panelControl)
        {
            bool found = false;
            foreach (Control control in this.petPanel.Controls)
            {
                if (control != panelControl)
                    control.Hide();
                else
                {
                    control.Show();
                    found = true;
                }
            }
            if (!found)
            {
                petPanel.Controls.Add(panelControl);
                panelControl.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Controls.Clear();
            comboBox2.Controls.Clear();
        }
    }
}
