using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class Pinky : IGhosts
    {
        public Rectangle rectangle { get; set; }
        public Texture2D texture2D { get; set; }
        Direcction direcction;

        public Pinky(Rectangle rectangle)
        {
            this.rectangle = rectangle;
            this.texture2D = Tools.GetTexture("Ghosts");
            this.direcction = Direcction.Up;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (direcction == Direcction.Up)
                spriteBatch.Draw(texture2D, rectangle, new Rectangle(0, 20, 20, 20), Color.White);
            else if (direcction == Direcction.Down)
                spriteBatch.Draw(texture2D, rectangle, new Rectangle(20, 20, 20, 20), Color.White);
            else if (direcction == Direcction.Left)
                spriteBatch.Draw(texture2D, rectangle, new Rectangle(40, 20, 20, 20), Color.White);
            else if (direcction == Direcction.Right)
                spriteBatch.Draw(texture2D, rectangle, new Rectangle(60, 20, 20, 20), Color.White);
        }
    }
}
