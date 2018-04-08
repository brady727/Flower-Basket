﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Florae_Basket
{
    public partial class AddFlowerGUI : Form
    {

		AddFlowerCtlr guiControllerReference;

        public AddFlowerGUI(AddFlowerCtlr ctlr)
        {

            InitializeComponent();
			guiControllerReference = ctlr;
		}

		private void addFlowerToDBBtn_Click(object sender, EventArgs e)
		{

			// grab the entered English name, Latin name, and botanical family from the text boxes
			string enteredEnglishName = englishNameEntryBox.Text;

			string enteredLatinName = latinNameEntryBox.Text;

			string enteredBotanicalFamily = botanicalFamEntryBox.Text;

			// instantiate a Flower object from the user entries
			Flower flowerToAdd = new Flower(enteredLatinName, enteredEnglishName, enteredBotanicalFamily);

			// checks the database for existence of a Flower object with the same attributes
			string displayedMsg = AddFlowerCtlr.verifyFlower(flowerToAdd);

			MessageBox.Show(displayedMsg);
                
            // flower entry will NOT be added in the GUI; will be added in verifyFlower() using an instantiation of the DBMngr class

                //testDB TDB = new testDB();
                //TDB.addIt(enteredEnglishName, enteredLatinName, enteredBotanicalFamily);
                //MessageBox.Show("Flower successfuly added!");
		
		}

        private void AddToMain_click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Hide();
        }

        private void add_leave_click(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AddFlowerGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            new MainMenu().Show();
        }

        private void AddFlowerGUI_Load(object sender, EventArgs e)
        {

        }
    }
}
