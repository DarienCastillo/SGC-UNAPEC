using SGC_UNAPEC.Modules.Cafeterias;
using System.Windows.Forms;  //  para usar MessageBox

namespace SGC_UNAPEC
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new SGC());
        }
    }
}
