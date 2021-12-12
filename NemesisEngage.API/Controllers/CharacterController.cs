using NemesisEngage.API.Services;

namespace NemesisEngage.API.Controllers
{
    public class CharacterController
    {
        private readonly CharacterService _characterService;
        public CharacterController(CharacterService characterService)
        {
            _characterService = characterService;
        }
    }
}