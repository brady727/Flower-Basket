﻿namespace Florae_Basket
{
    partial class ImageSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageSearch));
            this.searchButton = new System.Windows.Forms.Button();
            this.imgSelectLabel = new System.Windows.Forms.Label();
            this.imgSelectButton = new System.Windows.Forms.Button();
            this.imgNoteLabel = new System.Windows.Forms.Label();
            this.wordSearchSelect = new System.Windows.Forms.CheckBox();
            this.wordSearchBox = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.chiLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.redButton = new System.Windows.Forms.RadioButton();
            this.blueButton = new System.Windows.Forms.RadioButton();
            this.greenButton = new System.Windows.Forms.RadioButton();
            this.freqColorCheckBox = new System.Windows.Forms.CheckBox();
            this.returnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(192, 328);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(103, 34);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // imgSelectLabel
            // 
            this.imgSelectLabel.AutoSize = true;
            this.imgSelectLabel.Location = new System.Drawing.Point(58, 60);
            this.imgSelectLabel.Name = "imgSelectLabel";
            this.imgSelectLabel.Size = new System.Drawing.Size(197, 13);
            this.imgSelectLabel.TabIndex = 1;
            this.imgSelectLabel.Text = "Select an image file to search by image: ";
            // 
            // imgSelectButton
            // 
            this.imgSelectButton.Location = new System.Drawing.Point(291, 60);
            this.imgSelectButton.Name = "imgSelectButton";
            this.imgSelectButton.Size = new System.Drawing.Size(103, 48);
            this.imgSelectButton.TabIndex = 2;
            this.imgSelectButton.Text = "Select Image File";
            this.imgSelectButton.UseVisualStyleBackColor = true;
            this.imgSelectButton.Click += new System.EventHandler(this.imgSelectButton_Click);
            // 
            // imgNoteLabel
            // 
            this.imgNoteLabel.AutoSize = true;
            this.imgNoteLabel.Location = new System.Drawing.Point(61, 78);
            this.imgNoteLabel.Name = "imgNoteLabel";
            this.imgNoteLabel.Size = new System.Drawing.Size(176, 13);
            this.imgNoteLabel.TabIndex = 3;
            this.imgNoteLabel.Text = "Note: Must be in .jpeg, .png, or .gif  ";
            this.imgNoteLabel.Click += new System.EventHandler(this.imgNoteLabel_Click);
            // 
            // wordSearchSelect
            // 
            this.wordSearchSelect.AutoSize = true;
            this.wordSearchSelect.Location = new System.Drawing.Point(61, 201);
            this.wordSearchSelect.Name = "wordSearchSelect";
            this.wordSearchSelect.Size = new System.Drawing.Size(201, 17);
            this.wordSearchSelect.TabIndex = 4;
            this.wordSearchSelect.Text = "Combine with Word Search (optional)";
            this.wordSearchSelect.UseVisualStyleBackColor = true;
            this.wordSearchSelect.Visible = false;
            this.wordSearchSelect.CheckedChanged += new System.EventHandler(this.wordSearchSelect_CheckedChanged);
            // 
            // wordSearchBox
            // 
            this.wordSearchBox.Location = new System.Drawing.Point(291, 201);
            this.wordSearchBox.Name = "wordSearchBox";
            this.wordSearchBox.Size = new System.Drawing.Size(103, 20);
            this.wordSearchBox.TabIndex = 5;
            this.wordSearchBox.Visible = false;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(58, 157);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(253, 13);
            this.errorLabel.TabIndex = 8;
            this.errorLabel.Text = "You closed out of the File Selector. Please try again!";
            this.errorLabel.Visible = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(464, 25);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(181, 173);
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Match Indexes:";
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.Location = new System.Drawing.Point(534, 295);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(0, 13);
            this.resultsLabel.TabIndex = 11;
            // 
            // chiLabel
            // 
            this.chiLabel.AutoSize = true;
            this.chiLabel.Location = new System.Drawing.Point(432, 367);
            this.chiLabel.Name = "chiLabel";
            this.chiLabel.Size = new System.Drawing.Size(259, 13);
            this.chiLabel.TabIndex = 12;
            this.chiLabel.Text = "Chi-Square Values (0 is best, 1 or above is very poor):";
            this.chiLabel.Click += new System.EventHandler(this.chiLabel_Click);
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(432, 399);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(42, 13);
            this.valueLabel.TabIndex = 13;
            this.valueLabel.Text = "Values:";
            // 
            // redButton
            // 
            this.redButton.AutoSize = true;
            this.redButton.Location = new System.Drawing.Point(61, 279);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(45, 17);
            this.redButton.TabIndex = 14;
            this.redButton.TabStop = true;
            this.redButton.Text = "Red";
            this.redButton.UseVisualStyleBackColor = true;
            this.redButton.CheckedChanged += new System.EventHandler(this.redButton_CheckedChanged);
            // 
            // blueButton
            // 
            this.blueButton.AutoSize = true;
            this.blueButton.Location = new System.Drawing.Point(137, 279);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(46, 17);
            this.blueButton.TabIndex = 15;
            this.blueButton.TabStop = true;
            this.blueButton.Text = "Blue";
            this.blueButton.UseVisualStyleBackColor = true;
            // 
            // greenButton
            // 
            this.greenButton.AutoSize = true;
            this.greenButton.Location = new System.Drawing.Point(209, 279);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(54, 17);
            this.greenButton.TabIndex = 16;
            this.greenButton.TabStop = true;
            this.greenButton.Text = "Green";
            this.greenButton.UseVisualStyleBackColor = true;
            // 
            // freqColorCheckBox
            // 
            this.freqColorCheckBox.AutoSize = true;
            this.freqColorCheckBox.Location = new System.Drawing.Point(61, 244);
            this.freqColorCheckBox.Name = "freqColorCheckBox";
            this.freqColorCheckBox.Size = new System.Drawing.Size(277, 17);
            this.freqColorCheckBox.TabIndex = 17;
            this.freqColorCheckBox.Text = "Enter a specified color to narrow the search (optional)";
            this.freqColorCheckBox.UseVisualStyleBackColor = true;
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(61, 329);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 33);
            this.returnButton.TabIndex = 18;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // ImageSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 439);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.freqColorCheckBox);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.chiLabel);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.wordSearchBox);
            this.Controls.Add(this.wordSearchSelect);
            this.Controls.Add(this.imgNoteLabel);
            this.Controls.Add(this.imgSelectButton);
            this.Controls.Add(this.imgSelectLabel);
            this.Controls.Add(this.searchButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Florae Basket";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImageSearch_FormClosing);
            this.Load += new System.EventHandler(this.ImageSearch_Load);
            this.Shown += new System.EventHandler(this.ImageSearch_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label imgSelectLabel;
        private System.Windows.Forms.Button imgSelectButton;
        private System.Windows.Forms.Label imgNoteLabel;
        private System.Windows.Forms.CheckBox wordSearchSelect;
        private System.Windows.Forms.TextBox wordSearchBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.Label chiLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.RadioButton redButton;
        private System.Windows.Forms.RadioButton blueButton;
        private System.Windows.Forms.RadioButton greenButton;
        private System.Windows.Forms.CheckBox freqColorCheckBox;
        private System.Windows.Forms.Button returnButton;
    }
}

