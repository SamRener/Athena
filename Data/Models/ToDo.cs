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

        public string ExtenseDeadLine(DateTime data)
        {
            var Today = DateTime.Today;
            var Tomorrow = DateTime.Today.AddDays(1);

            if (data.Date == Today) return "Hoje";
            else if (data.Date == Tomorrow) return "Amanhã";
            else
            {
                return data.ToLongDateString();
            }
        }
    }
}
