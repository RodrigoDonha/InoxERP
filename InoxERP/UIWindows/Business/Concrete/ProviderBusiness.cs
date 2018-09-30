﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWindows.Context;
using UIWindows.Entities;

namespace UIWindows.Business.Concrete
{
    public sealed class ProviderBusiness : BaseBusiness<Providers>
    {
        public ProviderBusiness(InoxErpContext contextParam) : base(contextParam)
        {
            context = contextParam;
        }

        public Providers returnByName(string name)
        {
            return context.Providers.FirstOrDefault(r => r.sName == name);
        }

        public Providers returnById(string id)
        {
            return context.Providers.FirstOrDefault(r => r.sID == id);
        }
    }
}