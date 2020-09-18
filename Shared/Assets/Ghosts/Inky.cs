﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class Inky : IGhosts
    {
        public Rectangle rectangle { get; set; }
        public Texture2D texture { get; set; }

        public Inky(Rectangle rectangle)
        {
            this.rectangle = rectangle;
            this.texture = Tools.GhostL(Color.LightBlue);
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
