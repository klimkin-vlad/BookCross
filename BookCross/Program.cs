using System;
using System.Windows.Forms;

namespace BookCross
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainPresenter main = new MainPresenter();
            Application.Run(main.GetMainForm());
        }
    }
}
