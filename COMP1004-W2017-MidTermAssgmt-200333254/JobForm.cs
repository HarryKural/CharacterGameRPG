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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgmt_200333254
{
    public partial class JobForm : Form
    {
        // Create a reference to the previous form
        public RaceForm previousForm { get; set; }

        // Initializing variables
        private int _soldier = 30;
        private int _rogue = 28;
        private int _magicker = 15;
        private int _cultist = 24;

        public JobForm()
        {
            InitializeComponent();
        }

        private void SoldierRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RogueRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MagickerRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CultistRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            FinalForm finalForm = new FinalForm();

            finalForm.previousForm = this;

            finalForm.Show();
        }
    }
}
