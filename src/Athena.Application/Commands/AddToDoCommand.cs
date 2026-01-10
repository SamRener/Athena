using Athena.Domain;
using Athena.Domain.Entities;
using Athena.Domain.Persistence.Context;
using SRenerCq;

namespace Athena.Application.Commands;

public record AddToDoCommand(ToDo ToDo) : ICommand<Result<ToDo>>;

public class AddToDoCommandHandler(IAthenaDbContext Context) : ICommandHandler<AddToDoCommand, Result<ToDo>>
{
    public async Task<Result<ToDo>> Handle(AddToDoCommand command, CancellationToken cancellationToken)
    {
        await Context.ToDo.AddAsync(command.ToDo, cancellationToken);
        await Context.SaveChangesAsync(cancellationToken);

        return command.ToDo;
    }
}