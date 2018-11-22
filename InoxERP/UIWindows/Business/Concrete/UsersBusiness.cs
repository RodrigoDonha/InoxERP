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
            return context.Users.FirstOrDefault(u => u.sLogin == user.sLogin);
        }

        public Users signIn(Users user)
        {
            return context.Users.FirstOrDefault(u => u.sLogin == user.sLogin && u.sKey == user.sKey);
        }

        //Convet password to MD5 Criptography
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
