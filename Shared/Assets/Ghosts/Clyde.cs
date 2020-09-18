using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class Clyde : IGhosts
    {
        public Rectangle rectangle { get; set; }
        public Texture2D texture { get; set; }

        public Clyde(Rectangle rectangle)
        {
            this.rectangle = rectangle;
            this.texture = Tools.GhostL(Color.Orange);
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