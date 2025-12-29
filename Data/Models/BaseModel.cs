using System;
using System.ComponentModel.DataAnnotations;

namespace Athena.Data.Models;

public class BaseModel
{
    [Required] [Key]
    public int Id { get; set; }

    [Required]
    public DateTime Date { get; set; }

    public BaseModel()
    {
        Date = DateTime.Now;
    }
}