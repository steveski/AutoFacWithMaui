namespace AutoFacWithMaui;

using Autofac;
using Autofac.Extensions.DependencyInjection;
using Pages;
using Services;
using ViewModels;


public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
    {
        ILifetimeScope autofacContainer = null;

        var builder = MauiApp.CreateBuilder();
		builder
            .UseMauiApp<App>(x => new App(new AutofacServiceProvider(autofacContainer)))  // <<<<<<<<<<<<<<<<<<<<< I'm not sure I should have to do this. Not all apps will need to Service Locate the start page from the App.cs. This was just because of the fact I'm using Flyouts on the AppShell and using viewmodel databinding.
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<AppShellViewModel>();
        builder.Services.AddTransient<MainPageViewModel>();

        builder.Services.AddSingleton<AppShell>();
        builder.Services.AddSingleton<MainPage>();

        //builder.Services.AddTransient<ISomeService, SomeService>();  // <<<<<<<<<<<<<<<<<<<<< Registering the service here will work
        

        // Hook in AutoFac
        var autofacBuilder = new ContainerBuilder();
        autofacBuilder.Populate(builder.Services);

        autofacBuilder.RegisterType<SomeService>().As<SomeService>().InstancePerDependency();  // <<<<<<<<<<<<<<<<<<<<< But the issue I'm trying to resolve is why registration through AutoFac won't work
        autofacContainer = autofacBuilder.Build();
        

        return builder.Build();
	}
}
