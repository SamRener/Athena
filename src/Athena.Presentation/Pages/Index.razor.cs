using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Globalization;
using SRenerCq;
using System.Threading.Tasks;
using Athena.Domain.Entities;
using Athena.Application.Queries;
using Athena.Application.Commands;
namespace Athena.Presentation.Pages;

public partial class Index(IJSRuntime Js)
{
    [Inject]
    ISender Sender { get; set; }
    private IEnumerable<ToDo> ToDos { get; set; }

async Task LoadToDos()
    {
        GetToDosQuery query = new(ListType);

        ToDos = await Sender.Query(query);
    }
    async Task HandleFinished(int toDoCode)
    {
        ToggleCompletionCommand cmd = new(toDoCode);
        var result = await Sender.Command(cmd);

        if (result.IsSuccess)
        {
            Js.InvokeVoidAsync("playSound", "\\sounds\\plim.wav");
        }

        await LoadToDos();

    }
    async Task HandleImportant(int toDoCode)
    {
        ToggleImportanceCommand cmd = new(toDoCode);
        var result = await Sender.Command(cmd);

        await LoadToDos();
    }
    async Task HandleDeadLine(int toDoCode, DateTime deadLine)
    {
        AddDeadLineToToDoCommand cmd = new(toDoCode, deadLine);
        var result = await Sender.Command(cmd);

        await LoadToDos();
    }
    async Task AddToDo()
    {
        AddToDoCommand cmd = new(new(CurrentToDo));

        await Sender.Command(cmd);

        CurrentToDo = string.Empty;

        await LoadToDos();
    }
    async Task Delete(ToDo toDo)
    {
        DeleteToDoCommand cmd = new(toDo);
        await Sender.Command(cmd);

        await LoadToDos();
    }

    static string GetCurrentDate()
    {
        CultureInfo culture = new("pt-BR");
        DateTimeFormatInfo dtfi = culture.DateTimeFormat;

        int day = DateTime.Now.Day;
        int year = DateTime.Now.Year;
        string month = culture.TextInfo.ToTitleCase(dtfi.GetMonthName(DateTime.Now.Month));
        string dayOfWeek = culture.TextInfo.ToTitleCase(dtfi.GetDayName(DateTime.Now.DayOfWeek));
        return dayOfWeek + ", " + day + " de " + month + " de " + year;
    }
}
