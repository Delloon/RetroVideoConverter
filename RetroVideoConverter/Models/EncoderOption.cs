namespace RetroVideoConverter.Models
{
    public class EncoderOption
    {
        public string DisplayName { get; set; } = "";
        public string EncoderName { get; set; } = "";
        public bool IsHardware { get; set; }

        public override string ToString()
        {
            return DisplayName;
        }
    }
}