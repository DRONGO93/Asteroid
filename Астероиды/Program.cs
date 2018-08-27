using System;
using System.Windows.Forms;

namespace Астероиды
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {   
            Form form = new Form();
            //Настройки окна.
            form.Width = 800;
            form.Height = 600;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            Game.Init(form);
            Game.Load();
            Game.Drow();
            Game.Update();
            form.Show();
            Application.Run(form);
        }
    }
}
