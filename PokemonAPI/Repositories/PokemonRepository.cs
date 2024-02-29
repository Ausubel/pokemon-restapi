using PokemonAPI.Entities;
using PokemonAPI.Models;
using PokemonAPI.Repositories.Interfaces;

namespace PokemonAPI.Repositories
{
    public class PokemonRepository(DbPokemonContext context) : IPokemonRepository
    {
        private readonly DbPokemonContext _context = context;

        public List<Entities.Pokemon> GetAll()
        {
            return [.. _context.Pokemons
                .Select(pokemon => new Entities.Pokemon
                {
                    Id = pokemon.Id,
                    Name = pokemon.Name,
                    Type = pokemon.Type.Name,
                    Diet = pokemon.Diet.Description,
                    Size = pokemon.Size.Description,
                    WeightKg = pokemon.WeightKg,
                    Rarity = pokemon.Rarity.Name,
                    FunFact = pokemon.FunFact
                })];
        }
        public Entities.Pokemon? GetPokemonById(int id)
        {
            var pokemon =  _context.Pokemons
                .Where(pokemon => pokemon.Id == id)
                .Select(pokemon => new Entities.Pokemon
                {
                    Id = pokemon.Id,
                    Name = pokemon.Name,
                    Type = pokemon.Type.Name,
                    Diet = pokemon.Diet.Description,
                    Size = pokemon.Size.Description,
                    WeightKg = pokemon.WeightKg,
                    Rarity = pokemon.Rarity.Name,
                    FunFact = pokemon.FunFact
                }).FirstOrDefault();
            return pokemon;
        }
        public string AddPokemon(DTOs.PokemonDto pokemon)
        {
            try
            {
                _context.Pokemons.Add(new Models.Pokemon
                {
                    Name = pokemon.Name,
                    TypeId = pokemon.TypeId,
                    DietId = pokemon.DietId,
                    SizeId = pokemon.SizeId,
                    WeightKg = pokemon.WeightKg,
                    RarityId = pokemon.RarityId,
                    FunFact = pokemon.FunFact
                });
                _context.SaveChanges();
                return "Pokemon added";
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
            
        }
        public string UpdatePokemon(int id, DTOs.PokemonDto pokemon)
        {
            try
            {
                var pokemonToUpdate = _context.Pokemons.Find(id);
                if (pokemonToUpdate == null)
                {
                    throw new InvalidOperationException("Pokemon not found");
                }
                pokemonToUpdate.Name = pokemon.Name;
                pokemonToUpdate.TypeId = pokemon.TypeId;
                pokemonToUpdate.DietId = pokemon.DietId;
                pokemonToUpdate.SizeId = pokemon.SizeId;
                pokemonToUpdate.WeightKg = pokemon.WeightKg;
                pokemonToUpdate.RarityId = pokemon.RarityId;
                pokemonToUpdate.FunFact = pokemon.FunFact;
                _context.SaveChanges();
                return "Pokemon updated";
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
        public string DeletePokemon(int id)
        {
            try
            {
                var pokemonToDelete = _context.Pokemons.Find(id) ?? throw new InvalidOperationException("Pokemon not found");
                _context.Pokemons.Remove(pokemonToDelete!);
                _context.SaveChanges();

                return "Pokemon deleted";
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
    }
}
