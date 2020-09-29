using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class TeleporterLeft : ITeleporter
    {
        Point point;

        public TeleporterLeft(Point point)
        {
            this.point = point;
        }

        public void Update()
        {
            Rectangle playerRectangle = new Rectangle(GameScene.player.point.X * WK.W, GameScene.player.point.Y * WK.H, WK.W, WK.H);
            Rectangle teleporterRectangle = new Rectangle(point.X * WK.W, point.Y * WK.H, WK.W, WK.H);

            if (teleporterRectangle.Intersects(playerRectangle))
            {
                GameScene.player.point = new Point(24, 17);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //spriteBatch.Draw(Tools.CreateColorTexture(Color.Red), new Rectangle(point.X * WK.W, point.Y * WK.H, WK.W, WK.H), Color.White);
        }
    }
}