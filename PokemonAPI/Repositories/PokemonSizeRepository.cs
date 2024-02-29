using PokemonAPI.Entities;
using PokemonAPI.Models;
using PokemonAPI.Repositories.Interfaces;

namespace PokemonAPI.Repositories
{
    public class PokemonSizeRepository(DbPokemonContext context) : IPokemonSizeRepository
    {
        private readonly DbPokemonContext _context = context;
        public List<Entities.PokemonSize> GetAll()
        {
            return [.. _context.PokemonSizes
            .Select(size => new Entities.PokemonSize
            {
                Id = size.Id,
                Description = size.Description
            })];
        }
    }
}
