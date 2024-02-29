namespace PokemonAPI.Entities
{
    public class Pokemon
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Type { get; set; }
        public required string Diet { get; set; }
        public required string Size { get; set; }
        public required string WeightKg { get; set; }
        public required string Rarity { get; set; }
        public required string FunFact { get; set; }
    }
}
