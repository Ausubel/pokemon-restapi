namespace PokemonAPI.DTOs
{
    public class PokemonDto
    {
        public string Name { get; set; }
        public int TypeId { get; set; }
        public int DietId { get; set; }
        public int SizeId { get; set; }
        public string WeightKg { get; set; }
        public int RarityId { get; set; }
        public string FunFact { get; set; }
        
        public static bool IsValid(PokemonDto pokemon)
        {
            Console.WriteLine(pokemon.Name);
            Console.WriteLine(pokemon.TypeId);
            Console.WriteLine(pokemon.DietId);
            Console.WriteLine(pokemon.SizeId);
            Console.WriteLine(pokemon.WeightKg);
            Console.WriteLine(pokemon.RarityId);
            Console.WriteLine(pokemon.FunFact);
            Console.WriteLine(!string.IsNullOrEmpty(pokemon.Name));
            Console.WriteLine(pokemon.TypeId > 0);
            Console.WriteLine(pokemon.DietId > 0);
            Console.WriteLine(pokemon.SizeId > 0);
            Console.WriteLine(!string.IsNullOrEmpty(pokemon.WeightKg));
            Console.WriteLine(pokemon.RarityId > 0);
            Console.WriteLine(!string.IsNullOrEmpty(pokemon.FunFact));
            return !string.IsNullOrEmpty(pokemon.Name) && pokemon.TypeId > 0 && pokemon.DietId > 0 && pokemon.SizeId > 0 && !string.IsNullOrEmpty(pokemon.WeightKg) && pokemon.RarityId > 0 && !string.IsNullOrEmpty(pokemon.FunFact);
        }
    }
}
