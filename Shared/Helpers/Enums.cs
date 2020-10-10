using System;
namespace Shared
{
    internal enum Direcction
    {
        Right,
        Left,
        Up,
        Down
    }

    internal enum State
    {
        Stop,
        Moving
    }

    internal class MoveTo
    {
        public Direcction direcction;
        public float distance;
        public MoveTo(Direcction direcction, float distance)
        {
            this.direcction = direcction;
            this.distance = distance;
        }
    }
}
