using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;

namespace UIWindows.Views.Accounts
{
    public partial class frmConfirmationDelete : Form
    {
        public bool user { get; set; }

        public frmConfirmationDelete()
        {
            InitializeComponent();
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtSenha.Focus();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                if(!txtLogin.Text.Equals("") && !txtSenha.Text.Equals(""))
                   validationUserDel();
        }

        private void validationUserDel()
        {
            InoxErpContext ctx = new InoxErpContext();
            UsersBusiness objUser = new UsersBusiness(ctx);
            Entities.Users u = new Entities.Users
            {
                sLogin = txtLogin.Text,
                sKey = objUser.getMD5Hash(txtSenha.Text)
            };

            user = objUser.returnUserAdmin(u);
            Dispose();
        }
    }
}
