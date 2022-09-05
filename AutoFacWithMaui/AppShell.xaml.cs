using AutoFacWithMaui.Pages;
using AutoFacWithMaui.Services;
using AutoFacWithMaui.ViewModels;

namespace AutoFacWithMaui;

public partial class AppShell : Shell
{
	public AppShell(AppShellViewModel viewModel)
	{
		InitializeComponent();

        BindingContext = viewModel;
		
    }

}
