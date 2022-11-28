namespace Finalproj
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.catdogButton = new System.Windows.Forms.Button();
            this.birdButton = new System.Windows.Forms.Button();
            this.aquaticButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.decorationPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.navigationPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.decorationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPanel
            // 
            this.navigationPanel.Controls.Add(this.exitButton);
            this.navigationPanel.Controls.Add(this.panel3);
            this.navigationPanel.Controls.Add(this.checkOutButton);
            this.navigationPanel.Controls.Add(this.loginButton);
            this.navigationPanel.Controls.Add(this.catdogButton);
            this.navigationPanel.Controls.Add(this.birdButton);
            this.navigationPanel.Controls.Add(this.aquaticButton);
            this.navigationPanel.Controls.Add(this.homeButton);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel.Location = new System.Drawing.Point(0, 0);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(200, 599);
            this.navigationPanel.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitButton.Location = new System.Drawing.Point(0, 491);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(200, 51);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(-3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 134);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(45, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Terb\'s Pet\'s";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // checkOutButton
            // 
            this.checkOutButton.Image = ((System.Drawing.Image)(resources.GetObject("checkOutButton.Image")));
            this.checkOutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkOutButton.Location = new System.Drawing.Point(0, 425);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(200, 51);
            this.checkOutButton.TabIndex = 5;
            this.checkOutButton.Text = "Check Out";
            this.checkOutButton.UseVisualStyleBackColor = true;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Image = ((System.Drawing.Image)(resources.GetObject("loginButton.Image")));
            this.loginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.Location = new System.Drawing.Point(-3, 368);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(200, 51);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login/Register";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // catdogButton
            // 
            this.catdogButton.Image = ((System.Drawing.Image)(resources.GetObject("catdogButton.Image")));
            this.catdogButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.catdogButton.Location = new System.Drawing.Point(0, 196);
            this.catdogButton.Name = "catdogButton";
            this.catdogButton.Size = new System.Drawing.Size(200, 51);
            this.catdogButton.TabIndex = 3;
            this.catdogButton.Text = "Cats/Dogs";
            this.catdogButton.UseVisualStyleBackColor = true;
            this.catdogButton.Click += new System.EventHandler(this.catdogButton_Click);
            // 
            // birdButton
            // 
            this.birdButton.Image = ((System.Drawing.Image)(resources.GetObject("birdButton.Image")));
            this.birdButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.birdButton.Location = new System.Drawing.Point(0, 254);
            this.birdButton.Name = "birdButton";
            this.birdButton.Size = new System.Drawing.Size(200, 51);
            this.birdButton.TabIndex = 2;
            this.birdButton.Text = "Birds";
            this.birdButton.UseVisualStyleBackColor = true;
            this.birdButton.Click += new System.EventHandler(this.birdButton_Click);
            // 
            // aquaticButton
            // 
            this.aquaticButton.Image = ((System.Drawing.Image)(resources.GetObject("aquaticButton.Image")));
            this.aquaticButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.aquaticButton.Location = new System.Drawing.Point(0, 311);
            this.aquaticButton.Name = "aquaticButton";
            this.aquaticButton.Size = new System.Drawing.Size(200, 51);
            this.aquaticButton.TabIndex = 1;
            this.aquaticButton.Text = "Aquatic Animals";
            this.aquaticButton.UseVisualStyleBackColor = true;
            this.aquaticButton.Click += new System.EventHandler(this.aquaticButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(0, 140);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(200, 50);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // decorationPanel
            // 
            this.decorationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(128)))));
            this.decorationPanel.Controls.Add(this.label2);
            this.decorationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.decorationPanel.Location = new System.Drawing.Point(200, 0);
            this.decorationPanel.Name = "decorationPanel";
            this.decorationPanel.Size = new System.Drawing.Size(806, 35);
            this.decorationPanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "The Healthiest Pet\'s in All of Rockford";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(775, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(207, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(384, 120);
            this.label3.TabIndex = 3;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 599);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.decorationPanel);
            this.Controls.Add(this.navigationPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pet Store";
            this.navigationPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.decorationPanel.ResumeLayout(false);
            this.decorationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Panel decorationPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button catdogButton;
        private System.Windows.Forms.Button birdButton;
        private System.Windows.Forms.Button aquaticButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}

