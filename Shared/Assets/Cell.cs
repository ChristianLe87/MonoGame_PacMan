﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    internal class Cell2
    {
        public Rectangle rectangle;
        private Texture2D texture2D;

        public Cell2(Rectangle rectangle, Texture2D texture2D)
        {
            this.rectangle = rectangle;
            this.texture2D = texture2D;
        }

        internal void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture2D, rectangle, Color.White);
        }
    }
}