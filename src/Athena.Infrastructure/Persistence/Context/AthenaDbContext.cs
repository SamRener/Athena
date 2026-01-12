using Athena.Domain.Entities;
using Athena.Domain.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace Athena.Infrastructure.Persistence.Context;

public class AthenaDbContext : DbContext, IAthenaDbContext
{
    public virtual DbSet<ToDo> ToDo { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseSqlite("Data Source=app.db");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ToDo>()
        .HasMany(x => x.ToDos)
        .WithOne(x => x.ParentToDo)
        .HasForeignKey("ToDo_ParentId");

        modelBuilder.Entity<ToDo>().HasKey(x => x.Id);
        modelBuilder.Entity<ToDo>()
        .Property(x => x.CreatedAt)
        .IsRequired();

        modelBuilder.Entity<ToDo>()
        .Property(x => x.Finished)
        .IsRequired();

        modelBuilder.Entity<ToDo>()
        .Property(x => x.Description)
        .IsRequired();

        modelBuilder.Entity<ToDo>()
        .Property(x => x.Important)
        .IsRequired();
    }

}
