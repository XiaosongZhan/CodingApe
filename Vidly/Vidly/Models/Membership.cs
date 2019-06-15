using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Membership
    {
        public int MembershipId { get; set; }
        public byte Fee { get; set; }
        public byte Discount { get; set; }
        public byte Duration { get; set; }
        public string TypeName { get; set; }
    }
}