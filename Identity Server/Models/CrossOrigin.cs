using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Identity_Server.Models
{
    public class CrossOrigin
    {

        public int CrossOriginId { get; set; }
        public string name { get; set; }
        public Client client { get; set; }
    }
}
