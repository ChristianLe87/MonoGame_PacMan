using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    internal class GameScene : IScene
    {
        public static Score scoreText;
        public static Player player;
        public static List<Wall> walls;
        public static List<Dot> dots;
        public static List<IGhosts> ghosts;
        public static List<ITeleporter> teleports;

        public GameScene()
        {
            scoreText = new Score(new Point(2, 1));
            player = new Player(new Point(13, 20));
            walls = Map.Walls();
            dots = Map.Dots();
            ghosts = new List<IGhosts>()
            {
                new Blinky(new Point(12, 17)),
                new Clyde(new Point(13, 17)),
                new Inky(new Point(14, 17)),
                new Pinky(new Point(15, 17))
            };
            teleports = new List<ITeleporter>()
            {
                new TeleporterLeft(new Point(1, 17)),
                new TeleporterRight(new Point(26, 17)),
            };
        }


        public void Update()
        {
            scoreText.Update();
            player.Update();
            foreach (var wall in walls) wall.Update();
            foreach (var dot in dots) dot.Update();
            foreach (var ghost in ghosts) ghost.Update();
            foreach (var teleport in teleports) teleport.Update();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            scoreText.Draw(spriteBatch);
            player.Draw(spriteBatch);
            foreach (var wall in walls) wall.Draw(spriteBatch);
            foreach (var dot in dots) dot.Draw(spriteBatch);
            foreach (var ghost in ghosts) ghost.Draw(spriteBatch);
            foreach (var teleport in teleports) teleport.Draw(spriteBatch);
        }
    }
}
