using UIWindows.Context;
using UIWindows.Entities;

namespace UIWindows.Business.Concrete
{
    public sealed class ParcialToReceiveBusiness : BaseBusiness<ParcialReceive>
    {
        public ParcialToReceiveBusiness(InoxErpContext contextParam) : base(contextParam)
        {
            context = contextParam;
        }
    }
}
