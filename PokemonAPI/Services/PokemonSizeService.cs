using PokemonAPI.Entities;
using PokemonAPI.Repositories.Interfaces;

namespace PokemonAPI.Services
{
    public class PokemonSizeService(IPokemonSizeRepository pokemonSizeRepository)
    {
        private readonly IPokemonSizeRepository _pokemonSizeRepository = pokemonSizeRepository;

        public List<PokemonSize> GetAll()
        {
            return _pokemonSizeRepository.GetAll();
        }
    }
}
