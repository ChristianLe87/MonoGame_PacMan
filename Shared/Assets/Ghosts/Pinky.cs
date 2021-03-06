﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Shared
{
    public class Pinky : IGhosts
    {
        public Point point;
        public Texture2D texture2D;
        Direcction direcction;
        int moveSpeed = 1;
        int framesCount = 0;

        public Pinky(Point point)
        {
            this.point = /*point*/new Point(15, 14);
            this.texture2D = Tools.GetTexture(WK.Content.Ghosts);
            this.direcction = Direcction.Up;
        }


        public void Update()
        {
            framesCount++;

            if (framesCount == 20)
            {
                framesCount = 0;

                // 4 tiles infront of PacMan
                Point playerPosition = GameScene.player.point;
                if (GameScene.player.direcction == Direcction.Right)
                {
                    playerPosition.X = playerPosition.X + 4;
                }
                else if (GameScene.player.direcction == Direcction.Left)
                {
                    playerPosition.X = playerPosition.X - 4;
                }
                else if (GameScene.player.direcction == Direcction.Up)
                {
                    playerPosition.Y = playerPosition.Y - 4;
                }
                else if (GameScene.player.direcction == Direcction.Down)
                {
                    playerPosition.Y = playerPosition.Y + 4;
                }

                float distanceToPlayerUp = Tools.DistanceToPlayer(playerPosition, new Point(point.X, point.Y - 1));
                float distanceToPlayerRight = Tools.DistanceToPlayer(playerPosition, new Point(point.X + 1, point.Y));
                float distanceToPlayerDown = Tools.DistanceToPlayer(playerPosition, new Point(point.X, point.Y + 1));
                float distanceToPlayerLeft = Tools.DistanceToPlayer(playerPosition, new Point(point.X - 1, point.Y));


                List<MoveTo> distances = new List<MoveTo>
                {
                    new MoveTo(Direcction.Up, distanceToPlayerUp),
                    new MoveTo(Direcction.Right, distanceToPlayerRight),
                    new MoveTo(Direcction.Down, distanceToPlayerDown),
                    new MoveTo(Direcction.Left, distanceToPlayerLeft)
                };





                // delete all not possible direcctions (if a wall is on the left, dont give an option to go left)
                if (Get_If_Is_Wall.Up(this.point))
                {
                    distances = distances.Where(x => x.direcction != Direcction.Up).ToList();
                }

                if (Get_If_Is_Wall.Right(this.point))
                {
                    distances = distances.Where(x => x.direcction != Direcction.Right).ToList();
                }

                if (Get_If_Is_Wall.Down(this.point))
                {
                    distances = distances.Where(x => x.direcction != Direcction.Down).ToList();
                }

                if (Get_If_Is_Wall.Left(this.point))
                {
                    distances = distances.Where(x => x.direcction != Direcction.Left).ToList();
                }




                // Gohsts cant move backward
                if (direcction == Direcction.Up)
                {
                    distances = distances.Where(x => x.direcction != Direcction.Down).ToList();
                }

                else if (direcction == Direcction.Right)
                {
                    distances = distances.Where(x => x.direcction != Direcction.Left).ToList();
                }

                else if (direcction == Direcction.Down)
                {
                    distances = distances.Where(x => x.direcction != Direcction.Up).ToList();
                }

                else if (direcction == Direcction.Left)
                {
                    distances = distances.Where(x => x.direcction != Direcction.Right).ToList();
                }



                var minDis = distances.OrderBy(x => x.distance).First().distance;

                if (distanceToPlayerUp <= minDis && Get_If_Is_Wall.Up(this.point) == false)
                {
                    direcction = Direcction.Up;
                    Move();
                }
                else if (distanceToPlayerRight <= minDis && Get_If_Is_Wall.Right(this.point) == false)
                {
                    direcction = Direcction.Right;
                    Move();
                }
                else if (distanceToPlayerDown <= minDis && Get_If_Is_Wall.Down(this.point) == false)
                {
                    direcction = Direcction.Down;
                    Move();
                }
                else if (distanceToPlayerLeft <= minDis && Get_If_Is_Wall.Left(this.point) == false)
                {
                    direcction = Direcction.Left;
                    Move();
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (direcction == Direcction.Up)
                spriteBatch.Draw(texture2D, new Rectangle(point.X * WK.W, point.Y * WK.H, WK.W, WK.H), new Rectangle(0, 20, 20, 20), Color.White);
            else if (direcction == Direcction.Down)
                spriteBatch.Draw(texture2D, new Rectangle(point.X * WK.W, point.Y * WK.H, WK.W, WK.H), new Rectangle(20, 20, 20, 20), Color.White);
            else if (direcction == Direcction.Left)
                spriteBatch.Draw(texture2D, new Rectangle(point.X * WK.W, point.Y * WK.H, WK.W, WK.H), new Rectangle(40, 20, 20, 20), Color.White);
            else if (direcction == Direcction.Right)
                spriteBatch.Draw(texture2D, new Rectangle(point.X * WK.W, point.Y * WK.H, WK.W, WK.H), new Rectangle(60, 20, 20, 20), Color.White);
        }

        private void Move()
        {
            if (direcction == Direcction.Left)
            {
                point.X -= moveSpeed;
            }
            else if (direcction == Direcction.Right)
            {
                point.X += moveSpeed;
            }
            else if (direcction == Direcction.Up)
            {
                point.Y -= moveSpeed;
            }
            else if (direcction == Direcction.Down)
            {
                point.Y += moveSpeed;
            }
        }
    }
}
