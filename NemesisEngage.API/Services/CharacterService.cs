using System.Threading.Tasks;
using NemesisEngage.API.Models;
using NemesisEngage.API.Models.Requests;
using NemesisEngage.API.Repositories.Interfaces;

namespace NemesisEngage.API.Services
{
    public class CharacterService
    {
        private readonly IMongoRepository<Character> _characterRepository;
        public CharacterService(IMongoRepository<Character> characterRepository)
        {
            _characterRepository = characterRepository;
        }

        public async Task<Character> CreateCharacter(CharacterCreateRequest request)
        {
            Character character = new Character(request);
            return await _characterRepository.Create(character);
        }
    }
}