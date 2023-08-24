using System;

namespace ToDoList.Models;

public class ToDo
{
    public string Id { get; set; }
    
    public string Name { get; set; }
    
    public DateTime Schedule { get; set; }
    
    public bool IsDone { get; set; }

    public ToDo(string name, DateTime schedule)
    {
        Id = Guid.NewGuid().ToString();
        Name = name;
        Schedule = schedule;
        IsDone = false;
    }
}

