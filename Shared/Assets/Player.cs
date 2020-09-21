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
        State state;

        public Player(Rectangle rectangle)
        {
            this.rectangle = rectangle;
            this.texture = Tools.GetTexture(WK.Asset.PacMan);
            this.moveSpeed = 1;
            this.direcction = Direcction.Left;
            this.state = State.Moving;
        }

        internal void Update()
        {
            MovePlayer();
            SetDirection();
            SetState();
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
            if (state == State.Moving)
            {
                if (direcction == Direcction.Left)
                {
                    if (GetIfWall.Left(rectangle) == false)
                    {
                        rectangle.X -= moveSpeed;
                    }
                }
                    
                else if (direcction == Direcction.Right)
                {
                    if (GetIfWall.Right(rectangle) == false)
                    {
                        rectangle.X += moveSpeed;
                    }
                }
                else if (direcction == Direcction.Up)
                {
                    if (GetIfWall.Up(rectangle) == false)
                    {
                        rectangle.Y -= moveSpeed;
                    }
                }
                else if (direcction == Direcction.Down)
                {
                    if (GetIfWall.Down(rectangle) == false)
                    {
                        rectangle.Y += moveSpeed;
                    }
                }
                    
            }
        }

        private void SetDirection()
        {
            KeyboardState keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.A) || keyboardState.IsKeyDown(Keys.Left))
            {
                direcction = Direcction.Left;
                state = State.Moving;
            }
            else if (keyboardState.IsKeyDown(Keys.D) || keyboardState.IsKeyDown(Keys.Right))
            {
                direcction = Direcction.Right;
                state = State.Moving;
            }
            else if (keyboardState.IsKeyDown(Keys.W) || keyboardState.IsKeyDown(Keys.Up))
            {
                direcction = Direcction.Up;
                state = State.Moving;
            }
            else if (keyboardState.IsKeyDown(Keys.S) || keyboardState.IsKeyDown(Keys.Down))
            {
                direcction = Direcction.Down;
                state = State.Moving;
            }
        }

        private void SetState()
        {
            if (direcction == Direcction.Up && GetIfWall.Up(rectangle))
            {
                state = State.Stop;
            }
            else if (direcction == Direcction.Down && GetIfWall.Down(rectangle))
            {
                state = State.Stop;
            }
            else if (direcction == Direcction.Right && GetIfWall.Right(rectangle))
            {
                state = State.Stop;
            }
            else if (direcction == Direcction.Left && GetIfWall.Left(rectangle))
            {
                state = State.Stop;
            }
        }

        private class GetIfWall {
            internal static bool Up(Rectangle rectangle)
            {
                return (WK.Map.Map_1[rectangle.Y / 20 - 1, rectangle.X / 20] == 'x');
            }

            internal static bool Down(Rectangle rectangle)
            {
                return (WK.Map.Map_1[rectangle.Y / 20 + 1, rectangle.X / 20] == 'x');
            }

            internal static bool Right(Rectangle rectangle)
            {
                return (WK.Map.Map_1[rectangle.Y / 20, rectangle.X / 20 + 1] == 'x');
            }

            internal static bool Left(Rectangle rectangle)
            {
                return (WK.Map.Map_1[rectangle.Y / 20, rectangle.X / 20] == 'x');
            }

        }
    }
}