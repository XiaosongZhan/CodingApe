using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Movie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public int NumberInStock { get; set; }
        [DisplayFormat(DataFormatString ="{0: yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}