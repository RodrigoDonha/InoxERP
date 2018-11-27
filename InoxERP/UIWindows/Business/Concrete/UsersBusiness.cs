using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWindows.Context;
using UIWindows.Entities;

namespace UIWindows.Business.Concrete
{
    public sealed class UsersBusiness : BaseBusiness<Users>
    {
        public UsersBusiness(InoxErpContext contextParam) : base(contextParam)
        {
            context = contextParam;
        }

        public Users ValidateLoginEqual(Users user)
        {
            try
            {
                return context.Users.FirstOrDefault(u => u.sLogin == user.sLogin);
            }
            catch (Exception e)
            {
                if (errorMessage("equal") == DialogResult.Yes)
                    MessageBox.Show(e.InnerException.InnerException.ToString());

                return null;
            }
        }

        public Users signIn(Users user)
        {
            try
            {
                return context.Users.FirstOrDefault(u => u.sLogin == user.sLogin && u.sKey == user.sKey);
            }
            catch (Exception e)
            {
                if (errorMessage("login") == DialogResult.Yes)
                    MessageBox.Show(e.InnerException.InnerException.ToString());

                return null;
            }
        }

        //ERROR MESSAGES
        private DialogResult errorMessage(string type)
        {
            switch (type)
            {
                case "login":
                    return MessageBox.Show("Erro no Login de Usuário, Deseja ver a menssagem de Erro?", "ERRO AO CONSULTAR O USUÁRIO", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                case "equal":
                    return MessageBox.Show("Erro na Validação de Logins Iguais, Deseja ver a menssagem de Erro?", "ERRO AO VALIDAR O LOGIN", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            }

            return DialogResult.No;
        }


        //Convert password to MD5 Criptography
        public string getMD5Hash(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }
    }
}
