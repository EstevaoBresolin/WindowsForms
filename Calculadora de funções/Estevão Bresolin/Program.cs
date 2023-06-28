using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estevão_Bresolin
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form1 view = new Form1();
            view.Visible = false;

            Calcula_Fracoes_Model model = new Calcula_Fracoes_Model();

            Controller controller = new Controller(view, model);
            view.ShowDialog();
        }
    }
}
