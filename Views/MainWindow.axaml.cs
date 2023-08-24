using Avalonia.Controls;
using ToDoList.ViewModels;

namespace ToDoList.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        var mainWindowView = new MainWindowView();
        DataContext = mainWindowView;
    }
}