using PokemonAPI.Entities;
using PokemonAPI.Repositories.Interfaces;

namespace PokemonAPI.Services
{
    public class PokemonTypeService(IPokemonTypeRepository pokemonTypeRepository)
    {
        private readonly IPokemonTypeRepository _pokemonTypeRepository = pokemonTypeRepository;

        public List<PokemonType> GetAll()
        {
            return _pokemonTypeRepository.GetAll();
        }
    }
}
