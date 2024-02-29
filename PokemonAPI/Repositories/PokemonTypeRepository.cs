using PokemonAPI.Entities;
using PokemonAPI.Models;
using PokemonAPI.Repositories.Interfaces;

namespace PokemonAPI.Repositories
{
    public class PokemonTypeRepository(DbPokemonContext context) : IPokemonTypeRepository
    {
        private readonly DbPokemonContext _context = context;
        public List<Entities.PokemonType> GetAll()
        {
            return [.. _context.PokemonTypes
            .Select(type => new Entities.PokemonType
            {
                Id = type.Id,
                Name = type.Name
            })];
        }
    }
}
