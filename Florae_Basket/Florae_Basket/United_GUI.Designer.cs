﻿namespace Florae_Basket
{
    partial class United_GUI
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
            this.Username_txt = new System.Windows.Forms.TextBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SignIn_Title = new System.Windows.Forms.Label();
            this.Login_Title = new System.Windows.Forms.Label();
            this.Login_submit = new System.Windows.Forms.Button();
            this.Incorrect_Login_Warning = new System.Windows.Forms.Label();
            this.LandingPage = new System.Windows.Forms.Panel();
            this.UserControlButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AddFlowerButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.LandingPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // Username_txt
            // 
            this.Username_txt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Username_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_txt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Username_txt.Location = new System.Drawing.Point(490, 302);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.Size = new System.Drawing.Size(274, 26);
            this.Username_txt.TabIndex = 0;
            this.Username_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Password_txt
            // 
            this.Password_txt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Password_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Password_txt.Location = new System.Drawing.Point(490, 371);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(274, 26);
            this.Password_txt.TabIndex = 1;
            this.Password_txt.UseSystemPasswordChar = true;
            this.Password_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(578, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(583, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // SignIn_Title
            // 
            this.SignIn_Title.AutoSize = true;
            this.SignIn_Title.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn_Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SignIn_Title.Location = new System.Drawing.Point(533, 120);
            this.SignIn_Title.Name = "SignIn_Title";
            this.SignIn_Title.Size = new System.Drawing.Size(231, 73);
            this.SignIn_Title.TabIndex = 4;
            this.SignIn_Title.Text = "Sign In";
            this.SignIn_Title.Click += new System.EventHandler(this.SignIn_Title_Click);
            // 
            // Login_Title
            // 
            this.Login_Title.AutoSize = true;
            this.Login_Title.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login_Title.Location = new System.Drawing.Point(439, 47);
            this.Login_Title.Name = "Login_Title";
            this.Login_Title.Size = new System.Drawing.Size(424, 73);
            this.Login_Title.TabIndex = 5;
            this.Login_Title.Text = "Flower Basket";
            // 
            // Login_submit
            // 
            this.Login_submit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Login_submit.Enabled = false;
            this.Login_submit.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_submit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Login_submit.Location = new System.Drawing.Point(530, 457);
            this.Login_submit.Name = "Login_submit";
            this.Login_submit.Size = new System.Drawing.Size(188, 92);
            this.Login_submit.TabIndex = 6;
            this.Login_submit.Text = "Submit";
            this.Login_submit.UseVisualStyleBackColor = false;
            this.Login_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // Incorrect_Login_Warning
            // 
            this.Incorrect_Login_Warning.AutoSize = true;
            this.Incorrect_Login_Warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Incorrect_Login_Warning.ForeColor = System.Drawing.Color.Red;
            this.Incorrect_Login_Warning.Location = new System.Drawing.Point(540, 400);
            this.Incorrect_Login_Warning.Name = "Incorrect_Login_Warning";
            this.Incorrect_Login_Warning.Size = new System.Drawing.Size(178, 20);
            this.Incorrect_Login_Warning.TabIndex = 7;
            this.Incorrect_Login_Warning.Text = "Incorrect Information";
            this.Incorrect_Login_Warning.Visible = false;
            // 
            // LandingPage
            // 
            this.LandingPage.Controls.Add(this.UserControlButton);
            this.LandingPage.Controls.Add(this.SearchButton);
            this.LandingPage.Controls.Add(this.AddFlowerButton);
            this.LandingPage.Location = new System.Drawing.Point(12, 123);
            this.LandingPage.Name = "LandingPage";
            this.LandingPage.Size = new System.Drawing.Size(1284, 529);
            this.LandingPage.TabIndex = 8;
            this.LandingPage.Visible = false;
            // 
            // UserControlButton
            // 
            this.UserControlButton.Enabled = false;
            this.UserControlButton.Location = new System.Drawing.Point(898, 109);
            this.UserControlButton.Name = "UserControlButton";
            this.UserControlButton.Size = new System.Drawing.Size(364, 364);
            this.UserControlButton.TabIndex = 2;
            this.UserControlButton.UseVisualStyleBackColor = true;
            this.UserControlButton.Click += new System.EventHandler(this.UserControlButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Enabled = false;
            this.SearchButton.Location = new System.Drawing.Point(454, 109);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(364, 364);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AddFlowerButton
            // 
            this.AddFlowerButton.Enabled = false;
            this.AddFlowerButton.Location = new System.Drawing.Point(20, 109);
            this.AddFlowerButton.Name = "AddFlowerButton";
            this.AddFlowerButton.Size = new System.Drawing.Size(364, 364);
            this.AddFlowerButton.TabIndex = 0;
            this.AddFlowerButton.UseVisualStyleBackColor = true;
            this.AddFlowerButton.Click += new System.EventHandler(this.AddFlowerButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Enabled = false;
            this.LogOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.Location = new System.Drawing.Point(1188, 12);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(108, 39);
            this.LogOutButton.TabIndex = 9;
            this.LogOutButton.Text = "Sign Out";
            this.LogOutButton.UseVisualStyleBackColor = true;
            this.LogOutButton.Visible = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // United_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1308, 664);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.LandingPage);
            this.Controls.Add(this.Incorrect_Login_Warning);
            this.Controls.Add(this.Login_submit);
            this.Controls.Add(this.Login_Title);
            this.Controls.Add(this.SignIn_Title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.Username_txt);
            this.Name = "United_GUI";
            this.Text = "United_GUI";
            this.LandingPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SignIn_Title;
        private System.Windows.Forms.Label Login_Title;
        private System.Windows.Forms.Button Login_submit;
        private System.Windows.Forms.Label Incorrect_Login_Warning;
        private System.Windows.Forms.Panel LandingPage;
        private System.Windows.Forms.Button UserControlButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button AddFlowerButton;
        private System.Windows.Forms.Button LogOutButton;
    }
}