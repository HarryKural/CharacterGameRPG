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
    public partial class RaceForm : Form
    {
        // Create a reference to the previous form
        public AbilityForm previousForm { get; set; }

        private int _STR;
        private int _DEX;
        private int _END;
        private int _INT;
        private int _PER;
        private int _CHA;

        public RaceForm()
        {
            InitializeComponent();
        }

        private void HumanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Human1;
            RacialBonusTextBox.Text = "Increase all Character abilities by 5";
        }

        private void DwarfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Dwarf1;
            RacialBonusTextBox.Text = "Increase STR and PER by 20 & Decrease STR by 10";
        }

        private void ElfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Elf1;
            RacialBonusTextBox.Text = "Increase DEX and CHA by 15";
        }

        private void HalflingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Halfling2;
            RacialBonusTextBox.Text = "Increase DEX and INT by 20 & Decrease STR by 10";
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            JobForm jobForm = new JobForm();

            jobForm.previousForm = this;

            jobForm.Show();

            this.Hide();
        }
    }
}
