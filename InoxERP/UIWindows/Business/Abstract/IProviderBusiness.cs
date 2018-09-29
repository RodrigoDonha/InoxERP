using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWindows.Entities;

namespace UIWindows.Business.Abstract
{
    public interface IProviderBusiness : IBusiness<Providers>
    {
        Providers returnByName(string name);
    }
}
