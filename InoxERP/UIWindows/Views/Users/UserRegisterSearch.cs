using System;
using System.Linq;
using System.Windows.Forms;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;
using UIWindows.Entities.Enum;


namespace UIWindows
{
    public partial class frmUserRegisterSearch : Form
    {
        static InoxErpContext ctx = new InoxErpContext();
        UsersBusiness obj = new UsersBusiness(ctx);
        Users userLog = new Users();
        Users user = new Users();

        public frmUserRegisterSearch(Users user)
        {
            userLog = user;
            InitializeComponent();
            fillCbxType();
        }

        //INSERT
        private void btIncluir_Click_1(object sender, EventArgs e)
        {
            if (!validationCamps())
            { }
            else
            {
                user.sLogin = txtLogin.Text;
                if (validateUserEquals(user) == null)
                {
                    Users userPersist = new Users();

                    userPersist.sID = Guid.NewGuid().ToString();

                    userPersist.sName = txtNome.Text;
                    userPersist.sLogin = txtLogin.Text;
                    userPersist.sKey = obj.getMD5Hash(txtSenha.Text);
                    userPersist.Type = validationUserType(cbxTipo.SelectedItem.ToString());

                    if (messageYesNo("insert") == DialogResult.Yes)
                    {
                        obj.Insert(userPersist);

                        var ok = obj.Search.FirstOrDefault(b => b.sID == userPersist.sID);

                        if (ok == null)
                            MessageBox.Show("Erro ao Cadastrar o Usuário !!!");
                        else
                        {
                            MessageBox.Show("Usuário Cadastrado com Sucesso !!!");
                            if (userLog.sName == "test")
                                Dispose();
                        }

                        afterAction();
                    }
                }
                else
                    MessageBox.Show("Login já cadastrado !!!  Por favor escolha outro");
            }
        }

        //UPDATE
        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (!validationCamps())
            { }
            else
            {
                Users userAlter = new Users();

                userAlter = obj.ReturnByID(lblID.Text);

                userAlter.sName = txtNome.Text;
                userAlter.sLogin = txtLogin.Text;
                userAlter.sKey = obj.getMD5Hash(txtSenha.Text);
                userAlter.Type = validationUserType(cbxTipo.SelectedItem.ToString());

                if (messageYesNo("update") == DialogResult.Yes)
                {
                    obj.Update(userAlter);

                    var ok = obj.Search.FirstOrDefault(b => b.sID == userAlter.sID);

                    if (ok == null)
                        MessageBox.Show("Erro ao Atualizar o Usuário !!!");
                    else
                        MessageBox.Show("Usuário Atualizado com Sucesso !!!");

                    afterAction();
                }
            }
        }

        //DELETE
        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (lblID.Text.Equals(""))
                MessageBox.Show("Selecione um Usuario Primeiro");
            else
            {
                user.sLogin = txtLogin.Text;
                if (userLog.sLogin == user.sLogin)
                    MessageBox.Show("Você não pode EXCLUIR seu próprio Login");
                else if (messageYesNo("delete") == DialogResult.Yes)
                {
                    obj.Delete(lblID.Text);

                    var ok = obj.Search.FirstOrDefault(b => b.sID == lblID.Text);

                    if (ok != null)
                        MessageBox.Show("Erro ao Excluir o Usuário !!!");
                    else
                        MessageBox.Show("Usuário Excluido com Sucesso !!!");

                    afterAction();
                }
            }
        }


        public void afterAction()
        {
            fillDataSet();
            cleanCamps();
        }


        //VALIDATIONS

        //validators CAMPS
        public bool validationCamps()
        {
            if (txtNome.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um Nome para o Usuário");
                txtNome.Focus();
                return false;
            }

            if (txtLogin.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe um Login para o Usuário");
                txtLogin.Focus();
                return false;
            }

            if (txtSenha.Text.Length.Equals(0))
            {
                MessageBox.Show("Informe uma Senha para o Usuário");
                txtSenha.Focus();
                return false;
            }

            if (cbxTipo.SelectedItem == null)
            {
                MessageBox.Show("Informe um Tipo para o Usuário");
                cbxTipo.Focus();
                return false;
            }
            return true;
        }

        //validators User.sLogin is diferent of other before Insert
        public Users validateUserEquals(Users user)
        {
            return obj.ValidateLoginEqual(user);
        }

        //validator DIALOG
        public DialogResult messageYesNo(string type)
        {
            switch (type)
            {
                case "insert":
                    return MessageBox.Show("Confirma a inclusão ?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "update":
                    return MessageBox.Show("Confirma a atualização ?", "Atualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "delete":
                    return MessageBox.Show("Confirma a Exclusão ?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }

            return DialogResult.No;
        }

        //validator TYPE
        public UserType validationUserType(string u)
        {
            if (u == "Administrador")
                return UserType.Admin;
            else if (u == "Básico")
                return UserType.Basic;
            else return 0;
        }


        //CLEAN
        public void cleanCamps()
        {
            lblID.Text = "";
            txtNome.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            cbxTipo.Text = "";
            cbxTipo.SelectedIndex = 1;
        }


        //FILLs

        //FILL DATASET ON LOAD
        private void frmUserRegisterSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inoxErpDBDataSet.tb_users' table. You can move, or remove it, as needed.
            if(userLog.sName != "test")
                fillDataSet();
        }
        
        //overrid FILL DATASET
        public void fillDataSet() /////*********************ARRUMAR**********************************
        {
            try
            {
                if (userLog.sLogin == "Admin" || userLog.sLogin == "jefter" || userLog.sLogin == "rodrigo")
                    this.tb_usersTableAdapter.FillByAdminType(this.fullDataSet.tb_users);
                else
                    this.tb_usersTableAdapter.FillByBasicType(this.fullDataSet.tb_users);
            }
            catch (Exception e)
            {
                MessageBox.Show("Tabela de Usuários não foi Encontrada, Certifique-se de ter criado o seu Banco de Dados !!!");
            }
            
        }

        //FILL COMBOBOX
        public void fillCbxType()
        {
            String[] names = Enum.GetNames(typeof(UserType));
            foreach (String t in names)
                if (t == "Admin")
                    cbxTipo.Items.Add("Administrador");
                else
                    cbxTipo.Items.Add("Básico");
            cbxTipo.SelectedIndex = 1;
        }

        //FILL INFORMATION CAMPS
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int compare = dgvUsuarios.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (compare == 0)
            { }
            else
            {
                cleanCamps();
                lblID.Text = dgvUsuarios[0, dgvUsuarios.CurrentRow.Index].Value.ToString();
                txtLogin.Text = dgvUsuarios[2, dgvUsuarios.CurrentRow.Index].Value.ToString();
                txtNome.Text = dgvUsuarios[1, dgvUsuarios.CurrentRow.Index].Value.ToString();
                fillType();
            }
        }

        //FILL TYPE
        public void fillType()
        {
            var t = dgvUsuarios[4, dgvUsuarios.CurrentRow.Index].Value.ToString();
            cbxTipo.Text = t == "1" ? "Administrador" : "Básico";
        }

        private void frmUserRegisterSearch_Load_1(object sender, EventArgs e)
        {
           fillDataSet();
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            user.sLogin = txtLogin.Text;
            if(validateUserEquals(user) != null)
                MessageBox.Show("Login já cadastrado !!!  Por favor escolha outro");
        }
    }
}