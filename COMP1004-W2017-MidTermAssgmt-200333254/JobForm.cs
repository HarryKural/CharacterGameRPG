﻿using System;
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

        public JobForm()
        {
            InitializeComponent();
        }
    }
}