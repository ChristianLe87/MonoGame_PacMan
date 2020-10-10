using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
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

        internal static Texture2D GetTexture(string imageName)
        {
            string relativePath = $"{WK.Content.RelativePath}{imageName}.png";
            string absolutePath = new DirectoryInfo(Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, relativePath))).ToString();

            FileStream fileStream = new FileStream(absolutePath, FileMode.Open);

            var result = Texture2D.FromStream(Game1.graphicsDeviceManager.GraphicsDevice, fileStream);
            fileStream.Dispose();

            return result;
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

        internal static SoundEffect GetSoundEffect(string soundName)
        {
            string relativePath = $"{WK.Content.RelativePath}{soundName}.wav";
            string absolutePath = new DirectoryInfo(Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, relativePath))).ToString();

            FileStream fileStream = new FileStream(absolutePath, FileMode.Open);

            var result = SoundEffect.FromStream(fileStream);
            fileStream.Dispose();

            return result;
        }


        internal static float DistanceToPlayer(Point playerPosition, Point ghostPosition)
        {

            int x = Math.Abs(playerPosition.X - ghostPosition.X);
            int y = Math.Abs(playerPosition.Y - ghostPosition.Y);

            int x2 = x * x;
            int y2 = y * y;

            double distance = Math.Sqrt(x2 + y2);

            return (float)distance;
        }

    }

    internal class Get_If_Is_Wall
    {
        internal static bool Up(Point point)
        {
            return (WK.Map.Map_1[point.Y - 1, point.X] == 'x') || (WK.Map.Map_1[point.Y - 1, point.X] == '-');
        }

        internal static bool Down(Point point)
        {
            return (WK.Map.Map_1[point.Y + 1, point.X] == 'x') || (WK.Map.Map_1[point.Y + 1, point.X] == '-');
        }

        internal static bool Right(Point point)
        {
            return (WK.Map.Map_1[point.Y, point.X + 1] == 'x') || (WK.Map.Map_1[point.Y, point.X + 1] == '-');
        }

        internal static bool Left(Point point)
        {
            return (WK.Map.Map_1[point.Y, point.X - 1] == 'x') || (WK.Map.Map_1[point.Y, point.X - 1] == '-');
        }

    }
}
