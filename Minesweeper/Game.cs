﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    class Game : System.Windows.Forms.Panel
    {
        readonly int gridWidth;
        readonly int gridHeight;

        Square[,] grid;

        public Game(int width, int height, Difficulty d)
        {
            InitializeComponent();

            gridHeight = height;
            gridWidth = width;

            grid = new Square[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    grid[x, y] = new Square(x, y, d);
                    this.Controls.Add(grid[x, y]);
                }
            }

            int mc = mineCount();
            int sc = gridHeight * gridWidth;
        }

        public int mineCount()
        {
            int count = 0;
            for (int x = 0; x < gridWidth; x++)
            {
                for (int y = 0; y < gridHeight; y++)
                {
                    if (grid[x, y].isMine == true)
                        count++;
                }
            }
            return count;
        }

        public enum Difficulty
        {
            STUPIDLYHARD = 1,
            IMPOSSIBLE = 3,
            INSANE = 4,
            EXPERT = 5,
            HARD = 6,
            MEDIOCRE = 7,
            EASY = 8,
            PISH = 9,
            BABY = 10
        }
    }
}
