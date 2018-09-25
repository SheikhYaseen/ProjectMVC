using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcOne.Models
{
    public class Movies
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public DateTime DateRleased { get; set; }

        public DateTime? DateAdded { get; set; }

        public int NumberInStock { get; set; }
        public MovieType MovieType { get; set; }
        public byte MovieTypeId { get; set; }

    }
}