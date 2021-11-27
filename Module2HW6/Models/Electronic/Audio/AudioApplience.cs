using Module2HW6.Models.Enums;

namespace Module2HW6.Models.Electronic.Audio
{
    public abstract class AudioApplience : Electronic
    {
        public abstract AudioType AudioType { get; }
    }
}
