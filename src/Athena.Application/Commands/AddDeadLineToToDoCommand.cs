using Athena.Application.Queries;
using Athena.Domain;
using Athena.Domain.Entities;
using Athena.Domain.Persistence.Context;
using SRenerCq;

namespace Athena.Application.Commands;

public record AddDeadLineToToDoCommand(Guid Key, DateTime DeadLine) : ICommand<Result>;

public class AddDeadLineToToDoCommandHandler(IAthenaDbContext Context, ISender Sender) : ICommandHandler<AddDeadLineToToDoCommand, Result>
{
    public async Task<Result> Handle(AddDeadLineToToDoCommand command, CancellationToken cancellationToken)
    {
        var result = await Sender.Query(new GetToDoByKeyQuery(command.Key));
        if (result.IsFailure)
            return result.Error!;

        ToDo toDo = result.Value!;

        toDo.DeadLine = command.DeadLine;
        await Context.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}