using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class TeleporterRight : ITeleporter
    {
        Point point;

        public TeleporterRight(Point point)
        {
            this.point = point;
        }

        public void Update()
        {
            Rectangle playerRectangle = new Rectangle(GameScene.player.point.X * WK.W, GameScene.player.point.Y * WK.H, WK.W, WK.H);
            Rectangle teleporterRectangle = new Rectangle(point.X * WK.W, point.Y * WK.H, WK.W, WK.H);

            if (teleporterRectangle.Intersects(playerRectangle))
            {
                GameScene.player.point = new Point(2, 17);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //spriteBatch.Draw(Tools.CreateColorTexture(Color.Green), new Rectangle(point.X * WK.W, point.Y * WK.H, WK.W, WK.H), Color.White);
        }
    }
}
