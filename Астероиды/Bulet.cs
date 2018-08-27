using System;
using System.Drawing;

namespace Астероиды
{
    public class Bulet : BaseObject
    {
        public Bulet(Point pos, Point dir, Size size) : base(pos, dir, size) { }
        public override void Drow() => Game.Buffer.Graphics.DrawRectangle(Pens.OrangeRed, Pos.X + 30, Pos.Y + 10, Size.Width, Size.Height);
        public override void Update() => Pos.X += 3;
    }
}
