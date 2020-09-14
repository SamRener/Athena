using Athena.Database.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Athena.Database.Controllers
{
    public class ToDoController
    {
        AthenaContext ctx { get; set; }

        public ToDoController(IConfiguration config)
        {
            ctx = new AthenaContext(config);
        }
        public List<ToDo> GetAll()
        {
            return ctx.ToDo.Where(x => x.Date.Date == DateTime.Now.Date).ToList();
        }

        public Exception Insert(ToDo todo)
        {
            ctx.ToDo.Add(todo);
            ctx.SaveChanges();

            return null;
        }

        public bool HandleFinished(int Codigo)
        {
            var ToDo = ctx.ToDo.Find(Codigo);
            if(ToDo != null)
            {
                ToDo.Finished = !ToDo.Finished;
                ctx.SaveChanges();

                return ToDo.Finished;
            }
            return false;
        }
        public bool HandleImportant(int Codigo)
        {
            var ToDo = ctx.ToDo.Find(Codigo);
            if (ToDo != null)
            {
                ToDo.Important = !ToDo.Important;
                ctx.SaveChanges();

                return ToDo.Important;
            }
            return false;
        }

        public Exception Delete(ToDo toDo)
        {
            ctx.ToDo.Remove(toDo);
            ctx.SaveChanges();

            return null;
        }
    }
}
