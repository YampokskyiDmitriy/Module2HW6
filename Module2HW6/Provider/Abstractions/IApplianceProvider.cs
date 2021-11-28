using Module2HW6.Models;

namespace Module2HW6.Provider.Abstractions
{
    public interface IApplianceProvider
    {
        public Appliance[] GetAppliances();
    }
}
