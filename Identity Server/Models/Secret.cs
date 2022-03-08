using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Identity_Server.Models
{
    public class Secret
    {
        public int SecretId { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public DateTime? Expiration { get; set; }
        public string Type { get; set; }
        public Client client { get; set; }
        public ApiResource apiResource { get; set; }
        //
        // Résumé :
        //     Determines whether the specified System.Object, is equal to this instance.
        //
        // Paramètres :
        //   obj:
        //     The System.Object to compare with this instance.
        //
        // Retourne :
        //     true if the specified System.Object is equal to this instance; otherwise, false.
        /// public override bool Equals(object obj);
        //
        // Résumé :
        //     Returns a hash code for this instance.
        //
        // Retourne :
        //     A hash code for this instance, suitable for use in hashing algorithms and data
        //     structures like a hash table.
        /// public override int GetHashCode();
    }
}
