using System.ComponentModel.DataAnnotations;

namespace Ticketing.Models
{
    public class Actor
    {
        public int Id { get; set; }
        [Display(Name ="FullName" )]
        public string FullName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureUrl { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}
