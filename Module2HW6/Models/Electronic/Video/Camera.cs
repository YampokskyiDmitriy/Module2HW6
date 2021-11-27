using Module2HW6.Models.Enums;

namespace Module2HW6.Models.Electronic.Video
{
    public class Camera : VideoApplience
    {
        public override VideoType VideoType => VideoType.IPS;

        public override SizeType SizeType => SizeType.Small;
        public CameraType CameraType { get; set; }
    }
}
