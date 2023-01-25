using System.ComponentModel.DataAnnotations;

namespace JBU_Cinemas.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Cinema Logo")]
        public string LogoURL { get; set; }
        [Display(Name ="Cinema Name")]
        public string CinemaName { get; set; }
        [Display(Name ="Description")]
        public string Description { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
