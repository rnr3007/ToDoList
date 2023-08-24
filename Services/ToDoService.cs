using System;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Services;

public class ToDoService
{
    public List<ToDo> GetToDos()
    {
        return new List<ToDo>
        {
            new ToDo("Mandi", new DateTime(2023, 8, 31, 10, 0, 0)),
            new ToDo("Makan", new DateTime(2023, 8, 31, 12, 0, 0))
        };
    }

    public void CreateToDo(string name, DateTime schedule)
    {
        
    }
}