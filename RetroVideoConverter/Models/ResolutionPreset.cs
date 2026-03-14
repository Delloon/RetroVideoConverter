namespace RetroVideoConverter.Models
{
    public class ResolutionPreset
    {
        public string Name { get; set; } = "";
        public int MaxWidth { get; set; }
        public int MaxHeight { get; set; }

        public override string ToString()
        {
            return Name + " (" + MaxWidth + "x" + MaxHeight + ")";
        }
    }
}