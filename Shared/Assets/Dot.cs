using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class Dot
    {
        private Rectangle rectangle;
        private Texture2D texture;
        public bool active { get; private set; }

        public Dot(Rectangle rectangle, Texture2D texture2D)
        {
            this.rectangle = rectangle;
            this.texture = texture2D;
            this.active = true;
        }

        public void Update()
        {
            if (active)
            {
                if (rectangle.Intersects(GameScene.player.rectangle))
                {
                    GameScene.scoreText.UpdateScore(10);
                    active = false;
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if(active) spriteBatch.Draw(texture, rectangle, Color.White);
        }
    }
}
