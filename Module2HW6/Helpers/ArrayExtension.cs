using Module2HW6.Models;

namespace Module2HW6.Helpers
{
    public static class ArrayExtension
    {
        public static Appliance FindByPower(this Appliance[] appliances, int maxPower)
        {
            Appliance result = null;
            foreach (var appliance in appliances)
            {
                if (appliance.PowerConsumption == maxPower)
                {
                    result = appliance;
                    break;
                }
            }

            return result;
        }
    }
}