using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceTracking
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private string connectionString = ConfigurationManager.AppSettings["connectionString"];

        private void lnkForgetpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgetPassword fPassword = new frmForgetPassword();
            fPassword.ShowDialog();
        }

        private void lnkNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNewUser newUser = new frmNewUser();
            newUser.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Core.ClearTextBox(txtUserName, txtPassword);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUserName.Text))
                {
                    MessageBox.Show("Please Enter User Name.", "Tracking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUserName.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Please Enter Password.", "Tracking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }
                DbConcept db = new DbConcept();
                UserDto user = db.Login(txtUserName.Text, Core.Encrypt(txtPassword.Text));
                if (user != null)
                {
                    frmHome home = new frmHome();
                    this.Hide();
                    home.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Tracking", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}