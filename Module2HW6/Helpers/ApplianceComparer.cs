using System.Collections;
using Module2HW6.Models;

namespace Module2HW6.Helpers
{
    public class ApplianceComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x == null || y == null)
            {
                return 0;
            }

            var xAppliance = x as Appliance;
            var yAppliance = y as Appliance;

            switch (xAppliance?.PowerConsumption - yAppliance?.PowerConsumption)
            {
                case > 0:
                    return 1;
                case < 0:
                    return -1;
            }

            return 0;
        }
    }
}
