using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Shared
{
    public class Map
    {
        internal static List<Dot> Dots()
        {
            char[,] map = WK.Map.Map_1;

            int numRows = map.GetLength(0);
            int numColumn = map.GetLength(1);

            List<Dot> dots = new List<Dot>();

            for (var row = 0; row < numRows; row++)
                for (var col = 0; col < numColumn; col++)
                    if (map[row, col] == '.')
                        dots.Add(new Dot(new Rectangle(col * 20, row * 20, 20, 20), Tools.Dot(Color.Yellow)));

            return dots;
        }

        internal static List<Wall> Walls()
        {
            char[,] map = WK.Map.Map_1;

            int numRows = map.GetLength(0);
            int numColumn = map.GetLength(1);

            List<Wall> walls = new List<Wall>();

            for (var row = 0; row < numRows; row++)
                for (var col = 0; col < numColumn; col++)
                    if (map[row, col] == 'x')
                        walls.Add(new Wall(new Rectangle(col * 20, row * 20, 20, 20), Tools.CreateColorTexture(Color.Blue)));

            return walls;
        }
    }
}
