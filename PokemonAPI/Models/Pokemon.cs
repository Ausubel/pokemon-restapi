using System;
using System.Collections.Generic;

namespace PokemonAPI.Models;

public partial class Pokemon
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int TypeId { get; set; }

    public int DietId { get; set; }

    public int SizeId { get; set; }

    public required string WeightKg { get; set; }

    public int RarityId { get; set; }

    public string FunFact { get; set; } = null!;

    public virtual PokemonDiet Diet { get; set; } = null!;

    public virtual PokemonRarity Rarity { get; set; } = null!;

    public virtual PokemonSize Size { get; set; } = null!;

    public virtual PokemonType Type { get; set; } = null!;
}
