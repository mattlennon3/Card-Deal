﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Cards
{
    public partial class GameBoard : Form
    {
        public GameBoard()
        {
            InitializeComponent();
        }

        private void blackjackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blackjack blackjack = new Blackjack();
            blackjack.Show();
            this.Hide();
            blackjack.Disposed += new System.EventHandler(GameEnded);
        }

        private void GameEnded(object sender, EventArgs e)
        {
            this.Show();
        }
    }
}
