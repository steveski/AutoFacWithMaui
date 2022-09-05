namespace AutoFacWithMaui.ViewModels;

using CommunityToolkit.Mvvm.ComponentModel;

public partial class BaseViewModel : ObservableObject
{
    public BaseViewModel()
    {

    }

    [ObservableProperty]
    //[NotifyPropertyChangedFor(nameof(IsNotBusy))] // Doesn't work in this namespace
    private bool _isBusy;

    [ObservableProperty]
    private string _title;


    //public bool IsNotBusy => !IsBusy;

}
