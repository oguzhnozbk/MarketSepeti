using ApplicationCoreEntityFramework.EntityBase;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntitiesForMarketSepeti.Entities
{
    public class Category : IEntityBaseForDb
    {
        public int Id { get; set; }
        [Required, StringLength(maximumLength: 100)] public string Name { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
