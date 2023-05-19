using JBU_Cinemas.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace JBU_Cinemas.Models
{
    public class Cinema : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Cinema Logo")]
        [Required (ErrorMessage ="Cinema logo is required")]
        public string? LogoURL { get; set; }
        [Display(Name ="Cinema Name")]
        [Required(ErrorMessage ="Cinema name is required")]
        public string? CinemaName { get; set; }
        [Display(Name ="Description")]
        [Required(ErrorMessage ="Cinema description is required")]
        public string? Description { get; set; }

        //Relationships
        public List<Movie>? Movies { get; set; }
    }
}
