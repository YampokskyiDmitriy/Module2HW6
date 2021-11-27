using Module2HW6.Models.Enums;

namespace Module2HW6.Models.Household
{
    public abstract class Household : Applience
    {
        public override ApplienceType ApplienceType => ApplienceType.Household;
    }
}
