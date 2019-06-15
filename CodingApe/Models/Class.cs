using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingApe.Models
{
    public class Class
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsBuyClass { get; set; }
        [ForeignKey("Categories")]
        public int CategoriesID { get; set; }
        public  Categories Categories { get; set; }
    }
}