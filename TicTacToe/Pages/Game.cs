using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Pages
{
    public class Game
    {
        public Color CurrentTurn { get; set; }
        public Checker[,] Board = new Checker[8, 8];
        public bool GameOn { get; set; }

        public Game()
        {
            GameOn = true;
            for(int i=0; i<8; i+=2)
            {
                Board[i, 0] = new Checker(Color.Black, i, 0);
                Board[i+1, 1] = new Checker(Color.Black, i+1, 1);
                Board[i, 2] = new Checker(Color.Black, i, 2);

                Board[i+1, 5] = new Checker(Color.Purple, i+1, 5);
                Board[i, 6] = new Checker(Color.Purple, i, 6);
                Board[i+1, 7] = new Checker(Color.Purple, i+1, 7);
            }
            CurrentTurn = Color.Purple;
        }
        public string Serialize()
        {
            string state = GameOn.ToString() + '\n';
            state += CurrentTurn.ToString() + '\n';
            for(int i =0; i<8; i++)
            {
                for(int j=0; j<8; j++)
                {
                    if(Board[j,i]!=null)
                    {
                        Checker c = Board[j, i];
                        state += $"{c.color}|{c.King}|{c.Coords.x}|{c.Coords.y}\n";
                    }
                }
            }
            return state;
        }
        public static Game Marshal(string state)
        {
            string[] parts = state.Split("\n");
            Game game = new Game();
            game.GameOn = Boolean.Parse(parts[0]);
            game.CurrentTurn = (Color)Enum.Parse(typeof(Color),parts[1]);
        }
    }
}
