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
    public partial class FinalForm : Form
    {
        // Create a reference to the previous form
        public JobForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            // Show the Font Dialog
            fontDialog.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing... Your Information is in process.", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();

            aboutForm.ShowDialog();
        }
    }
}
