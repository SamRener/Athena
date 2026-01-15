using Athena.Application.Queries;
using Athena.Domain;
using Athena.Domain.Entities;
using Athena.Domain.Persistence.Context;
using SRenerCq;

namespace Athena.Application.Commands;

public record ToggleCompletionCommand(Guid Key) : ICommand<Result>;

public class ToggleCompletionCommandHandler(IAthenaDbContext Context, ISender Sender) : ICommandHandler<ToggleCompletionCommand, Result>
{
    public async Task<Result> Handle(ToggleCompletionCommand command, CancellationToken cancellationToken)
    {
        var result = await Sender.Query(new GetToDoByKeyQuery(command.Key));
        if (result.IsFailure)
            return result.Error!;

        ToDo toDo = result.Value!;

        toDo.Finished = !toDo.Finished;
        await Context.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}