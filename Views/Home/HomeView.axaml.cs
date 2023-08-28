using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using ToDoList.Views.ToDo;

namespace ToDoList.Views.Home;

public partial class HomeView : UserControl
{
    public HomeView()
    {
        InitializeComponent();
    }

    private void GoToListOfToDo(object? sender, TappedEventArgs e)
    {
        Controller.Content = new ToDoListView();
    }
}