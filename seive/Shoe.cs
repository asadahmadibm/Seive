using Sieve.Attributes;

namespace seive2
{
    public class Shoe
    {
        public int id { get; set; }
        public required string Name { get; set; }
        public required string Category { get; set; }
        public required string Brand { get; set; }
        [Sieve(CanSort = true, CanFilter = true)]
        public decimal Price { get; set; }
        [Sieve(CanSort = true)]
        public decimal Rating { get; set; }
    }
}
