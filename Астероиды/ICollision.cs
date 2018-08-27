using System.Drawing;

namespace Астероиды
{
    public interface ICollision
    {
        Rectangle Rect { get; }
        bool Collision(ICollision obj);
    }
}
