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
