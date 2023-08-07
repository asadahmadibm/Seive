namespace seive2
{
    public interface IShoeRetrievalService
    {
        IQueryable<Shoe> GetShoes();
    }
}
