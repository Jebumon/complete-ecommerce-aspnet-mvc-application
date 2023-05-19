using JBU_Cinemas.Data.Base;
using JBU_Cinemas.Data.Enums;
using JBU_Cinemas.Data.Services;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JBU_Cinemas.Models
{
    public class Movie : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Title")]
        public string Title { get; set; }
        [Display(Name ="Description")]
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
