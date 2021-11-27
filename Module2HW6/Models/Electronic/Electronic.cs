using Module2HW6.Models.Enums;

namespace Module2HW6.Models.Electronic
{
    public abstract class Electronic : Applience
    {
        public override ApplienceType ApplienceType => ApplienceType.Electronic;
    }
}
