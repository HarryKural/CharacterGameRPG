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

        public string STR;
        public string DEX;
        public string END;
        public string INT;
        public string PER;
        public string CHA;
        public string job;

        public JobForm()
        {
            InitializeComponent();
        }

        private void SoldierRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.HealthPointsTextBox.Text = (30 + previousForm.END).ToString();
            job = "Soldier";
        }

        private void RogueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.HealthPointsTextBox.Text = (28 + previousForm.DEX).ToString();
            job = "Rogue";
        }

        private void MagickerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.HealthPointsTextBox.Text = (15 + previousForm.INT).ToString();
            job = "Magicker";
        }

        private void CultistRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.HealthPointsTextBox.Text = (24 + previousForm.CHA).ToString();
            job = "Cultist";
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
