using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIWindows.Context;
using UIWindows.Entities;

namespace UIWindows.Business.Concrete
{
    public sealed class ProductBusiness : BaseBusiness<Products>
    {
        public ProductBusiness(InoxErpContext contextParam) : base(contextParam)
        {
            context = contextParam;
        }

        public Products ReturnByProductsId(string ID)
        {
            return context.Products.FirstOrDefault(r => r.sID == ID);
        }
    }
}
