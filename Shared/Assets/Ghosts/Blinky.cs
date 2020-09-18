using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class Blinky : IGhosts
    {
        public Rectangle rectangle { get; set; }
        public Texture2D texture { get; set; }

        public Blinky(Rectangle rectangle)
        {
            this.rectangle = rectangle;
            this.texture = Tools.GhostL(Color.Red);
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, Color.White);
        }
    }
}