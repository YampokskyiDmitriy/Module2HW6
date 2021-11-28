using Module2HW6.Models.Enums;

namespace Module2HW6.Models.Electronic.Audio
{
    public abstract class AudioAppliance : Electronic
    {
        public abstract AudioType AudioType { get; }
    }
}
