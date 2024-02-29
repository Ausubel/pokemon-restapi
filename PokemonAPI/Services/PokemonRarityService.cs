using PokemonAPI.Entities;
using PokemonAPI.Repositories.Interfaces;

namespace PokemonAPI.Services
{
    public class PokemonRarityService(IPokemonRarityRepository pokemonRarityRepository)
    {
        private readonly IPokemonRarityRepository _pokemonRarityRepository = pokemonRarityRepository;
        public List<PokemonRarity> GetAll()
        {
            return _pokemonRarityRepository.GetAll();
        }
    }
}
