﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public interface IDot
    {
        public Rectangle rectangle { get; set; }
        public Texture2D texture { get; set; }
        public bool active { get; set; }

        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}