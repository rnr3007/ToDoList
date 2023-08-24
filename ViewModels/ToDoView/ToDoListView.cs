using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ToDoList.Models;

namespace ToDoList.ViewModels.ToDoView;

public class ToDoListView
{
    public ObservableCollection<ToDo> ToDoList { get; set; } 

    public ToDoListView(IEnumerable<ToDo> toDoList)
    {
        ToDoList = new ObservableCollection<ToDo>(toDoList);
    }
}
