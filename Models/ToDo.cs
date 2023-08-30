using System;

namespace ToDoList.Models;

public class ToDo
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    
    public string Name { get; set; }
    
    public DateTime Schedule { get; set; }

    public bool IsDone { get; set; } = false;

    public ToDo(){}

    public ToDo(string name, DateTime schedule)
    {
        Name = name;
        Schedule = schedule;
    }
}

