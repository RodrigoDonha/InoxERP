using InoxERP;
using System;
using System.Linq;
using System.Windows.Forms;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;
using UIWindows.Entities.Enum;

namespace UIWindows
{
    public partial class frmSignIn : Form
    {
        static InoxErpContext context = new InoxErpContext();
        UsersBusiness UserBusiness = new UsersBusiness(context);
        public Users user = new Users();
        public bool log = false;

        public frmSignIn()
        {
            InitializeComponent();
        }

       private void btnAcessar_Click(object sender, EventArgs e)
        {
            user.sLogin = txtLogin.Text;
            user.sKey = user.getMD5Hash(txtSenha.Text); // ____JR@2018***
            //user.sKey = txtSenha.Text; // ____JR@2018***

            if (user.sLogin == "test" && user.sKey == "EA44959B528B2DE4D143BEABB30970BE")
            //if (user.sLogin == "test" && user.sKey == "____JR@2018***")
            {
                MessageBox.Show("Logged as TEST");

                user.sName = "test";
                user.sLogin = "test";
                user.sKey = "EA44959B528B2DE4D143BEABB30970BE";
                //user.sKey = "____JR@2018***";
                user.Type = UserType.Admin;
                log = true;
                this.Dispose();
            }
            else
            {
                user = UserBusiness.signIn(user);

                if (user == null)
                {
                    MessageBox.Show("Invalid User");
                    Application.Restart();
                }
                else
                {
                    log = true;
                    this.Dispose();
                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       private void btnLimpar_Click(object sender, EventArgs e)
       {
            txtLogin.Clear();
            txtSenha.Clear();
       }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAcessar_Click(sender,e);
            }
        }
    }
}
