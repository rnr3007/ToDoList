using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ToDoList.Models;

namespace ToDoList.ViewModels.ToDoView;

public class ToDoListVM
{
    public ObservableCollection<ToDo> ToDoList { get; set; } 

    public ToDoListVM(IEnumerable<ToDo> toDoList)
    {
        ToDoList = new ObservableCollection<ToDo>(toDoList);
    }
}
