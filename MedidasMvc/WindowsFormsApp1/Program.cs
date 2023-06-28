using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            ConverterView view = new ConverterView();
            view.Visible = false;

            MedidasModel model = new MedidasModel();

            MedidasController controller = new MedidasController(view, model);
            view.ShowDialog();


           // Application.EnableVisualStyles();
           // Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new ConverterView());
        }
    }
}
