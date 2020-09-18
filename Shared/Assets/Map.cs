using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class Map
    {

        internal static List<Cell> PowerUps()
        {
            char[,] map = WK.Map.Map_1;

            int numRows = map.GetLength(0);
            int numColumn = map.GetLength(1);

            List<Cell> powerUps = new List<Cell>();

            for (var row = 0; row < numRows; row++)
                for (var col = 0; col < numColumn; col++)
                    if (map[row, col] == 'o')
                        powerUps.Add(new Cell(new Rectangle(col * 20, row * 20, 20, 20), Tools.CreateColorTexture(Color.White)));

            return powerUps;
        }

        internal static List<Cell> Portals()
        {
            char[,] map = WK.Map.Map_1;

            int numRows = map.GetLength(0);
            int numColumn = map.GetLength(1);

            List<Cell> portals = new List<Cell>();

            for (var row = 0; row < numRows; row++)
                for (var col = 0; col < numColumn; col++)
                    if (map[row, col] == '<' || map[row, col] == '>')
                        portals.Add(new Cell(new Rectangle(col * 20, row * 20, 20, 20), Tools.CreateColorTexture(Color.Pink)));

            return portals;
        }

        internal static List<IDot> Dots()
        {
            char[,] map = WK.Map.Map_1;

            int numRows = map.GetLength(0);
            int numColumn = map.GetLength(1);

            List<IDot> dots = new List<IDot>();

            for (var row = 0; row < numRows; row++)
                for (var col = 0; col < numColumn; col++)
                    if (map[row, col] == '.')
                        dots.Add(new Dot(new Rectangle(col * 20, row * 20, 20, 20), Tools.CreateColorTexture(Color.Yellow)));

            return dots;
        }

        internal static List<Cell> Walls()
        {
            char[,] map = WK.Map.Map_1;

            int numRows = map.GetLength(0);
            int numColumn = map.GetLength(1);

            List<Cell> walls = new List<Cell>();

            for (var row = 0; row < numRows; row++)
                for (var col = 0; col < numColumn; col++)
                    if (map[row, col] == 'x')
                        walls.Add(new Cell(new Rectangle(col * 20, row * 20, 20, 20), Tools.CreateColorTexture(Color.Blue)));

            return walls;
        }
    }
}
