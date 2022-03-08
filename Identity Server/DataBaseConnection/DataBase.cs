using Identity_Server.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity_Server.DataBaseConnection
{
    public class DataBase: DbContext
    {
        public DataBase()
        {
        }

        public DataBase(DbContextOptions<DataBase> options) : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Scope> Scopes { get; set; }
        public DbSet<AuthCodeOptionsFlow> AuthCodeOptionsFlows { get; set; }
        public DbSet<Claims> Claims { get; set; }
        public DbSet<CrossOrigin> CrossOrigins { get; set; }
        public DbSet<ImplicitFlowOptions> ImplicitFlowOptions { get; set; }
        public DbSet<PostLogoutRedirectUri> PostLogoutRedirectUris { get; set; }
        public DbSet<RedirectURI> RedirectURIs { get; set; }
        public DbSet<Secret> Secrets { get; set; }
    }
}
