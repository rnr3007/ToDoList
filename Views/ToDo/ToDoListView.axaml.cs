using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using ToDoList.Services;
using ToDoList.ViewModels.ToDoView;
using ToDoList.Views.Home;

namespace ToDoList.Views.ToDo;

public partial class ToDoListView : UserControl
{
    public ToDoListView()
    {
        InitializeComponent();
        var service = new ToDoService();
        DataContext = new ToDoListVM(service.GetToDos());
        Sidebar.ToDoListNav.Classes.Add("active");
    }

    private void GoToHome(object? sender, RoutedEventArgs e)
    {
    }
}