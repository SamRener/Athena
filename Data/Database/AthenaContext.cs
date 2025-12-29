using Athena.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace Athena.Database;

public class AthenaContext : DbContext
{
    public virtual DbSet<ToDo> ToDo { get; set; }
    public virtual DbSet<ToDoList> ToDoList { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseSqlite("Data Source=app.db");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ToDo>()
        .HasOne(x => x.ToDoList)
        .WithMany(x => x.ToDos)
        .HasForeignKey("ToDo_Id");
    }


    
}
