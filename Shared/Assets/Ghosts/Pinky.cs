using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class Pinky : IGhosts
    {
        public Point point { get; set; }
        public Texture2D texture2D { get; set; }
        Direcction direcction;

        public Pinky(Point point)
        {
            this.point = point;
            this.texture2D = Tools.GetTexture(WK.Content.Ghosts);
            this.direcction = Direcction.Up;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (direcction == Direcction.Up)
                spriteBatch.Draw(texture2D, new Rectangle(point.X * WK.W, point.Y * WK.H, WK.W, WK.H), new Rectangle(0, 20, 20, 20), Color.White);
            else if (direcction == Direcction.Down)
                spriteBatch.Draw(texture2D, new Rectangle(point.X * WK.W, point.Y * WK.H, WK.W, WK.H), new Rectangle(20, 20, 20, 20), Color.White);
            else if (direcction == Direcction.Left)
                spriteBatch.Draw(texture2D, new Rectangle(point.X * WK.W, point.Y * WK.H, WK.W, WK.H), new Rectangle(40, 20, 20, 20), Color.White);
            else if (direcction == Direcction.Right)
                spriteBatch.Draw(texture2D, new Rectangle(point.X * WK.W, point.Y * WK.H, WK.W, WK.H), new Rectangle(60, 20, 20, 20), Color.White);
        }
    }
}
