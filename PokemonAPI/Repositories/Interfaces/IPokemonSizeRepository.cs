using PokemonAPI.Entities;

namespace PokemonAPI.Repositories.Interfaces
{
    public interface IPokemonSizeRepository
    {
        List<PokemonSize> GetAll();
    }
}
