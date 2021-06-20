using Core.Entities;


namespace Entities.Concrete
{
    // ciplak class kalmasin
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}