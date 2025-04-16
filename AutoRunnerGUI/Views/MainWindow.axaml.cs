using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AutoRunnerGUI.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        Debug.WriteLine("Click!");
    }
}