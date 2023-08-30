using System;
using System.Collections.Generic;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Services;

public class ToDoService
{
    public List<ToDo> GetToDos()
    {
        return Storage.SToDo;
    }

    public void CreateToDo(string name, DateTime schedule)
    {
        Storage.SToDo.Add(new ToDo(name, schedule));
    }
}