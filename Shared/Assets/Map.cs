using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class Map
    {
        internal static List<Dot> Dots()
        {
            char[,] map = WK.Map.Map_1;

            Texture2D texture2D = Tools.GetTexture(WK.Asset.Dot);

            int numRows = map.GetLength(0);
            int numColumn = map.GetLength(1);

            List<Dot> dots = new List<Dot>();

            for (var row = 0; row < numRows; row++)
                for (var col = 0; col < numColumn; col++)
                    if (map[row, col] == '.')
                        dots.Add(new Dot(new Point(col, row), texture2D));


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
                        walls.Add(new Wall(new Point(col, row), Tools.CreateColorTexture(Color.Blue)));

            return walls;
        }
    }
}
