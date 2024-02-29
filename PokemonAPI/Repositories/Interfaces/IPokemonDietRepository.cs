using PokemonAPI.Entities;

namespace PokemonAPI.Repositories.Interfaces
{
    public interface IPokemonDietRepository
    {
        List<PokemonDiet> GetAll();
    }
}
