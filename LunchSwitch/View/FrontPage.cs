using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchSwitch
{
    public partial class FrontPage : Form
    {
        public FrontPage()
        {
            InitializeComponent();
            this.Width = 1000;
            this.Height = 600;
            this.CenterToScreen();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(txtUserIdLogIn.Text == "" || txtPassword.Text == "")
            {
                lblLogInMessage.Text = "You must fill in both fields";
            }
        }
    }
}
