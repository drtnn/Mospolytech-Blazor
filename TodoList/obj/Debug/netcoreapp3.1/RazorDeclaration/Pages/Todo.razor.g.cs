#pragma checksum "/Users/wsmoked/Desktop/dotnet_test/TodoList/Pages/Todo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a064e25f273d7e14a7966b7ecec18f1545176b1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TodoList.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/wsmoked/Desktop/dotnet_test/TodoList/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/wsmoked/Desktop/dotnet_test/TodoList/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/wsmoked/Desktop/dotnet_test/TodoList/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/wsmoked/Desktop/dotnet_test/TodoList/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/wsmoked/Desktop/dotnet_test/TodoList/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/wsmoked/Desktop/dotnet_test/TodoList/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/wsmoked/Desktop/dotnet_test/TodoList/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/wsmoked/Desktop/dotnet_test/TodoList/_Imports.razor"
using TodoList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/wsmoked/Desktop/dotnet_test/TodoList/_Imports.razor"
using TodoList.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "/Users/wsmoked/Desktop/dotnet_test/TodoList/Pages/Todo.razor"
       
    private IList<TodoItem> todos = new List<TodoItem>();
	private string newTodo;
	private int maxID = 0;
    private void AddTodo()
    {
        if (!string.IsNullOrWhiteSpace(newTodo))
        {
            todos.Add(new TodoItem { id = maxID++, Title = newTodo });
            newTodo = string.Empty;
        }
    }
	void Delete(int id)
    {
        todos.Remove(todos.FirstOrDefault(i => i.id == id));
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
