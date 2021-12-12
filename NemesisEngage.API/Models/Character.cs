using System;
using NemesisEngage.API.Models.Requests;

namespace NemesisEngage.API.Models
{
    public class Character : BaseResource
    {
        public string Name { get; set; }
        public string Series { get; set; }
        public Attributes Attributes { get; set; }
        
        public Character() {}

        public Character(CharacterCreateRequest request)
        {
            Id = request.Name?.Replace(" ", "-").ToLower();
            Name = request.Name;
            Series = request.Series;
            Attributes = request.Attributes;
        }
    }
}