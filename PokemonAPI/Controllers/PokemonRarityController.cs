using Microsoft.AspNetCore.Mvc;
using PokemonAPI.Entities;
using PokemonAPI.ResponseHandlers;
using PokemonAPI.Services;

namespace PokemonAPI.Controllers
{
    [Route("api/rarity")]
    [ApiController]
    public class PokemonRarityController(PokemonRarityService pokemonRarityService) : ControllerBase
    {
        private readonly PokemonRarityService _pokemonRarityService = pokemonRarityService;

        // GET: api/rarity
        [HttpGet("all")]
        public void Get()
        {
            List<PokemonRarity> rarities = _pokemonRarityService.GetAll();
            if (rarities.Count == 0) SendResponses.SendNoContentResponse(HttpContext);
            else SendResponses.SendOkResponse(HttpContext, rarities, "Success");
        }
    }
}
