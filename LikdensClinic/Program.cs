using System;
using System.Windows.Forms;
using LikdensClinic.View;
using LikdensClinic.Model;
using LikdensClinic.Presenter;

namespace LikdensClinic
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IMainPresenter presenter = new MainPresenter(new MainModel(), new MainView());
            if(presenter != null)
                presenter.Run();
        }
    }
}
