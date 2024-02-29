using Microsoft.AspNetCore.Mvc;
using PokemonAPI.DTOs;
using PokemonAPI.Entities;
using PokemonAPI.ResponseHandlers;
using PokemonAPI.Services;
using PokemonAPI.Utils;


namespace PokemonAPI.Controllers
{
    [Route("api/pokemons")]
    [ApiController]
    public class PokemonController(PokemonService pokemonService) : ControllerBase
    {
        private readonly PokemonService _pokemonService = pokemonService;
        private readonly VerifyResponse verifyResponse = new();

        // GET: api/<PokemonController>
        [HttpGet("all")]
        public void Get()
        {
            List<Pokemon> pokemons = _pokemonService.GetAll();
            if (pokemons.Count == 0) SendResponses.SendNoContentResponse(HttpContext);
            else SendResponses.SendOkResponse(HttpContext, pokemons, "Success");
        }

        // GET api/<PokemonController>/
        [HttpGet("find/{id}")]
        public void Get(int id)
        {
            if (id < 1) {
                SendResponses.SendBadRequestResponse(HttpContext);
            }
            else verifyResponse.ExecuteAction(HttpContext, () =>
            {
                Pokemon pokemon = _pokemonService.GetPokemonById(id);
                if (pokemon == null) SendResponses.SendNotFoundResponse(HttpContext, "Pokemon not found");
                else SendResponses.SendOkResponse(HttpContext, pokemon, "Pokemon found!");
            }); 
        }

        // POST api/<PokemonController>
        [HttpPost("create")]
        public void Post(PokemonDto pokemonDto)
        {
            if (pokemonDto == null || !PokemonDto.IsValid(pokemonDto)) SendResponses.SendBadRequestResponse(HttpContext);
            else verifyResponse.ExecuteAction(HttpContext, () =>
            {
                string message = _pokemonService.AddPokemon(pokemonDto);
                SendResponses.SendOkResponse(HttpContext, "", message);
            });
        }

        // PUT api/<PokemonController>/
        [HttpPut("update/{id}")]
        public void Put(int id, [FromBody] PokemonDto pokemonDto)
        {
            if (id < 1 || pokemonDto == null || !PokemonDto.IsValid(pokemonDto))SendResponses.SendBadRequestResponse(HttpContext);
            else verifyResponse.ExecuteAction(HttpContext, () =>
            {
                string message = _pokemonService.UpdatePokemon(id, pokemonDto!);
                SendResponses.SendOkResponse(HttpContext, "", message);
            });
        }

        // DELETE api/<PokemonController>/
        [HttpDelete("delete/{id}")]
        public void Delete(int id)
        {
            if (id < 1) SendResponses.SendBadRequestResponse(HttpContext);
            else verifyResponse.ExecuteAction(HttpContext, () =>
            {
                string message = _pokemonService.DeletePokemon(id);
                SendResponses.SendOkResponse(HttpContext, "", message);
            });
        }
    }
}

