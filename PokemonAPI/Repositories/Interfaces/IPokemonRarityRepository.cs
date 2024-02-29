using PokemonAPI.Entities;

namespace PokemonAPI.Repositories.Interfaces
{
    public interface IPokemonRarityRepository
    {
        List<PokemonRarity> GetAll();
    }
}
