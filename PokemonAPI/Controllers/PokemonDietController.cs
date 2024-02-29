using Microsoft.AspNetCore.Mvc;
using PokemonAPI.Entities;
using PokemonAPI.ResponseHandlers;
using PokemonAPI.Services;

namespace PokemonAPI.Controllers
{
    [Route("api/diets")]
    [ApiController]
    public class PokemonDietController(PokemonDietService pokemonDietService) : ControllerBase
    {
        private readonly PokemonDietService _pokemonDietService = pokemonDietService;

        // GET: api/size
        [HttpGet("all")]
        public void Get()
        {
            List<PokemonDiet> diets = _pokemonDietService.GetAll();
            if (diets.Count == 0) SendResponses.SendNoContentResponse(HttpContext);
            else SendResponses.SendOkResponse(HttpContext, diets, "Success");
        }
    }
}
