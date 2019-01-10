using InoxERP;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;
using UIWindows.Entities.Enum;
using UIWindows.Views.Users;

namespace UIWindows
{
    public partial class frmSignIn : Form
    {
        static InoxErpContext context = new InoxErpContext();
        UsersBusiness UserBusiness = new UsersBusiness(context);
        public Users user = new Users();
        public bool log { get; set; } = false;

        public frmSignIn()
        {
            InitializeComponent();
        }

       private void btnAcessar_Click(object sender, EventArgs e)
        {
            user.sLogin = txtLogin.Text;
            user.sKey = UserBusiness.getMD5Hash(txtSenha.Text); // ___JR@2018***
            //user.sKey = txtSenha.Text; // ___JR@2018***

            //if (user.sLogin == "test" && user.sKey == "___JR@2018***")
            if (!txtLogin.Text.Equals("") && !txtSenha.Text.Equals(""))
                if (user.sLogin == "test" && user.sKey == "EA44959B528B2DE4D143BEABB30970BE")
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
                    this.Hide();
                    
                    frmChargingScreen login = new frmChargingScreen(user);

                    login.ShowDialog();

                    user = login.u;
                    log = login.log;

                    Dispose();
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
            if (!txtLogin.Text.Equals(""))
                if (e.KeyChar == 13)
                {
                    txtSenha.Focus();
                }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!txtSenha.Text.Equals(""))
                if (e.KeyChar == 13)
                {
                    btnAcessar_Click(sender,e);
                }
        }

        private void btnVisualizarSenha_Click(object sender, EventArgs e)
        {

            if (txtSenha.UseSystemPasswordChar)
            {
                txtSenha.UseSystemPasswordChar = false;
                btnVisualizarSenha.FlatAppearance.BorderSize = 1;
                btnVisualizarSenha.FlatAppearance.BorderColor = Color.Red;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                btnVisualizarSenha.FlatAppearance.BorderSize = 0;
                btnVisualizarSenha.FlatAppearance.BorderColor = Color.White;
            }
            
        }
    }
}
