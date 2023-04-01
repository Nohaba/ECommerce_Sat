using System.ComponentModel.DataAnnotations;

namespace ECommerce_Sat.DAL.Entities
{
    public class Country : Entity 
    {
        [Display(Name = "Pais")]//Nombre que quiero mostrar en la web
        [MaxLength(50)]//Var char
        [Required(ErrorMessage = "El campo {0} es obligatorio")]//NOT NULL
        public string Name { get; set; }
    }
}
