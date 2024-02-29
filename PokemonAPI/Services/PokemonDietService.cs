using PokemonAPI.Entities;
using PokemonAPI.Repositories.Interfaces;

namespace PokemonAPI.Services
{
    public class PokemonDietService(IPokemonDietRepository pokemonDietRepository)
    {
        private readonly IPokemonDietRepository _pokemonDietRepository = pokemonDietRepository;

        public List<PokemonDiet> GetAll()
        {
            return _pokemonDietRepository.GetAll();
        }
    }
}
