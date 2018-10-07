using System;
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

        public override void Delete(string id)
        {
            var linq = from q in context.Providers.Include("products").Where(c => c.sID == id).ToList() select q;
            var entity = linq.First();

            context.Set<Providers>().Remove(entity);
            context.SaveChanges();
        }
    }
}
