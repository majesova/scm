using IdentityServer4.EntityFramework.Options;
using Scm.Domain;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Scm.Data
{
    public class ScmContext : IdentityDbContext<AppUser,AppRole,string>
    {
        
        public ScmContext(DbContextOptions<ScmContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //put mappings database here
            base.OnModelCreating(builder);
        }
    }
}