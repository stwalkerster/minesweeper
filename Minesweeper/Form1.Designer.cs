namespace Minesweeper
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( GameForm ) );
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer( );
            this.toolStrip1 = new System.Windows.Forms.ToolStrip( );
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripDropDownButton( );
            this.chooseDifficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.stupidlyHardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.impossibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.insaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.expertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.hardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.mediocreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.easyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.pishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.babyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton( );
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton( );
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout( );
            this.toolStripContainer1.SuspendLayout( );
            this.toolStrip1.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size( 407, 274 );
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point( 0, 0 );
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size( 407, 299 );
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add( this.toolStrip1 );
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange( new System.Windows.Forms.ToolStripItem[ ] {
            this.toolStripSplitButton1,
            this.toolStripButton1,
            this.toolStripButton2} );
            this.toolStrip1.Location = new System.Drawing.Point( 0, 0 );
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size( 407, 25 );
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[ ] {
            this.chooseDifficultyToolStripMenuItem,
            this.stupidlyHardToolStripMenuItem,
            this.impossibleToolStripMenuItem,
            this.insaneToolStripMenuItem,
            this.expertToolStripMenuItem,
            this.hardToolStripMenuItem,
            this.mediocreToolStripMenuItem,
            this.easyToolStripMenuItem,
            this.pishToolStripMenuItem,
            this.babyToolStripMenuItem} );
            this.toolStripSplitButton1.Image = ( (System.Drawing.Image)( resources.GetObject( "toolStripSplitButton1.Image" ) ) );
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size( 94, 22 );
            this.toolStripSplitButton1.Text = "New Game";
            // 
            // chooseDifficultyToolStripMenuItem
            // 
            this.chooseDifficultyToolStripMenuItem.Enabled = false;
            this.chooseDifficultyToolStripMenuItem.Name = "chooseDifficultyToolStripMenuItem";
            this.chooseDifficultyToolStripMenuItem.Size = new System.Drawing.Size( 168, 22 );
            this.chooseDifficultyToolStripMenuItem.Text = "Choose Difficulty:";
            // 
            // stupidlyHardToolStripMenuItem
            // 
            this.stupidlyHardToolStripMenuItem.Name = "stupidlyHardToolStripMenuItem";
            this.stupidlyHardToolStripMenuItem.Size = new System.Drawing.Size( 168, 22 );
            this.stupidlyHardToolStripMenuItem.Text = "Stupidly Hard";
            this.stupidlyHardToolStripMenuItem.Click += new System.EventHandler( this.stupidlyHardToolStripMenuItem_Click );
            // 
            // impossibleToolStripMenuItem
            // 
            this.impossibleToolStripMenuItem.Name = "impossibleToolStripMenuItem";
            this.impossibleToolStripMenuItem.Size = new System.Drawing.Size( 168, 22 );
            this.impossibleToolStripMenuItem.Text = "Impossible";
            this.impossibleToolStripMenuItem.Click += new System.EventHandler( this.impossibleToolStripMenuItem_Click );
            // 
            // insaneToolStripMenuItem
            // 
            this.insaneToolStripMenuItem.Name = "insaneToolStripMenuItem";
            this.insaneToolStripMenuItem.Size = new System.Drawing.Size( 168, 22 );
            this.insaneToolStripMenuItem.Text = "Insane";
            this.insaneToolStripMenuItem.Click += new System.EventHandler( this.insaneToolStripMenuItem_Click );
            // 
            // expertToolStripMenuItem
            // 
            this.expertToolStripMenuItem.Name = "expertToolStripMenuItem";
            this.expertToolStripMenuItem.Size = new System.Drawing.Size( 168, 22 );
            this.expertToolStripMenuItem.Text = "Expert";
            this.expertToolStripMenuItem.Click += new System.EventHandler( this.expertToolStripMenuItem_Click );
            // 
            // hardToolStripMenuItem
            // 
            this.hardToolStripMenuItem.Name = "hardToolStripMenuItem";
            this.hardToolStripMenuItem.Size = new System.Drawing.Size( 168, 22 );
            this.hardToolStripMenuItem.Text = "Hard";
            this.hardToolStripMenuItem.Click += new System.EventHandler( this.hardToolStripMenuItem_Click );
            // 
            // mediocreToolStripMenuItem
            // 
            this.mediocreToolStripMenuItem.Name = "mediocreToolStripMenuItem";
            this.mediocreToolStripMenuItem.Size = new System.Drawing.Size( 168, 22 );
            this.mediocreToolStripMenuItem.Text = "Mediocre";
            this.mediocreToolStripMenuItem.Click += new System.EventHandler( this.mediocreToolStripMenuItem_Click );
            // 
            // easyToolStripMenuItem
            // 
            this.easyToolStripMenuItem.Name = "easyToolStripMenuItem";
            this.easyToolStripMenuItem.Size = new System.Drawing.Size( 168, 22 );
            this.easyToolStripMenuItem.Text = "Easy";
            this.easyToolStripMenuItem.Click += new System.EventHandler( this.easyToolStripMenuItem_Click );
            // 
            // pishToolStripMenuItem
            // 
            this.pishToolStripMenuItem.Name = "pishToolStripMenuItem";
            this.pishToolStripMenuItem.Size = new System.Drawing.Size( 168, 22 );
            this.pishToolStripMenuItem.Text = "Pish";
            this.pishToolStripMenuItem.Click += new System.EventHandler( this.pishToolStripMenuItem_Click );
            // 
            // babyToolStripMenuItem
            // 
            this.babyToolStripMenuItem.Name = "babyToolStripMenuItem";
            this.babyToolStripMenuItem.Size = new System.Drawing.Size( 168, 22 );
            this.babyToolStripMenuItem.Text = "Baby";
            this.babyToolStripMenuItem.Click += new System.EventHandler( this.babyToolStripMenuItem_Click );
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ( (System.Drawing.Image)( resources.GetObject( "toolStripButton1.Image" ) ) );
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size( 50, 22 );
            this.toolStripButton1.Text = "END";
            this.toolStripButton1.Click += new System.EventHandler( this.toolStripButton1_Click );
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.Image = ( (System.Drawing.Image)( resources.GetObject( "toolStripButton2.Image" ) ) );
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size( 60, 22 );
            this.toolStripButton2.Text = "About";
            this.toolStripButton2.Click += new System.EventHandler( this.toolStripButton2_Click );
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 407, 299 );
            this.Controls.Add( this.toolStripContainer1 );
            this.Name = "GameForm";
            this.Text = "Form1";
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout( false );
            this.toolStripContainer1.TopToolStripPanel.PerformLayout( );
            this.toolStripContainer1.ResumeLayout( false );
            this.toolStripContainer1.PerformLayout( );
            this.toolStrip1.ResumeLayout( false );
            this.toolStrip1.PerformLayout( );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem stupidlyHardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impossibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediocreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem easyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem babyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseDifficultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

