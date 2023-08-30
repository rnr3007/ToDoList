using System;
using ToDoList.Models;

namespace ToDoList.ViewModels.ToDoView;

public class ToDoCreateVM : ToDo
{
    public string Error { get; set; }
    
    public ToDoCreateVM(){}
    
    public ToDoCreateVM(string name, DateTime schedule)
    {
        this.Name = name;
        this.Schedule = schedule;
    }
}