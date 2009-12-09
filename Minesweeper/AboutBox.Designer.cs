namespace Minesweeper
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( AboutBox ) );
            this.okButton = new System.Windows.Forms.Button( );
            this.textBox1 = new System.Windows.Forms.TextBox( );
            this.label1 = new System.Windows.Forms.Label( );
            this.linkLabel1 = new System.Windows.Forms.LinkLabel( );
            this.labelCompanyName = new System.Windows.Forms.Label( );
            this.pictureBox2 = new System.Windows.Forms.PictureBox( );
            this.pictureBox1 = new System.Windows.Forms.PictureBox( );
            this.labelVersion = new System.Windows.Forms.Label( );
            ( (System.ComponentModel.ISupportInitialize)( this.pictureBox2 ) ).BeginInit( );
            ( (System.ComponentModel.ISupportInitialize)( this.pictureBox1 ) ).BeginInit( );
            this.SuspendLayout( );
            // 
            // okButton
            // 
            this.okButton.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point( 691, 423 );
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size( 75, 23 );
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point( 12, 247 );
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size( 397, 199 );
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = resources.GetString( "textBox1.Text" );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 14.25F, ( (System.Drawing.FontStyle)( ( System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline ) ) ), System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.label1.Location = new System.Drawing.Point( 146, 12 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 136, 24 );
            this.label1.TabIndex = 27;
            this.label1.Text = "Minesweeper";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point( 415, 423 );
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size( 169, 13 );
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.everaldo.com/crystal/";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Location = new System.Drawing.Point( 147, 53 );
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size( 35, 13 );
            this.labelCompanyName.TabIndex = 30;
            this.labelCompanyName.Text = "label2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Minesweeper.Properties.Resources.Crystal_splash;
            this.pictureBox2.Location = new System.Drawing.Point( 203, 247 );
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size( 563, 169 );
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Minesweeper.Properties.Resources.clanbomber;
            this.pictureBox1.Location = new System.Drawing.Point( 12, 12 );
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size( 128, 128 );
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point( 147, 36 );
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size( 35, 13 );
            this.labelVersion.TabIndex = 31;
            this.labelVersion.Text = "label2";
            // 
            // AboutBox
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 778, 458 );
            this.Controls.Add( this.labelVersion );
            this.Controls.Add( this.labelCompanyName );
            this.Controls.Add( this.linkLabel1 );
            this.Controls.Add( this.textBox1 );
            this.Controls.Add( this.pictureBox2 );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.pictureBox1 );
            this.Controls.Add( this.okButton );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding( 9 );
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.Load += new System.EventHandler( this.AboutBox_Load );
            ( (System.ComponentModel.ISupportInitialize)( this.pictureBox2 ) ).EndInit( );
            ( (System.ComponentModel.ISupportInitialize)( this.pictureBox1 ) ).EndInit( );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelVersion;
    }
}
