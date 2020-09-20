using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public interface IGhosts
    {
        public Rectangle rectangle { get; set; }
        public Texture2D texture { get; set; }

        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
