using System;
using Shared;

namespace mp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            using (var game = new Game1(""))
            {
                game.Run();
            }
        }
    }
}
