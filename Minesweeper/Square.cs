using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace Minesweeper
{
    class Square : System.Windows.Forms.CheckBox
    {
        bool _isMine;
        int _surroundingCount, _X, _Y;

        bool _isFlagged = false;

        public bool isFlagged
        {
            get
            {
                return _isFlagged;
            }
            set
            {
                _isFlagged = value;
            }
        }

        public const int SIZE = 25;

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

        public int surroundingCount
        {
            get
            {
                return _surroundingCount;
            }
            set
            {
                if( value < 9 )
                {
                    _surroundingCount = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException( );
                }
            }
        }

        public Square( int xPos, int yPos, Game.Difficulty d )
        {
            if( Program.random( (int)d ) == 0 )
            {
                isMine = true;
            }

            this.FlatStyle = FlatStyle.Popup;
            this.Appearance = Appearance.Button;
            this.AutoCheck = false;
            this.BackColor = Color.Green;

            this.Width = SIZE;
            this.Height = SIZE;
            this.Left = xPos * SIZE;
            this.Top = yPos * SIZE;
            this.Font = new System.Drawing.Font( new System.Drawing.FontFamily( System.Drawing.Text.GenericFontFamilies.SansSerif ), 10, System.Drawing.FontStyle.Bold );

            _X = xPos;
            _Y = yPos;



            ContextMenuStrip = new ContextMenuStrip( );

            EventHandler ehDig = new EventHandler( Menu_Dig );
            ContextMenuStrip.Items.Add( new ToolStripMenuItem( "Dig", Minesweeper.Properties.Resources.down, ehDig ) );

        
            EventHandler ehFlag = new EventHandler( Menu_Flag );
            ContextMenuStrip.Items.Add( new ToolStripMenuItem( "Flag", Minesweeper.Properties.Resources.flag, ehFlag ) );
        }

        void Menu_Dig( object sender, EventArgs e )
        {
            Trigger( );
            if( this.isMine )
                MineTriggered( this, new MineSquareEventArgs( _X, _Y ) );
        }

        void Menu_Flag( object sender, EventArgs e )
        {
            if( !_isFlagged )
            {
                isFlagged = true;
                Image = Minesweeper.Properties.Resources.flag;
            }
            else
            {
                isFlagged = false;
                Image = null;
            }
        }

        protected override void OnMouseDown( MouseEventArgs mevent )
        {
            if( !Checked )
                ContextMenuStrip.Show( this, mevent.Location );
        }



        public void Trigger( )
        {
            // don't bother doing this lot again!
            if( Checked == true )
                return;

            this.ContextMenuStrip = null;

            this.Checked = true;
            this.BackColor = DefaultBackColor;

            if( this.isMine )
            {
                this.BackColor = Color.Red;
                this.Image = Minesweeper.Properties.Resources.core;
            }
            else
            {
                this.Text = surroundingCount.ToString( );
                switch( surroundingCount )
                {
                    case 0:
                        this.Text = "";
                        TriggerSurroundingSquaresHandler temp = TriggerSurroundingSquares;
                        if( temp != null )
                        {
                            temp( this, new MineSquareEventArgs( _X, _Y ) );
                        }
                        break;
                    case 1:
                        this.ForeColor = Color.Blue;
                        break;
                    case 2:
                        this.ForeColor = Color.Green;
                        break;
                    case 3:
                        this.ForeColor = Color.Orange;
                        break;
                    case 4:
                        this.ForeColor = Color.Red;
                        break;
                    case 5:
                        this.ForeColor = Color.Purple;
                        break;
                    case 6:
                        this.ForeColor = Color.Magenta;
                        break;
                    case 7:
                        this.ForeColor = Color.Brown;
                        break;
                    case 8:
                        this.ForeColor = Color.Black;
                        break;
                }
            }
        }

        public delegate void TriggerSurroundingSquaresHandler( object sender, MineSquareEventArgs e );
        public event TriggerSurroundingSquaresHandler TriggerSurroundingSquares;
        public event EventHandler MineTriggered;
        public class MineSquareEventArgs : EventArgs
        {
            public MineSquareEventArgs( int x, int y )
            {
                _posX = x;
                _posY = y;
            }
            int _posX, _posY;

            public int X
            {
                get
                {
                    return _posX;
                }
            }
            public int Y
            {
                get
                {
                    return _posY;
                }
            }
        }

        public override string ToString( )
        {
            return "[" + _X + "," + _Y + "]: " + ( this.isMine ? "MINE" : this.surroundingCount.ToString() );
        }
    }
}
