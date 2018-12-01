using UIWindows.Entities;

namespace UIWindows.Business.Abstract
{
    public interface IContractBusiness : IBusiness<Contracts>
    {
        Contracts returnByName(string name);
    }
}
