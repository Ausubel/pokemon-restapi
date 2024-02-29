using PokemonAPI.Entities;

namespace PokemonAPI.Repositories.Interfaces
{
    public interface IPokemonTypeRepository
    {
        List<PokemonType> GetAll();
    }
}
