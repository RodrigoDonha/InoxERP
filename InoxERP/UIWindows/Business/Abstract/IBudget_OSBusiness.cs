using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWindows.Entities;

namespace UIWindows.Business.Abstract
{
    public interface IBudget_OSBusiness : IBusiness<Budgets_OS>
    {
        Budgets_OS returnByName(string name);
    }

    
}
