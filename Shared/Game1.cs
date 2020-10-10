using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{

    public class Game1 : Game
    {
        SpriteBatch spriteBatch;

        public static GraphicsDeviceManager graphicsDeviceManager;
        public static ContentManager contentManager;

        string actualScene;

        Dictionary<string, IScene> scenes;

        public Game1()
        {
            string absolutePath = new DirectoryInfo(Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, WK.Content.RelativePath))).ToString();
            this.Content.RootDirectory = absolutePath;
            contentManager = this.Content;

            // FPS
            this.IsFixedTimeStep = true;
            this.TargetElapsedTime = TimeSpan.FromSeconds(1d / WK.FPS);

            // Window size
            graphicsDeviceManager = new GraphicsDeviceManager(this);
            graphicsDeviceManager.PreferredBackBufferWidth = WK.Map.Map_1.GetLength(1) * WK.W;
            graphicsDeviceManager.PreferredBackBufferHeight = WK.Map.Map_1.GetLength(0) * WK.H;
            graphicsDeviceManager.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            actualScene = WK.Scene.GameScene;

            spriteBatch = new SpriteBatch(GraphicsDevice);

            scenes = new Dictionary<string, IScene>()
            {
                { WK.Scene.MenuScene, new MenuScene() },
                { WK.Scene.GameScene, new GameScene() },
                { WK.Scene.AboutScene, new AboutScene() },
                { WK.Scene.TestScene, new TestScene() }
            };
        }


        protected override void Update(GameTime gameTime)
        {
            // code
            scenes[actualScene].Update();
            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {
            graphicsDeviceManager.GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();

            // code
            scenes[actualScene].Draw(spriteBatch);

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
