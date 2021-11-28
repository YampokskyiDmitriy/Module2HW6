using Module2HW6.Models.Enums;

namespace Module2HW6.Models.Electronic.Video
{
    public abstract class VideoAppliance : Electronic
    {
        public abstract VideoType VideoType { get; }
    }
}
