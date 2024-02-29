using PokemonAPI.Entities;
using PokemonAPI.Models;
using PokemonAPI.Repositories.Interfaces;

namespace PokemonAPI.Repositories
{
    public class PokemonRarityRepository(DbPokemonContext context) : IPokemonRarityRepository
    {
        private readonly DbPokemonContext _context = context;

        public List<Entities.PokemonRarity> GetAll()
        {
            return [
            .. _context.PokemonRarities
            .Select(rarity => new Entities.PokemonRarity
            {
                Id = rarity.Id,
                Name = rarity.Name
            })];
        }
    }
}
