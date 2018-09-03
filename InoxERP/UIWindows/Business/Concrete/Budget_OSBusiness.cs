using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWindows.Context;
using UIWindows.Entities;

namespace UIWindows.Business.Concrete
{
    public sealed class Budget_OSBusiness : BaseBusiness<Budgets_OS>
    {
        public Budget_OSBusiness(InoxErpContext contextParam) : base(contextParam)
        {
            context = contextParam;
        }

        // alterar daqui para baixo
        public Users ValidateLoginEqual(Users user)
        {
            return context.Users.FirstOrDefault(u => u.sLogin == user.sLogin);
        }

        public Users signIn(Users user)
        {
            return context.Users.FirstOrDefault(u => u.sLogin == user.sLogin && u.sKey == user.sKey);
        }
    }
}
