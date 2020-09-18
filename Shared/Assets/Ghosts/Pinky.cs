using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class Pinky : IGhosts
    {
        public Rectangle rectangle { get; set; }
        public Texture2D texture { get; set; }

        public Pinky(Rectangle rectangle)
        {
            this.rectangle = rectangle;
            this.texture = Tools.GhostL(Color.Pink);
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
