using ApplicationCoreEntityFramework.EntityBase;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntitiesForMarketSepeti.Entities
{
    public class Market : IEntityBaseForDb
    {
        public int Id { get; set; }
        [Required, StringLength(maximumLength: 200)] public string Name { get; set; }
        [Required, StringLength(maximumLength: 350)] public string Address { get; set; }
        [Required, StringLength(maximumLength: 10)] public string PhoneNumber { get; set; }
        [Required, StringLength(maximumLength: 4)] public string OpeningTime { get; set; }
        [Required, StringLength(maximumLength: 4)] public string ClosingTime { get; set; }
        public virtual List<ProductMarket> ProductMarkets { get; set; }

    }
}
