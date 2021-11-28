using System;
using Module2HW6.Helpers;
using Module2HW6.Models;
using Module2HW6.Services.Abstractions;

namespace Module2HW6
{
    public class App
    {
        private readonly IApplianceService _applianceService;

        public App(IApplianceService applianceService)
        {
            _applianceService = applianceService;
        }

        public void Run()
        {
            var appliances = _applianceService.GetAppliances();

            Sort(appliances);
            GetPowerConsumption(appliances);
            Find(appliances);
        }

        public void GetPowerConsumption(Appliance[] appliances)
        {
            Console.WriteLine(_applianceService.GetPowerConsumption());
        }

        public void Sort(Appliance[] appliances)
        {
            Array.Sort(appliances, new ApplianceComparer());
            foreach (var appliance in appliances)
            {
                Console.WriteLine($"{appliance.Name}: {appliance.PowerConsumption}");
            }
        }

        public void Find(Appliance[] appliances)
        {
            var result = appliances.FindByPower(13);
            Console.WriteLine(result.Name);
        }
    }
}