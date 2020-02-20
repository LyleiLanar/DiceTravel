using System;
using System.Windows.Forms;

namespace DiceTravel
{
    static class Program
    {
        static public MainForm mainForm;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new MainForm();
            Application.Run(mainForm);
        }
       
    }
}
