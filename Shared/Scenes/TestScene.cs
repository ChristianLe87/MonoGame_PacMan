using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class TestScene : IScene
    {
        SpriteFont font_1;


        public TestScene()
        {
            font_1 = Game1.contentManager.Load<SpriteFont>("Arial_20");
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font_1, "hello", new Vector2(50, 40), Color.Black);
        }
    }
}
