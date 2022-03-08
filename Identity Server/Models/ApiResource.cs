using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity_Server.Models
{
    public class ApiResource
    {

        public int Id { get; set; }
        public ICollection<Secret> ApiSecrets { get; set; }
        public ICollection<Scope> Scopes { get; set; }
        public ICollection<Claims> Userclaims { get; set; }
    }
}
