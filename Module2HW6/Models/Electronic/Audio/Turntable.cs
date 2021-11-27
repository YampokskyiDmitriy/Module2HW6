using Module2HW6.Models.Enums;

namespace Module2HW6.Models.Electronic.Audio
{
    public class Turntable : AudioAppliance
    {
        public override AudioType AudioType => AudioType.Electromechanical;

        public override SizeType SizeType => SizeType.Medium;
        public TurntableType TurntableType { get; set; }
    }
}
