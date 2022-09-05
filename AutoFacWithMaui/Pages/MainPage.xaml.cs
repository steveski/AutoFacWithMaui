namespace AutoFacWithMaui.Pages;

using AutoFacWithMaui.ViewModels;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel viewModel)
    {
        InitializeComponent();
        
        BindingContext = viewModel;

    }

}

