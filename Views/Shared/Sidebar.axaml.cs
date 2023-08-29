using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Input;
using ToDoList.Views.Home;
using ToDoList.Views.ToDo;

namespace ToDoList.Views.Shared;

public partial class Sidebar : UserControl
{
    private IClassicDesktopStyleApplicationLifetime desktop { get; }
    
    public Sidebar()
    {
        InitializeComponent();
        desktop = (IClassicDesktopStyleApplicationLifetime)Application.Current.ApplicationLifetime;
    }

    private void GoToHome(object? sender, TappedEventArgs e)
    {
        desktop.MainWindow.Content = new HomeView();
    }

    private void GoToListOfToDo(object? sender, TappedEventArgs e)
    {
        desktop.MainWindow.Content = new ToDoListView();
    }
}