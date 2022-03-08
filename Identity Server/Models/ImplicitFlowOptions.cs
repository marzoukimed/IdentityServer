using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Identity_Server.Models
{
    public class ImplicitFlowOptions
    {
        
        public int ImplicitFlowOptionsId { get; set; }
        public bool AllowAccessTokensViaBrowser { get; set; }
        public bool RequirePkce { get; set; }
        public bool AllowPlainTextPkce { get; set; }
        public ICollection<RedirectURI> RedirectUris { get; set; }
        public ICollection<PostLogoutRedirectUri> PostLogoutRedirectUris { get; set; }
    }
}
