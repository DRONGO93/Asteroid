using System.Drawing;

namespace Астероиды
{
    public class Meteor : BaseObject
    {
        static Image _Meteorit;

        public Meteor(Point pos, Point dir, Size size) : base (pos, dir, size)
        {
            _Meteorit = Image.FromFile("Meteor0.png");
            Pos = pos;
            Dir = dir;
            Size = size;
        }

        public override void Drow() => Game.Buffer.Graphics.DrawImage(_Meteorit, Pos.X, Pos.Y, Size.Width, Size.Height);
        
        public override void Update()
        {
            Pos.X = Pos.X + Dir.X/4;
            //Pos.Y = Pos.Y + Dir.Y/4;
            if (Pos.X < 0)
            {
                Dir.X = 0;
                Game.Del_Meteor();
            }
            //if (Pos.X < 0) Dir.X = -Dir.X;
            //if (Pos.X > Game.Width) Dir.X = -Dir.X;
            //if (Pos.Y < 0) Dir.Y = -Dir.Y;
            //if (Pos.Y > Game.Height) Dir.Y = -Dir.Y;
        }
    }
}
