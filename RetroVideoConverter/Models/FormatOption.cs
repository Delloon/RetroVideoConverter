namespace RetroVideoConverter.Models
{
    public class FormatOption
    {
        public string Name { get; set; } = "";
        public string Extension { get; set; } = "";

        public override string ToString()
        {
            return $"{Name} (*.{Extension})";
        }
    }
}