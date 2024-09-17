using System.ComponentModel.DataAnnotations;

namespace PrivateBlog.Start.Data.Entities
{
    public class Section
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Sección")]
        [Required(ErrorMessage = "El campo '{0}' es requerido")]
        public string Name { get; set; }        
        
        [Display(Name = "Descripción")]
        public string? Description { get; set; }        
        
        [Display(Name = "¿Esta oculta?")]
        public bool IsHidden { get; set; }


    }
}
