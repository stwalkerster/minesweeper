using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Minesweeper
{
    class Game : System.Windows.Forms.Panel
    {
        readonly int gridWidth;
        readonly int gridHeight;

      public  Timer t = new Timer(  );

        bool gameOver = false;

        Square[ , ] grid;

        public Game( int width, int height, Difficulty d )
        {
            gridHeight = height;
            gridWidth = width;

            // instantiate minefield
            grid = new Square[ width, height ];
            for( int x = 0; x < width; x++ )
            {
                for( int y = 0; y < height; y++ )
                {
                    grid[ x, y ] = new Square( x, y, d );
                    grid[ x, y ].TriggerSurroundingSquares += new Square.TriggerSurroundingSquaresHandler( Game_TriggerSurroundingSquares );
                    grid[ x, y ].MineTriggered += new EventHandler( Game_MineTriggered );
                    this.Controls.Add( grid[ x, y ] );
                }
            }

            // get surrounding counts
            for( int x = 0; x < width; x++ )
            {
                for( int y = 0; y < height; y++ )
                {
                    int surroundingCount = 0;

                    if( x != 0 )
                    {
                        if( grid[ x - 1, y ].isMine )
                            surroundingCount++;
                    }

                    if( y != 0 )
                    {
                        if( grid[ x, y - 1 ].isMine )
                            surroundingCount++;
                    }

                    if( y != 0 && x != 0 )
                    {
                        if( grid[ x - 1, y - 1 ].isMine )
                            surroundingCount++;
                    }

                    if( ( y + 1 ) != height )
                    {
                        if( grid[ x, y + 1 ].isMine )
                            surroundingCount++;
                    }
                    if( ( x + 1 ) != width )
                    {
                        if( grid[ x + 1, y ].isMine )
                            surroundingCount++;
                    }
                    if( ( x + 1 ) != width && y != 0 )
                    {
                        if( grid[ x + 1, y - 1 ].isMine )
                            surroundingCount++;
                    }
                    if( ( y + 1 ) != height && x != 0 )
                    {
                        if( grid[ x - 1, y + 1 ].isMine )
                            surroundingCount++;
                    }
                    if( ( x + 1 ) != width && ( y + 1 ) != height )
                    {
                        if( grid[ x + 1, y + 1 ].isMine )
                            surroundingCount++;
                    }

                    grid[ x, y ].surroundingCount = surroundingCount;
                }
            }

            //TriggerAll( );

            int mc = mineCount( );
            int sc = gridHeight * gridWidth;

            
            t.Interval = 1000;
        }

        void Game_MineTriggered( object sender, EventArgs e )
        {
            TriggerAll( );
            if( !gameOver )
            {
                gameOver = true;
                MessageBox.Show( "You Have Lost, Please Die Now" );
                t.Stop( );
            }
        }

        void Game_TriggerSurroundingSquares( object sender, Square.MineSquareEventArgs e )
        {
            int x = e.X;
            int y = e.Y;
            int height = this.gridHeight;
            int width = this.gridWidth;

            if( x != 0 )
            {
                if( !grid[ x - 1, y ].Checked )  
                    grid[ x - 1, y ].Trigger( );
            }

            if( y != 0 )
            {
                if( !grid[ x, y - 1 ].Checked ) 
                grid[ x, y - 1 ].Trigger( );
            }

            if( y != 0 && x != 0 )
            {
                if( !grid[ x - 1, y - 1 ].Checked ) 
                grid[ x - 1, y - 1 ].Trigger( );
            }

            if( ( y + 1 ) != height )
            {
                if( !grid[ x, y + 1 ].Checked ) 
                grid[ x, y + 1 ].Trigger( );
            }
            if( ( x + 1 ) != width )
            {
                if( !grid[ x + 1, y ].Checked ) 
                grid[ x + 1, y ].Trigger( );
            }
            if( ( x + 1 ) != width && y != 0 )
            {
                if( !grid[ x + 1, y - 1 ].Checked ) 
                grid[ x + 1, y - 1 ].Trigger( );
            }
            if( ( y + 1 ) != height && x != 0 )
            {
                if( !grid[ x - 1, y + 1 ].Checked ) 
                grid[ x - 1, y + 1 ].Trigger( );
            }
            if( ( x + 1 ) != width && ( y + 1 ) != height )
            {
                if( !grid[ x + 1, y + 1 ].Checked ) 
                grid[ x + 1, y + 1 ].Trigger( );
            }
        }

        public int mineCount( )
        {
            int count = 0;
            for( int x = 0; x < gridWidth; x++ )
            {
                for( int y = 0; y < gridHeight; y++ )
                {
                    if( grid[ x, y ].isMine == true )
                        count++;
                }
            }
            return count;
        }

        public enum Difficulty
        {
            STUPIDLYHARD = 2,
            IMPOSSIBLE = 3,
            INSANE = 4,
            EXPERT = 8,
            HARD = 16,
            MEDIOCRE = 32,
            EASY = 64,
            PISH = 128,
            BABY = 256
        }

        public void TriggerAll( )
        {
            foreach( Square item in grid )
            {
                item.Trigger( );
            }
        }
    }
}