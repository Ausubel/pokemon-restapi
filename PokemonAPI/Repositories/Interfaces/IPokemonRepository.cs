using PokemonAPI.Entities;

namespace PokemonAPI.Repositories.Interfaces
{
    public interface IPokemonRepository
    {
        List<Pokemon> GetAll();
        Pokemon GetPokemonById(int id);
        string AddPokemon(DTOs.PokemonDto pokemon);
        string UpdatePokemon(int id, DTOs.PokemonDto pokemon);
        string DeletePokemon(int id);
    }
}
