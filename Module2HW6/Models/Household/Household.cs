using Module2HW6.Models.Enums;

namespace Module2HW6.Models.Household
{
    public abstract class Household : Appliance
    {
        public override ApplianceType ApplienceType => ApplianceType.Household;
    }
}
