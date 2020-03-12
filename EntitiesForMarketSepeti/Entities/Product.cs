using ApplicationCoreEntityFramework.EntityBase;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntitiesForMarketSepeti.Entities
{
    public class Product : IEntityBaseForDb
    {
        public int Id { get; set; }
        [Required, StringLength(maximumLength: 150)] public string Name { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<ProductMarket> ProductMarkets { get; set; }
    }
}
