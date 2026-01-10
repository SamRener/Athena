using Athena.Domain;
using Athena.Domain.Entities;
using Athena.Domain.Persistence.Context;
using SRenerCq;

namespace Athena.Application.Commands;

public record DeleteToDoCommand(ToDo ToDo) : ICommand<Result>;

public class DeleteToDoCommandHandler(IAthenaDbContext Context) : ICommandHandler<DeleteToDoCommand, Result>
{
    public async Task<Result> Handle(DeleteToDoCommand command, CancellationToken cancellationToken)
    {
        Context.ToDo.Remove(command.ToDo);
        await Context.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}