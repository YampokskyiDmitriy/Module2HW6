using Module2HW6.Models;
using Module2HW6.Provider.Abstractions;
using Module2HW6.Services.Abstractions;

namespace Module2HW6.Services
{
    public class ApplianceService : IApplianceService
    {
        public ApplianceService(IApplianceProvider applianceProvider)
        {
            Appliances = applianceProvider.GetAppliances();
        }

        private Appliance[] Appliances { get; set; }

        public Appliance[] GetAppliances()
        {
            return Appliances;
        }

        public double GetPowerConsumption()
        {
            var result = 0d;

            foreach (var appliance in Appliances)
            {
                result += appliance.PowerConsumption;
            }

            return result;
        }
    }
}
