using Microsoft.AspNetCore.Mvc;
using PokemonAPI.Entities;
using PokemonAPI.ResponseHandlers;
using PokemonAPI.Services;

namespace PokemonAPI.Controllers
{
    [Route("api/types")]
    [ApiController]
    public class PokemonTypeController(PokemonTypeService pokemonTypeService): ControllerBase
    {
        private readonly PokemonTypeService _pokemonTypeService = pokemonTypeService;

        // GET: api/type
        [HttpGet("all")]
        public void Get()
        {
            List<PokemonType> types = _pokemonTypeService.GetAll();
            if (types.Count == 0) SendResponses.SendNoContentResponse(HttpContext);
            else SendResponses.SendOkResponse(HttpContext, types, "Success");
        }
    }
}
