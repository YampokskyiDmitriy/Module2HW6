using Module2HW6.Models;

namespace Module2HW6.Services.Abstractions
{
    public interface IApplianceService
    {
        public double GetPowerConsumption();
        public Appliance[] GetAppliances();
    }
}
