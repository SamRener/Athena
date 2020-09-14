using Athena.Data.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace Athena.Database.Models
{
    public class ToDo : BaseModel
    {
        [Required]
        public bool Finished { get; set; }
        
        [Required]
        public string Description { get; set; }

        [Required]
        public bool Important { get; set; }

        public DateTime? DeadLine { get; set; }

        internal int? ToDoList_Id { get; set; }

        public virtual ToDoList ToDoList { get; set; }
    }
}
