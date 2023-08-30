using System;
using Avalonia.Media.Imaging;
using ToDoList.Utils;

namespace ToDoList.ViewModels.HomeView;

public class HomeVM
{
    public Bitmap IconPng { get; } = ImageHelper.LoadImage(
        new Uri("avares://ToDoList/Assets/icon.png"));
}

