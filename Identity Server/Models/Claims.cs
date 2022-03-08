using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Identity_Server.Models
{
    public class Claims
    {

        public int ClaimsId { get; set; }
        public string Type { get; set; }
        public string OriginalIssuer { get; set; }
        public string Issuer { get; set; }
        public string ValueType { get; set; }
        public string Value { get; set; }
        public Client client { get; set; }
        public ApiResource apiResource { get; set; }
    }
}
