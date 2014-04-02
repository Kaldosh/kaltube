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
    public partial class frmInputBox : Form
    {
        private frmInputBox()
        {
            InitializeComponent();
        }

        private void frmInputBox_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// shows a prompt with the given text, and allows user input. Returns the input on OK, or null on cancel. input field defaults to defaultText
        /// </summary>
        public static string InputBox(string prompt, string defaultText)
        {
            var frm = new frmInputBox();
            frm.lblPrompt.Text = prompt;
            frm.txtInput.Text = defaultText;
            var result = frm.ShowDialog();
            if (result == DialogResult.Cancel) return null; else return frm.txtInput.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
