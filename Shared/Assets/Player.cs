using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Shared
{
    internal class Player
    {
        public Point point;
        Texture2D texture;
        int moveSpeed;
        Direcction direcction;
        State state;
        SoundEffect eatingSound_1;
        SoundEffect eatingSound_2;

        int framesCount;

        public Player(Point point)
        {
            this.point = point;
            this.texture = Tools.GetTexture(WK.Asset.PacMan);
            this.moveSpeed = 1;
            this.direcction = Direcction.Up;
            this.state = State.Stop;
            this.framesCount = 0;
            this.eatingSound_1 = Tools.GetSoundEffect("EatingSound_1");
            this.eatingSound_2 = Tools.GetSoundEffect("EatingSound_2");
        }

        internal void Update()
        {
            framesCount++;

            if (framesCount == 10)
            {
                MovePlayer2();
                if(state == State.Moving)
                    eatingSound_1.Play();
            }

            if (framesCount == 20)
            {
                framesCount = 0;
                if (state == State.Moving)
                    eatingSound_2.Play();
            }


            SetDirection();
            SetState();
        }

        internal void Draw(SpriteBatch spriteBatch)
        {
            if (direcction == Direcction.Left)
                spriteBatch.Draw(texture, new Rectangle(point.X * WK.W, point.Y * WK.H, WK.W, WK.H), new Rectangle(0, 0, 20, 20), Color.White);
            else if (direcction == Direcction.Right)
                spriteBatch.Draw(texture, new Rectangle(point.X * WK.W, point.Y * WK.H, WK.W, WK.H), new Rectangle(20, 0, 20, 20), Color.White);
            else if (direcction == Direcction.Up)
                spriteBatch.Draw(texture, new Rectangle(point.X * WK.W, point.Y * WK.H, WK.W, WK.H), new Rectangle(40, 0, 20, 20), Color.White);
            else if (direcction == Direcction.Down)
                spriteBatch.Draw(texture, new Rectangle(point.X * WK.W, point.Y * WK.H, WK.W, WK.H), new Rectangle(60, 0, 20, 20), Color.White);
        }

        private void MovePlayer2()
        {
            if (state == State.Moving)
            {
                if (direcction == Direcction.Left)
                {
                    if (Get_If_Is_Wall.Left(point) == false)
                    {
                        point.X -= moveSpeed;
                    }
                }
                else if (direcction == Direcction.Right)
                {
                    if (Get_If_Is_Wall.Right(point) == false)
                    {
                        point.X += moveSpeed;
                    }
                }
                else if (direcction == Direcction.Up)
                {
                    if (Get_If_Is_Wall.Up(point) == false)
                    {
                        point.Y -= moveSpeed;
                    }
                }
                else if (direcction == Direcction.Down)
                {
                    if (Get_If_Is_Wall.Down(point) == false)
                    {
                        point.Y += moveSpeed;
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
            if (direcction == Direcction.Up && Get_If_Is_Wall.Up(point))
            {
                state = State.Stop;
            }
            else if (direcction == Direcction.Down && Get_If_Is_Wall.Down(point))
            {
                state = State.Stop;
            }
            else if (direcction == Direcction.Right && Get_If_Is_Wall.Right(point))
            {
                state = State.Stop;
            }
            else if (direcction == Direcction.Left && Get_If_Is_Wall.Left(point))
            {
                state = State.Stop;
            }
        }

        class Get_If_Is_Wall {
            internal static bool Up(Point point)
            {
                return (WK.Map.Map_1[point.Y-1, point.X] == 'x');
            }

            internal static bool Down(Point point)
            {
                return (WK.Map.Map_1[point.Y + 1, point.X] == 'x');
            }

            internal static bool Right(Point point)
            {
                return (WK.Map.Map_1[point.Y, point.X + 1] == 'x');
            }

            internal static bool Left(Point point)
            {
                return (WK.Map.Map_1[point.Y, point.X - 1] == 'x');
            }

        }
    }
}