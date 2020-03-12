using ApplicationCoreEntityFramework.EntityBase;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntitiesForMarketSepeti.Entities
{
    public class User : IEntityBaseForDb
    {
        public int Id { get; set; }
        [Required, StringLength(maximumLength: 128)] public string AspNetUserId { get; set; }
        [StringLength(maximumLength: 100)] public string FirstName { get; set; }
        [StringLength(maximumLength: 50)] public string LastName { get; set; }
        [StringLength(maximumLength: 350)] public string Address { get; set; }
        [StringLength(maximumLength: 150)] public string Email { get; set; }
        [StringLength(maximumLength: 10)] public string Phone { get; set; }
        public virtual List<ShoppingCart> ShoppingCarts { get; set; }
    }
}
