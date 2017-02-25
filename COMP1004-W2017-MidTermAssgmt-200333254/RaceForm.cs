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

        public int STR;
        public int DEX;
        public int END;
        public int INT;
        public int PER;
        public int CHA;

        public RaceForm()
        {
            InitializeComponent();
        }

        private void HumanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Human1;
            
            if (HumanRadioButton.Checked)
            {
                STR += 5;
                DEX += 5;
                END += 5;
                INT += 5;
                PER += 5;
                CHA += 5;
                RacialBonusTextBox.Text = "Increase all abilities by 5";
            }
            else
            {
                STR -= 5;
                DEX -= 5;
                END -= 5;
                INT -= 5;
                PER -= 5;
                CHA -= 5;
            }
        }

        private void DwarfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Dwarf1;
            
            if (DwarfRadioButton.Checked)
            {
                STR += 20;
                PER += 20;
                CHA = (CHA - 10 < 3) ? 3 : CHA - 10;
                RacialBonusTextBox.Text = "Increase STR and PER by 20 & Decrease STR by 10";
            }
            else
            {
                STR -= 20;
                PER -= 20;
                CHA += 10;
            }
        }

        private void ElfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Elf1;
            
            if (ElfRadioButton.Checked)
            {
                DEX += 15;
                CHA += 15;
                RacialBonusTextBox.Text = "Increase DEX & CHA by 15";
            }
            else
            {
                DEX -= 15;
                CHA -= 15;
            }
        }

        private void HalflingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Halfling2;
            
            if (HalflingRadioButton.Checked)
            {
                DEX += 20;
                INT += 20;
                STR = (STR - 10 < 3) ? 3 : STR - 10;
                RacialBonusTextBox.Text = "Increase DEX and INT by 20 & Decrease STR by 10";
            }
            else
            {
                DEX -= 20;
                INT -= 20;
                STR += 10;
            }
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
