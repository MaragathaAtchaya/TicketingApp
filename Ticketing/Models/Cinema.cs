﻿using System.ComponentModel.DataAnnotations;

namespace Ticketing.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string logo { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
