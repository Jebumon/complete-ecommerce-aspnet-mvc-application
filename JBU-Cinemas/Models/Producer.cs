using System.ComponentModel.DataAnnotations;

namespace JBU_Cinemas.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        public string ProducerName { get; set; }
        public string ProfilePictureURL { get; set; }
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }

    }
}
