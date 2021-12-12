namespace NemesisEngage.API.Models
{
    public class Character : BaseResource
    {
        public string Name { get; set; }
        public string Series { get; set; }
        public Attributes Attributes { get; set; }
    }
}