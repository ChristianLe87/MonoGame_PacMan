using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class Wall
    {
        private Point point;
        private Texture2D texture2D;

        public Wall(Point point, Texture2D texture2D)
        {
            this.point = point;
            this.texture2D = texture2D;
        }

        public void Update()
        {
        }

        internal void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture2D, new Rectangle(point.X * WK.W, point.Y * WK.H, WK.W, WK.H), Color.White);
        }
    }
}
