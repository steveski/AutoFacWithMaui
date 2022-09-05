using AutoFacWithMaui.Services;

namespace AutoFacWithMaui.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;

public partial class MainPageViewModel : BaseViewModel 
{


    public MainPageViewModel(ISomeService someService)
    {
        Title = "Snoogans";

        _someMessage = someService.SaySomething();

    }

    [ObservableProperty]
    private string _someMessage;


}