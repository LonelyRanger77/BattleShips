﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShips
{
    public partial class BattleShips : Form
    {
        public BattleShips(string nj)
        {
            InitializeComponent();
            label1.Text = nj;
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {

            

        }
    }
}
