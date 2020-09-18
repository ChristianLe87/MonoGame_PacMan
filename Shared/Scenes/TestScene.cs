using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class TestScene : IScene
    {
        Texture2D texture;

        public TestScene()
        {
            texture = Tools.GhostL( Color.Pink);
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Rectangle(100, 100, 20, 20), Color.White);
        }
    }
}
