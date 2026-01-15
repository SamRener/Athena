using Athena.Application.Queries;
using Athena.Domain;
using Athena.Domain.Entities;
using Athena.Domain.Persistence.Context;
using SRenerCq;

namespace Athena.Application.Commands;

public record ToggleImportanceCommand(Guid Key) : ICommand<Result>;

public class ToggleImportanceCommandHandler(IAthenaDbContext Context, ISender Sender) : ICommandHandler<ToggleImportanceCommand, Result>
{
    public async Task<Result> Handle(ToggleImportanceCommand command, CancellationToken cancellationToken)
    {
        var result = await Sender.Query(new GetToDoByKeyQuery(command.Key));
        if (result.IsFailure)
            return result.Error!;

        ToDo toDo = result.Value!;

        toDo.Important = !toDo.Important;
        await Context.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}