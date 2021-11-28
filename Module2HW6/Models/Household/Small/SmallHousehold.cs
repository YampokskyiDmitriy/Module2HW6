using Module2HW6.Models.Enums;

namespace Module2HW6.Models.Household.Small
{
    public abstract class SmallHousehold : Household
    {
        public override SizeType SizeType => SizeType.Small;
    }
}
