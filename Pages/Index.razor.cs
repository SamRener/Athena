using Athena.Database.Controllers;
using Athena.Database.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Athena.Pages
{
    public partial class Index
    {
        private List<ToDo> Tarefas { get; set; }
        private ToDoController toDoController { get; set; }

        void HandleFinished(int Codigo)
        {
            if (toDoController.HandleFinished(Codigo))
            {
                new System.Media.SoundPlayer(_env.WebRootPath + "\\sounds\\plim.wav").Play();
            }
            Tarefas = new List<ToDo>();
            Tarefas = toDoController.GetAll();

        }
        void HandleImportant(int Codigo)
        {
            toDoController.HandleImportant(Codigo);
            Tarefas = new List<ToDo>();
            Tarefas = toDoController.GetAll();
        }
        void SetDeadLine(int codigo, DateTime date)
        {
            toDoController.SetDeadLine(codigo, date);
            Tarefas = new List<ToDo>();
            toDoController.GetAll();
        }
        string DataAtual()
        {
            CultureInfo culture = new CultureInfo("pt-BR");
            DateTimeFormatInfo dtfi = culture.DateTimeFormat;

            int dia = DateTime.Now.Day;
            int ano = DateTime.Now.Year;
            string mes = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Month));
            string diasemana = culture.TextInfo.ToTitleCase(dtfi.GetDayName(DateTime.Now.DayOfWeek));
            return diasemana + ", " + dia + " de " + mes + " de " + ano;
        }
        void Adicionar()
        {
            toDoController.Insert(new ToDo { Description = TarefaAtual, User_ObjectId = "" });
            TarefaAtual = "";
            Tarefas = toDoController.GetAll();
        }
        void Delete(ToDo toDo)
        {
            toDoController.Delete(toDo);
            Tarefas = toDoController.GetAll();
        }

    }
}
