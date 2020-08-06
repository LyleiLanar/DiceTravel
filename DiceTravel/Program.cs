using System;
using System.Windows.Forms;

namespace DiceTravel
{
    static class Program
    {
        static public MainForm MainForm { get; private set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new MainForm();
            Application.Run(MainForm);
        }

        public static void MainFormActivate()
        {
            MainForm.Enabled = true;
        }
        public static void MainFormDeactivate()
        {
            MainForm.Enabled = false;
        }

    }
}
