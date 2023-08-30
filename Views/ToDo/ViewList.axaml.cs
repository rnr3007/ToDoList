using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using ToDoList.Services;
using ToDoList.ViewModels.ToDoView;

namespace ToDoList.Views.ToDo;

public partial class ViewList : UserControl
{
    public ViewList()
    {
        InitializeComponent();
        var service = new ToDoService();
        DataContext = new ToDoListVM(service.GetToDos());
    }

    private void GoToCreate(object? sender, TappedEventArgs e)
    {
        ToDoContent.Content = new ViewCreate();
    }
}