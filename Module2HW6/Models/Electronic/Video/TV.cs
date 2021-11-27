using Module2HW6.Models.Enums;

namespace Module2HW6.Models.Electronic.Video
{
    public class TV : VideoApplience
    {
        public override VideoType VideoType => VideoType.LED;

        public override SizeType SizeType => SizeType.Medium;
        public TVType TVType { get; set; }
    }
}
