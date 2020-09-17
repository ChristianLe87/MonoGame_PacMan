using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    internal class GameScene : IScene
    {
        Map map;
        //Player player;
        //List<IPortal> portals;
        //List<IDots> dots;

        public GameScene()
        {
            map = new Map(WK.Map.Map_1);
            //player = new Player(new Rectangle(10,10,10,10));
            //portals = PortalsGenerator(WK.Map.Map_1);
            //dots = DotGenerator(WK.Map.Map_1);
        }

        private List<IDots> DotGenerator(char[,] map_1)
        {
            throw new NotImplementedException();
        }

        private List<IPortal> PortalsGenerator(char[,] map_1)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            map.Update();
            //player.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            map.Draw(spriteBatch);
            //player.Draw(spriteBatch);
        }
    }
}