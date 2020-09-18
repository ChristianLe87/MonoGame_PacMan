using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    internal class GameScene : IScene
    {
        Player player;
        public static List<Cell> walls;
        public static List<IDot> dots;
        public static List<IGhosts> ghosts;

        public GameScene()
        {
            player = new Player(new Rectangle(260, 400, 20,20));
            walls = Map.Walls();
            dots = Map.Dots();
            ghosts = new List<IGhosts>()
            {
                new Blinky(new Rectangle(240, 340, 20, 20)),
                new Clyde(new Rectangle(260, 340, 20, 20)),
                new Inky(new Rectangle(280, 340, 20, 20)),
                new Pinky(new Rectangle(300, 340, 20, 20)),
            };
        }

       
        public void Update()
        {
            player.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var wall in walls) wall.Draw(spriteBatch);
            foreach (var dot in dots) dot.Draw(spriteBatch);
            foreach (var ghost in ghosts) ghost.Draw(spriteBatch);
            player.Draw(spriteBatch);
        }
    }
}