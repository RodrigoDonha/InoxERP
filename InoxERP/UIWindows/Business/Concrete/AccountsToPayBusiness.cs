using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWindows.Context;
using UIWindows.Entities;

namespace UIWindows.Business.Concrete
{
    public sealed class AccountsToPayBusiness : BaseBusiness<AccountsToPay>
    {
        public AccountsToPayBusiness(InoxErpContext contextParam) : base(contextParam)
        {
            context = contextParam;
        }
    }
}
