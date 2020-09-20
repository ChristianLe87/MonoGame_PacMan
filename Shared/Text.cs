using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class Text
    {
        SpriteFont font;
        Vector2 position;
        int score;

        public Text(Vector2 position)
        {
            this.font = Game1.contentManager.Load<SpriteFont>("Arial_20");
            this.position = position;
            this.score = 0;
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, $"Score: {score}", position, Color.Black);
        }

        public void UpdateScore(int addScore)
        {
            score += addScore;
        }
    }
}
