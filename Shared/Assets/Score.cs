using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class Score
    {
        SpriteFont font;
        Point point;
        int score;

        public Score(Point point)
        {
            this.font = Game1.contentManager.Load<SpriteFont>("Arial_20");
            this.point = point;
            this.score = 0;
        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(font, $"Score: {score}", new Vector2(point.X, point.Y), Color.Black);
        }

        public void UpdateScore(int addScore)
        {
            score += addScore;
        }
    }
}
