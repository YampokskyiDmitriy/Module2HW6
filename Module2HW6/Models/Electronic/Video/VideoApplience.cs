using Module2HW6.Models.Enums;

namespace Module2HW6.Models.Electronic.Video
{
    public abstract class VideoApplience : Electronic
    {
        public abstract VideoType VideoType { get; }
    }
}
