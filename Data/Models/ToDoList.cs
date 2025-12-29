using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Athena.Data.Models;

public class ToDoList: BaseModel
{
    [Required]
    public string Title { get; set; }

    public IEnumerable<ToDo> ToDos { get; set; }

}
