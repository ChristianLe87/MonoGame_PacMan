using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Shared
{
    internal class Player
    {
        public Rectangle rectangle;
        private Texture2D texture;
        int moveSpeed;

        public Player(Rectangle rectangle)
        {
            this.rectangle = rectangle;
            this.texture = Tools.PlayerR(Color.Yellow);
            this.moveSpeed = 3;
        }

        internal void Update()
        {
            MovePlayer();
        }

        internal void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, Color.White);
        }

        private void MovePlayer()
        {
            KeyboardState keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.A) || keyboardState.IsKeyDown(Keys.Left))
            {
                rectangle.X -= moveSpeed;
            }
            else if (keyboardState.IsKeyDown(Keys.D) || keyboardState.IsKeyDown(Keys.Right))
            {
                rectangle.X += moveSpeed;
            }
            else if (keyboardState.IsKeyDown(Keys.W) || keyboardState.IsKeyDown(Keys.Up))
            {
                rectangle.Y -= moveSpeed;
            }
            else if (keyboardState.IsKeyDown(Keys.S) || keyboardState.IsKeyDown(Keys.Down))
            {
                rectangle.Y += moveSpeed;
            }
        }
    }
}