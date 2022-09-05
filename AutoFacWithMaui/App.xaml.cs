namespace AutoFacWithMaui;

using Autofac;
using Services;

public partial class App : Application
{
	public App(IServiceProvider serviceProvider)
	{
		InitializeComponent();

        var someService = serviceProvider.GetService<ISomeService>();
        var message = someService.SaySomething();


        MainPage = serviceProvider.GetService<AppShell>();

    }
}
