using PokemonAPI.DTOs;
using PokemonAPI.Entities;
using PokemonAPI.Repositories.Interfaces;

namespace PokemonAPI.Services
{
    public class PokemonService(IPokemonRepository pokemonRepository)
    {
        private readonly IPokemonRepository _pokemonRepository = pokemonRepository;

        public List<Pokemon> GetAll()
        {
            return _pokemonRepository.GetAll();
        }
        public Pokemon GetPokemonById(int id)
        {
            return _pokemonRepository.GetPokemonById(id);
        }
        public string AddPokemon(PokemonDto pokemon)
        {
            return _pokemonRepository.AddPokemon(pokemon);
        }
        public string UpdatePokemon(int id, PokemonDto pokemon)
        {
            return _pokemonRepository.UpdatePokemon(id, pokemon);
        }
        public string DeletePokemon(int id)
        {
            return _pokemonRepository.DeletePokemon(id);
        }
    }
}
