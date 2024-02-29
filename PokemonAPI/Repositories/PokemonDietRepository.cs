using PokemonAPI.Entities;
using PokemonAPI.Models;
using PokemonAPI.Repositories.Interfaces;

namespace PokemonAPI.Repositories
{
    public class PokemonDietRepository(DbPokemonContext context) : IPokemonDietRepository
    {
        private readonly DbPokemonContext _context = context;
        public List<Entities.PokemonDiet> GetAll()
        {
            return [.. _context.PokemonDiets
            .Select(diet => new Entities.PokemonDiet
            {
                Id = diet.Id,
                Description = diet.Description
            })];
        }
    }
}
