using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.ComponentModel.DataAnnotations;

namespace ECommerce_Sat.DAL.Entities
{
    public class Entity
    {
        [Key]
        public Guid Id { get; set; }
        public virtual string? CreatedDate { get; set; }
        public virtual string? ModifiedDate { get; set; }
    }
}
