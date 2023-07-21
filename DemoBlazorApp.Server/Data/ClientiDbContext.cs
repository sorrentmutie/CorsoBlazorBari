using DemoBlazorLibrary;
using Microsoft.EntityFrameworkCore;

namespace DemoBlazorApp.Server.Data;

public class ClientiDbContext: DbContext
{
    public ClientiDbContext(DbContextOptions<ClientiDbContext> opzioni) : base(opzioni)
    {
            
    }

    public DbSet<Cliente> Clienti { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       //modelBuilder.Entity<Cliente>().ToTable("tbl_clienti");
       //modelBuilder.Entity<Cliente>().Property(c => c.Id).HasColumnName("id_cliente");
       //modelBuilder.Entity<Cliente>().HasKey(c => new { c.Id, c.Nome, c.Cognome });
    }
}
