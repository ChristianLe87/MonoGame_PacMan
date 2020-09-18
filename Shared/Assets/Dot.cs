using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class Dot : IDot
    {

        public Rectangle rectangle { get; set; }
        public Texture2D texture { get; set; }
        public bool active { get; set; }

        public Dot(Rectangle rectangle, Texture2D texture2D)
        {
            this.rectangle = rectangle;
            this.texture = texture2D;
            this.active = true;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if(active) spriteBatch.Draw(texture, rectangle, Color.White);
        }
    }
}
