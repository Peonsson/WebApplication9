using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication9.Models
{
    public class User
    {
        public int Id { get; set; }
        public DateTime LastLogin { get; set; }
        public DateTime Register { get; set; }
        public String Status { get; set; }
    }
}