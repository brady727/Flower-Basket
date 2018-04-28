﻿namespace Florae_Basket
{
	partial class ChangeFlowerGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeFlowerGUI));
            this.englishNameLbl = new System.Windows.Forms.Label();
            this.englishNameEntryBox = new System.Windows.Forms.TextBox();
            this.changeFlowerSubmit = new System.Windows.Forms.Button();
            this.ChangeToFlowerProfileBtn = new System.Windows.Forms.Button();
            this.botanicalFamLbl = new System.Windows.Forms.Label();
            this.botanicalFamEntryBox = new System.Windows.Forms.TextBox();
            this.notesLbl = new System.Windows.Forms.Label();
            this.imgPathLbl = new System.Windows.Forms.Label();
            this.imgPathView = new System.Windows.Forms.Label();
            this.noteEntryBox = new System.Windows.Forms.RichTextBox();
            this.uploadImgBtn = new System.Windows.Forms.Button();
            this.latinNameEntryBox = new System.Windows.Forms.TextBox();
            this.latinNameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // englishNameLbl
            // 
            this.englishNameLbl.AutoSize = true;
            this.englishNameLbl.Location = new System.Drawing.Point(44, 53);
            this.englishNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.englishNameLbl.Name = "englishNameLbl";
            this.englishNameLbl.Size = new System.Drawing.Size(75, 13);
            this.englishNameLbl.TabIndex = 4;
            this.englishNameLbl.Text = "English Name:";
            // 
            // englishNameEntryBox
            // 
            this.englishNameEntryBox.Location = new System.Drawing.Point(156, 53);
            this.englishNameEntryBox.Margin = new System.Windows.Forms.Padding(2);
            this.englishNameEntryBox.Name = "englishNameEntryBox";
            this.englishNameEntryBox.Size = new System.Drawing.Size(216, 20);
            this.englishNameEntryBox.TabIndex = 0;
            // 
            // changeFlowerSubmit
            // 
            this.changeFlowerSubmit.Location = new System.Drawing.Point(156, 353);
            this.changeFlowerSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.changeFlowerSubmit.Name = "changeFlowerSubmit";
            this.changeFlowerSubmit.Size = new System.Drawing.Size(75, 28);
            this.changeFlowerSubmit.TabIndex = 5;
            this.changeFlowerSubmit.Text = "Update!";
            this.changeFlowerSubmit.UseVisualStyleBackColor = true;
            this.changeFlowerSubmit.Click += new System.EventHandler(this.changeFlowerSubmit_Click);
            // 
            // ChangeToFlowerProfileBtn
            // 
            this.ChangeToFlowerProfileBtn.Location = new System.Drawing.Point(120, 411);
            this.ChangeToFlowerProfileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ChangeToFlowerProfileBtn.Name = "ChangeToFlowerProfileBtn";
            this.ChangeToFlowerProfileBtn.Size = new System.Drawing.Size(149, 23);
            this.ChangeToFlowerProfileBtn.TabIndex = 6;
            this.ChangeToFlowerProfileBtn.Text = "Return to Flower Profile";
            this.ChangeToFlowerProfileBtn.UseVisualStyleBackColor = true;
            this.ChangeToFlowerProfileBtn.Click += new System.EventHandler(this.ChangeToFlowerProfileBtn_Click);
            // 
            // botanicalFamLbl
            // 
            this.botanicalFamLbl.AutoSize = true;
            this.botanicalFamLbl.Location = new System.Drawing.Point(44, 139);
            this.botanicalFamLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.botanicalFamLbl.Name = "botanicalFamLbl";
            this.botanicalFamLbl.Size = new System.Drawing.Size(86, 13);
            this.botanicalFamLbl.TabIndex = 6;
            this.botanicalFamLbl.Text = "Botanical Family:";
            // 
            // botanicalFamEntryBox
            // 
            this.botanicalFamEntryBox.Location = new System.Drawing.Point(156, 139);
            this.botanicalFamEntryBox.Margin = new System.Windows.Forms.Padding(2);
            this.botanicalFamEntryBox.Name = "botanicalFamEntryBox";
            this.botanicalFamEntryBox.Size = new System.Drawing.Size(216, 20);
            this.botanicalFamEntryBox.TabIndex = 2;
            // 
            // notesLbl
            // 
            this.notesLbl.AutoSize = true;
            this.notesLbl.Location = new System.Drawing.Point(44, 242);
            this.notesLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.notesLbl.Name = "notesLbl";
            this.notesLbl.Size = new System.Drawing.Size(38, 13);
            this.notesLbl.TabIndex = 12;
            this.notesLbl.Text = "Notes:";
            // 
            // imgPathLbl
            // 
            this.imgPathLbl.AutoSize = true;
            this.imgPathLbl.Location = new System.Drawing.Point(44, 292);
            this.imgPathLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.imgPathLbl.Name = "imgPathLbl";
            this.imgPathLbl.Size = new System.Drawing.Size(64, 13);
            this.imgPathLbl.TabIndex = 13;
            this.imgPathLbl.Text = "Image Path:";
            // 
            // imgPathView
            // 
            this.imgPathView.AutoSize = true;
            this.imgPathView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPathView.Location = new System.Drawing.Point(154, 292);
            this.imgPathView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.imgPathView.MinimumSize = new System.Drawing.Size(113, 17);
            this.imgPathView.Name = "imgPathView";
            this.imgPathView.Size = new System.Drawing.Size(113, 17);
            this.imgPathView.TabIndex = 14;
            this.imgPathView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // noteEntryBox
            // 
            this.noteEntryBox.Location = new System.Drawing.Point(156, 178);
            this.noteEntryBox.Margin = new System.Windows.Forms.Padding(2);
            this.noteEntryBox.Name = "noteEntryBox";
            this.noteEntryBox.Size = new System.Drawing.Size(216, 79);
            this.noteEntryBox.TabIndex = 3;
            this.noteEntryBox.Text = "";
            // 
            // uploadImgBtn
            // 
            this.uploadImgBtn.Location = new System.Drawing.Point(46, 316);
            this.uploadImgBtn.Margin = new System.Windows.Forms.Padding(2);
            this.uploadImgBtn.Name = "uploadImgBtn";
            this.uploadImgBtn.Size = new System.Drawing.Size(56, 19);
            this.uploadImgBtn.TabIndex = 4;
            this.uploadImgBtn.Text = "Browse...";
            this.uploadImgBtn.UseVisualStyleBackColor = true;
            this.uploadImgBtn.Click += new System.EventHandler(this.uploadImgBtn_Click);
            // 
            // latinNameEntryBox
            // 
            this.latinNameEntryBox.Location = new System.Drawing.Point(156, 97);
            this.latinNameEntryBox.Margin = new System.Windows.Forms.Padding(2);
            this.latinNameEntryBox.Name = "latinNameEntryBox";
            this.latinNameEntryBox.Size = new System.Drawing.Size(216, 20);
            this.latinNameEntryBox.TabIndex = 1;
            // 
            // latinNameLbl
            // 
            this.latinNameLbl.AutoSize = true;
            this.latinNameLbl.Location = new System.Drawing.Point(44, 97);
            this.latinNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.latinNameLbl.Name = "latinNameLbl";
            this.latinNameLbl.Size = new System.Drawing.Size(64, 13);
            this.latinNameLbl.TabIndex = 18;
            this.latinNameLbl.Text = "Latin Name:";
            // 
            // ChangeFlowerGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 455);
            this.Controls.Add(this.latinNameLbl);
            this.Controls.Add(this.latinNameEntryBox);
            this.Controls.Add(this.uploadImgBtn);
            this.Controls.Add(this.noteEntryBox);
            this.Controls.Add(this.imgPathView);
            this.Controls.Add(this.imgPathLbl);
            this.Controls.Add(this.notesLbl);
            this.Controls.Add(this.ChangeToFlowerProfileBtn);
            this.Controls.Add(this.changeFlowerSubmit);
            this.Controls.Add(this.botanicalFamEntryBox);
            this.Controls.Add(this.englishNameEntryBox);
            this.Controls.Add(this.botanicalFamLbl);
            this.Controls.Add(this.englishNameLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ChangeFlowerGUI";
            this.Text = "Florae Basket";
            this.Load += new System.EventHandler(this.ChangeFlowerGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label englishNameLbl;
		private System.Windows.Forms.TextBox englishNameEntryBox;
		private System.Windows.Forms.Button changeFlowerSubmit;
		private System.Windows.Forms.Button ChangeToFlowerProfileBtn;
		private System.Windows.Forms.Label botanicalFamLbl;
		private System.Windows.Forms.TextBox botanicalFamEntryBox;
		private System.Windows.Forms.Label notesLbl;
		private System.Windows.Forms.Label imgPathLbl;
		private System.Windows.Forms.Label imgPathView;
		private System.Windows.Forms.RichTextBox noteEntryBox;
		private System.Windows.Forms.Button uploadImgBtn;
		private System.Windows.Forms.TextBox latinNameEntryBox;
		private System.Windows.Forms.Label latinNameLbl;
	}
}