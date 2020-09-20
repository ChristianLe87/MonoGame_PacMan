using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    internal class GameScene : IScene
    {
        public static Text scoreText;
        public static Player player;
        public static List<Wall> walls;
        public static List<Dot> dots;
        public static List<IGhosts> ghosts;

        public GameScene()
        {
            scoreText = new Text(new Vector2(80, 20));
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
            // --- Updates ---
            scoreText.Update();
            player.Update();
            foreach (var wall in walls) wall.Update();
            foreach (var dot in dots) dot.Update();
            foreach (var ghost in ghosts) ghost.Update();

            // --- Clean ---
            //dots = dots.Where(x => x.active == true).ToList();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            scoreText.Draw(spriteBatch);
            foreach (var wall in walls) wall.Draw(spriteBatch);
            foreach (var dot in dots) dot.Draw(spriteBatch);
            foreach (var ghost in ghosts) ghost.Draw(spriteBatch);
            player.Draw(spriteBatch);
        }
    }
}