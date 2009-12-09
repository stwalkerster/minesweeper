using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Minesweeper
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main( )
        {
            rnd = new Random( );
            
            Application.EnableVisualStyles( );
            Application.SetCompatibleTextRenderingDefault( false );
            Application.Run( new GameForm() );


        }

        static Random rnd;

        public static int random( int max )
        {
            return rnd.Next( max );
        }
    }
}
