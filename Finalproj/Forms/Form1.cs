using Finalproj.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Finalproj
{
    public partial class Form1 : Form
    {
        CheckOut checkOutfrm = new CheckOut();
        LoginForm loginForm = null;
        SearchForm searchForm = null;
        PetForm petForm = null;
        HomeControl homeControl = new HomeControl();
        BirdControl birdControl = new BirdControl();  
        CheckOut checkOutForm = null;
        CatControl catControl = new CatControl();
        FishControl fishControl = new FishControl();
        DogControl dogControl = new DogControl();
        

        public Form1()
        {
            InitializeComponent();
            //navigationPanel.Height = birdButton.Height;
 
        }


        private void homeButton_Click(object sender, EventArgs e)
        {
            //navigationPanel.Height = homeButton.Height;
            DisplayControl(homeControl);
            //panel1.Controls.Add(homeControl);

        }

        private void catdogButton_Click(object sender, EventArgs e)
        {
            //navigationPanel.Height = catdogButton.Height;
            //catControl1.BringToFront
            DisplayControl(catControl);
        }

        private void birdButton_Click(object sender, EventArgs e)
        {
            //navigationPanel.Height = birdButton.Height;

            DisplayControl(birdControl);
        }

        private void aquaticButton_Click(object sender, EventArgs e)
        {
            DisplayControl(fishControl);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (loginForm == null)
            {
                loginForm = new LoginForm();
                loginForm.TopLevel = false;
                loginForm.AutoScroll = true;
                loginForm.FormBorderStyle = FormBorderStyle.None;
            }
            DisplayControl(loginForm);
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            if (checkOutForm == null)
            {
                checkOutForm = new CheckOut();
                checkOutForm.TopLevel = false;
                checkOutForm.AutoScroll = true;
                checkOutForm.FormBorderStyle = FormBorderStyle.None;
            }
            DisplayControl(checkOutForm);
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

        private void DisplayControl(Control panelControl)
        {
            bool found = false;
            foreach (Control control in this.panel1.Controls)
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
                panel1.Controls.Add(panelControl);
                panelControl.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Controls.Add(homeControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisplayControl(dogControl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (searchForm == null)
            {
                searchForm = new SearchForm();
                searchForm.TopLevel = false;
                searchForm.AutoScroll = true;
                searchForm.FormBorderStyle = FormBorderStyle.None;
            }
            DisplayControl(searchForm);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(petForm == null)
            {
                petForm = new PetForm();
                petForm.TopLevel = false;
                petForm.AutoScroll = true;
                petForm.FormBorderStyle = FormBorderStyle.None;
            }
            DisplayControl(petForm);
        }
    }
}
