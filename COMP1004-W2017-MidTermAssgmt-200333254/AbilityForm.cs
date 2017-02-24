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
        

        public AbilityForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method generate random number in the textboxes
        /// by using Roll3D10 method.
        /// converting to ToString
        /// </summary>
        private void _generateAbilities()
        {
            STRTextBox.Text = this.Roll3D10().ToString();
            DEXTextBox.Text = this.Roll3D10().ToString();
            ENDTextBox.Text = this.Roll3D10().ToString();
            INTTextBox.Text = this.Roll3D10().ToString();
            PERTextBox.Text = this.Roll3D10().ToString();
            CHATextBox.Text = this.Roll3D10().ToString();
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
        /// This method calls the _generateAbilities method
        /// when roll button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RollButton_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(Roll3D10().ToString());

            _generateAbilities();
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

            // Show the next form
            raceForm.Show();

            // Hide the form
            this.Hide();
        }
    }
}
