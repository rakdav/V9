using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using V9.Controller;
using V9.View;

namespace V9
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainView mainView = new MainView();
            mainView.Visible = false;

        }
    }
}
