using Athena.Domain.Entities;
using Athena.Domain.Persistence.Context;
using SRenerCq;

namespace Athena.Application.Queries;

public record GetToDosQuery(ListType Type = ListType.All) : IQuery<IEnumerable<ToDo>>;

public class GetToDosQueryHandler(IAthenaDbContext Context) : IQueryHandler<GetToDosQuery, IEnumerable<ToDo>>
{
    public async Task<IEnumerable<ToDo>> Handle(GetToDosQuery query, CancellationToken cancellationToken)
    {

        if (query.Type == ListType.All)
            return Context.ToDo;

        Func<ToDo, bool> predicate;

        switch (query.Type)
        {
            case ListType.Important: predicate = new(x => x.Important); break;
            case ListType.Today:
            default: predicate = new(x => x.CreatedAt.Date == DateTime.Now.Date); break;
        }

        return Context.ToDo.Where(predicate);
    }
}
