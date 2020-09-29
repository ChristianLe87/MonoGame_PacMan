using System;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public interface ITeleporter
    {
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}