namespace NemesisEngage.API.Models.Requests
{
    public class CharacterCreateRequest
    {
        public string Name { get; set; }
        public string Series { get; set; }
        public Attributes Attributes { get; set; }
    }
}