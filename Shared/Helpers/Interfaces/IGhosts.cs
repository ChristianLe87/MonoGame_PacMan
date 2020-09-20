using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public interface IGhosts
    {
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
