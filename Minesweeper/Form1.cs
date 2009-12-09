﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class GameForm : Form
    {
        public GameForm( )
        {
            InitializeComponent( );
        }

        private void stupidlyHardToolStripMenuItem_Click( object sender, EventArgs e )
        {
            startNewGame( Game.Difficulty.STUPIDLYHARD );
        }

        private void impossibleToolStripMenuItem_Click( object sender, EventArgs e )
        {
            startNewGame( Game.Difficulty.IMPOSSIBLE );
        }

        private void insaneToolStripMenuItem_Click( object sender, EventArgs e )
        {
            startNewGame( Game.Difficulty.INSANE );
        }

        private void expertToolStripMenuItem_Click( object sender, EventArgs e )
        {
            startNewGame( Game.Difficulty.EXPERT );
        }

        private void hardToolStripMenuItem_Click( object sender, EventArgs e )
        {
            startNewGame( Game.Difficulty.HARD );
        }

        private void mediocreToolStripMenuItem_Click( object sender, EventArgs e )
        {
            startNewGame( Game.Difficulty.MEDIOCRE );
        }

        private void easyToolStripMenuItem_Click( object sender, EventArgs e )
        {
            startNewGame( Game.Difficulty.EASY );
        }

        private void pishToolStripMenuItem_Click( object sender, EventArgs e )
        {
            startNewGame( Game.Difficulty.PISH );
        }

        private void babyToolStripMenuItem_Click( object sender, EventArgs e )
        {
            startNewGame( Game.Difficulty.BABY );
        }

        void startNewGame( Game.Difficulty difficulty )
        {
            startNewGame( difficulty, 30, 20 );
        }
        void startNewGame( Game.Difficulty difficulty, int width, int height )
        {
            toolStripContainer1.ContentPanel.Controls.Clear( );
            Game game = new Game( width, height, difficulty );
            toolStripContainer1.ContentPanel.Controls.Add( game );
            game.Dock = DockStyle.Fill;
        }

        private void toolStripButton1_Click( object sender, EventArgs e )
        {
            ( (Game)toolStripContainer1.ContentPanel.Controls[ 0 ] ).TriggerAll( );
        }

        private void toolStripButton2_Click( object sender, EventArgs e )
        {
            new AboutBox( ).ShowDialog( );
        }

    }
}