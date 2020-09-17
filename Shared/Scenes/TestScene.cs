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
            //texture = Tools.CreateCircleTexture(20, Color.Pink);
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Rectangle(100, 100, 10, 10), Color.White);
        }
    }
}
