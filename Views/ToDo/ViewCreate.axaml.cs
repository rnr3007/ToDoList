using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using ToDoList.ViewModels.ToDoView;

namespace ToDoList.Views.ToDo;

public partial class ViewCreate : UserControl
{
    public ViewCreate()
    {
        InitializeComponent();
        DataContext = new ToDoCreateVM();
    }

    private void BackToList(object? sender, TappedEventArgs e)
    {
        Content = new ViewList();
    }
}