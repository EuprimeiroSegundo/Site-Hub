using Hub.Models;
using Microsoft.EntityFrameworkCore;

namespace Hub
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options): base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CadastroUsuario>().HasKey(t => t.Id);
        }

        public DbSet<Hub.Models.CadastroUsuario> CadastroUsuario { get; set; }

    }
}