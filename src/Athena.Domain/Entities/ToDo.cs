namespace Athena.Domain.Entities;

public class ToDo
{
    public ToDo()
    {
        CreatedAt = DateTime.Now;
    }

    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public bool Finished { get; set; }

    public required string Description { get; set; }

    public bool Important { get; set; }

    public DateTime? DeadLine { get; set; }

    public IEnumerable<ToDo>? ToDos { get; set; }
    public ToDo? ParentToDo { get; set; }

}
