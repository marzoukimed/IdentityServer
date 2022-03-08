using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Identity_Server.Models
{
    public class PostLogoutRedirectUri
    {
    
        public int PostLogoutRedirectUriId { get; set; }
        public string logouturi { get; set; }
        //public AuthCodeOptionsFlow AuthCodeOptionsFlow { get; set; }
       // public AuthCodeOptionsFlow ImplicitFlow { get; set; }
    }
}
