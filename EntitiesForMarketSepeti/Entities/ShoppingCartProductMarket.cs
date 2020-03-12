using ApplicationCoreEntityFramework.EntityBase;

namespace EntitiesForMarketSepeti.Entities
{
    public class ShoppingCartProductMarket : IEntityBaseForDb
    {
        public int Id { get; set; }
        public int ShoppingCartId { get; set; }
        public int ProductMarketId { get; set; }
        public int NumberOfProduct { get; set; }
        public double APruductPrice { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
        public virtual ProductMarket ProductMarket { get; set; }
    }
}
