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
    public partial class CheckOut : Form
    {
        CheckOut frmcheckOut = null;
        public CheckOut()
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
                MessageBox.Show("Order Taken");
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
                frmcheckOut = new CheckOut();
                SetFormProperties(frmcheckOut);
            }
            ShowForm(frmcheckOut);
        }
        private void SetFormProperties(Form frmSubForm)
        {
            frmSubForm.TopLevel = false;
            frmSubForm.AutoScroll = true;
            frmSubForm.Dock = DockStyle.Fill;
            this.itemsPanel.Controls.Add(frmSubForm);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBoxTopLeft.Image = Image.FromFile
            (System.Environment.GetFolderPath
            (System.Environment.SpecialFolder.MyPictures)
             + @"\catsz.jpg");
            var lblnew = new Label
            {
                Location = new Point(41, 71),
                Text = "$400",
                AutoSize = true,
                BackColor = Color.LightGray,
                Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, (byte)0)
            };
            //this refers to current form you can use your container according to requirement
            itemsPanel.Controls.Add(lblnew);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBoxTopRight.Image = Image.FromFile
            (System.Environment.GetFolderPath
            (System.Environment.SpecialFolder.MyPictures)
             + @"\pugs.jpg");
            var lblnew = new Label
            {
                Location = new Point(172, 71),
                Text = "$400",
                AutoSize = true,
                BackColor = Color.LightGray,
                Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, (byte)0)
            };
            //this refers to current form you can use your container according to requirement
            itemsPanel.Controls.Add(lblnew);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBoxBotRight.Image = Image.FromFile
            (System.Environment.GetFolderPath
            (System.Environment.SpecialFolder.MyPictures)
             + @"\zzzzzzzzz.jpg");
            var lblnew = new Label
            {
                Location = new Point(179, 176),
                Text = "$200",
                AutoSize = true,
                BackColor = Color.LightGray,
                Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, (byte)0)
            };
            //this refers to current form you can use your container according to requirement
            itemsPanel.Controls.Add(lblnew);
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBoxBotLeft.Image = Image.FromFile
            (System.Environment.GetFolderPath
            (System.Environment.SpecialFolder.MyPictures)
             + @"\Budgerigar.jpg");
            var lblnew = new Label
            {
                Location = new Point(40, 176),
                Text = "$150",
                AutoSize = true,
                BackColor = Color.LightGray,
                Font = new Font("Microsoft JhengHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, (byte)0)
            };
            //this refers to current form you can use your container according to requirement
            itemsPanel.Controls.Add(lblnew);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ccNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBoxTopLeft.Image = null;
            pictureBoxTopLeft.Image = null;
            pictureBoxTopRight.Image = null;
            pictureBoxBotRight.Image = null;
            pictureBoxBotLeft.Image = null;
            itemsPanel.Controls.Clear();
        }
    }
}
