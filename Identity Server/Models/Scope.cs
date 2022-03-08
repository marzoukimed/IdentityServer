using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Identity_Server.Models
{
    public class Scope
    {
        public int ScopeId { get; set; }
        public bool Enabled { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public bool ShowInDiscoveryDocument { get; set; }
        public bool Required { get; set; }
        public bool Emphasize { get; set; }
        public Client client { get; set; }
        public ApiResource apiResource { get; set; }

        
    }
}
