using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    internal class GameScene : IScene
    {
        Map map;

        public GameScene()
        {
            map = new Map(WK.Map.Map_1);
        }

        public void Update()
        {
            map.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            map.Draw(spriteBatch);
        }
    }
}