﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWindows;

namespace InoxERP.UI_Windows_Forms
{
    public partial class frmProviderRegister : Form
    {
        public frmProviderRegister()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
            new frmProviderSearch().Show();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
            new frmProviderSearch().Show();

        }
    }
}
