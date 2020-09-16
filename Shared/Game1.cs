using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Shared
{
    public class Game1 : Game
    {
        public static GraphicsDeviceManager graphicsDeviceManager;
        SpriteBatch spriteBatch;

        Texture2D texture2D;
        Rectangle rectangle;

        int canvasWidth = 500;
        int canvasHeight = 500;

        public Game1()
        {
            graphicsDeviceManager = new GraphicsDeviceManager(this);

            string relativePath = $"../../../../MonoGame_Templates/Assets/";
            string absolutePath = new DirectoryInfo(Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, relativePath))).ToString();
            this.Content.RootDirectory = absolutePath;

            // Window size
            graphicsDeviceManager.PreferredBackBufferWidth = canvasWidth;
            graphicsDeviceManager.PreferredBackBufferHeight = canvasHeight;
        }


        protected override void Initialize()
        {
            // TODO: Code
            base.Initialize();
        }


        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: Code
            texture2D = Tools.CreateColorTexture(Color.Pink);
            rectangle = new Rectangle(250, 250, 20, 20);
        }


        protected override void UnloadContent()
        {
            // TODO: Code
        }


        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Code

            if (true) this.IsMouseVisible = true;

            Vector2 oldPosition = new Vector2(rectangle.X, rectangle.Y);
            Vector2 newPosition = Tools.MovePlayer(oldPosition, 100, 100, 2);
            rectangle = new Rectangle((int)newPosition.X, (int)newPosition.Y, rectangle.Width, rectangle.Height);

            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            // TODO: Code
            spriteBatch.Draw(texture2D, rectangle, Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }



    public class Tools
    {
        internal static Texture2D CreateColorTexture(Color color)
        {
            Texture2D newTexture = new Texture2D(Game1.graphicsDeviceManager.GraphicsDevice, 1, 1, false, SurfaceFormat.Color);
            newTexture.SetData(new Color[] { color });
            return newTexture;
        }


        internal static Vector2 MovePlayer(Vector2 position, int minPosition, int maxPosition, int moveSpeed)
        {
            KeyboardState keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.A) || keyboardState.IsKeyDown(Keys.Left))
            {
                position.X -= moveSpeed;
            }
            else if (keyboardState.IsKeyDown(Keys.D) || keyboardState.IsKeyDown(Keys.Right))
            {
                position.X += moveSpeed;
            }
            else if (keyboardState.IsKeyDown(Keys.W) || keyboardState.IsKeyDown(Keys.Up))
            {
                position.Y -= moveSpeed;
            }
            else if (keyboardState.IsKeyDown(Keys.S) || keyboardState.IsKeyDown(Keys.Down))
            {
                position.Y += moveSpeed;
            }

            return position;
        }
    }
}
