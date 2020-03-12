using ApplicationCoreEntityFramework.EntityBase;
using System.Collections.Generic;

namespace EntitiesForMarketSepeti.Entities
{
    public class ProductMarket : IEntityBaseForDb
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int MarketId { get; set; }
        public double Price { get; set; }
        public virtual Product Product { get; set; }
        public virtual Market Market { get; set; }
        public virtual List<ShoppingCartProductMarket> ShoppingCartProductMarkets { get; set; }
    }
}
