using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Identity_Server.Models
{
    public class RedirectURI
    {
        public int RedirectURIId { get; set; }
        public string redirecturi { get; set; }
       // public AuthCodeOptionsFlow AuthCodeOptionsFlows { get; set; }
        //public AuthCodeOptionsFlow ImplicitFlow { get; set; }
    }
}
