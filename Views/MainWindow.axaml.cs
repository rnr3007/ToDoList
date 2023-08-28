using Avalonia.Controls;
using ToDoList.ViewModels;
using ToDoList.Views.Home;

namespace ToDoList.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        Controller.Content = new HomeView();
    }
}