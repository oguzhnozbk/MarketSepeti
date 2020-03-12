using EntitiesForMarketSepeti.Entities;
using System.Data.Entity;

namespace DbContextForMarketSepeti.Context
{
    public class MarketSepetiContext : DbContext
    {
        public MarketSepetiContext() : base("MarketSepetiDb")
        {

        }
        public virtual DbSet<Market> Markets { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ProductMarket> ProductMarkets { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<ShoppingCartProductMarket> ShoppingCartProductMarkets { get; set; }
    }
}
