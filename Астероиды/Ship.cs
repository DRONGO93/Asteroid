using System;
using System.Drawing;

namespace Астероиды
{
    public class Ship : BaseObject
    {
        static Image _ship;

        public Ship(Point pos, Point dir, Size size) : base(pos, dir, size)
        {
            _ship = Image.FromFile("Ship0.png");
            Pos = pos; Dir = dir; Size = size;
        }

        public override void Drow() => Game.Buffer.Graphics.DrawImage(_ship, Pos.X, Pos.Y, Size.Width, Size.Height);

        public override void Update() { }

        public void Up()
        {if (Pos.Y > 0) Pos.Y = Pos.Y - Dir.Y;}

        public void Down()
        {if (Pos.Y < Game.Height - 30) Pos.Y = Pos.Y + Dir.Y;}

        public void left()
        {if (Pos.X > 0) Pos.X = Pos.X - Dir.X;}

        public void Right()
        {if (Pos.X < Game.Width - 50) Pos.X = Pos.X + Dir.X;}

    }
}
