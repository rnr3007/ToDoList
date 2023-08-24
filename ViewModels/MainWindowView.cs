using System;
using ToDoList.Services;
using ToDoList.ViewModels.ToDoView;

namespace ToDoList.ViewModels;

public class MainWindowView
{
    public ToDoListView ToDoList { get; set; }
    
    public MainWindowView()
    {
        var service = new ToDoService();
        ToDoList = new ToDoListView(service.GetToDos());
    }
}

