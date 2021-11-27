using Module2HW6.Models.Enums;

namespace Module2HW6.Models
{
    public abstract class Appliance
    {
        public abstract ApplianceType ApplienceType { get; }
        public abstract SizeType SizeType { get; }
        public double PowerConsumption { get; set; }
        public string Name { get; set; }
    }
}
