using Athena.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Athena.Domain.Persistence.Context;

public interface IAthenaDbContext
{
    DbSet<ToDo> ToDo { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}