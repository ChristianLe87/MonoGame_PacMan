using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class Dot
    {
        private Rectangle rectangle;
        private Texture2D texture;
        private bool active;

        public Dot(Rectangle rectangle, Texture2D texture2D)
        {
            this.rectangle = rectangle;
            this.texture = texture2D;
            this.active = true;
        }

        public void Update()
        {

            if (rectangle.Intersects(GameScene.player.rectangle))
            {
                active = false;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if(active) spriteBatch.Draw(texture, rectangle, Color.White);
        }
    }
}
