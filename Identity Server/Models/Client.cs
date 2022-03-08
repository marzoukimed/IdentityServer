using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Identity_Server.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string ClientID { get; set; }
        public int AccessTokenLifetime { get; set; }
        public int AbsoluteRefreshTokenLifetime { get; set; }
        public int SlidingRefreshTokenLifetime { get; set; }
        public int? ConsentLifetime { get; set; }
        public bool EnableLocalLogin { get; set; }
        public bool IncludeJwtId { get; set; }
        public ICollection<Claims> Claims { get; set; }
        public bool AlwaysSendClientClaims { get; set; }
        public string ClientClaimsPrefix { get; set; }
        public bool AlwaysIncludeUserClaimsInIdToken { get; set; }
        public ICollection<Scope> Scopes { get; set; }
        public bool Enabled { get; set; }
        public string ProtocolType { get; set; }
        public ICollection<Secret> ClientSecrets { get; set; }
        public bool RequireClientSecret { get; set; }
        public string ClientName { get; set; }
        public string Description { get; set; }
        public string ClientUri { get; set; }
        public string LogoUri { get; set; }
        public bool RequireConsent { get; set; }
        public bool AllowRememberConsent { get; set; }
        public int AllowedGrantTypes { get; set; } //if 0 client credential, if==1 CodeFlow , if==2 implicit , if==3 hybrid
        public bool RequireRequestObject { get; set; }
        public ICollection<CrossOrigin> AllowedCorsOrigins { get; set; }
    }
}
