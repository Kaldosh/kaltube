using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KalTube
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public string Username { get { return txtUsername.Text; } set { txtUsername.Text = value; } }
        public string Password { get { return txtPassword.Text; } set { txtPassword.Text = value; } }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            System.Environment.Exit(0);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private bool setdefault = false;
        private void frmLogin_Activated(object sender, EventArgs e)
        {
            if (!setdefault)
            {
                setdefault = true;
                if (Form1.MySettings["username"] != null)
                    Username = Form1.MySettings["username"];
                txtPassword.Focus();
            }
        }
    }
}
