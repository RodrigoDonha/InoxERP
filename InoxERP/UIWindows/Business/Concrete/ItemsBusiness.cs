using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWindows.Context;
using UIWindows.Entities;

namespace UIWindows.Business.Concrete
{
    public sealed class ItemsBusiness : BaseBusiness<Items>
    {
        public ItemsBusiness(InoxErpContext contextParam) : base(contextParam)
        {
            context = contextParam;
        }

        public Items returnByBudgests_OSId(string ID)
        {
            return context.Items.FirstOrDefault(r => r.Budgets_OSID == ID);
        }

    }
}
