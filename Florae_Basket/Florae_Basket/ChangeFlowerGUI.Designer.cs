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
			this.SuspendLayout();
			// 
			// englishNameLbl
			// 
			this.englishNameLbl.AutoSize = true;
			this.englishNameLbl.Location = new System.Drawing.Point(59, 65);
			this.englishNameLbl.Name = "englishNameLbl";
			this.englishNameLbl.Size = new System.Drawing.Size(99, 17);
			this.englishNameLbl.TabIndex = 4;
			this.englishNameLbl.Text = "English Name:";
			// 
			// englishNameEntryBox
			// 
			this.englishNameEntryBox.Location = new System.Drawing.Point(208, 65);
			this.englishNameEntryBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.englishNameEntryBox.Name = "englishNameEntryBox";
			this.englishNameEntryBox.Size = new System.Drawing.Size(287, 22);
			this.englishNameEntryBox.TabIndex = 7;
			// 
			// changeFlowerSubmit
			// 
			this.changeFlowerSubmit.Location = new System.Drawing.Point(208, 389);
			this.changeFlowerSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.changeFlowerSubmit.Name = "changeFlowerSubmit";
			this.changeFlowerSubmit.Size = new System.Drawing.Size(100, 34);
			this.changeFlowerSubmit.TabIndex = 10;
			this.changeFlowerSubmit.Text = "Update!";
			this.changeFlowerSubmit.UseVisualStyleBackColor = true;
			this.changeFlowerSubmit.Click += new System.EventHandler(this.changeFlowerSubmit_Click);
			// 
			// ChangeToFlowerProfileBtn
			// 
			this.ChangeToFlowerProfileBtn.Location = new System.Drawing.Point(160, 460);
			this.ChangeToFlowerProfileBtn.Name = "ChangeToFlowerProfileBtn";
			this.ChangeToFlowerProfileBtn.Size = new System.Drawing.Size(199, 28);
			this.ChangeToFlowerProfileBtn.TabIndex = 11;
			this.ChangeToFlowerProfileBtn.Text = "Return to Flower Profile";
			this.ChangeToFlowerProfileBtn.UseVisualStyleBackColor = true;
			this.ChangeToFlowerProfileBtn.Click += new System.EventHandler(this.ChangeToFlowerProfileBtn_Click);
			// 
			// botanicalFamLbl
			// 
			this.botanicalFamLbl.AutoSize = true;
			this.botanicalFamLbl.Location = new System.Drawing.Point(59, 123);
			this.botanicalFamLbl.Name = "botanicalFamLbl";
			this.botanicalFamLbl.Size = new System.Drawing.Size(114, 17);
			this.botanicalFamLbl.TabIndex = 6;
			this.botanicalFamLbl.Text = "Botanical Family:";
			// 
			// botanicalFamEntryBox
			// 
			this.botanicalFamEntryBox.Location = new System.Drawing.Point(208, 123);
			this.botanicalFamEntryBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.botanicalFamEntryBox.Name = "botanicalFamEntryBox";
			this.botanicalFamEntryBox.Size = new System.Drawing.Size(287, 22);
			this.botanicalFamEntryBox.TabIndex = 9;
			// 
			// notesLbl
			// 
			this.notesLbl.AutoSize = true;
			this.notesLbl.Location = new System.Drawing.Point(59, 262);
			this.notesLbl.Name = "notesLbl";
			this.notesLbl.Size = new System.Drawing.Size(49, 17);
			this.notesLbl.TabIndex = 12;
			this.notesLbl.Text = "Notes:";
			// 
			// imgPathLbl
			// 
			this.imgPathLbl.AutoSize = true;
			this.imgPathLbl.Location = new System.Drawing.Point(59, 310);
			this.imgPathLbl.Name = "imgPathLbl";
			this.imgPathLbl.Size = new System.Drawing.Size(83, 17);
			this.imgPathLbl.TabIndex = 13;
			this.imgPathLbl.Text = "Image Path:";
			// 
			// imgPathView
			// 
			this.imgPathView.AutoSize = true;
			this.imgPathView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.imgPathView.Location = new System.Drawing.Point(209, 310);
			this.imgPathView.MinimumSize = new System.Drawing.Size(150, 20);
			this.imgPathView.Name = "imgPathView";
			this.imgPathView.Size = new System.Drawing.Size(150, 20);
			this.imgPathView.TabIndex = 14;
			this.imgPathView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// noteEntryBox
			// 
			this.noteEntryBox.Location = new System.Drawing.Point(208, 183);
			this.noteEntryBox.Name = "noteEntryBox";
			this.noteEntryBox.Size = new System.Drawing.Size(287, 96);
			this.noteEntryBox.TabIndex = 15;
			this.noteEntryBox.Text = "";
			// 
			// uploadImgBtn
			// 
			this.uploadImgBtn.Location = new System.Drawing.Point(62, 341);
			this.uploadImgBtn.Name = "uploadImgBtn";
			this.uploadImgBtn.Size = new System.Drawing.Size(75, 23);
			this.uploadImgBtn.TabIndex = 16;
			this.uploadImgBtn.Text = "Browse...";
			this.uploadImgBtn.UseVisualStyleBackColor = true;
			this.uploadImgBtn.Click += new System.EventHandler(this.uploadImgBtn_Click);
			// 
			// ChangeFlowerGUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 560);
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
			this.Name = "ChangeFlowerGUI";
			this.Text = "ChangeFlowerGUI";
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
	}
}