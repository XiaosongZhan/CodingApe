using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingApes.Models
{
    public class Section
    {
        public int Id { get; set; }
        public string SectionName { get; set; }
        public string CategoryName { get; set; }
    }
}   