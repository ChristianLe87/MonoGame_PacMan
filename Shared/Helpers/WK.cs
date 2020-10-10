﻿namespace Shared
{
    public class WK
    {
        public static readonly double FPS = 60;

        public static readonly int H = 20;
        public static readonly int W = 20;

        public class Content
        {
            public static readonly string RelativePath = "../../../../MonoGame_PacMan/Shared/Content/";

            public static readonly string PacMan = "PacMan_20_80_PNG";
            public static readonly string Ghosts = "Ghosts_80_80_PNG";
            public static readonly string Dot = "Dot_20x20_PNG";

            public static readonly string EatingSound = "EatingSound_WAV";

            public static readonly string Arial_20 = "Arial_20";
        }


        public class Scene
        {
            public static string GameScene = "GameScene";
            public static string MenuScene = "MenuScene";
            public static string AboutScene = "AboutScene";
            public static string TestScene = "TestScene";
        }

        public class Map
        {
            public static char[,] Map_1 = new char[,] {
                    { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                    { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                    { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                    { 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x' },
                    { 'x', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'x', 'x', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'x' },
                    { 'x', '.', 'x', 'x', 'x', 'x', '.', 'x', 'x', 'x', 'x', 'x', '.', 'x', 'x', '.', 'x', 'x', 'x', 'x', 'x', '.', 'x', 'x', 'x', 'x', '.', 'x' },
                    { 'x', 'o', 'x', ' ', ' ', 'x', '.', 'x', ' ', ' ', ' ', 'x', '.', 'x', 'x', '.', 'x', ' ', ' ', ' ', 'x', '.', 'x', ' ', ' ', 'x', 'o', 'x' },
                    { 'x', '.', 'x', 'x', 'x', 'x', '.', 'x', 'x', 'x', 'x', 'x', '.', 'x', 'x', '.', 'x', 'x', 'x', 'x', 'x', '.', 'x', 'x', 'x', 'x', '.', 'x' },
                    { 'x', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'x' },
                    { 'x', '.', 'x', 'x', 'x', 'x', '.', 'x', 'x', '.', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', '.', 'x', 'x', '.', 'x', 'x', 'x', 'x', '.', 'x' },
                    { 'x', '.', 'x', 'x', 'x', 'x', '.', 'x', 'x', '.', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', '.', 'x', 'x', '.', 'x', 'x', 'x', 'x', '.', 'x' },
                    { 'x', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'x', 'x', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'x' },
                    { 'x', 'x', 'x', 'x', 'x', 'x', '.', 'x', 'x', 'x', 'x', 'x', ' ', 'x', 'x', ' ', 'x', 'x', 'x', 'x', 'x', '.', 'x', 'x', 'x', 'x', 'x', 'x' },
                    { ' ', ' ', ' ', ' ', ' ', 'x', '.', 'x', 'x', 'x', 'x', 'x', ' ', 'x', 'x', ' ', 'x', 'x', 'x', 'x', 'x', '.', 'x', ' ', ' ', ' ', ' ', ' ' },
                    { ' ', ' ', ' ', ' ', ' ', 'x', '.', 'x', 'x', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'x', 'x', '.', 'x', ' ', ' ', ' ', ' ', ' ' },
                    { ' ', ' ', ' ', ' ', ' ', 'x', '.', 'x', 'x', ' ', 'x', 'x', 'x', '-', '-', 'x', 'x', 'x', ' ', 'x', 'x', '.', 'x', ' ', ' ', ' ', ' ', ' ' },
                    { 'x', 'x', 'x', 'x', 'x', 'x', '.', 'x', 'x', ' ', 'x', ' ', ' ', ' ', ' ', ' ', ' ', 'x', ' ', 'x', 'x', '.', 'x', 'x', 'x', 'x', 'x', 'x' },
                    { ' ', ' ', ' ', ' ', ' ', '-', '.', ' ', ' ', ' ', 'x', ' ', ' ', ' ', ' ', ' ', ' ', 'x', ' ', ' ', ' ', '.', '-', ' ', ' ', ' ', ' ', ' ' },
                    { 'x', 'x', 'x', 'x', 'x', 'x', '.', 'x', 'x', ' ', 'x', ' ', ' ', ' ', ' ', ' ', ' ', 'x', ' ', 'x', 'x', '.', 'x', 'x', 'x', 'x', 'x', 'x' },
                    { ' ', ' ', ' ', ' ', ' ', 'x', '.', 'x', 'x', ' ', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', ' ', 'x', 'x', '.', 'x', ' ', ' ', ' ', ' ', ' ' },
                    { ' ', ' ', ' ', ' ', ' ', 'x', '.', 'x', 'x', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'x', 'x', '.', 'x', ' ', ' ', ' ', ' ', ' ' },
                    { ' ', ' ', ' ', ' ', ' ', 'x', '.', 'x', 'x', ' ', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', ' ', 'x', 'x', '.', 'x', ' ', ' ', ' ', ' ', ' ' },
                    { 'x', 'x', 'x', 'x', 'x', 'x', '.', 'x', 'x', ' ', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', ' ', 'x', 'x', '.', 'x', 'x', 'x', 'x', 'x', 'x' },
                    { 'x', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'x', 'x', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'x' },
                    { 'x', '.', 'x', 'x', 'x', 'x', '.', 'x', 'x', 'x', 'x', 'x', '.', 'x', 'x', '.', 'x', 'x', 'x', 'x', 'x', '.', 'x', 'x', 'x', 'x', '.', 'x' },
                    { 'x', '.', 'x', 'x', 'x', 'x', '.', 'x', 'x', 'x', 'x', 'x', '.', 'x', 'x', '.', 'x', 'x', 'x', 'x', 'x', '.', 'x', 'x', 'x', 'x', '.', 'x' },
                    { 'x', 'o', '.', '.', 'x', 'x', '.', '.', '.', '.', '.', '.', '.', ' ', ' ', '.', '.', '.', '.', '.', '.', '.', 'x', 'x', '.', '.', 'o', 'x' },
                    { 'x', 'x', 'x', '.', 'x', 'x', '.', 'x', 'x', '.', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', '.', 'x', 'x', '.', 'x', 'x', '.', 'x', 'x', 'x' },
                    { 'x', 'x', 'x', '.', 'x', 'x', '.', 'x', 'x', '.', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', '.', 'x', 'x', '.', 'x', 'x', '.', 'x', 'x', 'x' },
                    { 'x', '.', '.', '.', '.', '.', '.', 'x', 'x', '.', '.', '.', '.', 'x', 'x', '.', '.', '.', '.', 'x', 'x', '.', '.', '.', '.', '.', '.', 'x' },
                    { 'x', '.', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', '.', 'x', 'x', '.', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', '.', 'x' },
                    { 'x', '.', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', '.', 'x', 'x', '.', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', '.', 'x' },
                    { 'x', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', '.', 'x' },
                    { 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x', 'x' },
                    { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                    { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' }
                };

        }
    }
}