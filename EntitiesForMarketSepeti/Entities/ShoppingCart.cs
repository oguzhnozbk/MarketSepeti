using ApplicationCoreEntityFramework.EntityBase;
using System;
using System.Collections.Generic;

namespace EntitiesForMarketSepeti.Entities
{
    public class ShoppingCart : IEntityBaseForDb
    {
        public int Id { get; set; }
        public bool IsItComplete { get; set; }
        public int UserId { get; set; }
        public DateTime? TimeToComplate { get; set; }
        public virtual User User { get; set; }
        public virtual List<ShoppingCartProductMarket> ShoppingCartProductMarkets { get; set; }

    }
}
