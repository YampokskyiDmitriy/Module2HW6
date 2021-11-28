using Module2HW6.Models;
using Module2HW6.Models.Electronic.Audio;
using Module2HW6.Models.Electronic.Video;
using Module2HW6.Models.Enums;
using Module2HW6.Models.Household.Large;
using Module2HW6.Models.Household.Small;
using Module2HW6.Provider.Abstractions;

namespace Module2HW6.Provider
{
    public class ApplianceProvider : IApplianceProvider
    {
        public Appliance[] GetAppliances()
        {
            var appliance = new Appliance[]
            {
                new Recorder() { Name = "Recorder", RecorderType = RecorderType.Reel, PowerConsumption = 17 },
                new Turntable() { Name = "Turntable", TurntableType = TurntableType.Roller, PowerConsumption = 43 },
                new Camera() { Name = "Camera", CameraType = CameraType.Case, PowerConsumption = 9 },
                new TV() { Name = "TV", TVType = TVType.Digital, PowerConsumption = 87 },
                new Conditioner { Name = "Conditioner", ConditionerType = ConditionerType.Wall, PowerConsumption = 67 },
                new Fridge { Name = "Fridge", FridgeType = FridgeType.Bicameral, PowerConsumption = 71 },
                new HairDryer { Name = "Hair Dryer", HairDryerType = HairDryerType.Styler, PowerConsumption = 10 },
                new Toaster { Name = "Toaster", ToasterType = ToasterType.Waffle, PowerConsumption = 13 }
            };

            return appliance;
        }
    }
}
