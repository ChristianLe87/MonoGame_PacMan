﻿using System;
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


        // Statics
        public static GraphicsDeviceManager graphicsDeviceManager;
        public static ContentManager contentManager;

        Dictionary<string, IScene> scenes;

        string actualScene;

        public Game1(string relativePath)
        {
            string absolutePath = new DirectoryInfo(Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, relativePath))).ToString();
            this.Content.RootDirectory = absolutePath;
            contentManager = this.Content;

            graphicsDeviceManager = new GraphicsDeviceManager(this);

            // Window size
            graphicsDeviceManager.PreferredBackBufferWidth = WK.Map.Map_1.GetLength(1) * 10;
            graphicsDeviceManager.PreferredBackBufferHeight = WK.Map.Map_1.GetLength(0) * 10;
        }


        protected override void Initialize()
        {
            // code
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
                { WK.Scene.AboutScene, new AboutScene() }
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
