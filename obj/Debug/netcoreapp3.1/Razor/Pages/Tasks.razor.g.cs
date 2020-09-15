#pragma checksum "C:\Users\User\source\repos\Athena\Pages\Tasks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bf3ffd9b275a2d13c66377f5ac24bd08b088e9b"
// <auto-generated/>
#pragma warning disable 1591
namespace Athena.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\source\repos\Athena\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\Athena\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\Athena\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\Athena\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\Athena\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\Athena\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\Athena\_Imports.razor"
using Athena;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\source\repos\Athena\_Imports.razor"
using Athena.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\source\repos\Athena\_Imports.razor"
using Athena.Database.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\source\repos\Athena\_Imports.razor"
using Athena.Database.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\source\repos\Athena\_Imports.razor"
using BlazorContextMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tasks")]
    public partial class Tasks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "athena-dia-background");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h3 class=\"athena-title\">Tarefas</h3>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "athena-list");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 9 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
         if (Tarefas != null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenElement(8, "ul");
            __builder.AddAttribute(9, "class", "list-group list-group-flush");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 12 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                 foreach (var tarefa in Tarefas.Where(x => !x.Finished).OrderByDescending(x => x.Important))
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                    ");
            __builder.OpenElement(12, "li");
            __builder.AddAttribute(13, "class", "athena-dia-list-group list-group-item list-group-item-action");
            __builder.AddAttribute(14, "style", "border-radius: 4px;");
            __builder.AddMarkupContent(15, "\r\n\r\n                        ");
            __builder.OpenComponent<BlazorContextMenu.ContextMenuTrigger>(16);
            __builder.AddAttribute(17, "MenuId", "menuToDo");
            __builder.AddAttribute(18, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 16 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                                                    tarefa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(20, "\r\n\r\n                            ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "custom-control custom-checkbox");
                __builder2.AddMarkupContent(23, "\r\n                                ");
                __builder2.OpenElement(24, "input");
                __builder2.AddAttribute(25, "type", "checkbox");
                __builder2.AddAttribute(26, "id", "ToDoItem_" + (
#nullable restore
#line 19 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                                                     tarefa.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                                                                            e => HandleFinished(tarefa.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "name", "ToDoItem_" + (
#nullable restore
#line 19 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                                                                                                                             tarefa.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "class", "custom-control-input");
                __builder2.AddAttribute(30, "checked", 
#nullable restore
#line 19 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                                                                                                                                                                               tarefa.Finished

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                                ");
                __builder2.OpenElement(32, "label");
                __builder2.AddAttribute(33, "class", "custom-control-label");
                __builder2.AddAttribute(34, "for", "ToDoItem_" + (
#nullable restore
#line 20 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                                                                   tarefa.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(35, 
#nullable restore
#line 20 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                                                                               tarefa.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n");
#nullable restore
#line 21 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                 if (tarefa.DeadLine.HasValue)
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(37, "                                    ");
                __builder2.OpenElement(38, "label");
                __builder2.AddMarkupContent(39, "\r\n                                        &bull;\r\n                                        <i class=\"far fa-calendar\"></i> ");
                __builder2.AddContent(40, 
#nullable restore
#line 25 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                                                         tarefa.ExtenseDeadLine(tarefa.DeadLine.Value)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(41, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n");
#nullable restore
#line 27 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(43, "\r\n");
#nullable restore
#line 29 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                 if (tarefa.Important)
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(44, "                                    ");
                __builder2.OpenElement(45, "i");
                __builder2.AddAttribute(46, "class", "fas fa-star");
                __builder2.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                                                       e => HandleImportant(tarefa.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n");
#nullable restore
#line 32 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(49, "                                    ");
                __builder2.OpenElement(50, "i");
                __builder2.AddAttribute(51, "class", "far fa-star");
                __builder2.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                                                       e => HandleImportant(tarefa.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n");
#nullable restore
#line 36 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(54, "                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
#nullable restore
#line 40 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(58, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
#nullable restore
#line 42 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
            if (Tarefas.Any(x => x.Finished))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(60, "                ");
            __builder.OpenElement(61, "a");
            __builder.AddAttribute(62, "class", "btn athena-dia-finished-button btn-sm");
            __builder.AddAttribute(63, "href", "javascript:;");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                                                                                 e => ShowFinished = !ShowFinished

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(65, "\r\n");
#nullable restore
#line 45 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                     if (ShowFinished)
                    {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(66, "                        <i class=\"fas fa-chevron-down\"></i>\r\n");
#nullable restore
#line 49 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(67, "                        <i class=\"fas fa-chevron-right\"></i>\r\n");
#nullable restore
#line 53 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(68, "                    Concluída\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
#nullable restore
#line 56 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                 if (ShowFinished)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(70, "                    ");
            __builder.OpenElement(71, "ul");
            __builder.AddAttribute(72, "class", "list-group list-group-flush");
            __builder.AddMarkupContent(73, "\r\n");
#nullable restore
#line 59 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                         foreach (var tarefa in Tarefas.Where(x => x.Finished).OrderByDescending(x => x.Important))
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(74, "                            ");
            __builder.OpenElement(75, "li");
            __builder.AddAttribute(76, "class", "athena-dia-list-group list-group-item list-group-item-action");
            __builder.AddAttribute(77, "style", "border-radius: 4px;");
            __builder.AddMarkupContent(78, "\r\n                                ");
            __builder.OpenComponent<BlazorContextMenu.ContextMenuTrigger>(79);
            __builder.AddAttribute(80, "MenuId", "menuToDo");
            __builder.AddAttribute(81, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 62 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                                                            tarefa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(83, "\r\n                                    ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "custom-control custom-checkbox");
                __builder2.AddMarkupContent(86, "\r\n                                        ");
                __builder2.OpenElement(87, "input");
                __builder2.AddAttribute(88, "type", "checkbox");
                __builder2.AddAttribute(89, "id", "ToDoItem_" + (
#nullable restore
#line 64 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                                                             tarefa.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                                                                                    e => HandleFinished(tarefa.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(91, "name", "ToDoItem_" + (
#nullable restore
#line 64 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                                                                                                                                     tarefa.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "class", "custom-control-input");
                __builder2.AddAttribute(93, "checked", 
#nullable restore
#line 64 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                                                                                                                                                                                       tarefa.Finished

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n                                        ");
                __builder2.OpenElement(95, "label");
                __builder2.AddAttribute(96, "class", "custom-control-label");
                __builder2.AddAttribute(97, "for", "ToDoItem_" + (
#nullable restore
#line 65 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                                                                           tarefa.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(98, 
#nullable restore
#line 65 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                                                                                       tarefa.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n");
#nullable restore
#line 66 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                         if (tarefa.DeadLine.HasValue)
                                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(100, "                                            ");
                __builder2.OpenElement(101, "label");
                __builder2.AddMarkupContent(102, "\r\n                                                &bull;\r\n                                                <i class=\"far fa-calendar\"></i> ");
                __builder2.AddContent(103, 
#nullable restore
#line 70 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                                                                 tarefa.ExtenseDeadLine(tarefa.DeadLine.Value)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(104, "\r\n                                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n");
#nullable restore
#line 72 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                        }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(106, "\r\n");
#nullable restore
#line 74 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                         if (tarefa.Important)
                                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(107, "                                            ");
                __builder2.OpenElement(108, "i");
                __builder2.AddAttribute(109, "class", "fas fa-star");
                __builder2.AddAttribute(110, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                                                               e => HandleImportant(tarefa.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n");
#nullable restore
#line 77 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(112, "                                            ");
                __builder2.OpenElement(113, "i");
                __builder2.AddAttribute(114, "class", "far fa-star");
                __builder2.AddAttribute(115, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                                                               e => HandleImportant(tarefa.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n");
#nullable restore
#line 81 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(117, "                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n                                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(119, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n");
#nullable restore
#line 85 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(121, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n");
#nullable restore
#line 87 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                 
            }
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(123, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n    ");
            __builder.OpenElement(125, "div");
            __builder.AddAttribute(126, "class", "container athena-workspace");
            __builder.AddMarkupContent(127, "\r\n        ");
            __builder.OpenElement(128, "div");
            __builder.AddAttribute(129, "class", "input-group");
            __builder.AddMarkupContent(130, "\r\n            ");
            __builder.AddMarkupContent(131, "<div class=\"input-group-prepend\">\r\n                <span class=\"athena-add-input input-group-text\">\r\n                    <i class=\"fas fa-plus\"></i>\r\n                </span>\r\n            </div>\r\n            ");
            __builder.OpenElement(132, "input");
            __builder.AddAttribute(133, "class", "form-control athena-add-input");
            __builder.AddAttribute(134, "placeholder", "Adicionar uma Tarefa");
            __builder.AddAttribute(135, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 98 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                                                                                                                                   HandleKeyPress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(136, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 98 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                                                                                                   TarefaAtual

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(137, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TarefaAtual = __value, TarefaAtual));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(141, "\r\n\r\n");
            __builder.OpenComponent<BlazorContextMenu.ContextMenu>(142);
            __builder.AddAttribute(143, "Id", "menuToDo");
            __builder.AddAttribute(144, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<BlazorContextMenu.MenuRenderingContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(145, "\r\n    ");
                __builder2.OpenComponent<BlazorContextMenu.Item>(146);
                __builder2.AddAttribute(147, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(148, "<i class=\"fas fa-unlink\"></i>Remover de Meu Dia");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(149, "\r\n    ");
                __builder2.OpenComponent<BlazorContextMenu.Item>(150);
                __builder2.AddAttribute(151, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorContextMenu.ItemClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorContextMenu.ItemClickEventArgs>(this, 
#nullable restore
#line 106 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                     e => HandleImportant((e.Data as ToDo).Id)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(152, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(153, "\r\n        <i class=\"far fa-star\"></i> Marcar como Importante\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(154, "\r\n    ");
                __builder2.OpenComponent<BlazorContextMenu.Item>(155);
                __builder2.AddAttribute(156, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorContextMenu.ItemClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorContextMenu.ItemClickEventArgs>(this, 
#nullable restore
#line 109 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                     e => HandleFinished((e.Data as ToDo).Id)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(157, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(158, "<i class=\"far fa-check-circle\"></i> Marcar como Concluída");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(159, "\r\n    ");
                __builder2.OpenComponent<BlazorContextMenu.Seperator>(160);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(161, "\r\n    ");
                __builder2.OpenComponent<BlazorContextMenu.Item>(162);
                __builder2.AddAttribute(163, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorContextMenu.ItemClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorContextMenu.ItemClickEventArgs>(this, 
#nullable restore
#line 111 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                     e => HandleDeadLine((e.Data as ToDo).Id, DateTime.Now)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(164, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(165, "<i class=\"far fa-calendar-check\"></i> Concluir hoje");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(166, "\r\n    ");
                __builder2.OpenComponent<BlazorContextMenu.Item>(167);
                __builder2.AddAttribute(168, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorContextMenu.ItemClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorContextMenu.ItemClickEventArgs>(this, 
#nullable restore
#line 112 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                     e => HandleDeadLine((e.Data as ToDo).Id, DateTime.Now.AddDays(1))

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(169, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(170, "<i class=\"far fa-calendar-minus\"></i> Concluir Amanhã");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(171, "\r\n    ");
                __builder2.OpenComponent<BlazorContextMenu.Item>(172);
                __builder2.AddAttribute(173, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(174, "<i class=\"far fa-calendar-alt\"></i> Escolher uma data");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(175, "\r\n    ");
                __builder2.OpenComponent<BlazorContextMenu.Seperator>(176);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(177, "\r\n    ");
                __builder2.OpenComponent<BlazorContextMenu.Item>(178);
                __builder2.AddAttribute(179, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(180, "<i class=\"fas fa-tasks\"></i> Mover Tarefa Para...");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(181, "\r\n    ");
                __builder2.OpenComponent<BlazorContextMenu.Item>(182);
                __builder2.AddAttribute(183, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorContextMenu.ItemClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorContextMenu.ItemClickEventArgs>(this, 
#nullable restore
#line 116 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
                     e => Delete(e.Data as ToDo)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(184, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(185, "<div style=\"color: red\"><i class=\"far fa-trash-alt\"></i> Excluir Tarefa</div>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(186, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(187, "\r\n\r\n");
            __builder.OpenComponent<BlazorContextMenu.ContextMenu>(188);
            __builder.AddAttribute(189, "Id", "menuData");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 123 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
      
    private bool ShowFinished = true;
    private string TarefaAtual { get; set; }


    protected override void OnInitialized()
    {
        if (toDoController == null) toDoController = new ToDoController(config);
        Tarefas = toDoController.GetAll(true);
    }

    async Task HandleKeyPress(KeyboardEventArgs e)
    {
        if (e.Key == "Enter") Adicionar();
    }

    void Delete(ItemClickEventArgs e)
    {
        Delete(e.Data as ToDo);
    }

    void HandleImportant(ItemClickEventArgs e)
    {
        HandleImportant((e.Data as ToDo).Id);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
