using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIWindows.Entities
{
    public class Permitions : BaseEntity
    {
        public bool bRegisters { get; set; }

        public bool bBudgets { get; set; }

        public bool bServicesOrders { get; set; }

        public bool bDeliverys { get; set; }

        public bool bAccounts { get; set; }

        public bool bCash { get; set; }

        public bool bReports { get; set; }

        public bool bBackups { get; set; }
        
        public bool bPermitions { get; set; }
    }

}
