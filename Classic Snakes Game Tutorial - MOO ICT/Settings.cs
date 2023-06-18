using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snakes_Game
{
    class Settings
    {

        public static int Width { get; set; }
        public static int Height { get; set; }

        public static string directions;

        public Settings()
        {
            Width = 16;
            Height = 16;
            directions = "left";
        }


    }
}
//Classic Snakes Game Tutorial - MOO ICT
//Classic_Snakes_Game_Tutorial___MOO_ICT