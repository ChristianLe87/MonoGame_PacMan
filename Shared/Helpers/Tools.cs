using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class Tools
    {
        internal static Texture2D CreateColorTexture(Color color)
        {
            Texture2D newTexture = new Texture2D(Game1.graphicsDeviceManager.GraphicsDevice, 1, 1, false, SurfaceFormat.Color);
            newTexture.SetData(new Color[] { color });
            return newTexture;
        }

 


        internal static Texture2D Dot(Color c)
        {
            Color _ = Color.Black;
            Color[] thing = new Color[]
            {
                _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _,
                _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _,
                _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _,
                _, _, _, _, _, _, _, _, _, c, c, c, _, _, _, _, _, _, _, _,
                _, _, _, _, _, _, _, c, c, c, c, c, c, c, _, _, _, _, _, _,
                _, _, _, _, _, _, c, c, c, c, c, c, c, c, c, _, _, _, _, _,
                _, _, _, _, _, c, c, c, c, c, c, c, c, c, c, c, _, _, _, _,
                _, _, _, _, c, c, c, c, c, c, c, c, c, c, c, c, c, _, _, _,
                _, _, _, _, c, c, c, c, c, c, c, c, c, c, c, c, c, _, _, _,
                _, _, _, _, c, c, c, c, c, c, c, c, c, c, c, c, c, _, _, _,
                _, _, _, _, c, c, c, c, c, c, c, c, c, c, c, c, c, _, _, _,
                _, _, _, _, c, c, c, c, c, c, c, c, c, c, c, c, c, _, _, _,
                _, _, _, _, _, c, c, c, c, c, c, c, c, c, c, c, _, _, _, _,
                _, _, _, _, _, _, c, c, c, c, c, c, c, c, c, _, _, _, _, _,
                _, _, _, _, _, _, _, c, c, c, c, c, c, c, _, _, _, _, _, _,
                _, _, _, _, _, _, _, _, _, c, c, c, _, _, _, _, _, _, _, _,
                _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _,
                _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _,
                _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _,
                _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _
            };

            Texture2D newTexture = new Texture2D(Game1.graphicsDeviceManager.GraphicsDevice, 20, 20);
            newTexture.SetData(thing);
            return newTexture;
        }


        internal static Texture2D GhostL(Color c)
        {
            Color w = Color.White;
            Color b = Color.Blue;
            Color _ = Color.Black;
            Color[] thing = new Color[]
            {
                _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _,
                _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _,
                _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _,
                _, _, _, _, _, _, _, _, c, c, c, c, c, _, _, _, _, _, _, _,
                _, _, _, _, _, _, c, c, c, c, c, c, c, c, c, _, _, _, _, _,
                _, _, _, _, _, c, c, c, c, c, c, c, w, w, c, c, _, _, _, _,
                _, _, _, _, c, w, w, c, c, c, c, w, w, w, w, c, _, _, _, _,
                _, _, _, _, w, w, w, w, c, c, c, w, w, w, w, c, _, _, _, _,
                _, _, _, _, b, b, w, w, c, c, c, b, b, w, w, c, c, _, _, _,
                _, _, _, c, b, b, w, w, c, c, c, b, b, w, w, c, c, _, _, _,
                _, _, _, c, c, w, w, c, c, c, c, c, w, w, c, c, c, _, _, _,
                _, _, _, c, c, c, c, c, c, c, c, c, c, c, c, c, c, _, _, _,
                _, _, _, c, c, c, c, c, c, c, c, c, c, c, c, c, c, _, _, _,
                _, _, _, c, c, c, c, c, c, c, c, c, c, c, c, c, c, _, _, _,
                _, _, _, c, c, c, c, c, c, c, c, c, c, c, c, c, c, _, _, _,
                _, _, _, c, c, _, c, c, c, _, _, c, c, c, _, c, c, _, _, _,
                _, _, _, c, _, _, _, c, c, _, _, c, c, _, _, _, c, _, _, _,
                _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _,
                _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _,
                _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _
            };

            Texture2D newTexture = new Texture2D(Game1.graphicsDeviceManager.GraphicsDevice, 20, 20);
            newTexture.SetData(thing);
            return newTexture;
        }

        internal static Texture2D PlayerR(Color c)
        {
            Color w = Color.White;
            Color b = Color.Blue;
            Color _ = Color.Black;
            Color[] thing = new Color[]
            {
                _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _,
                _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _,
                _, _, _, _, _, _, _, _, _, c, c, c, _, _, _, _, _, _, _, _,
                _, _, _, _, _, _, _, c, c, c, c, c, c, c, _, _, _, _, _, _,
                _, _, _, _, _, _, c, c, c, c, c, c, c, c, c, _, _, _, _, _,
                _, _, _, _, _, c, c, c, c, c, c, c, c, c, c, c, _, _, _, _,
                _, _, _, _, c, c, c, c, c, c, c, c, c, c, c, c, c, _, _, _,
                _, _, _, _, c, c, c, c, c, c, c, c, c, c, c, c, _, _, _, _,
                _, _, _, c, c, c, c, c, c, c, c, c, c, c, _, _, _, _, _, _,
                _, _, _, c, c, c, c, c, c, c, c, _, _, _, _, _, _, _, _, _,
                _, _, _, c, c, c, c, c, c, c, c, c, c, c, _, _, _, _, _, _,
                _, _, _, _, c, c, c, c, c, c, c, c, c, c, c, c, _, _, _, _,
                _, _, _, _, c, c, c, c, c, c, c, c, c, c, c, c, c, _, _, _,
                _, _, _, _, _, c, c, c, c, c, c, c, c, c, c, c, _, _, _, _,
                _, _, _, _, _, _, c, c, c, c, c, c, c, c, c, _, _, _, _, _,
                _, _, _, _, _, _, _, c, c, c, c, c, c, c, _, _, _, _, _, _,
                _, _, _, _, _, _, _, _, _, c, c, c, _, _, _, _, _, _, _, _,
                _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _,
                _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _,
                _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _
            };

            Texture2D newTexture = new Texture2D(Game1.graphicsDeviceManager.GraphicsDevice, 20, 20);
            newTexture.SetData(thing);
            return newTexture;
        }
    }
}
