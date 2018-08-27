using System.Drawing;

namespace Астероиды
{
    public abstract class BaseObject : ICollision
    {
        protected Point Pos;
        protected Point Dir;
        protected Size Size;

        protected Point TmpPos;

        public BaseObject(Point pos, Point dir, Size size)
        {
            Pos = pos;
            Dir = dir;
            Size = size;
        }

        public bool Collision(ICollision o) => o.Rect.IntersectsWith(this.Rect);
        public Rectangle Rect=> new Rectangle(Pos,Size);
        
        public abstract void Drow();

        public abstract void Update();
        
    }
}