using System;
using System.Windows.Forms;

namespace DiceTravel
{
    static class Program
    {

        static MainForm mainForm;
        static public User ActiveUser { get; private set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new MainForm();

            Application.Run(mainForm);
        }
        static public void LogOutUser()
        {
            Program.ActiveUser = null;
            DeactivateControls();
            RefreshMainFormUserData();
        }
        static public void LogInUser(string loginName, string password)
        {
            Program.ActiveUser = User.GetAuthenticatedUser(loginName, password);
            ActivateControls();
            RefreshMainFormUserData();
        }
        private static void DeactivateControls()
        {
            mainForm.GrpBxUserData.Visible = false;
            mainForm.GrpBxMainFrame.Visible = false;
        }
        private static void ActivateControls()
        {
            mainForm.GrpBxUserData.Visible = true;
            mainForm.GrpBxMainFrame.Visible = true;
        }
        private static void RefreshMainFormUserData()
        {
            if (Program.ActiveUser != null)
            {
                mainForm.TxtUserDataLoginName.Text = ActiveUser.LoginName;
                mainForm.TxtUserDataRealName.Text = ActiveUser.Surname + ActiveUser.Firstname;
                mainForm.TxtUserDataBirthDate.Text = ActiveUser.BirthDate.Substring(0, 12);
            }
            else
            {
                mainForm.TxtUserDataLoginName.Text = "-";
                mainForm.TxtUserDataRealName.Text = "-";
                mainForm.TxtUserDataBirthDate.Text = "-";
            }
        }
    }
}
