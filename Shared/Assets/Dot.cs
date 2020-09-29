using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class Dot
    {
        Point point;
        Texture2D texture;
        public bool active { get; private set; }

        public Dot(Point point, Texture2D texture2D)
        {
            this.point = point;
            this.texture = texture2D;
            this.active = true;
        }

        public void Update()
        {
            /*if (active)
            {
                if (rectangle.Intersects(GameScene.player.rectangle))
                {
                    GameScene.scoreText.UpdateScore(10);
                    active = false;
                }
            }*/
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (active) spriteBatch.Draw(texture, new Rectangle(point.X * WK.W, point.Y * WK.H, WK.W, WK.H), Color.White);
        }
    }
}
