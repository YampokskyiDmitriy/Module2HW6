using Module2HW6.Models.Enums;

namespace Module2HW6.Models.Electronic
{
    public abstract class Electronic : Appliance
    {
        public override ApplianceType ApplienceType => ApplianceType.Electronic;
    }
}
