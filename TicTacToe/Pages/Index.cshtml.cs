using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TicTacToe.Pages
{
    public class IndexModel : PageModel
    {
        public Game g;
        public void OnGet()
        {
            g = new Game();
        }
        public void OnPost(int cx, int cy, int sx, int sy)
        {
            g = new Game();
            Checker checker = g.Board[cx, cy];
            checker.Coords.x = sx;
            checker.Coords.y = sy;
            g.Board[sx, sy] = checker;
            g.Board[cx, cy] = null;
        }
    }
}
