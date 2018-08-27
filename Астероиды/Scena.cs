using System;
using System.Windows.Forms;
using System.Drawing;


namespace Астероиды
{
    class Scena
    {
        //
        //private static BufferedGraphicsContext _context;
        //public static BufferedGraphics Buffer;
        //public static int Width { get; set; }
        //public static int Height { get; set; }

        ////public static event Message MessageDie;

        //public static void Init(Form form)//Инициализация
        //{   
        //    Graphics G;
        //    _context = BufferedGraphicsManager.Current;
        //    G = form.CreateGraphics();
        //    Width = form.Width;
        //    Height = form.Height;
        //    Buffer = _context.Allocate(G, new Rectangle(0, 0, Width, Height));

        //    //Заводим таймер времени.
        //    Timer time = new Timer {Interval = 100};
        //    time.Start();
        //    time.Tick += new EventHandler(Timer_Tick); //Каждую секунду запускаем.
        //}

        //public static void DrowFon()//Рисуем фон
        //{
        //    Buffer.Graphics.Clear(Color.Black);
        //    Buffer.Render();
        //}

        //public static void DrowMeteor()//Рисуем метеорит. Пытаюсь перенести в класс объектов.
        //{
        //    Image Kartinka = Image.FromFile("Meteor0.png");
        //    Bitmap Meteor = new Bitmap(Kartinka);
        //    Graphics g = Graphics.FromImage(Meteor);
        //    int XSize = 40; int YSize = 40;
        //    int LocationX = 50;
        //    int LocationY = 50;
        //    Buffer.Graphics.DrawImage(Meteor, LocationX, LocationY, XSize, YSize);
        //    Buffer.Render();
        //}

        ////public int Hmet { get; set; }

        //private static void Timer_Tick(object Sender, EventArgs e)//Запускаемся каждую секунду.
        //{
        //    //int Hmet = Random(int 1, int 5);//Диапазон кол-во метеоритов появляющихся в 1 сек.
        //    //for (int i = 0; i < Hmet; i++)
        //    //{
        //    //    DrowMeteor();
        //    //}
        //}

        //public int Random(int Min, int Max)//Люблю рандом. Он мне понадобится.
        //{
        //    Random rnd = new Random();
        //    try //Безопасный рендом.
        //    {
        //        int value = rnd.Next(Min, Max);
        //        return value;
        //    }
        //    catch
        //    {
        //        return 0;
        //    }
        //}

        //public int HPregen(int HP)
        //{
        //    HP = HP + 50;
        //    return HP;
        //}

        //class Meteor
        //{
        //    public int XSize;
        //    public int YSize;
        //    public int LocationX;
        //    public int LocationY;
        //}

        //class Ship : BaseObject
        //{
        //    private int _HP = 100;
        //    public int Hp => _HP;

        //    public void HPlow(int n)
        //    {
        //        _HP -= n;
        //    }

        //    public Ship(Point pos, Point dir, Size size) : base(pos, dir, size)
        //    {}

        //    //public override void Drow()
        //    //{
        //    //    Game.Buffer.Graphics.FillEllipse(Brushes.Wheat, Pos.X, Pos.Y, Size.Width, Size.Height);
        //    //}

        //    public override void Update()
        //    {
        //        //base.Update();

        //        //foreach (BaseObject obj in _objs) obj.Update(); //Очень интересный куплет.
        //        //_bullet?.Update();
        //        //for (var i = 0; i < _asteroids.Length; i++)
        //        //{
        //        //    if (_asteroids[i] == null) continue;
        //        //    _asteroids[i].Update();
        //        //    if (_bullet != null && _bullet.Collision(_asteroids[i]))
        //        //    {
        //        //        System.Media.SystemSounds.Hand.Play();
        //        //        _asteroids[i] = null;
        //        //        _bullet = null;
        //        //        continue;
        //        //    }
        //        //    if (!_ship.Collision(_asteroids[i])) continue;
        //        //    var rnd = new Random();
        //        //    _ship?.HPLow(rnd.Next(1, 10));
        //        //    System.Media.SystemSounds.Asterisk.Play();
        //        //    if (_ship.HPLow <= 0) _ship?.Die(); //Смерть шипа ри HP = 0.
        //        //}
        //    }

        //    public void Up()
        //    {
        //        if (Pos.Y > 0) Pos.Y = Pos.Y - Dir.Y;
        //    }

        //    public void Down()
        //    {
        //        if (Pos.Y < Game.Height) Pos.Y = Pos.Y + Dir.Y;
        //    }

        //    public void Die()
        //    { }

        //    public static void DrowShip()
        //    {
        //        //Buffer.Graphics.Clear(Color.Black);
        //        //foreach (BaseObject obj in _objs)
        //        //    obj.Drow();
        //        //foreach (Asteroid a in _asteroids)
        //        //{
        //        //    a?.Drow();
        //        //}
        //        //_bullet?.Drow();
        //        //_ship?.Drow();
        //        //if (_ship != null)
        //        //    Buffer.Graphics.DrawString("Здоровье:" + _ship.HP, SystemFonts.DefaultFont, Brushes.Wheat, 0, 0);
        //        //Buffer.Render();
        //    }

        //    //public void Die()
        //    //{
        //    //    MessageDie?.Invoke();
        //    //}
        //}
    }
}
