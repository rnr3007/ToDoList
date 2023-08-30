using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Input;
using ToDoList.ViewModels.HomeView;
using ToDoList.Views.ToDo;

namespace ToDoList.Views.Home;

public partial class HomeView : UserControl
{
    private IClassicDesktopStyleApplicationLifetime desktop { get; }
    
    public HomeView()
    {
        InitializeComponent();
        desktop = (IClassicDesktopStyleApplicationLifetime)Application.Current.ApplicationLifetime;
        Sidebar.HomeNav.Classes.Add("active");
        // DataContext = new HomeVM();
    }

    private void GoToListOfToDo(object? sender, TappedEventArgs e)
    {
        desktop.MainWindow.Content = new ToDoListView();
    }
}