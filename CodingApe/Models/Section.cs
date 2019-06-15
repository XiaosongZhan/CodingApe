using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingApe.Models
{
    public class Section
    {
        public int Id { get; set; }
        public string SectionName { get; set; }
        [ForeignKey("Topic")]
        public int TopicsID { get; set; }
        public Topic Topic { get; set; }
    }
}