namespace seive2
{
    public class ShoeRetrievalService : IShoeRetrievalService
    {
        private ShoesContext _context;

        public ShoeRetrievalService(ShoesContext context)
        {
            _context = context;
        }
        public IQueryable<Shoe> GetShoes()
        {

            return _context.shoes.AsQueryable();

            return new List<Shoe>
        {
            new()
            {
                Name = "egasus 39",
                Brand = "Nike",
                Price = 139.99M,
                Category = "Running",
                Rating = 4.5M
            },
            new()
            {
                Name = "Pegasus Trail 3",
                Brand = "mike",
                Price = 129.99M,
                Category = "Trail",
                Rating = 3.8M
            },
            new()
            {
                Name = "Ride 15",
                Brand = "Saucony",
                Price = 119.99M,
                Category = "Neutral",
                Rating = 4.9M
            }
        }.AsQueryable();
        }
    }
}
