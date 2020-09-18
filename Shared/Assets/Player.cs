using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Shared
{
    internal class Player
    {
        public Rectangle rectangle;
        private Texture2D texture;

        public Player(Rectangle rectangle)
        {
            this.rectangle = rectangle;
            this.texture = Tools.CreateColorTexture(Color.Red);
        }

        internal void Update()
        {
            KeyboardState keyboardState = Keyboard.GetState();

            Vector2 newPosition = Tools.MovePlayer(new Vector2(rectangle.X, rectangle.Y), 0, 500, 3);
            rectangle.X = (int)newPosition.X;
            rectangle.Y = (int)newPosition.Y;

            
            foreach (var dot in GameScene.dots)
            {
                var intersects = dot.rectangle.Intersects(this.rectangle);
                if (intersects)
                {
                    dot.active = false;
                }
            }

        }

        internal void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, Color.White);
        }
    }
}