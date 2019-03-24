using System;
using System.Windows.Forms;

namespace AuthentificationConcept
{
    // First of all thank you for downloading my source code.
    // I Am fairly new to coding, I never had learning courses.
    // Code may be a big mess for you, if this is the case apologies just trying to come up with something.

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void AutoLoginChk_Click(object sender, EventArgs e)
        {
            if (SaveUsernameChk.Checked & SaveUsernameChk.Checked == true)
            {

            }
            else
            {
                AutoLoginChk.Checked = false;
                MessageBox.Show("To use Auto Login feature you must use :\n \n-Save Username \n-Save Password", "#Unable to use Auto Login feature.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
