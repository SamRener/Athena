namespace Athena.Domain.Entities;

public record ToDo
{
    public ToDo()
    {
        CreatedAt = DateTime.Now;
    }

    public ToDo(string description) : base()
    {
        Description = description;
    }
    
    public int Id { get; set; }

    public DateTime CreatedAt { get; set; }

    public bool Finished { get; set; }

    public string Description { get; set; } = string.Empty;

    public bool Important { get; set; }

    public DateTime? DeadLine { get; set; }

    public IEnumerable<ToDo>? ToDos { get; set; }
    public ToDo? ParentToDo { get; set; }

}
