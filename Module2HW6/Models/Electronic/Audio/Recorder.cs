using Module2HW6.Models.Enums;

namespace Module2HW6.Models.Electronic.Audio
{
    public class Recorder : AudioApplience
    {
        public override AudioType AudioType => AudioType.Magnetic;

        public override SizeType SizeType => SizeType.Medium;
        public RecorderType RecorderType { get; set; }
    }
}