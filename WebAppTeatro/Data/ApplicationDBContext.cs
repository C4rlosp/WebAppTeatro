
using Microsoft.EntityFrameworkCore;
using WebAppTeatro.Shared;

namespace WebAppTeatro.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder){ }

        //agregamos las clases con las que relacionamos nuestra DB
        public DbSet<Usuarios> Usuarios { get; set; }
    }

}
