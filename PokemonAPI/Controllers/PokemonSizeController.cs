using Microsoft.AspNetCore.Mvc;
using PokemonAPI.Entities;
using PokemonAPI.ResponseHandlers;
using PokemonAPI.Services;

namespace PokemonAPI.Controllers
{
    [Route("api/size")]
    [ApiController]
    public class PokemonSizeController(PokemonSizeService pokemonSizeService) : ControllerBase
    {
        private readonly PokemonSizeService _pokemonSizeService = pokemonSizeService;
        // GET: api/size
        [HttpGet("all")]
        public void Get()
        {
            List<PokemonSize> sizes = _pokemonSizeService.GetAll();
            if (sizes.Count == 0) SendResponses.SendNoContentResponse(HttpContext);
            else SendResponses.SendOkResponse(HttpContext, sizes, "Success");
        }
    }
}
