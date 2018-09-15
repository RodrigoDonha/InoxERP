﻿using System;
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

        public Budgets_OS returnByName(string name)
        {
            return context.Budgets_OS.FirstOrDefault(r=>r.sName == name);
        }

        public Budgets_OS returnByDate(DateTime date)
        {
            return context.Budgets_OS.FirstOrDefault(r => r.dtDate.ToShortDateString() == date.ToShortDateString());
        }
        
    }
}
