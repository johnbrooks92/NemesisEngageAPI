using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NemesisEngage.API.Models;
using NemesisEngage.API.Models.Requests;
using NemesisEngage.API.Services;
using Swashbuckle.AspNetCore.Annotations;


namespace NemesisEngage.API.Controllers
{
    [ApiController]
    [Route("characters")]
    public class CharacterController : ControllerBase
    {
        private readonly CharacterService _characterService;
        public CharacterController(CharacterService characterService)
        {
            _characterService = characterService;
        }
        
        [HttpPost]
        [SwaggerResponse(StatusCodes.Status201Created, null, typeof(Character))]
        [SwaggerResponse(StatusCodes.Status400BadRequest, null, typeof(string))]
        [SwaggerResponse(StatusCodes.Status422UnprocessableEntity, "", typeof(string))]
        public async Task<IActionResult> Create(CharacterCreateRequest request)
        {
            var resource = await _characterService.CreateCharacter(request);
            return resource != null ? Created($"/characters/{resource.Id}", resource ) : UnprocessableEntity();
        }
    }
}