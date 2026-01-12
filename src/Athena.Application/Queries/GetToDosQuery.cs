using Athena.Domain.Entities;
using Athena.Domain.Persistence.Context;
using Microsoft.Extensions.Logging;
using SRenerCq;

namespace Athena.Application.Queries;

public record GetToDosQuery(ListType Type = ListType.All) : IQuery<IEnumerable<ToDo>>;

public class GetToDosQueryHandler(IAthenaDbContext Context) : IQueryHandler<GetToDosQuery, IEnumerable<ToDo>>
{
    public async Task<IEnumerable<ToDo>> Handle(GetToDosQuery query, CancellationToken cancellationToken)
    {

        return query.Type switch
        {
            ListType.Important => Context.ToDo.Where(x => x.Important),
            ListType.Today => Context.ToDo.Where(x => x.CreatedAt.Date == DateTime.Now.Date),
            _ => Context.ToDo
        };
    }
}
