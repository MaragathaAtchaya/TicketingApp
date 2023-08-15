using System.ComponentModel.DataAnnotations;

namespace Ticketing.Models
{
    public class Producer
    {   
        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile Picture")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name = "FullName")]
        public string FullName { get; set; }
        [Display(Name = "Bio")]

        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
