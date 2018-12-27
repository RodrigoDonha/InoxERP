using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;
using UIWindows.Entities.Enum;

namespace UIWindows.Business.Concrete
{
    public sealed class CashBusiness : BaseBusiness<Cash>
    {
        public CashBusiness(InoxErpContext contextParam) : base(contextParam)
        {
            context = contextParam;
        }

        public decimal returnBalance(decimal cash)
        {
            decimal Sum = ReturnAll().ToList().Where(e => e.CashType == CashType.Enter).Sum(e=>e.dValue) - ReturnAll().ToList().Where(e => e.CashType == CashType.Out).Sum(e => e.dValue);
            
            Sum = Sum + cash;

            return Sum;
        }
    }
}
