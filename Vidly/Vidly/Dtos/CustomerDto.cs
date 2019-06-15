using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vidly.Models;
namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "please enter a valid name.")]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribed { get; set; }
        [ForeignKey("Membership")]
        public int MemberId { get; set; }
       
    }
}