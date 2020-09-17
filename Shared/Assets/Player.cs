using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    internal class Player
    {
        private Rectangle rectangle;

        public Player(Rectangle rectangle)
        {
            this.rectangle = rectangle;
        }

        internal void Update()
        {
            throw new NotImplementedException();
        }

        internal void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }
    }
}