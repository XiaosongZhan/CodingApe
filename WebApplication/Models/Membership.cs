using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Membership
    {
        public int Id { get; set; }
        public string MemberName { get; set; }
        public int Fee { get; set; }
    }
}