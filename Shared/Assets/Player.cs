using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Shared
{
    internal class Player
    {
        public Rectangle rectangle;
        Texture2D texture;
        int moveSpeed;
        Direcction direcction;

        public Player(Rectangle rectangle)
        {
            this.rectangle = rectangle;
            this.texture = Tools.GetTexture("PacMan_20_80_PNG");
            this.moveSpeed = 2;
            this.direcction = Direcction.Up;
        }

        internal void Update()
        {
            MovePlayer();
            SetDirection();
        }

        internal void Draw(SpriteBatch spriteBatch)
        {
            if (direcction == Direcction.Left)
                spriteBatch.Draw(texture, rectangle, new Rectangle(0, 0, 20, 20), Color.White);
            else if (direcction == Direcction.Right)
                spriteBatch.Draw(texture, rectangle, new Rectangle(20, 0, 20, 20), Color.White);
            else if (direcction == Direcction.Up)
                spriteBatch.Draw(texture, rectangle, new Rectangle(40, 0, 20, 20), Color.White);
            else if (direcction == Direcction.Down)
                spriteBatch.Draw(texture, rectangle, new Rectangle(60, 0, 20, 20), Color.White);
        }

        private void MovePlayer()
        {
            switch (direcction)
            {
                default:
                    break;
            }
            if (direcction == Direcction.Left)
            {
                rectangle.X -= moveSpeed;
            }
            else if (direcction == Direcction.Right)
            {
                rectangle.X += moveSpeed;
            }
            else if (direcction == Direcction.Up)
            {
                rectangle.Y -= moveSpeed;
            }
            else if (direcction == Direcction.Down)
            {
                rectangle.Y += moveSpeed;
            }
        }

        private void SetDirection()
        {
            KeyboardState keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.A) || keyboardState.IsKeyDown(Keys.Left))
            {
                direcction = Direcction.Left;
            }
            else if (keyboardState.IsKeyDown(Keys.D) || keyboardState.IsKeyDown(Keys.Right))
            {
                direcction = Direcction.Right;
            }
            else if (keyboardState.IsKeyDown(Keys.W) || keyboardState.IsKeyDown(Keys.Up))
            {
                direcction = Direcction.Up;
            }
            else if (keyboardState.IsKeyDown(Keys.S) || keyboardState.IsKeyDown(Keys.Down))
            {
                direcction = Direcction.Down;
            }
        }
    }
}