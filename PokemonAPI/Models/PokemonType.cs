using System;
using System.Collections.Generic;

namespace PokemonAPI.Models;

public partial class PokemonType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Pokemon> Pokemons { get; set; } = new List<Pokemon>();
}
