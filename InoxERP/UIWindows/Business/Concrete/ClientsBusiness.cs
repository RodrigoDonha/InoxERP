using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWindows.Context;
using UIWindows.Entities;

namespace UIWindows.Business.Concrete
{
    public sealed class ClientsBusiness : BaseBusiness<Clients>
    {
        public ClientsBusiness(InoxErpContext contextParam) : base(contextParam)
        {
            context = contextParam;
        }

        public override void Delete(string id)
        {
            var linq = from q in context.Clients.Include("budgets_os").Where(c => c.sID == id).ToList() select q;
            var entity = linq.First();

            context.Set<Clients>().Remove(entity);
            context.SaveChanges();
        }
    }
}
