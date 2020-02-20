using System;
using System.Windows.Forms;

namespace DiceTravel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MenuMainSignin_Click(object sender, EventArgs e)
        {
            SignUp si = new SignUp();
            si.Text = Properties.Settings.Default.projectName + " - Regisztráció";
            si.Show();
        }
        private void MenuMainQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void MenuMainLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Text = Properties.Settings.Default.projectName + " - Belépés";
            login.Show();
        }
        private void MenuMainLogout_Click(object sender, EventArgs e)
        {
            Program.LogOutUser();

        }
    }
}
