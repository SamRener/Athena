using Athena.Domain;
using Athena.Domain.Entities;
using Athena.Domain.Persistence.Context;
using SRenerCq;

namespace Athena.Application.Queries;

public record GetToDoByKeyQuery(Guid Key) : IQuery<Result<ToDo>>;

public class GetToDoByKeyQueryHandler(IAthenaDbContext Context) : IQueryHandler<GetToDoByKeyQuery, Result<ToDo>>
{
    public async Task<Result<ToDo>> Handle(GetToDoByKeyQuery query, CancellationToken cancellationToken)
    {

        var toDo = await Context.ToDo.FindAsync([query.Key], cancellationToken: cancellationToken);

        if (toDo is null)
            return Result<ToDo>.Failure(Error.NotFound);

        return toDo;
    }
}
