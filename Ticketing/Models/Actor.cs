using System.ComponentModel.DataAnnotations;

namespace Ticketing.Models
{
    public class Actor
    {
        public int Id { get; set; }
        [Display(Name ="FullName" )]
        [Required(ErrorMessage ="FullName is required")]
        [StringLength(50,MinimumLength = 3,ErrorMessage ="FullName requires atleast 3 and maximum of 50 characters")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureUrl { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}
