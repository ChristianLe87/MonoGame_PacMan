using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class Map
    {
        private List<Cell> cells;

        public Map(char[,] map)
        {
            this.cells = PopulateCels(map);
        }

        private List<Cell> PopulateCels(char[,] map)
        {
            int numRows = map.GetLength(0);
            int numColumn = map.GetLength(1);

            List<Cell> cels = new List<Cell>();



            // define each cell
            for (var row = 0; row < numRows; row++)
            {
                for (var col = 0; col < numColumn; col++)
                {
                    if (map[row, col] == ' ')
                    {
                        Cell cell = new Cell(new Rectangle(col * 10, row * 10, 10, 10), Tools.CreateColorTexture(Color.Black));
                        cels.Add(cell);
                    }
                    else if (map[row, col] == 'x')
                    {
                        cels.Add(new Cell(new Rectangle(col * 10, row * 10, 10, 10), Tools.CreateColorTexture(Color.Blue)));
                    }
                    else if (map[row, col] == '.')
                    {
                        cels.Add(new Cell(new Rectangle(col * 10, row * 10, 10, 10), Tools.CreateColorTexture(Color.Yellow)));
                    }
                    else if (map[row, col] == 'o')
                    {
                        cels.Add(new Cell(new Rectangle(col * 10, row * 10, 10, 10), Tools.CreateColorTexture(Color.White)));
                    }
                    else
                    {
                        cels.Add(new Cell(new Rectangle(col * 10, row * 10, 10, 10), Tools.CreateColorTexture(Color.Pink)));
                    }
                }
            }


            return cels;
        }

        internal void Update()
        {
            //throw new NotImplementedException();
        }

        internal void Draw(SpriteBatch spriteBatch)
        {
            foreach (var cell in cells)
            {
                cell.Draw(spriteBatch);
            }
        }
    }
}
