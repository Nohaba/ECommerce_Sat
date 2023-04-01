using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.ComponentModel.DataAnnotations;

namespace ECommerce_Sat.DAL.Entities
{
    public class Entity
    {
        [Key]
        public Guid Id { get; set; }
        
        [Display(Name = "Fecha de creación")]
        public virtual string? CreatedDate { get; set; }
        
        [Display(Name = "Fecha de modificación")]
        public virtual string? ModifiedDate { get; set; }
    }
}
