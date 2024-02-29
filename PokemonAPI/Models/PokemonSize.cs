using System;
using System.Collections.Generic;

namespace PokemonAPI.Models;

public partial class PokemonSize
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Pokemon> Pokemons { get; set; } = new List<Pokemon>();
}
