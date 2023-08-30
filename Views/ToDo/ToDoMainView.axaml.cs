using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using ToDoList.Services;
using ToDoList.ViewModels.ToDoView;
using ToDoList.Views.Home;

namespace ToDoList.Views.ToDo;

public partial class ToDoMainView : UserControl
{
    public ToDoMainView()
    {
        InitializeComponent();
        var service = new ToDoService();
        Sidebar.ToDoListNav.Classes.Add("active");
        ToDoContent.Children.Add(new ViewList());
    }

    private void GoToHome(object? sender, RoutedEventArgs e)
    {
    }
}