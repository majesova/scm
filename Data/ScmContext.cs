using IdentityServer4.EntityFramework.Options;
using Scm.Domain;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using CargaDescarga;

namespace Scm.Data
{
    public class ScmContext : IdentityDbContext<AppUser,AppRole,string>
    {
        public DbSet<Empleado> Empleados { get; set; }
        public ScmContext(DbContextOptions<ScmContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {   
            //put mappings database here
            builder.Entity<Empleado>(x=>{
                x.HasKey(x=>x.IdEmpleado);
                x.Property(x=>x.IdEmpleado).ValueGeneratedOnAdd();
                x.Property(x=>x.Nombre).HasMaxLength(200).IsRequired();

            });
            base.OnModelCreating(builder);
        }
    }
}