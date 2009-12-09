using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    class Square : System.Windows.Forms.Button
    {
        bool _isMine;

        public const int SIZE = 20;

        public bool isMine
        {
            get
            {
                return _isMine;
            }
            private set
            {
                _isMine = value;
            }
        }

        public Square(int xPos, int yPos , Game.Difficulty d)
        {
            if( Program.random( (int)d ) == 0 )
            {
                isMine = true;
                this.BackColor = System.Drawing.Color.Red;
            }

            this.Width = SIZE;
            this.Height = SIZE;
            this.Left = xPos * SIZE;
            this.Top = yPos * SIZE;
            this.Text = "8";
            this.Font = new System.Drawing.Font( new System.Drawing.FontFamily( System.Drawing.Text.GenericFontFamilies.Monospace ), 10, System.Drawing.FontStyle.Bold );
        }

        protected override void OnClick( EventArgs e )
        {
            base.OnClick( e );
        }
    }
}
