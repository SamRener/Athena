using Athena.Data.Models;
using Athena.Presentation.Controllers;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Athena.Pages;

public partial class Tasks(IJSRuntime Js)
{
    [Inject]
    Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
    [Inject]
    Microsoft.AspNetCore.Hosting.IWebHostEnvironment _env { get; set; }
    private List<ToDo> Tarefas { get; set; }
    private ToDoController toDoController { get; set; }

    void HandleFinished(int Codigo)
    {
        if (toDoController.HandleFinished(Codigo))
        {
        Js.InvokeVoidAsync("playSound", "\\sounds\\plim.wav");
        }
        Tarefas = new List<ToDo>();
        Tarefas = toDoController.GetAll(true);

    }
    void HandleImportant(int Codigo)
    {
        toDoController.HandleImportant(Codigo);
        Tarefas = new List<ToDo>();
        Tarefas = toDoController.GetAll(true);
    }
    void HandleDeadLine(int codigo, DateTime date)
    {
        toDoController.HandleDeadline(codigo, date);
        Tarefas = new List<ToDo>();
        Tarefas = toDoController.GetAll(true);
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
        toDoController.Insert(new ToDo { Description = TarefaAtual});
        TarefaAtual = "";
        Tarefas = toDoController.GetAll(true);
    }
    void Delete(ToDo toDo)
    {
        toDoController.Delete(toDo);
        Tarefas = toDoController.GetAll(true);
    }

}
