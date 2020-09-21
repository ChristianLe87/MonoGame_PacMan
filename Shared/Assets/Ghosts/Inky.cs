﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class Inky : IGhosts
    {
        public Rectangle rectangle { get; set; }
        public Texture2D texture2D { get; set; }
        Direcction direcction;

        public Inky(Rectangle rectangle)
        {
            this.rectangle = rectangle;
            this.texture2D = Tools.GetTexture(WK.Asset.Ghosts);
            this.direcction = Direcction.Up;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (direcction == Direcction.Up)
                spriteBatch.Draw(texture2D, rectangle, new Rectangle(0, 40, 20, 20), Color.White);
            else if (direcction == Direcction.Down)
                spriteBatch.Draw(texture2D, rectangle, new Rectangle(20, 40, 20, 20), Color.White);
            else if (direcction == Direcction.Left)
                spriteBatch.Draw(texture2D, rectangle, new Rectangle(40, 40, 20, 20), Color.White);
            else if (direcction == Direcction.Right)
                spriteBatch.Draw(texture2D, rectangle, new Rectangle(60, 40, 20, 20), Color.White);
        }
    }
}
