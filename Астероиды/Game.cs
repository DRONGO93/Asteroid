using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Астероиды
{
    static class Game
    {
        private static Timer _timer = new Timer();
        public static Random rnd = new Random();
        private static BufferedGraphicsContext _context;
        public static BufferedGraphics Buffer;
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Points { get; set; } = 0;
        public static BaseObject[] _objs;
        private static Ship _ship;

        static Game()
        { }

        public static void Init(Form form)
        {
            Graphics G;
            _context = BufferedGraphicsManager.Current;
            G = form.CreateGraphics();
            Width = form.Width;
            Height = form.Height;
            form.Text = "Астероиды";
            Buffer = _context.Allocate(G, new Rectangle(0, 0, Width, Height));

            #region События и управление временем.
            Timer timer = new Timer { Interval = 10 };
            _timer.Start();
            _timer.Tick += Timer_Tick;



            form.KeyDown += Form_KeyDown;//Подключаем управление.(Подписываемся на событие.)
                                         //Ship.MessageDie += Finish;
            #endregion
        }

        private static void Form_KeyDown(object sender, KeyEventArgs e)//Ревкция на нажатие кнопок.
        {
            if (e.KeyCode == Keys.Up) _ship.Up();
            if (e.KeyCode == Keys.Down) _ship.Down();
            if (e.KeyCode == Keys.Left) _ship.left();
            if (e.KeyCode == Keys.Right) _ship.Right();
        }

        public static void Drow()//Рендерим сцену.
        {
            Buffer.Graphics.Clear(Color.Black);

            _ship?.Drow();

            foreach (Meteor obj in _objs)
                obj.Drow();

            Buffer.Render();
        }

        public static void Finish()//Конец игры.
        {
            _timer.Stop();
            Buffer.Graphics.DrawString("Конец игры.", new Font(FontFamily.GenericSansSerif, 60, FontStyle.Underline), Brushes.White, 200, 100);
            Buffer.Render();
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            NewMeteor();
            Drow();
            Update();

        }

        public static void NewMeteor()
        {
            //_objs = new Meteor[1];
            
            for (var i = 0; i < _objs.Length; i++)
            {
                var r = rnd.Next(5, 50);
                NewMeteor(r, i);
            }
        }

        public static void Update()
        {   
            foreach (Meteor a in _objs)
            {   
                a?.Update();
                _ship?.Update();

                for (var i = 0; i < _objs.Length; i++)
                {   
                    if (_objs == null) continue;
                    
                    if (_ship.Collision(_objs[i]) && (_objs[i] != null))
                    {
                        _objs[i] = null;

                        var r = rnd.Next(5, 50);
                        NewMeteor(r, i);
                        continue;
                    }
                }
            }
        }

        public static void Load()
        {
            _ship = new Ship(new Point(10, 400), new Point(5, 5), new Size(50, 30));

            _objs = new Meteor[25];
            for (var i = 0; i < _objs.Length; i++)
            {
                var r = rnd.Next(5, 50);
                NewMeteor(r, i);
            }
        }

        public static void NewMeteor(int r,int i)
        {  
            _objs[i] = new Meteor(new Point(Game.Width, rnd.Next(0, Game.Height)), new Point(-r / 4, 0), new Size(r, r));
        }
    }

}
