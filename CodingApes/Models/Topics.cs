using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingApes.Models
{
    public class Topics
    {
        public int Id { get; set; }
        public string TopicsName1 { get; set; }
        public string TopicsName2 { get; set; }
        public string TopicsName3 { get; set; }
        public string TopicsName4 { get; set; }
        public string TopicsName5 { get; set; }
        public string TopicsName6 { get; set; }
        public string TopicsName7 { get; set; }
        public string TopicsName8 { get; set; }
        public string TopicsName9 { get; set; }
        public string TopicsName10 { get; set; }
        public string TopicsName11 { get; set; }
        public string TopicsName12 { get; set; }
        [ForeignKey("Section")]
        public int SectionID { get; set; }
        public Section Section { get; set; }

       
    }
}