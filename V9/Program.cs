using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using V9.Controller;
using V9.Model;
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
            List<Material> materials = new List<Material>();
            using (ModelDB db=new ModelDB())
            {
                materials = db.Material.ToList();
            }
            MainController controller = new MainController(mainView, materials);
            controller.AddPagination();
            controller.LoadView(1);
            controller.AddTypeOfMaterial();
            mainView.ShowDialog();
        }
    }
}
