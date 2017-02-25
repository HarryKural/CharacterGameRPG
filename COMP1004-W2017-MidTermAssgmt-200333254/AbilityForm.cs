/// <summary>
/// App name:           Character Generator
/// Author's name:      Harshit Sharma
/// Student Number#:    200333254
/// App Creation Date:  Feb 23, 2017
/// Last Modified Date: Feb 24, 2017
/// App description:    This application generates RPG character.
///                     It displays randomly generated numbers (abilities).
/// Rapid Application Development - MidTerm Assignment
/// </summary>

// using pre-existing libraries
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgmt_200333254
{
    public partial class AbilityForm : Form
    {
        // Random Number object
        Random random = new Random();
        
        // Instantiate List for TextBox
        private List<TextBox> _abilities;
        
        public AbilityForm()
        {
            InitializeComponent();

            // Instantiates a List of Text Boxes
            this._abilities = new List<TextBox>();
            this._initializeAbilities();
        }

        /// <summary>
        /// This method adds all the generated numbers to the textboxes
        /// </summary>
        private void _initializeAbilities()
        {
            this._abilities.Add(STRTextBox);
            this._abilities.Add(DEXTextBox);
            this._abilities.Add(ENDTextBox);
            this._abilities.Add(INTTextBox);
            this._abilities.Add(PERTextBox);
            this._abilities.Add(CHATextBox);
        }

        /// <summary>
        /// This method simulates the rolling of three 10-sided dice
        /// </summary>
        /// <returns>
        /// This method returns a number between 3 and 30 (The result of rolling 3d10)
        /// </returns>
        private int Roll3D10()
        {
            int result = 0;
            for (int dice = 0; dice < 3; dice++)
            {
                result += random.Next(1, 11);
            }
            return result;
        }

        /// <summary>
        /// This method works when roll button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RollButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(Roll3D10().ToString());

            // iterates through the TextBox List (_abilities)
            for (int ability = 0; ability < this._abilities.Count; ability++)
            {
                // assign the current roll to the current ability
                this._abilities[ability].Text = this.Roll3D10().ToString();
            }
        }

        /// <summary>
        /// This method shows the race form and hides the ability form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            // Instantiate an object to the next form
            RaceForm raceForm = new RaceForm();

            // Pass a reference to the current form to the next form
            raceForm.previousForm = this;

            // Setting value of variables to textboxes & parsing to Int
            raceForm.STR = Int16.Parse(this.STRTextBox.Text);
            raceForm.DEX = Int16.Parse(this.DEXTextBox.Text);
            raceForm.END = Int16.Parse(this.ENDTextBox.Text);
            raceForm.INT = Int16.Parse(this.INTTextBox.Text);
            raceForm.PER = Int16.Parse(this.PERTextBox.Text);
            raceForm.CHA = Int16.Parse(this.CHATextBox.Text);

            // Show the next form
            raceForm.Show();

            // Hide the form
            this.Hide();
        }
    }
}
