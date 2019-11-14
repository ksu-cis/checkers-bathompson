using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe
{  
    public enum Color
    {
        Purple,
        Black
    }
    public struct Coordinate
    {
        public int x;
        public int y;
    }
    public class Checker
    {
        public Color color { get; private set; }
        public Coordinate Coords;
        public bool King { get; set; }

        public Checker(Color c, int x, int y)
        {
            color = c;
            Coords.x = x;
            Coords.y = y;
            King = false;
        }
    }
}
