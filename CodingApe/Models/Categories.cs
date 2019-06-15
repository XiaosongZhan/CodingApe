using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingApe.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string CategoriesName { get; set; }
        [ForeignKey("Section")]
        public int SectionID { get; set; }
        public Section Section { get; set; }
    }
}