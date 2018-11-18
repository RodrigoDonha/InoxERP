using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWindows.Business.Concrete;
using UIWindows.Context;
using UIWindows.Entities;

namespace UIWindows.Business.Concrete
{
    public sealed class CashBusiness : BaseBusiness<Cash>
    {
        public CashBusiness(InoxErpContext contextParam) : base(contextParam)
        {
            context = contextParam;
        }
    }
}
